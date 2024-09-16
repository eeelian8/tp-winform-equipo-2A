using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_ADM_ModificarArticulo
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
            this.input_CodigoArticuloMA = new System.Windows.Forms.TextBox();
            this.lbl_NroArticuloMA = new System.Windows.Forms.Label();
            this.pb_ImagenesDetallesMA = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_BuscarMA = new System.Windows.Forms.Button();
            this.btn_ConfirmarModificar = new System.Windows.Forms.Button();
            this.btn_EliminarIMG = new System.Windows.Forms.Button();
            this.btn_AgregarIMG = new System.Windows.Forms.Button();
            this.lbl_NombreDetallesMA = new System.Windows.Forms.TextBox();
            this.lbl_DescripcionDetallesMA = new System.Windows.Forms.TextBox();
            this.cb_CategoriaDetallesMA = new System.Windows.Forms.ComboBox();
            this.cb_MarcasDetallesMA = new System.Windows.Forms.ComboBox();
            this.lbl_PrecioDetallesMA = new System.Windows.Forms.TextBox();
            this.tb_nuevaUrlImagen = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenesDetallesMA)).BeginInit();
            this.SuspendLayout();
            // 
            // input_CodigoArticuloMA
            // 
            this.input_CodigoArticuloMA.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.input_CodigoArticuloMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.input_CodigoArticuloMA.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_CodigoArticuloMA.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.input_CodigoArticuloMA.Location = new System.Drawing.Point(216, 62);
            this.input_CodigoArticuloMA.Name = "input_CodigoArticuloMA";
            this.input_CodigoArticuloMA.Size = new System.Drawing.Size(104, 22);
            this.input_CodigoArticuloMA.TabIndex = 5;
            // 
            // lbl_NroArticuloMA
            // 
            this.lbl_NroArticuloMA.AutoSize = true;
            this.lbl_NroArticuloMA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroArticuloMA.Location = new System.Drawing.Point(162, 27);
            this.lbl_NroArticuloMA.Name = "lbl_NroArticuloMA";
            this.lbl_NroArticuloMA.Size = new System.Drawing.Size(277, 19);
            this.lbl_NroArticuloMA.TabIndex = 4;
            this.lbl_NroArticuloMA.Text = "INGRESE EL CODIGO DE ARTICULO:";
            // 
            // pb_ImagenesDetallesMA
            // 
            this.pb_ImagenesDetallesMA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_ImagenesDetallesMA.Location = new System.Drawing.Point(301, 153);
            this.pb_ImagenesDetallesMA.Name = "pb_ImagenesDetallesMA";
            this.pb_ImagenesDetallesMA.Size = new System.Drawing.Size(241, 177);
            this.pb_ImagenesDetallesMA.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ImagenesDetallesMA.TabIndex = 34;
            this.pb_ImagenesDetallesMA.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 16);
            this.label1.TabIndex = 45;
            this.label1.Text = "Precio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(298, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 16);
            this.label2.TabIndex = 44;
            this.label2.Text = "Imagen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 269);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Categoria:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 16);
            this.label4.TabIndex = 42;
            this.label4.Text = "Marca:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 16);
            this.label5.TabIndex = 41;
            this.label5.Text = "Descripcion:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 16);
            this.label6.TabIndex = 40;
            this.label6.Text = "Nombre:";
            // 
            // btn_BuscarMA
            // 
            this.btn_BuscarMA.BackColor = System.Drawing.Color.White;
            this.btn_BuscarMA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarMA.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BuscarMA.Location = new System.Drawing.Point(327, 62);
            this.btn_BuscarMA.Name = "btn_BuscarMA";
            this.btn_BuscarMA.Size = new System.Drawing.Size(26, 23);
            this.btn_BuscarMA.TabIndex = 48;
            this.btn_BuscarMA.Text = ">";
            this.btn_BuscarMA.UseVisualStyleBackColor = false;
            this.btn_BuscarMA.Click += new System.EventHandler(this.btn_BuscarMA_Click);
            // 
            // btn_ConfirmarModificar
            // 
            this.btn_ConfirmarModificar.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ConfirmarModificar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarModificar.Location = new System.Drawing.Point(115, 364);
            this.btn_ConfirmarModificar.Name = "btn_ConfirmarModificar";
            this.btn_ConfirmarModificar.Size = new System.Drawing.Size(111, 32);
            this.btn_ConfirmarModificar.TabIndex = 49;
            this.btn_ConfirmarModificar.Text = "Guardar";
            this.btn_ConfirmarModificar.UseVisualStyleBackColor = false;
            this.btn_ConfirmarModificar.Click += new System.EventHandler(this.btn_ConfirmarModificar_Click);
            // 
            // btn_EliminarIMG
            // 
            this.btn_EliminarIMG.BackColor = System.Drawing.Color.LightSalmon;
            this.btn_EliminarIMG.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarIMG.Location = new System.Drawing.Point(351, 382);
            this.btn_EliminarIMG.Name = "btn_EliminarIMG";
            this.btn_EliminarIMG.Size = new System.Drawing.Size(50, 23);
            this.btn_EliminarIMG.TabIndex = 55;
            this.btn_EliminarIMG.Text = "Eliminar";
            this.btn_EliminarIMG.UseVisualStyleBackColor = false;
            this.btn_EliminarIMG.Click += new System.EventHandler(this.btn_EliminarIMG_Click);
            // 
            // btn_AgregarIMG
            // 
            this.btn_AgregarIMG.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_AgregarIMG.Font = new System.Drawing.Font("Tahoma", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarIMG.Location = new System.Drawing.Point(422, 382);
            this.btn_AgregarIMG.Name = "btn_AgregarIMG";
            this.btn_AgregarIMG.Size = new System.Drawing.Size(120, 23);
            this.btn_AgregarIMG.TabIndex = 56;
            this.btn_AgregarIMG.Text = "Agregar nueva imagen";
            this.btn_AgregarIMG.UseVisualStyleBackColor = false;
            this.btn_AgregarIMG.Click += new System.EventHandler(this.btn_AgregarIMG_Click);
            // 
            // lbl_NombreDetallesMA
            // 
            this.lbl_NombreDetallesMA.Location = new System.Drawing.Point(99, 134);
            this.lbl_NombreDetallesMA.Name = "lbl_NombreDetallesMA";
            this.lbl_NombreDetallesMA.Size = new System.Drawing.Size(177, 20);
            this.lbl_NombreDetallesMA.TabIndex = 57;
            // 
            // lbl_DescripcionDetallesMA
            // 
            this.lbl_DescripcionDetallesMA.Location = new System.Drawing.Point(100, 173);
            this.lbl_DescripcionDetallesMA.Name = "lbl_DescripcionDetallesMA";
            this.lbl_DescripcionDetallesMA.Size = new System.Drawing.Size(177, 20);
            this.lbl_DescripcionDetallesMA.TabIndex = 58;
            // 
            // cb_CategoriaDetallesMA
            // 
            this.cb_CategoriaDetallesMA.FormattingEnabled = true;
            this.cb_CategoriaDetallesMA.Location = new System.Drawing.Point(99, 269);
            this.cb_CategoriaDetallesMA.Name = "cb_CategoriaDetallesMA";
            this.cb_CategoriaDetallesMA.Size = new System.Drawing.Size(176, 21);
            this.cb_CategoriaDetallesMA.TabIndex = 61;
            // 
            // cb_MarcasDetallesMA
            // 
            this.cb_MarcasDetallesMA.FormattingEnabled = true;
            this.cb_MarcasDetallesMA.Location = new System.Drawing.Point(99, 226);
            this.cb_MarcasDetallesMA.Name = "cb_MarcasDetallesMA";
            this.cb_MarcasDetallesMA.Size = new System.Drawing.Size(176, 21);
            this.cb_MarcasDetallesMA.TabIndex = 62;
            // 
            // lbl_PrecioDetallesMA
            // 
            this.lbl_PrecioDetallesMA.Location = new System.Drawing.Point(98, 310);
            this.lbl_PrecioDetallesMA.Name = "lbl_PrecioDetallesMA";
            this.lbl_PrecioDetallesMA.Size = new System.Drawing.Size(178, 20);
            this.lbl_PrecioDetallesMA.TabIndex = 63;
            // 
            // tb_nuevaUrlImagen
            // 
            this.tb_nuevaUrlImagen.Location = new System.Drawing.Point(301, 347);
            this.tb_nuevaUrlImagen.Name = "tb_nuevaUrlImagen";
            this.tb_nuevaUrlImagen.Size = new System.Drawing.Size(241, 20);
            this.tb_nuevaUrlImagen.TabIndex = 64;
            this.tb_nuevaUrlImagen.Leave += new System.EventHandler(this.tb_nuevaUrlImagen_Leave);
            // 
            // wf_ADM_ModificarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 431);
            this.Controls.Add(this.tb_nuevaUrlImagen);
            this.Controls.Add(this.lbl_PrecioDetallesMA);
            this.Controls.Add(this.cb_MarcasDetallesMA);
            this.Controls.Add(this.cb_CategoriaDetallesMA);
            this.Controls.Add(this.lbl_DescripcionDetallesMA);
            this.Controls.Add(this.lbl_NombreDetallesMA);
            this.Controls.Add(this.btn_AgregarIMG);
            this.Controls.Add(this.btn_EliminarIMG);
            this.Controls.Add(this.btn_ConfirmarModificar);
            this.Controls.Add(this.btn_BuscarMA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.pb_ImagenesDetallesMA);
            this.Controls.Add(this.input_CodigoArticuloMA);
            this.Controls.Add(this.lbl_NroArticuloMA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(581, 470);
            this.Name = "wf_ADM_ModificarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_ModificarArticulo";
            this.Load += new System.EventHandler(this.wf_ADM_ModificarArticulo_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ImagenesDetallesMA)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox input_CodigoArticuloMA;
        private Label lbl_NroArticuloMA;
        private PictureBox pb_ImagenesDetallesMA;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btn_BuscarMA;
        private Button btn_ConfirmarModificar;
        private Button btn_EliminarIMG;
        private Button btn_AgregarIMG;
        private TextBox lbl_NombreDetallesMA;
        private TextBox lbl_DescripcionDetallesMA;
        private ComboBox cb_CategoriaDetallesMA;
        private ComboBox cb_MarcasDetallesMA;
        private TextBox lbl_PrecioDetallesMA;
        private TextBox tb_nuevaUrlImagen;
    }
}