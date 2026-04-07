-- =====================================================
-- Stored Procedures para Vocabulary Lists
-- =====================================================

-- Drop existing procedures if they exist
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_InsertVocabularyList')
    DROP PROCEDURE sp_InsertVocabularyList
GO

IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_GetUserVocabularyLists')
    DROP PROCEDURE sp_GetUserVocabularyLists
GO

-- =====================================================
-- sp_InsertVocabularyList
-- Crea una nueva lista de vocabulario
-- =====================================================
CREATE PROCEDURE sp_InsertVocabularyList
    @UserId INT,
    @ListName NVARCHAR(200),
    @Description NVARCHAR(500) = NULL,
    @Icon NVARCHAR(50) = '📚',
    @ColorCode NVARCHAR(20) = '#4ECDC4',
    @IsPublic BIT = 0
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO vocabulary_lists (user_id, list_name, description, icon, color_code, is_public, is_active, created_at, updated_at)
        VALUES (@UserId, @ListName, @Description, @Icon, @ColorCode, @IsPublic, 1, GETDATE(), GETDATE());

        -- Retornar el ID de la lista creada
        SELECT CAST(SCOPE_IDENTITY() AS INT);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- =====================================================
-- sp_GetUserVocabularyLists
-- Obtiene las listas de vocabulario del usuario
-- =====================================================
CREATE PROCEDURE sp_GetUserVocabularyLists
    @UserId INT,
    @IncludePublic BIT = 1
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        IF @IncludePublic = 1
        BEGIN
            SELECT
                list_id,
                user_id,
                list_name,
                description,
                icon,
                color_code,
                total_words,
                is_public,
                is_active,
                created_at,
                updated_at
            FROM vocabulary_lists
            WHERE (user_id = @UserId OR is_public = 1)
            AND is_active = 1
            ORDER BY created_at DESC;
        END
        ELSE
        BEGIN
            SELECT
                list_id,
                user_id,
                list_name,
                description,
                icon,
                color_code,
                total_words,
                is_public,
                is_active,
                created_at,
                updated_at
            FROM vocabulary_lists
            WHERE user_id = @UserId
            AND is_active = 1
            ORDER BY created_at DESC;
        END
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
