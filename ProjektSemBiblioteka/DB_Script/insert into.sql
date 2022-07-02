USE Projekt_wypo¿yczalnia
GO

INSERT INTO [Autor]([Imie], [Nazwisko])
VALUES 
	('Andrzej','Sapkowski'),
	('Donald','Karolak'),
	('Barbara','Pieni¹¿ek'),
	('Witold','Szymaniak'),
	('Agnieszka','Lesiasta'),
	('Albert','Mleczny'),
	('Amadeusz','Baranowski'),
	('Fabian','Wiœniewski'),
	('Jakub','Wróblewski'),
	('Lidia','Szulc'),
	('Tatiana','Siemaszko')
GO

INSERT INTO [Uzytkownicy]([Imie],[Nazwisko],[Adres],[Nr_Telefonu])
VALUES
	('Krzysztof','P³etwa','Kraków 32a','785423695'),
	('Bart³omiej','Zarêba','Warszawa 89/1/b','563256985'),
	('Monika','Szyd³owska','Niepo³omice 1423','789451254'),
	('Anna','Laskowska','Bierzanów 4b','852589653'),
	('Aleksandra','Bia³ecka','Wieliczka 234','456321569'),
	('Tadeusz','Jacaszek','Olkusz 778','412326725'),
	('Magda','Piêkna','Niepo³omice 69','694206586')
GO

INSERT INTO [Wydawnictwo]([Nazwa])
VALUES
	('Kurza Stupka'), 
	('Baranie Rogi'), 
	('Nowa Era#'), 
	('Sary Wiek'), 
	('Babcia_i_Wnuczka'), 
	('M¹dra-Sowa') 
GO

INSERT INTO [Literatura]([Kategoria],[Tytul],[Id_Autor],[Id_Wydawnictwo])
VALUES
	('Ksiazka','Œwinki Trzy i Wielki Wilk',1,3),
	('Album','Kwiaty USA',5,1),
	('Album','Ptaki Europy',10,6),
	('Czasopismo','PLAYBOY',6,5),
	('Ksiazka','Nad Morzem',8,2),
	('Ksiazka','Babciny Placek',1,5),
	('Czasopismo','Bravo Koks',11,1),
	('Ksiazka','Programowanie PHP',2,4),
	('Album','Polskie Góry',9,2),
	('Album','Nowe Oblicze Œwiata',7,3),
	('Ksiazka','Wielka Stopa',3,3),
	('Czasopismo','Wielcy Ludzie Wiêksze Ryby',2,2),
	('Album','Samochody Tego Wieku',4,3),
	('Ksiazka','Historia Kolei',11,6),
	('Ksiazka','Ma³y Zamek',4,1),
	('Czasopismo','Cz³owiek i Ma³pa',2,6)
GO

INSERT INTO [Wypozyczona_literatura]([Id_Uzytkownika],[Id_Literatury],[Data_Wydania],[Okres_Wypozyczenia])
VALUES
	(1,7,'2020-12-12',7),
	(3,16,'2021-01-01',13),
	(5,10,'2021-01-13',3),
	(7,4,'2021-01-23',7),
	(4,13,'2021-01-20',10),
	(6,3,'2020-11-18',10),
	(1,1,'2022-01-13',8),
	(2,11,'2021-12-24',12),
	(6,8,'2022-01-03',4),
	(4,9,'2022-01-24',6)
GO

INSERT INTO [Zwrot_literatury]([Id_Uzytkownika],[Id_Literatury],[Data_Zwrotu])
VALUES
	(1,7,'2020-12-19'),
	(3,16,'2021-01-11'),
	(5,10,'2021-01-15'),
	(7,4,'2021-01-30'),
	(6,3,'2020-11-27'),
	(1,1,'2022-01-19'),
	(2,11,'2022-01-04'),
	(4,13,'2021-01-30')
GO