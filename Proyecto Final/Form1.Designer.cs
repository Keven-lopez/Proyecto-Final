namespace Proyecto_Final
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelid = new System.Windows.Forms.Label();
            this.labelSexo = new System.Windows.Forms.Label();
            this.labelRegion = new System.Windows.Forms.Label();
            this.labelRecurso = new System.Windows.Forms.Label();
            this.labelAlcance = new System.Windows.Forms.Label();
            this.labelRol = new System.Windows.Forms.Label();
            this.labelDano = new System.Windows.Forms.Label();
            this.labelAspectos = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxRecurso = new System.Windows.Forms.TextBox();
            this.textBoxAspectos = new System.Windows.Forms.TextBox();
            this.checkedListBoxRol = new System.Windows.Forms.CheckedListBox();
            this.comboBoxAlcance = new System.Windows.Forms.ComboBox();
            this.comboBoxDanio = new System.Windows.Forms.ComboBox();
            this.buttonCrear = new System.Windows.Forms.Button();
            this.comboBoxSexo = new System.Windows.Forms.ComboBox();
            this.labelModo = new System.Windows.Forms.Label();
            this.comboBoxRegion = new System.Windows.Forms.ComboBox();
            this.buttonRegistro = new System.Windows.Forms.Button();
            this.buttonActualizar = new System.Windows.Forms.Button();
            this.buttonActualizarConfirmar = new System.Windows.Forms.Button();
            this.buttonBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(378, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to Summoners Rift\r\n";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Location = new System.Drawing.Point(261, 495);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(955, 222);
            this.dataGridView1.TabIndex = 2;
            // 
            // buttonCargar
            // 
            this.buttonCargar.BackColor = System.Drawing.Color.Transparent;
            this.buttonCargar.BackgroundImage = global::Proyecto_Final.Properties.Resources.League_of_Legends6_4169875939__2_;
            this.buttonCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCargar.FlatAppearance.BorderSize = 0;
            this.buttonCargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCargar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonCargar.Location = new System.Drawing.Point(210, 476);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(151, 41);
            this.buttonCargar.TabIndex = 3;
            this.buttonCargar.Text = "Cargar Tabla";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.buttonProbar_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(128, 288);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(59, 16);
            this.labelNombre.TabIndex = 4;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelid
            // 
            this.labelid.AutoSize = true;
            this.labelid.BackColor = System.Drawing.Color.Transparent;
            this.labelid.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelid.ForeColor = System.Drawing.Color.White;
            this.labelid.Location = new System.Drawing.Point(128, 185);
            this.labelid.Name = "labelid";
            this.labelid.Size = new System.Drawing.Size(23, 16);
            this.labelid.TabIndex = 5;
            this.labelid.Text = "ID:";
            // 
            // labelSexo
            // 
            this.labelSexo.AutoSize = true;
            this.labelSexo.BackColor = System.Drawing.Color.Transparent;
            this.labelSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSexo.ForeColor = System.Drawing.Color.White;
            this.labelSexo.Location = new System.Drawing.Point(128, 381);
            this.labelSexo.Name = "labelSexo";
            this.labelSexo.Size = new System.Drawing.Size(41, 16);
            this.labelSexo.TabIndex = 6;
            this.labelSexo.Text = "Sexo:";
            // 
            // labelRegion
            // 
            this.labelRegion.AutoSize = true;
            this.labelRegion.BackColor = System.Drawing.Color.Transparent;
            this.labelRegion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegion.ForeColor = System.Drawing.Color.White;
            this.labelRegion.Location = new System.Drawing.Point(558, 185);
            this.labelRegion.Name = "labelRegion";
            this.labelRegion.Size = new System.Drawing.Size(57, 16);
            this.labelRegion.TabIndex = 7;
            this.labelRegion.Text = "Region: ";
            // 
            // labelRecurso
            // 
            this.labelRecurso.AutoSize = true;
            this.labelRecurso.BackColor = System.Drawing.Color.Transparent;
            this.labelRecurso.ForeColor = System.Drawing.Color.White;
            this.labelRecurso.Location = new System.Drawing.Point(558, 288);
            this.labelRecurso.Name = "labelRecurso";
            this.labelRecurso.Size = new System.Drawing.Size(64, 16);
            this.labelRecurso.TabIndex = 8;
            this.labelRecurso.Text = "Recurso: ";
            // 
            // labelAlcance
            // 
            this.labelAlcance.AutoSize = true;
            this.labelAlcance.BackColor = System.Drawing.Color.Transparent;
            this.labelAlcance.ForeColor = System.Drawing.Color.White;
            this.labelAlcance.Location = new System.Drawing.Point(558, 381);
            this.labelAlcance.Name = "labelAlcance";
            this.labelAlcance.Size = new System.Drawing.Size(62, 16);
            this.labelAlcance.TabIndex = 9;
            this.labelAlcance.Text = "Alcance: ";
            // 
            // labelRol
            // 
            this.labelRol.AutoSize = true;
            this.labelRol.BackColor = System.Drawing.Color.Transparent;
            this.labelRol.ForeColor = System.Drawing.Color.White;
            this.labelRol.Location = new System.Drawing.Point(988, 185);
            this.labelRol.Name = "labelRol";
            this.labelRol.Size = new System.Drawing.Size(34, 16);
            this.labelRol.TabIndex = 10;
            this.labelRol.Text = "Rol: ";
            // 
            // labelDano
            // 
            this.labelDano.AutoSize = true;
            this.labelDano.BackColor = System.Drawing.Color.Transparent;
            this.labelDano.ForeColor = System.Drawing.Color.White;
            this.labelDano.Location = new System.Drawing.Point(988, 288);
            this.labelDano.Name = "labelDano";
            this.labelDano.Size = new System.Drawing.Size(90, 16);
            this.labelDano.TabIndex = 11;
            this.labelDano.Text = "Tipo de Daño";
            // 
            // labelAspectos
            // 
            this.labelAspectos.AutoSize = true;
            this.labelAspectos.BackColor = System.Drawing.Color.Transparent;
            this.labelAspectos.ForeColor = System.Drawing.Color.White;
            this.labelAspectos.Location = new System.Drawing.Point(988, 381);
            this.labelAspectos.Name = "labelAspectos";
            this.labelAspectos.Size = new System.Drawing.Size(137, 16);
            this.labelAspectos.TabIndex = 12;
            this.labelAspectos.Text = "Numero de Aspectos:";
            // 
            // textBoxID
            // 
            this.textBoxID.AllowDrop = true;
            this.textBoxID.Location = new System.Drawing.Point(261, 182);
            this.textBoxID.Multiline = true;
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(66, 38);
            this.textBoxID.TabIndex = 13;
            this.textBoxID.TextChanged += new System.EventHandler(this.textBoxID_TextChanged);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.AllowDrop = true;
            this.textBoxNombre.Enabled = false;
            this.textBoxNombre.Location = new System.Drawing.Point(261, 285);
            this.textBoxNombre.Multiline = true;
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(226, 38);
            this.textBoxNombre.TabIndex = 14;
            // 
            // textBoxRecurso
            // 
            this.textBoxRecurso.AllowDrop = true;
            this.textBoxRecurso.Enabled = false;
            this.textBoxRecurso.Location = new System.Drawing.Point(691, 288);
            this.textBoxRecurso.Multiline = true;
            this.textBoxRecurso.Name = "textBoxRecurso";
            this.textBoxRecurso.Size = new System.Drawing.Size(145, 38);
            this.textBoxRecurso.TabIndex = 18;
            // 
            // textBoxAspectos
            // 
            this.textBoxAspectos.AllowDrop = true;
            this.textBoxAspectos.Enabled = false;
            this.textBoxAspectos.Location = new System.Drawing.Point(1291, 378);
            this.textBoxAspectos.Multiline = true;
            this.textBoxAspectos.Name = "textBoxAspectos";
            this.textBoxAspectos.Size = new System.Drawing.Size(36, 38);
            this.textBoxAspectos.TabIndex = 21;
            // 
            // checkedListBoxRol
            // 
            this.checkedListBoxRol.FormattingEnabled = true;
            this.checkedListBoxRol.Location = new System.Drawing.Point(1291, 160);
            this.checkedListBoxRol.Name = "checkedListBoxRol";
            this.checkedListBoxRol.Size = new System.Drawing.Size(132, 89);
            this.checkedListBoxRol.TabIndex = 22;
            this.checkedListBoxRol.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxRol_ItemCheck);
            // 
            // comboBoxAlcance
            // 
            this.comboBoxAlcance.Enabled = false;
            this.comboBoxAlcance.FormattingEnabled = true;
            this.comboBoxAlcance.Location = new System.Drawing.Point(691, 381);
            this.comboBoxAlcance.Name = "comboBoxAlcance";
            this.comboBoxAlcance.Size = new System.Drawing.Size(132, 24);
            this.comboBoxAlcance.TabIndex = 23;
            this.comboBoxAlcance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxAlcance_KeyPress);
            // 
            // comboBoxDanio
            // 
            this.comboBoxDanio.Enabled = false;
            this.comboBoxDanio.FormattingEnabled = true;
            this.comboBoxDanio.Location = new System.Drawing.Point(1291, 285);
            this.comboBoxDanio.Name = "comboBoxDanio";
            this.comboBoxDanio.Size = new System.Drawing.Size(132, 24);
            this.comboBoxDanio.TabIndex = 24;
            this.comboBoxDanio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxDanio_KeyPress);
            // 
            // buttonCrear
            // 
            this.buttonCrear.BackColor = System.Drawing.Color.Transparent;
            this.buttonCrear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonCrear.BackgroundImage")));
            this.buttonCrear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCrear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCrear.FlatAppearance.BorderSize = 0;
            this.buttonCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonCrear.Location = new System.Drawing.Point(445, 476);
            this.buttonCrear.Name = "buttonCrear";
            this.buttonCrear.Size = new System.Drawing.Size(151, 41);
            this.buttonCrear.TabIndex = 25;
            this.buttonCrear.Text = "Crear Registro";
            this.buttonCrear.UseVisualStyleBackColor = true;
            this.buttonCrear.Click += new System.EventHandler(this.buttonCrear_Click);
            // 
            // comboBoxSexo
            // 
            this.comboBoxSexo.Enabled = false;
            this.comboBoxSexo.FormattingEnabled = true;
            this.comboBoxSexo.Location = new System.Drawing.Point(261, 381);
            this.comboBoxSexo.Name = "comboBoxSexo";
            this.comboBoxSexo.Size = new System.Drawing.Size(66, 24);
            this.comboBoxSexo.TabIndex = 26;
            this.comboBoxSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxSexo_KeyPress);
            // 
            // labelModo
            // 
            this.labelModo.AutoSize = true;
            this.labelModo.BackColor = System.Drawing.Color.Transparent;
            this.labelModo.ForeColor = System.Drawing.Color.White;
            this.labelModo.Location = new System.Drawing.Point(681, 767);
            this.labelModo.Name = "labelModo";
            this.labelModo.Size = new System.Drawing.Size(114, 16);
            this.labelModo.TabIndex = 27;
            this.labelModo.Text = "Modo sólo lectura";
            // 
            // comboBoxRegion
            // 
            this.comboBoxRegion.Enabled = false;
            this.comboBoxRegion.FormattingEnabled = true;
            this.comboBoxRegion.Location = new System.Drawing.Point(691, 182);
            this.comboBoxRegion.Name = "comboBoxRegion";
            this.comboBoxRegion.Size = new System.Drawing.Size(183, 24);
            this.comboBoxRegion.TabIndex = 29;
            this.comboBoxRegion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxRegion_KeyPress);
            // 
            // buttonRegistro
            // 
            this.buttonRegistro.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegistro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRegistro.BackgroundImage")));
            this.buttonRegistro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonRegistro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegistro.FlatAppearance.BorderSize = 0;
            this.buttonRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegistro.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonRegistro.Location = new System.Drawing.Point(670, 476);
            this.buttonRegistro.Name = "buttonRegistro";
            this.buttonRegistro.Size = new System.Drawing.Size(215, 41);
            this.buttonRegistro.TabIndex = 30;
            this.buttonRegistro.Text = "Buscar Registro Por ID";
            this.buttonRegistro.UseVisualStyleBackColor = true;
            this.buttonRegistro.Click += new System.EventHandler(this.buttonRegistro_Click_1);
            // 
            // buttonActualizar
            // 
            this.buttonActualizar.BackColor = System.Drawing.Color.Transparent;
            this.buttonActualizar.BackgroundImage = global::Proyecto_Final.Properties.Resources.League_of_Legends6_4169875939__2_;
            this.buttonActualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActualizar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizar.FlatAppearance.BorderSize = 0;
            this.buttonActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonActualizar.Location = new System.Drawing.Point(952, 476);
            this.buttonActualizar.Name = "buttonActualizar";
            this.buttonActualizar.Size = new System.Drawing.Size(190, 41);
            this.buttonActualizar.TabIndex = 31;
            this.buttonActualizar.Text = "Actualizar Registro";
            this.buttonActualizar.UseVisualStyleBackColor = true;
            this.buttonActualizar.Click += new System.EventHandler(this.buttonActualizar_Click);
            // 
            // buttonActualizarConfirmar
            // 
            this.buttonActualizarConfirmar.BackColor = System.Drawing.Color.Transparent;
            this.buttonActualizarConfirmar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonActualizarConfirmar.BackgroundImage")));
            this.buttonActualizarConfirmar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonActualizarConfirmar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonActualizarConfirmar.Enabled = false;
            this.buttonActualizarConfirmar.FlatAppearance.BorderSize = 0;
            this.buttonActualizarConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonActualizarConfirmar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonActualizarConfirmar.Location = new System.Drawing.Point(952, 476);
            this.buttonActualizarConfirmar.Name = "buttonActualizarConfirmar";
            this.buttonActualizarConfirmar.Size = new System.Drawing.Size(190, 41);
            this.buttonActualizarConfirmar.TabIndex = 32;
            this.buttonActualizarConfirmar.Text = "Actualizar";
            this.buttonActualizarConfirmar.UseVisualStyleBackColor = true;
            this.buttonActualizarConfirmar.Visible = false;
            this.buttonActualizarConfirmar.Click += new System.EventHandler(this.buttonActualizarConfirmar_Click);
            // 
            // buttonBorrar
            // 
            this.buttonBorrar.BackColor = System.Drawing.Color.Transparent;
            this.buttonBorrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonBorrar.BackgroundImage")));
            this.buttonBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBorrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonBorrar.FlatAppearance.BorderSize = 0;
            this.buttonBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(199)))), ((int)(((byte)(199)))));
            this.buttonBorrar.Location = new System.Drawing.Point(1200, 476);
            this.buttonBorrar.Name = "buttonBorrar";
            this.buttonBorrar.Size = new System.Drawing.Size(151, 41);
            this.buttonBorrar.TabIndex = 33;
            this.buttonBorrar.Text = "Borrar Registro";
            this.buttonBorrar.UseVisualStyleBackColor = true;
            this.buttonBorrar.Click += new System.EventHandler(this.buttonBorrar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Final.Properties.Resources.rift;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.buttonBorrar);
            this.Controls.Add(this.buttonActualizarConfirmar);
            this.Controls.Add(this.buttonActualizar);
            this.Controls.Add(this.buttonRegistro);
            this.Controls.Add(this.comboBoxRegion);
            this.Controls.Add(this.labelModo);
            this.Controls.Add(this.comboBoxSexo);
            this.Controls.Add(this.buttonCrear);
            this.Controls.Add(this.comboBoxDanio);
            this.Controls.Add(this.comboBoxAlcance);
            this.Controls.Add(this.checkedListBoxRol);
            this.Controls.Add(this.textBoxAspectos);
            this.Controls.Add(this.textBoxRecurso);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.labelAspectos);
            this.Controls.Add(this.labelDano);
            this.Controls.Add(this.labelRol);
            this.Controls.Add(this.labelAlcance);
            this.Controls.Add(this.labelRecurso);
            this.Controls.Add(this.labelRegion);
            this.Controls.Add(this.labelSexo);
            this.Controls.Add(this.labelid);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelSexo;
        private System.Windows.Forms.Label labelRegion;
        private System.Windows.Forms.Label labelRecurso;
        private System.Windows.Forms.Label labelAlcance;
        private System.Windows.Forms.Label labelRol;
        private System.Windows.Forms.Label labelDano;
        private System.Windows.Forms.Label labelAspectos;
        private System.Windows.Forms.TextBox textBoxID;
        public System.Windows.Forms.Label labelid;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxRecurso;
        private System.Windows.Forms.TextBox textBoxAspectos;
        private System.Windows.Forms.CheckedListBox checkedListBoxRol;
        private System.Windows.Forms.ComboBox comboBoxAlcance;
        private System.Windows.Forms.ComboBox comboBoxDanio;
        private System.Windows.Forms.Button buttonCrear;
        private System.Windows.Forms.ComboBox comboBoxSexo;
        private System.Windows.Forms.Label labelModo;
        private System.Windows.Forms.ComboBox comboBoxRegion;
        private System.Windows.Forms.Button buttonRegistro;
        private System.Windows.Forms.Button buttonActualizar;
        private System.Windows.Forms.Button buttonActualizarConfirmar;
        private System.Windows.Forms.Button buttonBorrar;
    }
}

