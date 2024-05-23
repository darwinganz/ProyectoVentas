namespace Academico.Presentacion
{
    partial class Frm_Estudiantes
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
            this.btnListar = new System.Windows.Forms.Button();
            this.dataEstudiantes = new System.Windows.Forms.DataGridView();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNum_doc = new System.Windows.Forms.TextBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dbFisUplaDataSet = new Ventas.UI.dbFisUplaDataSet();
            this.dbFisUplaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFisUplaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFisUplaDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnListar.Location = new System.Drawing.Point(337, 17);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(88, 23);
            this.btnListar.TabIndex = 0;
            this.btnListar.Text = "LISTAR";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // dataEstudiantes
            // 
            this.dataEstudiantes.AutoGenerateColumns = false;
            this.dataEstudiantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataEstudiantes.DataSource = this.dbFisUplaDataSetBindingSource;
            this.dataEstudiantes.Location = new System.Drawing.Point(17, 59);
            this.dataEstudiantes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dataEstudiantes.Name = "dataEstudiantes";
            this.dataEstudiantes.Size = new System.Drawing.Size(467, 192);
            this.dataEstudiantes.TabIndex = 1;
            this.dataEstudiantes.DoubleClick += new System.EventHandler(this.dataEstudiantes_DoubleClick);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(93, 17);
            this.txtBuscar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(191, 20);
            this.txtBuscar.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(15, 270);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "CODIGO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(141, 270);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "NOMBRES";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(15, 333);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "NUM_DOC";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(141, 336);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "EMAIL";
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnNuevo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNuevo.Location = new System.Drawing.Point(399, 317);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(71, 23);
            this.btnNuevo.TabIndex = 8;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnActualizar.Location = new System.Drawing.Point(399, 362);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(71, 23);
            this.btnActualizar.TabIndex = 9;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(15, 397);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "ESTADO";
            // 
            // txtNombres
            // 
            this.txtNombres.Location = new System.Drawing.Point(144, 302);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(191, 20);
            this.txtNombres.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(144, 365);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(191, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(18, 302);
            this.txtId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(98, 20);
            this.txtId.TabIndex = 13;
            // 
            // txtNum_doc
            // 
            this.txtNum_doc.Location = new System.Drawing.Point(17, 365);
            this.txtNum_doc.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNum_doc.Name = "txtNum_doc";
            this.txtNum_doc.Size = new System.Drawing.Size(98, 20);
            this.txtNum_doc.TabIndex = 14;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(82, 395);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 15;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(15, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "NOMBRE";
            // 
            // dbFisUplaDataSet
            // 
            this.dbFisUplaDataSet.DataSetName = "dbFisUplaDataSet";
            this.dbFisUplaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dbFisUplaDataSetBindingSource
            // 
            this.dbFisUplaDataSetBindingSource.DataSource = this.dbFisUplaDataSet;
            this.dbFisUplaDataSetBindingSource.Position = 0;
            // 
            // Frm_Estudiantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 433);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.txtNum_doc);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.dataEstudiantes);
            this.Controls.Add(this.btnListar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_Estudiantes";
            this.Text = "MANTENIMEINTO DE ESTUDIANTES";
            ((System.ComponentModel.ISupportInitialize)(this.dataEstudiantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFisUplaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbFisUplaDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.DataGridView dataEstudiantes;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNum_doc;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource dbFisUplaDataSetBindingSource;
        private Ventas.UI.dbFisUplaDataSet dbFisUplaDataSet;
    }
}