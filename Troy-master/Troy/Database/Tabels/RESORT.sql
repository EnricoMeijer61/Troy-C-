﻿CREATE TABLE [dbo].[RESORT]
(
	[id] INT NOT NULL CONSTRAINT [PK_RESORT] PRIMARY KEY IDENTITY, 
    [naam] NVARCHAR(50) NULL, 
    [bio] NVARCHAR(50) NULL
)