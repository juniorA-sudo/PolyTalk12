USE PruebaPolyTalk;
GO

PRINT 'Verifying unique lesson content...';
PRINT '';

SELECT TOP 20
    l.lesson_id,
    l.lesson_title,
    COUNT(lc.content_id) AS [Content Blocks],
    SUBSTRING(STRING_AGG(lc.title, ' | '), 1, 150) AS [Content Titles]
FROM lessons l
INNER JOIN units u ON l.unit_id = u.unit_id
INNER JOIN levels lv ON u.level_id = lv.level_id
LEFT JOIN lesson_content lc ON l.lesson_id = lc.lesson_id
WHERE lv.level_code = 'A1'
GROUP BY l.lesson_id, l.lesson_title
ORDER BY l.lesson_id;

PRINT '';
PRINT 'Sample content for a few lessons:';

SELECT
    l.lesson_id,
    l.lesson_title,
    lc.title,
    LEFT(lc.explanation, 100) AS [Explanation Preview]
FROM lessons l
INNER JOIN lesson_content lc ON l.lesson_id = lc.lesson_id
INNER JOIN units u ON l.unit_id = u.unit_id
INNER JOIN levels lv ON u.level_id = lv.level_id
WHERE lv.level_code = 'A1' AND l.lesson_id IN (1, 6, 11, 21, 31)
ORDER BY l.lesson_id, lc.display_order;

PRINT '';
PRINT 'Content statistics:';
SELECT
    lv.level_code,
    lv.level_name,
    COUNT(DISTINCT l.lesson_id) AS [Lessons],
    COUNT(lc.content_id) AS [Total Content Blocks]
FROM levels lv
LEFT JOIN units u ON lv.level_id = u.level_id
LEFT JOIN lessons l ON u.unit_id = l.unit_id
LEFT JOIN lesson_content lc ON l.lesson_id = lc.lesson_id
GROUP BY lv.level_code, lv.level_name, lv.order_number
ORDER BY lv.order_number;

GO
