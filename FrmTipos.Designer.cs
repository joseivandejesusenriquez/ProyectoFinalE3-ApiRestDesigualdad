
namespace Cliente_API_REST
{
    partial class FrmTipos
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
            this.DGVTipos = new System.Windows.Forms.DataGridView();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.RTBContenido = new System.Windows.Forms.RichTextBox();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVTipos
            // 
            this.DGVTipos.AllowUserToAddRows = false;
            this.DGVTipos.AllowUserToDeleteRows = false;
            this.DGVTipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVTipos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Nombre,
            this.C_Descripcion});
            this.DGVTipos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVTipos.Location = new System.Drawing.Point(12, 12);
            this.DGVTipos.MultiSelect = false;
            this.DGVTipos.Name = "DGVTipos";
            this.DGVTipos.ReadOnly = true;
            this.DGVTipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVTipos.ShowEditingIcon = false;
            this.DGVTipos.Size = new System.Drawing.Size(460, 150);
            this.DGVTipos.TabIndex = 0;
            this.DGVTipos.TabStop = false;
            this.DGVTipos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVTipos_CellDoubleClick);
            this.DGVTipos.SelectionChanged += new System.EventHandler(this.DGVTipos_SelectionChanged);
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
            // RTBContenido
            // 
            this.RTBContenido.BackColor = System.Drawing.Color.White;
            this.RTBContenido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RTBContenido.Location = new System.Drawing.Point(12, 168);
            this.RTBContenido.Name = "RTBContenido";
            this.RTBContenido.ReadOnly = true;
            this.RTBContenido.Size = new System.Drawing.Size(460, 225);
            this.RTBContenido.TabIndex = 1;
            this.RTBContenido.TabStop = false;
            this.RTBContenido.Text = "";
            // 
            // C_ID
            // 
            this.C_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_ID.FillWeight = 76.14214F;
            this.C_ID.Frozen = true;
            this.C_ID.HeaderText = "ID";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            this.C_ID.Visible = false;
            this.C_ID.Width = 80;
            // 
            // C_Nombre
            // 
            this.C_Nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.C_Nombre.FillWeight = 111.9289F;
            this.C_Nombre.Frozen = true;
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.Name = "C_Nombre";
            this.C_Nombre.ReadOnly = true;
            this.C_Nombre.Width = 150;
            // 
            // C_Descripcion
            // 
            this.C_Descripcion.FillWeight = 111.9289F;
            this.C_Descripcion.HeaderText = "Descripción";
            this.C_Descripcion.Name = "C_Descripcion";
            this.C_Descripcion.ReadOnly = true;
            // 
            // FrmTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RTBContenido);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.DGVTipos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipos de discriminación";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTipos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVTipos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVTipos;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.RichTextBox RTBContenido;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Descripcion;
    }
}