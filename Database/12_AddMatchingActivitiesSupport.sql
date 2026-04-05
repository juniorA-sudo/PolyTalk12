-- ============================================================================
-- DATABASE MIGRATION: Add Matching Activities and Multimedia Support
-- Purpose: Enable interactive matching/drag-drop activities and media content
-- ============================================================================

USE PruebaPolyTalk;
GO

-- ============================================================================
-- 1. CREATE MATCHING_PAIRS TABLE
-- ============================================================================
-- Stores pairs for matching activities (word-definition, image-text, etc.)

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[matching_pairs]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[matching_pairs]
    (
        [pair_id] INT IDENTITY(1,1) PRIMARY KEY,
        [activity_id] INT NOT NULL,
        [left_item] NVARCHAR(500) NOT NULL,  -- Left side (word, image description, etc.)
        [left_image_url] NVARCHAR(500),      -- Optional image for left item
        [right_item] NVARCHAR(500) NOT NULL, -- Right side (definition, translation, etc.)
        [right_image_url] NVARCHAR(500),     -- Optional image for right item
        [display_order] INT DEFAULT 0,
        [created_at] DATETIME DEFAULT GETDATE(),
        CONSTRAINT [FK_matching_pairs_activity_id] FOREIGN KEY([activity_id])
            REFERENCES [dbo].[lesson_activities]([activity_id]) ON DELETE CASCADE
    );

    CREATE NONCLUSTERED INDEX [idx_matching_pairs_activity_id] ON [dbo].[matching_pairs]([activity_id]);
    PRINT 'Created table: matching_pairs';
END
ELSE
BEGIN
    PRINT 'Table matching_pairs already exists';
END
GO

-- ============================================================================
-- 2. ADD MISSING COLUMNS TO EXISTING TABLES
-- ============================================================================

-- Add video_url to lesson_activities if not exists
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.lesson_activities') AND name = 'video_url')
BEGIN
    ALTER TABLE [dbo].[lesson_activities] ADD [video_url] NVARCHAR(500);
    PRINT 'Added video_url column to lesson_activities';
END

-- Add duration_seconds to lesson_activities for timing feedback
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.lesson_activities') AND name = 'duration_seconds')
BEGIN
    ALTER TABLE [dbo].[lesson_activities] ADD [duration_seconds] INT DEFAULT 60;
    PRINT 'Added duration_seconds column to lesson_activities';
END

-- Add correct_option_count for multi-select activities
IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.lesson_activities') AND name = 'correct_option_count')
BEGIN
    ALTER TABLE [dbo].[lesson_activities] ADD [correct_option_count] INT DEFAULT 1;
    PRINT 'Added correct_option_count column to lesson_activities';
END

GO

-- ============================================================================
-- 3. INSERT SAMPLE MATCHING ACTIVITIES
-- ============================================================================
-- Add matching activities to first 5 lessons as demonstration

-- First, ensure we have activities with type 'matching'
DECLARE @ActivityCounter INT = 1;
DECLARE @LessonId INT;
DECLARE @ActivityId INT;

-- Get first lesson
SELECT TOP 1 @LessonId = lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id;

IF @LessonId IS NOT NULL
BEGIN
    -- Insert a matching activity if not exists
    IF NOT EXISTS (SELECT 1 FROM lesson_activities WHERE lesson_id = @LessonId AND activity_type = 'matching')
    BEGIN
        INSERT INTO lesson_activities
        (lesson_id, activity_type, instruction, content, correct_answer, display_order)
        VALUES
        (@LessonId, 'matching', 'Emparejar las palabras con sus definiciones',
         'Matching Words', 'match_complete', 1);

        SET @ActivityId = @@IDENTITY;

        -- Add sample matching pairs
        INSERT INTO matching_pairs (activity_id, left_item, right_item, display_order)
        VALUES
        (@ActivityId, 'Happy', 'Alegre, contento', 1),
        (@ActivityId, 'Sad', 'Triste', 2),
        (@ActivityId, 'Angry', 'Enojado, furioso', 3),
        (@ActivityId, 'Excited', 'Emocionado, entusiasmado', 4),
        (@ActivityId, 'Tired', 'Cansado', 5);

        PRINT 'Inserted sample matching activity';
    END
END

GO

-- ============================================================================
-- 4. INSERT SAMPLE TRUE/FALSE ACTIVITIES
-- ============================================================================

DECLARE @LessonId2 INT;
DECLARE @ActivityId2 INT;

SELECT TOP 1 @LessonId2 = lesson_id FROM lessons WHERE is_active = 1 ORDER BY lesson_id;

IF @LessonId2 IS NOT NULL
BEGIN
    IF NOT EXISTS (SELECT 1 FROM lesson_activities WHERE lesson_id = @LessonId2 AND activity_type = 'true_false')
    BEGIN
        INSERT INTO lesson_activities
        (lesson_id, activity_type, instruction, content, correct_answer, display_order)
        VALUES
        (@LessonId2, 'true_false', '¿Es correcto o falso?',
         'The capital of France is Paris', 'true', 2),
        (@LessonId2, 'true_false', '¿Es correcto o falso?',
         'English is spoken in Australia', 'true', 3),
        (@LessonId2, 'true_false', '¿Es correcto o falso?',
         'The sun rises in the west', 'false', 4);

        PRINT 'Inserted sample true/false activities';
    END
END

GO

-- ============================================================================
-- 5. UPDATE ACTIVITY_OPTIONS WITH IMAGE SUPPORT
-- ============================================================================
-- Add image_url column to activity_options for image-based choices

IF NOT EXISTS (SELECT * FROM sys.columns WHERE object_id = OBJECT_ID('dbo.activity_options') AND name = 'image_url')
BEGIN
    ALTER TABLE [dbo].[activity_options] ADD [image_url] NVARCHAR(500);
    PRINT 'Added image_url column to activity_options';
END

GO

-- ============================================================================
-- 6. CREATE ACTIVITY_ATTEMPTS TABLE FOR DETAILED TRACKING
-- ============================================================================
-- Track each attempt at an activity for analytics and feedback

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[activity_attempts]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[activity_attempts]
    (
        [attempt_id] INT IDENTITY(1,1) PRIMARY KEY,
        [student_id] INT NOT NULL,
        [activity_id] INT NOT NULL,
        [lesson_id] INT NOT NULL,
        [response_text] NVARCHAR(MAX),
        [is_correct] BIT,
        [time_spent_seconds] INT,
        [attempted_at] DATETIME DEFAULT GETDATE(),
        CONSTRAINT [FK_activity_attempts_student] FOREIGN KEY([student_id])
            REFERENCES [dbo].[students]([student_id]) ON DELETE CASCADE,
        CONSTRAINT [FK_activity_attempts_activity] FOREIGN KEY([activity_id])
            REFERENCES [dbo].[lesson_activities]([activity_id]) ON DELETE CASCADE,
        CONSTRAINT [FK_activity_attempts_lesson] FOREIGN KEY([lesson_id])
            REFERENCES [dbo].[lessons]([lesson_id]) ON DELETE CASCADE
    );

    CREATE NONCLUSTERED INDEX [idx_activity_attempts_student] ON [dbo].[activity_attempts]([student_id]);
    CREATE NONCLUSTERED INDEX [idx_activity_attempts_activity] ON [dbo].[activity_attempts]([activity_id]);
    PRINT 'Created table: activity_attempts for detailed analytics';
END
ELSE
BEGIN
    PRINT 'Table activity_attempts already exists';
END

GO

-- ============================================================================
-- 7. VERIFICATION QUERIES
-- ============================================================================

PRINT '======================== VERIFICATION ========================';
PRINT '';

PRINT 'Tables created/updated:';
SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME IN ('matching_pairs', 'activity_attempts');

PRINT '';
PRINT 'Sample matching activity pairs:';
SELECT TOP 5 mp.pair_id, mp.left_item, mp.right_item, la.content as activity_name
FROM matching_pairs mp
JOIN lesson_activities la ON mp.activity_id = la.activity_id;

PRINT '';
PRINT 'Sample true/false activities:';
SELECT TOP 5 activity_id, activity_type, content FROM lesson_activities WHERE activity_type = 'true_false';

PRINT '';
PRINT '✓ Database migration completed successfully!';
