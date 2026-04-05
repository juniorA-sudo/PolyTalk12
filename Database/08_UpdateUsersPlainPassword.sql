-- =====================================================
-- UPDATE USERS WITH PLAIN TEXT PASSWORDS FOR TESTING
-- =====================================================

USE PruebaPolyTalk
GO

-- Update users with plain text password "123123"
UPDATE users SET password = '123123' WHERE username IN ('admin', 'maestro', 'estudiante')
GO

-- Verify
SELECT user_id, username, password, role FROM users
GO

PRINT '✓ Users updated with plain text password: 123123'
GO
