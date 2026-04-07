-- =====================================================
-- Populate predefined vocabulary lists with sample words
-- =====================================================

-- Get the list IDs for predefined lists
DECLARE @BasicGreetingsId INT;
DECLARE @BusinessTermsId INT;

SET @BasicGreetingsId = (SELECT TOP 1 list_id FROM vocabulary_lists WHERE list_name = 'Basic Greetings');
SET @BusinessTermsId = (SELECT TOP 1 list_id FROM vocabulary_lists WHERE list_name = 'Business Terms');

-- =====================================================
-- Basic Greetings - 10 words
-- =====================================================
IF @BasicGreetingsId IS NOT NULL
BEGIN
    INSERT INTO list_words (list_id, word_english, word_spanish, date_added, is_active) VALUES
        (@BasicGreetingsId, 'Hello', 'Hola', GETDATE(), 1),
        (@BasicGreetingsId, 'Good morning', 'Buenos días', GETDATE(), 1),
        (@BasicGreetingsId, 'Good afternoon', 'Buenas tardes', GETDATE(), 1),
        (@BasicGreetingsId, 'Good evening', 'Buenas noches', GETDATE(), 1),
        (@BasicGreetingsId, 'How are you?', '¿Cómo estás?', GETDATE(), 1),
        (@BasicGreetingsId, 'Thank you', 'Gracias', GETDATE(), 1),
        (@BasicGreetingsId, 'You are welcome', 'De nada', GETDATE(), 1),
        (@BasicGreetingsId, 'Goodbye', 'Adiós', GETDATE(), 1),
        (@BasicGreetingsId, 'See you later', 'Hasta luego', GETDATE(), 1),
        (@BasicGreetingsId, 'Nice to meet you', 'Mucho gusto', GETDATE(), 1);

    -- Update total_words counter
    UPDATE vocabulary_lists SET total_words = 10 WHERE list_id = @BasicGreetingsId;
END

-- =====================================================
-- Business Terms - 10 words
-- =====================================================
IF @BusinessTermsId IS NOT NULL
BEGIN
    INSERT INTO list_words (list_id, word_english, word_spanish, date_added, is_active) VALUES
        (@BusinessTermsId, 'Meeting', 'Reunión', GETDATE(), 1),
        (@BusinessTermsId, 'Project', 'Proyecto', GETDATE(), 1),
        (@BusinessTermsId, 'Deadline', 'Fecha límite', GETDATE(), 1),
        (@BusinessTermsId, 'Budget', 'Presupuesto', GETDATE(), 1),
        (@BusinessTermsId, 'Report', 'Informe', GETDATE(), 1),
        (@BusinessTermsId, 'Strategy', 'Estrategia', GETDATE(), 1),
        (@BusinessTermsId, 'Client', 'Cliente', GETDATE(), 1),
        (@BusinessTermsId, 'Profit', 'Ganancia', GETDATE(), 1),
        (@BusinessTermsId, 'Invest', 'Invertir', GETDATE(), 1),
        (@BusinessTermsId, 'Contract', 'Contrato', GETDATE(), 1);

    -- Update total_words counter
    UPDATE vocabulary_lists SET total_words = 10 WHERE list_id = @BusinessTermsId;
END

-- =====================================================
-- Create Verbs list if it doesn't exist
-- =====================================================
IF NOT EXISTS (SELECT 1 FROM vocabulary_lists WHERE list_name = 'Verbs')
BEGIN
    INSERT INTO vocabulary_lists (user_id, list_name, description, icon, color_code, is_public, is_published, is_active, total_words)
    VALUES (1, 'Verbs', 'Common action verbs', '🎯', '#FF6B6B', 1, 1, 1, 10);

    DECLARE @VerbsId INT = SCOPE_IDENTITY();

    INSERT INTO list_words (list_id, word_english, word_spanish, date_added, is_active) VALUES
        (@VerbsId, 'Go', 'Ir', GETDATE(), 1),
        (@VerbsId, 'Come', 'Venir', GETDATE(), 1),
        (@VerbsId, 'Eat', 'Comer', GETDATE(), 1),
        (@VerbsId, 'Drink', 'Beber', GETDATE(), 1),
        (@VerbsId, 'Sleep', 'Dormir', GETDATE(), 1),
        (@VerbsId, 'Work', 'Trabajar', GETDATE(), 1),
        (@VerbsId, 'Study', 'Estudiar', GETDATE(), 1),
        (@VerbsId, 'Play', 'Jugar', GETDATE(), 1),
        (@VerbsId, 'Read', 'Leer', GETDATE(), 1),
        (@VerbsId, 'Write', 'Escribir', GETDATE(), 1);
END
