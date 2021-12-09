using CourseManagement.Business;
using CourseManagement.Core.Models;
using System;
using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public partial class AddEditTeacherForm : Form
    {
        private readonly bool IsEdit;
        private Profesor Teacher;
        public AddEditTeacherForm(bool isEdit, Profesor teacher)
        {
            InitializeComponent();
            IsEdit = isEdit;
            Teacher = teacher;
            StartNames();
            InitImputs();
        }
        private void StartNames()
        {
            this.Text = IsEdit ? "Editar Profesor" : "Nuevo Profesor";
            btnAddEditTeacher.Text = IsEdit ? "Guardar" : "Agregar";
        }
        private void InitImputs()
        {
            numCode.Enabled = false;
            numCode.Value = Teacher.Id;
            txtName.Text = Teacher.Nombre;
            txtLastName.Text = Teacher.Apellido;
        }
        private void btnAddEditTeacher_Click(object sender, EventArgs e)
        {
            if (FormIsComplete())
            {
                Profesor teacher = new Profesor()
                {
                    Id = Convert.ToInt32(numCode.Value),
                    Nombre = txtName.Text,
                    Apellido = txtLastName.Text,
                };
                bool result = IsEdit ? ProfesorService.UpdateTeacher(teacher) : ProfesorService.InsertTeacher(teacher);
                if (result) Message.Ok($"Se grabó el registro correctamente");
                else Message.Error($"Error, no se pudo grabar el registro");
                Close();
            }
            else Message.Warning($"Debe completar el formulario para insertar");
        }
        private bool FormIsComplete()
        {
            if (string.IsNullOrEmpty(txtName.Text)) return false;
            if (string.IsNullOrEmpty(txtLastName.Text)) return false;
            return true;
        }
    }
}
