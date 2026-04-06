-- Fix activity_attempts table without cascade issues
USE PruebaPolyTalk;
GO

IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[activity_attempts]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[activity_attempts]
    (
        [attempt_id] INT IDENTITY(1,1) PRIMARY KEY,
        [student_id] INT NOT NULL,
        [activity_id] INT NOT NULL,
        [lesson_id] INT NOT NULL,
        [response_text] NVARCHAR(MAX),
        [is_correct] BIT,
        [time_spent_seconds] INT,
        [attempted_at] DATETIME DEFAULT GETDATE(),
        CONSTRAINT [FK_activity_attempts_student] FOREIGN KEY([student_id])
            REFERENCES [dbo].[students]([student_id]) ON DELETE CASCADE,
        CONSTRAINT [FK_activity_attempts_activity] FOREIGN KEY([activity_id])
            REFERENCES [dbo].[lesson_activities]([activity_id]) ON DELETE NO ACTION
    );

    CREATE NONCLUSTERED INDEX [idx_activity_attempts_student] ON [dbo].[activity_attempts]([student_id]);
    CREATE NONCLUSTERED INDEX [idx_activity_attempts_activity] ON [dbo].[activity_attempts]([activity_id]);
    PRINT 'Created table: activity_attempts for detailed analytics';
END
ELSE
BEGIN
    PRINT 'Table activity_attempts already exists';
END

PRINT '✓ Activity attempts table created successfully!';
GO
