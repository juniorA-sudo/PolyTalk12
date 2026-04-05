-- =====================================================
-- POLYTALK - FINAL COMPLETE DATABASE SCHEMA
-- EVERYTHING NEEDED FOR FULL FUNCTIONALITY
-- =====================================================

IF EXISTS (SELECT * FROM sys.databases WHERE name = 'PruebaPolyTalk')
BEGIN
    ALTER DATABASE PruebaPolyTalk SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE PruebaPolyTalk
END
GO

CREATE DATABASE PruebaPolyTalk
GO

USE PruebaPolyTalk
GO

-- =====================================================
-- 1. USERS TABLE
-- =====================================================
CREATE TABLE users
(
    user_id INT PRIMARY KEY IDENTITY(1,1),
    username NVARCHAR(100) NOT NULL UNIQUE,
    password NVARCHAR(255) NOT NULL,
    email NVARCHAR(150) NOT NULL,
    phone NVARCHAR(20),
    role NVARCHAR(50) NOT NULL, -- 'admin', 'maestro', 'estudiante'
    full_name NVARCHAR(200) NOT NULL,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1
)
GO

-- =====================================================
-- 2. LEVELS TABLE
-- =====================================================
CREATE TABLE levels
(
    level_id INT PRIMARY KEY IDENTITY(1,1),
    level_code NVARCHAR(10) NOT NULL UNIQUE, -- A1, A2, B1, B2, C1, C2
    level_name NVARCHAR(100) NOT NULL,
    description NVARCHAR(500),
    order_number INT,
    display_order INT DEFAULT 1,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE()
)
GO

-- =====================================================
-- 3. UNITS TABLE
-- =====================================================
CREATE TABLE units
(
    unit_id INT PRIMARY KEY IDENTITY(1,1),
    level_id INT NOT NULL,
    unit_name NVARCHAR(200) NOT NULL,
    unit_number INT DEFAULT 1,
    unit_title NVARCHAR(200) NOT NULL,
    unit_code NVARCHAR(50) NOT NULL UNIQUE,
    unit_description NVARCHAR(500),
    description NVARCHAR(500),
    display_order INT DEFAULT 1,
    order_number INT DEFAULT 1,
    is_published BIT DEFAULT 0,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (level_id) REFERENCES levels(level_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 4. STUDENTS TABLE
-- =====================================================
CREATE TABLE students
(
    student_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL UNIQUE,
    student_code NVARCHAR(50) UNIQUE,
    current_english_level NVARCHAR(10), -- A1, A2, B1, B2, C1, C2
    enrollment_date DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 5. TEACHERS TABLE
-- =====================================================
CREATE TABLE teachers
(
    teacher_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL UNIQUE,
    teacher_code NVARCHAR(50) UNIQUE,
    specialization NVARCHAR(200),
    english_level NVARCHAR(10), -- A1, A2, B1, B2, C1, C2
    hire_date DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 6. GROUPS TABLE
-- =====================================================
CREATE TABLE groups
(
    group_id INT PRIMARY KEY IDENTITY(1,1),
    group_code NVARCHAR(50) NOT NULL UNIQUE,
    group_name NVARCHAR(200) NOT NULL,
    teacher_id INT,
    english_level NVARCHAR(10), -- A1, A2, B1, B2, C1, C2
    max_capacity INT DEFAULT 30,
    schedule NVARCHAR(200),
    classroom NVARCHAR(100),
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
)
GO

-- =====================================================
-- 7. ENROLLMENTS TABLE
-- =====================================================
CREATE TABLE enrollments
(
    enrollment_id INT PRIMARY KEY IDENTITY(1,1),
    group_id INT NOT NULL,
    student_id INT NOT NULL,
    enrollment_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50) DEFAULT 'activo', -- activo, completado, abandonado
    FOREIGN KEY (group_id) REFERENCES groups(group_id) ON DELETE CASCADE,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    UNIQUE (group_id, student_id)
)
GO

-- =====================================================
-- 8. LESSONS TABLE
-- =====================================================
CREATE TABLE lessons
(
    lesson_id INT PRIMARY KEY IDENTITY(1,1),
    unit_id INT NOT NULL,
    lesson_title NVARCHAR(200) NOT NULL,
    lesson_number INT DEFAULT 1,
    lesson_description NVARCHAR(500),
    lesson_type NVARCHAR(50) DEFAULT 'content',
    content NVARCHAR(MAX),
    duration_minutes INT DEFAULT 45,
    display_order INT DEFAULT 1,
    order_number INT DEFAULT 1,
    is_published BIT DEFAULT 0,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 9. LESSON_CONTENT TABLE
-- =====================================================
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
GO

-- =====================================================
-- 10. LESSON_ACTIVITIES TABLE
-- =====================================================
CREATE TABLE lesson_activities
(
    activity_id INT PRIMARY KEY IDENTITY(1,1),
    lesson_id INT NOT NULL,
    activity_type NVARCHAR(50), -- Multiple Choice, Fill Blank, Matching
    instruction NVARCHAR(MAX),
    content NVARCHAR(MAX),
    correct_answer NVARCHAR(500),
    audio_url NVARCHAR(500),
    image_url NVARCHAR(500),
    display_order INT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 11. ACTIVITY_OPTIONS TABLE
-- =====================================================
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
GO

-- =====================================================
-- 12. LESSON_PROGRESS TABLE
-- =====================================================
CREATE TABLE lesson_progress
(
    progress_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    lesson_id INT NOT NULL,
    total_activities INT DEFAULT 0,
    completed_activities INT DEFAULT 0,
    score INT DEFAULT 0,
    started_at DATETIME DEFAULT GETDATE(),
    completed_at DATETIME NULL,
    last_reviewed DATETIME,
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE,
    UNIQUE (student_id, lesson_id)
)
GO

-- =====================================================
-- 13. VOCABULARY_LISTS TABLE
-- =====================================================
CREATE TABLE vocabulary_lists
(
    list_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    unit_id INT,
    list_name NVARCHAR(200) NOT NULL,
    description NVARCHAR(500),
    icon NVARCHAR(50) DEFAULT '📚',
    color_code NVARCHAR(20) DEFAULT '#4ECDC4',
    total_words INT DEFAULT 0,
    is_public BIT DEFAULT 0,
    is_published BIT DEFAULT 0,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE SET NULL
)
GO

-- =====================================================
-- 14. VOCABULARY_ITEMS TABLE
-- =====================================================
CREATE TABLE vocabulary_items
(
    item_id INT PRIMARY KEY IDENTITY(1,1),
    vocabulary_list_id INT NOT NULL,
    word NVARCHAR(100) NOT NULL,
    definition NVARCHAR(500),
    example_sentence NVARCHAR(500),
    pronunciation NVARCHAR(200),
    image_url NVARCHAR(500),
    audio_url NVARCHAR(500),
    order_number INT,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (vocabulary_list_id) REFERENCES vocabulary_lists(list_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 15. STUDENT_VOCABULARY TABLE
-- =====================================================
CREATE TABLE student_vocabulary
(
    student_vocab_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    vocabulary_item_id INT NOT NULL,
    learned_date DATETIME DEFAULT GETDATE(),
    mastered BIT DEFAULT 0,
    last_reviewed DATETIME,
    review_count INT DEFAULT 0,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (vocabulary_item_id) REFERENCES vocabulary_items(item_id) ON DELETE CASCADE,
    UNIQUE (student_id, vocabulary_item_id)
)
GO

-- =====================================================
-- 16. TASKS TABLE
-- =====================================================
CREATE TABLE tasks
(
    task_id INT PRIMARY KEY IDENTITY(1,1),
    title NVARCHAR(200) NOT NULL,
    description NVARCHAR(MAX),
    teacher_id INT NOT NULL,
    group_id INT NOT NULL,
    unit_id INT,
    assigned_date DATETIME DEFAULT GETDATE(),
    due_date DATETIME,
    max_score INT DEFAULT 100,
    submission_type NVARCHAR(50) DEFAULT 'Text', -- File, Text, Image, Review
    allow_late BIT DEFAULT 1,
    show_grade BIT DEFAULT 1,
    status NVARCHAR(50) DEFAULT 'Active', -- Active, Expired, Completed, Draft
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id) ON DELETE CASCADE,
    FOREIGN KEY (group_id) REFERENCES groups(group_id) ON DELETE CASCADE,
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE SET NULL
)
GO

-- =====================================================
-- 17. TASK_MATERIALS TABLE
-- =====================================================
CREATE TABLE task_materials
(
    material_id INT PRIMARY KEY IDENTITY(1,1),
    task_id INT NOT NULL,
    file_name NVARCHAR(300) NOT NULL,
    file_path NVARCHAR(500) NOT NULL,
    file_type NVARCHAR(50) DEFAULT 'PDF', -- PDF, Image, Audio, Video, Word
    file_size_kb INT,
    uploaded_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- 18. TASK_SUBMISSIONS TABLE
-- =====================================================
CREATE TABLE task_submissions
(
    submission_id INT PRIMARY KEY IDENTITY(1,1),
    task_id INT NOT NULL,
    student_id INT NOT NULL,
    comment NVARCHAR(MAX),
    file_name NVARCHAR(300),
    file_path NVARCHAR(500),
    submitted_at DATETIME DEFAULT GETDATE(),
    is_late BIT DEFAULT 0,
    status NVARCHAR(50) DEFAULT 'Submitted', -- Submitted, Graded, Reviewed
    score DECIMAL(5,2),
    feedback NVARCHAR(MAX),
    graded_at DATETIME NULL,
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    UNIQUE (task_id, student_id)
)
GO

-- =====================================================
-- ÍNDICES PARA OPTIMIZACIÓN
-- =====================================================
CREATE INDEX idx_users_username ON users(username)
CREATE INDEX idx_users_role ON users(role)
CREATE INDEX idx_users_is_active ON users(is_active)
CREATE INDEX idx_students_user_id ON students(user_id)
CREATE INDEX idx_students_level ON students(current_english_level)
CREATE INDEX idx_teachers_user_id ON teachers(user_id)
CREATE INDEX idx_groups_teacher_id ON groups(teacher_id)
CREATE INDEX idx_groups_level ON groups(english_level)
CREATE INDEX idx_enrollments_group_id ON enrollments(group_id)
CREATE INDEX idx_enrollments_student_id ON enrollments(student_id)
CREATE INDEX idx_lessons_unit_id ON lessons(unit_id)
CREATE INDEX idx_lessons_published ON lessons(is_published)
CREATE INDEX idx_lesson_progress_student_id ON lesson_progress(student_id)
CREATE INDEX idx_lesson_progress_lesson_id ON lesson_progress(lesson_id)
CREATE INDEX idx_vocabulary_lists_user_id ON vocabulary_lists(user_id)
CREATE INDEX idx_vocabulary_lists_unit_id ON vocabulary_lists(unit_id)
CREATE INDEX idx_vocabulary_items_list_id ON vocabulary_items(vocabulary_list_id)
CREATE INDEX idx_student_vocabulary_student_id ON student_vocabulary(student_id)
CREATE INDEX idx_student_vocabulary_item_id ON student_vocabulary(vocabulary_item_id)
CREATE INDEX idx_tasks_teacher_id ON tasks(teacher_id)
CREATE INDEX idx_tasks_group_id ON tasks(group_id)
CREATE INDEX idx_tasks_status ON tasks(status)
CREATE INDEX idx_task_materials_task_id ON task_materials(task_id)
CREATE INDEX idx_task_submissions_task_id ON task_submissions(task_id)
CREATE INDEX idx_task_submissions_student_id ON task_submissions(student_id)
CREATE INDEX idx_task_submissions_status ON task_submissions(status)
GO

-- =====================================================
-- STORED PROCEDURES
-- =====================================================

-- SP: Get vocabulary lists for a user
CREATE PROCEDURE sp_GetUserVocabularyLists
    @UserId INT,
    @IncludePublic BIT = 0
AS
BEGIN
    SELECT
        list_id,
        list_name,
        description,
        unit_id,
        icon,
        color_code,
        total_words,
        is_public,
        is_published,
        is_active,
        created_at,
        (SELECT COUNT(*) FROM vocabulary_items WHERE vocabulary_list_id = vl.list_id) AS item_count
    FROM vocabulary_lists vl
    WHERE user_id = @UserId
        OR (@IncludePublic = 1 AND is_public = 1)
    ORDER BY created_at DESC
END
GO

PRINT '✓ Stored procedures created'
GO

-- =====================================================
-- INSERT DATA - LEVELS
-- =====================================================
INSERT INTO levels (level_code, level_name, description, order_number, display_order, is_active)
VALUES
    ('A1', 'Beginner', 'Elementary English - A1 Level', 1, 1, 1),
    ('A2', 'Elementary', 'Pre-Intermediate English - A2 Level', 2, 2, 1),
    ('B1', 'Intermediate', 'Intermediate English - B1 Level', 3, 3, 1),
    ('B2', 'Upper Intermediate', 'Upper Intermediate English - B2 Level', 4, 4, 1),
    ('C1', 'Advanced', 'Advanced English - C1 Level', 5, 5, 1),
    ('C2', 'Mastery', 'Proficient English - C2 Level', 6, 6, 1)
GO
PRINT '✓ 6 Levels inserted'
GO

-- =====================================================
-- INSERT DATA - USERS (3 usuarios con password "123123")
-- =====================================================
INSERT INTO users (username, password, email, phone, role, full_name, is_active)
VALUES
    ('admin', '123123', 'admin@polytalk.com', '1234567890', 'admin', 'Administrador del Sistema', 1),
    ('maestro', '123123', 'maestro@polytalk.com', '0987654321', 'maestro', 'Profesor Principal', 1),
    ('estudiante', '123123', 'estudiante@polytalk.com', '5555555555', 'estudiante', 'Estudiante Principal', 1)
GO
PRINT '✓ 3 Users inserted'
GO

-- =====================================================
-- INSERT DATA - STUDENT AND TEACHER PROFILES
-- =====================================================
INSERT INTO students (user_id, student_code, current_english_level, is_active)
VALUES
    (1, 'ADM-S001', 'C2', 1),
    (3, 'STU-001', 'A1', 1)
GO

INSERT INTO teachers (user_id, teacher_code, specialization, english_level, is_active)
VALUES
    (1, 'ADM-T001', 'All Levels', 'C2', 1),
    (2, 'MRT-001', 'General English', 'C1', 1)
GO
PRINT '✓ Profiles created'
GO

-- =====================================================
-- INSERT DATA - 8 UNITS PER LEVEL (48 total)
-- =====================================================
DECLARE @unitNum INT = 1

-- A1 Units
INSERT INTO units (level_id, unit_name, unit_number, unit_title, unit_code, unit_description, display_order, order_number, is_published, is_active)
VALUES
    (1, 'Unit 1: Greetings', 1, 'A1 Unit 1: Greetings', 'A1U001', 'Learn to introduce yourself', 1, 1, 1, 1),
    (1, 'Unit 2: Present Simple', 2, 'A1 Unit 2: Be Verb', 'A1U002', 'Master the verb to be', 2, 2, 1, 1),
    (1, 'Unit 3: Family', 3, 'A1 Unit 3: Family', 'A1U003', 'Learn family vocabulary', 3, 3, 1, 1),
    (1, 'Unit 4: Daily Time', 4, 'A1 Unit 4: Time', 'A1U004', 'Tell the time', 4, 4, 1, 1),
    (1, 'Unit 5: Objects', 5, 'A1 Unit 5: Objects', 'A1U005', 'Identify common items', 5, 5, 1, 1),
    (1, 'Unit 6: Commands', 6, 'A1 Unit 6: Commands', 'A1U006', 'Follow instructions', 6, 6, 1, 1),
    (1, 'Unit 7: Activities', 7, 'A1 Unit 7: Activities', 'A1U007', 'Describe daily routines', 7, 7, 1, 1),
    (1, 'Unit 8: Chat', 8, 'A1 Unit 8: Conversations', 'A1U008', 'Simple dialogues', 8, 8, 1, 1),

-- A2 Units
    (2, 'Unit 9: Present Simple', 9, 'A2 Unit 1: Present Simple', 'A2U001', 'Regular daily routines', 9, 1, 1, 1),
    (2, 'Unit 10: Food', 10, 'A2 Unit 2: Food', 'A2U002', 'Order at a restaurant', 10, 2, 1, 1),
    (2, 'Unit 11: Past Simple', 11, 'A2 Unit 3: Past', 'A2U003', 'Tell past stories', 11, 3, 1, 1),
    (2, 'Unit 12: Shopping', 12, 'A2 Unit 4: Shopping', 'A2U004', 'Buy items and ask prices', 12, 4, 1, 1),
    (2, 'Unit 13: Directions', 13, 'A2 Unit 5: Places', 'A2U005', 'Ask and give directions', 13, 5, 1, 1),
    (2, 'Unit 14: Hobbies', 14, 'A2 Unit 6: Hobbies', 'A2U006', 'Discuss leisure activities', 14, 6, 1, 1),
    (2, 'Unit 15: Clothes', 15, 'A2 Unit 7: Clothes', 'A2U007', 'Describe clothing items', 15, 7, 1, 1),
    (2, 'Unit 16: Travel', 16, 'A2 Unit 8: Travel', 'A2U008', 'Plan a trip', 16, 8, 1, 1),

-- B1 Units
    (3, 'Unit 17: Present Continuous', 17, 'B1 Unit 1: Present Cont.', 'B1U001', 'Describe ongoing actions', 17, 1, 1, 1),
    (3, 'Unit 18: Past Continuous', 18, 'B1 Unit 2: Past Cont.', 'B1U002', 'Tell interrupted stories', 18, 2, 1, 1),
    (3, 'Unit 19: Perfect', 19, 'B1 Unit 3: Pres. Perfect', 'B1U003', 'Talk about life experiences', 19, 3, 1, 1),
    (3, 'Unit 20: Future', 20, 'B1 Unit 4: Future', 'B1U004', 'Discuss plans', 20, 4, 1, 1),
    (3, 'Unit 21: Comparatives', 21, 'B1 Unit 5: Comparatives', 'B1U005', 'Compare things', 21, 5, 1, 1),
    (3, 'Unit 22: Conditionals', 22, 'B1 Unit 6: Conditionals', 'B1U006', 'If-then expressions', 22, 6, 1, 1),
    (3, 'Unit 23: Reported', 23, 'B1 Unit 7: Reported', 'B1U007', 'Tell what others said', 23, 7, 1, 1),
    (3, 'Unit 24: Phrasal', 24, 'B1 Unit 8: Phrasal Verbs', 'B1U008', 'Verb combinations', 24, 8, 1, 1),

-- B2 Units
    (4, 'Unit 25: Perfect Tenses', 25, 'B2 Unit 1: Perfect', 'B2U001', 'Complex time', 25, 1, 1, 1),
    (4, 'Unit 26: Passive', 26, 'B2 Unit 2: Passive', 'B2U002', 'Passive constructions', 26, 2, 1, 1),
    (4, 'Unit 27: Modals', 27, 'B2 Unit 3: Modals', 'B2U003', 'Possibility and probability', 27, 3, 1, 1),
    (4, 'Unit 28: Mixed Conditionals', 28, 'B2 Unit 4: Mixed Cond.', 'B2U004', 'Complex if-clauses', 28, 4, 1, 1),
    (4, 'Unit 29: Business', 29, 'B2 Unit 5: Business', 'B2U005', 'Professional communication', 29, 5, 1, 1),
    (4, 'Unit 30: Essays', 30, 'B2 Unit 6: Essays', 'B2U006', 'Formal essay structure', 30, 6, 1, 1),
    (4, 'Unit 31: Idioms', 31, 'B2 Unit 7: Idioms', 'B2U007', 'Native-like expressions', 31, 7, 1, 1),
    (4, 'Unit 32: Discourse', 32, 'B2 Unit 8: Discourse', 'B2U008', 'Connect ideas', 32, 8, 1, 1),

-- C1 Units
    (5, 'Unit 33: Advanced Grammar', 33, 'C1 Unit 1: Grammar', 'C1U001', 'Subtle distinctions', 33, 1, 1, 1),
    (5, 'Unit 34: Literature', 34, 'C1 Unit 2: Literature', 'C1U002', 'Analyze texts', 34, 2, 1, 1),
    (5, 'Unit 35: Research', 35, 'C1 Unit 3: Research', 'C1U003', 'Scholarly articles', 35, 3, 1, 1),
    (5, 'Unit 36: Speaking', 36, 'C1 Unit 4: Speaking', 'C1U004', 'Deliver presentations', 36, 4, 1, 1),
    (5, 'Unit 37: Negotiation', 37, 'C1 Unit 5: Negotiation', 'C1U005', 'Business interactions', 37, 5, 1, 1),
    (5, 'Unit 38: Debate', 38, 'C1 Unit 6: Debate', 'C1U006', 'Construct arguments', 38, 6, 1, 1),
    (5, 'Unit 39: Media', 39, 'C1 Unit 7: Media', 'C1U007', 'News and broadcasts', 39, 7, 1, 1),
    (5, 'Unit 40: Vocabulary', 40, 'C1 Unit 8: Vocabulary', 'C1U008', 'Technical words', 40, 8, 1, 1),

-- C2 Units
    (6, 'Unit 41: Semantics', 41, 'C2 Unit 1: Semantics', 'C2U001', 'Nuanced meanings', 41, 1, 1, 1),
    (6, 'Unit 42: Varieties', 42, 'C2 Unit 2: Varieties', 'C2U002', 'Regional dialects', 42, 2, 1, 1),
    (6, 'Unit 43: Philosophy', 43, 'C2 Unit 3: Philosophy', 'C2U003', 'Abstract discussions', 43, 3, 1, 1),
    (6, 'Unit 44: Translation', 44, 'C2 Unit 4: Translation', 'C2U004', 'Translate texts', 44, 4, 1, 1),
    (6, 'Unit 45: Creative', 45, 'C2 Unit 5: Creative', 'C2U005', 'Literary works', 45, 5, 1, 1),
    (6, 'Unit 46: Linguistics', 46, 'C2 Unit 6: Linguistics', 'C2U006', 'Language structure', 46, 6, 1, 1),
    (6, 'Unit 47: Cognition', 47, 'C2 Unit 7: Cognition', 'C2U007', 'How we process language', 47, 7, 1, 1),
    (6, 'Unit 48: Mastery', 48, 'C2 Unit 8: Mastery', 'C2U008', 'Integration and fluency', 48, 8, 1, 1)
GO
PRINT '✓ 48 Units (8 per level) created'
GO

-- =====================================================
-- INSERT DATA - 5 LESSONS PER UNIT (240 total)
-- =====================================================
DECLARE @unitId INT
DECLARE @lessonNum INT
DECLARE @currentUnit INT = 1

WHILE @currentUnit <= 48
BEGIN
    SET @lessonNum = 1
    WHILE @lessonNum <= 5
    BEGIN
        INSERT INTO lessons (unit_id, lesson_title, lesson_number, lesson_description, lesson_type, duration_minutes, display_order, order_number, is_published, is_active)
        VALUES (@currentUnit,
                'Lesson ' + CAST(@currentUnit AS VARCHAR) + '.' + CAST(@lessonNum AS VARCHAR),
                @lessonNum,
                'Content for lesson ' + CAST(@currentUnit AS VARCHAR) + '.' + CAST(@lessonNum AS VARCHAR),
                'content',
                45,
                @lessonNum,
                @lessonNum,
                1,
                1)
        SET @lessonNum = @lessonNum + 1
    END
    SET @currentUnit = @currentUnit + 1
END
GO
PRINT '✓ 240 Lessons (5 per unit) created'
GO

-- =====================================================
-- INSERT DATA - GROUPS AND ENROLLMENTS
-- =====================================================
INSERT INTO groups (group_code, group_name, teacher_id, english_level, max_capacity, is_active)
VALUES
    ('G001', 'Beginners Group A', 2, 'A1', 30, 1),
    ('G002', 'Intermediate Group B', 2, 'B1', 30, 1)
GO

INSERT INTO enrollments (group_id, student_id, enrollment_date, status)
VALUES
    (1, 1, GETDATE(), 'activo'),  -- admin in group 1
    (1, 2, GETDATE(), 'activo'),  -- estudiante in group 1
    (2, 1, GETDATE(), 'activo'),  -- admin in group 2
    (2, 2, GETDATE(), 'activo')   -- estudiante in group 2
GO
PRINT '✓ Groups and enrollments created'
GO

-- =====================================================
-- INSERT DATA - VOCABULARY LISTS AND ITEMS
-- =====================================================
INSERT INTO vocabulary_lists (user_id, unit_id, list_name, description, icon, color_code, total_words, is_public, is_published, is_active)
VALUES
    (1, 1, 'Basic Greetings', 'Common greetings and polite expressions', '👋', '#FF6B6B', 10, 1, 1, 1),
    (1, 2, 'Business Terms', 'Professional and business vocabulary', '💼', '#4ECDC4', 10, 1, 1, 1)
GO

INSERT INTO vocabulary_items (vocabulary_list_id, word, definition, example_sentence, pronunciation)
VALUES
    (1, 'Hello', 'Greeting word', 'Hello, nice to meet you', 'hə-LOH'),
    (1, 'Hi', 'Informal greeting', 'Hi! How are you?', 'hai'),
    (1, 'Good morning', 'Morning greeting', 'Good morning, everyone!', 'gud MOR-ning'),
    (1, 'Goodbye', 'Farewell word', 'Goodbye, see you tomorrow!', 'gud-BYE'),
    (1, 'Please', 'Polite word', 'Please, have a seat', 'PLEEZ'),
    (1, 'Thank you', 'Gratitude word', 'Thank you very much', 'THANK you'),
    (1, 'Excuse me', 'Get attention', 'Excuse me, what time is it?', 'ik-SKYOOZ me'),
    (1, 'Sorry', 'Apology word', 'I am sorry for being late', 'SAR-ee'),
    (1, 'Welcome', 'Greeting to guest', 'Welcome to our home!', 'WEL-kum'),
    (1, 'How are you', 'Inquiry', 'How are you doing today?', 'how are you'),
    (2, 'Meeting', 'Business gathering', 'We have a meeting at 10 AM', 'MEET-ing'),
    (2, 'Schedule', 'Plan of activities', 'Check your schedule for tomorrow', 'SKED-jool'),
    (2, 'Deadline', 'Final time limit', 'The deadline is Friday', 'DEAD-line'),
    (2, 'Report', 'Document of findings', 'Please submit your report', 'ri-PORT'),
    (2, 'Conference', 'Large meeting', 'Annual conference is next month', 'KON-fer-ens'),
    (2, 'Budget', 'Financial plan', 'We need to approve the budget', 'BUD-jit'),
    (2, 'Project', 'Planned undertaking', 'The new project starts Monday', 'PRAH-jekt'),
    (2, 'Team', 'Group of people', 'Great teamwork everyone!', 'TEEM'),
    (2, 'Target', 'Goal to achieve', 'Our target is 10% growth', 'TAR-git'),
    (2, 'Strategy', 'Plan of action', 'Discuss our sales strategy', 'STRAT-uh-jee')
GO
PRINT '✓ Vocabulary lists and items created'
GO

-- =====================================================
-- INSERT DATA - TASKS AND SUBMISSIONS (examples)
-- =====================================================
INSERT INTO tasks (title, description, teacher_id, group_id, unit_id, assigned_date, due_date, max_score, submission_type, allow_late, show_grade, status)
VALUES
    ('Unit 1 Practice', 'Complete the exercises from Unit 1', 2, 1, 1, GETDATE(), DATEADD(DAY, 7, GETDATE()), 100, 'Text', 1, 1, 'Active'),
    ('Unit 2 Quiz', 'Take the Unit 2 comprehension quiz', 2, 1, 2, GETDATE(), DATEADD(DAY, 3, GETDATE()), 50, 'Text', 1, 1, 'Active'),
    ('Speaking Activity', 'Record a 2-minute conversation', 2, 2, 5, GETDATE(), DATEADD(DAY, 10, GETDATE()), 100, 'File', 1, 1, 'Active')
GO
PRINT '✓ Sample tasks created'
GO

-- =====================================================
-- FINAL SUMMARY
-- =====================================================
PRINT ''
PRINT '=========================================='
PRINT '✓✓✓ DATABASE SETUP COMPLETE ✓✓✓'
PRINT '=========================================='
PRINT ''
PRINT 'DATABASE STRUCTURE:'
PRINT '  • 18 Tables (all required columns)'
PRINT '  • 23+ Indexes'
PRINT '  • 1 Stored Procedure: sp_GetUserVocabularyLists'
PRINT ''
PRINT 'SAMPLE DATA:'
PRINT '  • 6 Levels (A1-C2)'
PRINT '  • 48 Units (8 per level)'
PRINT '  • 240 Lessons (5 per unit)'
PRINT '  • 3 Users: admin, maestro, estudiante'
PRINT '  • 2 Groups with enrollments'
PRINT '  • 2 Vocabulary Lists with 20 items'
PRINT '  • 3 Sample Tasks'
PRINT ''
PRINT 'LOGIN CREDENTIALS:'
PRINT '  • Username: admin / Password: 123123'
PRINT '  • Username: maestro / Password: 123123'
PRINT '  • Username: estudiante / Password: 123123'
PRINT ''
PRINT '=========================================='
GO
