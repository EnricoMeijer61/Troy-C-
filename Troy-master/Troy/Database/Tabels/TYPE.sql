﻿CREATE TABLE [dbo].[TYPE]
(
	[id] INT NOT NULL CONSTRAINT [PK_TYPE] PRIMARY KEY IDENTITY, 
    [type] INT NOT NULL, 
    [bio] NVARCHAR(MAX) NOT NULL, 
	[resortid] INT NOT NULL CONSTRAINT [FK_TYPE_RESORT] FOREIGN KEY REFERENCES [RESORT]([id])
)
