using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ej36Guia_Herencia;

namespace Ej43Guia_Excepciones_Clase18
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia competencia = new Competencia(2, 2, Competencia.TipoCompetencia.F1);
            MotoCross moto = new MotoCross(1, "a");
            AutoF1 auto = new AutoF1(2, "b");
            bool agregar;


            try
            {
                agregar = competencia + moto;
                //agregar = competencia + auto;
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

            Console.ReadKey();
        }
    }
}
