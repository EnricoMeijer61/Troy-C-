set identity_insert RESERVATIE on

merge into RESERVATIE as T using
	(values
		(1, '2017-03-31', '2017-04-17', '2017-04-28', 1, null, null, 15),
		(2, '2017-03-31', '2017-04-27', '2017-05-09', 2, 7, null, null),
		(3, '2017-03-31', '2017-05-05', '2017-05-20', 3, null, 2, null)
	) as S (id, datum, [start], eind, gebruikerid, resortid, accomodatieid, dienstid) on T.id = S.id
when matched then
	update set 
		datum = S.datum,
		[start] = S.[start],
		eind = S.eind,
		gebruikerid = S.gebruikerid,
		resortid = S.resortid,
		accomodatieid = S.accomodatieid,
		dienstid = S.dienstid
when not matched by target then
	insert (id, datum, [start], eind, gebruikerid, resortid, accomodatieid, dienstid)
	values (id, datum, [start], eind, gebruikerid, resortid, accomodatieid, dienstid)
;

set identity_insert RESERVATIE off