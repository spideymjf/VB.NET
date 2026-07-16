CREATE INDEX Facture_Code_Client ON Facture(Code_Client);
CREATE INDEX DetailFacture_NumFact ON Detail_Facture(NumFacture);

CREATE INDEX Facture_DateFact ON Facture(Date_Facture);
CREATE INDEX Client_Email ON Client(Email);