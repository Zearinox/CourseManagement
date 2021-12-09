using CourseManagement.Business;
using CourseManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public partial class AddEditSubjectForm : Form
    {
        private readonly bool IsEdit;
        private Materia Subjet;
        public AddEditSubjectForm(bool isEdit, Materia subjet)
        {
            InitializeComponent();
            IsEdit = isEdit;
            Subjet = subjet;
            InitCbx();
            StartNames();
            InitImputs();
        }
        private void InitCbx()
        {
            List<Profesor> teachers = ProfesorService.GetAllTeachs();
            List<Anios> years = AniosService.GetAllYears();
            List<Cuatrimestre> semestres = CuatrimestreService.GetAllSemestres();
            cbxTeacher.DataSource = teachers;
            cbxSemestre.DataSource = semestres;
            cbxYear.DataSource = years;
            cbxTeacher.ValueMember = "Id";
            cbxSemestre.ValueMember = "Id";
            cbxYear.ValueMember = "Id";
            cbxTeacher.DisplayMember = "Apellido";
            cbxSemestre.DisplayMember = "Nombre";
            cbxYear.DisplayMember = "Nombre";
            if (!IsEdit)
            {
                cbxTeacher.SelectedIndex = -1;
                cbxTeacher.Text = "Seleccionar...";
                cbxSemestre.SelectedIndex = -1;
                cbxSemestre.Text = "Seleccionar...";
                cbxYear.SelectedIndex = -1;
                cbxYear.Text = "Seleccionar...";
                cbxDays.SelectedIndex = -1;
                cbxDays.Text = "Seleccionar...";
            }
        }
        private void StartNames()
        {
            this.Text = IsEdit ? "Editar Materia" : "Nueva Materia";
            btnAddEditSubjet.Text = IsEdit ? "Guardar" : "Agregar";
        }
        private void InitImputs()
        {
            numCode.Enabled = false;
            numCode.Value = Subjet.Id;
            txtName.Text = Subjet.NombreMateria;
            cbxDays.Text = Subjet.DiaCursada;
            if (Subjet.IdProfesor != null ) cbxTeacher.SelectedValue = Subjet.IdProfesor;
            if (Subjet.IdCuatrimestre != null) cbxSemestre.SelectedValue = Subjet.IdCuatrimestre;
            if (Subjet.IdAnio != null) cbxYear.SelectedValue = Subjet.IdAnio;
            if (Subjet.Cursada.HasValue) chbCursada.Checked = Subjet.Cursada.Value;
            if (Subjet.Aprobada.HasValue) chbSubAprove.Checked = Subjet.Aprobada.Value;
        }

        private void btnAddEditSubjet_Click(object sender, EventArgs e)
        {
            if (FormIsComplete())
            {
                Materia subject = new Materia()
                {
                    Id = Convert.ToInt32(numCode.Value),
                    NombreMateria = txtName.Text,
                    DiaCursada = cbxDays.Text,
                    Cursada = chbCursada.Checked,
                    Aprobada = chbSubAprove.Checked,
                    IdAnio = (int)cbxYear.SelectedValue,
                    IdCuatrimestre = (int)cbxSemestre.SelectedValue,
                    IdProfesor = (int)cbxTeacher.SelectedValue
                };
                bool result = IsEdit ? MateriasService.UpdateSubjet(subject) : MateriasService.InsertSubjet(subject);
                if (result) Message.Ok($"Se grabó el registro correctamente");
                else Message.Error($"Error, no se pudo grabar el registro");
                Close();
            }
            else Message.Warning($"Debe completar el formulario para insertar");

        }
        private bool FormIsComplete()
        {
            if (string.IsNullOrEmpty(txtName.Text)) return false;
            if (string.IsNullOrEmpty(cbxDays.Text)) return false;
            if (cbxSemestre.SelectedValue != null)
            {
                if ((int)cbxSemestre.SelectedValue < 0) return false;
            }
            else return false;
            if (cbxTeacher.SelectedValue != null)
            {
                if ((int)cbxTeacher.SelectedValue < 0) return false;
            }
            else return false;
            if (cbxYear.SelectedValue != null)
            {
                if ((int)cbxYear.SelectedValue < 0) return false;
            }
            else return false;
            
            return true;
        }

    }
}
