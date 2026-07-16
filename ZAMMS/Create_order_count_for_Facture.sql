ALTER TABLE dbo.Facture
ADD norder INT IDENTITY(1,1) NOT NULL;

CREATE INDEX Facture_Order ON Facture(norder);