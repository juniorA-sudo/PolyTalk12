-- =====================================================
-- POLYTALK - TEST DATA INSERTION
-- =====================================================

USE PruebaPolyTalk
GO

-- =====================================================
-- Insert Test Users
-- =====================================================

-- Admin User
INSERT INTO users (username, email, role, full_name, password, created_at, is_active)
VALUES ('admin_poly', 'admin@polytalk.com', 'admin', 'Admin PolyTalk', 'admin123', GETDATE(), 1)
GO

-- Teacher Users
INSERT INTO users (username, email, role, full_name, password, created_at, is_active)
VALUES
    ('maestro1', 'maestro1@polytalk.com', 'maestro', 'Juan García', 'maestro123', GETDATE(), 1),
    ('maestro2', 'maestro2@polytalk.com', 'maestro', 'María López', 'maestro123', GETDATE(), 1),
    ('maestro3', 'maestro3@polytalk.com', 'maestro', 'Carlos Martínez', 'maestro123', GETDATE(), 1)
GO

-- Student Users
INSERT INTO users (username, email, role, full_name, password, created_at, is_active)
VALUES
    ('estudiante1', 'estudiante1@polytalk.com', 'estudiante', 'Pedro Rodríguez', 'estudiante123', GETDATE(), 1),
    ('estudiante2', 'estudiante2@polytalk.com', 'estudiante', 'Ana González', 'estudiante123', GETDATE(), 1),
    ('estudiante3', 'estudiante3@polytalk.com', 'estudiante', 'Luis Fernández', 'estudiante123', GETDATE(), 1),
    ('estudiante4', 'estudiante4@polytalk.com', 'estudiante', 'Sofia Ramírez', 'estudiante123', GETDATE(), 1)
GO

-- =====================================================
-- Insert Teachers
-- =====================================================

INSERT INTO teachers (user_id, specialization, hire_date, phone)
SELECT user_id, 'English Conversation', GETDATE(), '555-0101'
FROM users WHERE username = 'maestro1'
GO

INSERT INTO teachers (user_id, specialization, hire_date, phone)
SELECT user_id, 'Grammar & Writing', GETDATE(), '555-0102'
FROM users WHERE username = 'maestro2'
GO

INSERT INTO teachers (user_id, specialization, hire_date, phone)
SELECT user_id, 'Listening & Pronunciation', GETDATE(), '555-0103'
FROM users WHERE username = 'maestro3'
GO

-- =====================================================
-- Insert Students
-- =====================================================

INSERT INTO students (user_id, english_level, enrollment_date, phone)
SELECT user_id, 'A1', GETDATE(), '555-1001'
FROM users WHERE username = 'estudiante1'
GO

INSERT INTO students (user_id, english_level, enrollment_date, phone)
SELECT user_id, 'A2', GETDATE(), '555-1002'
FROM users WHERE username = 'estudiante2'
GO

INSERT INTO students (user_id, english_level, enrollment_date, phone)
SELECT user_id, 'B1', GETDATE(), '555-1003'
FROM users WHERE username = 'estudiante3'
GO

INSERT INTO students (user_id, english_level, enrollment_date, phone)
SELECT user_id, 'B2', GETDATE(), '555-1004'
FROM users WHERE username = 'estudiante4'
GO

-- =====================================================
-- Insert Groups
-- =====================================================

INSERT INTO groups (group_code, group_name, teacher_id, english_level, created_at)
SELECT 'G001', 'Principiantes A1', teacher_id, 'A1', GETDATE()
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro1')
GO

INSERT INTO groups (group_code, group_name, teacher_id, english_level, created_at)
SELECT 'G002', 'Intermedios B1', teacher_id, 'B1', GETDATE()
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro2')
GO

INSERT INTO groups (group_code, group_name, teacher_id, english_level, created_at)
SELECT 'G003', 'Avanzados B2', teacher_id, 'B2', GETDATE()
FROM teachers WHERE user_id = (SELECT user_id FROM users WHERE username = 'maestro3')
GO

-- =====================================================
-- Insert Group Members (Enrollments)
-- =====================================================

INSERT INTO group_members (group_id, student_id, enrolled_date)
SELECT g.group_id, s.student_id, GETDATE()
FROM groups g, students s, users u
WHERE g.group_code = 'G001' AND u.username = 'estudiante1' AND s.user_id = u.user_id
GO

INSERT INTO group_members (group_id, student_id, enrolled_date)
SELECT g.group_id, s.student_id, GETDATE()
FROM groups g, students s, users u
WHERE g.group_code = 'G002' AND u.username = 'estudiante2' AND s.user_id = u.user_id
GO

INSERT INTO group_members (group_id, student_id, enrolled_date)
SELECT g.group_id, s.student_id, GETDATE()
FROM groups g, students s, users u
WHERE g.group_code = 'G003' AND u.username = 'estudiante3' AND s.user_id = u.user_id
GO

INSERT INTO group_members (group_id, student_id, enrolled_date)
SELECT g.group_id, s.student_id, GETDATE()
FROM groups g, students s, users u
WHERE g.group_code = 'G003' AND u.username = 'estudiante4' AND s.user_id = u.user_id
GO

-- =====================================================
-- Test Data Summary
-- =====================================================

-- Admin: admin_poly / admin123
-- Teachers: maestro1/2/3 / maestro123
-- Students: estudiante1/2/3/4 / estudiante123

PRINT 'Test data inserted successfully!'
PRINT 'Admin User: admin_poly / admin123'
PRINT 'Teacher Users: maestro1, maestro2, maestro3 / maestro123'
PRINT 'Student Users: estudiante1, estudiante2, estudiante3, estudiante4 / estudiante123'
