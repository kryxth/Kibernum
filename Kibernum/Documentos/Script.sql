/* To prevent any potential data loss issues, you should review this script in detail before running it outside the context of the database designer.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Persona
	(
	IdPersona int NOT NULL IDENTITY (1, 1),
	Documento varchar(20) NOT NULL UNIQUE,
	Nombres varchar(100) NOT NULL UNIQUE,
	Apellidos varchar(100) NOT NULL UNIQUE,
	FechaNacimiento datetime NULL,
	NumerosTelefonicos varchar(100) NULL,
	CorreosElectronicos varchar(100) NULL,
	DirecionesFisicas varchar(100) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Persona ADD CONSTRAINT
	PK_Persona PRIMARY KEY CLUSTERED 
	(
	IdPersona
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Persona SET (LOCK_ESCALATION = TABLE)
GO
COMMIT