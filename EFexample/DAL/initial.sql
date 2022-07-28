IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Artists] (
    [ArtistId] int NOT NULL IDENTITY,
    [UserName] nvarchar(50) NOT NULL,
    [Country] nvarchar(50) NULL,
    [Provence] nvarchar(50) NULL,
    [City] nvarchar(50) NULL,
    [WebSite] nvarchar(255) NULL,
    [CreateDate] datetime2 NOT NULL,
    CONSTRAINT [PK_Artists] PRIMARY KEY ([ArtistId])
);
GO

CREATE TABLE [ArtistsSkills] (
    [ArtistSkillId] int NOT NULL IDENTITY,
    [TalentName] nvarchar(50) NOT NULL,
    [SkillLevel] int NOT NULL,
    [Details] nvarchar(255) NULL,
    [Styles] nvarchar(255) NULL,
    [ArtistId] int NULL,
    CONSTRAINT [PK_ArtistsSkills] PRIMARY KEY ([ArtistSkillId]),
    CONSTRAINT [FK_ArtistsSkills_Artists_ArtistId] FOREIGN KEY ([ArtistId]) REFERENCES [Artists] ([ArtistId]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_ArtistsSkills_ArtistId] ON [ArtistsSkills] ([ArtistId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220721153110_Initial', N'5.0.17');
GO

COMMIT;
GO

