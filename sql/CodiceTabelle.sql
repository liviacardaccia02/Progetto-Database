use SocialNetworkPalestra;

create table AGGIUNTA (
     NomeEsercizio varchar(20) not null,
     GruppoMuscolareEsercizio varchar(20) not null,
     CodiceAllenamento int not null,
     constraint IDAGGIUNTA primary key (NomeEsercizio, GruppoMuscolareEsercizio, CodiceAllenamento));

create table ALLENAMENTO (
     CodiceAllenamento int identity(1,1) not null,
     Titolo varchar(50) not null default 'Nuovo Allenamento',
     DataAllenamento date not null default '2023-09-01',
     DurataMinuti int not null default '60',
     LivelloIntensità varchar(20) not null default 'Facile',
     Utente int not null,
     constraint IDALLENAMENTO primary key (CodiceAllenamento));

create table AMICIZIA (
     Richiedente int not null,
     Ricevente int not null,
     StatoAmicizia varchar(10) not null default 'In attesa',
     constraint IDAMICIZIA primary key (Richiedente, Ricevente));

create table ESERCIZIO (
     Nome varchar(20) not null default 'Nuovo Esercizio',
     GruppoMuscolare  varchar(20) not null default 'Gruppo muscolare non disponibile',
     Descrizione varchar(200) not null default 'Descrizione non disponibile',
     Creatore int not null,
     constraint IDESERCIZIO primary key (Nome, GruppoMuscolare));

create table INTERAZIONE (
     IDinterazione int identity(1,1) not null,
     TipoInterazione varchar(10) not null default 'Like',
     Testo varchar(200),
     Data date not null default '2023-09-01',
     Utente int not null,
     constraint IDINTERAZIONI primary key (IDinterazione));

create table MEDICO (
     CF varchar(16) not null,
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Email varchar(100) not null,
     NumeroTelefono varchar(10) not null,
     Specializzazione varchar(20) not null,
     constraint IDDOTTORE primary key (CF));

create table MISURAZIONE_CORPOREA (
     Utente int not null,
     DataMisurazione date not null,
     Peso float not null,
     Altezza float not null,
     CirconferenzaVita float,
     CirconferenzaBraccia float,
     CirconferenzaGambe float,
     constraint IDMISURAZIONE_CORPOREA primary key (Utente, DataMisurazione));

create table POST (
     IDpost int identity(1,1) not null,
     Interazione int,
     AllenamentoCollegato int not null,
     DataPubblicazione date not null,
     Titolo varchar(50) not null default 'Nuovo Post',
     Didascalia varchar(200) not null default 'Ecco il mio allenamento!',
     Autore int not null,
     constraint IDPOST primary key (IDpost),
     constraint FKriferimento_ID unique (Interazione),
     constraint FKcollegamento_ID unique (AllenamentoCollegato));

create table UTENTE (
     IDutente int identity(1,1) not null,
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Username varchar(20) not null,
     Email varchar(100) not null,
     DataRegistrazione date not null,
     NumeroTelefono varchar(10),
     constraint IDUTENTE_ID primary key (IDutente));

create table VISITA (
     CodiceVisita int identity(1,1) not null,
     DataVisita date not null,
     OraVisita time not null,
     PrezzoVisita money not null check(PrezzoVisita > 0) default '50',
     Paziente int not null,
     Medico varchar(16) not null,
     constraint IDVISITA primary key (CodiceVisita));


-- Constraints Section
-- ___________________ 

alter table AGGIUNTA add constraint FKR
     foreign key (NomeEsercizio, GruppoMuscolareEsercizio)
     references ESERCIZIO;

alter table AGGIUNTA add constraint FKR_1
     foreign key (CodiceAllenamento)
     references ALLENAMENTO;

--alter table ALLENAMENTO add constraint IDALLENAMENTO_CHK
--     check(exists(select * from AGGIUNTA
--                  where AGGIUNTA.CodiceAllenamento = CodiceAllenamento)); 

--alter table ALLENAMENTO add constraint IDALLENAMENTO_CHK
--     check(exists(select * from POST
--                  where POST.AllenamentoCollegato = CodiceAllenamento)); 

alter table ALLENAMENTO add constraint FKcomposizione
     foreign key (Utente)
     references UTENTE;

alter table AMICIZIA add constraint FKrichiede
     foreign key (Richiedente)
     references UTENTE;

alter table AMICIZIA add constraint FKriceve
     foreign key (Ricevente)
     references UTENTE;

alter table ESERCIZIO add constraint FKcreazione
     foreign key (Creatore)
     references UTENTE;

--alter table INTERAZIONE add constraint IDINTERAZIONI_CHK
--     check(exists(select * from POST
--                  where POST.Interazione = IDinterazione)); 

alter table INTERAZIONE add constraint FKcondivisione
     foreign key (Utente)
     references UTENTE;

alter table MISURAZIONE_CORPOREA add constraint FKinserimento
     foreign key (Utente)
     references UTENTE;

alter table POST add constraint FKriferimento_FK
     foreign key (Interazione)
     references INTERAZIONE;

alter table POST add constraint FKcollegamento_FK
     foreign key (AllenamentoCollegato)
     references ALLENAMENTO;

alter table POST add constraint FKpubblicazione
     foreign key (Autore)
     references UTENTE;

alter table VISITA add constraint FKprenotazione
     foreign key (Paziente)
     references UTENTE;

alter table VISITA add constraint FKeffettuazione
     foreign key (Medico)
     references MEDICO;
