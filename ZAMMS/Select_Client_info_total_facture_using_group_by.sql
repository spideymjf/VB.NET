SELECT 
    c.Code_client, 
    c.Nom_client, 
    f.NumFacture, 
    f.Date_Facture,
    tf.total_facture AS total_ttc
FROM dbo.Client AS c
INNER JOIN dbo.Facture AS f 
    ON c.Code_client = f.Code_client
INNER JOIN (
    SELECT 
        df2.NumFacture, 
        SUM((p2.Prix_unitaire_HTVA * (100 - df2.Remise) / 100) * (1 + p2.TVA / 100) * df2.Quantite) AS total_facture
    FROM dbo.Detail_Facture AS df2
    INNER JOIN dbo.Produit AS p2 
        ON df2.code_produit = p2.Code_Produit
    GROUP BY df2.NumFacture
) AS tf 
    ON tf.NumFacture = f.NumFacture;