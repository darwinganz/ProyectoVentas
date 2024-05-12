
namespace Ventas.UI
{
    partial class Frm_Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Productos = new System.Windows.Forms.Button();
            this.btn_Categorias = new System.Windows.Forms.Button();
            this.lbl_miperfil = new System.Windows.Forms.Label();
            this.lbl_user = new System.Windows.Forms.Label();
            this.PicUser = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btn_cerrar);
            this.panel1.Controls.Add(this.PicLogo);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1842, 105);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 11.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(261, 50);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 34);
            this.label4.TabIndex = 407;
            this.label4.Text = "Versión 0.5";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cerrar.AutoEllipsis = true;
            this.btn_cerrar.BackgroundImage = global::Ventas.UI.Properties.Resources._001_29;
            this.btn_cerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_cerrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cerrar.FlatAppearance.BorderSize = 0;
            this.btn_cerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_cerrar.Location = new System.Drawing.Point(1490, 12);
            this.btn_cerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(43, 33);
            this.btn_cerrar.TabIndex = 406;
            this.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_cerrar.UseVisualStyleBackColor = true;
            this.btn_cerrar.Click += new System.EventHandler(this.btn_cerrar_Click_1);
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.Transparent;
            this.PicLogo.ForeColor = System.Drawing.Color.Black;
            this.PicLogo.Image = ((System.Drawing.Image)(resources.GetObject("PicLogo.Image")));
            this.PicLogo.Location = new System.Drawing.Point(1247, -1);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(4);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(229, 105);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicLogo.TabIndex = 4;
            this.PicLogo.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label2.Location = new System.Drawing.Point(244, 12);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(362, 51);
            this.label2.TabIndex = 404;
            this.label2.Text = "SISTEMA ACADEMICO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel2.Controls.Add(this.btn_Productos);
            this.panel2.Controls.Add(this.btn_Categorias);
            this.panel2.Controls.Add(this.lbl_miperfil);
            this.panel2.Controls.Add(this.lbl_user);
            this.panel2.Controls.Add(this.PicUser);
            this.panel2.Location = new System.Drawing.Point(0, 1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(253, 1193);
            this.panel2.TabIndex = 2;
            // 
            // btn_Productos
            // 
            this.btn_Productos.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Productos.FlatAppearance.BorderSize = 0;
            this.btn_Productos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Productos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Productos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Productos.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Productos.ForeColor = System.Drawing.Color.Black;
            this.btn_Productos.Image = ((System.Drawing.Image)(resources.GetObject("btn_Productos.Image")));
            this.btn_Productos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos.Location = new System.Drawing.Point(40, 254);
            this.btn_Productos.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Productos.Name = "btn_Productos";
            this.btn_Productos.Size = new System.Drawing.Size(174, 39);
            this.btn_Productos.TabIndex = 402;
            this.btn_Productos.Text = "      Docentes";
            this.btn_Productos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Productos.UseVisualStyleBackColor = true;
            this.btn_Productos.Click += new System.EventHandler(this.btn_Productos_Click);
            // 
            // btn_Categorias
            // 
            this.btn_Categorias.FlatAppearance.BorderColor = System.Drawing.Color.Gainsboro;
            this.btn_Categorias.FlatAppearance.BorderSize = 0;
            this.btn_Categorias.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Categorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gainsboro;
            this.btn_Categorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Categorias.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Categorias.ForeColor = System.Drawing.Color.Black;
            this.btn_Categorias.Image = ((System.Drawing.Image)(resources.GetObject("btn_Categorias.Image")));
            this.btn_Categorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categorias.Location = new System.Drawing.Point(40, 207);
            this.btn_Categorias.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Categorias.Name = "btn_Categorias";
            this.btn_Categorias.Size = new System.Drawing.Size(192, 39);
            this.btn_Categorias.TabIndex = 401;
            this.btn_Categorias.Text = "      Estudiantes";
            this.btn_Categorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Categorias.UseVisualStyleBackColor = true;
            this.btn_Categorias.Click += new System.EventHandler(this.btn_Categorias_Click);
            // 
            // lbl_miperfil
            // 
            this.lbl_miperfil.AutoSize = true;
            this.lbl_miperfil.BackColor = System.Drawing.Color.Transparent;
            this.lbl_miperfil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_miperfil.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_miperfil.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_miperfil.Location = new System.Drawing.Point(80, 136);
            this.lbl_miperfil.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_miperfil.Name = "lbl_miperfil";
            this.lbl_miperfil.Size = new System.Drawing.Size(78, 22);
            this.lbl_miperfil.TabIndex = 18;
            this.lbl_miperfil.Text = "Mi perfil";
            this.lbl_miperfil.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_user
            // 
            this.lbl_user.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_user.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lbl_user.Location = new System.Drawing.Point(23, 107);
            this.lbl_user.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_user.Name = "lbl_user";
            this.lbl_user.Size = new System.Drawing.Size(209, 25);
            this.lbl_user.TabIndex = 17;
            this.lbl_user.Text = "Orlando Cordova A.";
            this.lbl_user.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PicUser
            // 
            this.PicUser.Image = ((System.Drawing.Image)(resources.GetObject("PicUser.Image")));
            this.PicUser.Location = new System.Drawing.Point(72, 13);
            this.PicUser.Margin = new System.Windows.Forms.Padding(4);
            this.PicUser.Name = "PicUser";
            this.PicUser.Size = new System.Drawing.Size(95, 86);
            this.PicUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicUser.TabIndex = 16;
            this.PicUser.TabStop = false;
            // 
            // Frm_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1792, 862);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Frm_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_Principal";
            this.Load += new System.EventHandler(this.Frm_Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicUser)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        internal System.Windows.Forms.Button btn_Productos;
        internal System.Windows.Forms.Button btn_Categorias;
        internal System.Windows.Forms.Label lbl_miperfil;
        internal System.Windows.Forms.Label lbl_user;
        internal System.Windows.Forms.PictureBox PicUser;
        internal System.Windows.Forms.PictureBox PicLogo;
        internal System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cerrar;
        internal System.Windows.Forms.Label label4;
    }
}