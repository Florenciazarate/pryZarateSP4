namespace pryZarateSP4
{
    partial class frmTriatlon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTriatlon));
            btnAsignar = new Button();
            btnDeterminar = new Button();
            btnSalir = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dgvParticipantes = new DataGridView();
            clmNumero = new DataGridViewTextBoxColumn();
            clmNombre = new DataGridViewTextBoxColumn();
            clmPais = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            lblParticipantes = new Label();
            lblPosiciones = new Label();
            dataGridView1 = new DataGridView();
            clmPrueba = new DataGridViewTextBoxColumn();
            clmParticipante1 = new DataGridViewTextBoxColumn();
            clmParticipante2 = new DataGridViewTextBoxColumn();
            clmParticipante3 = new DataGridViewTextBoxColumn();
            clmParticipante4 = new DataGridViewTextBoxColumn();
            clmParticipante5 = new DataGridViewTextBoxColumn();
            dataGridView2 = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            lblGanador = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.DarkSeaGreen;
            btnAsignar.FlatStyle = FlatStyle.Popup;
            btnAsignar.Location = new Point(596, 66);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(132, 30);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar participantes";
            btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnDeterminar
            // 
            btnDeterminar.BackColor = Color.DarkSeaGreen;
            btnDeterminar.FlatStyle = FlatStyle.Popup;
            btnDeterminar.Location = new Point(596, 99);
            btnDeterminar.Name = "btnDeterminar";
            btnDeterminar.Size = new Size(132, 30);
            btnDeterminar.TabIndex = 1;
            btnDeterminar.Text = "Determinar ganadores";
            btnDeterminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSeaGreen;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Location = new Point(596, 132);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 30);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.BackgroundColor = Color.Linen;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Columns.AddRange(new DataGridViewColumn[] { clmNumero, clmNombre, clmPais, Column1 });
            dgvParticipantes.Location = new Point(25, 66);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.Size = new Size(344, 74);
            dgvParticipantes.TabIndex = 3;
            // 
            // clmNumero
            // 
            clmNumero.HeaderText = "Número";
            clmNumero.Name = "clmNumero";
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.Name = "clmNombre";
            // 
            // clmPais
            // 
            clmPais.HeaderText = "País";
            clmPais.Name = "clmPais";
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Location = new Point(25, 46);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(75, 15);
            lblParticipantes.TabIndex = 4;
            lblParticipantes.Text = "Participantes";
            // 
            // lblPosiciones
            // 
            lblPosiciones.AutoSize = true;
            lblPosiciones.Location = new Point(25, 163);
            lblPosiciones.Name = "lblPosiciones";
            lblPosiciones.Size = new Size(63, 15);
            lblPosiciones.TabIndex = 5;
            lblPosiciones.Text = "Posiciónes";
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmPrueba, clmParticipante1, clmParticipante2, clmParticipante3, clmParticipante4, clmParticipante5 });
            dataGridView1.Location = new Point(25, 184);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(643, 105);
            dataGridView1.TabIndex = 6;
            // 
            // clmPrueba
            // 
            clmPrueba.HeaderText = "Prueba";
            clmPrueba.Name = "clmPrueba";
            // 
            // clmParticipante1
            // 
            clmParticipante1.HeaderText = "Participante 1";
            clmParticipante1.Name = "clmParticipante1";
            // 
            // clmParticipante2
            // 
            clmParticipante2.HeaderText = "Participante 2";
            clmParticipante2.Name = "clmParticipante2";
            // 
            // clmParticipante3
            // 
            clmParticipante3.HeaderText = "Participante 3";
            clmParticipante3.Name = "clmParticipante3";
            // 
            // clmParticipante4
            // 
            clmParticipante4.HeaderText = "Participante 4";
            clmParticipante4.Name = "clmParticipante4";
            // 
            // clmParticipante5
            // 
            clmParticipante5.HeaderText = "Participante 5";
            clmParticipante5.Name = "clmParticipante5";
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = Color.Linen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(25, 326);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(643, 105);
            dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Prueba";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Participante 1";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Participante 2";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Participante 3";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Participante 4";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Participante 5";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Location = new Point(25, 305);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(52, 15);
            lblGanador.TabIndex = 7;
            lblGanador.Text = "Ganador";
            // 
            // frmTriatlon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(800, 527);
            Controls.Add(dataGridView2);
            Controls.Add(lblGanador);
            Controls.Add(dataGridView1);
            Controls.Add(lblPosiciones);
            Controls.Add(lblParticipantes);
            Controls.Add(dgvParticipantes);
            Controls.Add(btnSalir);
            Controls.Add(btnDeterminar);
            Controls.Add(btnAsignar);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "frmTriatlon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmTriatlon";
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnDeterminar;
        private Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvParticipantes;
        private DataGridViewTextBoxColumn clmNumero;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmPais;
        private DataGridViewTextBoxColumn Column1;
        private Label lblParticipantes;
        private Label lblPosiciones;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn clmPrueba;
        private DataGridViewTextBoxColumn clmParticipante1;
        private DataGridViewTextBoxColumn clmParticipante2;
        private DataGridViewTextBoxColumn clmParticipante3;
        private DataGridViewTextBoxColumn clmParticipante4;
        private DataGridViewTextBoxColumn clmParticipante5;
        private DataGridView dataGridView2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Label lblGanador;
    }
}