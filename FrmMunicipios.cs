using System.Windows.Forms;
using Cliente_API_REST.Models;
using System.Collections.Generic;

namespace Cliente_API_REST
{
    public partial class FrmMunicipios : Form
    {
        private readonly ServiceClient Client = new ServiceClient();
        public FrmMunicipios()
        {
            InitializeComponent();
            LoadMunicipios();
        }

        private async void LoadMunicipios()
        {
            var response = await Client.Get<Response<List<MunicipiosModel>>>("municipios/listado");
            if (response != null) {
                foreach (var Item in response.Result) {
                    DGVMunicipios.Rows.Add(Item.Id, Item.Name);
                }
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Inicio.Show();
        }
    }
}
