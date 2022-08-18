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
            string strSQL = "SELECT TOP 20 * FROM bugs WHERE 1=1 ";
            Dictionary<string, object> parametros = new Dictionary<string, object>();

            DateTime fechaDesde;
            DateTime fechaHasta;
            if (DateTime.TryParse(txtFechaDesde.Text, out fechaDesde)
                && DateTime.TryParse(txtFechaHasta.Text, out fechaHasta))
            {
                strSQL += " AND (fecha_alta>=@fechaDesde AND fecha_alta<=@fechaHasta) ";
                parametros.Add("fechaDesde", txtFechaDesde.Text);
                parametros.Add("fechaHasta", txtFechaHasta.Text);
            }

            if (!string.IsNullOrEmpty(cboEstados.Text))
            {
                var idEstado = cboEstados.SelectedValue.ToString();
                strSQL += "AND (id_estado=@idEstado) ";
                parametros.Add("isEstado", idEstado);
            }

            if (!string.IsNullOrEmpty(cboAsignadoA.Text))
            { 
                var asignadoA = cboAsignadoA.SelectedValue.ToString();
                strSQL += "AND (id_usuario_asignado=@idUsuarioAsignado) ";
                parametros.Add("isUsuarioAsignado", asignadoA);
            }

            strSQL += "ORDER BY fecha_alta DESC";
            dgvBugs.DataSource = DataManager.GetInstance().ConsultaSQL(strSQL, parametros);

            if (dgvBugs.Rows.Count == 0) 
            {
                MessageBox.Show("No se encontraron coincidencias para el/los filtros ingresados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LLenarCombo(ComboBox cbo, Object source, string display, String value) 
        {
            cbo.DataSource = source;
            cbo.DisplayMember = display;
            cbo.ValueMember = value;
            cbo.SelectedIndex = -1;
        }

        private void frmBugs_Load(object sender, EventArgs e) 
        {
            LLenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * from Estados"), "nombre", "id_estado");
            LLenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * from Prioridades"), "nombre", "id_prioridad");
            LLenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * from Criticidades"), "nombre", "id_criticidad");
            LLenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * from Usuarios"), "usuario", "id_usuario");
            LLenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * from Productos"), "nombre", "id_producto");
        }
    }
}
