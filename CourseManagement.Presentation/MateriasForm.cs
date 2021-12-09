using CourseManagement.Business;
using CourseManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public partial class MateriasForm : Form
    {
        public MateriasForm()
        {
            InitializeComponent();
            ReloadList();
        }
        private void ReloadList()
        {
            List<Materia> subjects = MateriasService.GetAllSubjets();
            LoadDgv(subjects);
            ButtonCriteria(isSelected: false);
        }
        private void ButtonCriteria(bool isSelected)
        {
            btnEditarMateria.Enabled = isSelected;
            btnEliminarMateria.Enabled = isSelected;
        }
        private void LoadDgv(List<Materia> subjects)
        {
            dgvMateria.DataSource = subjects;
            dgvMateria.Columns["IdAnio"].Visible = false;
            dgvMateria.Columns["IdCuatrimestre"].Visible = false;
            dgvMateria.Columns["IdProfesor"].Visible = false;
        }
        private void btnEliminarMateria_Click(object sender, EventArgs e)
        {
            if (Message.Validation("¿Esta seguro que quiere eliminar el registro?"))
            {
                string id = dgvMateria.CurrentRow.Cells["Id"].Value.ToString();
                bool result = MateriasService.DeleteSubjet(id);
                if (result)
                {
                    ReloadList();
                    Message.Ok("Se eliminó el registro correctamente");
                }
                else Message.Error("Error, no se puedo eliminar el registro");
            }
        }
        private void btnAgregarMateria_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddEditSubjectForm addEditSubjecForm = new AddEditSubjectForm(isEdit: false, subjet: new Materia());
            addEditSubjecForm.FormClosing += AddEditSubjectForm_FormClosing;
            addEditSubjecForm.Show();
        }
        private void btnEditarMateria_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Materia subjet = MateriasService.GetTeacherById((int)dgvMateria.CurrentRow.Cells["Id"].Value);
            AddEditSubjectForm addEditSubjecForm = new AddEditSubjectForm(isEdit: true, subjet: subjet);
            addEditSubjecForm.FormClosing += AddEditSubjectForm_FormClosing;
            addEditSubjecForm.Show();
        }
        public void AddEditSubjectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            ReloadList();
        }
        private void dgvMateria_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvMateria.Columns[e.ColumnIndex].Name == "Cursada" || dgvMateria.Columns[e.ColumnIndex].Name == "Aprobada")
            {
                if (e.Value is bool)
                {
                    bool value = (bool)e.Value;
                    e.Value = (value) ? "Sí" : "No";
                    e.FormattingApplied = true;
                }
            }
            if (dgvMateria.Columns[e.ColumnIndex].Name == "Cuatrimestre")
            {
                if (e.Value is Cuatrimestre)
                {
                    Cuatrimestre value = (Cuatrimestre)e.Value;
                    e.Value = value.Nombre;
                    e.FormattingApplied = true;
                }
            }
            if (dgvMateria.Columns[e.ColumnIndex].Name == "Anios")
            {
                if (e.Value is Anios)
                {
                    Anios value = (Anios)e.Value;
                    e.Value = value.Nombre;
                    e.FormattingApplied = true;
                }
            }
            if (dgvMateria.Columns[e.ColumnIndex].Name == "Profesor")
            {
                if (e.Value is Profesor)
                {
                    Profesor value = (Profesor)e.Value;
                    e.Value = value.Nombre + " " + value.Apellido;
                    e.FormattingApplied = true;
                }
            }
        }
        private void dgvMateria_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonCriteria(dgvMateria.SelectedRows.Count == 1);
        }

        private void txtBuscarMateria_KeyUp(object sender, KeyEventArgs e)
        {
            Search();
        }
        private void cbobuscar_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search();
        }
        private void Search()
        {
            if (!string.IsNullOrEmpty(txtBuscarMateria.Text))
            {
                List<Materia> subjects = MateriasService.GetAllSubjets();
                if (cbobuscar.Text == "MATERIA")
                    subjects = subjects.Where(s => s.NombreMateria.ToLower().Contains(txtBuscarMateria.Text.ToLower())).ToList();
                else
                    subjects = subjects.Where(s => s.Profesor.Nombre.ToLower().Contains(txtBuscarMateria.Text.ToLower()) || s.Profesor.Apellido.ToLower().Contains(txtBuscarMateria.Text.ToLower())).ToList();

                dgvMateria.DataSource = subjects;
                ButtonCriteria(isSelected: false);
            }
            else
                ReloadList();
        }

        private void btnProf_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            ProfesoresForm profesoresForm = new ProfesoresForm();
            profesoresForm.FormClosing += MateriaForm_FormClosing;
            profesoresForm.Show();
        }

        public void MateriaForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
        }
    }
}
