CREATE VIEW DetailFactureTest AS
SELECT 
    Code_produit
   ,Quantite
   ,Prix_unitaire_HTVA
   ,NumFacture
   ,[TVA] as TVA_Percentage
   ,TVA * 100 as TVA
   ,(Prix_unitaire_HTVA * (1 + TVA))  AS Prix_unitaire_TTC
   ,Prix_unitaire_HTVA * Quantite AS Prix_Total_HTVA
   ,(Prix_unitaire_HTVA * (1+ TVA))* Quantite AS Prix_Total_TTC
FROM dbo.Detail_Facture;
