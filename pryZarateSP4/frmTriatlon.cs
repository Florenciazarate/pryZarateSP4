using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
            btnDeterminar.Enabled = false;
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
            List<string> nombresUsados = new List<string>();
            List<string> nacionalidadesUsadas = new List<string>();
            for (i = 0; i < 6; i++)
            {
                var nombre = dgvParticipantes.Rows[i].Cells[1].Value?.ToString();
                var nacionalidad = dgvParticipantes.Rows[i].Cells[2].Value?.ToString();
                if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(nacionalidad))
                {
                    MessageBox.Show("Debe completar los datos de todos los participantes", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (!Regex.IsMatch(nombre, @"^[a-zA-Z\s]{3,}$") || !Regex.IsMatch(nacionalidad, @"^[a-zA-Z\s]{3,}$"))
                {
                    MessageBox.Show("Los campos solo deben tener letras (mínimo 3 caracteres).", "Error", MessageBoxButtons.OK);
                    return;
                }
                if (nombresUsados.Contains(nombre) && nacionalidadesUsadas.Contains(nacionalidad))
                {
                    MessageBox.Show("Duplicado de persona.", "Error", MessageBoxButtons.OK);
                    return;
                }
                nombresUsados.Add(nombre);
                nacionalidadesUsadas.Add(nacionalidad);
            }
            for (i = 0; i < 6; i++)
            {
                dgvPosiciones.Columns[i + 1].HeaderText = dgvParticipantes.Rows[i].Cells[1].Value.ToString();
            }

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
            btnDeterminar.Enabled = true;
        }
    }
}
