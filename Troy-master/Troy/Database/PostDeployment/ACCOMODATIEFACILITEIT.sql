set identity_insert ACCOMODATIEFACILITEIT on

merge into ACCOMODATIEFACILITEIT as T using
	(values
		(1, 'infrarood sauna', 1),
		(2, 'whirlpool', 1),
		(3, 'gashaard', 1),
		(4, 'led-tv', 1),
		(5, 'home cinema', 1),
		(6, 'afwasmachine', 1),
		(7, 'vloerverwarming', 1),
		(8, 'combimagnetron/oven', 1),
		(9, 'terras', 1),
		(10, 'bediening schoonmaak/opruim service',1),
		(11, 'nespresso-koffiezetapparaat', 1),
		(12, 'internet', 1),
		(13, 'gastenruimte', 1),

	    (14, 'flatscreen TV 60', 2),
		(15, 'open haard', 2),
		(16, 'homecinema met DVD-speler', 2),
		(17, 'luxe keuken met oven',2),
		(18, 'magnetron',2),
		(19, 'vaatwasser', 2),
		(20, 'douche', 2),
		(21, 'bad', 2),
		(22, 'infrarood sauna', 2),
		(23, 'whirepool', 2),
		(24, 'schoonmaak en opruim service', 2),
		(25, 'Nespresso-koffiezetapparaat', 2),
		(26, 'internet', 2),

		(27, 'zwembad',3),
		(28, 'pizza-oven', 3),
		(29, 'barbecue',3),
		(30, 'veranda',3),
		(31, 'infrarood sauna',3),
		(32, 'whirlpool', 3),
		(33, 'gashaard', 3),
		(34, 'LCD-tv',3),
		(35, 'home cinema set',3),
		(36, 'afwasmachine', 3),
		(37, 'vloerverwarming', 3),
		(38, 'combimagnetron/oven',3),
		(39, 'terras',3),
		(40,'bediening/schoonmaak en opruim service'),
		(41, 'nespresso-koffiezetapparaat'),
		(42, 'internet',3),
		(43 , 'gastenruimte', 3),

		(44, 'golfslagbad' , 4),
		(45, 'theater', 4),
		(46, 'bioscoop', 4),
		(47, 'feestzaal', 4)






	) as S (id, faciliteit, accomodatieid) on T.id = S.id
when matched then
	update set 
		faciliteit = S.faciliteit,
		accomodatieid = S.accomodatieid
when not matched by target then
	insert (id, faciliteit, accomodatieid)
	values (id, faciliteit, accomodatieid)
;

set identity_insert ACCOMODATIEFACILITEIT off