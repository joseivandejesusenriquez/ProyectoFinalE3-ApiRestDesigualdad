
namespace Cliente_API_REST
{
    partial class FrmCapturaTipos
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
            this.Txb_Nombre = new System.Windows.Forms.TextBox();
            this.L_Nombre = new System.Windows.Forms.Label();
            this.L_Descripcion = new System.Windows.Forms.Label();
            this.RTB_Descripcion = new System.Windows.Forms.RichTextBox();
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
            this.Btn_Accion.Location = new System.Drawing.Point(12, 399);
            this.Btn_Accion.Name = "Btn_Accion";
            this.Btn_Accion.Size = new System.Drawing.Size(460, 50);
            this.Btn_Accion.TabIndex = 4;
            this.Btn_Accion.UseVisualStyleBackColor = false;
            this.Btn_Accion.Click += new System.EventHandler(this.Btn_Accion_Click);
            // 
            // Txb_Nombre
            // 
            this.Txb_Nombre.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Txb_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Txb_Nombre.Location = new System.Drawing.Point(12, 42);
            this.Txb_Nombre.Name = "Txb_Nombre";
            this.Txb_Nombre.Size = new System.Drawing.Size(460, 35);
            this.Txb_Nombre.TabIndex = 1;
            // 
            // L_Nombre
            // 
            this.L_Nombre.AutoSize = true;
            this.L_Nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.L_Nombre.Location = new System.Drawing.Point(12, 10);
            this.L_Nombre.Name = "L_Nombre";
            this.L_Nombre.Size = new System.Drawing.Size(107, 29);
            this.L_Nombre.TabIndex = 0;
            this.L_Nombre.Text = "Nombre:";
            // 
            // L_Descripcion
            // 
            this.L_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.L_Descripcion.AutoSize = true;
            this.L_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.L_Descripcion.Location = new System.Drawing.Point(12, 120);
            this.L_Descripcion.Name = "L_Descripcion";
            this.L_Descripcion.Size = new System.Drawing.Size(147, 29);
            this.L_Descripcion.TabIndex = 2;
            this.L_Descripcion.Text = "Descripción:";
            // 
            // RTB_Descripcion
            // 
            this.RTB_Descripcion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RTB_Descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.RTB_Descripcion.Location = new System.Drawing.Point(12, 152);
            this.RTB_Descripcion.Name = "RTB_Descripcion";
            this.RTB_Descripcion.Size = new System.Drawing.Size(460, 241);
            this.RTB_Descripcion.TabIndex = 3;
            this.RTB_Descripcion.Text = "";
            // 
            // FrmCapturaTipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.RTB_Descripcion);
            this.Controls.Add(this.L_Descripcion);
            this.Controls.Add(this.L_Nombre);
            this.Controls.Add(this.Txb_Nombre);
            this.Controls.Add(this.Btn_Accion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCapturaTipos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Btn_Accion;
        private System.Windows.Forms.TextBox Txb_Nombre;
        private System.Windows.Forms.Label L_Nombre;
        private System.Windows.Forms.Label L_Descripcion;
        private System.Windows.Forms.RichTextBox RTB_Descripcion;
    }
}