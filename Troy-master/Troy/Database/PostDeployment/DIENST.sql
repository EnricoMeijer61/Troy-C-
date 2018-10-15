set identity_insert DIENST on

merge into DIENST as T using
	(values
		(1, 'Butler', Null, 1),
		(2, 'Catering', Null, 1),
		(3, null , 'persoonlijke verzorging', 1),
		(4, null, 'verpleging', 1),
		
		(5, 'Butler', Null, 2),
		(6, 'Catering', Null, 2),
		(7, null , 'persoonlijke verzorging', 2),
		(8, null, 'verpleging', 2),

		(9, 'Butler', Null, 3),
		(10, 'Catering', Null, 3),
		(11, null , 'persoonlijke verzorging', 3),
		(12, null, 'verpleging', 3),

		(13, 'Butler', Null, 4),
		(14, 'Catering', Null, 4),
		(15, null , 'persoonlijke verzorging', 4),
		(16, null, 'verpleging', 4),

		(17, 'Butler', Null, 5),
		(18, 'Catering', Null, 5),
		(19, null , 'persoonlijke verzorging', 5),
		(20, null, 'verpleging', 5),

		(21, 'Butler', Null, 6),
		(22, 'Catering', Null, 6),
		(23, null , 'persoonlijke verzorging', 6),
		(24, null, 'verpleging', 6),

		(25, 'Butler', Null, 7),
		(26, 'Catering', Null, 7),
		(27, null , 'persoonlijke verzorging', 7),
		(28, null, 'verpleging', 7),

		(29, 'Butler', Null, 8),
		(30, 'Catering', Null, 8),
		(31, null , 'persoonlijke verzorging', 8),
		(32, null, 'verpleging', 8),

		(33, 'Butler', Null, 9),
		(34, 'Catering', Null, 9),
		(35, null , 'persoonlijke verzorging', 9),
		(36, null, 'verpleging', 9)

	) as S (id, dienst, zorg, resortid) on T.id = S.id
when matched then
	update set 
		dienst = S.dienst,
		zorg = S.zorg,
		resortid = S.resortid
when not matched by target then
	insert (id, dienst, zorg, resortid)
	values (id, dienst, zorg, resortid)
;

set identity_insert DIENST off