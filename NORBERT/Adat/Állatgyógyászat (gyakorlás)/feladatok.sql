--Bónusz:
--2.
SELECT COUNT(*), AVG(dij)
FROM kutya INNER JOIN kezeles ON kutya.id = kezeles.kutyaid
WHERE korEv < 2 OR (korEv = 2 AND korHonap < 6)

--3.
SELECT gazda.nev
FROM gazda LEFT JOIN kutya ON gazda.id = kutya.gazdaid
WHERE kerulet = 20
GROUP BY gazda.id
HAVING COUNT(kutya.id) <= 1
UNION
SELECT gazda.nev
FROM
    gazda 
    INNER JOIN kutya ON gazda.id = kutya.gazdaid
    INNER JOIN kezeles ON kutya.id = kezeles.kutyaid
GROUP BY gazda.id
HAVING SUM(dij) >= 100000