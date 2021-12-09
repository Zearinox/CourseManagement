
namespace CourseManagement.Presentation
{
    partial class AddEditTeacherForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.btnAddEditTeacher = new System.Windows.Forms.Button();
            this.numCode = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCode)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(203, 111);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(203, 175);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(120, 20);
            this.txtLastName.TabIndex = 1;
            // 
            // btnAddEditTeacher
            // 
            this.btnAddEditTeacher.Location = new System.Drawing.Point(165, 264);
            this.btnAddEditTeacher.Name = "btnAddEditTeacher";
            this.btnAddEditTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditTeacher.TabIndex = 2;
            this.btnAddEditTeacher.Text = "Agregar";
            this.btnAddEditTeacher.UseVisualStyleBackColor = true;
            this.btnAddEditTeacher.Click += new System.EventHandler(this.btnAddEditTeacher_Click);
            // 
            // numCode
            // 
            this.numCode.Location = new System.Drawing.Point(203, 48);
            this.numCode.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCode.Name = "numCode";
            this.numCode.Size = new System.Drawing.Size(120, 20);
            this.numCode.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Apellido";
            // 
            // AddEditTeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 352);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCode);
            this.Controls.Add(this.btnAddEditTeacher);
            this.Controls.Add(this.txtLastName);
            this.Controls.Add(this.txtName);
            this.Name = "AddEditTeacherForm";
            this.Text = "Nuevo Profesor";
            ((System.ComponentModel.ISupportInitialize)(this.numCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Button btnAddEditTeacher;
        private System.Windows.Forms.NumericUpDown numCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}