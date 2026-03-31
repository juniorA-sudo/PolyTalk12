-- =====================================================
-- POLYTALK - COMPLETE TEST DATA
-- =====================================================

USE PruebaPolyTalk
GO

-- =====================================================
-- INSERT USERS
-- =====================================================

-- Admin User
INSERT INTO users (username, email, phone, role, full_name, password, is_active)
VALUES ('admin_poly', 'admin@polytalk.com', '555-0000', 'admin', 'Admin PolyTalk', 'admin123', 1)
GO

-- Teacher Users
INSERT INTO users (username, email, phone, role, full_name, password, is_active)
VALUES
    ('maestro1', 'maestro1@polytalk.com', '555-0101', 'maestro', 'Juan García López', 'maestro123', 1),
    ('maestro2', 'maestro2@polytalk.com', '555-0102', 'maestro', 'María López Rodríguez', 'maestro123', 1),
    ('maestro3', 'maestro3@polytalk.com', '555-0103', 'maestro', 'Carlos Martínez González', 'maestro123', 1)
GO

-- Student Users
INSERT INTO users (username, email, phone, role, full_name, password, is_active)
VALUES
    ('estudiante1', 'estudiante1@polytalk.com', '555-1001', 'estudiante', 'Pedro Rodríguez Silva', 'estudiante123', 1),
    ('estudiante2', 'estudiante2@polytalk.com', '555-1002', 'estudiante', 'Ana González Pérez', 'estudiante123', 1),
    ('estudiante3', 'estudiante3@polytalk.com', '555-1003', 'estudiante', 'Luis Fernández Castro', 'estudiante123', 1),
    ('estudiante4', 'estudiante4@polytalk.com', '555-1004', 'estudiante', 'Sofia Ramírez Torres', 'estudiante123', 1),
    ('estudiante5', 'estudiante5@polytalk.com', '555-1005', 'estudiante', 'Diego Morales Navarro', 'estudiante123', 1),
    ('estudiante6', 'estudiante6@polytalk.com', '555-1006', 'estudiante', 'Isabel Vargas Flores', 'estudiante123', 1)
GO

-- =====================================================
-- INSERT TEACHERS
-- =====================================================

INSERT INTO teachers (user_id, teacher_code, specialization, english_level)
SELECT user_id, 'T001', 'Conversational English & Speaking', 'C1'
FROM users WHERE username = 'maestro1'
GO

INSERT INTO teachers (user_id, teacher_code, specialization, english_level)
SELECT user_id, 'T002', 'Grammar & Writing', 'C2'
FROM users WHERE username = 'maestro2'
GO

INSERT INTO teachers (user_id, teacher_code, specialization, english_level)
SELECT user_id, 'T003', 'Listening & Pronunciation', 'B2'
FROM users WHERE username = 'maestro3'
GO

-- =====================================================
-- INSERT STUDENTS
-- =====================================================

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S001', 'A1' FROM users WHERE username = 'estudiante1'
GO

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S002', 'A2' FROM users WHERE username = 'estudiante2'
GO

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S003', 'B1' FROM users WHERE username = 'estudiante3'
GO

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S004', 'B2' FROM users WHERE username = 'estudiante4'
GO

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S005', 'A1' FROM users WHERE username = 'estudiante5'
GO

INSERT INTO students (user_id, student_code, current_english_level)
SELECT user_id, 'S006', 'B1' FROM users WHERE username = 'estudiante6'
GO

-- =====================================================
-- INSERT UNITS (Organized by level)
-- =====================================================

-- A1 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Basic Greetings & Introductions', 'A1-U01', 'Learn to introduce yourself and greet others', 1, 1
FROM levels WHERE level_code = 'A1'
GO

INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Family & Relationships', 'A1-U02', 'Vocabulary and grammar for talking about family', 2, 1
FROM levels WHERE level_code = 'A1'
GO

-- A2 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Daily Routines & Time', 'A2-U01', 'Discuss daily activities and tell time', 1, 1
FROM levels WHERE level_code = 'A2'
GO

-- B1 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Past Experiences', 'B1-U01', 'Master past tense and share experiences', 1, 1
FROM levels WHERE level_code = 'B1'
GO

INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Future Plans & Ambitions', 'B1-U02', 'Discuss future plans and aspirations', 2, 1
FROM levels WHERE level_code = 'B1'
GO

-- B2 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published)
SELECT level_id, 'Advanced Conversation Topics', 'B2-U01', 'Discuss complex topics and opinions', 1, 1
FROM levels WHERE level_code = 'B2'
GO

-- =====================================================
-- INSERT GROUPS
-- =====================================================

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity)
SELECT 'G001', 'Beginners A1 - Morning Class', teacher_id, 'A1', 25
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro1')
GO

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity)
SELECT 'G002', 'Intermediate B1 - Afternoon Class', teacher_id, 'B1', 25
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro2')
GO

INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity)
SELECT 'G003', 'Advanced B2 - Evening Class', teacher_id, 'B2', 20
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro3')
GO

-- =====================================================
-- INSERT ENROLLMENTS (Enroll students in groups)
-- =====================================================

-- Group G001 (A1) - maestro1
INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G001' AND u.username = 'estudiante1' AND s.user_id = u.user_id
GO

INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G001' AND u.username = 'estudiante5' AND s.user_id = u.user_id
GO

-- Group G002 (B1) - maestro2
INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G002' AND u.username = 'estudiante3' AND s.user_id = u.user_id
GO

INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G002' AND u.username = 'estudiante6' AND s.user_id = u.user_id
GO

-- Group G003 (B2) - maestro3
INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G003' AND u.username = 'estudiante2' AND s.user_id = u.user_id
GO

INSERT INTO enrollments (group_id, student_id, status)
SELECT g.group_id, s.student_id, 'activo'
FROM groups g, students s, users u
WHERE g.group_code = 'G003' AND u.username = 'estudiante4' AND s.user_id = u.user_id
GO

-- =====================================================
-- INSERT LESSONS
-- =====================================================

-- Lessons for A1-U01
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published)
SELECT unit_id, 'Hello! - Learn Basic Greetings', 'Introduction to common greetings and basic responses', 1, 1
FROM units WHERE unit_code = 'A1-U01'
GO

INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published)
SELECT unit_id, 'My Name Is... - Personal Introductions', 'Learn how to introduce yourself and ask names', 2, 1
FROM units WHERE unit_code = 'A1-U01'
GO

-- Lessons for B1-U01
INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published)
SELECT unit_id, 'Last Weekend - Simple Past Review', 'Review simple past tense with real experiences', 1, 1
FROM units WHERE unit_code = 'B1-U01'
GO

-- =====================================================
-- INSERT VOCABULARY LISTS
-- =====================================================

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published)
SELECT u.unit_id, 'Basic Greetings', 'Essential greeting phrases for A1 level', t.teacher_id, 1
FROM units u, teachers t, users us
WHERE u.unit_code = 'A1-U01' AND us.username = 'maestro1' AND t.user_id = us.user_id
GO

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published)
SELECT u.unit_id, 'Family Members', 'Vocabulary for family relationships', t.teacher_id, 1
FROM units u, teachers t, users us
WHERE u.unit_code = 'A1-U02' AND us.username = 'maestro1' AND t.user_id = us.user_id
GO

INSERT INTO vocabulary_lists (unit_id, list_name, description, teacher_id, is_published)
SELECT u.unit_id, 'Past Tense Verbs', 'Common verbs in past tense form', t.teacher_id, 1
FROM units u, teachers t, users us
WHERE u.unit_code = 'B1-U01' AND us.username = 'maestro2' AND t.user_id = us.user_id
GO

-- =====================================================
-- INSERT VOCABULARY ITEMS
-- =====================================================

-- Greetings
INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Hello', 'Hola', 'hə-ˈlō', 1
FROM vocabulary_lists WHERE list_name = 'Basic Greetings'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Good morning', 'Buenos días', 'ˈɡu̇d ˈmȯr-niŋ', 2
FROM vocabulary_lists WHERE list_name = 'Basic Greetings'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Good afternoon', 'Buenas tardes', 'ˈɡu̇d ˌaf-tər-ˈnün', 3
FROM vocabulary_lists WHERE list_name = 'Basic Greetings'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Goodbye', 'Adiós', 'ˌa-də-ˈō(ˌ)s', 4
FROM vocabulary_lists WHERE list_name = 'Basic Greetings'
GO

-- Family Members
INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Mother', 'Madre', 'ˈmə-t͟hər', 1
FROM vocabulary_lists WHERE list_name = 'Family Members'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Father', 'Padre', 'ˈfä-t͟hər', 2
FROM vocabulary_lists WHERE list_name = 'Family Members'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Sister', 'Hermana', 'ˈsis-tər', 3
FROM vocabulary_lists WHERE list_name = 'Family Members'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Brother', 'Hermano', 'ˈbro-t͟hər', 4
FROM vocabulary_lists WHERE list_name = 'Family Members'
GO

-- Past Tense Verbs
INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Went', 'Fue/Iba', 'ˈwent', 1
FROM vocabulary_lists WHERE list_name = 'Past Tense Verbs'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Saw', 'Vi', 'ˈsȯ', 2
FROM vocabulary_lists WHERE list_name = 'Past Tense Verbs'
GO

INSERT INTO vocabulary_items (list_id, english_word, spanish_word, pronunciation, order_number)
SELECT list_id, 'Did', 'Hizo/Hice', 'ˈdid', 3
FROM vocabulary_lists WHERE list_name = 'Past Tense Verbs'
GO

-- =====================================================
-- INSERT TASKS
-- =====================================================

-- Task for Group G001 (A1)
INSERT INTO tasks (title, description, teacher_id, group_id, unit_id, assigned_date, due_date, max_score, submission_type, status)
SELECT 'Write a Simple Introduction',
       'Write 5-7 sentences introducing yourself in English. Include your name, age, and family members.',
       t.teacher_id,
       g.group_id,
       u.unit_id,
       GETDATE(),
       DATEADD(DAY, 7, GETDATE()),
       100,
       'Text',
       'Active'
FROM teachers t, groups g, units u, users us
WHERE us.username = 'maestro1' AND t.user_id = us.user_id
  AND g.group_code = 'G001' AND u.unit_code = 'A1-U01'
GO

-- Task for Group G002 (B1)
INSERT INTO tasks (title, description, teacher_id, group_id, unit_id, assigned_date, due_date, max_score, submission_type, status)
SELECT 'Share a Past Experience',
       'Record or write about a memorable experience from last month. Use past tense verbs.',
       t.teacher_id,
       g.group_id,
       u.unit_id,
       GETDATE(),
       DATEADD(DAY, 10, GETDATE()),
       100,
       'Text',
       'Active'
FROM teachers t, groups g, units u, users us
WHERE us.username = 'maestro2' AND t.user_id = us.user_id
  AND g.group_code = 'G002' AND u.unit_code = 'B1-U01'
GO

-- Task for Group G003 (B2)
INSERT INTO tasks (title, description, teacher_id, group_id, unit_id, assigned_date, due_date, max_score, submission_type, status)
SELECT 'Debate: Technology Impact',
       'Prepare arguments for a debate about the impact of technology on education.',
       t.teacher_id,
       g.group_id,
       u.unit_id,
       GETDATE(),
       DATEADD(DAY, 14, GETDATE()),
       100,
       'Text',
       'Active'
FROM teachers t, groups g, units u, users us
WHERE us.username = 'maestro3' AND t.user_id = us.user_id
  AND g.group_code = 'G003' AND u.unit_code = 'B2-U01'
GO

-- =====================================================
-- INSERT SAMPLE TASK SUBMISSIONS
-- =====================================================

-- Submission from estudiante1 for first task
INSERT INTO task_submissions (task_id, student_id, comment, submitted_at, status, score, feedback)
SELECT t.task_id, s.student_id, 'My introduction text goes here...', DATEADD(DAY, -2, GETDATE()), 'Submitted', NULL, NULL
FROM tasks t, students s, users u
WHERE u.username = 'estudiante1' AND s.user_id = u.user_id
  AND t.title = 'Write a Simple Introduction'
GO

-- =====================================================
-- INSERT LESSON PROGRESS
-- =====================================================

INSERT INTO lesson_progress (student_id, lesson_id, started_at, completed_activities, total_activities, score)
SELECT s.student_id, l.lesson_id, GETDATE(), 8, 10, 85
FROM students s, lessons l, units u, users us
WHERE us.username = 'estudiante1' AND s.user_id = us.user_id
  AND l.lesson_title = 'Hello! - Learn Basic Greetings' AND l.unit_id = u.unit_id AND u.unit_code = 'A1-U01'
GO

-- =====================================================
-- VERIFICATION QUERIES
-- =====================================================

PRINT ''
PRINT '============================================'
PRINT 'TEST DATA INSERTION COMPLETE'
PRINT '============================================'
PRINT ''
PRINT 'Users Inserted:'
PRINT '  - Admin: admin_poly / admin123'
PRINT '  - Teachers: maestro1, maestro2, maestro3 / maestro123'
PRINT '  - Students: estudiante1-6 / estudiante123'
PRINT ''
PRINT 'Data Summary:'
SELECT 'Users' as Entity, COUNT(*) as Count FROM users
UNION ALL
SELECT 'Teachers', COUNT(*) FROM teachers
UNION ALL
SELECT 'Students', COUNT(*) FROM students
UNION ALL
SELECT 'Groups', COUNT(*) FROM groups
UNION ALL
SELECT 'Enrollments', COUNT(*) FROM enrollments
UNION ALL
SELECT 'Units', COUNT(*) FROM units
UNION ALL
SELECT 'Lessons', COUNT(*) FROM lessons
UNION ALL
SELECT 'Vocabulary Lists', COUNT(*) FROM vocabulary_lists
UNION ALL
SELECT 'Vocabulary Items', COUNT(*) FROM vocabulary_items
UNION ALL
SELECT 'Tasks', COUNT(*) FROM tasks
UNION ALL
SELECT 'Task Submissions', COUNT(*) FROM task_submissions
UNION ALL
SELECT 'Lesson Progress', COUNT(*) FROM lesson_progress
GO
