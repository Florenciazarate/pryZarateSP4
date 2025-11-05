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
            pictureBox1 = new PictureBox();
            lblBienvenido = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.DarkSeaGreen;
            btnAsignar.FlatStyle = FlatStyle.Popup;
            btnAsignar.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignar.Location = new Point(374, 254);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(132, 54);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar participantes";
            btnAsignar.UseVisualStyleBackColor = false;
            // 
            // btnDeterminar
            // 
            btnDeterminar.BackColor = Color.DarkSeaGreen;
            btnDeterminar.FlatStyle = FlatStyle.Popup;
            btnDeterminar.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeterminar.Location = new Point(25, 614);
            btnDeterminar.Name = "btnDeterminar";
            btnDeterminar.Size = new Size(151, 35);
            btnDeterminar.TabIndex = 1;
            btnDeterminar.Text = "Determinar ganadores";
            btnDeterminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.DarkSeaGreen;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(536, 892);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(132, 30);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToDeleteRows = false;
            dgvParticipantes.BackgroundColor = Color.Linen;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Columns.AddRange(new DataGridViewColumn[] { clmNumero, clmNombre, clmPais });
            dgvParticipantes.Location = new Point(25, 102);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.Size = new Size(343, 206);
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
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParticipantes.Location = new Point(25, 71);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(104, 21);
            lblParticipantes.TabIndex = 4;
            lblParticipantes.Text = "Participantes";
            // 
            // lblPosiciones
            // 
            lblPosiciones.AutoSize = true;
            lblPosiciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosiciones.Location = new Point(25, 340);
            lblPosiciones.Name = "lblPosiciones";
            lblPosiciones.Size = new Size(86, 21);
            lblPosiciones.TabIndex = 5;
            lblPosiciones.Text = "Posiciónes";
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.BackgroundColor = Color.Linen;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { clmPrueba, clmParticipante1, clmParticipante2, clmParticipante3, clmParticipante4, clmParticipante5 });
            dataGridView1.Location = new Point(25, 372);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(643, 236);
            dataGridView1.TabIndex = 6;
            // 
            // clmPrueba
            // 
            clmPrueba.HeaderText = "Prueba";
            clmPrueba.Name = "clmPrueba";
            clmPrueba.ReadOnly = true;
            // 
            // clmParticipante1
            // 
            clmParticipante1.HeaderText = "Participante 1";
            clmParticipante1.Name = "clmParticipante1";
            clmParticipante1.ReadOnly = true;
            // 
            // clmParticipante2
            // 
            clmParticipante2.HeaderText = "Participante 2";
            clmParticipante2.Name = "clmParticipante2";
            clmParticipante2.ReadOnly = true;
            // 
            // clmParticipante3
            // 
            clmParticipante3.HeaderText = "Participante 3";
            clmParticipante3.Name = "clmParticipante3";
            clmParticipante3.ReadOnly = true;
            // 
            // clmParticipante4
            // 
            clmParticipante4.HeaderText = "Participante 4";
            clmParticipante4.Name = "clmParticipante4";
            clmParticipante4.ReadOnly = true;
            // 
            // clmParticipante5
            // 
            clmParticipante5.HeaderText = "Participante 5";
            clmParticipante5.Name = "clmParticipante5";
            clmParticipante5.ReadOnly = true;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.BackgroundColor = Color.Linen;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6 });
            dataGridView2.Location = new Point(25, 701);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.ReadOnly = true;
            dataGridView2.Size = new Size(643, 162);
            dataGridView2.TabIndex = 8;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.HeaderText = "Prueba";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.HeaderText = "Participante 1";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.HeaderText = "Participante 2";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.HeaderText = "Participante 3";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.HeaderText = "Participante 4";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.HeaderText = "Participante 5";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanador.Location = new Point(25, 673);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(72, 21);
            lblGanador.TabIndex = 7;
            lblGanador.Text = "Ganador";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.podio_jpg;
            pictureBox1.Location = new Point(504, 739);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 124);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(25, 16);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(281, 30);
            lblBienvenido.TabIndex = 10;
            lblBienvenido.Text = "Bienvenido al Triatlón 2025";
            // 
            // frmTriatlon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(707, 975);
            Controls.Add(lblBienvenido);
            Controls.Add(pictureBox1);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAsignar;
        private Button btnDeterminar;
        private Button btnSalir;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private DataGridView dgvParticipantes;
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
        private DataGridViewTextBoxColumn clmNumero;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmPais;
        private PictureBox pictureBox1;
        private Label lblBienvenido;
    }
}