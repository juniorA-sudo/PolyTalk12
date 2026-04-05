-- =====================================================
-- ALTER LESSONS TABLE - ADD MISSING COLUMNS
-- =====================================================

USE PruebaPolyTalk
GO

-- Add missing columns if they don't exist
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'lesson_type')
BEGIN
    ALTER TABLE lessons ADD lesson_type NVARCHAR(50) DEFAULT 'content'
    PRINT 'Column lesson_type added'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'is_active')
BEGIN
    ALTER TABLE lessons ADD is_active BIT DEFAULT 1
    PRINT 'Column is_active added'
END
GO

IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'lessons' AND COLUMN_NAME = 'display_order')
BEGIN
    ALTER TABLE lessons ADD display_order INT DEFAULT 1
    PRINT 'Column display_order added'
END
GO

-- Update display_order based on order_number
UPDATE lessons SET display_order = ISNULL(order_number, 1)
GO

PRINT '✓ Lessons table altered successfully'
GO
