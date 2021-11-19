
namespace Cliente_API_REST
{
    partial class FrmCapturaEstadistica
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
            this.Btn_Accion = new System.Windows.Forms.Button();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Municipio = new System.Windows.Forms.Label();
            this.CBTipos = new System.Windows.Forms.ComboBox();
            this.CBMunicipios = new System.Windows.Forms.ComboBox();
            this.L_Porcentaje = new System.Windows.Forms.Label();
            this.NUDPorcentaje = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NUDPorcentaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Btn_Accion
            // 
            this.Btn_Accion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Accion.BackColor = System.Drawing.Color.Teal;
            this.Btn_Accion.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Btn_Accion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Accion.ForeColor = System.Drawing.Color.White;
            this.Btn_Accion.Location = new System.Drawing.Point(12, 299);
            this.Btn_Accion.Name = "Btn_Accion";
            this.Btn_Accion.Size = new System.Drawing.Size(360, 50);
            this.Btn_Accion.TabIndex = 6;
            this.Btn_Accion.UseVisualStyleBackColor = false;
            this.Btn_Accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.L_Nombre.Location = new System.Drawing.Point(12, 10);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(242, 29);
            this.L_Nombre.TabIndex = 0;
            this.L_Nombre.Text = "Tipo de desigualdad:";
            // 
            // L_Municipio
            // 
            this.L_Municipio.AutoSize = true;
            this.L_Municipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.L_Municipio.Location = new System.Drawing.Point(12, 100);
            this.L_Municipio.Name = "L_Municipio";
            this.L_Municipio.Size = new System.Drawing.Size(123, 29);
            this.L_Municipio.TabIndex = 2;
            this.L_Municipio.Text = "Municipio:";
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
            this.CBTipos.Location = new System.Drawing.Point(12, 42);
            this.CBTipos.MaxDropDownItems = 10;
            this.CBTipos.Name = "CBTipos";
            this.CBTipos.Size = new System.Drawing.Size(360, 37);
            this.CBTipos.TabIndex = 1;
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
            this.CBMunicipios.Location = new System.Drawing.Point(12, 132);
            this.CBMunicipios.MaxDropDownItems = 10;
            this.CBMunicipios.Name = "CBMunicipios";
            this.CBMunicipios.Size = new System.Drawing.Size(360, 37);
            this.CBMunicipios.TabIndex = 3;
            // 
            // L_Porcentaje
            // 
            this.L_Porcentaje.AutoSize = true;
            this.L_Porcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.L_Porcentaje.Location = new System.Drawing.Point(12, 190);
            this.L_Porcentaje.Name = "L_Porcentaje";
            this.L_Porcentaje.Size = new System.Drawing.Size(135, 29);
            this.L_Porcentaje.TabIndex = 4;
            this.L_Porcentaje.Text = "Porcentaje:";
            // 
            // NUDPorcentaje
            // 
            this.NUDPorcentaje.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NUDPorcentaje.DecimalPlaces = 2;
            this.NUDPorcentaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.NUDPorcentaje.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.NUDPorcentaje.Location = new System.Drawing.Point(12, 222);
            this.NUDPorcentaje.Name = "NUDPorcentaje";
            this.NUDPorcentaje.Size = new System.Drawing.Size(360, 35);
            this.NUDPorcentaje.TabIndex = 5;
            this.NUDPorcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FrmCapturaEstadistica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.NUDPorcentaje);
            this.Controls.Add(this.L_Porcentaje);
            this.Controls.Add(this.CBMunicipios);
            this.Controls.Add(this.CBTipos);
            this.Controls.Add(this.L_Municipio);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.Btn_Accion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCapturaEstadistica";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.NUDPorcentaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Accion;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Municipio;
        private System.Windows.Forms.ComboBox CBTipos;
        private System.Windows.Forms.ComboBox CBMunicipios;
        private System.Windows.Forms.Label L_Porcentaje;
        private System.Windows.Forms.NumericUpDown NUDPorcentaje;
    }
}