using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BugTracker
{
    public partial class frmConsultaBugs : Form
    {
        public frmConsultaBugs()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }


        private void frmConsultaBugs_Load(object sender, EventArgs e)
        {
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Estados"),"nombre","id_estado");
            LlenarCombo(cboAsignadoA,DataManager.GetInstance().ConsultaSQL("SELECT * FROM Usuarios"),"usuario","id_usuario");
            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Prioridades"),"nombre","id_prioridad");
            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Criticidades"),"nombre","id_criticidad");
            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("SELECT * FROM Productos"), "nombre", "id_producto");
        }
        private void btnConsultar_Click_1(object sender, EventArgs e)
        { 
            //armo la consulta sql
            string consultaSQL = "SELECT * FROM Bugs WHERE 1=1 ";
            
            //creo el diccionario que va a contener los parametros de consulta
            Dictionary<string, object> parametrosConsulta = new Dictionary<string, object>();

            //armo la parte de la consulta para el combo de Fechas
            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde) &&
                DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                consultaSQL += " AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta) ";
                parametrosConsulta.Add("fechaDesde", fechaDesde);
                parametrosConsulta.Add("fechaHasta", fechaHasta);


                //armo la parte de la consulta para el combo de Estados
                if (!string.IsNullOrEmpty(cboEstados.Text))
                {
                    var idEstado = cboEstados.SelectedValue.ToString();
                    consultaSQL += "AND (id_estado=@idEstado) ";
                    parametrosConsulta.Add("idEstado", idEstado);
                }

                //armo la parte de la consulta para el combo de Asignado a
                if (!string.IsNullOrEmpty(cboAsignadoA.Text))
                {
                    var asignadoA = cboAsignadoA.SelectedValue.ToString();
                    consultaSQL += "AND (id_usuario_asignado=@idUsuarioAsignado) ";
                    parametrosConsulta.Add("idUsuarioAsignado", asignadoA);
                }

                //armo la parte de la consulta para el combo de Prioridad
                if (!string.IsNullOrEmpty(cboPrioridades.Text))
                {
                    var idPrioridad = cboPrioridades.SelectedValue.ToString();
                    consultaSQL += "AND (id_prioridad = @idPrioridad)";
                    parametrosConsulta.Add("idPrioridad", idPrioridad);
                }

                //armo la parte de la consulta para el combo de Criticidad
                if (!string.IsNullOrEmpty(cboCriticidades.Text))
                {
                    var idCriticidad = cboCriticidades.SelectedValue.ToString();
                    consultaSQL += "AND (id_criticidad=@idCriticidad)";
                    parametrosConsulta.Add("idCriticidad", idCriticidad);
                }

                //armo la parte de la consulta para el combo de Producto
                if (!string.IsNullOrEmpty(cboProductos.Text))
                {
                    var idProducto = cboProductos.SelectedValue.ToString();
                    consultaSQL += "AND (id_producto=@idProducto)";
                    parametrosConsulta.Add("idProducto", idProducto);
                }

                //Completar el resto de las validaciones 
                consultaSQL += " ORDER BY fecha_alta DESC";
                dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(consultaSQL, parametrosConsulta);

                if (dgvBugs.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Ingresar al menos las fechas Desde y Hasta", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        //METODOS
        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {
            // Datasource: establece el origen de datos de este objeto.
            cbo.DataSource = source;
            // DisplayMember: establece la propiedad que se va a mostrar para este ListControl.
            cbo.DisplayMember = display;
            // ValueMember: establece la ruta de acceso de la propiedad que se utilizará como valor real para los elementos de ListControl.
            cbo.ValueMember = value;
            //SelectedIndex: establece el índice que especifica el elemento seleccionado actualmente.
            cbo.SelectedIndex = -1;
        }

    }
}
