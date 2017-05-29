
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 05/29/2017 19:47:23
-- Generated from EDMX file: C:\Faculdade\C#LP1\ProjetoMVC\ProjetoMVC_Livraria\Livraria\Model\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [livraria];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Autor'
CREATE TABLE [dbo].[Autor] (
    [IdAutor] int IDENTITY(1,1) NOT NULL,
    [NomeAutor] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Livro'
CREATE TABLE [dbo].[Livro] (
    [IdLivro] int IDENTITY(1,1) NOT NULL,
    [IdGenero] int  NOT NULL,
    [IdAutor] int  NOT NULL,
    [NomeLivro] nvarchar(max)  NOT NULL,
    [Ano] int  NOT NULL,
    [Descricao] nvarchar(max)  NOT NULL,
    [Paginas] int  NOT NULL,
    [IdEditora] int  NOT NULL,
    [Isbn] nvarchar(max)  NOT NULL,
    [Preco] decimal(18,0)  NOT NULL
);
GO

-- Creating table 'Genero'
CREATE TABLE [dbo].[Genero] (
    [IdGenero] int IDENTITY(1,1) NOT NULL,
    [NomeGenero] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Editora'
CREATE TABLE [dbo].[Editora] (
    [IdEditora] int IDENTITY(1,1) NOT NULL,
    [NomeEditora] nvarchar(max)  NOT NULL,
    [RazaoSocial] nvarchar(max)  NOT NULL,
    [CNPJ] nvarchar(max)  NOT NULL,
    [Email] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Funcionario'
CREATE TABLE [dbo].[Funcionario] (
    [IdFuncionario] int IDENTITY(1,1) NOT NULL,
    [NomeFuncionario] nvarchar(max)  NOT NULL,
    [Login] nvarchar(max)  NOT NULL,
    [Senha] nvarchar(max)  NOT NULL,
    [Administrador] bit  NOT NULL
);
GO

-- Creating table 'Venda'
CREATE TABLE [dbo].[Venda] (
    [IdVenda] int IDENTITY(1,1) NOT NULL,
    [DataVenda] datetime  NOT NULL,
    [PrecoTotal] decimal(18,0)  NOT NULL,
    [TotalLivros] int  NOT NULL,
    [IdFuncionario] int  NOT NULL
);
GO

-- Creating table 'Item_VendaSet'
CREATE TABLE [dbo].[Item_VendaSet] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [IdVenda] int  NOT NULL,
    [LivroIdLivro] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [IdAutor] in table 'Autor'
ALTER TABLE [dbo].[Autor]
ADD CONSTRAINT [PK_Autor]
    PRIMARY KEY CLUSTERED ([IdAutor] ASC);
GO

-- Creating primary key on [IdLivro] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [PK_Livro]
    PRIMARY KEY CLUSTERED ([IdLivro] ASC);
GO

-- Creating primary key on [IdGenero] in table 'Genero'
ALTER TABLE [dbo].[Genero]
ADD CONSTRAINT [PK_Genero]
    PRIMARY KEY CLUSTERED ([IdGenero] ASC);
GO

-- Creating primary key on [IdEditora] in table 'Editora'
ALTER TABLE [dbo].[Editora]
ADD CONSTRAINT [PK_Editora]
    PRIMARY KEY CLUSTERED ([IdEditora] ASC);
GO

-- Creating primary key on [IdFuncionario] in table 'Funcionario'
ALTER TABLE [dbo].[Funcionario]
ADD CONSTRAINT [PK_Funcionario]
    PRIMARY KEY CLUSTERED ([IdFuncionario] ASC);
GO

-- Creating primary key on [IdVenda] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [PK_Venda]
    PRIMARY KEY CLUSTERED ([IdVenda] ASC);
GO

-- Creating primary key on [Id] in table 'Item_VendaSet'
ALTER TABLE [dbo].[Item_VendaSet]
ADD CONSTRAINT [PK_Item_VendaSet]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [IdGenero] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [FK_LivroGenero]
    FOREIGN KEY ([IdGenero])
    REFERENCES [dbo].[Genero]
        ([IdGenero])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LivroGenero'
CREATE INDEX [IX_FK_LivroGenero]
ON [dbo].[Livro]
    ([IdGenero]);
GO

-- Creating foreign key on [IdAutor] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [FK_LivroAutor]
    FOREIGN KEY ([IdAutor])
    REFERENCES [dbo].[Autor]
        ([IdAutor])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_LivroAutor'
CREATE INDEX [IX_FK_LivroAutor]
ON [dbo].[Livro]
    ([IdAutor]);
GO

-- Creating foreign key on [IdEditora] in table 'Livro'
ALTER TABLE [dbo].[Livro]
ADD CONSTRAINT [FK_EditoraLivro]
    FOREIGN KEY ([IdEditora])
    REFERENCES [dbo].[Editora]
        ([IdEditora])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_EditoraLivro'
CREATE INDEX [IX_FK_EditoraLivro]
ON [dbo].[Livro]
    ([IdEditora]);
GO

-- Creating foreign key on [IdFuncionario] in table 'Venda'
ALTER TABLE [dbo].[Venda]
ADD CONSTRAINT [FK_VendaFuncionario]
    FOREIGN KEY ([IdFuncionario])
    REFERENCES [dbo].[Funcionario]
        ([IdFuncionario])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_VendaFuncionario'
CREATE INDEX [IX_FK_VendaFuncionario]
ON [dbo].[Venda]
    ([IdFuncionario]);
GO

-- Creating foreign key on [IdVenda] in table 'Item_VendaSet'
ALTER TABLE [dbo].[Item_VendaSet]
ADD CONSTRAINT [FK_Item_VendaVenda]
    FOREIGN KEY ([IdVenda])
    REFERENCES [dbo].[Venda]
        ([IdVenda])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_VendaVenda'
CREATE INDEX [IX_FK_Item_VendaVenda]
ON [dbo].[Item_VendaSet]
    ([IdVenda]);
GO

-- Creating foreign key on [LivroIdLivro] in table 'Item_VendaSet'
ALTER TABLE [dbo].[Item_VendaSet]
ADD CONSTRAINT [FK_Item_VendaLivro]
    FOREIGN KEY ([LivroIdLivro])
    REFERENCES [dbo].[Livro]
        ([IdLivro])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_Item_VendaLivro'
CREATE INDEX [IX_FK_Item_VendaLivro]
ON [dbo].[Item_VendaSet]
    ([LivroIdLivro]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------