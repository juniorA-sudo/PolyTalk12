-- =====================================================
-- DELETE ALL TEST DATA (for resetting database)
-- =====================================================

USE PruebaPolyTalk
GO

-- Disable all constraints temporarily
EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
GO

-- Delete from all tables
DELETE FROM task_submissions
DELETE FROM task_materials
DELETE FROM tasks
DELETE FROM student_vocabulary
DELETE FROM lesson_progress
DELETE FROM vocabulary_items
DELETE FROM vocabulary_lists
DELETE FROM lessons
DELETE FROM group_members
DELETE FROM groups
DELETE FROM students
DELETE FROM teachers
DELETE FROM users

-- Re-enable all constraints
EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'
GO

PRINT 'All data deleted successfully!'
