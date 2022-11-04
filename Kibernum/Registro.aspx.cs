using Kibernum.Business;
using ProyectoDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kibernum
{
    public partial class Registro : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            PersonaDTO persona = new PersonaDTO();
            persona.Documento = txtDocumento.Text;
            persona.Nombres = txtNombres.Text;
            persona.Apellidos = txtApellidos.Text;
            persona.FechaNacimiento = DateTime.Parse(txtFechaNacimiento.Text);
            persona.NumerosTelefonicos = txtNumerosTelefonicos.Text;
            persona.CorreosElectronicos = txtCorreoElectronico.Text;
            persona.DirecionesFisicas = txtDirecciones.Text;

            try
            {
                new PersonaBusiness().Insertar(persona);
                MostrarMensaje("Usuario registrado exitosamente");
            }
            catch (Exception ex)
            {
                MostrarMensaje(ex.Message);
            }
            
        }

        private void MostrarMensaje(string mensaje)
        {
            string script = "MostrarMensaje(" + mensaje + ")";
            ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", script, false);
        }
    }
}