using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exito
{
    class AlmacenesExito
    {
        #region Atributos 
        public decimal costoDeCompra, periodoDeConservacion, periodoDeAlmacenamiento, volumen, valorVenta,
            valorProducto, costoAlmacenamiento, costoExhibicion, porcentajeDeDepresiacion;
        public string tipoDeProducto, tipoDeConservacion, medioDeAlmacenamiento;
        #endregion
        #region Metodos

        public void PedirDatos()
        {
            Console.WriteLine("***DATOS DE ENTRADA***");
            Console.Write("Costo de Compra ($):                                                        ");
            costoDeCompra = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Tipo de Producto[P]erecedero, [N]o Perecedero:                              ");
            tipoDeProducto =Console.ReadLine();
            Console.Write("Tipo de Conservacion [F]rio ,[A]mbiente :                                   ");
            tipoDeConservacion = Console.ReadLine();
            Console.Write("Periodo de Conservacion (dias):                                             ");
            periodoDeConservacion = Convert.ToDecimal(Console.ReadLine());
            Console.Write("periodo de almacenamiento(dias):                                            ");
            periodoDeAlmacenamiento = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Volumen (Litros):                                                           ");
            volumen = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Medio de almacenamiento [N]everra, [C]ongelador, [E]stanteria, [G]uacal :   ");
            medioDeAlmacenamiento=Console.ReadLine();

        }


        public void CalcularCostoAlmacenamiento()
        {
            if (tipoDeProducto == "P" || tipoDeProducto == "p")
            {
                if ((tipoDeConservacion == "F" || tipoDeConservacion == "f") && (periodoDeConservacion < 10))
                {
                    costoAlmacenamiento = costoDeCompra * 0.05M;
                }
                if ((tipoDeConservacion == "F" || tipoDeConservacion == "f") && (periodoDeConservacion >= 10))
                {
                    costoAlmacenamiento = costoDeCompra * 0.10M;
                }
                if ((tipoDeConservacion == "A" || tipoDeConservacion == "a") && (periodoDeConservacion < 20))
                {
                    costoAlmacenamiento = costoDeCompra * 0.03M;
                }

                if ((tipoDeConservacion == "A" || tipoDeConservacion == "a") && (periodoDeConservacion > 20))
                {
                    costoAlmacenamiento = costoDeCompra * 0.10M;
                }
                if ((tipoDeConservacion == "A" || tipoDeConservacion == "a") && (periodoDeAlmacenamiento == 20))
                {
                    costoAlmacenamiento = costoDeCompra * 0.05M;
                }
            }
            else
            {
                if (volumen >= 50)
                {
                    costoAlmacenamiento = costoDeCompra * 0.10M;

                }
                else
                {
                    costoAlmacenamiento = costoDeCompra * 0.20M;
                }

            }


        }
      

        public void CalcularPorcentajeDepreciacion()
        {
            if (periodoDeAlmacenamiento < 30)
            {
                porcentajeDeDepresiacion = 0.95M;
            }
            else
            {
                porcentajeDeDepresiacion = 0.85M;
            }
        }


        public void CalcularCostoExhibicion()
        {
            if (tipoDeProducto == "P" || tipoDeProducto == "p")//Perecederos
            {
                if ((tipoDeConservacion == "F" || tipoDeConservacion == "f") && (medioDeAlmacenamiento == "N" || medioDeAlmacenamiento == "n"))
                {
                    costoExhibicion = costoAlmacenamiento * 2;
                }
                else
                {
                    costoExhibicion = costoAlmacenamiento;//revizar
                }

               
            }
            else
            {
                if ((medioDeAlmacenamiento == "E" || medioDeAlmacenamiento == "e"))
                {
                    costoExhibicion = costoAlmacenamiento * 0.05M;
                }
                else
                {
                    costoExhibicion = costoAlmacenamiento * 0.07M;
                }
            }
        }


        public void CalcularValorProducto()
        {
            valorProducto = (costoDeCompra + costoAlmacenamiento + costoExhibicion) * porcentajeDeDepresiacion;

        }

        public void CalcularValorVenta()
        {
            if ((tipoDeProducto == "N") || (tipoDeProducto == "n"))
            {
                valorVenta = (valorProducto * 0.2M) + valorProducto;
            }
            else
            {
                valorVenta = (valorProducto * 0.4M) + valorProducto;
            }
        }
        public void MostrarResultados()
        {
            Console.WriteLine("*** REsultadOS ***");
            Console.WriteLine("Costos de almacenamiento                                                   :${0,14:N2}",costoAlmacenamiento);
            Console.WriteLine("porcentaje de depreciacion del producto                                     :{0,14:P1}",porcentajeDeDepresiacion);
            Console.WriteLine("costos de exhibicion                                                       :${0,14:N2}",costoExhibicion);
            Console.WriteLine("valor del producto                                                         :${0,14:N2}",valorProducto);
            Console.WriteLine("valor de venta                                                             :${0,14:N2}",valorVenta);
            Console.ReadKey();
        }
        }
        #endregion


    }
