-- =====================================================
-- ADD MISSING COLUMNS TO LESSONS TABLE
-- =====================================================

USE PruebaPolyTalk
GO

-- Add lesson_description if it doesn't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'lesson_description')
BEGIN
    ALTER TABLE lessons ADD lesson_description NVARCHAR(500) DEFAULT ''
    PRINT 'Column lesson_description added'
END
GO

-- Add lesson_number if it doesn't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'lesson_number')
BEGIN
    ALTER TABLE lessons ADD lesson_number INT DEFAULT 1
    PRINT 'Column lesson_number added'
END
GO

-- Add duration_minutes if it doesn't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'duration_minutes')
BEGIN
    ALTER TABLE lessons ADD duration_minutes INT DEFAULT 45
    PRINT 'Column duration_minutes added'
END
GO

PRINT '✓ All missing columns added to lessons table'
GO
