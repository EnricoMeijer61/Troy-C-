set identity_insert ADRES on

merge into ADRES as T using
	(values
		(1, 'Nederland', 'Hoorn', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', 1, null),
		(2,  'Nederland', 'Purmerdend', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', 2, null),
		(3,  'Nederland', 'Zaandam', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', 3, null),
		(4, 'Nederland', 'Amsterdam', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', null, 1),
		(5,  'Nederland', 'Amsterdam', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', null, 2),
		(6,  'Nederland', 'Amsterdam', 'Noord-Holland', 'straat', '0000XX', '12345678', 'email@mali.nl', null, 3)
	) as S (id, land, stad, povincie, straat, postocde, telefoonnummer, email, gebruikerid, resortid) on T.id = S.id
when matched then
	update set 
		land = S.land,
		stad = S.stad,
		povincie = S.provincie,
		straat = S.straat,
		postocde = S.postcode,
		telefoonnummer = S.telefoonnummer,
		email = S.email,
		gebruikerid = S.gebruikerid,
		resortid = S.resortid
when not matched by target then
	insert (id, land, stad, provincie, straat, postcode, telefoonnummer, email, gebruikerid, resortid)
	values (id, land, stad, provincie, straat, postcode, telefoonnummer, email, gebruikerid, resortid)
;

set identity_insert ADRES off