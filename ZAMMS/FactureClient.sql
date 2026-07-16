USE [Fmsoft]
GO

/****** Object:  View [dbo].[FacturesClient]    Script Date: 10/07/2026 11:37:04 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[FacturesClient]
AS
SELECT        c.Code_client, c.Nom_client, f.NumFacture, tf.total_facture, f.Date_Facture,  
              (p.Prix_unitaire_HTVA * (100 - df.Remise) / 100) * (1 + p.TVA / 100) 
                         * df.Quantite AS total_ttc
FROM            dbo.Client AS c INNER JOIN
                         dbo.Facture AS f ON c.Code_client = f.Code_client INNER JOIN
                         dbo.Detail_Facture AS df ON f.NumFacture = df.NumFacture INNER JOIN
                         dbo.Produit AS p ON df.code_produit = p.Code_Produit INNER JOIN
                             (SELECT        df2.NumFacture, SUM((p2.Prix_unitaire_HTVA * (100 - df2.Remise) / 100) * (1 + p2.TVA / 100) * df2.Quantite) AS total_facture
                               FROM            dbo.Detail_Facture AS df2 INNER JOIN
                                                         dbo.Produit AS p2 ON df2.code_produit = p2.Code_Produit
                               GROUP BY df2.NumFacture) AS tf ON tf.NumFacture = f.NumFacture 
ORDER BY c.Code_client, f.NumFacture, p.Code_Produit
OFFSET 0 ROWS
GO


