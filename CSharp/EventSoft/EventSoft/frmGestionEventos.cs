using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EventSoft.ServiciosWS;


namespace EventSoft
{
    public partial class frmGestionEventos : Form
    {
        WSClient _serviciosWS;
        private Estado _estado;
        private string _rutaFoto = "";
        private docente _docenteSeleccionado;
        private evento _evento;
        private actividad _actividadSeleccionada;
        private BindingList<docente> _docentes;
        private BindingList<actividad> _actividades;

        public frmGestionEventos()
        {
            InitializeComponent();
            _estado = Estado.Inicial;
            establecerEstadoComponentes();

            _serviciosWS = new WSClient();
            cboEspecialidad.ValueMember = "idEspecialidad";
            cboEspecialidad.DisplayMember = "nombre";
            cboEspecialidad.DataSource = _serviciosWS.listarEspecialidadesTodas();

            dgvDocentes.AutoGenerateColumns = false;
            dgvActividades.AutoGenerateColumns = false;
        }

        public void establecerEstadoComponentes()
        {
            switch (_estado)
            {
                case Estado.Inicial:
                    btnNuevo.Enabled = true;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = true;
                    btnCancelar.Enabled = true;
                    txtIDEvento.Enabled = false;
                    txtNombreEvento.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    cboEspecialidad.Enabled = false;
                    txtCosto.Enabled = false;
                    txtCodigoPUCPDocente.Enabled = false;
                    txtNombreDocente.Enabled = false;
                    btnBuscarDocente.Enabled = false;
                    btnAgregarActividad.Enabled = false;
                    btnEliminarActividad.Enabled = false;
                    btnAgregarDocente.Enabled = false;
                    btnEliminarDocente.Enabled = false;
                    dgvDocentes.Enabled = false;
                    txtNombreActividad.Enabled = false;
                    dtpFechaActividad.Enabled = false;
                    dtpHoraInicio.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    dgvActividades.Enabled = false;
                    break;
                case Estado.Nuevo:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = true;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDEvento.Enabled = true;
                    txtNombreEvento.Enabled = true;
                    dtpFechaInicio.Enabled = true;
                    dtpFechaFin.Enabled = true;
                    btnSubirFoto.Enabled = true;
                    cboEspecialidad.Enabled = true;
                    txtCosto.Enabled = true;
                    txtCodigoPUCPDocente.Enabled = true;
                    txtNombreDocente.Enabled = true;
                    btnBuscarDocente.Enabled = true;
                    btnAgregarActividad.Enabled = true;
                    btnEliminarActividad.Enabled = true;
                    btnAgregarDocente.Enabled = true;
                    btnEliminarDocente.Enabled = true;
                    dgvDocentes.Enabled = true;
                    txtNombreActividad.Enabled = true;
                    dtpFechaActividad.Enabled = true;
                    dtpHoraInicio.Enabled = true;
                    dtpHoraFin.Enabled = true;
                    dgvActividades.Enabled = true;
                    break;
                case Estado.Guardar:
                case Estado.Buscar:
                    btnNuevo.Enabled = false;
                    btnGuardar.Enabled = false;
                    btnBuscar.Enabled = false;
                    btnCancelar.Enabled = true;
                    txtIDEvento.Enabled = false;
                    txtNombreEvento.Enabled = false;
                    dtpFechaInicio.Enabled = false;
                    dtpFechaFin.Enabled = false;
                    btnSubirFoto.Enabled = false;
                    cboEspecialidad.Enabled = false;
                    txtCosto.Enabled = false;
                    txtCodigoPUCPDocente.Enabled = false;
                    txtNombreDocente.Enabled = false;
                    btnBuscarDocente.Enabled = false;
                    btnAgregarActividad.Enabled = false;
                    btnEliminarActividad.Enabled = false;
                    btnAgregarDocente.Enabled = false;
                    btnEliminarDocente.Enabled = false;
                    dgvDocentes.Enabled = false;
                    txtNombreActividad.Enabled = false;
                    dtpFechaActividad.Enabled = false;
                    dtpHoraInicio.Enabled = false;
                    dtpHoraFin.Enabled = false;
                    dgvActividades.Enabled = false;
                    break;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            _estado = Estado.Nuevo;
            limpiarComponentes();
            establecerEstadoComponentes();
            _actividades = new BindingList<actividad>();
            _docentes = new BindingList<docente>();
            _evento = new evento();
            dgvDocentes.DataSource = _docentes;
            dgvActividades.DataSource = _actividades;
        }

        public void limpiarComponentes()
        {
            txtIDEvento.Text = "";
            txtNombreEvento.Text = "";
            dtpFechaInicio.Value = DateTime.Now;
            dtpFechaFin.Value = DateTime.Now;
            cboEspecialidad.SelectedIndex = -1;
            txtCosto.Text = "";
            dgvDocentes.DataSource = null;
            txtCodigoPUCPDocente.Text = "";
            txtNombreDocente.Text = "";
            txtNombreActividad.Text = "";
            dtpFechaActividad.Value = DateTime.Now;
            dtpHoraInicio.Value = DateTime.Now;
            dtpHoraFin.Value = DateTime.Now;
            dgvActividades.DataSource = null;
        }

        private void btnSubirFoto_Click(object sender, EventArgs e)
        {
            try
            {
                if (ofdFoto.ShowDialog() == DialogResult.OK)
                {
                    _rutaFoto = ofdFoto.FileName;
                    pbFoto.Image = Image.FromFile(_rutaFoto);
                    
                    FileStream fs = new FileStream(_rutaFoto, FileMode.Open, FileAccess.Read);
                    BinaryReader br = new BinaryReader(fs);
                    _evento.foto = br.ReadBytes((int)fs.Length);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("El archivo seleccionado no es un tipo de imagen válido");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            _estado = Estado.Inicial;
            limpiarComponentes();
            establecerEstadoComponentes();
        }

        private void btnBuscarDocente_Click(object sender, EventArgs e)
        {
            frmBusquedaDocentes frmBusqDoc = new frmBusquedaDocentes((int)cboEspecialidad.SelectedValue);
            if (frmBusqDoc.ShowDialog() == DialogResult.OK)
            {
                _docenteSeleccionado = frmBusqDoc.DocenteSeleccionado;
                //llenar Datos
                txtCodigoPUCPDocente.Text = _docenteSeleccionado.codigoPUCP;
                txtNombreDocente.Text = _docenteSeleccionado.nombre + " "
                + _docenteSeleccionado.apellidoPaterno + " " + _docenteSeleccionado.apellidoMaterno;
            }
        }

        private void btnAgregarDocente_Click(object sender, EventArgs e)
        {
            if (_docenteSeleccionado != null)
            {
                _docentes.Add(_docenteSeleccionado);
                txtCodigoPUCPDocente.Text = "";
                txtNombreDocente.Text = "";
                _docenteSeleccionado = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnEliminarDocente_Click(object sender, EventArgs e)
        {
            if (dgvDocentes.CurrentRow != null)
            {
                docente docente = (docente)dgvDocentes.CurrentRow.DataBoundItem;
                this._docentes.Remove(docente);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnAgregarActividad_Click(object sender, EventArgs e)
        {
            _actividadSeleccionada = new actividad();
            _actividadSeleccionada.horaInicio = dtpHoraInicio.Value.ToString("HH:mm"); ;
            _actividadSeleccionada.horaFin = dtpHoraFin.Value.ToString("HH:mm"); ;
            _actividadSeleccionada.nombre = txtNombreActividad.Text;
            _actividadSeleccionada.fecha = dtpFechaActividad.Value;
            _actividadSeleccionada.fechaSpecified = true;

            if (_actividadSeleccionada != null)
            {
                _actividades.Add(_actividadSeleccionada);
                txtNombreActividad.Text = "";
                _actividadSeleccionada = null;
            }
            else
            {
                MessageBox.Show("Debe seleccionar una actividad", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dgvActividades_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            actividad actividad = (actividad)dgvActividades.Rows[e.RowIndex].DataBoundItem;
            dgvActividades.Rows[e.RowIndex].Cells[0].Value = actividad.nombre;
            dgvActividades.Rows[e.RowIndex].Cells[1].Value = actividad.fecha.ToString("dd-MM-yyyy");
            dgvActividades.Rows[e.RowIndex].Cells[2].Value = actividad.horaInicio;
            dgvActividades.Rows[e.RowIndex].Cells[3].Value = actividad.horaFin;
        }

        private void btnEliminarActividad_Click(object sender, EventArgs e)
        {
            if (dgvActividades.CurrentRow != null)
            {
                actividad actividad = (actividad)dgvActividades.CurrentRow.DataBoundItem;
                this._actividades.Remove(actividad);
            }
            else
            {
                MessageBox.Show("Debe seleccionar un docente", "Mensaje de advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            _evento.nombre = txtNombreEvento.Text;
            _evento.fechaInicio = dtpFechaInicio.Value;
            _evento.fechaInicioSpecified = true;
            _evento.fechaFin = dtpFechaFin.Value;
            _evento.fechaFinSpecified = true;
            _evento.especialidad = new especialidad();
            _evento.especialidad.idEspecialidad = (int)cboEspecialidad.SelectedValue;
            _evento.costo = Double.Parse(txtCosto.Text);
            _evento.responsables = _docentes.ToArray();
            _evento.actividades = _actividades.ToArray();

            int resultado = _serviciosWS.insertarEvento(_evento);
            if (resultado != 0)
            {
                txtIDEvento.Text = resultado.ToString();
                MessageBox.Show("Se ha registrado correctamente",
                "Mensaje de éxito", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
                _estado = Estado.Guardar;
                establecerEstadoComponentes();
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error con el registro",
                "Mensaje de éxito", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmBusquedaEventos frmBusqEvent = new frmBusquedaEventos();
            if (frmBusqEvent.ShowDialog() == DialogResult.OK)
            {
                _evento = frmBusqEvent.EventoSeleccionado;

                //llenas info
                txtIDEvento.Text = _evento.idEvento.ToString();
                txtNombreEvento.Text = _evento.nombre;


                dtpFechaInicio.Value = _evento.fechaInicio;
                dtpFechaFin.Value = _evento.fechaFin;
                cboEspecialidad.SelectedValue = _evento.especialidad;
                txtCosto.Text = _evento.costo.ToString();


                if (_evento.foto != null)
                {
                    MemoryStream ms = new MemoryStream(_evento.foto);
                    pbFoto.Image = new Bitmap(ms);
                }

                dgvActividades.DataSource = _evento.actividades;
                dgvDocentes.DataSource = _evento.responsables;

            }
        }
    }
}
