set identity_insert GEBRUIKER on

merge into GEBRUIKER as T using
	(values
		(1, 'Justin', 'Drenthe', '1990-01-01'),
		(2, 'Enrico', 'Meijer','1990-01-01'),
		(3, 'Dowen', 'Van Zijst', '1990-01-01')
	) as S (id, naam, achternaam, geboortedatum) on T.id = S.id
when matched then
	update set 
		naam = S.naam,
		achternaam = S.achternaam,
		geboortedatum = S.geboortedatum
when not matched by target then
	insert (id, naam, achternaam, geboortedatum)
	values (id, naam, achternaam, geboortedatum)
;

set identity_insert GEBRUIKER off
GO
