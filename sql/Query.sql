use SocialNetworkPalestra;

-- OP 1
--INSERT INTO UTENTE (Nome, Cognome, Username, Email, DataRegistrazione, NumeroTelefono)
--VALUES (?, ?, ?, ?, ?, ?)
--VALUES (?, ?, ?, ?, ?, ?, ?)
--VALUES (?, ?, ?, ?)

-- OP 4
--SELECT Nome as 'Nome esercizio', GruppoMuscolare as 'Muscoli coinvolti', Descrizione
--FROM ESERCIZIO

-- OP 5
--INSERT INTO ALLENAMENTO (Titolo, Data, Durata, LivelloIntesit�, Utente)
--VALUES (?, ?, ?, ?, ?)
--VALUES (?, ?, ?)
--VALUES (?, ?, ?)
--VALUES (?, ?, ?, ?, ?)
--VALUES (�C�, ?, ?, ?)
--VALUES (�L�, ?, ?, ?)
--VALUES (?, ?, �In attesa�)

-- OP 11
--UPDATE AMICIZIA
--SET StatoAmicizia = ?
--WHERE Richiedente = ? AND Ricevente = ?

-- OP 12
--INSERT INTO MEDICO (CF, Nome, Cognome, Email, NumeroTelefono, Specializzazione)
--VALUES (?, ?, ?, ?, ?, ?)

-- OP 13
--INSERT INTO VISITA (Data, Ora, Prezzo, Paziente)
--VALUES (?, ?, ?, ?)

-- OP 14
--UPDATE VISITA
--SET Medico = ?
--WHERE CodiceVisita = ?