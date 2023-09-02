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

INSERT INTO ESERCIZIO (Nome, GruppoMuscolare, Descrizione)
VALUES
	('Lat pulldown', 'Schiena', 'esercizio da eseguire con apposito macchinario'),
	('Dip', 'Petto', 'esercizio che può essere fatto sia con la macchina che con un peso'),
	('Tapis roulant', 'Cardio', 'corsa lenta o accelerata adatta al riscaldamento'),
	('Curl', 'Bicipiti', 'movimento da eseguire con manubri'),
	('Crunch', 'Addominali', 'consigliato uso di un tappetino'),
	('Squat', 'Glutei', 'si può effettuare a corpo libero o col bilanciere');
