using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_Detalles
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
            this.input_CodigoArticuloDetalles = new System.Windows.Forms.TextBox();
            this.lbl_NroArticuloDetalles = new System.Windows.Forms.Label();
            this.lbl_PrecioDetalles = new System.Windows.Forms.Label();
            this.lbl_ImagenDetalles = new System.Windows.Forms.Label();
            this.lbl_CategoriaDetalles = new System.Windows.Forms.Label();
            this.lbl_MarcaDetalles = new System.Windows.Forms.Label();
            this.lbl_DescripcionDetalles = new System.Windows.Forms.Label();
            this.lbl_NombreDetalles = new System.Windows.Forms.Label();
            this.pb_ImagenesDA = new System.Windows.Forms.PictureBox();
            this.lbl_PrecioDA = new System.Windows.Forms.Label();
            this.lbl_NombreDA = new System.Windows.Forms.Label();
            this.lbl_DescripcionDA = new System.Windows.Forms.Label();
            this.lbl_MarcasDA = new System.Windows.Forms.Label();
            this.lbl_CategoriaDA = new System.Windows.Forms.Label();
            this.btn_DetallesBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenesDA)).BeginInit();
            this.SuspendLayout();
            // 
            // input_CodigoArticuloDetalles
            // 
            this.input_CodigoArticuloDetalles.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_CodigoArticuloDetalles.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_CodigoArticuloDetalles.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_CodigoArticuloDetalles.Location = new System.Drawing.Point(109, 75);
            this.input_CodigoArticuloDetalles.Name = "input_CodigoArticuloDetalles";
            this.input_CodigoArticuloDetalles.Size = new System.Drawing.Size(107, 20);
            this.input_CodigoArticuloDetalles.TabIndex = 7;
            // 
            // lbl_NroArticuloDetalles
            // 
            this.lbl_NroArticuloDetalles.AutoSize = true;
            this.lbl_NroArticuloDetalles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroArticuloDetalles.Location = new System.Drawing.Point(75, 45);
            this.lbl_NroArticuloDetalles.Name = "lbl_NroArticuloDetalles";
            this.lbl_NroArticuloDetalles.Size = new System.Drawing.Size(277, 19);
            this.lbl_NroArticuloDetalles.TabIndex = 6;
            this.lbl_NroArticuloDetalles.Text = "INGRESE EL CODIGO DE ARTICULO:";
            // 
            // lbl_PrecioDetalles
            // 
            this.lbl_PrecioDetalles.AutoSize = true;
            this.lbl_PrecioDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioDetalles.Location = new System.Drawing.Point(66, 328);
            this.lbl_PrecioDetalles.Name = "lbl_PrecioDetalles";
            this.lbl_PrecioDetalles.Size = new System.Drawing.Size(61, 18);
            this.lbl_PrecioDetalles.TabIndex = 17;
            this.lbl_PrecioDetalles.Text = "Precio:";
            // 
            // lbl_ImagenDetalles
            // 
            this.lbl_ImagenDetalles.AutoSize = true;
            this.lbl_ImagenDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ImagenDetalles.Location = new System.Drawing.Point(58, 225);
            this.lbl_ImagenDetalles.Name = "lbl_ImagenDetalles";
            this.lbl_ImagenDetalles.Size = new System.Drawing.Size(69, 18);
            this.lbl_ImagenDetalles.TabIndex = 16;
            this.lbl_ImagenDetalles.Text = "Imagen:";
            // 
            // lbl_CategoriaDetalles
            // 
            this.lbl_CategoriaDetalles.AutoSize = true;
            this.lbl_CategoriaDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaDetalles.Location = new System.Drawing.Point(41, 200);
            this.lbl_CategoriaDetalles.Name = "lbl_CategoriaDetalles";
            this.lbl_CategoriaDetalles.Size = new System.Drawing.Size(86, 18);
            this.lbl_CategoriaDetalles.TabIndex = 15;
            this.lbl_CategoriaDetalles.Text = "Categoria:";
            // 
            // lbl_MarcaDetalles
            // 
            this.lbl_MarcaDetalles.AutoSize = true;
            this.lbl_MarcaDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarcaDetalles.Location = new System.Drawing.Point(69, 172);
            this.lbl_MarcaDetalles.Name = "lbl_MarcaDetalles";
            this.lbl_MarcaDetalles.Size = new System.Drawing.Size(59, 18);
            this.lbl_MarcaDetalles.TabIndex = 14;
            this.lbl_MarcaDetalles.Text = "Marca:";
            // 
            // lbl_DescripcionDetalles
            // 
            this.lbl_DescripcionDetalles.AutoSize = true;
            this.lbl_DescripcionDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescripcionDetalles.Location = new System.Drawing.Point(27, 144);
            this.lbl_DescripcionDetalles.Name = "lbl_DescripcionDetalles";
            this.lbl_DescripcionDetalles.Size = new System.Drawing.Size(101, 18);
            this.lbl_DescripcionDetalles.TabIndex = 13;
            this.lbl_DescripcionDetalles.Text = "Descripcion:";
            // 
            // lbl_NombreDetalles
            // 
            this.lbl_NombreDetalles.AutoSize = true;
            this.lbl_NombreDetalles.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDetalles.Location = new System.Drawing.Point(56, 116);
            this.lbl_NombreDetalles.Name = "lbl_NombreDetalles";
            this.lbl_NombreDetalles.Size = new System.Drawing.Size(72, 18);
            this.lbl_NombreDetalles.TabIndex = 12;
            this.lbl_NombreDetalles.Text = "Nombre:";
            // 
            // pb_ImagenesDA
            // 
            this.pb_ImagenesDA.Location = new System.Drawing.Point(134, 229);
            this.pb_ImagenesDA.Name = "pb_ImagenesDA";
            this.pb_ImagenesDA.Size = new System.Drawing.Size(188, 88);
            this.pb_ImagenesDA.TabIndex = 22;
            this.pb_ImagenesDA.TabStop = false;
            // 
            // lbl_PrecioDA
            // 
            this.lbl_PrecioDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_PrecioDA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrecioDA.Location = new System.Drawing.Point(134, 326);
            this.lbl_PrecioDA.Name = "lbl_PrecioDA";
            this.lbl_PrecioDA.Size = new System.Drawing.Size(188, 22);
            this.lbl_PrecioDA.TabIndex = 23;
            this.lbl_PrecioDA.Click += new System.EventHandler(this.lbl_PrecioDA_Click);
            // 
            // lbl_NombreDA
            // 
            this.lbl_NombreDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_NombreDA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NombreDA.Location = new System.Drawing.Point(134, 116);
            this.lbl_NombreDA.Name = "lbl_NombreDA";
            this.lbl_NombreDA.Size = new System.Drawing.Size(188, 22);
            this.lbl_NombreDA.TabIndex = 24;
            // 
            // lbl_DescripcionDA
            // 
            this.lbl_DescripcionDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_DescripcionDA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DescripcionDA.Location = new System.Drawing.Point(134, 144);
            this.lbl_DescripcionDA.Name = "lbl_DescripcionDA";
            this.lbl_DescripcionDA.Size = new System.Drawing.Size(188, 21);
            this.lbl_DescripcionDA.TabIndex = 25;
            this.lbl_DescripcionDA.Click += new System.EventHandler(this.lbl_DescripcionDA_Click);
            // 
            // lbl_MarcasDA
            // 
            this.lbl_MarcasDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_MarcasDA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MarcasDA.Location = new System.Drawing.Point(134, 171);
            this.lbl_MarcasDA.Name = "lbl_MarcasDA";
            this.lbl_MarcasDA.Size = new System.Drawing.Size(188, 24);
            this.lbl_MarcasDA.TabIndex = 26;
            // 
            // lbl_CategoriaDA
            // 
            this.lbl_CategoriaDA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_CategoriaDA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CategoriaDA.Location = new System.Drawing.Point(134, 199);
            this.lbl_CategoriaDA.Name = "lbl_CategoriaDA";
            this.lbl_CategoriaDA.Size = new System.Drawing.Size(188, 22);
            this.lbl_CategoriaDA.TabIndex = 27;
            // 
            // btn_DetallesBuscar
            // 
            this.btn_DetallesBuscar.Location = new System.Drawing.Point(242, 75);
            this.btn_DetallesBuscar.Name = "btn_DetallesBuscar";
            this.btn_DetallesBuscar.Size = new System.Drawing.Size(75, 23);
            this.btn_DetallesBuscar.TabIndex = 28;
            this.btn_DetallesBuscar.Text = "Buscar";
            this.btn_DetallesBuscar.UseVisualStyleBackColor = true;
            this.btn_DetallesBuscar.Click += new System.EventHandler(this.btn_DetallesBuscar_Click);
            // 
            // wf_Detalles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 390);
            this.Controls.Add(this.btn_DetallesBuscar);
            this.Controls.Add(this.lbl_CategoriaDA);
            this.Controls.Add(this.lbl_MarcasDA);
            this.Controls.Add(this.lbl_DescripcionDA);
            this.Controls.Add(this.lbl_NombreDA);
            this.Controls.Add(this.lbl_PrecioDA);
            this.Controls.Add(this.pb_ImagenesDA);
            this.Controls.Add(this.lbl_PrecioDetalles);
            this.Controls.Add(this.lbl_ImagenDetalles);
            this.Controls.Add(this.lbl_CategoriaDetalles);
            this.Controls.Add(this.lbl_MarcaDetalles);
            this.Controls.Add(this.lbl_DescripcionDetalles);
            this.Controls.Add(this.lbl_NombreDetalles);
            this.Controls.Add(this.input_CodigoArticuloDetalles);
            this.Controls.Add(this.lbl_NroArticuloDetalles);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 429);
            this.Name = "wf_Detalles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_Detalles";
            this.Load += new System.EventHandler(this.wf_Detalles_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenesDA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_CodigoArticuloDetalles;
        private Label lbl_NroArticuloDetalles;
        private Label lbl_PrecioDetalles;
        private Label lbl_ImagenDetalles;
        private Label lbl_CategoriaDetalles;
        private Label lbl_MarcaDetalles;
        private Label lbl_DescripcionDetalles;
        private Label lbl_NombreDetalles;
        private PictureBox pb_ImagenesDA;
        private Label lbl_PrecioDA;
        private Label lbl_NombreDA;
        private Label lbl_DescripcionDA;
        private Label lbl_MarcasDA;
        private Label lbl_CategoriaDA;
        private Button btn_DetallesBuscar;
    }
}