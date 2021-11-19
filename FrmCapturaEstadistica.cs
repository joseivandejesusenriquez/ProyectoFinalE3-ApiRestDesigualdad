using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Cliente_API_REST.Models;

namespace Cliente_API_REST
{
    public partial class FrmCapturaEstadistica : Form
    {
        string[,] TiposCargados;
        string[,] MunicipiosCargados;
        private readonly int ID_Estadistica;
        private readonly bool Editar_Estadistica;
        readonly ServiceClient Client = new ServiceClient();

        public FrmCapturaEstadistica()
        {
            InitializeComponent();
            LoadTipos();
            LoadMunicipios();
            this.Editar_Estadistica = false;
            this.Text = "Nuevo Registro";
            Btn_Accion.Text = "&Guardar";
            Btn_Accion.BackColor = System.Drawing.Color.Green;
        }

        public FrmCapturaEstadistica(int ID)
        {
            InitializeComponent();
            this.ID_Estadistica = ID;
            CBTipos.Enabled = false; 
            CBMunicipios.Enabled = false;
            LoadTipos();
            LoadMunicipios();
            this.Editar_Estadistica = true;
            this.Text = "Cargando Datos";
            Btn_Accion.Text = "&Actualizar";
            Btn_Accion.BackColor = System.Drawing.Color.Teal;
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            Btn_Accion.Enabled = false;
            if(CBTipos.SelectedIndex != -1) {
                if (CBMunicipios.SelectedIndex != -1) {
                    if (this.Editar_Estadistica) {
                        ActualizarEstadistica();
                    } else{
                        GuardarEstadistica();
                    }
                } else{
                    MessageBox.Show("Inserte todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CBMunicipios.Focus();
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
            if (response != null) {
                TiposCargados = new string[response.Count, 2];
                int i = 0;
                foreach (var Item in response.Result) {
                    CBTipos.Items.Add(Item.Name);
                    TiposCargados[i, 0] = Item.Id.ToString();
                    TiposCargados[i, 1] = Item.Name;
                    i++;
                }

                if (response.Count > 0) {
                    CBTipos.SelectedIndex = 0;
                    CBTipos.Enabled = true;
                }
            } else{
                Btn_Accion.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

                if(this.Editar_Estadistica)
                {
                    LoadEstadistica();
                }
            } else{
                Btn_Accion.Enabled = false;
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void LoadEstadistica()
        {
            var datos = new
            {
                estadistica = this.ID_Estadistica
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<EstadisticasModel>>(datos_serializados, "estadisticas/obtener");
            if(response != null) {
                int Tipos = TiposCargados.Length / 2;
                int Municipios = MunicipiosCargados.Length / 2;
                for (int i = 0; i < Tipos; i++) {
                    if(TiposCargados[i, 0] == response.Result.Type.ToString()) {
                        CBTipos.Enabled = true;
                        CBTipos.SelectedIndex = i;
                        break;
                    }
                }
                for (int i = 0; i < Municipios; i++) {
                    if (MunicipiosCargados[i, 0] == response.Result.Municipality.ToString()) {
                        CBMunicipios.Enabled = true;
                        CBMunicipios.SelectedIndex = i;
                        break;
                    }
                }
                NUDPorcentaje.Value = response.Result.Percentage;
                this.Text = "Editar datos";
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GuardarEstadistica()
        {
            var datos = new
            {
                tipo = Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]),
                municipio = Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]),
                porcentaje = NUDPorcentaje.Value
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "estadisticas/guardar");
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
                        Btn_Accion.Enabled = true;
                    }
                } else{
                    MessageBox.Show(response.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Btn_Accion.Enabled = true;
                }
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void ActualizarEstadistica()
        {
            var datos = new
            {
                estadistica = ID_Estadistica,
                tipo = Convert.ToInt32(TiposCargados[CBTipos.SelectedIndex, 0]),
                municipio = Convert.ToInt32(MunicipiosCargados[CBMunicipios.SelectedIndex, 0]),
                porcentaje = NUDPorcentaje.Value
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "estadisticas/actualizar");
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
            CBMunicipios.SelectedIndex = -1;
            NUDPorcentaje.Value = 0;
            CBTipos.Focus();
            Btn_Accion.Enabled = true;
        }
    }
}
