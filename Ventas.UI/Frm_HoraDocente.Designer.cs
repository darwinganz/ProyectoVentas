namespace Academico.Presentacion
{
    partial class Frm_HoraDocente
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
            this.components = new System.ComponentModel.Container();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNum_doc = new System.Windows.Forms.TextBox();
            this.hora_entrada = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(420, 103);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(99, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 137);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hora de ingreso";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(41, 175);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(52, 24);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "hora";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 38);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(312, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Por favor ingrese numero de documento";
            // 
            // txtNum_doc
            // 
            this.txtNum_doc.Location = new System.Drawing.Point(45, 76);
            this.txtNum_doc.Name = "txtNum_doc";
            this.txtNum_doc.Size = new System.Drawing.Size(261, 20);
            this.txtNum_doc.TabIndex = 4;
            // 
            // hora_entrada
            // 
            this.hora_entrada.Enabled = true;
            this.hora_entrada.Tick += new System.EventHandler(this.hora_entrada_Tick);
            // 
            // Frm_HoraDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 231);
            this.Controls.Add(this.txtNum_doc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblHora);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistrar);
            this.Name = "Frm_HoraDocente";
            this.Text = "MANTENIMIENTO DE HORARIOS DOCENTES";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum_doc;
        private System.Windows.Forms.Timer hora_entrada;
    }
}