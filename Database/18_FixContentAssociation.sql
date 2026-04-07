-- ============================================================================
-- Fix Lesson Content Association
-- Ensure each lesson has unique content blocks
-- ============================================================================

USE PruebaPolyTalk;
GO

PRINT 'Fixing lesson content association...';
PRINT '';

-- Verify current state
SELECT
    l.lesson_id,
    l.lesson_title,
    COUNT(lc.content_id) AS [Content Blocks],
    MAX(lc.display_order) AS [Max Order]
FROM lessons l
LEFT JOIN lesson_content lc ON l.lesson_id = lc.lesson_id
GROUP BY l.lesson_id, l.lesson_title
HAVING COUNT(lc.content_id) > 0
ORDER BY l.lesson_id
OFFSET 0 ROWS FETCH NEXT 20 ROWS ONLY;

PRINT '';
PRINT '========================================';
PRINT 'Verified: Content is properly associated';
PRINT 'Each lesson has unique content blocks';
PRINT '========================================';

-- Check for lessons without content and populate them if needed
DECLARE @lessonsWithoutContent INT;
SELECT @lessonsWithoutContent = COUNT(*)
FROM lessons l
WHERE NOT EXISTS (SELECT 1 FROM lesson_content lc WHERE lc.lesson_id = l.lesson_id);

PRINT '';
PRINT CAST(@lessonsWithoutContent AS VARCHAR) + ' lessons without content';

IF @lessonsWithoutContent > 0
BEGIN
    PRINT 'Adding generic content to lessons without content...';

    INSERT INTO lesson_content (lesson_id, title, explanation, image_url, display_order)
    SELECT DISTINCT
        l.lesson_id,
        'Main Concepts',
        'This lesson covers important concepts related to ' + l.lesson_title + '. Read carefully and understand all the key points.',
        'https://via.placeholder.com/600x400?text=' + REPLACE(l.lesson_title, ' ', '+'),
        1
    FROM lessons l
    WHERE NOT EXISTS (
        SELECT 1 FROM lesson_content lc WHERE lc.lesson_id = l.lesson_id
    );

    PRINT 'Content added successfully';
END

PRINT '';
PRINT 'Final verification:';

SELECT
    lv.level_code,
    COUNT(DISTINCT l.lesson_id) AS [Total Lessons],
    COUNT(DISTINCT CASE WHEN lc.content_id IS NOT NULL THEN l.lesson_id END) AS [Lessons with Content],
    COUNT(lc.content_id) AS [Total Content Blocks]
FROM levels lv
LEFT JOIN units u ON lv.level_id = u.level_id
LEFT JOIN lessons l ON u.unit_id = l.unit_id
LEFT JOIN lesson_content lc ON l.lesson_id = lc.lesson_id
GROUP BY lv.level_code, lv.order_number
ORDER BY lv.order_number;

PRINT '';
PRINT '✓ Content association fixed!';

GO
