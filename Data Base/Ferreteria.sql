CREATE DATABASE Ferreteria
GO
use Ferreteria
create table Categoria
(idCategoria int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Categoria_idCategoria PRIMARY KEY (idCategoria)
)


create table Marca
(idMarca int IDENTITY(1,1) NOT NULL,
descripcion varchar (50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Marca_idMarca PRIMARY KEY (idMarca)
)

 create table UnidadMedida
 (codUnidad int IDENTITY(1,1) NOT NULL,
 descripcion varchar (50) NOT NULL,
 borrado int DEFAULT 0
 Constraint PK_UnidadMedida_codUnidad PRIMARY KEY (codUnidad)
 )

create table Lote
(idLote int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Lote_idLote PRIMARY KEY (idLote)
)

create table Perfil
(idPerfil int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Perfil_idPerfil PRIMARY KEY (idPerfil)
)

create table Modulo
(idModulo int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Modulo_idModulo PRIMARY KEY (idModulo)
)

create table TipoFactura
(codTipoFactura int IDENTITY(1,1) NOT NULL,
descripcion varchar (50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_TipoFactura_codTipoFactura PRIMARY KEY (codTipoFactura)
)

create table TipoFormaPago
(idFormaPago int IDENTITY(1,1) NOT NULL,
descripcion varchar (50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_TipoFormaPago_idFormaPago PRIMARY KEY (idFormaPago)
)

create table Estado
(idEstado int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
ambito varchar(20),
borrado int DEFAULT 0
Constraint PK_Estado_idEstado PRIMARY KEY (idEstado)
)

create table Localidad
(codLocalidad int IDENTITY(1,1) NOT NULL,
nombre varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_Localidad_codLocalidad PRIMARY KEY (codLocalidad)
)

create table TipoDocumento
(idTipoDocumento int IDENTITY(1,1) NOT NULL,
descripcion varchar(50) NOT NULL,
borrado int DEFAULT 0
Constraint PK_TipoDocumento_idTipoDocumento PRIMARY KEY (idTipoDocumento)
)

create table Articulo
(codProducto int /*IDENTITY(1,1)'*/ NOT NULL,
descripcion varchar (50) NOT NULL,
codUnidad int,
precioUnitario float, 
idMarca int,
idCategoria int,
borrado int DEFAULT 0,
Constraint PK_Articulo_codProd PRIMARY KEY (codProducto),
Constraint FK_Articulo_Marca FOREIGN KEY (idMarca) REFERENCES Marca(idMarca),
Constraint FK_Articulo_Categoria FOREIGN KEY (idCategoria) REFERENCES Categoria (idCategoria)
)

create table Barrio
(codBarrio int IDENTITY(1,1) NOT NULL,
nombre varchar(50) NOT NULL,
localidad int,
borrado int DEFAULT 0,
Constraint PK_Barrio_codBarrio PRIMARY KEY (codBarrio),
Constraint FK_Barrio_localidad FOREIGN KEY (localidad) REFERENCES Localidad(codLocalidad)
)

create table Proveedor
(codProveedor int /*IDENTITY(1,1)*/ NOT NULL,
CUIT int,
razonSocial varchar(50) NOT NULL,
nombre varchar(50),
apellido varchar(50),
telefono varchar(50),
calle varchar(50),
numero int,
codBarrio int,
borrado int DEFAULT 0,
Constraint PK_Proveedor PRIMARY KEY (codProveedor),
Constraint FK_Proveedor_barrio FOREIGN KEY (codBarrio) REFERENCES Barrio(codBarrio)
)

create table ArticuloXLote
(idLote int NOT NULL,
codArticulo int NOT NULL,
fechaIngreso datetime,
stockInicial int,
codProveedor int,
borrado int DEFAULT 0,
Constraint PK_ArticuloXLote PRIMARY KEY (idLote,codArticulo),
Constraint FK_ArticuloXLote_codProveedor FOREIGN KEY (codProveedor) REFERENCES Proveedor(codProveedor),
Constraint FK_ArticuloXLote_idLote FOREIGN KEY (idLote) REFERENCES Lote(idLote),
Constraint FK_ArticuloXLote_codArticulo FOREIGN KEY (codArticulo) REFERENCES Articulo(codProducto)
)

create table Empleado
(tipoDocEmpleado int NOT NULL, 
nroDocEmpleado int NOT NULL,
apellido varchar(50),
nombre varchar(50),
fechaNac datetime,
telefono varchar(50),
fechaIngreso datetime,
borrado int DEFAULT 0,
Constraint PK_Empleado PRIMARY KEY (tipoDocEmpleado,nroDocEmpleado),
Constraint FK_Empleado_tipoDoc FOREIGN KEY (tipoDocEmpleado) REFERENCES TipoDocumento(idTipoDocumento)
)

create table Cliente
(tipoDocCliente int NOT NULL, 
nroDocCliente int NOT NULL, 
apellido varchar(50),
nombre varchar(50),
telefono varchar(50),
cuit int,
mail varchar(50),
calle varchar(50),
nroCalle int,
codBarrio int,
borrado int DEFAULT 0,
Constraint PK_Cliente PRIMARY KEY (tipoDocCliente,nroDocCliente),
Constraint FK_Cliente_tipoDoc FOREIGN KEY (tipoDocCliente) REFERENCES TipoDocumento(idTipoDocumento),
Constraint FK_Cliente_barrio FOREIGN KEY (codBarrio) REFERENCES Barrio(codBarrio)
)

create table Usuario
(codUsuario int NOT NULL, 
nombreUsuario varchar(50),
Upassword varchar(50), 
perfil int,
dniEmpleado int,
tipoDocCliente int,
borrado int DEFAULT 0,
Constraint PK_Usuario PRIMARY KEY (codUsuario),
Constraint FK_Usuario_perfil FOREIGN KEY (tipoDocCliente) REFERENCES TipoDocumento(idTipoDocumento),
Constraint FK_Usuario_Empleado FOREIGN KEY (dniEmpleado,tipoDocCliente) REFERENCES Empleado(tipoDocEmpleado,nroDocEmpleado)
)

create table ModuloXPerfil
(idModulo int NOT NULL, 
idPerfil int NOT NULL, 
Constraint PK_ModuloXPerfil PRIMARY KEY (idModulo,idPerfil),
Constraint FK_ModuloXPerfil_Modulo FOREIGN KEY (idModulo) REFERENCES Modulo(idModulo),
Constraint FK_ModuloXPerfil_idPerfil FOREIGN KEY (idPerfil) REFERENCES Perfil(idPerfil)
)

create table OrdenDeCompra
(codCompra int NOT NULL, 
idProveedor int NOT NULL, 
fecha datetime,
Constraint PK_OrdenDeCompra PRIMARY KEY (codCompra,idProveedor),
Constraint FK_OrdenDeCompra_idProveedor FOREIGN KEY (idProveedor ) REFERENCES Proveedor(codProveedor)
)

create table DetOrdenCompra
(codCompra int NOT NULL, 
idProveedor int NOT NULL, 
codProd int NOT NULL, 
precioUnitario float,
cantidad int,
Constraint PK_DetOrdenCompra PRIMARY KEY (codCompra,idProveedor,codProd),
Constraint FK_DetOrdenCompra_Compra FOREIGN KEY (codCompra,idProveedor) REFERENCES OrdenDeCompra(codCompra,idProveedor),
Constraint FK_DetOrdenCompra_codProd  FOREIGN KEY (codProd ) REFERENCES Articulo(codProducto)

)

create table ArticuloXProveedor
(codProveedor int NOT NULL,
codProducto int NOT NULL,
Constraint PK_ArticuloXProveedor PRIMARY KEY(codProveedor,codProducto),
Constraint FK_ArticuloXProveedor_codProveedor FOREIGN KEY(codProveedor) REFERENCES Proveedor(codProveedor),
Constraint FK_ArticuloXProveedor_codProducto FOREIGN KEY(codProducto) REFERENCES Articulo(codProducto),

)

create table Venta
(nroFactura int NOT NULL IDENTITY(1,1),
tipoFactura int NOT NULL,
tipoDocCliente int,
nroDocCliente int,
tipoDocEmpleado int,
nroDocEmpleado int,
fecha datetime,
idEstado int,
borrado int DEFAULT 0,
Constraint PK_Venta PRIMARY KEY (nroFactura,tipoFactura),
Constraint FK_Venta_TipoFactura FOREIGN KEY(tipoFactura) REFERENCES TipoFactura(codTipoFactura),
Constraint FK_Venta_Cliente FOREIGN KEY(tipoDocCliente,nroDocCliente) REFERENCES Cliente(tipoDocCliente,nroDocCliente),
Constraint FK_Venta_Empleado FOREIGN KEY(tipoDocEmpleado,nroDocEmpleado) REFERENCES Empleado(tipoDocEmpleado,nroDocEmpleado),
Constraint FK_Venta_Estado FOREIGN KEY(idEstado) REFERENCES Estado(idEstado),

)

create table DetFacturaVenta
(nroFactura int NOT NULL,
tipoFactura int NOT NULL,
codProd int NOT NULL,
idLote int,
precioUnitario int,
cantidad int,
Constraint PK_DetFacturaVenta PRIMARY KEY(nroFactura,tipoFactura,codProd,idLote),
Constraint FK_Venta_Factura FOREIGN KEY(nroFactura,tipoFactura) REFERENCES Venta(nroFactura,tipoFactura),
Constraint FK_Venta_Lote FOREIGN KEY(idLote) REFERENCES Lote(idLote),

)

create table FormasPagoVenta
(nroFactura int NOT NULL,
tipofactura int NOT NULL,
idFormaPago int NOT NULL IDENTITY(1,1),
montoPago int,
fechaPago datetime,
Constraint PK_FormasPagoVenta PRIMARY KEY (nroFactura,tipoFactura,IdformaPago),
Constraint FK_FormasPagoVenta_Venta FOREIGN KEY (nroFactura,tipoFactura) REFERENCES Venta(nroFactura,tipoFactura),
Constraint FK_FormasPagoVenta_TiposFormasPago FOREIGN KEY (idFormaPago) REFERENCES TipoFormaPago(idFormaPago),

)


create table Entrega
(codEntrega int NOT NULL IDENTITY(1,1),
fechaEntrega datetime,
fechaRealEntrega datetime,
idEstado int,
nroFactura int,
tipoFactura int,
tipoDocEmpleado int,
nroDocEmpleado int,
Constraint PK_Entrega PRIMARY KEY (codEntrega),
Constraint FK_Entrega_Estado FOREIGN KEY (idEstado) REFERENCES Estado(idEstado),
Constraint FK_Entregas_Venta FOREIGN KEY (nroFactura,tipoFactura) REFERENCES Venta(nroFactura,tipoFactura),
Constraint FK_Entrega_Empleado FOREIGN KEY(tipoDocEmpleado,nroDocEmpleado) REFERENCES Empleado(tipoDocEmpleado,nroDocEmpleado),

)
