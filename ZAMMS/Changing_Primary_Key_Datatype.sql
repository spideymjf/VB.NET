ALTER TABLE dbo.Detail_Facture
DROP CONSTRAINT PK__Detail_F__F0C4D7D98B663907;

ALTER TABLE dbo.Detail_Facture DROP COLUMN Code_detail;

ALTER TABLE dbo.Detail_Facture
ADD Code_detail INT IDENTITY(1,1) NOT NULL;

ALTER TABLE dbo.Detail_Facture
ADD CONSTRAINT PK__Detail_Facture PRIMARY KEY (Code_detail);