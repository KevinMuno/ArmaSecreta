﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaparaExamen
{
    public class EstudiantePregrado : EstudianteRegular
    {
        public  double CalcularPromedio()
        {
            return ((Evaluacion1 * 0.15) + (Evaluacion2 * 0.012) + (Evaluacion3 * 0.0225) + (Actitudinal * 0.10)) / 4;
        }
    }
}
