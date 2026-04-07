-- =====================================================
-- Create list_words table for vocabulary management
-- =====================================================

-- Drop the table if it exists
IF EXISTS (SELECT * FROM sys.tables WHERE name = 'list_words')
    DROP TABLE list_words
GO

-- Create the list_words table
CREATE TABLE list_words
(
    word_id INT PRIMARY KEY IDENTITY(1,1),
    list_id INT NOT NULL,
    word_english NVARCHAR(200) NOT NULL,
    word_spanish NVARCHAR(200) NOT NULL,
    image_url NVARCHAR(500),
    audio_url NVARCHAR(500),
    date_added DATETIME DEFAULT GETDATE(),
    is_active BIT DEFAULT 1,
    FOREIGN KEY (list_id) REFERENCES vocabulary_lists(list_id) ON DELETE CASCADE
)
GO

-- Create index for faster lookups
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_list_words_list_id' AND object_id = OBJECT_ID('list_words'))
    CREATE INDEX idx_list_words_list_id ON list_words(list_id)
GO

-- =====================================================
-- Stored Procedure: Get words for a vocabulary list
-- =====================================================
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_GetListWords')
    DROP PROCEDURE sp_GetListWords
GO

CREATE PROCEDURE sp_GetListWords
    @ListId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT
            word_id,
            list_id,
            word_english,
            word_spanish,
            image_url,
            audio_url,
            date_added,
            is_active
        FROM list_words
        WHERE list_id = @ListId AND is_active = 1
        ORDER BY date_added DESC;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- =====================================================
-- Stored Procedure: Insert a new word to vocabulary list
-- =====================================================
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_InsertListWord')
    DROP PROCEDURE sp_InsertListWord
GO

CREATE PROCEDURE sp_InsertListWord
    @ListId INT,
    @WordEnglish NVARCHAR(200),
    @WordSpanish NVARCHAR(200),
    @ImageUrl NVARCHAR(500) = NULL,
    @AudioUrl NVARCHAR(500) = NULL
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        INSERT INTO list_words (list_id, word_english, word_spanish, image_url, audio_url, date_added, is_active)
        VALUES (@ListId, @WordEnglish, @WordSpanish, @ImageUrl, @AudioUrl, GETDATE(), 1);

        -- Update the total_words count in vocabulary_lists
        UPDATE vocabulary_lists
        SET total_words = (SELECT COUNT(*) FROM list_words WHERE list_id = @ListId AND is_active = 1)
        WHERE list_id = @ListId;

        SELECT CAST(SCOPE_IDENTITY() AS INT);
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO

-- =====================================================
-- Stored Procedure: Delete a word from vocabulary list
-- =====================================================
IF EXISTS (SELECT * FROM sys.objects WHERE type = 'P' AND name = 'sp_DeleteListWord')
    DROP PROCEDURE sp_DeleteListWord
GO

CREATE PROCEDURE sp_DeleteListWord
    @WordId INT,
    @ListId INT
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        UPDATE list_words
        SET is_active = 0
        WHERE word_id = @WordId;

        -- Update the total_words count
        UPDATE vocabulary_lists
        SET total_words = (SELECT COUNT(*) FROM list_words WHERE list_id = @ListId AND is_active = 1)
        WHERE list_id = @ListId;
    END TRY
    BEGIN CATCH
        THROW;
    END CATCH
END
GO
