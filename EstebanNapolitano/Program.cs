namespace EstebanNapolitano
{
    internal class Usuario
    {
        public int _ID;
        public string _Nombre;
        public string _Apellido;
        public string _NombreUsuario;
        public string _Contraseña;
        public string _Mail;
    }
    internal class Producto
    {
        public int _ID;
        public string _Descripcion;
        public double _Costo;
        public double _PrecioVenta;
        public int _Stock;
        public int _IDUsuario;
    }
    internal class ProductoVendido
    {
        public int _ID;
        public string _IDProducto;
        public int _Stock;
        public int _IDVenta;
    }
    internal class Venta
    {
        public int _ID;
        public string _Comentarios;
        public int _IDUsuario;
    }
}
