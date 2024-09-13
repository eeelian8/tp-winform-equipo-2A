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
            this.btn_BuscarNA = new System.Windows.Forms.Button();
            this.cb_MarcaNA = new System.Windows.Forms.ComboBox();
            this.cb_CategoriaNA = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbl_NombreNA
            // 
            this.lbl_NombreNA.AutoSize = true;
            this.lbl_NombreNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_NombreNA.Location = new System.Drawing.Point(48, 99);
            this.lbl_NombreNA.Name = "lbl_NombreNA";
            this.lbl_NombreNA.Size = new System.Drawing.Size(57, 16);
            this.lbl_NombreNA.TabIndex = 0;
            this.lbl_NombreNA.Text = "Nombre:";
            // 
            // btnAgregarNA
            // 
            this.btnAgregarNA.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAgregarNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarNA.Location = new System.Drawing.Point(359, 341);
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
            this.input_NombreNA.Location = new System.Drawing.Point(108, 97);
            this.input_NombreNA.Name = "input_NombreNA";
            this.input_NombreNA.Size = new System.Drawing.Size(363, 20);
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
            this.lbl_MarcaNA.Location = new System.Drawing.Point(57, 213);
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
            this.lbl_PrecioNA.Location = new System.Drawing.Point(57, 289);
            this.lbl_PrecioNA.Name = "lbl_PrecioNA";
            this.lbl_PrecioNA.Size = new System.Drawing.Size(47, 16);
            this.lbl_PrecioNA.TabIndex = 14;
            this.lbl_PrecioNA.Text = "Precio:";
            // 
            // input_PrecioNA
            // 
            this.input_PrecioNA.BackColor = System.Drawing.SystemColors.Control;
            this.input_PrecioNA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_PrecioNA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_PrecioNA.Location = new System.Drawing.Point(108, 286);
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
            this.input_CodigoNA.Location = new System.Drawing.Point(108, 72);
            this.input_CodigoNA.Name = "input_CodigoNA";
            this.input_CodigoNA.Size = new System.Drawing.Size(363, 20);
            this.input_CodigoNA.TabIndex = 20;
            // 
            // lbl_CodigoNA
            // 
            this.lbl_CodigoNA.AutoSize = true;
            this.lbl_CodigoNA.Font = new System.Drawing.Font("Tahoma", 9.75F);
            this.lbl_CodigoNA.Location = new System.Drawing.Point(53, 73);
            this.lbl_CodigoNA.Name = "lbl_CodigoNA";
            this.lbl_CodigoNA.Size = new System.Drawing.Size(51, 16);
            this.lbl_CodigoNA.TabIndex = 19;
            this.lbl_CodigoNA.Text = "Codigo:";
            // 
            // btn_BuscarNA
            // 
            this.btn_BuscarNA.BackColor = System.Drawing.Color.White;
            this.btn_BuscarNA.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_BuscarNA.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_BuscarNA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarNA.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarNA.Location = new System.Drawing.Point(108, 244);
            this.btn_BuscarNA.Name = "btn_BuscarNA";
            this.btn_BuscarNA.Size = new System.Drawing.Size(64, 20);
            this.btn_BuscarNA.TabIndex = 21;
            this.btn_BuscarNA.Text = "Buscar";
            this.btn_BuscarNA.UseVisualStyleBackColor = false;
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
            // wf_ADM_AgregarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 404);
            this.Controls.Add(this.cb_CategoriaNA);
            this.Controls.Add(this.cb_MarcaNA);
            this.Controls.Add(this.btn_BuscarNA);
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
            this.MaximumSize = new System.Drawing.Size(534, 443);
            this.Name = "wf_ADM_AgregarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Gestion Catalogo [Nuevo Articulo]";
            this.Load += new System.EventHandler(this.wf_ADM_AgregarArticulo_Load_1);
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
        private Button btn_BuscarNA;
        private ComboBox cb_MarcaNA;
        private ComboBox cb_CategoriaNA;
    }
}