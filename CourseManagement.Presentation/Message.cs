using System.Windows.Forms;

namespace CourseManagement.Presentation
{
    public static class Message
    {
        public static bool Validation(string msg)
        {
            return MessageBox.Show(msg, "Sistema de materias", MessageBoxButtons.YesNo) == DialogResult.Yes;
        }
        public static void Ok(string msg)
        {
            MessageBox.Show(msg, "Sistema de materias", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        public static void Warning(string msg)
        {
            MessageBox.Show(msg, "Sistema de materias", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        public static void Error(string msg)
        {
            MessageBox.Show(msg, "Sistema de materias", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
