Use Wypozycalnia
go
Create table Literatura(
	[Id] int identity(1,1) UNIQUE NOT NULL,
	[Kategoria] varchar(11) NOT NULL,
	[Tytul] varchar(50) NOT NULL,
	[Id_Autor] int NOT NULL,
	[Id_Wydawnictwo] int NOT NULL,
		CONSTRAINT [CHK_kategoria] CHECK ([Kategoria] IN( 'Ksiazka', 'Czasopismo','Album'))
)
GO
ALTER TABLE [dbo].[Literatura] ADD CONSTRAINT
[PK_autor_wyda] PRIMARY KEY ([Id],[Id_Autor],[Id_Wydawnictwo])
GO


Create table Autor(
	[Id] int identity(1,1) NOT NULL,
	[Imie] varchar(30) NOT NULL,
	[Nazwisko] varchar(50) NOT NULL
)
GO
ALTER TABLE [dbo].[Autor] ADD CONSTRAINT
[PK_TAutor] PRIMARY KEY ([Id])
GO


Create table Wydawnictwo(
	[Id] INT IDENTITY(1,1) not null,
	[Nazwa] varchar(50) UNIQUE NOT NULL
)
GO
ALTER TABLE [dbo].[Wydawnictwo] ADD CONSTRAINT
[PK_wydawnictwo] PRIMARY KEY ([Id])
GO


Create table Uzytkownicy(
	[Id] INT IDENTITY(1,1) NOT NULL,
	[Imie] varchar(30) NOT NULL,
	[Nazwisko] varchar(50) NOT NULL,
	[Adres] varchar(50) NOT NULL,
	[Nr_Telefonu] varchar(9) NOT NULL UNIQUE,
		CONSTRAINT [CHK_uzytkownicy] CHECK ([Nr_Telefonu] LIKE '[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'),

)
GO
ALTER TABLE [dbo].[Uzytkownicy] ADD CONSTRAINT
[PK_uzytkownicy] PRIMARY KEY ([Id])
GO


Create table Wypozyczona_literatura(
	[Id_Uzytkownika] int NOT NULL,
	[Id_Literatury] int NOT NULL,
	[Data_Wydania] date DEFAULT GETDATE(),
	[Okres_Wypozyczenia] int NOT NULL DEFAULT 7,
		CONSTRAINT [CHK_okres_wypozyczenia] CHECK ([Okres_Wypozyczenia] > 0 AND [Okres_Wypozyczenia] <=14),
)
GO
ALTER TABLE [dbo].[Wypozyczona_literatura] ADD CONSTRAINT
[PK_wypozyczone] PRIMARY KEY ([Id_Uzytkownika],[Id_Literatury])
GO


Create table Zwrot_literatury(
	[Id_Uzytkownika] int NOT NULL,
	[Id_Literatury] int NOT NULL,
	[Data_Zwrotu] date  DEFAULT GETDATE(),
	
)
GO

ALTER TABLE [dbo].[Zwrot_literatury] ADD CONSTRAINT
[PK_zwroty] PRIMARY KEY ([Id_Uzytkownika],[Id_Literatury])
GO

ALTER TABLE [dbo].[Literatura] ADD CONSTRAINT [Pisze] FOREIGN KEY ([Id_Autor]) REFERENCES
[dbo].[Autor]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION
GO

ALTER TABLE [dbo].[Literatura] ADD CONSTRAINT [Wydaje] FOREIGN KEY ([Id_Wydawnictwo]) REFERENCES
[dbo].[Wydawnictwo]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION
GO

ALTER TABLE [dbo].[Wypozyczona_literatura] ADD CONSTRAINT [Odpowiada] FOREIGN KEY ([Id_Literatury]) REFERENCES 
[dbo].[Literatura]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION 
GO

ALTER TABLE [dbo].[Wypozyczona_literatura] ADD CONSTRAINT [Wypozycza] FOREIGN KEY ([Id_Uzytkownika]) REFERENCES 
[dbo].[Uzytkownicy]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION 
GO

ALTER TABLE [dbo].[Zwrot_literatury] ADD CONSTRAINT [Zwraca] FOREIGN KEY ([Id_Uzytkownika]) REFERENCES 
[dbo].[Uzytkownicy]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION 
GO

ALTER TABLE [dbo].[Zwrot_literatury] ADD CONSTRAINT [Odpowiada1] FOREIGN KEY ([Id_Literatury]) REFERENCES 
[dbo].[Literatura]([Id]) ON UPDATE NO ACTION ON DELETE NO ACTION 
GO