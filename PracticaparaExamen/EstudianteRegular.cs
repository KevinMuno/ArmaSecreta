using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaparaExamen
{
    public class EstudianteRegular
    {
        public string NombreEstudiante { get; set; }
        public double Evaluacion1 { get; set; }
        public double Evaluacion2 { get; set; }
        public double Evaluacion3 { get; set; }
        public double Actitudinal { get; set; }



        public double CalcularPromedio()
        {
            return (Evaluacion1 + Evaluacion2 + Evaluacion3 + Actitudinal) / 4;
        }
        public string Condicion()
        {
            double Promedio = CalcularPromedio();
            if (Promedio >= 91)
            {
                return "EXCELENTE";
            }
            else if (Promedio >= 81)
            {
                return "MUY BUENO";
            }
            else if (Promedio >= 71)
            {
                return "BUENO";
            }
            else if (Promedio >= 61)
            {
                return "REGULAR";
            }
            else if (Promedio <= 60)
            {
                return "REPROBADO";
            }
            return "";



        }
    }
}
