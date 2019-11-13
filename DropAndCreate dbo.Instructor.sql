USE [StudentExercises]
GO

/****** Object: Table [dbo].[Instructor] Script Date: 11/13/2019 11:26:39 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

DROP TABLE [dbo].[Instructor];


GO
CREATE TABLE [dbo].[Instructor] (
    [Id]          INT          IDENTITY (1, 1) NOT NULL,
    [FirstName]       VARCHAR (25) NULL,
    [LastName]       VARCHAR (25) NULL,
    [SlackHandle] VARCHAR (25) NULL,
    [CohortId]    INT          NULL,
    [Specialty]   VARCHAR (25) NULL
);


