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

        private void LlenarCombo(ComboBox cbo, Object source, string display, String value)
        {

            //DataSource establece el origen de datos de este objeto
            cbo.DataSource = source;

            //DisplayMember Establece la prioridad que se va a mostrar para este ListControl
            cbo.DisplayMember = display;

            //ValueMember: Establece la ruta de acceso de la prioridad que se utilizara para el valor real de los elementos de ListControl
            cbo.ValueMember = value;

            //SelectedIndex: Establece el indice que especifica el elemento seleccionado actualmente
            cbo.SelectedIndex = -1;

        }

        private void Load(object sender, EventArgs e)
        {
           
            LlenarCombo(cboEstados, DataManager.GetInstance().ConsultaSQL("Select * From Estados"), "nombre", "id_estado");

            LlenarCombo(cboPrioridades, DataManager.GetInstance().ConsultaSQL("Select * From Prioridades"), "nombre", "id_prioridad");

            LlenarCombo(cboCriticidades, DataManager.GetInstance().ConsultaSQL("Select * From Criticidades"), "nombre", "id_criticidad");

            LlenarCombo(cboAsignadoA, DataManager.GetInstance().ConsultaSQL("Select * From Usuarios"), "usuario", "id_usuario");

            LlenarCombo(cboProductos, DataManager.GetInstance().ConsultaSQL("Select * From Productos"), "nombre", "id_producto");

        }
    }
}
