set identity_insert ACCOMODATIE on

merge into ACCOMODATIE as T using
	(values
		(1, '192/m2', 4, 3, 1),
		(2, '72/m2', 6, 1, 2),
		(3, '350/m2', 8, 9, 3),
		(4, '18000/m2', 18, 12,4)
	) as S (id, oppervlakte, slaapkamers, autos, typeid) on T.id = S.id
when matched then
	update set 
		opervlakte = S.opervlakte,
		slaapkamers = S.slaapkamers,
		autos = S.autos,
		typeid = S.typeid
when not matched by target then
	insert (id, oppervlakte, slaapkamers, autos, typeid)
	values (id, oppervlakte, slaapkamers, autos, typeid)
;

set identity_insert ACCOMODATIE off