-- =====================================================
-- POLYTALK - CLEAN DATABASE RESET
-- Simple users: admin, maestro, estudiante (all with 123 password)
-- 8 units with 5 lessons each
-- =====================================================

USE PruebaPolyTalk
GO

-- =====================================================
-- DELETE ALL DATA (Clean slate)
-- =====================================================

EXEC sp_MSForEachTable 'ALTER TABLE ? NOCHECK CONSTRAINT ALL'
GO

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
DELETE FROM group_members
DELETE FROM lessons
DELETE FROM units
DELETE FROM groups
DELETE FROM students
DELETE FROM teachers
DELETE FROM users
DELETE FROM levels

EXEC sp_MSForEachTable 'ALTER TABLE ? WITH CHECK CHECK CONSTRAINT ALL'
GO

-- Reset identity seeds
DBCC CHECKIDENT ('users', RESEED, 1)
DBCC CHECKIDENT ('students', RESEED, 1)
DBCC CHECKIDENT ('teachers', RESEED, 1)
DBCC CHECKIDENT ('groups', RESEED, 1)
DBCC CHECKIDENT ('enrollments', RESEED, 1)
DBCC CHECKIDENT ('levels', RESEED, 1)
DBCC CHECKIDENT ('units', RESEED, 1)
DBCC CHECKIDENT ('lessons', RESEED, 1)
DBCC CHECKIDENT ('vocabulary_lists', RESEED, 1)
DBCC CHECKIDENT ('vocabulary_items', RESEED, 1)

PRINT 'All data deleted'
GO

-- =====================================================
-- INSERT ENGLISH LEVELS
-- =====================================================

INSERT INTO levels (level_code, level_name, description, order_number, is_active, display_order)
VALUES
    ('A1', 'Beginner', 'Elementary proficiency', 1, 1, 1),
    ('A2', 'Elementary', 'Elementary proficiency', 2, 1, 2),
    ('B1', 'Intermediate', 'Intermediate proficiency', 3, 1, 3),
    ('B2', 'Upper Intermediate', 'Upper intermediate proficiency', 4, 1, 4),
    ('C1', 'Advanced', 'Advanced proficiency', 5, 1, 5),
    ('C2', 'Proficiency', 'Mastery proficiency', 6, 1, 6)
GO

PRINT '✓ English levels created'
GO

-- =====================================================
-- CREATE 3 USERS (admin, maestro, estudiante)
-- =====================================================

INSERT INTO users (username, email, phone, role, full_name, password, is_active)
VALUES
    ('admin', 'admin@polytalk.com', '555-0000', 'admin', 'Administrador PolyTalk', 'admin123', 1),
    ('maestro', 'maestro@polytalk.com', '555-0100', 'maestro', 'Profesor de Inglés', 'maestro123', 1),
    ('estudiante', 'estudiante@polytalk.com', '555-1000', 'estudiante', 'Alumno PolyTalk', 'estudiante123', 1)
GO

PRINT '✓ Users created: admin, maestro, estudiante'
GO

-- =====================================================
-- CREATE TEACHER PROFILE
-- =====================================================

INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active)
SELECT user_id, 'T001', 'English Teaching', 'C1', 1
FROM users WHERE username = 'maestro'
GO

PRINT '✓ Teacher profile created'
GO

-- =====================================================
-- CREATE STUDENT PROFILE
-- =====================================================

INSERT INTO students (user_id, student_code, current_english_level, is_active)
SELECT user_id, 'S001', 'B1', 1
FROM users WHERE username = 'estudiante'
GO

-- Also add admin as student and teacher
INSERT INTO students (user_id, student_code, current_english_level, is_active)
SELECT user_id, 'ADMIN-S', 'C2', 1
FROM users WHERE username = 'admin'
GO

INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active)
SELECT user_id, 'ADMIN-T', 'All Levels', 'C2', 1
FROM users WHERE username = 'admin'
GO

PRINT '✓ Student profiles created'
GO

-- =====================================================
-- CREATE 8 UNITS WITH 5 LESSONS EACH
-- =====================================================

-- Unit 1: Basic Greetings and Introductions
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Basic Greetings and Introductions', 'U001', 'Learn to greet and introduce yourself', 1, 1, 1, 1, 'Unit 1', 'Basic Greetings and Introductions', 'Learn to greet and introduce yourself'
FROM levels WHERE level_code = 'A1'
GO

-- Unit 2: Present Simple Tense
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Present Simple Tense', 'U002', 'Master the present simple tense', 2, 1, 1, 2, 'Unit 2', 'Present Simple Tense', 'Master the present simple tense'
FROM levels WHERE level_code = 'A1'
GO

-- Unit 3: Everyday Vocabulary
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Everyday Vocabulary', 'U003', 'Common words and phrases for daily use', 3, 1, 1, 3, 'Unit 3', 'Everyday Vocabulary', 'Common words and phrases for daily use'
FROM levels WHERE level_code = 'A2'
GO

-- Unit 4: Past Tense Stories
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Past Tense Stories', 'U004', 'Tell stories using past tense', 4, 1, 1, 4, 'Unit 4', 'Past Tense Stories', 'Tell stories using past tense'
FROM levels WHERE level_code = 'A2'
GO

-- Unit 5: Intermediate Conversations
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Intermediate Conversations', 'U005', 'Engage in complex conversations', 5, 1, 1, 5, 'Unit 5', 'Intermediate Conversations', 'Engage in complex conversations'
FROM levels WHERE level_code = 'B1'
GO

-- Unit 6: Business English
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Business English', 'U006', 'Professional communication skills', 6, 1, 1, 6, 'Unit 6', 'Business English', 'Professional communication skills'
FROM levels WHERE level_code = 'B1'
GO

-- Unit 7: Advanced Reading and Writing
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Advanced Reading and Writing', 'U007', 'Complex texts and academic writing', 7, 1, 1, 7, 'Unit 7', 'Advanced Reading and Writing', 'Complex texts and academic writing'
FROM levels WHERE level_code = 'B2'
GO

-- Unit 8: Mastery and Fluency
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
SELECT level_id, 'Mastery and Fluency', 'U008', 'Native-like proficiency and expression', 8, 1, 1, 8, 'Unit 8', 'Mastery and Fluency', 'Native-like proficiency and expression'
FROM levels WHERE level_code = 'C1'
GO

PRINT '✓ 8 Units created'
GO

-- =====================================================
-- CREATE 5 LESSONS FOR EACH UNIT (40 lessons total)
-- =====================================================

-- Lessons for Unit 1
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 1.1: Hello and Goodbye', 'Learn basic greetings', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U001'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 1.2: My Name Is...', 'Personal introductions', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U001'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 1.3: Nice to Meet You', 'Meeting people formally', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U001'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 1.4: How Are You?', 'Asking about someone''s wellbeing', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U001'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 1.5: Small Talk', 'Basic conversation starters', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U001'
GO

-- Lessons for Unit 2
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 2.1: I am, You are, He/She is', 'Verb ''to be''', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U002'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 2.2: Simple Present Verbs', 'Regular and irregular verbs', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U002'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 2.3: Daily Routines', 'Talking about everyday activities', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U002'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 2.4: Hobbies and Interests', 'Discussing what you enjoy', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U002'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 2.5: Work and Jobs', 'Describing professions', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U002'
GO

-- Lessons for Unit 3
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 3.1: Family Members', 'Vocabulary for family', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U003'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 3.2: Colors and Numbers', 'Basic vocabulary', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U003'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 3.3: Food and Drinks', 'Vocabulary for eating', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U003'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 3.4: Clothes and Appearance', 'Describing what people wear', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U003'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 3.5: Places in Town', 'Location vocabulary', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U003'
GO

-- Lessons for Unit 4
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 4.1: Past Simple Regular Verbs', 'Verbs ending in -ed', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U004'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 4.2: Irregular Past Verbs', 'Common irregular forms', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U004'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 4.3: My Last Weekend', 'Telling a simple story', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U004'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 4.4: Childhood Memories', 'Talking about the past', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U004'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 4.5: Historical Events', 'Describing past events', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U004'
GO

-- Lessons for Unit 5
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 5.1: Restaurant Conversations', 'Ordering food', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U005'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 5.2: Hotel and Travel', 'Making reservations', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U005'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 5.3: Shopping and Prices', 'Asking about products', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U005'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 5.4: Giving Directions', 'Helping people navigate', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U005'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 5.5: Problem Solving', 'Dealing with difficulties', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U005'
GO

-- Lessons for Unit 6
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 6.1: Business Meetings', 'Professional communication', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U006'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 6.2: Email Writing', 'Professional correspondence', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U006'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 6.3: Presentations', 'Public speaking skills', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U006'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 6.4: Negotiations', 'Bargaining and agreements', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U006'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 6.5: Office Culture', 'Workplace English', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U006'
GO

-- Lessons for Unit 7
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 7.1: Academic Texts', 'Reading scholarly articles', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U007'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 7.2: Essay Writing', 'Structured academic writing', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U007'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 7.3: Research Papers', 'In-depth writing projects', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U007'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 7.4: Literature Analysis', 'Understanding complex texts', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U007'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 7.5: Critical Thinking', 'Analyzing and evaluating ideas', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U007'
GO

-- Lessons for Unit 8
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 8.1: Idioms and Expressions', 'Native-like language', 1, 1, 1, 1, 45
FROM units WHERE unit_code = 'U008'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 8.2: Accent and Pronunciation', 'Sound like a native speaker', 2, 1, 1, 2, 45
FROM units WHERE unit_code = 'U008'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 8.3: Cultural Nuances', 'Understanding subtle meanings', 3, 1, 1, 3, 45
FROM units WHERE unit_code = 'U008'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 8.4: Advanced Conversations', 'Fluent discussion topics', 4, 1, 1, 4, 45
FROM units WHERE unit_code = 'U008'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes)
SELECT unit_id, 'Lesson 8.5: Mastery Review', 'Comprehensive skill assessment', 5, 1, 1, 5, 45
FROM units WHERE unit_code = 'U008'
GO

PRINT '✓ 40 Lessons created (5 per unit)'
GO

-- =====================================================
-- CREATE GROUPS
-- =====================================================

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity, is_active)
SELECT 'G001', 'Beginners Class', teacher_id, 'A1', 30, 1
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro')
GO

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity, is_active)
SELECT 'G002', 'Intermediate Class', teacher_id, 'B1', 25, 1
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro')
GO

PRINT '✓ Groups created'
GO

-- =====================================================
-- ENROLL STUDENTS
-- =====================================================

INSERT INTO enrollments (group_id, student_id, status, is_active)
SELECT g.group_id, s.student_id, 'activo', 1
FROM groups g, students s, users u
WHERE g.group_code = 'G001' AND u.username = 'estudiante' AND s.user_id = u.user_id
GO

INSERT INTO enrollments (group_id, student_id, status, is_active)
SELECT g.group_id, s.student_id, 'activo', 1
FROM groups g, students s, users u
WHERE g.group_code = 'G002' AND u.username = 'estudiante' AND s.user_id = u.user_id
GO

-- Enroll admin in both groups
INSERT INTO enrollments (group_id, student_id, status, is_active)
SELECT g.group_id, s.student_id, 'activo', 1
FROM groups g, students s, users u
WHERE u.username = 'admin' AND s.user_id = u.user_id
GO

PRINT '✓ Students enrolled in groups'
GO

-- =====================================================
-- CREATE VOCABULARY LISTS
-- =====================================================

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published, is_active, icon, color_code, total_words)
SELECT u.unit_id, 'Basic Vocabulary', 'Essential words for Unit 1', t.teacher_id, 1, 1, '📚', '#FF6B6B', 25
FROM units u, teachers t, users us
WHERE u.unit_code = 'U001' AND us.username = 'maestro' AND t.user_id = us.user_id
GO

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published, is_active, icon, color_code, total_words)
SELECT u.unit_id, 'Advanced Vocabulary', 'Complex words for Unit 5', t.teacher_id, 1, 1, '🎓', '#4ECDC4', 40
FROM units u, teachers t, users us
WHERE u.unit_code = 'U005' AND us.username = 'maestro' AND t.user_id = us.user_id
GO

PRINT '✓ Vocabulary lists created'
GO

-- =====================================================
-- INSERT VOCABULARY ITEMS
-- =====================================================

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number, is_active)
SELECT list_id, 'Hello', 'Hola', 'hə-ˈlō', 1, 1 FROM vocabulary_lists WHERE list_name = 'Basic Vocabulary'
UNION ALL
SELECT list_id, 'Goodbye', 'Adiós', 'ˌɡu̇d-ˈbī', 2, 1 FROM vocabulary_lists WHERE list_name = 'Basic Vocabulary'
UNION ALL
SELECT list_id, 'Please', 'Por favor', 'ˈplēz', 3, 1 FROM vocabulary_lists WHERE list_name = 'Basic Vocabulary'
UNION ALL
SELECT list_id, 'Thank you', 'Gracias', 'ˈθaŋk-yə', 4, 1 FROM vocabulary_lists WHERE list_name = 'Basic Vocabulary'
UNION ALL
SELECT list_id, 'Yes', 'Sí', 'ˈyes', 5, 1 FROM vocabulary_lists WHERE list_name = 'Basic Vocabulary'
GO

PRINT '✓ Vocabulary items created'
GO

-- =====================================================
-- SUMMARY
-- =====================================================

PRINT ''
PRINT '=========================================='
PRINT 'DATABASE RESET COMPLETE'
PRINT '=========================================='
PRINT ''
PRINT '✓ Users Created:'
PRINT '  - admin (admin123) - Administrator'
PRINT '  - maestro (maestro123) - Teacher'
PRINT '  - estudiante (estudiante123) - Student'
PRINT ''
PRINT '✓ Structure:'
PRINT '  - 8 Units'
PRINT '  - 40 Lessons (5 per unit)'
PRINT '  - 2 Groups'
PRINT '  - 2 Vocabulary Lists'
PRINT ''
PRINT '✓ Enrollment:'
PRINT '  - Student enrolled in both groups'
PRINT '  - Admin enrolled in all groups'
PRINT ''
PRINT '=========================================='
GO
