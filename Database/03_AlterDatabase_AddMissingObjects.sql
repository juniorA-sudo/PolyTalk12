-- =====================================================
-- POLYTALK - ALTER DATABASE TO ADD MISSING COLUMNS
-- =====================================================

USE PruebaPolyTalk
GO

-- =====================================================
-- ADD MISSING COLUMNS TO EXISTING TABLES
-- =====================================================

-- Add display_order to levels table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'levels' AND COLUMN_NAME = 'display_order')
BEGIN
    ALTER TABLE levels ADD display_order INT DEFAULT 0
    PRINT 'Added display_order column to levels table'
END
GO

-- Add missing columns to units table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'units' AND COLUMN_NAME = 'unit_number')
BEGIN
    ALTER TABLE units ADD unit_number NVARCHAR(50)
    PRINT 'Added unit_number column to units table'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'units' AND COLUMN_NAME = 'unit_title')
BEGIN
    ALTER TABLE units ADD unit_title NVARCHAR(200)
    PRINT 'Added unit_title column to units table'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'units' AND COLUMN_NAME = 'unit_description')
BEGIN
    ALTER TABLE units ADD unit_description NVARCHAR(500)
    PRINT 'Added unit_description column to units table'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'units' AND COLUMN_NAME = 'display_order')
BEGIN
    ALTER TABLE units ADD display_order INT DEFAULT 0
    PRINT 'Added display_order column to units table'
END
GO

-- Add missing columns to lessons table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'display_order')
BEGIN
    ALTER TABLE lessons ADD display_order INT DEFAULT 0
    PRINT 'Added display_order column to lessons table'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'duration_minutes')
BEGIN
    ALTER TABLE lessons ADD duration_minutes INT DEFAULT 45
    PRINT 'Added duration_minutes column to lessons table'
END
GO

-- =====================================================
-- CREATE MISSING TABLES
-- =====================================================

-- Lesson Content Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'lesson_content')
BEGIN
    CREATE TABLE lesson_content
    (
        content_id INT PRIMARY KEY IDENTITY(1,1),
        lesson_id INT NOT NULL,
        title NVARCHAR(200),
        explanation NVARCHAR(MAX),
        image_url NVARCHAR(500),
        audio_url NVARCHAR(500),
        display_order INT DEFAULT 0,
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE
    )
    CREATE INDEX idx_lesson_content_lesson_id ON lesson_content(lesson_id)
    PRINT 'Created lesson_content table'
END
GO

-- Lesson Activities Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'lesson_activities')
BEGIN
    CREATE TABLE lesson_activities
    (
        activity_id INT PRIMARY KEY IDENTITY(1,1),
        lesson_id INT NOT NULL,
        activity_type NVARCHAR(50), -- Multiple Choice, Fill Blank, Matching, etc.
        instruction NVARCHAR(MAX),
        content NVARCHAR(MAX),
        correct_answer NVARCHAR(500),
        audio_url NVARCHAR(500),
        image_url NVARCHAR(500),
        display_order INT DEFAULT 0,
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE
    )
    CREATE INDEX idx_lesson_activities_lesson_id ON lesson_activities(lesson_id)
    PRINT 'Created lesson_activities table'
END
GO

-- Activity Options Table
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'activity_options')
BEGIN
    CREATE TABLE activity_options
    (
        option_id INT PRIMARY KEY IDENTITY(1,1),
        activity_id INT NOT NULL,
        option_text NVARCHAR(500),
        is_correct BIT DEFAULT 0,
        display_order INT DEFAULT 0,
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (activity_id) REFERENCES lesson_activities(activity_id) ON DELETE CASCADE
    )
    CREATE INDEX idx_activity_options_activity_id ON activity_options(activity_id)
    PRINT 'Created activity_options table'
END
GO

-- =====================================================
-- CREATE STORED PROCEDURES
-- =====================================================

-- Stored procedure for getting user vocabulary lists
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_GetUserVocabularyLists')
    DROP PROCEDURE sp_GetUserVocabularyLists
GO

CREATE PROCEDURE sp_GetUserVocabularyLists
    @UserId INT
AS
BEGIN
    SELECT
        vl.list_id,
        vl.list_name,
        vl.description,
        u.unit_id,
        u.unit_name,
        vl.is_published,
        vl.created_at,
        COUNT(vi.item_id) AS item_count
    FROM vocabulary_lists vl
    LEFT JOIN units u ON vl.unit_id = u.unit_id
    LEFT JOIN vocabulary_items vi ON vl.list_id = vi.list_id
    WHERE vl.teacher_id = @UserId
    GROUP BY vl.list_id, vl.list_name, vl.description, u.unit_id, u.unit_name, vl.is_published, vl.created_at
    ORDER BY vl.created_at DESC
END
GO

PRINT 'Created sp_GetUserVocabularyLists stored procedure'
GO

-- =====================================================
-- UPDATE EXISTING DATA WITH NEW COLUMNS
-- =====================================================

-- Update units with unit_number and titles
UPDATE units SET unit_number = unit_code, unit_title = unit_name, unit_description = description
WHERE unit_number IS NULL OR unit_title IS NULL
GO

-- Update display_order values
UPDATE levels SET display_order = order_number WHERE display_order = 0
UPDATE units SET display_order = order_number WHERE display_order = 0
UPDATE lessons SET display_order = order_number WHERE display_order = 0
GO

PRINT ''
PRINT '============================================'
PRINT 'DATABASE ALTERATIONS COMPLETE'
PRINT '============================================'
PRINT 'Added missing columns:'
PRINT '  - display_order to levels, units, lessons'
PRINT '  - unit_number, unit_title, unit_description to units'
PRINT '  - duration_minutes to lessons'
PRINT ''
PRINT 'Created missing tables:'
PRINT '  - lesson_content'
PRINT '  - lesson_activities'
PRINT '  - activity_options'
PRINT ''
PRINT 'Created stored procedures:'
PRINT '  - sp_GetUserVocabularyLists'
GO
