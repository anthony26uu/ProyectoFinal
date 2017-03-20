

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


create table Facturas (IdFactura int primary key identity (1,1),
IdEmpleado int,
IdArticulo int,
FechaVenta DateTime,
Descuento decimal,
Cliente varchar(80),
TipoVenta varchar(80), 
CantidadProd int ,
ITBS decimal
);

create table  ArticuloCategorias (
	ArticuloCategoriasid int identity(1,1)primary key,
    IdArticulo INT  ,
    CategoriaId   INT ,
   
);




create table FacturaDetalles(IdDetalle int identity(1,1) primary key, IdFactura int, 
IdArticulo int ,  Precio decimal,   Cantidad decimal);