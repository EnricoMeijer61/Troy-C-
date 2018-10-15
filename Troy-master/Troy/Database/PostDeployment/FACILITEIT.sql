set identity_insert FACILITEIT on

merge into FACILITEIT as T using
	(values
		(1, 'Restaurant', 1),
		(2, 'Pizza Restaurant', 1),
		(3, 'Snackbar', 1),
		(4, 'Grand Café', 1),
		(5, 'Bowlingbanen', 1),
		(6, 'Winkelcentrum', 1),
		(7, 'Supermarkt', 1),
		(8, 'Spa en Wellness', 1),
		(9, 'Subtropisch Zwembad', 1),
		(10, 'Paintball', 1),
		(11, 'Indoor Skihal', 1),
		(12, 'High Adventure en Sport Center', 1),
		(13, 'Klimwand', 1),
		(14, 'Skydiving', 1),

		(15, 'Restaurant', 2),
		(16, 'Pizza Restaurant', 2),
		(17, 'Snackbar', 2),
		(18, 'Grand Café', 2),
		(19, 'Bowlingbanen', 2),
		(20, 'Supermarkt', 2),
		(21, 'Spa en Wellness', 2),
		(22, 'Subtropisch Zwembad', 2),
		(23, 'Indoor Skihal', 2),
		(24, 'High Adventure en Sport Center', 2),
		(25, 'Klimwand', 2),
		(26, 'Stilteruimte en meditatieruimte', 2),
		(27, 'Excursies en dagtips', 2),
		(28, 'Parachute springen en ballonvaart(op eigen risico)', 2),

		(29, 'Restaurant', 3),
		(30, 'Pizza Restaurant', 3),
		(31, 'Snackbar', 3),
		(32, 'Grand Café', 3),
		(33, 'Supermarkt', 3),
		(34, 'Spa en Wellness', 3),
		(35, 'Subtropisch Zwembad', 3),
		(36, 'Paintball', 3),
		(37, 'Indoor Skihal', 3),
		(38, 'Excursies en dagtips', 3),

		(39, 'Restaurant', 4),
		(40, 'Pizza Restaurant', 4),
		(41, 'Snackbar', 4),
		(42, 'Grand Café', 4),
		(43, 'Bowlingbanen', 4),
		(44, 'Supermarkt', 4),
		(45, 'Spa en Wellness', 4),
		(46, 'Subtropisch Zwembad', 4),
		(47, 'Indoor Skihal', 4),
		(48, 'High Adventure en Sport Center', 4),
		(49, 'Klimwand', 4),
		(50, 'Stilteruimte en meditatieruimte', 4),
		(51, 'Excursies en dagtips', 4),
		(52, 'Parachute springen en ballonvaart(op eigen risico)', 4),

		(53, 'Restaurant', 5),
		(54, 'Pizza Restaurant', 5),
		(55, 'Snackbar', 5),
		(56, 'Grand Café', 5),
		(57, 'Bowlingbanen', 5),
		(58, 'Supermarkt', 5),
		(59, 'Spa en Wellness', 5),
		(60, 'Subtropisch Zwembad', 5),
		(61, 'Indoor Skihal', 5),
		(62, 'High Adventure en Sport Center', 5),
		(63, 'Klimwand', 5),
		(64, 'Stilteruimte en meditatieruimte', 5),
		(65, 'Excursies en dagtips', 5),
		(66, 'Parachute springen en ballonvaart(op eigen risico)', 5),

		
		(67, 'Restaurant', 6),
		(68, 'Pizza Restaurant', 6),
		(69, 'Snackbar', 6),
		(70, 'Grand Café', 6),
		(71, 'Bowlingbanen', 6),
		(72, 'Supermarkt', 6),
		(73, 'Spa en Wellness', 6),
		(74, 'Subtropisch Zwembad', 6),
		(75, 'Indoor Skihal', 6),
		(76, 'High Adventure en Sport Center', 6),
		(77, 'Klimwand', 6),
		(78, 'Stilteruimte en meditatieruimte', 6),
		(79, 'Excursies en dagtips', 6),
		(80, 'Parachute springen en ballonvaart(op eigen risico)', 6),

		(81, 'Restaurant', 7),
		(82, 'Snackbar', 7),
		(83, 'Grand Café', 7),
		(84, 'Bowlingbanen', 7),
		(85, 'Supermarkt', 7),
		(86, 'Spa en Wellness', 7),
		(87, 'Indoor Skihal', 7),
		(88, 'High Adventure en Sport Center', 7),
		(89, 'Excursies en dagtips', 7),
		(90, 'Parachute springen en ballonvaart(op eigen risico)', 7),
		
		(91, 'Restaurant', 8),
		(92, 'Snackbar', 8),
		(93, 'Grand Café', 8),
		(94, 'Bowlingbanen', 8),
		(95, 'Supermarkt', 8),
		(96, 'Spa en Wellness', 8),
		(97, 'Indoor Skihal', 8),
		(98, 'High Adventure en Sport Center', 8),
		(99, 'Excursies en dagtips', 8),
		(100, 'Parachute springen en ballonvaart(op eigen risico)', 8),

		(101, 'Restaurant', 9),
		(102, 'Pizza Restaurant', 9),
		(103, 'Snackbar', 9),
		(104, 'Grand Café', 9),
		(105, 'Bowlingbanen', 9),
		(106, 'Supermarkt', 9),
		(107, 'Spa en Wellness', 9),
		(108, 'Subtropisch Zwembad', 9),
		(109, 'Indoor Skihal', 9),
		(110, 'High Adventure en Sport Center', 9),
		(111, 'Klimwand', 9),
		(112, 'Stilteruimte en meditatieruimte', 9),
		(113, 'Excursies en dagtips', 9),
		(114, 'Parachute springen en ballonvaart(op eigen risico)', 9)
		


		
	
		

	 )as S (id, faciliteit, resortid) on T.id = S.id
when matched then
	update set 
		faciliteist = S.faciliteist,
		resortid = S.resortid
when not matched by target then
	insert (id, faciliteit, resortid)
	values (id, faciliteit, resortid)
;

set identity_insert FACILITEIT off