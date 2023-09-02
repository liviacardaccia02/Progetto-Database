use SocialNetworkPalestra;

-- OP 1
--INSERT INTO UTENTE (Nome, Cognome, Username, Email, DataRegistrazione, NumeroTelefono)
--VALUES (?, ?, ?, ?, ?, ?)-- OP 2--INSERT INTO MISURAZIONE_CORPOREA (Utente, DataMisurazione, Peso, Altezza, CirconferenzaVita, CirconferenzaBraccia, CirconferenzaGambe)
--VALUES (?, ?, ?, ?, ?, ?, ?)-- OP 3--INSERT INTO ESERCIZIO (Nome, GruppoMuscolare, Descrizione, Creatore)
--VALUES (?, ?, ?, ?)

-- OP 4
--SELECT Nome as 'Nome esercizio', GruppoMuscolare as 'Muscoli coinvolti', Descrizione
--FROM ESERCIZIO

-- OP 5
--INSERT INTO ALLENAMENTO (Titolo, Data, Durata, LivelloIntesità, Utente)
--VALUES (?, ?, ?, ?, ?)--INSERT INTO AGGIUNTA (NomeEsercizio, GruppoMuscolareEsercizio, CodiceAllenamento)
--VALUES (?, ?, ?)-- OP 6--INSERT INTO AGGIUNTA (NomeEsercizio, GruppoMuscolareEsercizio, CodiceAllenamento)
--VALUES (?, ?, ?) -- OP 7--INSERT INTO POST (AllenamentoCollegato, DataPubblicazione, Titolo, Didascalia, Autore)
--VALUES (?, ?, ?, ?, ?)-- OP 8--INSERT INTO INTERAZIONE (TipoInterazione, Testo, Data, Utente)
--VALUES (’C’, ?, ?, ?)-- OP 9--INSERT INTO INTERAZIONE (TipoInterazione, Testo, Data, Utente)
--VALUES (’L’, ?, ?, ?)-- OP 10--INSERT INTO AMICIZIA (Richiedente, Ricevente, StatoAmicizia)
--VALUES (?, ?, ’In attesa’)

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