set identity_insert PRIJS on

merge into PRIJS as T using
	(values
		(1, 5500, 1, null),
		(2, 2500, 2, null),
		(3, 8495, 3, null),
		(4, 22639, 4, null),
		(5, 2.50, null, 1),
		(6, 3.50, null, 2)
	) as S (id, prijs, accomodatieid, dienstid) on T.id = S.id
when matched then
	update set 
		prijs = S.prijs,
		accomodatieid = S.accomodatieid,
		dienstid = S.dienstid
when not matched by target then
	insert (id, prijs, accomodatieid, dienstid)
	values (id, prijs, accomodatieid, dienstid)
;

set identity_insert PRIJS off