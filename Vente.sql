create database Vente
use [Vente]
create table Client 
(
  CodeCl varchar(30) primary key not null,
  Nom varchar(40) not null,
  Prenom varchar(40) not null,
  Adresse varchar(100) not null,
  Tel varchar(15) not null,
  Email varchar(255) Unique not null,
  Ville varchar(30) not null,
)
create table Categorie  
(
  CodeCat varchar(30) primary key not null,
  Libelle varchar(30) not null,
)
create table Article  
(
  CodeArt varchar(30) primary key not null,
  Designation varchar(40)  not null,
  PU varchar(30) not null,
  QStock int not null,
  Photo image not null,
  CodeCategorie varchar(30) foreign key references Categorie(CodeCat) not null,
)
create table Commande  
(
  NumCom varchar(20) primary key not null,
  DateCom datetime not null,
  CodeCl varchar(30) foreign key references Client(CodeCl) not null,
)
create table Detail   
(
  NumCom varchar(20) foreign key references Commande(NumCom) not null, 
  CodeArt varchar(30) foreign key references Article(CodeArt) not null,
  QteCommandee int not null,
)
create table Facture   
(
  NumeroFact varchar(30) primary key not null,
  DateFact datetime  not null,
  MontantFact varchar(30) not null,
  NumCom varchar(20) foreign key references Commande(NumCom) not null, 
)



