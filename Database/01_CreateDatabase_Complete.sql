-- =====================================================
-- POLYTALK - COMPLETE DATABASE SCHEMA
-- SQL Server - PruebaPolyTalk Database
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
-- USERS TABLE (Base para todos los roles)
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
-- LEVELS TABLE
-- =====================================================
CREATE TABLE levels
(
    level_id INT PRIMARY KEY IDENTITY(1,1),
    level_code NVARCHAR(10) NOT NULL UNIQUE, -- A1, A2, B1, B2, C1, C2
    level_name NVARCHAR(100) NOT NULL,
    description NVARCHAR(500),
    order_number INT,
    is_active BIT DEFAULT 1,
    created_at DATETIME DEFAULT GETDATE()
)
GO

-- =====================================================
-- UNITS TABLE (Organized by level)
-- =====================================================
CREATE TABLE units
(
    unit_id INT PRIMARY KEY IDENTITY(1,1),
    level_id INT NOT NULL,
    unit_name NVARCHAR(200) NOT NULL,
    unit_code NVARCHAR(50) NOT NULL UNIQUE,
    description NVARCHAR(500),
    order_number INT,
    is_published BIT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (level_id) REFERENCES levels(level_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- STUDENTS TABLE
-- =====================================================
CREATE TABLE students
(
    student_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL UNIQUE,
    student_code NVARCHAR(50) UNIQUE,
    current_english_level NVARCHAR(10), -- A1, A2, B1, B2, C1, C2
    enrollment_date DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- TEACHERS TABLE
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
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- GROUPS TABLE
-- =====================================================
CREATE TABLE groups
(
    group_id INT PRIMARY KEY IDENTITY(1,1),
    group_code NVARCHAR(50) NOT NULL UNIQUE,
    group_name NVARCHAR(200) NOT NULL,
    teacher_id INT,
    english_level NVARCHAR(10), -- A1, A2, B1, B2, C1, C2
    max_capacity INT DEFAULT 30,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
)
GO

-- =====================================================
-- ENROLLMENTS (Student Enrollments in Groups)
-- =====================================================
CREATE TABLE enrollments
(
    enrollment_id INT PRIMARY KEY IDENTITY(1,1),
    group_id INT NOT NULL,
    student_id INT NOT NULL,
    enrolled_date DATETIME DEFAULT GETDATE(),
    status NVARCHAR(50) DEFAULT 'activo', -- activo, completado, abandonado
    FOREIGN KEY (group_id) REFERENCES groups(group_id) ON DELETE CASCADE,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    UNIQUE (group_id, student_id)
)
GO

-- =====================================================
-- LESSONS TABLE
-- =====================================================
CREATE TABLE lessons
(
    lesson_id INT PRIMARY KEY IDENTITY(1,1),
    unit_id INT NOT NULL,
    lesson_title NVARCHAR(200) NOT NULL,
    content NVARCHAR(MAX),
    order_number INT,
    is_published BIT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- LESSON PROGRESS TABLE
-- =====================================================
CREATE TABLE lesson_progress
(
    progress_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    lesson_id INT NOT NULL,
    started_at DATETIME DEFAULT GETDATE(),
    completed_at DATETIME NULL,
    completed_activities INT DEFAULT 0,
    total_activities INT,
    score INT DEFAULT 0,
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE,
    UNIQUE (student_id, lesson_id)
)
GO

-- =====================================================
-- VOCABULARY LISTS TABLE
-- =====================================================
CREATE TABLE vocabulary_lists
(
    list_id INT PRIMARY KEY IDENTITY(1,1),
    unit_id INT,
    list_name NVARCHAR(200) NOT NULL,
    description NVARCHAR(500),
    teacher_id INT,
    is_published BIT DEFAULT 0,
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE SET NULL,
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id) ON DELETE SET NULL
)
GO

-- =====================================================
-- VOCABULARY ITEMS TABLE
-- =====================================================
CREATE TABLE vocabulary_items
(
    item_id INT PRIMARY KEY IDENTITY(1,1),
    list_id INT NOT NULL,
    english_word NVARCHAR(100) NOT NULL,
    spanish_word NVARCHAR(100) NOT NULL,
    pronunciation NVARCHAR(200),
    image_url NVARCHAR(500),
    order_number INT,
    created_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (list_id) REFERENCES vocabulary_lists(list_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- STUDENT VOCABULARY (Track mastered words)
-- =====================================================
CREATE TABLE student_vocabulary
(
    student_vocab_id INT PRIMARY KEY IDENTITY(1,1),
    student_id INT NOT NULL,
    vocabulary_item_id INT NOT NULL,
    learned_date DATETIME DEFAULT GETDATE(),
    mastered BIT DEFAULT 0,
    last_reviewed DATETIME NULL,
    review_count INT DEFAULT 0,
    FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
    FOREIGN KEY (vocabulary_item_id) REFERENCES vocabulary_items(item_id) ON DELETE CASCADE,
    UNIQUE (student_id, vocabulary_item_id)
)
GO

-- =====================================================
-- TASKS TABLE
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
    submission_type NVARCHAR(50), -- File, Text, Image, Review
    allow_late BIT DEFAULT 1,
    show_grade BIT DEFAULT 1,
    status NVARCHAR(50) DEFAULT 'Active', -- Active, Expired, Completed, Draft
    created_at DATETIME DEFAULT GETDATE(),
    updated_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id),
    FOREIGN KEY (group_id) REFERENCES groups(group_id) ON DELETE CASCADE,
    FOREIGN KEY (unit_id) REFERENCES units(unit_id) ON DELETE SET NULL
)
GO

-- =====================================================
-- TASK MATERIALS (Attachments)
-- =====================================================
CREATE TABLE task_materials
(
    material_id INT PRIMARY KEY IDENTITY(1,1),
    task_id INT NOT NULL,
    file_name NVARCHAR(300) NOT NULL,
    file_path NVARCHAR(500) NOT NULL,
    file_type NVARCHAR(50), -- PDF, Image, Audio, Video, Word
    file_size_kb INT,
    uploaded_at DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE
)
GO

-- =====================================================
-- TASK SUBMISSIONS (Student submissions)
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
-- CREATE INDEXES
-- =====================================================
CREATE INDEX idx_users_username ON users(username)
CREATE INDEX idx_users_role ON users(role)
CREATE INDEX idx_users_is_active ON users(is_active)

CREATE INDEX idx_students_user_id ON students(user_id)
CREATE INDEX idx_students_level ON students(current_english_level)

CREATE INDEX idx_teachers_user_id ON teachers(user_id)
CREATE INDEX idx_teachers_level ON teachers(english_level)

CREATE INDEX idx_groups_teacher_id ON groups(teacher_id)
CREATE INDEX idx_groups_level ON groups(english_level)

CREATE INDEX idx_enrollments_group_id ON enrollments(group_id)
CREATE INDEX idx_enrollments_student_id ON enrollments(student_id)

CREATE INDEX idx_lessons_unit_id ON lessons(unit_id)
CREATE INDEX idx_lessons_published ON lessons(is_published)

CREATE INDEX idx_lesson_progress_student_id ON lesson_progress(student_id)
CREATE INDEX idx_lesson_progress_lesson_id ON lesson_progress(lesson_id)

CREATE INDEX idx_vocabulary_lists_unit_id ON vocabulary_lists(unit_id)
CREATE INDEX idx_vocabulary_lists_teacher_id ON vocabulary_lists(teacher_id)

CREATE INDEX idx_vocabulary_items_list_id ON vocabulary_items(list_id)

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
-- INSERT DEFAULT LEVELS
-- =====================================================
INSERT INTO levels (level_code, level_name, description, order_number, is_active)
VALUES
    ('A1', 'Beginner', 'Elementary proficiency', 1, 1),
    ('A2', 'Elementary', 'Elementary proficiency', 2, 1),
    ('B1', 'Intermediate', 'Intermediate proficiency', 3, 1),
    ('B2', 'Upper Intermediate', 'Upper intermediate proficiency', 4, 1),
    ('C1', 'Advanced', 'Advanced proficiency', 5, 1),
    ('C2', 'Proficiency', 'Mastery proficiency', 6, 1)
GO

PRINT 'Database created successfully!'
PRINT 'Tables created:'
PRINT '  - users'
PRINT '  - english_levels'
PRINT '  - units'
PRINT '  - students'
PRINT '  - teachers'
PRINT '  - groups'
PRINT '  - group_members'
PRINT '  - lessons'
PRINT '  - lesson_progress'
PRINT '  - vocabulary_lists'
PRINT '  - vocabulary_items'
PRINT '  - student_vocabulary'
PRINT '  - tasks'
PRINT '  - task_materials'
PRINT '  - task_submissions'
