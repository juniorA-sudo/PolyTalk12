-- =====================================================
-- POLYTALK - DATABASE SETUP SCRIPT
-- SQL Server - PruebaPolyTalk Database
-- =====================================================

-- Create database if it doesn't exist
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = 'PruebaPolyTalk')
BEGIN
    CREATE DATABASE PruebaPolyTalk
END
GO

USE PruebaPolyTalk
GO

-- =====================================================
-- Users Table (base para todos los roles)
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'users')
BEGIN
    CREATE TABLE users
    (
        user_id INT PRIMARY KEY IDENTITY(1,1),
        username NVARCHAR(100) NOT NULL UNIQUE,
        password NVARCHAR(255) NOT NULL,
        email NVARCHAR(150) NOT NULL,
        role NVARCHAR(50) NOT NULL, -- 'Administrator', 'Teacher', 'Student'
        full_name NVARCHAR(200) NOT NULL,
        created_at DATETIME DEFAULT GETDATE(),
        updated_at DATETIME DEFAULT GETDATE(),
        is_active BIT DEFAULT 1
    )
END
GO

-- =====================================================
-- Students Table
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'students')
BEGIN
    CREATE TABLE students
    (
        student_id INT PRIMARY KEY IDENTITY(1,1),
        user_id INT NOT NULL,
        english_level NVARCHAR(50), -- 'A1', 'A2', 'B1', 'B2', 'C1', 'C2'
        enrollment_date DATETIME DEFAULT GETDATE(),
        phone NVARCHAR(20),
        FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
    )
END
GO

-- =====================================================
-- Teachers Table
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'teachers')
BEGIN
    CREATE TABLE teachers
    (
        teacher_id INT PRIMARY KEY IDENTITY(1,1),
        user_id INT NOT NULL,
        specialization NVARCHAR(200),
        hire_date DATETIME DEFAULT GETDATE(),
        phone NVARCHAR(20),
        FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE
    )
END
GO

-- =====================================================
-- Groups Table
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'groups')
BEGIN
    CREATE TABLE groups
    (
        group_id INT PRIMARY KEY IDENTITY(1,1),
        group_code NVARCHAR(50) NOT NULL UNIQUE,
        group_name NVARCHAR(200) NOT NULL,
        teacher_id INT,
        english_level NVARCHAR(50),
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
    )
END
GO

-- =====================================================
-- Group Members (Enrollment)
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'group_members')
BEGIN
    CREATE TABLE group_members
    (
        group_member_id INT PRIMARY KEY IDENTITY(1,1),
        group_id INT NOT NULL,
        student_id INT NOT NULL,
        enrolled_date DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (group_id) REFERENCES groups(group_id) ON DELETE CASCADE,
        FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
        UNIQUE (group_id, student_id)
    )
END
GO

-- =====================================================
-- Tasks Table
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'tasks')
BEGIN
    CREATE TABLE tasks
    (
        task_id INT PRIMARY KEY IDENTITY(1,1),
        title NVARCHAR(300) NOT NULL,
        description NVARCHAR(MAX),
        teacher_id INT NOT NULL,
        group_id INT NOT NULL,
        unit_id INT,
        assigned_date DATETIME DEFAULT GETDATE(),
        due_date DATETIME NOT NULL,
        max_score INT DEFAULT 100,
        submission_type NVARCHAR(50) DEFAULT 'File', -- 'File', 'Text', 'Image', 'Review'
        allow_late BIT DEFAULT 0,
        show_grade BIT DEFAULT 1,
        status NVARCHAR(50) DEFAULT 'Active', -- 'Active', 'Expired', 'Completed', 'Draft'
        created_at DATETIME DEFAULT GETDATE(),
        updated_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id),
        FOREIGN KEY (group_id) REFERENCES groups(group_id)
    )
END
GO

-- =====================================================
-- Task Materials (Archivos adjuntos de la tarea)
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'task_materials')
BEGIN
    CREATE TABLE task_materials
    (
        material_id INT PRIMARY KEY IDENTITY(1,1),
        task_id INT NOT NULL,
        file_name NVARCHAR(500) NOT NULL,
        file_path NVARCHAR(MAX) NOT NULL,
        file_type NVARCHAR(50), -- 'PDF', 'Word', 'Image', 'Audio', 'Video'
        file_size_kb INT,
        uploaded_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE
    )
END
GO

-- =====================================================
-- Task Submissions (Entregas de estudiantes)
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'task_submissions')
BEGIN
    CREATE TABLE task_submissions
    (
        submission_id INT PRIMARY KEY IDENTITY(1,1),
        task_id INT NOT NULL,
        student_id INT NOT NULL,
        comment NVARCHAR(MAX),
        file_path NVARCHAR(MAX),
        file_name NVARCHAR(500),
        submitted_at DATETIME DEFAULT GETDATE(),
        is_late BIT DEFAULT 0,
        status NVARCHAR(50) DEFAULT 'Submitted', -- 'Submitted', 'Graded', 'Reviewed'
        score DECIMAL(5,2),
        feedback NVARCHAR(MAX),
        graded_at DATETIME,
        FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE,
        FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
        UNIQUE (task_id, student_id)
    )
END
GO

-- =====================================================
-- Lessons Table
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'lessons')
BEGIN
    CREATE TABLE lessons
    (
        lesson_id INT PRIMARY KEY IDENTITY(1,1),
        title NVARCHAR(300) NOT NULL,
        description NVARCHAR(MAX),
        unit_id INT,
        teacher_id INT,
        duration_minutes INT,
        created_at DATETIME DEFAULT GETDATE(),
        updated_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id)
    )
END
GO

-- =====================================================
-- Vocabulary Lists
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'vocabulary_lists')
BEGIN
    CREATE TABLE vocabulary_lists
    (
        list_id INT PRIMARY KEY IDENTITY(1,1),
        title NVARCHAR(300) NOT NULL,
        description NVARCHAR(MAX),
        lesson_id INT,
        created_by INT,
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id),
        FOREIGN KEY (created_by) REFERENCES teachers(teacher_id)
    )
END
GO

-- =====================================================
-- Vocabulary Items
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'vocabulary_items')
BEGIN
    CREATE TABLE vocabulary_items
    (
        item_id INT PRIMARY KEY IDENTITY(1,1),
        list_id INT NOT NULL,
        word NVARCHAR(200) NOT NULL,
        pronunciation NVARCHAR(200),
        definition NVARCHAR(MAX),
        example NVARCHAR(MAX),
        created_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (list_id) REFERENCES vocabulary_lists(list_id) ON DELETE CASCADE
    )
END
GO

-- =====================================================
-- Lesson Progress
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'lesson_progress')
BEGIN
    CREATE TABLE lesson_progress
    (
        progress_id INT PRIMARY KEY IDENTITY(1,1),
        student_id INT NOT NULL,
        lesson_id INT NOT NULL,
        total_activities INT DEFAULT 0,
        completed_activities INT DEFAULT 0,
        score DECIMAL(5,2) DEFAULT 0,
        started_at DATETIME DEFAULT GETDATE(),
        completed_at DATETIME NULL,
        FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
        FOREIGN KEY (lesson_id) REFERENCES lessons(lesson_id) ON DELETE CASCADE,
        UNIQUE (student_id, lesson_id)
    )
END
GO

-- =====================================================
-- Student Vocabulary (Track learned vocabulary per student)
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'student_vocabulary')
BEGIN
    CREATE TABLE student_vocabulary
    (
        student_vocab_id INT PRIMARY KEY IDENTITY(1,1),
        student_id INT NOT NULL,
        vocabulary_item_id INT NOT NULL,
        mastered BIT DEFAULT 0,
        learned_date DATETIME DEFAULT GETDATE(),
        last_reviewed DATETIME NULL,
        FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
        FOREIGN KEY (vocabulary_item_id) REFERENCES vocabulary_items(item_id) ON DELETE CASCADE,
        UNIQUE (student_id, vocabulary_item_id)
    )
END
GO

-- =====================================================
-- Insert Sample Administrator User
-- =====================================================
IF NOT EXISTS (SELECT * FROM users WHERE username = 'admin')
BEGIN
    INSERT INTO users (username, password, email, role, full_name)
    VALUES ('admin', 'admin123', 'admin@polytalk.local', 'Administrator', 'Administrator')
END
GO

PRINT 'Database PruebaPolyTalk created successfully!'
