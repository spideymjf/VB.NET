USE [Fmsoft]
GO

/****** Object:  View [dbo].[DetailFactureRequest]    Script Date: 09/07/2026 09:02:25 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW dbo.DetailFactureRequest
AS
SELECT
    p.Code_Produit,
    p.Designation_Produit,
    df.Remise,
    p.TVA,
    df.Quantite,
    p.Quantite_Stock,
    p.Prix_unitaire_HTVA,
    ((p.Prix_unitaire_HTVA * (100-df.Remise))/100)  AS Prix_Unitaire_Apres_Remise_HTVA ,
    p.Prix_unitaire_HTVA * df.Quantite AS Prix_Total_HTVA,
    ((p.Prix_unitaire_HTVA * (100-df.Remise))/100) * (1 + p.TVA/100) AS Prix_unitaire_TTC ,
    ((p.Prix_unitaire_HTVA * (100-df.Remise))/100) * df.Quantite AS Prix_Total_Apres_Remise_HTVA,
    (((p.Prix_unitaire_HTVA * (100-df.Remise))/100)* (1 + p.TVA/100)) * df.Quantite  AS Prix_Total_TTC,
    df.NumFacture
FROM dbo.Detail_Facture df
INNER JOIN dbo.Produit p
    ON df.Code_Produit = p.Code_Produit;
GO


