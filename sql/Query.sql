use SocialNetworkPalestra;

-- OP 1
--INSERT INTO UTENTE (Nome, Cognome, Username, Email, DataRegistrazione, NumeroTelefono)
--VALUES (?, ?, ?, ?, ?, ?)

-- OP 2
--INSERT INTO MISURAZIONE_CORPOREA (Utente, DataMisurazione, Peso, Altezza,
-- CirconferenzaVita, CirconferenzaBraccia, CirconferenzaGambe)
--VALUES (?, ?, ?, ?, ?, ?, ?)

-- OP 3
--INSERT INTO ESERCIZIO (Nome, GruppoMuscolare, Descrizione, Creatore)
--VALUES (?, ?, ?, ?)

-- OP 4
--SELECT E.Nome as 'Esercizio', E.GruppoMuscolare as 'Gruppo muscolare coinvolto',
--E.Descrizione, U.Username as 'Creatore'
--FROM ESERCIZIO E, UTENTE U
--WHERE E.Creatore = U.IDutente


-- OP 5
--INSERT INTO ALLENAMENTO (Titolo, Data, Durata, LivelloIntesità, Utente)
--VALUES (?, ?, ?, ?, ?)

--INSERT INTO AGGIUNTA (NomeEsercizio, GruppoMuscolareEsercizio, CodiceAllenamento)
--VALUES (?, ?, ?)

-- OP 6
--SELECT AL.Titolo AS 'Allenamento', E.Nome AS 'Nome esercizio', E.GruppoMuscolare
--FROM AGGIUNTA A
--FULL JOIN ESERCIZIO E ON (E.Nome = A.NomeEsercizio) AND (E.GruppoMuscolare = A.GruppoMuscolareEsercizio)
--LEFT JOIN ALLENAMENTO AL ON (A.CodiceAllenamento = AL.CodiceAllenamento)
--WHERE A.CodiceAllenamento = 9
 
-- OP 7
--INSERT INTO POST (Interazione, AllenamentoCollegato, DataPubblicazione, Titolo, Didascalia, Autore)
--VALUES (?, ?, ?, ?, ?)

-- OP 8
--SELECT U.Nome, U.Cognome, U.Username, P.Titolo as 'Post pubblicato',
--P.DataPubblicazione as 'Data di pubblicazione'
--FROM UTENTE U
--LEFT JOIN POST P ON U.IDutente = P.Autore
--WHERE U.IDutente = 1

-- OP 9
--SELECT U1.Username, U2.Username as 'Follower', A.StatoAmicizia
--FROM UTENTE U1
--LEFT JOIN AMICIZIA A ON U1.IDutente = A.Ricevente
--FULL JOIN  UTENTE U2 ON A.Richiedente = U2.IDutente
--WHERE U1.IDutente = 1

-- OP 10
--SELECT Nome, Cognome, Specializzazione
--FROM MEDICO

-- OP 11
--INSERT INTO MEDICO (CF, Nome, Cognome, Email, NumeroTelefono, Specializzazione)
--VALUES (?, ?, ?, ?, ?, ?)

-- OP 12
--INSERT INTO VISITA (Data, Ora, Prezzo, Paziente)
--VALUES (?, ?, ?, ?)
