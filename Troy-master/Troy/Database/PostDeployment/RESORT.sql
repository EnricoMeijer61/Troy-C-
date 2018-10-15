set identity_insert RESORT on

merge into RESORT as T using
	(values
		(1, 'De Zandhoeven (NL)', 'Een verblijf in De Zandhoeven staat garant voor een sportieve en actieve vakantie. Watersporten op het Zandhoevermeer, fietstochten maken doorheen het prachtige Nederland, de kinderboerderij bezoeken, midgetgolf spelen en voor echte waaghalzen het Via Alpa  klimparcours - aan het einde van de dag kan u uitrusten in uw boerderij of Villa. De spa en wellness is van 06:00 – 23:30 uur geopend.'),
		(2, 'De Merenvogel (NL)', 'De Merenvogel heeft koninklijke uitstraling en huiselijke warmte. Kom binnen in onze prachtige lobby en voel onmiddellijk het inspirerende effect. De sfeer van een paleis – met hoge gewelven en schitterende kroonluchters – en met een uiterst persoonlijk ontvangst door onze Clefs d’Or concierges die u begroeten aan de antieke balie in de lobby. Terwijl wij u inchecken, kunt u genieten van een glaasje champagne of een kijkje nemen op het terras langs de rivier. Dit prestigieuze Merenvogel park  ligt in het hartje van het groene hart, op het kruispunt van de groene, culturele en shoppingsgebieden, en heet u welkom met een rijke combinatie van klassieke elegantie en moderne luxe.'),
		(3, 'Zweedse bruegel (NL)', 'De Zweedse bruegel heeft vakantiehuisje op het platteland. Ideaal om in de zomer het stadsleven te ontvluchten en om in de winter volop van de sneeuw te kunnen genieten. U zult onder de indruk zijn van de fantastische ligging aan het water van de Sonderdam, de prachtige natuurlijke omgeving en de ruime opzet van dit luxe vakantiepark. Vanuit uw ruime, comfortabel ingerichte vakantiewoning of op uw boot in onze eigen jachthaven kunt u uren wegdromen en moeiteloos de alledaagse drukte achter u laten ... of lekker actief bezig zijn, wandelen en fietsen in de omgeving en uitstapjes maken! Hier komt u op adem en zult u recreëren zonder zorgen.'),
		(4, 'Prora Park (D)', 'Ontworpen door een speer van een architect midden in de jaren 30 waarin de beton bouw erg in  opkomst was. Dit speciale park was ontworpen voor de trend van grote groepsreizen (al dan niet verplicht).  In de jaren 90 geheel opgeknapt en geschikt gemaakt voor een uitgestrekt luxe vakantie met uw gehele gezin.  Er is plaats voor uw boot in onze eigen jachthaven. (ook geschikt voor lange boten). Terwijl wij u inchecken, kunt u genieten van een glaasje champagne.  Er is buiten een kinderboerderij en een midgetgolf.')
		(5, 'Westseepark (D)', 'In de bossen zo’n 4 km ten zuidwesten van Sweeland ligt Westseepark naast natuurgebied Malle Babbe. Het ‘enorm grote’ park heeft een ‘prachtige’ natuur met onder andere twee meren, waar u ‘heerlijk fietsen’ kunt. Voor jong en oud, sportief en niet-sportief, de gasten geven aan dat ‘voor eenieder veel te doen’ is in vakantiepark Westseepark.  Aan de kant is het dorpje met ‘veel’ barretjes, restaurantjes en winkels. Op het park is een ‘oase van rust’.'),
		(6, 'Kehlsteinhausser park (D)', 'Heerlijk ontwaken, ontbijten op je terras met een weergaloos uitzicht en een frisse sprong in je zwembad. Je vakantiedag kan niet beter beginnen! In de luxe vakantiehuizen van Kehlsteinhausser  Villa’s  is het op en top genieten! In de warme zomermaanden is een buitenzwembad een welkome verfrissing. Baantjes trekken in de ochtend, zonnebaden in de middag en genieten van een wijntje aan de rand van het bad in de avonduren. Voor een winterse vakantie zit je eveneens goed in een vakantievilla van Kehlsteinhausser Villa’s. Tussen het veelzijdige aanbod bevinden zich genoeg luxe vakantiehuizen met een binnenzwembad of een sauna waar het heerlijk bijkomen is. Na een stevige wandeling in het winterse landschap of een sportieve dag op de piste warm je je op bij de open haard in je vakantievilla'),
		(7, 'Villa Rosenrot (D)', 'De Villa Rosenrot zijn  groot en bieden 2 tot 4 slaapkamers. De Villa beschikken over een eigen, grote tuin, een privézwembad, een Mauretiaanse veranda, een ruime lounge en een volledig uitgeruste keuken. De Villa in Belek beschikken over 2 slaapkamers, een sauna en twee privé zwembad, waarvan een binnen en een buiten.'),
		(8, 'Stoneage park (UK)', 'empty'),
		(9, 'Thatcher Great Park (UK)', 'empty')
	) as S (id, naam, bio) on T.id = S.id
when matched then
	update set 
		naam = S.naam,
		bio = S.bio
when not matched by target then
	insert (id, naam, bio)
	values (id, naam, bio)
;

set identity_insert RESORT off