

 CREATE TABLE Articulos(
    IdArticulo     INT primary key IDENTITY (1, 1),
    NombreArticulo VARCHAR (80),
    Existencia     INT ,
    PrecioVenta    decimal,
    PrecioCompra   decimal,
    Categoria      VARCHAR (80),
    CodigoArticulo VARCHAR (80),
    FechaIngreso   DATETIME,
	CategoriaId int ,
	ITBIS decimal
);

create table Clientes(ClienteId int identity(1,1) primary key, 
Nombres varchar(80), 
Direccion varchar(100),
Email varchar(50),
Telefono varchar(15),
);





create table Usuarios(Id int primary key identity(1,1), 
nombreUsuario varchar (50),
PassUsuario varchar(70) ,
Tipo varchar(70) 
);

create table Categorias( CategoriaId int primary key identity (1,1), 
NombreCategoria varchar(80)
);




create table  Facturas (
	IdFactura int identity(1,1)primary key,
 NombreUsuario varchar(80),
FechaVenta datetime,
Cliente  varchar(80),
TipoVenta varchar(80),
Total decimal
);



create table  ArticuloCategorias (
	ArticuloCategoriasid int identity(1,1)primary key,
    IdArticulo INT  ,
    CategoriaId   INT ,
   
);




create table FacturaDetalles(IdDetalle int identity(1,1) primary key, IdFactura int, 
IdArticulo int ,  Precio decimal,   Cantidad int);












CREATE TABLE [dbo].[Clientes] (
    [ClienteId]       INT           IDENTITY (1, 1) NOT NULL,
    [Nombres]         VARCHAR (80)  NULL,
    [Direccion]       VARCHAR (100) NULL,
    [Email]           VARCHAR (80)  NULL,
    [Telefono]        VARCHAR (80)  NULL,
    [Sexo]            VARCHAR (50)  NULL,
    [FechaNacimiento] DATETIME      NULL,
	[Cedula] VARCHAR (80)       NULL,
    PRIMARY KEY CLUSTERED ([ClienteId] ASC)
);


CREATE TABLE [dbo].[Categorias] (
    [CategoriaId]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreCategoria] VARCHAR (80) NULL,
    PRIMARY KEY CLUSTERED ([CategoriaId] ASC)
);


CREATE TABLE [dbo].[ArticuloCategorias] (
    [ArticuloCategoriasid] INT IDENTITY (1, 1) NOT NULL,
    [IdArticulo]           INT NULL,
    [CategoriaId]          INT NULL,
    PRIMARY KEY CLUSTERED ([ArticuloCategoriasid] ASC)
);


CREATE TABLE [dbo].[Articulos] (
    [IdArticulo]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreArticulo] VARCHAR (80) NULL,
    [Existencia]     INT          NULL,
    [PrecioVenta]    DECIMAL (18) NULL,
    [PrecioCompra]   DECIMAL (18) NULL,
    [Categoria]      VARCHAR (80) NULL,
    [CodigoArticulo] VARCHAR (80) NULL,
    [FechaIngreso]   DATETIME     NULL,
    [CategoriaId]    INT          NULL,
    [ITBIS]          DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([IdArticulo] ASC)
);

CREATE TABLE [dbo].[FacturaDetalles] (
    [IdDetalle]  INT          IDENTITY (1, 1) NOT NULL,
    [IdFactura]  INT          NULL,
    [IdArticulo] INT          NULL,
    [Precio]     DECIMAL (18) NULL,
    [Cantidad]   INT          NULL,
    PRIMARY KEY CLUSTERED ([IdDetalle] ASC),
    FOREIGN KEY ([IdArticulo]) REFERENCES [dbo].[Articulos] ([IdArticulo]),
	FOREIGN KEY ([IdFactura]) REFERENCES [dbo].[Facturas] ([IdFactura])

);

CREATE TABLE [dbo].[Facturas] (
    [IdFactura]     INT          IDENTITY (1, 1) NOT NULL,
    [NombreUsuario] VARCHAR (50) NULL,
    [FechaVenta]    DATETIME     NULL,
    [Cliente]       VARCHAR (80) NULL,
    [TipoVenta]     VARCHAR (80) NULL,
    [CantidadProd]  INT          NULL,
    [Total]         DECIMAL (18) NULL,
    PRIMARY KEY CLUSTERED ([IdFactura] ASC)
);

CREATE TABLE [dbo].[Usuarios] (
    [Id]            INT          IDENTITY (1, 1) NOT NULL,
    [nombreUsuario] VARCHAR (50) NULL,
    [PassUsuario]   VARCHAR (70) NULL,
    [Tipo]          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);