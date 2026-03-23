-- =====================================================
-- POLYTALK - CREAR TABLAS DE TAREAS
-- Ejecutar en SQL Server Management Studio
-- Base de datos: PruebaPolyTalk
-- =====================================================

USE PruebaPolyTalk;
GO

-- =====================================================
-- 1. TABLA tasks
-- =====================================================
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='tasks' AND xtype='U')
BEGIN
    CREATE TABLE tasks (
        task_id         INT IDENTITY(1,1) PRIMARY KEY,
        title           NVARCHAR(200)   NOT NULL,
        description     NVARCHAR(MAX)   NULL,
        teacher_id      INT             NOT NULL,
        group_id        INT             NOT NULL,
        unit_id         INT             NULL,
        assigned_date   DATE            NOT NULL DEFAULT GETDATE(),
        due_date        DATE            NOT NULL,
        max_score       INT             NOT NULL DEFAULT 100,
        submission_type NVARCHAR(50)    NOT NULL DEFAULT 'File',
        allow_late      BIT             NOT NULL DEFAULT 0,
        show_grade      BIT             NOT NULL DEFAULT 1,
        status          NVARCHAR(20)    NOT NULL DEFAULT 'Active',
        created_at      DATETIME        NOT NULL DEFAULT GETDATE(),
        FOREIGN KEY (teacher_id) REFERENCES teachers(teacher_id),
        FOREIGN KEY (group_id)   REFERENCES groups(group_id)
    );
    PRINT 'Tabla tasks creada.';
END
ELSE
    PRINT 'Tabla tasks ya existe.';
GO

-- =====================================================
-- 2. TABLA task_submissions
-- =====================================================
IF NOT EXISTS (SELECT * FROM sysobjects WHERE name='task_submissions' AND xtype='U')
BEGIN
    CREATE TABLE task_submissions (
        submission_id   INT IDENTITY(1,1) PRIMARY KEY,
        task_id         INT             NOT NULL,
        student_id      INT             NOT NULL,
        comment         NVARCHAR(MAX)   NULL,
        file_path       NVARCHAR(500)   NULL,
        file_name       NVARCHAR(200)   NULL,
        submitted_at    DATETIME        NOT NULL DEFAULT GETDATE(),
        is_late         BIT             NOT NULL DEFAULT 0,
        status          NVARCHAR(20)    NOT NULL DEFAULT 'Submitted',
        score           DECIMAL(5,2)    NULL,
        feedback        NVARCHAR(MAX)   NULL,
        graded_at       DATETIME        NULL,
        FOREIGN KEY (task_id)    REFERENCES tasks(task_id),
        FOREIGN KEY (student_id) REFERENCES students(student_id),
        UNIQUE (task_id, student_id)
    );
    PRINT 'Tabla task_submissions creada.';
END
ELSE
    PRINT 'Tabla task_submissions ya existe.';
GO

PRINT 'Listo. Ya puedes correr la aplicacion.';
