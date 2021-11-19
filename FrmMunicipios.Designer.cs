
namespace Cliente_API_REST
{
    partial class FrmMunicipios
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
            this.DGVMunicipios = new System.Windows.Forms.DataGridView();
            this.C_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.C_Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMunicipios)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVMunicipios
            // 
            this.DGVMunicipios.AllowUserToAddRows = false;
            this.DGVMunicipios.AllowUserToDeleteRows = false;
            this.DGVMunicipios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVMunicipios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMunicipios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C_ID,
            this.C_Nombre});
            this.DGVMunicipios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVMunicipios.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DGVMunicipios.Location = new System.Drawing.Point(0, 0);
            this.DGVMunicipios.MultiSelect = false;
            this.DGVMunicipios.Name = "DGVMunicipios";
            this.DGVMunicipios.ReadOnly = true;
            this.DGVMunicipios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVMunicipios.ShowEditingIcon = false;
            this.DGVMunicipios.Size = new System.Drawing.Size(484, 461);
            this.DGVMunicipios.TabIndex = 0;
            this.DGVMunicipios.TabStop = false;
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
            this.C_Nombre.FillWeight = 111.9289F;
            this.C_Nombre.HeaderText = "Nombre";
            this.C_Nombre.Name = "C_Nombre";
            this.C_Nombre.ReadOnly = true;
            // 
            // FrmMunicipios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.DGVMunicipios);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMunicipios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Municipios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmTipos_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.DGVMunicipios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVMunicipios;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn C_Nombre;
    }
}