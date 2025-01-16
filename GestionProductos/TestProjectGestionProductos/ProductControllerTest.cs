using GestionProductos;
using Xunit;

namespace TestProjectGestionProductos
{
    public class ProductoControllerTest
    {
        [Fact]

        public void Test1()
        {
            //configurar
            var producto = new Producto { Nombre = "Prueba", Precio = 10 };

            //validar
            Assert.True(producto.Precio >= 0, "El precio no pyuede ser negativo");
        }

    }

}