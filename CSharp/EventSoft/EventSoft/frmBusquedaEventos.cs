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
    public partial class frmBusquedaEventos : Form
    {
        private WSClient _servicioWS;
        private evento _eventoSeleccionado;
        public frmBusquedaEventos()
        {
            InitializeComponent();
            dgvEventos.AutoGenerateColumns = false;
            _servicioWS = new WSClient();
        }

        public evento EventoSeleccionado { get => _eventoSeleccionado; set => _eventoSeleccionado = value; }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            dgvEventos.DataSource = _servicioWS.listarEventosPorNombre(txtNombreID.Text);
        }

        private void dgvEventos_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            evento evento = (evento)dgvEventos.Rows[e.RowIndex].DataBoundItem;
            dgvEventos.Rows[e.RowIndex].Cells[0].Value = evento.idEvento;
            dgvEventos.Rows[e.RowIndex].Cells[1].Value = evento.nombre;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvEventos.CurrentRow != null)
            {
                EventoSeleccionado = (evento)dgvEventos.CurrentRow.DataBoundItem;
                EventoSeleccionado.responsables = _servicioWS.listarDocentePorIdEvento(EventoSeleccionado.idEvento);
                EventoSeleccionado.actividades = _servicioWS.listarActividadesPorIdEvento(EventoSeleccionado.idEvento);
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
