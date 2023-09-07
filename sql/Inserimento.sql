use SocialNetworkPalestra;

INSERT INTO UTENTE (Nome, Cognome, Username, Email, DataRegistrazione, NumeroTelefono)
VALUES 
    ('Livia', 'Cardaccia', 'nitritodisodio', 'liviacardaccia99@gmail.com', '2023-06-01', '3982455678'),
    ('Jane', 'Smith', 'janesmith', 'janesmith@gmail.com', '2023-08-02', '3674566789'),
    ('Michael', 'Johnson', 'michaelj', 'michael@gmail.com', '2023-08-03', '3456789012'),
    ('Emily', 'Brown', 'emilyb', 'emily@yahoo.com', '2023-08-04', '3567890123'),
    ('William', 'Lee', 'williaml', 'william@yahoo.com', '2023-08-05', '3678901234'),
    ('Olivia', 'Wilson', 'oliviaw', 'olivia@hotmail.com', '2023-08-06', '3789012345'),
    ('James', 'Anderson', 'jamesa', 'james@hotmail.com', '2023-08-07', '3890123456'),
    ('Emma', 'Garcia', 'emmag', 'emma@gmail.com', '2023-08-08', '3901234567'),
    ('Liam', 'Martinez', 'liamm', 'liam@gmail.com', '2023-08-09', '3012345678'),
    ('Ava', 'Clark', 'avaclark', 'ava@gmail.com', '2023-08-10', '3123456789'),
    ('Noah', 'Hernandez', 'noahh', 'noah@yahoo.com', '2023-08-11', '3876543210'),
    ('Isabella', 'Lopez', 'isabellal', 'isabella@yahoo.com', '2023-08-12', '3765432109'),
    ('Sophia', 'Gonzalez', 'sophiag', 'sophia@hotmail.com', '2023-08-13', '3653431098'),
    ('Mia', 'Perez', 'miap', 'mia@hotmail.com', '2023-08-14', '3543210987'),
    ('Benjamin', 'Smith', 'benjamins', 'benjamin@gmail.com', '2023-08-15', '3432109876'),
    ('Elijah', 'Davis', 'elijahd', 'elijah@gmail.com', '2023-08-16', '3321098765'),
    ('Lucas', 'Rodriguez', 'lucasr', 'lucas@gmail.com', '2023-08-17', '3210987654'),
    ('Henry', 'Brown', 'henryb', 'henry@yahoo.com', '2023-08-18', '3109876543'),
    ('Aria', 'Williams', 'ariaw', 'aria@yahoo.com', '2023-08-19', '3098765432'),
    ('Mason', 'Moore', 'masonm', 'mason@hotmail.com', '2023-08-20', '3987654321'),
	('Marco', 'Rossi', 'marcorossi', 'marcorossi@gmail.com', '2022-01-15', '3331234567'),
    ('Anna', 'Bianchi', 'annabianchi', 'annabianchi@gmail.com', '2022-02-20', '3472345678'),
    ('Luca', 'Ferrari', 'lucaferrari', 'lucaferrari@gmail.com', '2022-03-25', '3453456789'),
    ('Giulia', 'Romano', 'giuliaromano', 'giuliaromano@libero.com', '2022-04-30', '3664567890'),
    ('Paolo', 'Esposito', 'paoloesposito', 'paoloesposito@libero.com', '2022-05-05', '3335678901'),
    ('Francesca', 'Ricci', 'francescaricci', 'francescaricci@libero.com', '2022-06-10', '3476789012'),
    ('Davide', 'Gallo', 'davidegallo', 'davidegallo@yahoo.com', '2022-07-15', '3457890123'),
    ('Sara', 'Conti', 'saraconti', 'saraconti@yahoo.com', '2022-08-20', '3668901234'),
    ('Alessio', 'Mancini', 'alessiomancini', 'alessiomancini@yahoo.com', '2022-09-25', '3339012345'),
    ('Valentina', 'Martini', 'valentinamartini', 'valentinamartini@gmail.com', '2022-10-30', '3470123456'),
    ('Giovanni', 'Barbieri', 'giovannibarbieri', 'giovannibarbieri@gmail.com', '2022-11-05', '3451234567'),
    ('Laura', 'Pellegrini', 'laurapellegrini', 'laurapellegrini@gmail.com', '2022-12-10', '3662345678'),
    ('Andrea', 'Rizzo', 'andrearizzo', 'andrearizzo@libero.com', '2022-01-15', '3333456789'),
    ('Roberta', 'Greco', 'robertagreco', 'robertagreco@libero.com', '2022-02-20', '3474567890'),
    ('Matteo', 'Lombardi', 'matteolombardi', 'matteolombardi@libero.com', '2022-03-25', '3455678901'),
    ('Simona', 'Ferrara', 'simonaferrara', 'simonaferrara@yahoo.com', '2022-04-30', '3666789012'),
    ('Nicola', 'Santoro', 'nicolasantoro', 'nicolasantoro@yahoo.com', '2022-05-05', '3337890123'),
    ('Elisa', 'Galli', 'elisagalli', 'elisagalli@yahoo.com', '2022-06-10', '3478901234'),
    ('Alessandro', 'Rinaldi', 'alessandrorinaldi', 'alessandrorinaldi@gmail.com', '2022-07-15', '3459012345'),
    ('Cristina', 'Ferri', 'cristinaferri', 'cristinaferri@gmail.com', '2022-08-20', '3660123456');

INSERT INTO MEDICO (CF, Nome, Cognome, Email, NumeroTelefono, Specializzazione)
VALUES
    ('ABCDEF12A34B567C', 'Mario', 'Rossi', 'mario.rossi@gmail.com', '3234567890', 'Fisioterapista'),
    ('GHIJKL56M78N123O', 'Anna', 'Bianchi', 'anna.bianchi@gmail.com', '3345678901', 'Nutrizionista'),
    ('PQRSTU90V12W345X', 'Luca', 'Verdi', 'luca.verdi@gmail.com', '3456789012', 'Medico Sportivo'),
    ('YZABCD34E56F789G', 'Sara', 'Neri', 'sara.neri@gmail.com', '3567890123', 'Fisioterapista'),
    ('HIJKLM78N90P123Q', 'Paolo', 'Russo', 'paolo.russo@gmail.com', '3678901234', 'Nutrizionista'),
    ('RSTUVW12X34Y567Z', 'Laura', 'Marrone', 'laura.marrone@gmail.com', '3789012345', 'Medico Sportivo'),
    ('EFGHIJ67K89L012M', 'Marco', 'Gialli', 'marco.gialli@gmail.com', '3890123456', 'Fisioterapista'),
    ('NOPQRS90T12U345V', 'Giulia', 'Ferrari', 'giulia.ferrari@gmail.com', '3901234567', 'Nutrizionista'),
    ('WXYZAB12C34D567E', 'Simone', 'Bianco', 'simone.bianco@gmail.com', '3012345678', 'Medico Sportivo'),
    ('F12345G67H89I012', 'Roberto', 'Verde', 'roberto.verde@gmail.com', '3123456789', 'Fisioterapista');

INSERT INTO VISITA (DataVisita, OraVisita, PrezzoVisita, Paziente, Medico)
VALUES 
    ('2023-09-01', '09:00:00', 35, 21, 'F12345G67H89I012'),
    ('2023-09-04', '14:30:00', 35, 22, 'GHIJKL56M78N123O'),
    ('2023-09-06', '09:30:00', 55, 23, 'HIJKLM78N90P123Q'),
    ('2023-09-07', '11:15:00', 60, 24, 'HIJKLM78N90P123Q'),
    ('2023-09-08', '13:45:00', 40, 25, 'NOPQRS90T12U345V'),
    ('2023-09-10', '17:30:00', 70, 26, 'PQRSTU90V12W345X'),
    ('2023-09-11', '09:15:00', 45, 27, 'RSTUVW12X34Y567Z'),
    ('2023-09-12', '10:45:00', 75, 28, 'WXYZAB12C34D567E'),
    ('2023-09-13', '12:30:00', 80, 29, 'YZABCD34E56F789G'),
    ('2023-09-17', '11:30:00', 100, 30, 'GHIJKL56M78N123O'),
    ('2023-09-18', '13:00:00', 60, 31, 'RSTUVW12X34Y567Z');

INSERT INTO ESERCIZIO (Nome, GruppoMuscolare, Descrizione)
VALUES
	('Lat pulldown', 'Schiena', 'esercizio da eseguire con apposito macchinario'),
	('Dip', 'Petto', 'esercizio che può essere fatto sia con la macchina che con un peso'),
	('Tapis roulant', 'Cardio', 'corsa lenta o accelerata adatta al riscaldamento'),
	('Curl', 'Bicipiti', 'movimento da eseguire con manubri'),
	('Crunch', 'Addominali', 'consigliato uso di un tappetino'),
	('Squat', 'Glutei', 'si può effettuare a corpo libero o col bilanciere');

INSERT INTO ALLENAMENTO (Titolo, DataAllenamento, DurataMinuti, LivelloIntensità, Utente)
VALUES
	('Allenamento serale', '2023-05-25', 90, 'Medio', 37),
	('Allenamento mattutino', '2022-05-30', 30, 'Facile', 34),
	('Extreme workout', '2023-04-20', 120, 'Difficile', 9),
	('Chest massacre', '2023-07-09', 120, 'Difficile', 3),
	('Allenamento glutei', '2023-06-10', 90, 'Medio', 23),
	('Il mio primo allenamento', '2023-07-21', 30, 'Facile', 38),
	('Riscaldamento', '2023-08-29', 15, 'Facile', 29),
	('Pilates', '2023-08-08', 50, 'Facile', 16),
	('Cardio', '2023-03-25', 45, 'Medio', 18),
	('Leg day', '2023-02-04', 90, 'Difficile', 11),
	('Upper body', '2023-02-13', 60, 'Medio', 13);

INSERT INTO INTERAZIONE (TipoInterazione, Testo, Data, Utente)
VALUES 
    ('Like', NULL, '2022-09-15', 2),
    ('Like', NULL, '2022-08-20', 3),
    ('Like', NULL, '2023-08-10', 4),
    ('Commento', 'Buon allenamento!', '2023-07-25', 1),
    ('Commento', 'Great workout!', '2023-08-05', 5),
    ('Like', NULL, '2023-06-08', 6),
    ('Like', NULL, '2023-07-09', 7),
    ('Commento', 'Ottimo lavoro!', '2023-03-12', 21),
    ('Commento', 'Good job!', '2023-08-12', 8),
    ('Like', NULL, '2023-09-01', 9),
    ('Commento', 'Bene!', '2023-03-20', 22),
    ('Commento', 'Fantastic workout!', '2022-10-28', 14),
    ('Like', NULL, '2023-02-18',23),
    ('Commento', 'Eccellente!', '2022-09-22', 24),
    ('Like', NULL, '2022-12-20', 25),
    ('Commento', 'Molto bravo!', '2023-01-15', 26),
    ('Like', NULL, '2022-11-08', 27),
    ('Like', NULL, '2023-03-05', 28),
    ('Like', NULL, '2023-03-01', 29),
    ('Commento', 'Well done!', '2023-08-16', 15),
    ('Commento', 'Bravissimo!', '2022-12-10', 30),
    ('Commento', 'Excellent job!', '2023-08-25', 16),
    ('Like', NULL, '2022-11-10', 31),
    ('Like', NULL, '2023-02-10', 32),
    ('Like', NULL, '2022-10-05', 33),
    ('Commento', 'Keep it up!', '2023-08-28', 17),
    ('Like', NULL, '2022-09-05', 34);

INSERT INTO POST (Interazione, AllenamentoCollegato, DataPubblicazione, Titolo, Didascalia, Autore)
VALUES 
	(5, 5, '2023-05-25', 'Serata tranquilla', 'Allenamento tranquilla e poi relax', 37),
	(3, 6, '2022-05-30', 'Buongiornissimo', 'Il modo migliore per iniziare la giornata', 34),
	(7, 7, '2023-04-20', 'The struggle is real!', 'currently sweating', 9),
	(11, 8, '2023-07-09', 'Chest massacre', 'My fav workout', 3),
	(10, 9, '2023-06-10', 'Glutei on fire', 'Mi preparo alla prossima estate :)', 23),
	(23, 10, '2023-07-21', 'Ciao a tutti', 'ciao', 38),
	(16, 11, '2023-08-29', 'Riscaldamento', 'Per iniziare al meglio', 29),
	(13, 12, '2023-08-08', 'Lezione di pilates', 'Adoro le lezioni online', 16);

INSERT INTO MISURAZIONE_CORPOREA(Utente, DataMisurazione, Peso, Altezza, CirconferenzaVita, CirconferenzaBraccia, CirconferenzaGambe)
VALUES 
    (1, '2023-06-01', 75.5, 175, 80, 30, 40),
    (2, '2023-08-02', 70, 180, 75, 28, 38),
    (3, '2023-08-03', 80, 170, 85, 32, 42),
    (4, '2023-08-04', 68, 172, 78, 29, 39),
    (5, '2023-08-05', 72, 178, 82, 31, 41),
    (6, '2023-08-06', 76, 173, 81, 30.5, 40.5),
    (7, '2023-08-07', 71.5, 176, 79, 29.5, 39.5),
    (8, '2023-08-08',  78, 172, 86, 33, 43),
    (9, '2023-08-09', 69, 179, 76, 28.5, 38.5),
    (10, '2023-08-10', 73, 174, 83, 31.5, 41.5);