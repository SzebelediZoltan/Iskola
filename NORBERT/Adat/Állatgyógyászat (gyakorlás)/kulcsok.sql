--
-- Indexek a kiírt táblákhoz
--

--
-- A tábla indexei `fajta`
--
ALTER TABLE `fajta`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `gazda`
--
ALTER TABLE `gazda`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kezeles`
--
ALTER TABLE `kezeles`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kezelestipus`
--
ALTER TABLE `kezelestipus`
  ADD PRIMARY KEY (`id`);

--
-- A tábla indexei `kutya`
--
ALTER TABLE `kutya`
  ADD PRIMARY KEY (`id`);

-- -----------------------------------------------------------------------
--
-- Megkötések a kiírt táblákhoz
--

--
-- Megkötések a táblához `kezeles`
--
ALTER TABLE `kezeles`
  ADD CONSTRAINT `FK_kezeles_kezelestipus_id` FOREIGN KEY (`kezelestipusId`) REFERENCES `kezelestipus` (`id`),
  ADD CONSTRAINT `FK_kezeles_kutya_id` FOREIGN KEY (`kutyaId`) REFERENCES `kutya` (`id`);

--
-- Megkötések a táblához `kutya`
--
ALTER TABLE `kutya`
  ADD CONSTRAINT `FK_kutya_fajta_id` FOREIGN KEY (`fajtaId`) REFERENCES `fajta` (`id`),
  ADD CONSTRAINT `FK_kutya_gazda_id` FOREIGN KEY (`gazdaId`) REFERENCES `gazda` (`id`);