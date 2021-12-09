
namespace CourseManagement.Presentation
{
    partial class ProfesoresForm
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
            this.txtBuscarProfesor = new System.Windows.Forms.TextBox();
            this.btnAgregarProfesor = new System.Windows.Forms.Button();
            this.btnEditarProfesor = new System.Windows.Forms.Button();
            this.btnEliminarProfesor = new System.Windows.Forms.Button();
            this.dgvProfesor = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBuscarProfesor
            // 
            this.txtBuscarProfesor.Location = new System.Drawing.Point(137, 86);
            this.txtBuscarProfesor.Name = "txtBuscarProfesor";
            this.txtBuscarProfesor.Size = new System.Drawing.Size(343, 20);
            this.txtBuscarProfesor.TabIndex = 21;
            this.txtBuscarProfesor.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtBuscarProfesor_KeyUp);
            // 
            // btnAgregarProfesor
            // 
            this.btnAgregarProfesor.Location = new System.Drawing.Point(651, 49);
            this.btnAgregarProfesor.Name = "btnAgregarProfesor";
            this.btnAgregarProfesor.Size = new System.Drawing.Size(111, 33);
            this.btnAgregarProfesor.TabIndex = 19;
            this.btnAgregarProfesor.Text = "Agregar Profesor";
            this.btnAgregarProfesor.UseVisualStyleBackColor = true;
            this.btnAgregarProfesor.Click += new System.EventHandler(this.btnAgregarProfesor_Click);
            // 
            // btnEditarProfesor
            // 
            this.btnEditarProfesor.Location = new System.Drawing.Point(30, 147);
            this.btnEditarProfesor.Name = "btnEditarProfesor";
            this.btnEditarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnEditarProfesor.TabIndex = 18;
            this.btnEditarProfesor.Text = "Editar";
            this.btnEditarProfesor.UseVisualStyleBackColor = true;
            this.btnEditarProfesor.Click += new System.EventHandler(this.btnEditarProfesor_Click);
            // 
            // btnEliminarProfesor
            // 
            this.btnEliminarProfesor.Location = new System.Drawing.Point(111, 147);
            this.btnEliminarProfesor.Name = "btnEliminarProfesor";
            this.btnEliminarProfesor.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProfesor.TabIndex = 17;
            this.btnEliminarProfesor.Text = "Eliminar";
            this.btnEliminarProfesor.UseVisualStyleBackColor = true;
            this.btnEliminarProfesor.Click += new System.EventHandler(this.btnEliminarProfesor_Click);
            // 
            // dgvProfesor
            // 
            this.dgvProfesor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProfesor.Location = new System.Drawing.Point(30, 192);
            this.dgvProfesor.Name = "dgvProfesor";
            this.dgvProfesor.Size = new System.Drawing.Size(744, 237);
            this.dgvProfesor.TabIndex = 16;
            this.dgvProfesor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProfesor_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Buscar Profesor...";
            // 
            // ProfesoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBuscarProfesor);
            this.Controls.Add(this.btnAgregarProfesor);
            this.Controls.Add(this.btnEditarProfesor);
            this.Controls.Add(this.btnEliminarProfesor);
            this.Controls.Add(this.dgvProfesor);
            this.Name = "ProfesoresForm";
            this.Text = "Profesores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvProfesor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBuscarProfesor;
        private System.Windows.Forms.Button btnAgregarProfesor;
        private System.Windows.Forms.Button btnEditarProfesor;
        private System.Windows.Forms.Button btnEliminarProfesor;
        private System.Windows.Forms.DataGridView dgvProfesor;
        private System.Windows.Forms.Label label1;
    }
}