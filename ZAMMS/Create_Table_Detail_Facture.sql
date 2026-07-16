CREATE TABLE Detail_Facture (
    Code_detail     VARCHAR(10)   PRIMARY KEY,
    Code_produit    VARCHAR(10)   NOT NULL,
    Qte             INT           NOT NULL,
    Prix_unitaire   DECIMAL(10,2) NOT NULL,
    Prix_TTC        DECIMAL(10,2) NOT NULL,
    NumFact         VARCHAR(10)   NOT NULL,
    CONSTRAINT FK_Detail_Facture FOREIGN KEY (NumFact)
        REFERENCES Facture(NumFact)
);