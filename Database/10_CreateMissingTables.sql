USE PruebaPolyTalk
GO

-- =====================================================
-- CREATE MISSING TABLE: STUDENT_VOCABULARY
-- =====================================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'student_vocabulary')
BEGIN
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
    PRINT '✓ Table student_vocabulary created'
END
GO

-- =====================================================
-- CREATE MISSING TABLE: TASK_SUBMISSIONS
-- =====================================================
IF NOT EXISTS (SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'task_submissions')
BEGIN
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
        status NVARCHAR(50) DEFAULT 'Submitted',
        score DECIMAL(5,2),
        feedback NVARCHAR(MAX),
        graded_at DATETIME NULL,
        updated_at DATETIME DEFAULT GETDATE(),
        FOREIGN KEY (task_id) REFERENCES tasks(task_id) ON DELETE CASCADE,
        FOREIGN KEY (student_id) REFERENCES students(student_id) ON DELETE CASCADE,
        UNIQUE (task_id, student_id)
    )
    PRINT '✓ Table task_submissions created'
END
GO

-- =====================================================
-- CREATE MISSING INDEXES
-- =====================================================
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_student_vocabulary_student_id')
BEGIN
    CREATE INDEX idx_student_vocabulary_student_id ON student_vocabulary(student_id)
    PRINT '✓ Index idx_student_vocabulary_student_id created'
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_student_vocabulary_item_id')
BEGIN
    CREATE INDEX idx_student_vocabulary_item_id ON student_vocabulary(vocabulary_item_id)
    PRINT '✓ Index idx_student_vocabulary_item_id created'
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_task_submissions_task_id')
BEGIN
    CREATE INDEX idx_task_submissions_task_id ON task_submissions(task_id)
    PRINT '✓ Index idx_task_submissions_task_id created'
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_task_submissions_student_id')
BEGIN
    CREATE INDEX idx_task_submissions_student_id ON task_submissions(student_id)
    PRINT '✓ Index idx_task_submissions_student_id created'
END
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_task_submissions_status')
BEGIN
    CREATE INDEX idx_task_submissions_status ON task_submissions(status)
    PRINT '✓ Index idx_task_submissions_status created'
END
GO

PRINT ''
PRINT '=========================================='
PRINT '✓ Missing tables and indexes created'
PRINT '=========================================='
GO
