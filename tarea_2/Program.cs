using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;


namespace Clasetipodatos
{
    internal class Program
    {

        static void Main(string[] args, int cedula, string tipo, string empleado, int horas, int salario)
        {

            Console.WriteLine("Numero de cedula:");
            cedula = int(Console.ReadLine());

            Console.WriteLine("Nombre del empleado:");
            empleado = string(Console.ReadLine());

            Console.WriteLine("Horas laboradas:");
            horas = int(Console.ReadLine());

            Console.ReadLine("El salario ordinario total:" 400000 * horas);

            salario = 400000 * horas;

            Console.WriteLine("digite el tipo de empleado");
            tipo = Decimal.(Console.ReadLine());
            if (tipo.Equals("Operario"))
            {
                Console.WriteLine(salario * 0,15 / 100);
            }
            else

            if (tipo.Equals("Tecnico"))
            {
                Console.WriteLine(salario * 0, 10 / 100);
            }
            else

            if (tipo.Equals("Profesional"))
            {
                Console.WriteLine(salario * 0, 5 / 100);
            }
            else

            if (!tipo.Equals("Operario") || tipo.Equals("Tecnico") || !tipo.Equals("Profesional"))
            {
                Console.WriteLine("No es una opcion valida");
            } else { }

            Console.ReadLine("El numero de cedula es:" + cedula);
            Console.ReadLine("El nombre del empleado es:" + empleado);
            Console.ReadLine("El tipo de empleado es:" + tipo);
            Console.ReadLine("El salario por hora es de:" + 400000 / 192);
            Console.ReadLine("La cantidad de horas laboradas es de:" + horas);
            Console.ReadLine("El salario ordinario es de:" + 400000);
            Console.ReadLine("El salario bruto es de:" + tipo);
            Console.ReadLine("La deduccion de la CCSS es de 9,17%");
            Console.ReadLine("La deduccion de la CCSS es de 9,17%");
            Console.ReadLine("El salario neto es de:" + tipo - 0,15% ");

        }
    }
}