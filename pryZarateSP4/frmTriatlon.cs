using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryZarateSP4
{
    public partial class frmTriatlon : Form
    {
        public frmTriatlon()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTriatlon_Load(object sender, EventArgs e)
        {
            int i;
            for (i = 1; i <= 6; i++)
            {
                dgvParticipantes.Rows.Add(i.ToString());
            }
            dgvParticipantes.Columns[0].ReadOnly = true;
            dgvPosiciones.Enabled = false;

        }

        private void btnAsignar_Click(object sender, EventArgs e)
        {
            int i;
            dgvPosiciones.Rows.Clear();
            // verificar que estén cargados todos los participantes
            for (i = 0; i < 6; i++)
            {
                if (dgvParticipantes.Rows[i].Cells[1].Value == null ||
                dgvParticipantes.Rows[i].Cells[2].Value == null)
                {
                    MessageBox.Show("Debe completar los datos de todos los participantes",
                    "Error", MessageBoxButtons.OK);
                    return;
                }
            }
            // configurar las columnas de la grilla
            for (i = 0; i < 6; i++)
            {
                dgvPosiciones.Columns[i + 1].HeaderText =
                dgvParticipantes.Rows[i].Cells[1].Value.ToString();
            }
            // configurar las filas con las 3 pruebas del Triatlón
            for (i = 0; i < 3; i++)
            {
                dgvPosiciones.Rows.Add();
            }
            dgvPosiciones.Rows[0].Cells[0].Value = "Natación";
            dgvPosiciones.Rows[1].Cells[0].Value = "Ciclismo";
            dgvPosiciones.Rows[2].Cells[0].Value = "Carrera";
            dgvPosiciones.Columns[0].ReadOnly = true;
            dgvParticipantes.ClearSelection();
            dgvPosiciones.Enabled = true;
        }
    }
}
