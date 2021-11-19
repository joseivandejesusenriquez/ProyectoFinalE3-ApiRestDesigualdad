using System;
using System.Windows.Forms;

namespace Cliente_API_REST
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void Btn_Municipios_Click(object sender, EventArgs e)
        {
            FrmMunicipios Municipios = new FrmMunicipios();
            this.Hide();
            Municipios.Show();
        }

        private void Btn_Tipos_Click(object sender, EventArgs e)
        {
            FrmTipos Tipos = new FrmTipos();
            this.Hide();
            Tipos.Show();
        }

        private void Btn_Consejos_Click(object sender, EventArgs e)
        {
            FrmConsejos Consejos = new FrmConsejos();
            this.Hide();
            Consejos.Show();
        }

        private void Btn_Estadisticas_Click(object sender, EventArgs e)
        {
            FrmEstadisticas Estadisticas = new FrmEstadisticas();
            this.Hide();
            Estadisticas.Show();
        }

        private void FrmInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Inicio.Show();
        }
    }
}
