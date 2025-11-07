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
            dgvPosiciones = new DataGridView();
            clmPrueba = new DataGridViewTextBoxColumn();
            clmParticipante1 = new DataGridViewTextBoxColumn();
            clmParticipante2 = new DataGridViewTextBoxColumn();
            clmParticipante3 = new DataGridViewTextBoxColumn();
            clmParticipante4 = new DataGridViewTextBoxColumn();
            clmParticipante5 = new DataGridViewTextBoxColumn();
            clmParticipante6 = new DataGridViewTextBoxColumn();
            dgvGanador = new DataGridView();
            clmPuesto = new DataGridViewTextBoxColumn();
            clmNombreGanadores = new DataGridViewTextBoxColumn();
            clmPaisGanadores = new DataGridViewTextBoxColumn();
            clmPuntosGanadores = new DataGridViewTextBoxColumn();
            lblGanador = new Label();
            imgGanador = new PictureBox();
            lblBienvenido = new Label();
            lblFrase = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvGanador).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imgGanador).BeginInit();
            SuspendLayout();
            // 
            // btnAsignar
            // 
            btnAsignar.BackColor = Color.Ivory;
            btnAsignar.FlatStyle = FlatStyle.Popup;
            btnAsignar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAsignar.Location = new Point(25, 273);
            btnAsignar.Name = "btnAsignar";
            btnAsignar.Size = new Size(239, 39);
            btnAsignar.TabIndex = 0;
            btnAsignar.Text = "Asignar participantes";
            btnAsignar.UseVisualStyleBackColor = false;
            btnAsignar.Click += btnAsignar_Click;
            // 
            // btnDeterminar
            // 
            btnDeterminar.BackColor = Color.Ivory;
            btnDeterminar.FlatStyle = FlatStyle.Popup;
            btnDeterminar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeterminar.Location = new Point(645, 205);
            btnDeterminar.Name = "btnDeterminar";
            btnDeterminar.Size = new Size(239, 39);
            btnDeterminar.TabIndex = 1;
            btnDeterminar.Text = "Determinar ganadores";
            btnDeterminar.UseVisualStyleBackColor = false;
            btnDeterminar.Click += btnDeterminar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.Ivory;
            btnSalir.FlatStyle = FlatStyle.Popup;
            btnSalir.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.Location = new Point(1109, 649);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(239, 39);
            btnSalir.TabIndex = 2;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // dgvParticipantes
            // 
            dgvParticipantes.AllowUserToAddRows = false;
            dgvParticipantes.AllowUserToDeleteRows = false;
            dgvParticipantes.AllowUserToResizeColumns = false;
            dgvParticipantes.AllowUserToResizeRows = false;
            dgvParticipantes.BackgroundColor = Color.Linen;
            dgvParticipantes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvParticipantes.Columns.AddRange(new DataGridViewColumn[] { clmNumero, clmNombre, clmPais });
            dgvParticipantes.Location = new Point(25, 90);
            dgvParticipantes.Name = "dgvParticipantes";
            dgvParticipantes.RowHeadersVisible = false;
            dgvParticipantes.Size = new Size(553, 177);
            dgvParticipantes.TabIndex = 3;
            // 
            // clmNumero
            // 
            clmNumero.HeaderText = "Número";
            clmNumero.MaxInputLength = 30;
            clmNumero.Name = "clmNumero";
            clmNumero.Resizable = DataGridViewTriState.False;
            // 
            // clmNombre
            // 
            clmNombre.HeaderText = "Nombre";
            clmNombre.Name = "clmNombre";
            clmNombre.Width = 250;
            // 
            // clmPais
            // 
            clmPais.HeaderText = "País";
            clmPais.Name = "clmPais";
            clmPais.Width = 200;
            // 
            // lblParticipantes
            // 
            lblParticipantes.AutoSize = true;
            lblParticipantes.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblParticipantes.Location = new Point(25, 59);
            lblParticipantes.Name = "lblParticipantes";
            lblParticipantes.Size = new Size(104, 21);
            lblParticipantes.TabIndex = 4;
            lblParticipantes.Text = "Participantes";
            // 
            // lblPosiciones
            // 
            lblPosiciones.AutoSize = true;
            lblPosiciones.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPosiciones.Location = new Point(645, 59);
            lblPosiciones.Name = "lblPosiciones";
            lblPosiciones.Size = new Size(86, 21);
            lblPosiciones.TabIndex = 5;
            lblPosiciones.Text = "Posiciónes";
            // 
            // dgvPosiciones
            // 
            dgvPosiciones.AllowUserToAddRows = false;
            dgvPosiciones.AllowUserToDeleteRows = false;
            dgvPosiciones.AllowUserToResizeColumns = false;
            dgvPosiciones.AllowUserToResizeRows = false;
            dgvPosiciones.BackgroundColor = Color.Linen;
            dgvPosiciones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPosiciones.Columns.AddRange(new DataGridViewColumn[] { clmPrueba, clmParticipante1, clmParticipante2, clmParticipante3, clmParticipante4, clmParticipante5, clmParticipante6 });
            dgvPosiciones.Location = new Point(645, 90);
            dgvPosiciones.Name = "dgvPosiciones";
            dgvPosiciones.RowHeadersVisible = false;
            dgvPosiciones.Size = new Size(703, 109);
            dgvPosiciones.TabIndex = 6;
            // 
            // clmPrueba
            // 
            clmPrueba.HeaderText = "Prueba";
            clmPrueba.MaxInputLength = 10;
            clmPrueba.Name = "clmPrueba";
            clmPrueba.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante1
            // 
            clmParticipante1.HeaderText = "Participante 1";
            clmParticipante1.Name = "clmParticipante1";
            clmParticipante1.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante2
            // 
            clmParticipante2.HeaderText = "Participante 2";
            clmParticipante2.Name = "clmParticipante2";
            clmParticipante2.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante3
            // 
            clmParticipante3.HeaderText = "Participante 3";
            clmParticipante3.Name = "clmParticipante3";
            clmParticipante3.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante4
            // 
            clmParticipante4.HeaderText = "Participante 4";
            clmParticipante4.Name = "clmParticipante4";
            clmParticipante4.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante5
            // 
            clmParticipante5.HeaderText = "Participante 5";
            clmParticipante5.Name = "clmParticipante5";
            clmParticipante5.Resizable = DataGridViewTriState.False;
            // 
            // clmParticipante6
            // 
            clmParticipante6.HeaderText = "Participante 6";
            clmParticipante6.Name = "clmParticipante6";
            // 
            // dgvGanador
            // 
            dgvGanador.AllowUserToAddRows = false;
            dgvGanador.AllowUserToDeleteRows = false;
            dgvGanador.AllowUserToResizeColumns = false;
            dgvGanador.AllowUserToResizeRows = false;
            dgvGanador.BackgroundColor = Color.Linen;
            dgvGanador.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvGanador.Columns.AddRange(new DataGridViewColumn[] { clmPuesto, clmNombreGanadores, clmPaisGanadores, clmPuntosGanadores });
            dgvGanador.Location = new Point(25, 474);
            dgvGanador.Name = "dgvGanador";
            dgvGanador.ReadOnly = true;
            dgvGanador.RowHeadersVisible = false;
            dgvGanador.Size = new Size(403, 104);
            dgvGanador.TabIndex = 8;
            // 
            // clmPuesto
            // 
            clmPuesto.HeaderText = "Puesto";
            clmPuesto.MaxInputLength = 30;
            clmPuesto.Name = "clmPuesto";
            clmPuesto.ReadOnly = true;
            clmPuesto.Resizable = DataGridViewTriState.False;
            // 
            // clmNombreGanadores
            // 
            clmNombreGanadores.HeaderText = "Nombre";
            clmNombreGanadores.Name = "clmNombreGanadores";
            clmNombreGanadores.ReadOnly = true;
            // 
            // clmPaisGanadores
            // 
            clmPaisGanadores.HeaderText = "País";
            clmPaisGanadores.Name = "clmPaisGanadores";
            clmPaisGanadores.ReadOnly = true;
            // 
            // clmPuntosGanadores
            // 
            clmPuntosGanadores.HeaderText = "Puntos";
            clmPuntosGanadores.Name = "clmPuntosGanadores";
            clmPuntosGanadores.ReadOnly = true;
            // 
            // lblGanador
            // 
            lblGanador.AutoSize = true;
            lblGanador.FlatStyle = FlatStyle.System;
            lblGanador.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGanador.Location = new Point(25, 441);
            lblGanador.Name = "lblGanador";
            lblGanador.Size = new Size(97, 30);
            lblGanador.TabIndex = 7;
            lblGanador.Text = "Ganador";
            // 
            // imgGanador
            // 
            imgGanador.BorderStyle = BorderStyle.Fixed3D;
            imgGanador.Image = Properties.Resources.imgPodio;
            imgGanador.Location = new Point(488, 409);
            imgGanador.Name = "imgGanador";
            imgGanador.Size = new Size(223, 190);
            imgGanador.SizeMode = PictureBoxSizeMode.StretchImage;
            imgGanador.TabIndex = 9;
            imgGanador.TabStop = false;
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
            // lblFrase
            // 
            lblFrase.AutoSize = true;
            lblFrase.Font = new Font("Perpetua Titling MT", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFrase.Location = new Point(25, 343);
            lblFrase.Name = "lblFrase";
            lblFrase.Size = new Size(1195, 32);
            lblFrase.TabIndex = 11;
            lblFrase.Text = "\"El éxito solo llega a quienes estan demasiado ocupados buscandolos\"";
            // 
            // frmTriatlon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Bisque;
            ClientSize = new Size(1364, 700);
            Controls.Add(lblFrase);
            Controls.Add(lblBienvenido);
            Controls.Add(imgGanador);
            Controls.Add(dgvGanador);
            Controls.Add(lblGanador);
            Controls.Add(dgvPosiciones);
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
            Load += frmTriatlon_Load;
            ((System.ComponentModel.ISupportInitialize)dgvParticipantes).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvPosiciones).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvGanador).EndInit();
            ((System.ComponentModel.ISupportInitialize)imgGanador).EndInit();
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
        private DataGridView dgvPosiciones;
        private DataGridView dgvGanador;
        private Label lblGanador;
        private PictureBox imgGanador;
        private Label lblBienvenido;
        private DataGridViewTextBoxColumn clmNumero;
        private DataGridViewTextBoxColumn clmNombre;
        private DataGridViewTextBoxColumn clmPais;
        private DataGridViewTextBoxColumn clmPrueba;
        private DataGridViewTextBoxColumn clmParticipante1;
        private DataGridViewTextBoxColumn clmParticipante2;
        private DataGridViewTextBoxColumn clmParticipante3;
        private DataGridViewTextBoxColumn clmParticipante4;
        private DataGridViewTextBoxColumn clmParticipante5;
        private DataGridViewTextBoxColumn clmParticipante6;
        private DataGridViewTextBoxColumn clmPuesto;
        private DataGridViewTextBoxColumn clmNombreGanadores;
        private DataGridViewTextBoxColumn clmPaisGanadores;
        private DataGridViewTextBoxColumn clmPuntosGanadores;
        private Label lblFrase;
    }
}