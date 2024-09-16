using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_Inicio
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(wf_Inicio));
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.btn_Busqueda = new System.Windows.Forms.Button();
            this.btn_AgregarArticulo = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_Creditos = new System.Windows.Forms.ToolStripStatusLabel();
            this.btn_EliminarArticulo = new System.Windows.Forms.Button();
            this.btn_ModificarArticulo = new System.Windows.Forms.Button();
            this.btn_MarcasCategorias = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gb_AdmArticulos = new System.Windows.Forms.GroupBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_DetallesArticulos = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.gb_AdmArticulos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Tahoma", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(21, 16);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(173, 29);
            this.lbl_Titulo.TabIndex = 1;
            this.lbl_Titulo.Text = "Bienvenido/a";
            // 
            // btn_Busqueda
            // 
            this.btn_Busqueda.BackColor = System.Drawing.Color.DarkGray;
            this.btn_Busqueda.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Busqueda.FlatAppearance.BorderSize = 2;
            this.btn_Busqueda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Busqueda.Location = new System.Drawing.Point(21, 93);
            this.btn_Busqueda.Name = "btn_Busqueda";
            this.btn_Busqueda.Padding = new System.Windows.Forms.Padding(0, 90, 0, 0);
            this.btn_Busqueda.Size = new System.Drawing.Size(332, 147);
            this.btn_Busqueda.TabIndex = 2;
            this.btn_Busqueda.Text = "Busqueda";
            this.btn_Busqueda.UseVisualStyleBackColor = false;
            this.btn_Busqueda.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // btn_AgregarArticulo
            // 
            this.btn_AgregarArticulo.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btn_AgregarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarArticulo.Location = new System.Drawing.Point(5, 34);
            this.btn_AgregarArticulo.Name = "btn_AgregarArticulo";
            this.btn_AgregarArticulo.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.btn_AgregarArticulo.Size = new System.Drawing.Size(116, 110);
            this.btn_AgregarArticulo.TabIndex = 4;
            this.btn_AgregarArticulo.Text = "Agregar";
            this.btn_AgregarArticulo.UseVisualStyleBackColor = false;
            this.btn_AgregarArticulo.Click += new System.EventHandler(this.btn_AgregarArticulo_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_Creditos});
            this.statusStrip1.Location = new System.Drawing.Point(0, 459);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(756, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_Creditos
            // 
            this.lbl_Creditos.Name = "lbl_Creditos";
            this.lbl_Creditos.Size = new System.Drawing.Size(57, 17);
            this.lbl_Creditos.Text = "Grupo 2A";
            // 
            // btn_EliminarArticulo
            // 
            this.btn_EliminarArticulo.BackColor = System.Drawing.Color.Tomato;
            this.btn_EliminarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarArticulo.Location = new System.Drawing.Point(127, 34);
            this.btn_EliminarArticulo.Name = "btn_EliminarArticulo";
            this.btn_EliminarArticulo.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.btn_EliminarArticulo.Size = new System.Drawing.Size(116, 110);
            this.btn_EliminarArticulo.TabIndex = 7;
            this.btn_EliminarArticulo.Text = "Eliminar";
            this.btn_EliminarArticulo.UseVisualStyleBackColor = false;
            this.btn_EliminarArticulo.Click += new System.EventHandler(this.btn_EliminarArticulo_Click);
            // 
            // btn_ModificarArticulo
            // 
            this.btn_ModificarArticulo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ModificarArticulo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ModificarArticulo.Location = new System.Drawing.Point(249, 34);
            this.btn_ModificarArticulo.Name = "btn_ModificarArticulo";
            this.btn_ModificarArticulo.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.btn_ModificarArticulo.Size = new System.Drawing.Size(116, 110);
            this.btn_ModificarArticulo.TabIndex = 8;
            this.btn_ModificarArticulo.Text = "Modificar";
            this.btn_ModificarArticulo.UseVisualStyleBackColor = false;
            this.btn_ModificarArticulo.Click += new System.EventHandler(this.btn_ModificarArticulo_Click);
            // 
            // btn_MarcasCategorias
            // 
            this.btn_MarcasCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_MarcasCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MarcasCategorias.Location = new System.Drawing.Point(540, 301);
            this.btn_MarcasCategorias.Name = "btn_MarcasCategorias";
            this.btn_MarcasCategorias.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.btn_MarcasCategorias.Size = new System.Drawing.Size(191, 110);
            this.btn_MarcasCategorias.TabIndex = 9;
            this.btn_MarcasCategorias.Text = "Marcas / Categorias";
            this.btn_MarcasCategorias.UseVisualStyleBackColor = false;
            this.btn_MarcasCategorias.Click += new System.EventHandler(this.btn_MarcasCategorias_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 10;
            this.label2.Text = "Administracion de Articulos";
            // 
            // gb_AdmArticulos
            // 
            this.gb_AdmArticulos.Controls.Add(this.pictureBox4);
            this.gb_AdmArticulos.Controls.Add(this.pictureBox3);
            this.gb_AdmArticulos.Controls.Add(this.pictureBox2);
            this.gb_AdmArticulos.Controls.Add(this.label2);
            this.gb_AdmArticulos.Controls.Add(this.btn_ModificarArticulo);
            this.gb_AdmArticulos.Controls.Add(this.btn_EliminarArticulo);
            this.gb_AdmArticulos.Controls.Add(this.btn_AgregarArticulo);
            this.gb_AdmArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gb_AdmArticulos.Location = new System.Drawing.Point(368, 88);
            this.gb_AdmArticulos.Name = "gb_AdmArticulos";
            this.gb_AdmArticulos.Size = new System.Drawing.Size(373, 155);
            this.gb_AdmArticulos.TabIndex = 11;
            this.gb_AdmArticulos.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(271, 40);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(76, 77);
            this.pictureBox4.TabIndex = 16;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.btn_ModificarArticulo_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(148, 42);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(76, 75);
            this.pictureBox3.TabIndex = 15;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.btn_EliminarArticulo_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(25, 43);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(76, 75);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.btn_AgregarArticulo_Click);
            // 
            // btn_DetallesArticulos
            // 
            this.btn_DetallesArticulos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_DetallesArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DetallesArticulos.Location = new System.Drawing.Point(21, 301);
            this.btn_DetallesArticulos.Name = "btn_DetallesArticulos";
            this.btn_DetallesArticulos.Padding = new System.Windows.Forms.Padding(0, 70, 0, 0);
            this.btn_DetallesArticulos.Size = new System.Drawing.Size(468, 110);
            this.btn_DetallesArticulos.TabIndex = 12;
            this.btn_DetallesArticulos.Text = "Detalles";
            this.btn_DetallesArticulos.UseVisualStyleBackColor = false;
            this.btn_DetallesArticulos.Click += new System.EventHandler(this.btn_DetallesArticulos_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(137, 111);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 78);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.btn_Busqueda_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(582, 307);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(108, 75);
            this.pictureBox5.TabIndex = 17;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.btn_MarcasCategorias_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(205, 308);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(108, 75);
            this.pictureBox6.TabIndex = 18;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.btn_DetallesArticulos_Click);
            // 
            // wf_Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(756, 481);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_DetallesArticulos);
            this.Controls.Add(this.gb_AdmArticulos);
            this.Controls.Add(this.btn_MarcasCategorias);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_Busqueda);
            this.Controls.Add(this.lbl_Titulo);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(772, 544);
            this.MinimumSize = new System.Drawing.Size(772, 520);
            this.Name = "wf_Inicio";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Inicio";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gb_AdmArticulos.ResumeLayout(false);
            this.gb_AdmArticulos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_Titulo;
        private Button btn_Busqueda;
        private Button btn_AgregarArticulo;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel lbl_Creditos;
        private Button btn_EliminarArticulo;
        private Button btn_ModificarArticulo;
        private Button btn_MarcasCategorias;
        private Label label2;
        private GroupBox gb_AdmArticulos;
        private Button btn_DetallesArticulos;
        private PictureBox pictureBox5;
        private PictureBox pictureBox4;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox6;
    }
}