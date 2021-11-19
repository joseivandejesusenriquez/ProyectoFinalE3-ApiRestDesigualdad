using System;
using System.Windows.Forms;
using Cliente_API_REST.Models;
using System.Collections.Generic;


namespace Cliente_API_REST
{
    public partial class FrmEstadisticas : Form
    {
        ServiceClient Client = new ServiceClient();
        string [,] MunicipiosCargados;
        public FrmEstadisticas()
        {
            InitializeComponent();
            LoadMunicipios();
        }

        private void CBMunicipios_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadEstadisticas(Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]));
        }

        private async void LoadMunicipios()
        {
            var response = await Client.Get<Response<List<MunicipiosModel>>>("municipios/listado");
            if (response != null) {
                MunicipiosCargados = new string[response.Count, 2];
                int i = 0;
                foreach (var Item in response.Result) {
                    CBMunicipios.Items.Add(Item.Name);
                    MunicipiosCargados[i, 0] = Item.Id.ToString();
                    MunicipiosCargados[i, 1] = Item.Name;
                    i++;
                }

                if (response.Count > 0) {
                    CBMunicipios.SelectedIndex = 0;
                    CBMunicipios.Enabled = true;
                }
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadEstadisticas(int ID_Municipio)
        {
            CBMunicipios.Enabled = false;
            Btn_Eliminar.Enabled = false;
            var datos = new
            {
                municipio = ID_Municipio
            };
            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<List<EstadisticasModel>>>(datos_serializados, "estadisticas/listado");

            if (response != null)
            {
                DGVEstadisticas.Rows.Clear();
                foreach (var Item in response.Result)
                {
                    DGVEstadisticas.Rows.Add(Item.Id, Item.Type_Name, Item.Percentage);
                }
                if (response.Count > 0)
                {
                    Btn_Eliminar.Enabled = true;
                }
                CBMunicipios.Enabled = true;
            }
            else {
                Btn_Eliminar.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteEstadistica(int ID)
        {
            var datos = new
            {
                estadistica = ID
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "estadisticas/eliminar");
            if (response != null)
            {
                if (response.Result != null && response.Count > 0)
                {
                    if (response.Result.Value)
                    {
                        MessageBox.Show("Registro Eliminado", "Eliminación Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadEstadisticas(Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]));
                    }
                    else
                    {
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmCapturaEstadistica Capturar = new FrmCapturaEstadistica();
            Capturar.ShowDialog();
            LoadEstadisticas(Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]));
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteEstadistica(Convert.ToInt32(DGVEstadisticas.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void DGVEstadisticas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea editar el registro seleccionado actualmente?", "¿Editar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmCapturaEstadistica Capturar = new FrmCapturaEstadistica(Convert.ToInt32(DGVEstadisticas.CurrentRow.Cells[0].Value.ToString()));
                Capturar.ShowDialog();
                LoadEstadisticas(Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]));
            }
        }

        private void FrmEstadisticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Inicio.Show();
        }
    }
}
