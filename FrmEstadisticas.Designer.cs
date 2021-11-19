
namespace Cliente_API_REST
{
    partial class FrmEstadisticas
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
            this.DGVEstadisticas = new System.Windows.Forms.DataGridView();
            this.CBMunicipios = new System.Windows.Forms.ComboBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Discriminacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstadisticas)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVEstadisticas
            // 
            this.DGVEstadisticas.AllowUserToAddRows = false;
            this.DGVEstadisticas.AllowUserToDeleteRows = false;
            this.DGVEstadisticas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVEstadisticas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DGVEstadisticas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVEstadisticas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Discriminacion,
            this.C_Porcentaje});
            this.DGVEstadisticas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVEstadisticas.Location = new System.Drawing.Point(12, 55);
            this.DGVEstadisticas.MultiSelect = false;
            this.DGVEstadisticas.Name = "DGVEstadisticas";
            this.DGVEstadisticas.ReadOnly = true;
            this.DGVEstadisticas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVEstadisticas.ShowEditingIcon = false;
            this.DGVEstadisticas.Size = new System.Drawing.Size(460, 338);
            this.DGVEstadisticas.TabIndex = 1;
            this.DGVEstadisticas.TabStop = false;
            this.DGVEstadisticas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVEstadisticas_CellDoubleClick);
            // 
            // CBMunicipios
            // 
            this.CBMunicipios.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBMunicipios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBMunicipios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBMunicipios.Enabled = false;
            this.CBMunicipios.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBMunicipios.FormattingEnabled = true;
            this.CBMunicipios.IntegralHeight = false;
            this.CBMunicipios.Location = new System.Drawing.Point(12, 12);
            this.CBMunicipios.MaxDropDownItems = 10;
            this.CBMunicipios.Name = "CBMunicipios";
            this.CBMunicipios.Size = new System.Drawing.Size(460, 37);
            this.CBMunicipios.TabIndex = 0;
            this.CBMunicipios.SelectedIndexChanged += new System.EventHandler(this.CBMunicipios_SelectedIndexChanged);
            // 
            // Btn_Eliminar
            // 
            this.Btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Eliminar.BackColor = System.Drawing.Color.Maroon;
            this.Btn_Eliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Eliminar.Enabled = false;
            this.Btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Eliminar.ForeColor = System.Drawing.Color.White;
            this.Btn_Eliminar.Location = new System.Drawing.Point(247, 399);
            this.Btn_Eliminar.Name = "Btn_Eliminar";
            this.Btn_Eliminar.Size = new System.Drawing.Size(225, 50);
            this.Btn_Eliminar.TabIndex = 3;
            this.Btn_Eliminar.Text = "&Borrar";
            this.Btn_Eliminar.UseVisualStyleBackColor = false;
            this.Btn_Eliminar.Click += new System.EventHandler(this.Btn_Eliminar_Click);
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Nuevo.BackColor = System.Drawing.Color.Green;
            this.Btn_Nuevo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Nuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Nuevo.ForeColor = System.Drawing.Color.White;
            this.Btn_Nuevo.Location = new System.Drawing.Point(12, 399);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(225, 50);
            this.Btn_Nuevo.TabIndex = 2;
            this.Btn_Nuevo.Text = "&Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // C_ID
            // 
            this.C_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_ID.DefaultCellStyle = dataGridViewCellStyle1;
            this.C_ID.FillWeight = 76.14214F;
            this.C_ID.Frozen = true;
            this.C_ID.HeaderText = "ID";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            this.C_ID.Visible = false;
            this.C_ID.Width = 80;
            // 
            // C_Discriminacion
            // 
            this.C_Discriminacion.FillWeight = 111.9289F;
            this.C_Discriminacion.HeaderText = "Discriminacion";
            this.C_Discriminacion.Name = "C_Discriminacion";
            this.C_Discriminacion.ReadOnly = true;
            // 
            // C_Porcentaje
            // 
            this.C_Porcentaje.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_Porcentaje.DefaultCellStyle = dataGridViewCellStyle2;
            this.C_Porcentaje.HeaderText = "Porcentaje";
            this.C_Porcentaje.Name = "C_Porcentaje";
            this.C_Porcentaje.ReadOnly = true;
            // 
            // FrmEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.CBMunicipios);
            this.Controls.Add(this.DGVEstadisticas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmEstadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadisticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmEstadisticas_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVEstadisticas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVEstadisticas;
        private System.Windows.Forms.ComboBox CBMunicipios;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Discriminacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Porcentaje;
    }
}