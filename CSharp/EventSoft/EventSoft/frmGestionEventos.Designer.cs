namespace EventSoft
{
    partial class frmGestionEventos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGestionEventos));
            this.tsMenu = new System.Windows.Forms.ToolStrip();
            this.btnNuevo = new System.Windows.Forms.ToolStripButton();
            this.btnGuardar = new System.Windows.Forms.ToolStripButton();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.lblGestionEventos = new System.Windows.Forms.Label();
            this.tbGestionEventos = new System.Windows.Forms.TabControl();
            this.tpDatosGenerales = new System.Windows.Forms.TabPage();
            this.btnSubirFoto = new System.Windows.Forms.Button();
            this.gbDocentesResponsables = new System.Windows.Forms.GroupBox();
            this.btnEliminarDocente = new System.Windows.Forms.Button();
            this.btnAgregarDocente = new System.Windows.Forms.Button();
            this.btnBuscarDocente = new System.Windows.Forms.Button();
            this.txtNombreDocente = new System.Windows.Forms.TextBox();
            this.lblNombreDocente = new System.Windows.Forms.Label();
            this.txtCodigoPUCPDocente = new System.Windows.Forms.TextBox();
            this.lblCodigoPUCPDocente = new System.Windows.Forms.Label();
            this.dgvDocentes = new System.Windows.Forms.DataGridView();
            this.CodigoPUCP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCompleto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCosto = new System.Windows.Forms.TextBox();
            this.lblCosto = new System.Windows.Forms.Label();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.lblEspecialidad = new System.Windows.Forms.Label();
            this.lblFechaFin = new System.Windows.Forms.Label();
            this.lblFechaInicio = new System.Windows.Forms.Label();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.txtNombreEvento = new System.Windows.Forms.TextBox();
            this.lblNombreEvento = new System.Windows.Forms.Label();
            this.txtIDEvento = new System.Windows.Forms.TextBox();
            this.lblIDEvento = new System.Windows.Forms.Label();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.tbActividades = new System.Windows.Forms.TabPage();
            this.btnEliminarActividad = new System.Windows.Forms.Button();
            this.btnAgregarActividad = new System.Windows.Forms.Button();
            this.dtpFechaActividad = new System.Windows.Forms.DateTimePicker();
            this.lblFechaActividad = new System.Windows.Forms.Label();
            this.dgvActividades = new System.Windows.Forms.DataGridView();
            this.Actividad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtpHoraFin = new System.Windows.Forms.DateTimePicker();
            this.lblHoraFin = new System.Windows.Forms.Label();
            this.dtpHoraInicio = new System.Windows.Forms.DateTimePicker();
            this.lblHoraInicio = new System.Windows.Forms.Label();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.ofdFoto = new System.Windows.Forms.OpenFileDialog();
            this.tsMenu.SuspendLayout();
            this.tbGestionEventos.SuspendLayout();
            this.tpDatosGenerales.SuspendLayout();
            this.gbDocentesResponsables.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.tbActividades.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).BeginInit();
            this.SuspendLayout();
            // 
            // tsMenu
            // 
            this.tsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNuevo,
            this.btnGuardar,
            this.btnBuscar,
            this.btnCancelar});
            this.tsMenu.Location = new System.Drawing.Point(0, 0);
            this.tsMenu.Name = "tsMenu";
            this.tsMenu.Size = new System.Drawing.Size(833, 25);
            this.tsMenu.TabIndex = 0;
            this.tsMenu.Text = "toolStrip1";
            // 
            // btnNuevo
            // 
            this.btnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.Image")));
            this.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(62, 22);
            this.btnNuevo.Text = "&Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.Image")));
            this.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(69, 22);
            this.btnGuardar.Text = "&Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Image = ((System.Drawing.Image)(resources.GetObject("btnBuscar.Image")));
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(62, 22);
            this.btnBuscar.Text = "&Buscar";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 22);
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblGestionEventos
            // 
            this.lblGestionEventos.AutoSize = true;
            this.lblGestionEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGestionEventos.Location = new System.Drawing.Point(12, 32);
            this.lblGestionEventos.Name = "lblGestionEventos";
            this.lblGestionEventos.Size = new System.Drawing.Size(187, 16);
            this.lblGestionEventos.TabIndex = 1;
            this.lblGestionEventos.Text = "Gestión de Eventos PUCP";
            // 
            // tbGestionEventos
            // 
            this.tbGestionEventos.Controls.Add(this.tpDatosGenerales);
            this.tbGestionEventos.Controls.Add(this.tbActividades);
            this.tbGestionEventos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGestionEventos.Location = new System.Drawing.Point(15, 59);
            this.tbGestionEventos.Name = "tbGestionEventos";
            this.tbGestionEventos.SelectedIndex = 0;
            this.tbGestionEventos.Size = new System.Drawing.Size(806, 455);
            this.tbGestionEventos.TabIndex = 2;
            // 
            // tpDatosGenerales
            // 
            this.tpDatosGenerales.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatosGenerales.Controls.Add(this.btnSubirFoto);
            this.tpDatosGenerales.Controls.Add(this.gbDocentesResponsables);
            this.tpDatosGenerales.Controls.Add(this.txtCosto);
            this.tpDatosGenerales.Controls.Add(this.lblCosto);
            this.tpDatosGenerales.Controls.Add(this.cboEspecialidad);
            this.tpDatosGenerales.Controls.Add(this.lblEspecialidad);
            this.tpDatosGenerales.Controls.Add(this.lblFechaFin);
            this.tpDatosGenerales.Controls.Add(this.lblFechaInicio);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaFin);
            this.tpDatosGenerales.Controls.Add(this.dtpFechaInicio);
            this.tpDatosGenerales.Controls.Add(this.txtNombreEvento);
            this.tpDatosGenerales.Controls.Add(this.lblNombreEvento);
            this.tpDatosGenerales.Controls.Add(this.txtIDEvento);
            this.tpDatosGenerales.Controls.Add(this.lblIDEvento);
            this.tpDatosGenerales.Controls.Add(this.pbFoto);
            this.tpDatosGenerales.Location = new System.Drawing.Point(4, 22);
            this.tpDatosGenerales.Name = "tpDatosGenerales";
            this.tpDatosGenerales.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatosGenerales.Size = new System.Drawing.Size(798, 429);
            this.tpDatosGenerales.TabIndex = 0;
            this.tpDatosGenerales.Text = "Datos Generales del Evento";
            // 
            // btnSubirFoto
            // 
            this.btnSubirFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubirFoto.Location = new System.Drawing.Point(228, 133);
            this.btnSubirFoto.Name = "btnSubirFoto";
            this.btnSubirFoto.Size = new System.Drawing.Size(44, 23);
            this.btnSubirFoto.TabIndex = 14;
            this.btnSubirFoto.Text = "...";
            this.btnSubirFoto.UseVisualStyleBackColor = true;
            this.btnSubirFoto.Click += new System.EventHandler(this.btnSubirFoto_Click);
            // 
            // gbDocentesResponsables
            // 
            this.gbDocentesResponsables.Controls.Add(this.btnEliminarDocente);
            this.gbDocentesResponsables.Controls.Add(this.btnAgregarDocente);
            this.gbDocentesResponsables.Controls.Add(this.btnBuscarDocente);
            this.gbDocentesResponsables.Controls.Add(this.txtNombreDocente);
            this.gbDocentesResponsables.Controls.Add(this.lblNombreDocente);
            this.gbDocentesResponsables.Controls.Add(this.txtCodigoPUCPDocente);
            this.gbDocentesResponsables.Controls.Add(this.lblCodigoPUCPDocente);
            this.gbDocentesResponsables.Controls.Add(this.dgvDocentes);
            this.gbDocentesResponsables.Location = new System.Drawing.Point(13, 225);
            this.gbDocentesResponsables.Name = "gbDocentesResponsables";
            this.gbDocentesResponsables.Size = new System.Drawing.Size(779, 198);
            this.gbDocentesResponsables.TabIndex = 13;
            this.gbDocentesResponsables.TabStop = false;
            this.gbDocentesResponsables.Text = "Profesores Responsables";
            // 
            // btnEliminarDocente
            // 
            this.btnEliminarDocente.Location = new System.Drawing.Point(733, 45);
            this.btnEliminarDocente.Name = "btnEliminarDocente";
            this.btnEliminarDocente.Size = new System.Drawing.Size(40, 23);
            this.btnEliminarDocente.TabIndex = 7;
            this.btnEliminarDocente.Text = "-";
            this.btnEliminarDocente.UseVisualStyleBackColor = true;
            this.btnEliminarDocente.Click += new System.EventHandler(this.btnEliminarDocente_Click);
            // 
            // btnAgregarDocente
            // 
            this.btnAgregarDocente.Location = new System.Drawing.Point(692, 45);
            this.btnAgregarDocente.Name = "btnAgregarDocente";
            this.btnAgregarDocente.Size = new System.Drawing.Size(40, 23);
            this.btnAgregarDocente.TabIndex = 6;
            this.btnAgregarDocente.Text = "+";
            this.btnAgregarDocente.UseVisualStyleBackColor = true;
            this.btnAgregarDocente.Click += new System.EventHandler(this.btnAgregarDocente_Click);
            // 
            // btnBuscarDocente
            // 
            this.btnBuscarDocente.Location = new System.Drawing.Point(234, 21);
            this.btnBuscarDocente.Name = "btnBuscarDocente";
            this.btnBuscarDocente.Size = new System.Drawing.Size(45, 23);
            this.btnBuscarDocente.TabIndex = 5;
            this.btnBuscarDocente.Text = "...";
            this.btnBuscarDocente.UseVisualStyleBackColor = true;
            this.btnBuscarDocente.Click += new System.EventHandler(this.btnBuscarDocente_Click);
            // 
            // txtNombreDocente
            // 
            this.txtNombreDocente.Location = new System.Drawing.Point(122, 47);
            this.txtNombreDocente.Name = "txtNombreDocente";
            this.txtNombreDocente.ReadOnly = true;
            this.txtNombreDocente.Size = new System.Drawing.Size(443, 20);
            this.txtNombreDocente.TabIndex = 4;
            // 
            // lblNombreDocente
            // 
            this.lblNombreDocente.AutoSize = true;
            this.lblNombreDocente.Location = new System.Drawing.Point(6, 51);
            this.lblNombreDocente.Name = "lblNombreDocente";
            this.lblNombreDocente.Size = new System.Drawing.Size(110, 13);
            this.lblNombreDocente.TabIndex = 3;
            this.lblNombreDocente.Text = "Nombre Completo:";
            // 
            // txtCodigoPUCPDocente
            // 
            this.txtCodigoPUCPDocente.Location = new System.Drawing.Point(99, 23);
            this.txtCodigoPUCPDocente.Name = "txtCodigoPUCPDocente";
            this.txtCodigoPUCPDocente.ReadOnly = true;
            this.txtCodigoPUCPDocente.Size = new System.Drawing.Size(129, 20);
            this.txtCodigoPUCPDocente.TabIndex = 2;
            // 
            // lblCodigoPUCPDocente
            // 
            this.lblCodigoPUCPDocente.AutoSize = true;
            this.lblCodigoPUCPDocente.Location = new System.Drawing.Point(6, 26);
            this.lblCodigoPUCPDocente.Name = "lblCodigoPUCPDocente";
            this.lblCodigoPUCPDocente.Size = new System.Drawing.Size(87, 13);
            this.lblCodigoPUCPDocente.TabIndex = 1;
            this.lblCodigoPUCPDocente.Text = "Código PUCP:";
            // 
            // dgvDocentes
            // 
            this.dgvDocentes.AllowUserToAddRows = false;
            this.dgvDocentes.AllowUserToDeleteRows = false;
            this.dgvDocentes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDocentes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodigoPUCP,
            this.NombreCompleto,
            this.Especialidad});
            this.dgvDocentes.Location = new System.Drawing.Point(6, 75);
            this.dgvDocentes.Name = "dgvDocentes";
            this.dgvDocentes.ReadOnly = true;
            this.dgvDocentes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDocentes.Size = new System.Drawing.Size(767, 117);
            this.dgvDocentes.TabIndex = 0;
            // 
            // CodigoPUCP
            // 
            this.CodigoPUCP.HeaderText = "Código PUCP";
            this.CodigoPUCP.Name = "CodigoPUCP";
            this.CodigoPUCP.ReadOnly = true;
            this.CodigoPUCP.Width = 120;
            // 
            // NombreCompleto
            // 
            this.NombreCompleto.HeaderText = "Nombre Completo";
            this.NombreCompleto.Name = "NombreCompleto";
            this.NombreCompleto.ReadOnly = true;
            this.NombreCompleto.Width = 300;
            // 
            // Especialidad
            // 
            this.Especialidad.HeaderText = "Especialidad";
            this.Especialidad.Name = "Especialidad";
            this.Especialidad.ReadOnly = true;
            this.Especialidad.Width = 280;
            // 
            // txtCosto
            // 
            this.txtCosto.Location = new System.Drawing.Point(124, 196);
            this.txtCosto.Name = "txtCosto";
            this.txtCosto.Size = new System.Drawing.Size(148, 20);
            this.txtCosto.TabIndex = 12;
            // 
            // lblCosto
            // 
            this.lblCosto.AutoSize = true;
            this.lblCosto.Location = new System.Drawing.Point(10, 199);
            this.lblCosto.Name = "lblCosto";
            this.lblCosto.Size = new System.Drawing.Size(108, 13);
            this.lblCosto.TabIndex = 11;
            this.lblCosto.Text = "Costo del Evento:";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Location = new System.Drawing.Point(233, 168);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(559, 21);
            this.cboEspecialidad.TabIndex = 10;
            // 
            // lblEspecialidad
            // 
            this.lblEspecialidad.AutoSize = true;
            this.lblEspecialidad.Location = new System.Drawing.Point(10, 171);
            this.lblEspecialidad.Name = "lblEspecialidad";
            this.lblEspecialidad.Size = new System.Drawing.Size(217, 13);
            this.lblEspecialidad.TabIndex = 9;
            this.lblEspecialidad.Text = "Especialidad que organiza el evento:";
            // 
            // lblFechaFin
            // 
            this.lblFechaFin.AutoSize = true;
            this.lblFechaFin.Location = new System.Drawing.Point(286, 121);
            this.lblFechaFin.Name = "lblFechaFin";
            this.lblFechaFin.Size = new System.Drawing.Size(67, 13);
            this.lblFechaFin.TabIndex = 8;
            this.lblFechaFin.Text = "Fecha Fin:";
            // 
            // lblFechaInicio
            // 
            this.lblFechaInicio.AutoSize = true;
            this.lblFechaInicio.Location = new System.Drawing.Point(286, 79);
            this.lblFechaInicio.Name = "lblFechaInicio";
            this.lblFechaInicio.Size = new System.Drawing.Size(99, 13);
            this.lblFechaInicio.TabIndex = 7;
            this.lblFechaInicio.Text = "Fecha de Inicio:";
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(288, 136);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(504, 20);
            this.dtpFechaFin.TabIndex = 6;
            // 
            // dtpFechaInicio
            // 
            this.dtpFechaInicio.Location = new System.Drawing.Point(288, 94);
            this.dtpFechaInicio.Name = "dtpFechaInicio";
            this.dtpFechaInicio.Size = new System.Drawing.Size(504, 20);
            this.dtpFechaInicio.TabIndex = 5;
            // 
            // txtNombreEvento
            // 
            this.txtNombreEvento.Location = new System.Drawing.Point(288, 53);
            this.txtNombreEvento.Name = "txtNombreEvento";
            this.txtNombreEvento.Size = new System.Drawing.Size(504, 20);
            this.txtNombreEvento.TabIndex = 4;
            // 
            // lblNombreEvento
            // 
            this.lblNombreEvento.AutoSize = true;
            this.lblNombreEvento.Location = new System.Drawing.Point(285, 38);
            this.lblNombreEvento.Name = "lblNombreEvento";
            this.lblNombreEvento.Size = new System.Drawing.Size(119, 13);
            this.lblNombreEvento.TabIndex = 3;
            this.lblNombreEvento.Text = "Nombre del Evento:";
            // 
            // txtIDEvento
            // 
            this.txtIDEvento.Location = new System.Drawing.Point(380, 10);
            this.txtIDEvento.Name = "txtIDEvento";
            this.txtIDEvento.ReadOnly = true;
            this.txtIDEvento.Size = new System.Drawing.Size(59, 20);
            this.txtIDEvento.TabIndex = 2;
            this.txtIDEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblIDEvento
            // 
            this.lblIDEvento.AutoSize = true;
            this.lblIDEvento.Location = new System.Drawing.Point(285, 13);
            this.lblIDEvento.Name = "lblIDEvento";
            this.lblIDEvento.Size = new System.Drawing.Size(89, 13);
            this.lblIDEvento.TabIndex = 1;
            this.lblIDEvento.Text = "ID del Evento:";
            // 
            // pbFoto
            // 
            this.pbFoto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbFoto.Location = new System.Drawing.Point(13, 13);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(259, 143);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 0;
            this.pbFoto.TabStop = false;
            // 
            // tbActividades
            // 
            this.tbActividades.BackColor = System.Drawing.SystemColors.Control;
            this.tbActividades.Controls.Add(this.btnEliminarActividad);
            this.tbActividades.Controls.Add(this.btnAgregarActividad);
            this.tbActividades.Controls.Add(this.dtpFechaActividad);
            this.tbActividades.Controls.Add(this.lblFechaActividad);
            this.tbActividades.Controls.Add(this.dgvActividades);
            this.tbActividades.Controls.Add(this.dtpHoraFin);
            this.tbActividades.Controls.Add(this.lblHoraFin);
            this.tbActividades.Controls.Add(this.dtpHoraInicio);
            this.tbActividades.Controls.Add(this.lblHoraInicio);
            this.tbActividades.Controls.Add(this.txtNombreActividad);
            this.tbActividades.Controls.Add(this.lblNombreActividad);
            this.tbActividades.Location = new System.Drawing.Point(4, 22);
            this.tbActividades.Name = "tbActividades";
            this.tbActividades.Padding = new System.Windows.Forms.Padding(3);
            this.tbActividades.Size = new System.Drawing.Size(798, 429);
            this.tbActividades.TabIndex = 1;
            this.tbActividades.Text = "Actividades del Evento";
            // 
            // btnEliminarActividad
            // 
            this.btnEliminarActividad.Location = new System.Drawing.Point(740, 54);
            this.btnEliminarActividad.Name = "btnEliminarActividad";
            this.btnEliminarActividad.Size = new System.Drawing.Size(40, 23);
            this.btnEliminarActividad.TabIndex = 10;
            this.btnEliminarActividad.Text = "-";
            this.btnEliminarActividad.UseVisualStyleBackColor = true;
            this.btnEliminarActividad.Click += new System.EventHandler(this.btnEliminarActividad_Click);
            // 
            // btnAgregarActividad
            // 
            this.btnAgregarActividad.Location = new System.Drawing.Point(699, 54);
            this.btnAgregarActividad.Name = "btnAgregarActividad";
            this.btnAgregarActividad.Size = new System.Drawing.Size(40, 23);
            this.btnAgregarActividad.TabIndex = 9;
            this.btnAgregarActividad.Text = "+";
            this.btnAgregarActividad.UseVisualStyleBackColor = true;
            this.btnAgregarActividad.Click += new System.EventHandler(this.btnAgregarActividad_Click);
            // 
            // dtpFechaActividad
            // 
            this.dtpFechaActividad.Location = new System.Drawing.Point(93, 32);
            this.dtpFechaActividad.Name = "dtpFechaActividad";
            this.dtpFechaActividad.Size = new System.Drawing.Size(371, 20);
            this.dtpFechaActividad.TabIndex = 8;
            // 
            // lblFechaActividad
            // 
            this.lblFechaActividad.AutoSize = true;
            this.lblFechaActividad.Location = new System.Drawing.Point(15, 36);
            this.lblFechaActividad.Name = "lblFechaActividad";
            this.lblFechaActividad.Size = new System.Drawing.Size(46, 13);
            this.lblFechaActividad.TabIndex = 7;
            this.lblFechaActividad.Text = "Fecha:";
            // 
            // dgvActividades
            // 
            this.dgvActividades.AllowUserToAddRows = false;
            this.dgvActividades.AllowUserToDeleteRows = false;
            this.dgvActividades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActividades.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Actividad,
            this.Fecha,
            this.HoraInicio,
            this.HoraFin});
            this.dgvActividades.Location = new System.Drawing.Point(15, 90);
            this.dgvActividades.Name = "dgvActividades";
            this.dgvActividades.ReadOnly = true;
            this.dgvActividades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvActividades.Size = new System.Drawing.Size(765, 326);
            this.dgvActividades.TabIndex = 6;
            this.dgvActividades.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvActividades_CellFormatting);
            // 
            // Actividad
            // 
            this.Actividad.HeaderText = "Actividad";
            this.Actividad.Name = "Actividad";
            this.Actividad.ReadOnly = true;
            this.Actividad.Width = 350;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 150;
            // 
            // HoraInicio
            // 
            this.HoraInicio.HeaderText = "Hora Inicio";
            this.HoraInicio.Name = "HoraInicio";
            this.HoraInicio.ReadOnly = true;
            // 
            // HoraFin
            // 
            this.HoraFin.HeaderText = "Hora Fin";
            this.HoraFin.Name = "HoraFin";
            this.HoraFin.ReadOnly = true;
            // 
            // dtpHoraFin
            // 
            this.dtpHoraFin.CustomFormat = "HH:mm";
            this.dtpHoraFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraFin.Location = new System.Drawing.Point(302, 55);
            this.dtpHoraFin.Name = "dtpHoraFin";
            this.dtpHoraFin.ShowUpDown = true;
            this.dtpHoraFin.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraFin.TabIndex = 5;
            // 
            // lblHoraFin
            // 
            this.lblHoraFin.AutoSize = true;
            this.lblHoraFin.Location = new System.Drawing.Point(237, 59);
            this.lblHoraFin.Name = "lblHoraFin";
            this.lblHoraFin.Size = new System.Drawing.Size(59, 13);
            this.lblHoraFin.TabIndex = 4;
            this.lblHoraFin.Text = "Hora Fin:";
            // 
            // dtpHoraInicio
            // 
            this.dtpHoraInicio.CustomFormat = "HH:mm";
            this.dtpHoraInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpHoraInicio.Location = new System.Drawing.Point(93, 55);
            this.dtpHoraInicio.Name = "dtpHoraInicio";
            this.dtpHoraInicio.ShowUpDown = true;
            this.dtpHoraInicio.Size = new System.Drawing.Size(89, 20);
            this.dtpHoraInicio.TabIndex = 3;
            // 
            // lblHoraInicio
            // 
            this.lblHoraInicio.AutoSize = true;
            this.lblHoraInicio.Location = new System.Drawing.Point(14, 59);
            this.lblHoraInicio.Name = "lblHoraInicio";
            this.lblHoraInicio.Size = new System.Drawing.Size(73, 13);
            this.lblHoraInicio.TabIndex = 2;
            this.lblHoraInicio.Text = "Hora Inicio:";
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(161, 9);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(511, 20);
            this.txtNombreActividad.TabIndex = 1;
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(12, 12);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(143, 13);
            this.lblNombreActividad.TabIndex = 0;
            this.lblNombreActividad.Text = "Nombre de la Actividad:";
            // 
            // ofdFoto
            // 
            this.ofdFoto.FileName = "openFileDialog1";
            // 
            // frmGestionEventos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 526);
            this.Controls.Add(this.tbGestionEventos);
            this.Controls.Add(this.lblGestionEventos);
            this.Controls.Add(this.tsMenu);
            this.Name = "frmGestionEventos";
            this.Text = "Formulario de Gestión de Eventos";
            this.tsMenu.ResumeLayout(false);
            this.tsMenu.PerformLayout();
            this.tbGestionEventos.ResumeLayout(false);
            this.tpDatosGenerales.ResumeLayout(false);
            this.tpDatosGenerales.PerformLayout();
            this.gbDocentesResponsables.ResumeLayout(false);
            this.gbDocentesResponsables.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDocentes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.tbActividades.ResumeLayout(false);
            this.tbActividades.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActividades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip tsMenu;
        private System.Windows.Forms.ToolStripButton btnNuevo;
        private System.Windows.Forms.ToolStripButton btnGuardar;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.Label lblGestionEventos;
        private System.Windows.Forms.TabControl tbGestionEventos;
        private System.Windows.Forms.TabPage tpDatosGenerales;
        private System.Windows.Forms.Label lblFechaFin;
        private System.Windows.Forms.Label lblFechaInicio;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.TextBox txtNombreEvento;
        private System.Windows.Forms.Label lblNombreEvento;
        private System.Windows.Forms.TextBox txtIDEvento;
        private System.Windows.Forms.Label lblIDEvento;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.TabPage tbActividades;
        private System.Windows.Forms.GroupBox gbDocentesResponsables;
        private System.Windows.Forms.TextBox txtCodigoPUCPDocente;
        private System.Windows.Forms.Label lblCodigoPUCPDocente;
        private System.Windows.Forms.DataGridView dgvDocentes;
        private System.Windows.Forms.TextBox txtCosto;
        private System.Windows.Forms.Label lblCosto;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.Label lblEspecialidad;
        private System.Windows.Forms.Button btnBuscarDocente;
        private System.Windows.Forms.TextBox txtNombreDocente;
        private System.Windows.Forms.Label lblNombreDocente;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.Button btnEliminarDocente;
        private System.Windows.Forms.Button btnAgregarDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodigoPUCP;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCompleto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidad;
        private System.Windows.Forms.TextBox txtNombreActividad;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.Button btnEliminarActividad;
        private System.Windows.Forms.Button btnAgregarActividad;
        private System.Windows.Forms.DateTimePicker dtpFechaActividad;
        private System.Windows.Forms.Label lblFechaActividad;
        private System.Windows.Forms.DataGridView dgvActividades;
        private System.Windows.Forms.DataGridViewTextBoxColumn Actividad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn HoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraFin;
        private System.Windows.Forms.Label lblHoraFin;
        private System.Windows.Forms.DateTimePicker dtpHoraInicio;
        private System.Windows.Forms.Label lblHoraInicio;
        private System.Windows.Forms.Button btnSubirFoto;
        private System.Windows.Forms.OpenFileDialog ofdFoto;
    }
}

