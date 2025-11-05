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
        public struct DATOS
        {
            public int participante;
            public int puntos;
        }

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
        private void btnDeterminar_Click(object sender, EventArgs e)
        {
            {
                int fila;
                int col;
                int i;
                string valor;
                string nombre;
                string nacionalidad;
                if (!ValidarPosiciones())
                {
                    MessageBox.Show("Los datos son incorrectos, revise las posiciones asignadas",
                    "Error", MessageBoxButtons.OK);
                    return;
                }
                dgvPosiciones.ClearSelection();
                int[,] puestos = new int[3, 6];
                for (fila = 0; fila < 3; fila++)
                {
                    for (col = 0; col < 6; col++)
                    {

                        valor = dgvPosiciones.Rows[fila].Cells[col + 1].Value.ToString();
                        puestos[fila, col] = int.Parse(valor);
                    }
                }
                DATOS[] datos = new DATOS[6];
                for (i = 0; i < 6; i++)
                {
                    datos[i].participante = i + 1;
                    datos[i].puntos = 0;
                }
                for (col = 0; col < 6; col++)
                {
                    for (fila = 0; fila < 3; fila++)
                    {
                        datos[col].puntos += ObtenerPuntos(puestos[fila, col]);
                    }
                }
                DATOS[] ganadores = new DATOS[3];
                ganadores[0] = BuscarMayorPuntaje(datos, ganadores);
                ganadores[1] = BuscarMayorPuntaje(datos, ganadores);
                ganadores[2] = BuscarMayorPuntaje(datos, ganadores);
                dgvGanador.Rows.Clear();
                for (fila = 0; fila < 3; fila++)
                {
                    dgvGanador.Rows.Add();
                    dgvGanador.Rows[fila].Cells[0].Value = fila + 1;
                    int f = ganadores[fila].participante - 1;
                    nombre = dgvParticipantes.Rows[f].Cells[1].Value.ToString();
                    dgvGanador.Rows[fila].Cells[1].Value = nombre;
                    nacionalidad = dgvParticipantes.Rows[f].Cells[2].Value.ToString();
                    dgvGanador.Rows[fila].Cells[2].Value = nacionalidad;
                    dgvGanador.Rows[fila].Cells[3].Value = ganadores[fila].puntos.ToString();
                }
                dgvGanador.ClearSelection();
                EscribirGanadores();
            }
        }
        private bool ValidarPosiciones()
        {
            int f, c, i;
            int valor;

            for (f = 0; f < dgvPosiciones.RowCount; f++)
            {
                for (c = 1; c < dgvPosiciones.ColumnCount; c++)
                {
                    var celda = dgvPosiciones.Rows[f].Cells[c].Value;
                    if (celda == null || !int.TryParse(celda.ToString(), out valor) || valor < 1 || valor > 6)
                    {
                        MessageBox.Show("Solo se permiten números del 1 al 6.",
                                        "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                    for (i = c + 1; i < dgvPosiciones.ColumnCount; i++)
                    {
                        var celdaComparar = dgvPosiciones.Rows[f].Cells[i].Value;
                        if (celdaComparar != null &&
                            int.TryParse(celdaComparar.ToString(), out int valorComparar) &&
                            valor == valorComparar)
                        {
                            MessageBox.Show($"Valor repetido ({valor}) en la fila {f + 1}.",
                                            "Error de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            return true;
        }
        private int ObtenerPuntos(int puesto)
        {
            int[] puntos = new int[6] { 1000, 920, 830, 740, 650, 560 };
            return puntos[puesto - 1];
        }
        private DATOS BuscarMayorPuntaje(DATOS[] d, DATOS[] g)
        {
            DATOS resultado;
            int i;
            int f;
            int ganadorPrevio;
            resultado.participante = 0;
            resultado.puntos = 0;
            for (i = 0; i < 6; i++)
            {
                if (d[i].puntos > resultado.puntos)
                {
                    ganadorPrevio = 0;
                    for (f = 0; f < g.Length; f++)
                    {
                        if (d[i].participante == g[f].participante)
                        {
                            ganadorPrevio = 1;
                        }
                    }
                    if (ganadorPrevio == 0)
                    {
                        resultado.puntos = d[i].puntos;
                        resultado.participante = d[i].participante;
                    }
                }
            }
            return resultado;
        }
        private void EscribirGanadores()
        {
            int ancho = imgGanador.Width;
            int alto = imgGanador.Height;
            StringFormat formato = new StringFormat();
            formato.Alignment = StringAlignment.Center;
            formato.LineAlignment = StringAlignment.Center;
            Graphics gra = imgGanador.CreateGraphics();
            string nombre = dgvGanador.Rows[0].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Segoe UI", 14), Brushes.Black,
            (ancho / 2), alto / 4, formato);
            nombre = dgvGanador.Rows[1].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Segoe UI", 9), Brushes.Black,
            (ancho / 4), alto / 2.75f, formato);
            nombre = dgvGanador.Rows[2].Cells[1].Value.ToString();
            gra.DrawString(nombre, new Font("Segoe UI", 9), Brushes.Black,
            (ancho / 1.33f), alto / 2, formato);
        }
    }
}
