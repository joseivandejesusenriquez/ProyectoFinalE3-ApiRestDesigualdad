
namespace Cliente_API_REST
{
    partial class FrmConsejos
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DGVConsejos = new System.Windows.Forms.DataGridView();
            this.CBTipos = new System.Windows.Forms.ComboBox();
            this.RTBContenido = new System.Windows.Forms.RichTextBox();
            this.Btn_Eliminar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Consejo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsejos)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVConsejos
            // 
            this.DGVConsejos.AllowUserToAddRows = false;
            this.DGVConsejos.AllowUserToDeleteRows = false;
            this.DGVConsejos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVConsejos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVConsejos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Consejo});
            this.DGVConsejos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVConsejos.Location = new System.Drawing.Point(12, 55);
            this.DGVConsejos.MultiSelect = false;
            this.DGVConsejos.Name = "DGVConsejos";
            this.DGVConsejos.ReadOnly = true;
            this.DGVConsejos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVConsejos.ShowEditingIcon = false;
            this.DGVConsejos.Size = new System.Drawing.Size(460, 150);
            this.DGVConsejos.TabIndex = 0;
            this.DGVConsejos.TabStop = false;
            this.DGVConsejos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVConsejos_CellDoubleClick);
            this.DGVConsejos.SelectionChanged += new System.EventHandler(this.DGVConsejos_SelectionChanged);
            // 
            // CBTipos
            // 
            this.CBTipos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CBTipos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CBTipos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBTipos.Enabled = false;
            this.CBTipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CBTipos.FormattingEnabled = true;
            this.CBTipos.IntegralHeight = false;
            this.CBTipos.Location = new System.Drawing.Point(12, 12);
            this.CBTipos.MaxDropDownItems = 10;
            this.CBTipos.Name = "CBTipos";
            this.CBTipos.Size = new System.Drawing.Size(460, 37);
            this.CBTipos.TabIndex = 0;
            this.CBTipos.SelectedIndexChanged += new System.EventHandler(this.CBTipos_SelectedIndexChanged);
            // 
            // RTBContenido
            // 
            this.RTBContenido.BackColor = System.Drawing.Color.White;
            this.RTBContenido.Location = new System.Drawing.Point(12, 211);
            this.RTBContenido.Name = "RTBContenido";
            this.RTBContenido.ReadOnly = true;
            this.RTBContenido.Size = new System.Drawing.Size(460, 169);
            this.RTBContenido.TabIndex = 2;
            this.RTBContenido.TabStop = false;
            this.RTBContenido.Text = "";
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
            this.Btn_Eliminar.TabIndex = 5;
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
            this.Btn_Nuevo.TabIndex = 4;
            this.Btn_Nuevo.Text = "&Nuevo";
            this.Btn_Nuevo.UseVisualStyleBackColor = false;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // C_ID
            // 
            this.C_ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.C_ID.DefaultCellStyle = dataGridViewCellStyle3;
            this.C_ID.FillWeight = 76.14214F;
            this.C_ID.Frozen = true;
            this.C_ID.HeaderText = "ID";
            this.C_ID.Name = "C_ID";
            this.C_ID.ReadOnly = true;
            this.C_ID.Visible = false;
            this.C_ID.Width = 80;
            // 
            // C_Consejo
            // 
            this.C_Consejo.FillWeight = 111.9289F;
            this.C_Consejo.HeaderText = "Consejo";
            this.C_Consejo.Name = "C_Consejo";
            this.C_Consejo.ReadOnly = true;
            // 
            // FrmConsejos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.Btn_Eliminar);
            this.Controls.Add(this.Btn_Nuevo);
            this.Controls.Add(this.RTBContenido);
            this.Controls.Add(this.CBTipos);
            this.Controls.Add(this.DGVConsejos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmConsejos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consejos";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTipos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVConsejos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVConsejos;
        private System.Windows.Forms.ComboBox CBTipos;
        private System.Windows.Forms.RichTextBox RTBContenido;
        private System.Windows.Forms.Button Btn_Eliminar;
        private System.Windows.Forms.Button Btn_Nuevo;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Consejo;
    }
}