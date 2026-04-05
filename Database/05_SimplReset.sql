-- =====================================================
-- SIMPLE DATABASE RESET
-- =====================================================

USE PruebaPolyTalk
GO

-- Delete in correct order (respecting foreign keys)
DELETE FROM activity_options
DELETE FROM lesson_activities
DELETE FROM lesson_content
DELETE FROM student_vocabulary
DELETE FROM lesson_progress
DELETE FROM task_submissions
DELETE FROM task_materials
DELETE FROM tasks
DELETE FROM vocabulary_items
DELETE FROM vocabulary_lists
DELETE FROM enrollments
DELETE FROM lessons
DELETE FROM units
DELETE FROM groups
DELETE FROM students
DELETE FROM teachers
DELETE FROM users

PRINT 'All data deleted'
GO

-- Reset identity sequences
DECLARE @SQL NVARCHAR(MAX)
SET @SQL = ''
SELECT @SQL = @SQL + 'DBCC CHECKIDENT (''' + TABLE_NAME + ''', RESEED, 0);'
FROM INFORMATION_SCHEMA.TABLES
WHERE TABLE_SCHEMA = 'dbo' AND TABLE_TYPE = 'BASE TABLE'
AND TABLE_NAME IN ('users', 'students', 'teachers', 'groups', 'enrollments',
                   'levels', 'units', 'lessons', 'vocabulary_lists', 'vocabulary_items')

EXEC sp_executesql @SQL

PRINT 'Identity sequences reset'
GO

-- =====================================================
-- INSERT 3 SIMPLE USERS
-- =====================================================

INSERT INTO users (username, email, phone, role, full_name, password, is_active)
VALUES
    ('admin', 'admin@polytalk.com', '555-0000', 'admin', 'Administrador', 'admin123', 1),
    ('maestro', 'maestro@polytalk.com', '555-1000', 'maestro', 'Profesor Inglés', 'maestro123', 1),
    ('estudiante', 'estudiante@polytalk.com', '555-2000', 'estudiante', 'Alumno', 'estudiante123', 1)
GO

PRINT '✓ 3 Users created'
GO

-- =====================================================
-- CREATE TEACHER PROFILE
-- =====================================================

INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active)
VALUES (2, 'T001', 'English Teaching', 'C1', 1)
GO

-- =====================================================
-- CREATE STUDENT PROFILE
-- =====================================================

INSERT INTO students (user_id, student_code, current_english_level, is_active)
VALUES (3, 'S001', 'B1', 1)
GO

-- Admin as both student and teacher
INSERT INTO students (user_id, student_code, current_english_level, is_active)
VALUES (1, 'ADM-S', 'C2', 1)
GO

INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active)
VALUES (1, 'ADM-T', 'All Levels', 'C2', 1)
GO

PRINT '✓ Profiles created'
GO

-- =====================================================
-- CREATE 8 UNITS
-- =====================================================

INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (1, 'Unit 1: Greetings', 'U001', 'Basic greetings', 1, 1, 1, 1, 1, 'Unit 1: Greetings', 'Learn to greet'),
    (1, 'Unit 2: Present Simple', 'U002', 'Present tense', 2, 1, 1, 2, 2, 'Unit 2: Present Simple', 'Master present tense'),
    (2, 'Unit 3: Vocabulary', 'U003', 'Daily vocabulary', 3, 1, 1, 3, 3, 'Unit 3: Vocabulary', 'Common words'),
    (2, 'Unit 4: Past Tense', 'U004', 'Past stories', 4, 1, 1, 4, 4, 'Unit 4: Past Tense', 'Tell stories'),
    (3, 'Unit 5: Conversations', 'U005', 'Intermediate talk', 5, 1, 1, 5, 5, 'Unit 5: Conversations', 'Complex talks'),
    (4, 'Unit 6: Business', 'U006', 'Professional English', 6, 1, 1, 6, 6, 'Unit 6: Business', 'Work English'),
    (5, 'Unit 7: Advanced Reading', 'U007', 'Complex texts', 7, 1, 1, 7, 7, 'Unit 7: Advanced Reading', 'Academic texts'),
    (6, 'Unit 8: Mastery', 'U008', 'Native fluency', 8, 1, 1, 8, 8, 'Unit 8: Mastery', 'Perfect English')
GO

PRINT '✓ 8 Units created'
GO

-- =====================================================
-- CREATE 5 LESSONS PER UNIT (40 total)
-- =====================================================

-- Unit 1 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (1, 'Lesson 1.1: Hello', 'Basic greetings', 1, 1, 1, 1, 45),
    (1, 'Lesson 1.2: Nice to meet you', 'Introductions', 2, 1, 1, 2, 45),
    (1, 'Lesson 1.3: How are you?', 'Asking wellbeing', 3, 1, 1, 3, 45),
    (1, 'Lesson 1.4: Goodbye', 'Farewells', 4, 1, 1, 4, 45),
    (1, 'Lesson 1.5: Small talk', 'Casual conversation', 5, 1, 1, 5, 45)
GO

-- Unit 2 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (2, 'Lesson 2.1: I am', 'Verb to be', 1, 1, 1, 1, 45),
    (2, 'Lesson 2.2: Simple verbs', 'Regular verbs', 2, 1, 1, 2, 45),
    (2, 'Lesson 2.3: Daily routine', 'Habitual actions', 3, 1, 1, 3, 45),
    (2, 'Lesson 2.4: Hobbies', 'Interests', 4, 1, 1, 4, 45),
    (2, 'Lesson 2.5: Work', 'Jobs and professions', 5, 1, 1, 5, 45)
GO

-- Unit 3 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (3, 'Lesson 3.1: Family', 'Family members', 1, 1, 1, 1, 45),
    (3, 'Lesson 3.2: Colors', 'Color vocabulary', 2, 1, 1, 2, 45),
    (3, 'Lesson 3.3: Food', 'Eating vocabulary', 3, 1, 1, 3, 45),
    (3, 'Lesson 3.4: Clothes', 'Clothing items', 4, 1, 1, 4, 45),
    (3, 'Lesson 3.5: Places', 'Location vocabulary', 5, 1, 1, 5, 45)
GO

-- Unit 4 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (4, 'Lesson 4.1: Regular past', 'Past -ed verbs', 1, 1, 1, 1, 45),
    (4, 'Lesson 4.2: Irregular past', 'Irregular forms', 2, 1, 1, 2, 45),
    (4, 'Lesson 4.3: Last weekend', 'Simple story', 3, 1, 1, 3, 45),
    (4, 'Lesson 4.4: Memories', 'Childhood stories', 4, 1, 1, 4, 45),
    (4, 'Lesson 4.5: History', 'Historical events', 5, 1, 1, 5, 45)
GO

-- Unit 5 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (5, 'Lesson 5.1: Restaurant', 'Ordering food', 1, 1, 1, 1, 45),
    (5, 'Lesson 5.2: Hotel', 'Making bookings', 2, 1, 1, 2, 45),
    (5, 'Lesson 5.3: Shopping', 'Asking prices', 3, 1, 1, 3, 45),
    (5, 'Lesson 5.4: Directions', 'Giving instructions', 4, 1, 1, 4, 45),
    (5, 'Lesson 5.5: Problems', 'Solving issues', 5, 1, 1, 5, 45)
GO

-- Unit 6 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (6, 'Lesson 6.1: Meetings', 'Business talks', 1, 1, 1, 1, 45),
    (6, 'Lesson 6.2: Emails', 'Professional writing', 2, 1, 1, 2, 45),
    (6, 'Lesson 6.3: Presentations', 'Public speaking', 3, 1, 1, 3, 45),
    (6, 'Lesson 6.4: Negotiations', 'Bargaining', 4, 1, 1, 4, 45),
    (6, 'Lesson 6.5: Office', 'Workplace English', 5, 1, 1, 5, 45)
GO

-- Unit 7 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (7, 'Lesson 7.1: Academic texts', 'Scholarly articles', 1, 1, 1, 1, 45),
    (7, 'Lesson 7.2: Essays', 'Essay structure', 2, 1, 1, 2, 45),
    (7, 'Lesson 7.3: Research', 'Research papers', 3, 1, 1, 3, 45),
    (7, 'Lesson 7.4: Literature', 'Book analysis', 4, 1, 1, 4, 45),
    (7, 'Lesson 7.5: Critical thinking', 'Analysis skills', 5, 1, 1, 5, 45)
GO

-- Unit 8 lessons
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
VALUES
    (8, 'Lesson 8.1: Idioms', 'Native expressions', 1, 1, 1, 1, 45),
    (8, 'Lesson 8.2: Pronunciation', 'Native accent', 2, 1, 1, 2, 45),
    (8, 'Lesson 8.3: Culture', 'Cultural nuances', 3, 1, 1, 3, 45),
    (8, 'Lesson 8.4: Advanced talk', 'Fluent discussions', 4, 1, 1, 4, 45),
    (8, 'Lesson 8.5: Mastery', 'Final assessment', 5, 1, 1, 5, 45)
GO

PRINT '✓ 40 Lessons created'
GO

-- =====================================================
-- CREATE GROUPS AND ENROLL
-- =====================================================

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity, is_active)
VALUES
    ('G001', 'Beginners Class', 2, 'A1', 30, 1),
    ('G002', 'Intermediate Class', 2, 'B1', 25, 1)
GO

-- Enroll students
INSERT INTO enrollments (group_id, student_id, status, is_active)
VALUES
    (1, 3, 'activo', 1),
    (2, 3, 'activo', 1),
    (1, 1, 'activo', 1),
    (2, 1, 'activo', 1)
GO

PRINT '✓ Groups and enrollments created'
GO

-- =====================================================
-- CREATE VOCABULARY
-- =====================================================

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published, is_active, icon, color_code, total_words)
VALUES
    (1, 'Basic Greetings', 'Essential phrases', 2, 1, 1, '👋', '#FF6B6B', 10),
    (5, 'Business Terms', 'Work vocabulary', 2, 1, 1, '💼', '#4ECDC4', 20)
GO

-- Insert vocabulary items
INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number, is_active)
VALUES
    (1, 'Hello', 'Hola', 'hə-ˈlō', 1, 1),
    (1, 'Goodbye', 'Adiós', 'ɡud-ˈbī', 2, 1),
    (1, 'Please', 'Por favor', 'plēz', 3, 1),
    (1, 'Thank you', 'Gracias', 'θank-yü', 4, 1),
    (1, 'Yes', 'Sí', 'yes', 5, 1),
    (2, 'Meeting', 'Reunión', 'ˈmē-tiŋ', 1, 1),
    (2, 'Project', 'Proyecto', 'prə-ˈjekt', 2, 1),
    (2, 'Deadline', 'Plazo', 'ˈded-līn', 3, 1),
    (2, 'Budget', 'Presupuesto', 'ˈbə-jit', 4, 1),
    (2, 'Report', 'Informe', 'ri-ˈpȯrt', 5, 1)
GO

PRINT '✓ Vocabulary created'
GO

-- =====================================================
-- FINAL SUMMARY
-- =====================================================

PRINT ''
PRINT '=========================================='
PRINT '✓ DATABASE RESET SUCCESSFUL'
PRINT '=========================================='
PRINT ''
PRINT 'USERS (3):'
PRINT '  1. admin / admin123'
PRINT '  2. maestro / maestro123'
PRINT '  3. estudiante / estudiante123'
PRINT ''
PRINT 'STRUCTURE:'
PRINT '  - 8 Units'
PRINT '  - 40 Lessons (5 per unit)'
PRINT '  - 2 Groups'
PRINT '  - 2 Vocabulary Lists'
PRINT '  - 10 Vocabulary Items'
PRINT ''
PRINT '=========================================='
GO
