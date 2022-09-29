

CREATE TABLE [dbo].[user] (
    [id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [name]       VARCHAR (255) NOT NULL,
    [surname]    VARCHAR (255) NOT NULL,
    [email]      VARCHAR (255) NOT NULL,
    [password]   VARCHAR (20)  NOT NULL,
    [phone]      VARCHAR (20)  NOT NULL,
    [created_at] DATETIME      DEFAULT (NULL) NULL,
    [updated_at] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[document] (
    [id]         BIGINT        IDENTITY (1, 1) NOT NULL,
    [code]       VARCHAR (255) NOT NULL,
    [title]      VARCHAR (255) NOT NULL,
    [year]       INT           NOT NULL,
    [sector]     VARCHAR (100) NOT NULL,
    [available]  TINYINT       NOT NULL,
    [position]   VARCHAR (3)   NOT NULL,
    [author]     VARCHAR (50)  NOT NULL,
    [type]       VARCHAR (50)  NOT NULL,
    [time]       INT           NULL,
    [total_page] INT           NULL,
    [created_at] DATETIME      DEFAULT (NULL) NULL,
    [updated_at] DATETIME      DEFAULT (NULL) NULL,
    PRIMARY KEY CLUSTERED ([id] ASC)
);

CREATE TABLE [dbo].[rents] (
    [id]           BIGINT   IDENTITY NOT NULL,
    [created_at]   DATETIME DEFAULT (NULL) NULL,
    [updated_at]   DATETIME DEFAULT (NULL) NULL,
    [document_id]  BIGINT   NOT NULL,
    [user_id]      BIGINT   NOT NULL,
    [start_period] DATETIME,
    [end_period] DATETIME,
    CONSTRAINT [PK_rents_id] PRIMARY KEY CLUSTERED ([id] ASC),
    CONSTRAINT [rents$rents_user_id_foreign] FOREIGN KEY ([user_id]) REFERENCES [dbo].[user] ([id]),
    CONSTRAINT [rents$rent_document_id_foreign] FOREIGN KEY ([document_id]) REFERENCES [dbo].[document] ([id])
);