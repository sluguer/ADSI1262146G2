using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exito
{
    class Program
    {
        static void Main(string[] args)
        {
            AlmacenesExito oAExito = new AlmacenesExito();
            oAExito.PedirDatos();
            oAExito.CalcularCostoAlmacenamiento();
            oAExito.CalcularPorcentajeDepreciacion();
            oAExito.CalcularCostoExhibicion();
           oAExito.CalcularValorProducto();
            oAExito.CalcularValorVenta();
            oAExito.MostrarResultados();

        }
    }
}
