CREATE TABLE Facture (
    NumFact         VARCHAR(10)   PRIMARY KEY,
    Date_Fact       DATE          NOT NULL,
    Mont_HTVA       DECIMAL(10,2) NOT NULL,
    Mont_TTC        DECIMAL(10,2) NOT NULL,
    Valide          BIT           NOT NULL DEFAULT 0,
    Code_Client     VARCHAR(10)   NOT NULL,
    CONSTRAINT FK_Facture_Client FOREIGN KEY (Code_Client)
        REFERENCES Client(Code_Client)
);