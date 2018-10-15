﻿CREATE TABLE [dbo].[UUID]
(
	[id] INT NOT NULL CONSTRAINT [PK_UUID] PRIMARY KEY IDENTITY,
    [uuid] UNIQUEIDENTIFIER NOT NULL,
	[gebruikerid] INT NOT NULL CONSTRAINT [FK_UUID_GEBRUIKER] FOREIGN KEY REFERENCES [GEBRUIKER]([id])
)