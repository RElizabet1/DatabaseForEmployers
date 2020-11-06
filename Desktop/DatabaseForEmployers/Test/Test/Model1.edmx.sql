
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 11/04/2020 08:28:44
-- Generated from EDMX file: C:\Users\Nikita\source\repos\Test\Test\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [DatabaseUsers];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_UsersSetInterviewersSet]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[InterviewersSet] DROP CONSTRAINT [FK_UsersSetInterviewersSet];
GO
IF OBJECT_ID(N'[dbo].[FK_UsersSetSkills]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[SkillsSet] DROP CONSTRAINT [FK_UsersSetSkills];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[InterviewersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[InterviewersSet];
GO
IF OBJECT_ID(N'[dbo].[UsersSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[UsersSet];
GO
IF OBJECT_ID(N'[dbo].[SkillsSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[SkillsSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'InterviewersSet'
CREATE TABLE [dbo].[InterviewersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [ФИО] nvarchar(max)  NOT NULL,
    [UsersSetId] int   NULL
);
GO

-- Creating table 'UsersSet'
CREATE TABLE [dbo].[UsersSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Фамилия] nvarchar(max)  NOT NULL,
    [Имя] nvarchar(max)  NOT NULL,
    [Отчество] nvarchar(max)  NOT NULL,
    [Ссылка] nvarchar(max)  NOT NULL,
    [ДатаСобеседования] nvarchar(max)  NOT NULL,
    [Рейтинг] nvarchar(max)  NOT NULL,
    [Пояснения] nvarchar(max)  NULL,
    [Файлы] nvarchar(max)  NULL
);
GO

-- Creating table 'SkillsSet'
CREATE TABLE [dbo].[SkillsSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Фреймворки] nvarchar(max)  NOT NULL,
    [ЯзыкиПрограммирования] nvarchar(max)  NOT NULL,
    [Библиотеки] nvarchar(max)  NOT NULL,
    [UsersSetId] int   NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'InterviewersSet'
ALTER TABLE [dbo].[InterviewersSet]
ADD CONSTRAINT [PK_InterviewersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'UsersSet'
ALTER TABLE [dbo].[UsersSet]
ADD CONSTRAINT [PK_UsersSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'SkillsSet'
ALTER TABLE [dbo].[SkillsSet]
ADD CONSTRAINT [PK_SkillsSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [UsersSetId] in table 'InterviewersSet'
ALTER TABLE [dbo].[InterviewersSet]
ADD CONSTRAINT [FK_UsersSetInterviewersSet]
    FOREIGN KEY ([UsersSetId])
    REFERENCES [dbo].[UsersSet]
        ([Id])
    ON DELETE CASCADE;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersSetInterviewersSet'
CREATE INDEX [IX_FK_UsersSetInterviewersSet]
ON [dbo].[InterviewersSet]
    ([UsersSetId]);
GO

-- Creating foreign key on [UsersSetId] in table 'SkillsSet'
ALTER TABLE [dbo].[SkillsSet]
ADD CONSTRAINT [FK_UsersSetSkills]
    FOREIGN KEY ([UsersSetId])
    REFERENCES [dbo].[UsersSet]
        ([Id])
    ON DELETE CASCADE;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UsersSetSkills'
CREATE INDEX [IX_FK_UsersSetSkills]
ON [dbo].[SkillsSet]
    ([UsersSetId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------