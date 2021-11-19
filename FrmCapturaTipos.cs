using System;
using System.Windows.Forms;
using Cliente_API_REST.Models;

namespace Cliente_API_REST
{
    public partial class FrmCapturaTipos : Form
    {
        private readonly int ID_Tipo;
        private readonly bool Editar_Tipo;
        readonly ServiceClient Client = new ServiceClient();
        
        public FrmCapturaTipos()
        {
            InitializeComponent();
            this.Editar_Tipo = false;
            this.Text = "Nuevo Registro";
            Btn_Accion.Text = "&Guardar";
            Btn_Accion.BackColor = System.Drawing.Color.Green;
        }

        public FrmCapturaTipos(int ID)
        {
            InitializeComponent();
            this.ID_Tipo = ID;
            this.Editar_Tipo = true; 
            this.Text = "Cargando Datos"; 
            Btn_Accion.Text = "&Actualizar";
            Btn_Accion.BackColor = System.Drawing.Color.Teal;
            LoadTipo();
        }

        private void Btn_Accion_Click(object sender, EventArgs e)
        {
            Btn_Accion.Enabled = false;
            if (Txb_Nombre.Text != "")
            {
                if (RTB_Descripcion.Text != "")
                {
                    if (this.Editar_Tipo)
                    {
                        ActualizarTipo();
                    }
                    else
                    {
                        GuardarTipo();
                    }
                }
                else
                {
                    MessageBox.Show("Inserte todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    RTB_Descripcion.Focus();
                    Btn_Accion.Enabled = true;
                }
            }
            else
            {
                MessageBox.Show("Inserte todos los datos solicitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Txb_Nombre.Focus();
                Btn_Accion.Enabled = true;
            }
        }

        private async void LoadTipo()
        {
            var datos = new
            {
                tipo = this.ID_Tipo
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<TiposModel>>(datos_serializados, "tipos/obtener");
            if(response != null) {
                Txb_Nombre.Text = response.Result.Name;
                RTB_Descripcion.Text = response.Result.Description;
                this.Text = "Editar datos";
            } else{
                MessageBox.Show("No se pudo establecer conexión con el servidor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void GuardarTipo()
        {
            var datos = new
            {
                nombre = Txb_Nombre.Text,
                descripcion = RTB_Descripcion.Text
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "tipos/guardar");
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

        private async void ActualizarTipo()
        {
            var datos = new
            {
                tipo        = ID_Tipo,
                nombre      = Txb_Nombre.Text,
                descripcion = RTB_Descripcion.Text
            };

            var datos_serializados = Newtonsoft.Json.JsonConvert.SerializeObject(datos);
            var response = await Client.Post<Response<bool?>>(datos_serializados, "tipos/actualizar");
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
            Txb_Nombre.Clear();
            RTB_Descripcion.Clear();
            Txb_Nombre.Focus();
            Btn_Accion.Enabled = true;
        }
    }
}
