-- *********************************************
-- * Standard SQL generation                   
-- *--------------------------------------------
-- * DB-MAIN version: 11.0.2              
-- * Generator date: Sep 14 2021              
-- * Generation date: Fri Sep  1 12:46:21 2023 
-- * LUN file: C:\Users\livia\Desktop\UNI\Database\Elaborato.lun 
-- * Schema: ER/1 
-- ********************************************* 


-- Database Section
-- ________________ 

create database ER;


-- DBSpace Section
-- _______________


-- Tables Section
-- _____________ 

create table AGGIUNTA (
     Nome esercizio varchar(20) not null,
     Gruppo muscolare esercizio varchar(20) not null,
     Codice allenamento numeric(1) not null,
     constraint IDAGGIUNTA primary key (Nome esercizio, Gruppo muscolare esercizio, Codice allenamento));

create table ALLENAMENTO (
     Codice allenamento numeric(1) not null,
     Titolo varchar(50) not null,
     Data date not null,
     Durata float(1) not null,
     Livello di intensità varchar(20) not null,
     Utente -- Compound attribute -- not null,
     constraint IDALLENAMENTO_ID primary key (Codice allenamento));

create table AMICIZIA (
     Richiedente -- Compound attribute -- not null,
     Ricevente -- Compound attribute -- not null,
     Stato dell'amicizia varchar(10) not null,
     constraint IDAMICIZIA primary key (Richiedente -- Compound attribute --, Ricevente -- Compound attribute --));

create table ESERCIZIO (
     Nome varchar(20) not null,
     Gruppo muscolare  varchar(20) not null,
     Descrizione varchar(200) not null,
     Creatore -- Compound attribute -- not null,
     constraint IDESERCIZIO primary key (Nome, Gruppo muscolare ));

create table INTERAZIONE (
     ID interazione numeric(1) not null,
     Tipo di interazione char(1) not null,
     Testo[0,1] varchar(200) not null,
     Data date not null,
     Utente -- Compound attribute -- not null,
     constraint IDINTERAZIONI_ID primary key (ID interazione));

create table MEDICO (
     CF varchar(16) not null,
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Email varchar(100) not null,
     Numero di telefono numeric(1) not null,
     Specializzazione varchar(20) not null,
     constraint IDDOTTORE primary key (CF));

create table MISURAZIONE CORPOREA (
     Utente -- Compound attribute -- not null,
     Data della misurazione date not null,
     Peso float(1) not null,
     Altezza float(1) not null,
     Circonferenza vita [0,1] float(1) not null,
     Circonferenza braccia[0,1] float(1) not null,
     Circonferenza gambe[0,1] float(1) not null,
     constraint IDMISURAZIONE CORPOREA primary key (Utente -- Compound attribute --, Data della misurazione));

create table POST (
     ID post numeric(1) not null,
     Interazione char(1),
     Allenamento collegato numeric(1) not null,
     Data pubblicazione date not null,
     Titolo varchar(50) not null,
     Didascalia varchar(200) not null,
     Autore -- Compound attribute -- not null,
     constraint IDPOST primary key (ID post),
     constraint FKriferimento_ID unique (Interazione),
     constraint FKcollegamento_ID unique (Allenamento collegato));

create table UTENTE (
     ID utente -- Compound attribute -- not null,
     Nome varchar(20) not null,
     Cognome varchar(20) not null,
     Username varchar(20) not null,
     Email varchar(100) not null,
     Data di registrazione date not null,
     Numero di telefono[0,1] numeric(1) not null,
     constraint IDUTENTE_ID primary key (ID utente -- Compound attribute --));

create table VISITA (
     Codice visita numeric(1) not null,
     Data date not null,
     Ora numeric(1) not null,
     Prezzo float(1) not null,
     Paziente -- Compound attribute -- not null,
     Medico varchar(16) not null,
     constraint IDVISITA primary key (Codice visita));


-- Constraints Section
-- ___________________ 

alter table AGGIUNTA add constraint FKR
     foreign key (Nome esercizio, Gruppo muscolare esercizio)
     references ESERCIZIO;

alter table AGGIUNTA add constraint FKR_1
     foreign key (Codice allenamento)
     references ALLENAMENTO;

alter table ALLENAMENTO add constraint IDALLENAMENTO_CHK
     check(exists(select * from AGGIUNTA
                  where AGGIUNTA.Codice allenamento = Codice allenamento)); 

alter table ALLENAMENTO add constraint IDALLENAMENTO_CHK
     check(exists(select * from POST
                  where POST.Allenamento collegato = Codice allenamento)); 

alter table ALLENAMENTO add constraint FKcomposizione
     foreign key (Utente -- Compound attribute --)
     references UTENTE;

alter table AMICIZIA add constraint FKrichiede
     foreign key (Richiedente -- Compound attribute --)
     references UTENTE;

alter table AMICIZIA add constraint FKriceve
     foreign key (Ricevente -- Compound attribute --)
     references UTENTE;

alter table ESERCIZIO add constraint FKcreazione
     foreign key (Creatore -- Compound attribute --)
     references UTENTE;

alter table INTERAZIONE add constraint IDINTERAZIONI_CHK
     check(exists(select * from POST
                  where POST.Interazione = ID interazione)); 

alter table INTERAZIONE add constraint FKcondivisione
     foreign key (Utente -- Compound attribute --)
     references UTENTE;

alter table MISURAZIONE CORPOREA add constraint FKinserimento
     foreign key (Utente -- Compound attribute --)
     references UTENTE;

alter table POST add constraint FKriferimento_FK
     foreign key (Interazione)
     references INTERAZIONE;

alter table POST add constraint FKcollegamento_FK
     foreign key (Allenamento collegato)
     references ALLENAMENTO;

alter table POST add constraint FKpubblicazione
     foreign key (Autore -- Compound attribute --)
     references UTENTE;

alter table UTENTE add constraint IDUTENTE_CHK
     check(exists(select * from ALLENAMENTO
                  where ALLENAMENTO.Utente = ID utente)); 

alter table VISITA add constraint FKprenotazione
     foreign key (Paziente -- Compound attribute --)
     references UTENTE;

alter table VISITA add constraint FKeffettuazione
     foreign key (Medico)
     references MEDICO;


-- Index Section
-- _____________ 

