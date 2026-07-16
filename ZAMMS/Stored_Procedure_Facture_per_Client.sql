CREATE PROCEDURE dbo.GetClientDetailFacture
    @Code_client VARCHAR(10)
AS
BEGIN
    SET NOCOUNT ON;
    SELECT 
        c.Code_client,
        c.Nom_client,
        f.NumFacture,
        f.Date_Facture,
        SUM(df.Quantite * p.Prix_Unitaire_HTVA) AS Total_Facture
    FROM dbo.Client AS c
    INNER JOIN dbo.Facture AS f 
        ON c.Code_client = f.Code_client
    INNER JOIN dbo.Detail_Facture AS df 
        ON f.NumFacture = df.NumFacture
    INNER JOIN dbo.Produit AS p 
        ON df.Code_Produit = p.Code_Produit
    WHERE c.Code_client = @Code_client
    GROUP BY 
        c.Code_client, 
        c.Nom_client, 
        f.NumFacture, 
        f.Date_Facture;
END

EXEC dbo.GetClientDetailFacture @Code_client = 'a00';

DROP PROCEDURE dbo.GetClientDetailFacture