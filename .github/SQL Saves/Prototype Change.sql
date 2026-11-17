CREATE TABLE [dbo].[Contacts] (
    [ContactID] INT           IDENTITY (1, 1) NOT NULL,
    [FirstName] VARCHAR (30)  NOT NULL,
    [LastName]  NCHAR (10)    NOT NULL,
    [PhoneNum]  CHAR (10)     NOT NULL,
    [EMail]     VARCHAR (256) NOT NULL,
    [Type]      BIT           NOT NULL,
    [Notes]     TEXT          NULL,
    [storageID] INT NOT NULL, 
    PRIMARY KEY CLUSTERED ([ContactID] ASC)
);

