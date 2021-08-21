using Expendedora.Consola.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Expendedora.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Maquina maquina = new Maquina();
            Console.WriteLine("Presione 1 para encender la máquina");
            var codIngresado = Console.ReadLine();
            Console.Clear();
            if (codIngresado.ToString() != "1")
            {
                throw new Exception(Exceptions.CodigoInvalido);
            }
            else{
                maquina.EncenderMaquina();
                Console.WriteLine("");
                Console.WriteLine("-o-o-o-o-o-o-o-o-o-o-o-o-o-o-o-");
                Console.WriteLine("");
                Console.WriteLine("Presione 1 para ver el listado de latas");
                Console.WriteLine("Presione 2 para agregar una lata");
                Console.WriteLine("Presione 3 para extraer una lata");
                Console.WriteLine("Presione 4 para obtener el balance");
                Console.WriteLine("Presione 5 para mostrar el stock");

                var accionSolicitada = Console.ReadLine();

                if (int.Parse(accionSolicitada) == 1)
                {
                    int cantidad = GetListadoLatas().Count();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese el código de la lata a agregar: ");
                    for (int i = 0; i < cantidad; ++i)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("- " + GetListadoLatas()[i].Codigo);
                    }
                }
                else if (int.Parse(accionSolicitada) == 2)
                {
                    int cantidad = GetListadoLatas().Count();
                    Console.Clear();
                    Console.WriteLine("");
                    for (int i = 0; i < cantidad; ++i)
                    {
                        Console.WriteLine(GetListadoLatas()[i].Codigo);
                    }

                }
                else if (int.Parse(accionSolicitada) == 3)
                {
                    int cantidad = GetListadoLatas().Count();
                    Console.Clear();
                    Console.WriteLine("");
                    for (int i = 0; i < cantidad; ++i)
                    {
                        Console.WriteLine(GetListadoLatas()[i]);
                    }
                }
                else if (int.Parse(accionSolicitada) == 4)
                {
                    int cantidad = GetListadoLatas().Count();
                    Console.Clear();
                    Console.WriteLine("");
                    for (int i = 0; i < cantidad; ++i)
                    {
                        Console.WriteLine(GetListadoLatas()[i]);
                    }
                }
                else if (int.Parse(accionSolicitada) == 5)
                {
                    int cantidad = GetListadoLatas().Count();
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("La cantidad de latas en stock es: " + cantidad + " unidades");
                    for (int i = 0; i < cantidad; ++i)
                    {
                        Console.WriteLine("- " + GetListadoLatas().Find(f => f.Codigo == GetListadoLatas()[i].Codigo) + " " + GetListadoLatas()[i].Nombre + " " + GetListadoLatas()[i].Sabor);
                    }
                }
            }
            Console.Read();

            
        }

        private static List<Lata> GetListadoLatas()
        {
            var listado = new List<Lata>();
            Lata l1 = new Lata();
            l1.Codigo = "CO1";
            l1.Nombre = "Coca Cola";
            l1.Sabor = "Regular";

            Lata l2 = new Lata();
            l2.Codigo = "CO2";
            l2.Nombre = "Coca Cola";
            l2.Sabor = "Zero";

            Lata l3 = new Lata();
            l3.Codigo = "SP1";
            l3.Nombre = "Sprite";
            l3.Sabor = "Regular";

            Lata l4 = new Lata();
            l4.Codigo = "SP2";
            l4.Nombre = "Sprite";
            l4.Sabor = "Zero";

            Lata l5 = new Lata();
            l5.Codigo = "FA1";
            l5.Nombre = "Fanta";
            l5.Sabor = "Regular";

            Lata l6 = new Lata();
            l6.Codigo = "FA2";
            l6.Nombre = "Fanta";
            l6.Sabor = "Zero";

            listado.Add(l1);
            listado.Add(l2);
            listado.Add(l3);
            listado.Add(l4);
            listado.Add(l5);
            listado.Add(l6);

            return listado;
        }

        private static bool CodigosValidos(string codIngresado)
        {
            var listado = new List<string>();
            listado.Add("CO1");
            listado.Add("CO2");
            listado.Add("SP1");
            listado.Add("SP2");
            listado.Add("FA1");
            listado.Add("FA2");

            int cantidad = listado.Count();

            var listado2 = new List<bool>();

            for (int i=0; i < cantidad; ++i)
            {
                listado2.Add(listado[i].Equals(codIngresado));
            }

            if (listado2.Find(f => f.Equals(true)))
            {
                return true;
            }
            else
            {
                throw new Exception(Exceptions.CodigoInvalido);
            }
        }
    }
}
