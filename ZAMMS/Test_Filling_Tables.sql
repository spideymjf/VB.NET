insert into dbo.Client (Code_client,Nom_Client,Tel,Email) values ('C01','Ahmed','98500872','ahmed@yahoo.fr')



INSERT INTO [dbo].[Facture]
           ([NumFacture]
           ,[Date_Facture]
           ,[Montant_TVA]
           ,[Montant_TTC]
           ,[Validee]
           ,[Code_client])
     VALUES
           ('12'
           ,'2026-07-08'
           ,550.23
           ,612.369
           ,1
           ,'C01'
);

INSERT INTO [dbo].[Facture]
           ([NumFacture]
           ,[Date_Facture]
           ,[Montant_TVA]
           ,[Montant_TTC]
           ,[Validee]
           ,[Code_client])
     VALUES
           ('15'
           ,'2026-07-11'
           ,550.23
           ,612.3694
           ,0
           ,'C01'
);

INSERT INTO [dbo].[Facture]
           ([NumFacture]
           ,[Date_Facture]
           ,[Montant_TVA]
           ,[Montant_TTC]
           ,[Validee]
           ,[Code_client])
     VALUES
           ('1'
           ,'2026-07-21'
           ,550.23
           ,612.369
           ,1
           ,'C01'
);

INSERT INTO [dbo].[Facture]
           ([NumFacture]
           ,[Date_Facture]
           ,[Montant_TVA]
           ,[Montant_TTC]
           ,[Validee]
           ,[Code_client])
     VALUES
           ('0'
           ,'2026-08-01'
           ,12.65
           ,45
           ,0
           ,'C01'
);

DELETE FROM [dbo].[Facture]
      WHERE NumFacture='12'

INSERT INTO [dbo].[Facture]
           ([NumFacture]
           ,[Date_Facture]
           ,[Montant_TVA]
           ,[Montant_TTC]
           ,[Validee]
           ,[Code_client])
     VALUES
           ('12'
           ,'2026-07-08'
           ,550.23
           ,612.369
           ,1
           ,'C01'
);

INSERT INTO [dbo].[Detail_Facture]
           ([Code_produit]
           ,[Quantite]
           ,[Prix_unitaire]
           ,[Prix_TTC]
           ,[NumFacture])
     VALUES
     (
           '12'
           ,10
           ,5.5
           ,6.8
           ,'0')
;
