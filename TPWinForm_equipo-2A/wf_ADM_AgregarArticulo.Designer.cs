using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_ADM_AgregarArticulo
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
            this.lbl_NombreNA = new System.Windows.Forms.Label();
            this.btnAgregarNA = new System.Windows.Forms.Button();
            this.input_NombreNA = new System.Windows.Forms.TextBox();
            this.lbl_NuevoArticulo = new System.Windows.Forms.Label();
            this.lbl_DescripcionNA = new System.Windows.Forms.Label();
            this.input_DescripcionNA = new System.Windows.Forms.TextBox();
            this.lbl_MarcaNA = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_PrecioNA = new System.Windows.Forms.Label();
            this.input_PrecioNA = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ImagenNA = new System.Windows.Forms.Label();
            this.input_CodigoNA = new System.Windows.Forms.TextBox();
            this.lbl_CodigoNA = new System.Windows.Forms.Label();
            this.cb_MarcaNA = new System.Windows.Forms.ComboBox();
            this.cb_CategoriaNA = new System.Windows.Forms.ComboBox();
            this.btn_BuscarImagenesLocal = new System.Windows.Forms.Button();
            this.input_UrlImagen = new System.Windows.Forms.TextBox();
            this.btn_ConfirmarImagen = new System.Windows.Forms.Button();
            this.lbl_confirmacionImagen = new System.Windows.Forms.Label();
            this.btn_descartarImagen = new System.Windows.Forms.Button();
            this.pb_VisorImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_VisorImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreNA
            // 
            this.lbl_NombreNA.AutoSize = true;
            this.lbl_NombreNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_NombreNA.Location = new System.Drawing.Point(51, 98);
            this.lbl_NombreNA.Name = "lbl_NombreNA";
            this.lbl_NombreNA.Size = new System.Drawing.Size(57, 16);
            this.lbl_NombreNA.TabIndex = 0;
            this.lbl_NombreNA.Text = "Nombre:";
            // 
            // btnAgregarNA
            // 
            this.btnAgregarNA.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNA.Location = new System.Drawing.Point(366, 536);
            this.btnAgregarNA.Name = "btnAgregarNA";
            this.btnAgregarNA.Size = new System.Drawing.Size(105, 40);
            this.btnAgregarNA.TabIndex = 2;
            this.btnAgregarNA.Text = "Agregar";
            this.btnAgregarNA.UseVisualStyleBackColor = false;
            this.btnAgregarNA.Click += new System.EventHandler(this.btnAgregarNA_Click);
            // 
            // input_NombreNA
            // 
            this.input_NombreNA.BackColor = System.Drawing.Color.White;
            this.input_NombreNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_NombreNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_NombreNA.Location = new System.Drawing.Point(108, 97);
            this.input_NombreNA.Name = "input_NombreNA";
            this.input_NombreNA.Size = new System.Drawing.Size(363, 22);
            this.input_NombreNA.TabIndex = 4;
            // 
            // lbl_NuevoArticulo
            // 
            this.lbl_NuevoArticulo.AutoSize = true;
            this.lbl_NuevoArticulo.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.lbl_NuevoArticulo.Location = new System.Drawing.Point(18, 21);
            this.lbl_NuevoArticulo.Name = "lbl_NuevoArticulo";
            this.lbl_NuevoArticulo.Size = new System.Drawing.Size(165, 25);
            this.lbl_NuevoArticulo.TabIndex = 7;
            this.lbl_NuevoArticulo.Text = "NUEVO ARTICULO :";
            // 
            // lbl_DescripcionNA
            // 
            this.lbl_DescripcionNA.AutoSize = true;
            this.lbl_DescripcionNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_DescripcionNA.Location = new System.Drawing.Point(31, 124);
            this.lbl_DescripcionNA.Name = "lbl_DescripcionNA";
            this.lbl_DescripcionNA.Size = new System.Drawing.Size(77, 16);
            this.lbl_DescripcionNA.TabIndex = 8;
            this.lbl_DescripcionNA.Text = "Descripción:";
            // 
            // input_DescripcionNA
            // 
            this.input_DescripcionNA.BackColor = System.Drawing.Color.White;
            this.input_DescripcionNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_DescripcionNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_DescripcionNA.Location = new System.Drawing.Point(108, 122);
            this.input_DescripcionNA.Multiline = true;
            this.input_DescripcionNA.Name = "input_DescripcionNA";
            this.input_DescripcionNA.Size = new System.Drawing.Size(363, 75);
            this.input_DescripcionNA.TabIndex = 9;
            // 
            // lbl_MarcaNA
            // 
            this.lbl_MarcaNA.AutoSize = true;
            this.lbl_MarcaNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_MarcaNA.Location = new System.Drawing.Point(61, 213);
            this.lbl_MarcaNA.Name = "lbl_MarcaNA";
            this.lbl_MarcaNA.Size = new System.Drawing.Size(47, 16);
            this.lbl_MarcaNA.TabIndex = 10;
            this.lbl_MarcaNA.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.label5.Location = new System.Drawing.Point(257, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Categoria:";
            // 
            // lbl_PrecioNA
            // 
            this.lbl_PrecioNA.AutoSize = true;
            this.lbl_PrecioNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_PrecioNA.Location = new System.Drawing.Point(60, 505);
            this.lbl_PrecioNA.Name = "lbl_PrecioNA";
            this.lbl_PrecioNA.Size = new System.Drawing.Size(47, 16);
            this.lbl_PrecioNA.TabIndex = 14;
            this.lbl_PrecioNA.Text = "Precio:";
            // 
            // input_PrecioNA
            // 
            this.input_PrecioNA.BackColor = System.Drawing.Color.White;
            this.input_PrecioNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_PrecioNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_PrecioNA.Location = new System.Drawing.Point(108, 504);
            this.input_PrecioNA.Name = "input_PrecioNA";
            this.input_PrecioNA.Size = new System.Drawing.Size(143, 22);
            this.input_PrecioNA.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(102, 256);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 13);
            this.label7.TabIndex = 16;
            // 
            // lbl_ImagenNA
            // 
            this.lbl_ImagenNA.AutoSize = true;
            this.lbl_ImagenNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_ImagenNA.Location = new System.Drawing.Point(53, 247);
            this.lbl_ImagenNA.Name = "lbl_ImagenNA";
            this.lbl_ImagenNA.Size = new System.Drawing.Size(55, 16);
            this.lbl_ImagenNA.TabIndex = 17;
            this.lbl_ImagenNA.Text = "Imagen:";
            // 
            // input_CodigoNA
            // 
            this.input_CodigoNA.BackColor = System.Drawing.Color.White;
            this.input_CodigoNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_CodigoNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_CodigoNA.Location = new System.Drawing.Point(108, 72);
            this.input_CodigoNA.Name = "input_CodigoNA";
            this.input_CodigoNA.Size = new System.Drawing.Size(363, 22);
            this.input_CodigoNA.TabIndex = 20;
            // 
            // lbl_CodigoNA
            // 
            this.lbl_CodigoNA.AutoSize = true;
            this.lbl_CodigoNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_CodigoNA.Location = new System.Drawing.Point(57, 73);
            this.lbl_CodigoNA.Name = "lbl_CodigoNA";
            this.lbl_CodigoNA.Size = new System.Drawing.Size(51, 16);
            this.lbl_CodigoNA.TabIndex = 19;
            this.lbl_CodigoNA.Text = "Codigo:";
            // 
            // cb_MarcaNA
            // 
            this.cb_MarcaNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_MarcaNA.FormattingEnabled = true;
            this.cb_MarcaNA.Location = new System.Drawing.Point(108, 212);
            this.cb_MarcaNA.Name = "cb_MarcaNA";
            this.cb_MarcaNA.Size = new System.Drawing.Size(143, 21);
            this.cb_MarcaNA.TabIndex = 22;
            // 
            // cb_CategoriaNA
            // 
            this.cb_CategoriaNA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_CategoriaNA.FormattingEnabled = true;
            this.cb_CategoriaNA.Location = new System.Drawing.Point(328, 212);
            this.cb_CategoriaNA.Name = "cb_CategoriaNA";
            this.cb_CategoriaNA.Size = new System.Drawing.Size(143, 21);
            this.cb_CategoriaNA.TabIndex = 23;
            // 
            // btn_BuscarImagenesLocal
            // 
            this.btn_BuscarImagenesLocal.Location = new System.Drawing.Point(314, 246);
            this.btn_BuscarImagenesLocal.Name = "btn_BuscarImagenesLocal";
            this.btn_BuscarImagenesLocal.Size = new System.Drawing.Size(53, 23);
            this.btn_BuscarImagenesLocal.TabIndex = 24;
            this.btn_BuscarImagenesLocal.Text = "buscar";
            this.btn_BuscarImagenesLocal.UseVisualStyleBackColor = true;
            // 
            // input_UrlImagen
            // 
            this.input_UrlImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_UrlImagen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_UrlImagen.ForeColor = System.Drawing.Color.Black;
            this.input_UrlImagen.Location = new System.Drawing.Point(108, 246);
            this.input_UrlImagen.Name = "input_UrlImagen";
            this.input_UrlImagen.Size = new System.Drawing.Size(200, 22);
            this.input_UrlImagen.TabIndex = 25;
            this.input_UrlImagen.WordWrap = false;
            this.input_UrlImagen.Leave += new System.EventHandler(this.input_UrlImagen_Leave);
            // 
            // btn_ConfirmarImagen
            // 
            this.btn_ConfirmarImagen.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarImagen.Location = new System.Drawing.Point(373, 400);
            this.btn_ConfirmarImagen.Name = "btn_ConfirmarImagen";
            this.btn_ConfirmarImagen.Size = new System.Drawing.Size(31, 23);
            this.btn_ConfirmarImagen.TabIndex = 27;
            this.btn_ConfirmarImagen.Text = "+";
            this.btn_ConfirmarImagen.UseVisualStyleBackColor = true;
            this.btn_ConfirmarImagen.Click += new System.EventHandler(this.btn_ConfirmarImagen_Click);
            // 
            // lbl_confirmacionImagen
            // 
            this.lbl_confirmacionImagen.Location = new System.Drawing.Point(392, 284);
            this.lbl_confirmacionImagen.Name = "lbl_confirmacionImagen";
            this.lbl_confirmacionImagen.Size = new System.Drawing.Size(100, 80);
            this.lbl_confirmacionImagen.TabIndex = 28;
            // 
            // btn_descartarImagen
            // 
            this.btn_descartarImagen.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_descartarImagen.Location = new System.Drawing.Point(373, 429);
            this.btn_descartarImagen.Name = "btn_descartarImagen";
            this.btn_descartarImagen.Size = new System.Drawing.Size(31, 23);
            this.btn_descartarImagen.TabIndex = 29;
            this.btn_descartarImagen.Text = "-";
            this.btn_descartarImagen.UseVisualStyleBackColor = true;
            this.btn_descartarImagen.Click += new System.EventHandler(this.btn_descartarImagen_Click);
            // 
            // pb_VisorImagen
            // 
            this.pb_VisorImagen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_VisorImagen.Location = new System.Drawing.Point(108, 275);
            this.pb_VisorImagen.Name = "pb_VisorImagen";
            this.pb_VisorImagen.Size = new System.Drawing.Size(259, 212);
            this.pb_VisorImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_VisorImagen.TabIndex = 30;
            this.pb_VisorImagen.TabStop = false;
            // 
            // wf_ADM_AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 598);
            this.Controls.Add(this.pb_VisorImagen);
            this.Controls.Add(this.btn_descartarImagen);
            this.Controls.Add(this.lbl_confirmacionImagen);
            this.Controls.Add(this.btn_ConfirmarImagen);
            this.Controls.Add(this.input_UrlImagen);
            this.Controls.Add(this.btn_BuscarImagenesLocal);
            this.Controls.Add(this.cb_CategoriaNA);
            this.Controls.Add(this.cb_MarcaNA);
            this.Controls.Add(this.input_CodigoNA);
            this.Controls.Add(this.lbl_CodigoNA);
            this.Controls.Add(this.lbl_ImagenNA);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.input_PrecioNA);
            this.Controls.Add(this.lbl_PrecioNA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbl_MarcaNA);
            this.Controls.Add(this.input_DescripcionNA);
            this.Controls.Add(this.lbl_DescripcionNA);
            this.Controls.Add(this.lbl_NuevoArticulo);
            this.Controls.Add(this.input_NombreNA);
            this.Controls.Add(this.btnAgregarNA);
            this.Controls.Add(this.lbl_NombreNA);
            this.MaximizeBox = false;
            this.Name = "wf_ADM_AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Catalogo [Nuevo Articulo]";
            this.Load += new System.EventHandler(this.wf_ADM_AgregarArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_VisorImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NombreNA;
        private Button btnAgregarNA;
        private TextBox input_NombreNA;
        private Label lbl_NuevoArticulo;
        private Label lbl_DescripcionNA;
        private TextBox input_DescripcionNA;
        private Label lbl_MarcaNA;
        private Label label5;
        private Label lbl_PrecioNA;
        private TextBox input_PrecioNA;
        private Label label7;
        private Label lbl_ImagenNA;
        private TextBox input_CodigoNA;
        private Label lbl_CodigoNA;
        private ComboBox cb_MarcaNA;
        private ComboBox cb_CategoriaNA;
        private Button btn_BuscarImagenesLocal;
        private TextBox input_UrlImagen;
        private Button btn_ConfirmarImagen;
        private Label lbl_confirmacionImagen;
        private Button btn_descartarImagen;
        private PictureBox pb_VisorImagen;
    }
}