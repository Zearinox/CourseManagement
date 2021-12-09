
namespace CourseManagement.Presentation
{
    partial class MateriasForm
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
            this.dgvMateria = new System.Windows.Forms.DataGridView();
            this.btnEditarMateria = new System.Windows.Forms.Button();
            this.btnEliminarMateria = new System.Windows.Forms.Button();
            this.btnAgregarMateria = new System.Windows.Forms.Button();
            this.txtBuscarMateria = new System.Windows.Forms.TextBox();
            this.cbobuscar = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnProf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMateria
            // 
            this.dgvMateria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMateria.Location = new System.Drawing.Point(27, 180);
            this.dgvMateria.Name = "dgvMateria";
            this.dgvMateria.Size = new System.Drawing.Size(744, 237);
            this.dgvMateria.TabIndex = 0;
            this.dgvMateria.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMateria_CellClick);
            this.dgvMateria.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvMateria_CellFormatting);
            // 
            // btnEditarMateria
            // 
            this.btnEditarMateria.Location = new System.Drawing.Point(27, 135);
            this.btnEditarMateria.Name = "btnEditarMateria";
            this.btnEditarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnEditarMateria.TabIndex = 10;
            this.btnEditarMateria.Text = "Editar";
            this.btnEditarMateria.UseVisualStyleBackColor = true;
            this.btnEditarMateria.Click += new System.EventHandler(this.btnEditarMateria_Click);
            // 
            // btnEliminarMateria
            // 
            this.btnEliminarMateria.Location = new System.Drawing.Point(108, 135);
            this.btnEliminarMateria.Name = "btnEliminarMateria";
            this.btnEliminarMateria.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarMateria.TabIndex = 9;
            this.btnEliminarMateria.Text = "Eliminar";
            this.btnEliminarMateria.UseVisualStyleBackColor = true;
            this.btnEliminarMateria.Click += new System.EventHandler(this.btnEliminarMateria_Click);
            // 
            // btnAgregarMateria
            // 
            this.btnAgregarMateria.Location = new System.Drawing.Point(222, 130);
            this.btnAgregarMateria.Name = "btnAgregarMateria";
            this.btnAgregarMateria.Size = new System.Drawing.Size(93, 33);
            this.btnAgregarMateria.TabIndex = 11;
            this.btnAgregarMateria.Text = "Agregar Materia";
            this.btnAgregarMateria.UseVisualStyleBackColor = true;
            this.btnAgregarMateria.Click += new System.EventHandler(this.btnAgregarMateria_Click);
            // 
            // txtBuscarMateria
            // 
            this.txtBuscarMateria.Location = new System.Drawing.Point(123, 85);
            this.txtBuscarMateria.Name = "txtBuscarMateria";
            this.txtBuscarMateria.Size = new System.Drawing.Size(319, 20);
            this.txtBuscarMateria.TabIndex = 13;
            this.txtBuscarMateria.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarMateria_KeyUp);
            // 
            // cbobuscar
            // 
            this.cbobuscar.FormattingEnabled = true;
            this.cbobuscar.Items.AddRange(new object[] {
            "MATERIA",
            "PROFESOR"});
            this.cbobuscar.Location = new System.Drawing.Point(465, 85);
            this.cbobuscar.Name = "cbobuscar";
            this.cbobuscar.Size = new System.Drawing.Size(121, 21);
            this.cbobuscar.TabIndex = 12;
            this.cbobuscar.Text = "Materia";
            this.cbobuscar.SelectedIndexChanged += new System.EventHandler(this.cbobuscar_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Buscar    --->";
            // 
            // btnProf
            // 
            this.btnProf.BackColor = System.Drawing.Color.Orange;
            this.btnProf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProf.ForeColor = System.Drawing.Color.Black;
            this.btnProf.Location = new System.Drawing.Point(670, 57);
            this.btnProf.Name = "btnProf";
            this.btnProf.Size = new System.Drawing.Size(101, 74);
            this.btnProf.TabIndex = 15;
            this.btnProf.Text = "Profesores";
            this.btnProf.UseVisualStyleBackColor = false;
            this.btnProf.Click += new System.EventHandler(this.btnProf_Click);
            // 
            // MateriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnProf);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarMateria);
            this.Controls.Add(this.cbobuscar);
            this.Controls.Add(this.btnAgregarMateria);
            this.Controls.Add(this.btnEditarMateria);
            this.Controls.Add(this.btnEliminarMateria);
            this.Controls.Add(this.dgvMateria);
            this.Name = "MateriasForm";
            this.Text = "Materias";
            ((System.ComponentModel.ISupportInitialize)(this.dgvMateria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMateria;
        private System.Windows.Forms.Button btnEditarMateria;
        private System.Windows.Forms.Button btnEliminarMateria;
        private System.Windows.Forms.Button btnAgregarMateria;
        private System.Windows.Forms.TextBox txtBuscarMateria;
        private System.Windows.Forms.ComboBox cbobuscar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnProf;
    }
}