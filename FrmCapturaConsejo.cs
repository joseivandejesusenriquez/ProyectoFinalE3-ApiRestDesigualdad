using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cliente_API_REST.Models;

namespace Cliente_API_REST
{
    public partial class FrmCapturaConsejo : Form
    {
        private readonly int ID_Consejo;
        private readonly bool Editar_Consejo;
        readonly ServiceClient Client = new ServiceClient();
        string[,] TiposCargados;

        public FrmCapturaConsejo()
        {
            InitializeComponent();
            LoadTipos();
            this.Editar_Consejo = false;
            this.Text = "Nuevo Registro";
            Btn_Accion.Text = "&Guardar";
            Btn_Accion.BackColor = System.Drawing.Color.Green;
        }

        public FrmCapturaConsejo(int ID)
        {
            InitializeComponent();
            this.ID_Consejo = ID;
            CBTipos.Enabled = false; 
            LoadTipos();
            LoadConsejo();
            this.Editar_Consejo = true;
            this.Text = "Cargando Datos";
            Btn_Accion.Text = "&Actualizar";
            Btn_Accion.BackColor = System.Drawing.Color.Teal;
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            Btn_Accion.Enabled = false;
            if(CBTipos.SelectedIndex != -1) {
                if (RTB_Consejo.Text != "")
                {
                    if (this.Editar_Consejo)
                    {
                        ActualizarConsejo();
                    }
                    else
                    {
                        GuardarConsejo();
                    }
                }
                else
                {
                    MessageBox.Show("Inserte todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RTB_Consejo.Focus();
                    Btn_Accion.Enabled = true;
                }

            } else{
                MessageBox.Show("Inserte todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CBTipos.Focus();
                Btn_Accion.Enabled = true;
            }
        }

        private async void LoadTipos()
        {
            var response = await Client.Get<Response<List<TiposModel>>>("tipos/listado");
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
        }

        private async void LoadConsejo()
        {
            var datos = new
            {
                consejo = this.ID_Consejo
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<ConsejosModel>>(datos_serializados, "consejos/obtener");
            if(response != null) {
                int Tipos = TiposCargados.Length / 2;
                for(int i = 0; i < Tipos; i++)
                {
                    if(TiposCargados[i, 0] == response.Result.Type.ToString())
                    {
                        CBTipos.Enabled = true;
                        CBTipos.SelectedIndex = i;
                        break;
                    }
                }
                RTB_Consejo.Text = response.Result.Content;
                this.Text = "Editar datos";
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GuardarConsejo()
        {
            var datos = new
            {
                tipo = Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]),
                consejo = RTB_Consejo.Text
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "consejos/guardar");
            if (response != null) {
                if (response.Result != null && response.Count > 0) {
                    if (response.Result.Value) {
                        if(MessageBox.Show("Registro Guardado\n\n¿Desea Registrar otro?", "Guardado Correcto", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                            Limpiar();
                        } else{
                            this.Close();
                        }
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

        private async void ActualizarConsejo()
        {
            var datos = new
            {
                consejo     = ID_Consejo,
                tipo        = TiposCargados[CBTipos.SelectedIndex, 0],
                contenido   = RTB_Consejo.Text
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "consejos/actualizar");
            if (response != null) {
                if (response.Result != null && response.Count > 0) {
                    if (response.Result.Value) {
                        MessageBox.Show("Registro Actualizado", "Actualización Correcta", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
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

        private void Limpiar()
        {
            CBTipos.SelectedIndex = -1;
            RTB_Consejo.Clear();
            CBTipos.Focus();
            Btn_Accion.Enabled = true;
        }
    }
}
