using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaparaExamen
{
    public partial class Regular : Form
    {
        List<EstudianteRegular> estRegular = new List<EstudianteRegular>();
        public Regular()
        {
            InitializeComponent();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            EstudianteRegular estReg = new EstudianteRegular
            {
                NombreEstudiante = txtEstudiante.Text,
                Evaluacion1 = double.Parse(txtEva1.Text),
                Evaluacion2 = double.Parse(txtEva2.Text),
                Evaluacion3 = double.Parse(txtEva3.Text),
                Actitudinal = double.Parse(txtActitudinal.Text),

            };
            estRegular.Add(estReg);
            ActualizarDataGridView();

        }

        private void ActualizarDataGridView()
        {
            // Actualiza el DataGridView con la lista de estudiantes
            dgvDetalles.DataSource = null;
            dgvDetalles.DataSource = estRegular.Select(estudiante => new
            {
                estudiante.NombreEstudiante,
                estudiante.Evaluacion1,
                estudiante.Evaluacion2,
                estudiante.Evaluacion3,
                estudiante.Actitudinal,
                Promedio = estudiante.CalcularPromedio(),
                Condicion = estudiante.Condicion()
            }).ToList();
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            var estudianteMejorPromedio = estRegular
           .OrderByDescending(est => est.CalcularPromedio())
           .FirstOrDefault();

            txtPromedioAlto.Text = estudianteMejorPromedio?.NombreEstudiante ?? "N/A";

            int aprobados = estRegular.Count(est => est.Condicion() != "REPROBADO");
            int reprobados = estRegular.Count(est => est.Condicion() == "REPROBADO");

            txtAprobados.Text = aprobados.ToString();
            txtReprobados.Text = reprobados.ToString();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtEstudiante.Clear();
            txtEva1.Clear();
            txtEva2.Clear();
            txtEva3.Clear();
            txtActitudinal.Clear();
            txtEstudiante.Focus();
        }
    }
}
