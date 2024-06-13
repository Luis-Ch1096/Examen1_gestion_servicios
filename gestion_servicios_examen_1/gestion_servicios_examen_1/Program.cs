using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestion_servicios_examen_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int servicio, opcion = 0;
            int precio_pre = 31000;
            int precio_reparacion = 7000;
            int precio_diagnostico = 16000;
            int precio_alineacion = 10900;
            int iva = 13;
            int IVA;
            int subt;
            int total;

 
            Console.WriteLine("***** Bienvenido: Taller Auto Soluciones *****");
            Console.WriteLine("Por favor eliga una opcion:\n1-Consultar informacion de servicios.\n2-Salir.");
            opcion = int.Parse(Console.ReadLine());
            while (opcion != 2)
            {
                Console.WriteLine("En Auto Soluciones Le Ofresemos Los Siguientes Servicios: ");
                Console.WriteLine("1-Mantenimiento Preventivo.\n2-Reparación de Motores.\n3-Diagnóstico de Sistemas y Componentes Electrónicos.\n4-Alineación y Balanceo.");
                Console.WriteLine("Por favor digite un número según el servicio que desea: ");
                servicio = int.Parse(Console.ReadLine());
                switch (servicio)
                {
                    case 1:
                        Console.WriteLine("El mantenimiento preventivo es la atención temprana de los distintos componentes del vehículo.\nEs la revision oportuna de:\n" +
                        "**Todos los fluidos del vehiculo\n**Bateria\n**Sistema de enfriamiento\n**Frenos\n**Estado de las llantas\n**Suspensión, entre otros.");
                        subt = precio_pre;
                        IVA = (precio_pre * iva / 100);
                        total = (precio_pre + IVA);
                        Console.WriteLine("Detalle del costo Mantenimiento Preventivo:\nSub Total " + subt + " Colones" +"\nIVA " + IVA + " Colones" + "\nTotal " + total + " Colones");

                        break;
                    case 2:
                        Console.WriteLine("Reparacion de motores tanto Diesel como Gasolina, todos nuestros trabajos cuentan con hasta 90 días de garantia y son realizados por mécanicos altamente calificados.");
                        subt = precio_reparacion;
                        IVA = ( precio_reparacion * iva / 100);
                        total = (precio_reparacion + IVA);
                        Console.WriteLine("El costo por el trabajo de Reparacion de Motores es de:\nSub Total " + subt + " Colones" + "\nIVA " + IVA + " Colones" + "\nTotal " + total + " Colones\n**NOTA IMPORTANTE:Este precio es el valor mínimo por el diagnostico*** ");

                        break;
                    case 3:
                        Console.WriteLine("Si tiene algun problema con los sistemas electrónicos de su vehículo puede confiar en las capacidades únicas de nuestros especialistas, desde el diagnostico y lectura más básico hasta el más avanzado, contamos con tecnología de punta para el diagnóstico y reparación de sistemas electrónicos.");
                        subt = precio_diagnostico;
                        IVA = (precio_diagnostico * iva / 100);
                        total = (precio_diagnostico + IVA);
                        Console.WriteLine("Detalle del costo por el servicio de Dianostico de Sistemas Electrónicos:\nSub Total " + subt + " Colones" + "\nIVA " + IVA + " Colones" + "\nTotal " + total + " Colones");
                        break;
                    case 4:
                        Console.WriteLine("El servicio de alineación y balanceo es bastante común y se debe hacer con cierda periocidad, esto ofrecera una mayor estabilidad, amarre, y seguridad a tu vehículo.\n" + "Estos dos servicios son muy importantes para mantener en óptimas condiciones las llantas, extender su vida útil y lo más importante garantizar la seguridad de los ocupantes del vehículo.");
                        subt = precio_alineacion;
                        IVA = (precio_alineacion * iva / 100);
                        total = (precio_alineacion + IVA);
                        Console.WriteLine("Detalle del costo Servicio de Alineación y Balanceo:\nSub Total: " + subt + " Colones" + "\nIVA " + IVA + " Colones" + "\nTotal " + total + " Colones");
                        break;
                    default:
                        Console.WriteLine("Opcion Incorrecta.");
                        Console.WriteLine("1-Mantenimiento Preventivo.\n2-Reparación de Motores.\n3-Diagnóstico de Sistemas y Componentes Electrónicos.\n4-Alineación y Balanceo.");
                        Console.WriteLine("Por favor digite un número según el servicio que desea: ");
                        break;
                }
                Console.WriteLine("Por favor eliga una opcion:\n1-Consultar informacion de servicios.\n2-Salir.");
                opcion = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ha salido del programa.\nGracias por consultar los servicios de su taller Auto Soluciones, siempre sera un gusto atenderle.");
            Console.Read();
        }
    }
}
