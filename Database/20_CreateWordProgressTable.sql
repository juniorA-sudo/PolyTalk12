-- =====================================================
-- Create word_progress table for spaced repetition (SM-2 algorithm)
-- =====================================================

IF EXISTS (SELECT * FROM sys.tables WHERE name = 'word_progress')
    DROP TABLE word_progress
GO

-- Create the word_progress table
CREATE TABLE word_progress
(
    progress_id INT PRIMARY KEY IDENTITY(1,1),
    user_id INT NOT NULL,
    word_id INT NOT NULL,
    ease_factor FLOAT DEFAULT 2.5,        -- SM-2 ease factor (minimum 1.3)
    interval_days INT DEFAULT 1,          -- Days until next review
    next_review DATETIME DEFAULT GETDATE(), -- When to review next
    times_correct INT DEFAULT 0,          -- Times answered correctly
    times_wrong INT DEFAULT 0,            -- Times answered incorrectly
    last_reviewed DATETIME DEFAULT GETDATE(),
    FOREIGN KEY (user_id) REFERENCES users(user_id) ON DELETE CASCADE,
    FOREIGN KEY (word_id) REFERENCES list_words(word_id) ON DELETE NO ACTION,
    UNIQUE (user_id, word_id)
)
GO

-- Create indexes for faster lookups
IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_word_progress_user_id' AND object_id = OBJECT_ID('word_progress'))
    CREATE INDEX idx_word_progress_user_id ON word_progress(user_id)
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_word_progress_next_review' AND object_id = OBJECT_ID('word_progress'))
    CREATE INDEX idx_word_progress_next_review ON word_progress(next_review)
GO

IF NOT EXISTS (SELECT * FROM sys.indexes WHERE name = 'idx_word_progress_user_word' AND object_id = OBJECT_ID('word_progress'))
    CREATE INDEX idx_word_progress_user_word ON word_progress(user_id, word_id)
GO
