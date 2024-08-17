using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using dominio3;

namespace PracticaEventos
{
    public partial class Default : System.Web.UI.Page
    {
        private static List<Direccion> direcciones = new List<Direccion>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ListaDireccion"] == null) 
            {
              DireccionNegocio negocio = new DireccionNegocio();
              Session.Add("ListaDireccion", negocio.listar());
            }
            dgvDireccion.DataSource = Session["ListaDireccion"];
            dgvDireccion.DataBind();

            if (!IsPostBack)
            {
                // Cargar datos en el GridView  
                CargarDatos();
            }

        }

        private void CargarDatos()
        {
            // Aquí deberías cargar la lista de direcciones en el GridView  
            dgvDireccion.DataSource = direcciones;
            dgvDireccion.DataBind();
        }
            protected void dgvDireccion_SelectedIndexChanged(object sender, EventArgs e)
        {
           // var algo = dgvDireccion.SelectedRow.Cells[0].Text;
            var id = dgvDireccion.SelectedDataKey.Value.ToString();
            Response.Redirect("DireForm.aspx?id=" + id); 
        }

        protected void btnmodificar_Click(object sender, EventArgs e)
        {
            if (dgvDireccion.SelectedRow != null)
            {
                // Obtener el Id seleccionado  
                int id = Convert.ToInt32(dgvDireccion.SelectedDataKey.Value);
                Response.Redirect($"DireForm.aspx?id={id}");
            }
            else
            {
                Response.Write("<script>alert('Por favor seleccione una fila para modificar');</script>");
            }

        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvDireccion.SelectedRow != null)
            {
                // Obtener el Id seleccionado  
                int id = Convert.ToInt32(dgvDireccion.SelectedDataKey.Value);
                Direccion direccion = direcciones.FirstOrDefault(d => d.Id == id);

                if (direccion != null)
                {
                    direcciones.Remove(direccion);
                    CargarDatos(); // Actualiza el GridView  
                }
            }
            else
            {
                // Mensaje si no seleccionó ninguna fila  
                Response.Write("<script>alert('Por favor seleccione una fila para eliminar');</script>");
            }

        }
    }
}