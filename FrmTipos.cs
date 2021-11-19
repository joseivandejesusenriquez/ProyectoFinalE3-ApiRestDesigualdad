using System;
using System.Windows.Forms;
using Cliente_API_REST.Models;
using System.Collections.Generic;

namespace Cliente_API_REST
{
    public partial class FrmTipos : Form
    {
        private readonly ServiceClient Client = new ServiceClient();
        public FrmTipos()
        {
            InitializeComponent();
            LoadTipos();
        }

        private async void LoadTipos()
        {
            DGVTipos.Rows.Clear();
            var response = await Client.Get<Response<List<TiposModel>>>("tipos/listado");

            if(response != null) {
                foreach (var Item in response.Result) {
                    DGVTipos.Rows.Add(Item.Id, Item.Name, Item.Description);
                }
                if(response.Count > 0) {
                    Btn_Eliminar.Enabled = true;
                } else{
                    Btn_Eliminar.Enabled = false;
                }
            } else{
                Btn_Eliminar.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void DeleteTipo(int ID)
        {
            var datos = new
            {
                tipo = ID
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "tipos/eliminar");
            if (response != null) {
                if (response.Result != null && response.Count > 0) {
                    if (response.Result.Value) {
                        MessageBox.Show("Registro Eliminado", "Eliminación Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadTipos();
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

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmCapturaTipos Capturar = new FrmCapturaTipos();
            Capturar.ShowDialog();
            LoadTipos();
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Eliminar el registro?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                DeleteTipo(Convert.ToInt32(DGVTipos.CurrentRow.Cells[0].Value.ToString()));
            }
        }

        private void DGVTipos_SelectionChanged(object sender, EventArgs e)
        {
            if (DGVTipos.Rows.Count > 0) {
                RTBContenido.Text = DGVTipos.CurrentRow.Cells[2].Value.ToString();
            }
        }

        private void DGVTipos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MessageBox.Show("¿Desea editar el registro seleccionado actualmente?", "¿Editar?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FrmCapturaTipos Capturar = new FrmCapturaTipos(Convert.ToInt32(DGVTipos.CurrentRow.Cells[0].Value.ToString()));
                Capturar.ShowDialog();
                LoadTipos();
            }
        }

        private void FrmTipos_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.Inicio.Show();
        }
    }
}
