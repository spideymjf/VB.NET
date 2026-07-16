USE [Fmsoft]
GO

/****** Object:  View [dbo].[Factue_Client]    Script Date: 09/07/2026 12:11:33 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW FacturesClient AS
SELECT
    c.code_client,
    c.nom_client,
    f.NumFacture,
    tf.total_facture,
    f.date_facture,
    p.Code_Produit,
    p.designation_produit,
    df.Quantite,
    (p.Prix_unitaire_HTVA * (100 - df.Remise) / 100) * (1 + p.TVA / 100) * df.Quantite AS total_ttc
FROM client c
INNER JOIN Facture f 
    ON c.code_client = f.code_client
INNER JOIN detail_facture df 
    ON f.NumFacture = df.NumFacture
INNER JOIN Produit p 
    ON df.code_produit = p.Code_Produit
INNER JOIN (
    SELECT df2.NumFacture, 
           SUM((p2.Prix_unitaire_HTVA * (100 - df2.Remise) / 100) * (1 + p2.TVA / 100) * df2.Quantite) AS total_facture
    FROM detail_facture df2
    INNER JOIN Produit p2 
        ON df2.code_produit = p2.Code_Produit
    GROUP BY df2.NumFacture
) tf ON tf.NumFacture = f.NumFacture;
