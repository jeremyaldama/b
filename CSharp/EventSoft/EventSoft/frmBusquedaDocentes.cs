using EventSoft.ServiciosWS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventSoft
{
    public partial class frmBusquedaDocentes : Form
    {
        private WSClient _serviciosWS;
        private docente _docenteSeleccionado;
        int _idEspecialidad;
        public frmBusquedaDocentes()
        {
            InitializeComponent();
            _serviciosWS = new WSClient();
            dgvDocentes.AutoGenerateColumns = false;
        }

        public frmBusquedaDocentes(int idEspecialidad)
        {
            InitializeComponent();
            _serviciosWS = new WSClient();
            dgvDocentes.AutoGenerateColumns = false;
            this._idEspecialidad = idEspecialidad;
        }

        public docente DocenteSeleccionado { get => _docenteSeleccionado; set => _docenteSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvDocentes.DataSource = _serviciosWS.listarDocentesPorCodigoPUCPNombreIdEspecialidad(txtNombreCodigo.Text, _idEspecialidad);
        }

        private void dgvDocentes_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            docente docente = (docente)dgvDocentes.Rows[e.RowIndex].DataBoundItem;
            dgvDocentes.Rows[e.RowIndex].Cells[0].Value = docente.idDocente;
            dgvDocentes.Rows[e.RowIndex].Cells[1].Value = docente.nombre + " "
                + docente.apellidoPaterno + " " + docente.apellidoMaterno;
            dgvDocentes.Rows[e.RowIndex].Cells[2].Value = docente.especialidad.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.CurrentRow != null)
            {
                DocenteSeleccionado = (docente)dgvDocentes.CurrentRow.DataBoundItem;
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
