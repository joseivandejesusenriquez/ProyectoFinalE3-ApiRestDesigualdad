using System;
using System.Windows.Forms;
using Cliente_API_REST.Models;
using System.Collections.Generic;

namespace Cliente_API_REST
{
    public partial class FrmConsejos : Form
    {
        private readonly ServiceClient Client = new ServiceClient();
        private string[,] TiposCargados;
        public FrmConsejos()
        {
            InitializeComponent();
            LoadTipos();
        }

        private void CBTipos_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadConsejos(Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]));
        }

        private async void LoadTipos()
        {
            var response = await Client.Get<Response<List<TiposModel>>>("tipos/listado");
            if (response != null)
            {
                TiposCargados = new string[response.Count, 2];
                int i = 0;
                foreach (var Item in response.Result)
                {
                    CBTipos.Items.Add(Item.Name);
                    TiposCargados[i, 0] = Item.Id.ToString();
                    TiposCargados[i, 1] = Item.Name;
                    i++;
                }

                if (response.Count > 0)
                {
                    CBTipos.SelectedIndex = 0;
                    CBTipos.Enabled = true;
                }
            } else{
                Btn_Eliminar.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadConsejos(int ID_Tipo)
        {
            CBTipos.Enabled = false;
            var datos = new
            {
                tipo = ID_Tipo
            };
            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<List<ConsejosModel>>>(datos_serializados, "consejos/listado");
            
            DGVConsejos.Rows.Clear();
            if (response != null)
            {
                foreach (var Item in response.Result) {
                    DGVConsejos.Rows.Add(Item.Id, Item.Content);
                }
                if (response.Count > 0) {
                    Btn_Eliminar.Enabled = true;
                } else{
                    Btn_Eliminar.Enabled = false;
                }
            } else{
                Btn_Eliminar.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CBTipos.Enabled = true;
        }

        private async void DeleteConsejo(int ID)
        {
            var datos = new
            {
                consejo = ID
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "consejos/eliminar");
            if (response != null) {
                if (response.Result != null && response.Count > 0) {
                    if (response.Result.Value) {
                        MessageBox.Show("Registro Eliminado", "Eliminación Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadConsejos(Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]));
                    } else{
                        MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else{
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmTipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Inicio.Show();
        }

        private void DGVConsejos_SelectionChanged(object sender, EventArgs e)
        {
            if(DGVConsejos.Rows.Count > 0)
            {
                RTBContenido.Text = DGVConsejos.CurrentRow.Cells[1].Value.ToString();
            }
        }

        private void DGVConsejos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea editar el registro seleccionado actualmente?", "¿Editar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmCapturaConsejo Capturar = new FrmCapturaConsejo(Convert.ToInt32(DGVConsejos.CurrentRow.Cells[0].Value.ToString()));
                Capturar.ShowDialog();
                LoadConsejos(Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]));
            }
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmCapturaConsejo Capturar = new FrmCapturaConsejo();
            Capturar.ShowDialog();
            LoadConsejos(Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]));
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                DeleteConsejo(Convert.ToInt32(DGVConsejos.CurrentRow.Cells[0].Value.ToString()));
            }
        }
    }
}
