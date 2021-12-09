using CourseManagement.Business;
using CourseManagement.Core.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public partial class ProfesoresForm : Form
    {
        public ProfesoresForm()
        {
            InitializeComponent();
            ReloadList();
        }
        private void ReloadList()
        {
            List<Profesor> teachers = ProfesorService.GetAllTeachs();
            dgvProfesor.DataSource = teachers;
            ButtonCriteria(isSelected: false);
        }
        private void ButtonCriteria(bool isSelected)
        {
            btnEditarProfesor.Enabled = isSelected;
            btnEliminarProfesor.Enabled = isSelected;
        }

        private void dgvProfesor_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            ButtonCriteria(dgvProfesor.SelectedRows.Count == 1);
        }
        private void btnEliminarProfesor_Click(object sender, EventArgs e)
        {
            if (Message.Validation("¿Esta seguro que quiere eliminar el registro?"))
            {
                string id = dgvProfesor.CurrentRow.Cells["Id"].Value.ToString();
                bool result = ProfesorService.DeleteTeacher(id);
                if (result)
                {
                    ReloadList();
                    Message.Ok("Se eliminó el registro correctamente");
                }
                else Message.Error("Error, no se puedo eliminar el registro");
            }
        }
        private void btnAgregarProfesor_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            AddEditTeacherForm addEditTeacherForm = new AddEditTeacherForm(isEdit: false, teacher: new Profesor());
            addEditTeacherForm.FormClosing += addEditTeacherForm_FormClosing;
            addEditTeacherForm.Show();
        }
        private void btnEditarProfesor_Click(object sender, EventArgs e)
        {
            this.Enabled = false;
            Profesor teacher = new Profesor()
            {
                Id = Convert.ToInt32(dgvProfesor.CurrentRow.Cells["Id"].Value.ToString()),
                Nombre = dgvProfesor.CurrentRow.Cells["Nombre"].Value.ToString(),
                Apellido = dgvProfesor.CurrentRow.Cells["Apellido"].Value.ToString(),
            };
            AddEditTeacherForm addEditTeacherForm = new AddEditTeacherForm(isEdit: true, teacher: teacher);
            addEditTeacherForm.FormClosing += addEditTeacherForm_FormClosing;
            addEditTeacherForm.Show();
        }
        public void addEditTeacherForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Enabled = true;
            ReloadList();
        }
        private void txtBuscarProfesor_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrEmpty(txtBuscarProfesor.Text))
            {
                List<Profesor> teachers = ProfesorService.GetTeachersByFilter(txtBuscarProfesor.Text);
                dgvProfesor.DataSource = teachers;
                ButtonCriteria(isSelected: false);
            }
            else
                ReloadList();
        }
    }
}
