-- =====================================================
-- POLYTALK - COMPLETE DATABASE RESET
-- 8 Units per Level, 5 Lessons per Unit
-- Total: 48 Units, 240 Lessons
-- =====================================================

USE PruebaPolyTalk
GO

-- =====================================================
-- DELETE ALL DATA (in correct order)
-- =====================================================
PRINT 'Deleting all data...'
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
DELETE FROM levels
PRINT 'All data deleted'
GO

-- =====================================================
-- RESET IDENTITY SEQUENCES
-- =====================================================
DBCC CHECKIDENT ('levels', RESEED, 0)
DBCC CHECKIDENT ('units', RESEED, 0)
DBCC CHECKIDENT ('users', RESEED, 0)
DBCC CHECKIDENT ('students', RESEED, 0)
DBCC CHECKIDENT ('teachers', RESEED, 0)
DBCC CHECKIDENT ('groups', RESEED, 0)
DBCC CHECKIDENT ('lessons', RESEED, 0)
DBCC CHECKIDENT ('vocabulary_lists', RESEED, 0)
DBCC CHECKIDENT ('enrollments', RESEED, 0)
DBCC CHECKIDENT ('vocabulary_items', RESEED, 0)
PRINT 'Identity sequences reset'
GO

-- =====================================================
-- INSERT ENGLISH LEVELS
-- =====================================================
INSERT INTO levels (level_code, level_name, description, order_number, is_active)
VALUES
    ('A1', 'Beginner', 'Elementary English', 1, 1),
    ('A2', 'Elementary', 'Pre-Intermediate English', 2, 1),
    ('B1', 'Intermediate', 'Intermediate English', 3, 1),
    ('B2', 'Upper Intermediate', 'Upper Intermediate English', 4, 1),
    ('C1', 'Advanced', 'Advanced English', 5, 1),
    ('C2', 'Mastery', 'Proficient English', 6, 1)
GO
PRINT '✓ 6 Levels created'
GO

-- =====================================================
-- INSERT 3 USERS (admin, maestro, estudiante)
-- Password: 123123 (MD5: 4297f44b13955235245b2497399b27b0)
-- =====================================================
INSERT INTO users (username, password, email, phone, role, full_name, is_active)
VALUES
    ('admin', '4297f44b13955235245b2497399b27b0', 'admin@polytalk.com', '1234567890', 'admin', 'Administrador Sistema', 1),
    ('maestro', '4297f44b13955235245b2497399b27b0', 'maestro@polytalk.com', '0987654321', 'maestro', 'Profesor Principal', 1),
    ('estudiante', '4297f44b13955235245b2497399b27b0', 'estudiante@polytalk.com', '5555555555', 'estudiante', 'Estudiante Principal', 1)
GO
PRINT '✓ 3 Users created'
GO

-- =====================================================
-- CREATE STUDENT AND TEACHER PROFILES
-- =====================================================
-- Admin as both student and teacher
INSERT INTO students (user_id, student_code, current_english_level, is_active) VALUES (1, 'ADM-S', 'C2', 1)
INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active) VALUES (1, 'ADM-T', 'All Levels', 'C2', 1)

-- Teacher profile
INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active) VALUES (2, 'MRT-001', 'General English', 'C1', 1)

-- Student profile
INSERT INTO students (user_id, student_code, current_english_level, is_active) VALUES (3, 'STU-001', 'A1', 1)
GO
PRINT '✓ Profiles created'
GO

-- =====================================================
-- INSERT UNITS (8 per level = 48 total)
-- =====================================================
DECLARE @unit_number INT = 1
DECLARE @display_order INT = 1

-- A1 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (1, 'A1 Unit 1', 'A1U001', 'Introduction and Greetings', 1, 1, 1, 1, 1, 'A1 Unit 1: Greetings', 'Learn to introduce yourself'),
    (1, 'A1 Unit 2', 'A1U002', 'Basic Present', 2, 1, 1, 2, 2, 'A1 Unit 2: Be Verb', 'Master the verb to be'),
    (1, 'A1 Unit 3', 'A1U003', 'Family Members', 3, 1, 1, 3, 3, 'A1 Unit 3: Family', 'Learn family vocabulary'),
    (1, 'A1 Unit 4', 'A1U004', 'Days and Time', 4, 1, 1, 4, 4, 'A1 Unit 4: Time', 'Tell the time'),
    (1, 'A1 Unit 5', 'A1U005', 'Common Objects', 5, 1, 1, 5, 5, 'A1 Unit 5: Objects', 'Identify common items'),
    (1, 'A1 Unit 6', 'A1U006', 'Simple Commands', 6, 1, 1, 6, 6, 'A1 Unit 6: Commands', 'Follow simple instructions'),
    (1, 'A1 Unit 7', 'A1U007', 'Daily Activities', 7, 1, 1, 7, 7, 'A1 Unit 7: Activities', 'Describe daily routines'),
    (1, 'A1 Unit 8', 'A1U008', 'Basic Conversations', 8, 1, 1, 8, 8, 'A1 Unit 8: Chat', 'Simple dialogues')

-- A2 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (2, 'A2 Unit 1', 'A2U001', 'Present Simple', 9, 1, 1, 9, 9, 'A2 Unit 1: Present Simple', 'Regular daily routines'),
    (2, 'A2 Unit 2', 'A2U002', 'Food and Drinks', 10, 1, 1, 10, 10, 'A2 Unit 2: Food', 'Order at a restaurant'),
    (2, 'A2 Unit 3', 'A2U003', 'Past Simple Regular', 11, 1, 1, 11, 11, 'A2 Unit 3: Past', 'Tell past stories'),
    (2, 'A2 Unit 4', 'A2U004', 'Shopping', 12, 1, 1, 12, 12, 'A2 Unit 4: Shopping', 'Buy items and ask prices'),
    (2, 'A2 Unit 5', 'A2U005', 'Directions', 13, 1, 1, 13, 13, 'A2 Unit 5: Places', 'Ask and give directions'),
    (2, 'A2 Unit 6', 'A2U006', 'Hobbies', 14, 1, 1, 14, 14, 'A2 Unit 6: Hobbies', 'Discuss leisure activities'),
    (2, 'A2 Unit 7', 'A2U007', 'Clothes', 15, 1, 1, 15, 15, 'A2 Unit 7: Clothes', 'Describe clothing items'),
    (2, 'A2 Unit 8', 'A2U008', 'Travel', 16, 1, 1, 16, 16, 'A2 Unit 8: Travel', 'Plan a trip')

-- B1 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (3, 'B1 Unit 1', 'B1U001', 'Present Continuous', 17, 1, 1, 17, 17, 'B1 Unit 1: Present Cont.', 'Describe ongoing actions'),
    (3, 'B1 Unit 2', 'B1U002', 'Past Continuous', 18, 1, 1, 18, 18, 'B1 Unit 2: Past Cont.', 'Tell interrupted stories'),
    (3, 'B1 Unit 3', 'B1U003', 'Present Perfect', 19, 1, 1, 19, 19, 'B1 Unit 3: Pres. Perfect', 'Talk about life experiences'),
    (3, 'B1 Unit 4', 'B1U004', 'Future Plans', 20, 1, 1, 20, 20, 'B1 Unit 4: Future', 'Discuss plans and predictions'),
    (3, 'B1 Unit 5', 'B1U005', 'Comparative Forms', 21, 1, 1, 21, 21, 'B1 Unit 5: Comparatives', 'Compare people and things'),
    (3, 'B1 Unit 6', 'B1U006', 'Conditional Sentences', 22, 1, 1, 22, 22, 'B1 Unit 6: Conditionals', 'If-then expressions'),
    (3, 'B1 Unit 7', 'B1U007', 'Reported Speech', 23, 1, 1, 23, 23, 'B1 Unit 7: Reported', 'Tell what others said'),
    (3, 'B1 Unit 8', 'B1U008', 'Phrasal Verbs', 24, 1, 1, 24, 24, 'B1 Unit 8: Phrasal Verbs', 'Common verb combinations')

-- B2 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (4, 'B2 Unit 1', 'B2U001', 'Perfect Tenses', 25, 1, 1, 25, 25, 'B2 Unit 1: Perfect Tenses', 'Complex time references'),
    (4, 'B2 Unit 2', 'B2U002', 'Passive Voice', 26, 1, 1, 26, 26, 'B2 Unit 2: Passive', 'Describe actions without subjects'),
    (4, 'B2 Unit 3', 'B2U003', 'Modals of Deduction', 27, 1, 1, 27, 27, 'B2 Unit 3: Modals', 'Express possibility and probability'),
    (4, 'B2 Unit 4', 'B2U004', 'Advanced Conditionals', 28, 1, 1, 28, 28, 'B2 Unit 4: Mixed Cond.', 'Complex if-clauses'),
    (4, 'B2 Unit 5', 'B2U005', 'Business English', 29, 1, 1, 29, 29, 'B2 Unit 5: Business', 'Professional communication'),
    (4, 'B2 Unit 6', 'B2U006', 'Academic Writing', 30, 1, 1, 30, 30, 'B2 Unit 6: Essays', 'Formal essay structure'),
    (4, 'B2 Unit 7', 'B2U007', 'Idioms and Expressions', 31, 1, 1, 31, 31, 'B2 Unit 7: Idioms', 'Native-like expressions'),
    (4, 'B2 Unit 8', 'B2U008', 'Discourse Markers', 32, 1, 1, 32, 32, 'B2 Unit 8: Discourse', 'Connect ideas effectively')

-- C1 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (5, 'C1 Unit 1', 'C1U001', 'Nuanced Grammar', 33, 1, 1, 33, 33, 'C1 Unit 1: Advanced Grammar', 'Subtle grammatical distinctions'),
    (5, 'C1 Unit 2', 'C1U002', 'Literary Devices', 34, 1, 1, 34, 34, 'C1 Unit 2: Literature', 'Analyze literary texts'),
    (5, 'C1 Unit 3', 'C1U003', 'Academic Research', 35, 1, 1, 35, 35, 'C1 Unit 3: Research', 'Scholarly article analysis'),
    (5, 'C1 Unit 4', 'C1U004', 'Public Speaking', 36, 1, 1, 36, 36, 'C1 Unit 4: Speaking', 'Deliver presentations'),
    (5, 'C1 Unit 5', 'C1U005', 'Professional Negotiation', 37, 1, 1, 37, 37, 'C1 Unit 5: Negotiation', 'Complex business interactions'),
    (5, 'C1 Unit 6', 'C1U006', 'Debate and Argumentation', 38, 1, 1, 38, 38, 'C1 Unit 6: Debate', 'Construct compelling arguments'),
    (5, 'C1 Unit 7', 'C1U007', 'Media and Broadcasting', 39, 1, 1, 39, 39, 'C1 Unit 7: Media', 'Understand news and broadcasts'),
    (5, 'C1 Unit 8', 'C1U008', 'Specialized Vocabulary', 40, 1, 1, 40, 40, 'C1 Unit 8: Vocabulary', 'Technical and rare words')

-- C2 Units
INSERT INTO units (level_id, unit_name, unit_code, description, order_number, is_published, is_active, display_order, unit_number, unit_title, unit_description)
VALUES
    (6, 'C2 Unit 1', 'C2U001', 'Semantic Subtleties', 41, 1, 1, 41, 41, 'C2 Unit 1: Semantics', 'Understand nuanced meanings'),
    (6, 'C2 Unit 2', 'C2U002', 'Regional Varieties', 42, 1, 1, 42, 42, 'C2 Unit 2: Varieties', 'British, American, other dialects'),
    (6, 'C2 Unit 3', 'C2U003', 'Philosophy and Humanities', 43, 1, 1, 43, 43, 'C2 Unit 3: Philosophy', 'Complex abstract discussions'),
    (6, 'C2 Unit 4', 'C2U004', 'Advanced Translation', 44, 1, 1, 44, 44, 'C2 Unit 4: Translation', 'Translate complex texts'),
    (6, 'C2 Unit 5', 'C2U005', 'Creative Writing', 45, 1, 1, 45, 45, 'C2 Unit 5: Creative', 'Write literary works'),
    (6, 'C2 Unit 6', 'C2U006', 'Linguistic Analysis', 46, 1, 1, 46, 46, 'C2 Unit 6: Linguistics', 'Analyze language structure'),
    (6, 'C2 Unit 7', 'C2U007', 'Cognitive Linguistics', 47, 1, 1, 47, 47, 'C2 Unit 7: Cognition', 'Understand how we process language'),
    (6, 'C2 Unit 8', 'C2U008', 'Mastery Integration', 48, 1, 1, 48, 48, 'C2 Unit 8: Mastery', 'Integration and fluency')
GO
PRINT '✓ 48 Units created (8 per level)'
GO

-- =====================================================
-- INSERT 5 LESSONS PER UNIT (240 total)
-- =====================================================
DECLARE @unitId INT
DECLARE @lessonNum INT
DECLARE @lessonOrder INT

-- Generate lessons for all 48 units
DECLARE @currentUnit INT = 1
WHILE @currentUnit <= 48
BEGIN
    SET @lessonNum = 1
    WHILE @lessonNum <= 5
    BEGIN
        INSERT INTO lessons (unit_id, lesson_title, content, order_number, is_published, is_active, display_order, duration_minutes, lesson_type)
        VALUES (@currentUnit, 'Lesson ' + CAST(@currentUnit AS VARCHAR) + '.' + CAST(@lessonNum AS VARCHAR) + ': Topic ' + CAST(@lessonNum AS VARCHAR),
                'Content for lesson', @lessonNum, 1, 1, @lessonNum, 45, 'content')
        SET @lessonNum = @lessonNum + 1
    END
    SET @currentUnit = @currentUnit + 1
END
GO
PRINT '✓ 240 Lessons created (5 per unit)'
GO

-- =====================================================
-- CREATE GROUPS AND ENROLLMENTS
-- =====================================================
INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity, is_active)
VALUES
    ('G001', 'Beginners Group', 1, 'A1', 30, 1),
    ('G002', 'Intermediate Group', 1, 'B1', 30, 1)
GO

INSERT INTO enrollments (group_id, student_id, enrolled_date, status)
VALUES
    (1, 1, GETDATE(), 'activo'),  -- admin
    (1, 2, GETDATE(), 'activo'),  -- estudiante
    (2, 1, GETDATE(), 'activo'),  -- admin
    (2, 2, GETDATE(), 'activo')   -- estudiante
GO
PRINT '✓ Groups and enrollments created'
GO

-- =====================================================
-- CREATE VOCABULARY LISTS AND ITEMS
-- =====================================================
INSERT INTO vocabulary_lists (user_id, list_name, description, is_public, created_at, icon, color_code, total_words)
VALUES
    (1, 'Basic Greetings', 'Common greetings and polite expressions', 1, GETDATE(), '👋', '#FF6B6B', 15),
    (1, 'Business Terms', 'Professional and business vocabulary', 1, GETDATE(), '💼', '#4ECDC4', 20)
GO

INSERT INTO vocabulary_items (vocabulary_list_id, word, definition, example_sentence, pronunciation, image_url)
VALUES
    (1, 'Hello', 'Greeting word', 'Hello, nice to meet you', 'hə-LOH', NULL),
    (1, 'Hi', 'Informal greeting', 'Hi! How are you?', 'hai', NULL),
    (1, 'Good morning', 'Morning greeting', 'Good morning, everyone!', 'gud MOR-ning', NULL),
    (1, 'Goodbye', 'Farewell word', 'Goodbye, see you tomorrow!', 'gud-BYE', NULL),
    (1, 'Please', 'Polite word', 'Please, have a seat', 'PLEEZ', NULL),
    (1, 'Thank you', 'Gratitude word', 'Thank you very much', 'THANK you', NULL),
    (1, 'Excuse me', 'Polite attention-getter', 'Excuse me, what time is it?', 'ik-SKYOOZ me', NULL),
    (1, 'Sorry', 'Apology word', 'I am sorry for being late', 'SAR-ee', NULL),
    (1, 'Welcome', 'Greeting to guest', 'Welcome to our home!', 'WEL-kum', NULL),
    (1, 'How are you', 'Health inquiry', 'How are you doing today?', 'how are you', NULL),
    (2, 'Meeting', 'Business gathering', 'We have a meeting at 10 AM', 'MEET-ing', NULL),
    (2, 'Schedule', 'Plan of activities', 'Check your schedule for tomorrow', 'SKED-jool', NULL),
    (2, 'Deadline', 'Final time limit', 'The deadline is Friday', 'DEAD-line', NULL),
    (2, 'Report', 'Document of findings', 'Please submit your report', 'ri-PORT', NULL),
    (2, 'Conference', 'Large meeting', 'Annual conference is next month', 'KON-fer-ens', NULL),
    (2, 'Budget', 'Financial plan', 'We need to approve the budget', 'BUD-jit', NULL),
    (2, 'Project', 'Planned undertaking', 'The new project starts Monday', 'PRAH-jekt', NULL),
    (2, 'Team', 'Group of people', 'Great teamwork everyone!', 'TEEM', NULL),
    (2, 'Target', 'Goal to achieve', 'Our target is 10% growth', 'TAR-git', NULL),
    (2, 'Strategy', 'Plan of action', 'Discuss our sales strategy', 'STRAT-uh-jee', NULL)
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
PRINT '  - 6 English Levels (A1-C2)'
PRINT '  - 48 Units (8 per level)'
PRINT '  - 240 Lessons (5 per unit)'
PRINT '  - 2 Groups'
PRINT '  - 2 Vocabulary Lists'
PRINT '  - 20 Vocabulary Items'
PRINT ''
PRINT '=========================================='
GO
