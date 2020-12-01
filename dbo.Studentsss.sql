CREATE TABLE [dbo].[Studentsss] (
    [Id]          INT             IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (100)  NULL,
    [IndexNumber] NVARCHAR (20)   NULL,
    [AverageMark] DECIMAL (16, 2) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

