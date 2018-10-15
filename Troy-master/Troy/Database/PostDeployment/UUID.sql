set identity_insert UUID on

merge into UUID as T using
	(values
		(1, '1F9619FF-8B86-D011-B42D-00C04FC964FF', 1),
		(2, '2F9619FF-8B86-D011-B42D-00C04FC964FF', 2),
		(3, '3F9619FF-8B86-D011-B42D-00C04FC964FF', 3)
	) as S (id, uuid, gebruikerid) on T.id = S.id
when matched then
	update set 
		uuid = S.uuid,
		gebruikerid = S.gebruikerid
when not matched by target then
	insert (id, uuid, gebruikerid)
	values (id, uuid, gebruikerid)
;

set identity_insert UUID off