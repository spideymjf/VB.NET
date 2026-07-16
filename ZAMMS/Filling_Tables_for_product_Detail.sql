USE [Fmsoft]
GO

INSERT INTO [dbo].[Produit]
           ([Designation_Produit]
           ,[Prix_unitaire_HTVA]
           ,[TVA]
           ,[Quantite_Stock]
           ,[Code_Produit])
     VALUES
           ('Support de fixation de LAMPE'
           ,130
           ,19
           ,100
           ,'SUPP')
GO


INSERT INTO [dbo].[Produit]
           ([Designation_Produit]
           ,[Prix_unitaire_HTVA]
           ,[TVA]
           ,[Quantite_Stock]
           ,[Code_Produit])
     VALUES
           ('LAMPE electrique'
           ,56
           ,13
           ,100
           ,'PP1441')
GO


INSERT INTO [dbo].[Produit]
           ([Designation_Produit]
           ,[Prix_unitaire_HTVA]
           ,[TVA]
           ,[Quantite_Stock]
           ,[Code_Produit])
     VALUES
           ('tablette android'
           ,12
           ,13
           ,100
           ,'666666666')
GO


INSERT INTO [dbo].[Produit]
           ([Designation_Produit]
           ,[Prix_unitaire_HTVA]
           ,[TVA]
           ,[Quantite_Stock]
           ,[Code_Produit])
     VALUES
           ('lunette class'
           ,30
           ,19
           ,50
           ,'456456456')
GO

USE [Fmsoft]
GO

INSERT INTO [dbo].[Detail_Facture]
           ([Code_detail]
           ,[Quantite]
           ,[NumFacture]
           ,[code_produit]
           ,[Remise])
     VALUES
           ('1'
           ,9
           ,0
           ,'SUPP'
           ,10.50)
GO

INSERT INTO [dbo].[Detail_Facture]
           ([Code_detail]
           ,[Quantite]
           ,[NumFacture]
           ,[code_produit]
           ,[Remise])
     VALUES
           ('2'
           ,1
           ,0
           ,'PP1441'
           ,0)
GO

INSERT INTO [dbo].[Detail_Facture]
           ([Code_detail]
           ,[Quantite]
           ,[NumFacture]
           ,[code_produit]
           ,[Remise])
     VALUES
           ('3'
           ,1
           ,0
           ,'666666666'
           ,0)
GO

INSERT INTO [dbo].[Detail_Facture]
           ([Code_detail]
           ,[Quantite]
           ,[NumFacture]
           ,[code_produit]
           ,[Remise])
     VALUES
           ('4'
           ,1
           ,0
           ,'456456456'
           ,0)
GO

