using dominio3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PracticaEventos
{
    public partial class DireForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)

            {

                int id  = int.Parse(Request.QueryString["id"].ToString());
                List<Direccion> temporal = (List<Direccion>)Session["ListaDireccion"];
                Direccion seleccionado = temporal.Find(x =>  x.Id == id);   
                txtCalle.Text = seleccionado.Calle;
                txtId.Text = seleccionado.Id.ToString();

            }


            if (!IsPostBack)
            {
                if (Session["Direcciones"] != null)
                {
                    List<Direccion> direcciones = (List<Direccion>)Session["Direcciones"];
                    int id;
                    if (int.TryParse(Request.QueryString["id"], out id))
                    {
                        var direccion = direcciones.FirstOrDefault(d => d.Id == id);
                        if (direccion != null)
                        {
                            txtId.Text = direccion.Id.ToString();
                            txtCalle.Text = direccion.Calle;
                            txtAltura.Text = direccion.Altura.ToString();
                        }
                    }
                }
            }


        }
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Direccion d = new Direccion();
            d.Id = int.Parse(txtId.Text);
            d.Calle = txtCalle.Text;
            d.Altura = int.Parse(txtAltura.Text);
            // Esto en otro contexto se lo mandaria a la base de datos llamando a algun metodo.

            //   ((List<Direccion>)Session["ListaDireccion"]).Add(d);

            List<Direccion> temporal = (List<Direccion>)Session["ListaDireccion"];
            temporal.Add(d);

            Response.Redirect("Default.aspx");

        } 
    }
}