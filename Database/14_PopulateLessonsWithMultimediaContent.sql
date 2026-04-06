-- ============================================================================
-- Populate lessons with multimedia content for Duolingo-style experience
-- ============================================================================

USE PruebaPolyTalk;
GO

PRINT 'Starting multimedia content population...';

-- ============================================================================
-- 1. ADD SAMPLE IMAGES AND AUDIO TO LESSONS
-- ============================================================================

-- Update lesson content with images and audio URLs (using placeholder URLs)
UPDATE lesson_content
SET image_url = CASE
    WHEN content_id % 3 = 0 THEN 'https://via.placeholder.com/600x400?text=English+Lesson+' + CAST(content_id AS NVARCHAR(10))
    WHEN content_id % 3 = 1 THEN 'https://images.unsplash.com/photo-1491841573634-28fb1d3ab7da?w=600&h=400'
    ELSE 'https://images.unsplash.com/photo-1454165804606-c3d57bc86b40?w=600&h=400'
END,
audio_url = CASE
    WHEN content_id % 2 = 0 THEN 'file:///audio/lesson_' + CAST(lesson_id AS NVARCHAR(10)) + '_content_' + CAST(content_id AS NVARCHAR(10)) + '.mp3'
    ELSE NULL
END
WHERE lesson_id IN (SELECT TOP 10 lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id);

PRINT '✓ Updated lesson_content with multimedia URLs';

-- ============================================================================
-- 2. ADD MORE VARIED ACTIVITY TYPES TO FIRST 20 LESSONS
-- ============================================================================

DECLARE @LessonId INT;
DECLARE @ActivityId INT;
DECLARE @Counter INT = 0;

DECLARE lesson_cursor CURSOR FOR
SELECT TOP 20 lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id;

OPEN lesson_cursor;
FETCH NEXT FROM lesson_cursor INTO @LessonId;

WHILE @@FETCH_STATUS = 0 AND @Counter < 20
BEGIN
    -- Add a true/false activity to each lesson
    INSERT INTO lesson_activities
    (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
    (@LessonId, 'true_false', '¿Es correcto?',
     'This is a sentence in English', 'true', 2);

    -- Add a matching activity
    INSERT INTO lesson_activities
    (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
    (@LessonId, 'matching', 'Emparejar las palabras con sus significados',
     'Match these vocabulary items', 'match_complete', 3);

    SET @ActivityId = @@IDENTITY;

    -- Add sample matching pairs
    INSERT INTO matching_pairs (activity_id, left_item, right_item, display_order)
    VALUES
    (@ActivityId, 'Hello', 'Hola', 1),
    (@ActivityId, 'Goodbye', 'Adiós', 2),
    (@ActivityId, 'Thank you', 'Gracias', 3);

    -- Add an image-choice activity
    INSERT INTO lesson_activities
    (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
    (@LessonId, 'image_choice', 'Selecciona la imagen correcta',
     'Click the correct picture', 'image_1', 4);

    SET @ActivityId = @@IDENTITY;

    -- Add image options
    INSERT INTO activity_options
    (activity_id, option_text, is_correct, display_order, image_url)
    VALUES
    (@ActivityId, 'Image 1', 1, 1, 'https://via.placeholder.com/120x120?text=Correct'),
    (@ActivityId, 'Image 2', 0, 2, 'https://via.placeholder.com/120x120?text=Wrong1'),
    (@ActivityId, 'Image 3', 0, 3, 'https://via.placeholder.com/120x120?text=Wrong2');

    SET @Counter = @Counter + 1;
    FETCH NEXT FROM lesson_cursor INTO @LessonId;
END;

CLOSE lesson_cursor;
DEALLOCATE lesson_cursor;

PRINT '✓ Added varied activity types to first 20 lessons';

-- ============================================================================
-- 3. UPDATE ACTIVITY AUDIO AND IMAGE URLS
-- ============================================================================

UPDATE lesson_activities
SET
    audio_url = CASE
        WHEN activity_id % 2 = 0 THEN 'file:///audio/activity_' + CAST(activity_id AS NVARCHAR(10)) + '.mp3'
        ELSE NULL
    END,
    image_url = CASE
        WHEN activity_id % 3 = 0 THEN 'https://via.placeholder.com/600x400?text=Activity+' + CAST(activity_id AS NVARCHAR(10))
        WHEN activity_id % 3 = 1 THEN 'https://images.unsplash.com/photo-1516534775068-bb0427b51b37?w=600&h=400'
        ELSE 'https://images.unsplash.com/photo-1516534775068-bb0427b51b37?w=600&h=400'
    END
WHERE lesson_id IN (SELECT TOP 20 lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id);

PRINT '✓ Updated activity_options with image URLs';

-- ============================================================================
-- 4. ADD DURATION AND DIFFICULTY INDICATORS
-- ============================================================================

UPDATE lesson_activities
SET duration_seconds = CASE
    WHEN activity_type = 'matching' THEN 120
    WHEN activity_type = 'true_false' THEN 30
    WHEN activity_type = 'image_choice' THEN 45
    ELSE 60
END
WHERE lesson_id IN (SELECT TOP 20 lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id);

PRINT '✓ Added activity durations';

-- ============================================================================
-- 5. UPDATE VOCABULARY ITEMS WITH IMAGES AND AUDIO
-- ============================================================================

UPDATE list_words
SET
    image_url = 'https://via.placeholder.com/200x200?text=' + REPLACE(word_name, ' ', '+'),
    audio_url = 'file:///audio/vocab_' + CAST(word_id AS NVARCHAR(10)) + '.mp3'
WHERE word_id IN (SELECT TOP 50 word_id FROM list_words ORDER BY word_id);

PRINT '✓ Updated vocabulary items with media URLs';

-- ============================================================================
-- 6. CREATE SAMPLE CONTENT FOR DEMONSTRATION
-- ============================================================================

-- Insert sample lesson content with images and audio for first 5 lessons
DECLARE @LessonIdLoop INT;
DECLARE @Counter2 INT = 0;

DECLARE content_cursor CURSOR FOR
SELECT TOP 5 lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id;

OPEN content_cursor;
FETCH NEXT FROM content_cursor INTO @LessonIdLoop;

WHILE @@FETCH_STATUS = 0
BEGIN
    INSERT INTO lesson_content
    (lesson_id, title, explanation, image_url, audio_url, display_order)
    VALUES
    (@LessonIdLoop, 'Introduction to the Topic',
     'Learn the fundamentals of this lesson with clear examples and explanations.',
     'https://via.placeholder.com/600x400?text=Lesson+Introduction',
     'file:///audio/intro_' + CAST(@LessonIdLoop AS NVARCHAR(10)) + '.mp3', 1),
    (@LessonIdLoop, 'Common Phrases',
     'Here are some common phrases and expressions you will encounter.',
     'https://via.placeholder.com/600x400?text=Common+Phrases',
     'file:///audio/phrases_' + CAST(@LessonIdLoop AS NVARCHAR(10)) + '.mp3', 2),
    (@LessonIdLoop, 'Practice Examples',
     'Practice with these examples before attempting the activities.',
     'https://via.placeholder.com/600x400?text=Practice+Examples',
     'file:///audio/examples_' + CAST(@LessonIdLoop AS NVARCHAR(10)) + '.mp3', 3);

    FETCH NEXT FROM content_cursor INTO @LessonIdLoop;
END;

CLOSE content_cursor;
DEALLOCATE content_cursor;

PRINT '✓ Added comprehensive lesson content';

-- ============================================================================
-- 7. VERIFICATION AND SUMMARY
-- ============================================================================

PRINT '';
PRINT '======================== VERIFICATION ========================';
PRINT '';

PRINT 'Lessons with multimedia content:';
SELECT COUNT(*) AS [Lessons with Images] FROM lesson_content WHERE image_url IS NOT NULL;
SELECT COUNT(*) AS [Lessons with Audio] FROM lesson_content WHERE audio_url IS NOT NULL;
SELECT COUNT(*) AS [Activities with Images] FROM lesson_activities WHERE image_url IS NOT NULL;
SELECT COUNT(*) AS [Activities with Audio] FROM lesson_activities WHERE audio_url IS NOT NULL;

PRINT '';
PRINT 'Activity type distribution:';
SELECT activity_type, COUNT(*) AS quantity FROM lesson_activities GROUP BY activity_type;

PRINT '';
PRINT 'Matching activities created:';
SELECT COUNT(*) AS [Matching Pair Count] FROM matching_pairs;

PRINT '';
PRINT '✓ Multimedia content population completed successfully!';
PRINT '';
PRINT 'Summary:';
PRINT '- Added varied activity types (true_false, matching, image_choice)';
PRINT '- Populated lessons with images and audio URLs';
PRINT '- Created matching pair activities';
PRINT '- Updated vocabulary items with multimedia';
PRINT '- Set activity durations for better UX';
GO
