CREATE TABLE [dbo].[Vendedores] (
    [VendedorId]    INT          IDENTITY (1, 1) NOT NULL,
    [Nombre]        VARCHAR (30) NULL,
    [Apellido]      VARCHAR (30) NULL,
    [Sexo]          VARCHAR (10) NULL,
    [Cedula]        VARCHAR (15) NULL,
    [TelefonoFijo]  VARCHAR (15) NULL,
    [TelefonoMovil] VARCHAR (15) NULL,
    [Direccion]     VARCHAR (40) NULL,
    [TipoVehiculo]  VARCHAR (20) NULL
);

