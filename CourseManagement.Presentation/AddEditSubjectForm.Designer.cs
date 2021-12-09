
namespace CourseManagement.Presentation
{
    partial class AddEditSubjectForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.numCode = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddEditSubjet = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbxSemestre = new System.Windows.Forms.ComboBox();
            this.cbxTeacher = new System.Windows.Forms.ComboBox();
            this.cbxYear = new System.Windows.Forms.ComboBox();
            this.chbCursada = new System.Windows.Forms.CheckBox();
            this.chbSubAprove = new System.Windows.Forms.CheckBox();
            this.cbxDays = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numCode)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Código";
            // 
            // numCode
            // 
            this.numCode.Location = new System.Drawing.Point(193, 47);
            this.numCode.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numCode.Name = "numCode";
            this.numCode.Size = new System.Drawing.Size(120, 20);
            this.numCode.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre Materia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(70, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Día Cursada";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 245);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Profesor";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(70, 199);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Cuatrimestre";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 297);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Año";
            // 
            // btnAddEditSubjet
            // 
            this.btnAddEditSubjet.Location = new System.Drawing.Point(151, 442);
            this.btnAddEditSubjet.Name = "btnAddEditSubjet";
            this.btnAddEditSubjet.Size = new System.Drawing.Size(75, 23);
            this.btnAddEditSubjet.TabIndex = 14;
            this.btnAddEditSubjet.Text = "Agregar";
            this.btnAddEditSubjet.UseVisualStyleBackColor = true;
            this.btnAddEditSubjet.Click += new System.EventHandler(this.btnAddEditSubjet_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(191, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(122, 20);
            this.txtName.TabIndex = 15;
            // 
            // cbxSemestre
            // 
            this.cbxSemestre.FormattingEnabled = true;
            this.cbxSemestre.Location = new System.Drawing.Point(191, 196);
            this.cbxSemestre.Name = "cbxSemestre";
            this.cbxSemestre.Size = new System.Drawing.Size(121, 21);
            this.cbxSemestre.TabIndex = 17;
            // 
            // cbxTeacher
            // 
            this.cbxTeacher.FormattingEnabled = true;
            this.cbxTeacher.Location = new System.Drawing.Point(191, 242);
            this.cbxTeacher.Name = "cbxTeacher";
            this.cbxTeacher.Size = new System.Drawing.Size(121, 21);
            this.cbxTeacher.TabIndex = 18;
            // 
            // cbxYear
            // 
            this.cbxYear.FormattingEnabled = true;
            this.cbxYear.Location = new System.Drawing.Point(192, 294);
            this.cbxYear.Name = "cbxYear";
            this.cbxYear.Size = new System.Drawing.Size(121, 21);
            this.cbxYear.TabIndex = 19;
            // 
            // chbCursada
            // 
            this.chbCursada.AutoSize = true;
            this.chbCursada.Location = new System.Drawing.Point(194, 336);
            this.chbCursada.Name = "chbCursada";
            this.chbCursada.Size = new System.Drawing.Size(112, 17);
            this.chbCursada.TabIndex = 20;
            this.chbCursada.Text = "Cursada Completa";
            this.chbCursada.UseVisualStyleBackColor = true;
            // 
            // chbSubAprove
            // 
            this.chbSubAprove.AutoSize = true;
            this.chbSubAprove.Location = new System.Drawing.Point(192, 375);
            this.chbSubAprove.Name = "chbSubAprove";
            this.chbSubAprove.Size = new System.Drawing.Size(110, 17);
            this.chbSubAprove.TabIndex = 21;
            this.chbSubAprove.Text = "Materia Aprobada";
            this.chbSubAprove.UseVisualStyleBackColor = true;
            // 
            // cbxDays
            // 
            this.cbxDays.FormattingEnabled = true;
            this.cbxDays.Items.AddRange(new object[] {
            "Lunes",
            "Martes",
            "Miércoles",
            "Jueves",
            "Viernes"});
            this.cbxDays.Location = new System.Drawing.Point(191, 145);
            this.cbxDays.Name = "cbxDays";
            this.cbxDays.Size = new System.Drawing.Size(121, 21);
            this.cbxDays.TabIndex = 22;
            // 
            // AddEditSubjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(379, 507);
            this.Controls.Add(this.cbxDays);
            this.Controls.Add(this.chbSubAprove);
            this.Controls.Add(this.chbCursada);
            this.Controls.Add(this.cbxYear);
            this.Controls.Add(this.cbxTeacher);
            this.Controls.Add(this.cbxSemestre);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.btnAddEditSubjet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numCode);
            this.Name = "AddEditSubjectForm";
            this.Text = "AddEditSubjectForm";
            ((System.ComponentModel.ISupportInitialize)(this.numCode)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnAddEditSubjet;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbxSemestre;
        private System.Windows.Forms.ComboBox cbxTeacher;
        private System.Windows.Forms.ComboBox cbxYear;
        private System.Windows.Forms.CheckBox chbCursada;
        private System.Windows.Forms.CheckBox chbSubAprove;
        private System.Windows.Forms.ComboBox cbxDays;
    }
}