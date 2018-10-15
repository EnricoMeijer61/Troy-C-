﻿CREATE TABLE [dbo].[PRIJS]
(
	[id] INT NOT NULL CONSTRAINT [PK_PRIJS] PRIMARY KEY IDENTITY, 
    [prijs] DECIMAL NULL,
	[accomodatieid] INT NOT NULL CONSTRAINT [FK_PRIJS_ACCOMODATIE] FOREIGN KEY REFERENCES [ACCOMODATIE]([id]), 
	[dienstid] INT NOT NULL CONSTRAINT [FK_PRIJS_DIENST] FOREIGN KEY REFERENCES [DIENST]([id])
)
