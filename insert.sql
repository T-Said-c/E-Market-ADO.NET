insert into Client(CodeCl,Nom,Prenom,Adresse,Tel,Email,Ville)values('122','Tazi','Ali','rue 1 3700','0655970244','zimamdgbuf@gmail.com','Casablanca');
insert into Client(CodeCl,Nom,Prenom,Adresse,Tel,Email,Ville)values('1947','Wahid','Sarah','rue 4 43700','0610917435','opzfgebfiuz2@gmail.com','Rabat');
insert into Client(CodeCl,Nom,Prenom,Adresse,Tel,Email,Ville)values('284','Aboayoub','Iliass','rue 2 9400','0604819524','nqcoiqvh23@gmail.com','Tanja');
insert into Client(CodeCl,Nom,Prenom,Adresse,Tel,Email,Ville)values('95','Bousta','Mohammed','rue 8 64000','0601485302','uzeiuahfiuez@gmail.com','Fes');
insert into Client(CodeCl,Nom,Prenom,Adresse,Tel,Email,Ville)values('836','Lakhdar','Imane','rue 5 75300','0673904005','grrhrhd@gmail.com','Dakhla');

insert into Categorie(CodeCat,Libelle)values('1','TV');
insert into Categorie(CodeCat,Libelle)values('2','PC');
insert into Categorie(CodeCat,Libelle)values('3','Téléphone');
insert into Categorie(CodeCat,Libelle)values('4','Console');
insert into Categorie(CodeCat,Libelle)values('5','Autre');

insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie)values('20','SONY KD-75X81J','16999','5',(select BulkColumn from Openrowset(Bulk 'C:\Users\Nabstie\Desktop\Vente\Images\TV.jpg',Single_Blob) as image),'1');
insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie)values('9','APPLE MACBOOK PRO MYD92FN','21690','38',(select BulkColumn from Openrowset(Bulk 'C:\Users\Nabstie\Desktop\Vente\Images\PC.jpg',Single_Blob) as image),'2');
insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie)values('32','OPPO A54','2199','17',(select BulkColumn from Openrowset(Bulk 'C:\Users\Nabstie\Desktop\Vente\Images\telephone.jpg',Single_Blob) as image),'3');
insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie)values('74','SONY PS5 STANDARD','6799','23',(select BulkColumn from Openrowset(Bulk 'C:\Users\Nabstie\Desktop\Vente\Images\PS5.jpg',Single_Blob) as image),'4');
insert into Article(CodeArt,Designation,PU,QStock,Photo,CodeCategorie)values('49','Réfrigérateur WHIRLPOOL','8999','78',(select BulkColumn from Openrowset(Bulk 'C:\Users\Nabstie\Desktop\Vente\Images\Réfrigérateur.jpg',Single_Blob) as image),'1');

insert into Commande(NumCom,DateCom,CodeCl)values('21','12/05/2021','122');
insert into Commande(NumCom,DateCom,CodeCl)values('10','03/11/2021','1947');
insert into Commande(NumCom,DateCom,CodeCl)values('32','01/03/2021','284');
insert into Commande(NumCom,DateCom,CodeCl)values('40','10/09/2021','95');
insert into Commande(NumCom,DateCom,CodeCl)values('03','08/12/2021','836');

insert into Detail(NumCom,CodeArt,QteCommandee)values('21','20','1');
insert into Detail(NumCom,CodeArt,QteCommandee)values('10','9','2');
insert into Detail(NumCom,CodeArt,QteCommandee)values('32','32','10');
insert into Detail(NumCom,CodeArt,QteCommandee)values('40','74','5');
insert into Detail(NumCom,CodeArt,QteCommandee)values('03','49','1');

insert into Facture(NumeroFact,DateFact,MontantFact,NumCom)values('54','12/06/2021','356979','21');
insert into Facture(NumeroFact,DateFact,MontantFact,NumCom)values('31','03/12/2021','21690','10');
insert into Facture(NumeroFact,DateFact,MontantFact,NumCom)values('04','10/03/2021','70368','32');
insert into Facture(NumeroFact,DateFact,MontantFact,NumCom)values('19','10/12/2021','271960','40');
insert into Facture(NumeroFact,DateFact,MontantFact,NumCom)values('23','12/12/2021','26997','03');
