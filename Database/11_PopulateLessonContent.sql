USE PruebaPolyTalk
GO

-- =====================================================
-- POPULATE LESSON_CONTENT FOR ALL LESSONS
-- =====================================================
DECLARE @lessonId INT
DECLARE @lessonTitle NVARCHAR(200)
DECLARE @unitId INT

-- Cursor para cada lección
DECLARE lesson_cursor CURSOR FOR
SELECT lesson_id, lesson_title, unit_id FROM lessons WHERE is_active = 1

OPEN lesson_cursor
FETCH NEXT FROM lesson_cursor INTO @lessonId, @lessonTitle, @unitId

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Insert content for each lesson
    INSERT INTO lesson_content (lesson_id, title, explanation, display_order)
    VALUES
        (@lessonId,
         @lessonTitle + ' - Part 1',
         'This is the main explanation for ' + @lessonTitle + '. Learn the key concepts and vocabulary needed for this lesson.',
         1),
        (@lessonId,
         @lessonTitle + ' - Part 2',
         'Additional examples and practice for ' + @lessonTitle + '. Review the grammar rules and common patterns.',
         2),
        (@lessonId,
         @lessonTitle + ' - Part 3',
         'Summary and key points for ' + @lessonTitle + '. Make sure you understand all the concepts before moving to activities.',
         3)

    FETCH NEXT FROM lesson_cursor INTO @lessonId, @lessonTitle, @unitId
END

CLOSE lesson_cursor
DEALLOCATE lesson_cursor

PRINT '✓ Lesson content inserted for all lessons'
GO

-- =====================================================
-- POPULATE LESSON_ACTIVITIES FOR ALL LESSONS
-- =====================================================
DECLARE @lessonId INT
DECLARE @activityCount INT = 0

DECLARE lesson_cursor CURSOR FOR
SELECT lesson_id FROM lessons WHERE is_active = 1

OPEN lesson_cursor
FETCH NEXT FROM lesson_cursor INTO @lessonId

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Activity 1: Multiple Choice
    INSERT INTO lesson_activities (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
        (@lessonId,
         'Multiple Choice',
         'Select the correct answer',
         'What is the correct response for this question?',
         'Option B',
         1)

    -- Activity 2: Fill in the blank
    INSERT INTO lesson_activities (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
        (@lessonId,
         'Fill Blank',
         'Complete the sentence',
         'The _____ is a noun.',
         'word',
         2)

    -- Activity 3: Matching
    INSERT INTO lesson_activities (lesson_id, activity_type, instruction, content, correct_answer, display_order)
    VALUES
        (@lessonId,
         'Matching',
         'Match the words with their definitions',
         'Match 5 words with their correct definitions',
         'All matched correctly',
         3)

    SET @activityCount = @activityCount + 1

    FETCH NEXT FROM lesson_cursor INTO @lessonId
END

CLOSE lesson_cursor
DEALLOCATE lesson_cursor

PRINT '✓ Lesson activities inserted for all lessons (' + CAST(@activityCount AS VARCHAR) + ' lessons with 3 activities each)'
GO

-- =====================================================
-- POPULATE ACTIVITY_OPTIONS FOR ALL ACTIVITIES
-- =====================================================
DECLARE @activityId INT
DECLARE @optionCount INT = 0

DECLARE activity_cursor CURSOR FOR
SELECT activity_id FROM lesson_activities WHERE activity_type = 'Multiple Choice'

OPEN activity_cursor
FETCH NEXT FROM activity_cursor INTO @activityId

WHILE @@FETCH_STATUS = 0
BEGIN
    -- Insert 4 options per activity
    INSERT INTO activity_options (activity_id, option_text, is_correct, display_order)
    VALUES
        (@activityId, 'Option A', 0, 1),
        (@activityId, 'Option B', 1, 2),
        (@activityId, 'Option C', 0, 3),
        (@activityId, 'Option D', 0, 4)

    SET @optionCount = @optionCount + 1

    FETCH NEXT FROM activity_cursor INTO @activityId
END

CLOSE activity_cursor
DEALLOCATE activity_cursor

PRINT '✓ Activity options inserted for all multiple choice activities'
GO

-- =====================================================
-- FINAL SUMMARY
-- =====================================================
DECLARE @contentCount INT = (SELECT COUNT(*) FROM lesson_content)
DECLARE @activityCount INT = (SELECT COUNT(*) FROM lesson_activities)
DECLARE @optionCount INT = (SELECT COUNT(*) FROM activity_options)

PRINT ''
PRINT '=========================================='
PRINT '✓ LESSON CONTENT POPULATED'
PRINT '=========================================='
PRINT 'Lesson Content Records: ' + CAST(@contentCount AS VARCHAR)
PRINT 'Lesson Activities Records: ' + CAST(@activityCount AS VARCHAR)
PRINT 'Activity Options Records: ' + CAST(@optionCount AS VARCHAR)
PRINT '=========================================='
GO
