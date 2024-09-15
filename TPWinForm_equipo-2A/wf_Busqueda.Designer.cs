using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_Busqueda
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
            this.lbl_NombreBusca = new System.Windows.Forms.Label();
            this.lbl_CodigoBusca = new System.Windows.Forms.Label();
            this.lbl_DescripcionBusca = new System.Windows.Forms.Label();
            this.lbl_TituloBusqueda = new System.Windows.Forms.Label();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.lbl_IdBusca = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.db_BusquedaMarca = new System.Windows.Forms.ComboBox();
            this.lbl_RangoPrecioBusqueda = new System.Windows.Forms.Label();
            this.db_BusquedaCategoria = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TbPrecioMIN = new System.Windows.Forms.TextBox();
            this.TbPrecioMAX = new System.Windows.Forms.TextBox();
            this.btnAplicarFiltros = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_NombreBusca
            // 
            this.lbl_NombreBusca.AutoSize = true;
            this.lbl_NombreBusca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreBusca.Location = new System.Drawing.Point(59, 134);
            this.lbl_NombreBusca.Name = "lbl_NombreBusca";
            this.lbl_NombreBusca.Size = new System.Drawing.Size(59, 16);
            this.lbl_NombreBusca.TabIndex = 7;
            this.lbl_NombreBusca.Text = "NOMBRE";
            this.lbl_NombreBusca.Click += new System.EventHandler(this.lbl_MarcaBusqueda_Click);
            // 
            // lbl_CodigoBusca
            // 
            this.lbl_CodigoBusca.AutoSize = true;
            this.lbl_CodigoBusca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CodigoBusca.Location = new System.Drawing.Point(150, 133);
            this.lbl_CodigoBusca.Name = "lbl_CodigoBusca";
            this.lbl_CodigoBusca.Size = new System.Drawing.Size(55, 16);
            this.lbl_CodigoBusca.TabIndex = 8;
            this.lbl_CodigoBusca.Text = "CODIGO";
            // 
            // lbl_DescripcionBusca
            // 
            this.lbl_DescripcionBusca.AutoSize = true;
            this.lbl_DescripcionBusca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_DescripcionBusca.Location = new System.Drawing.Point(235, 133);
            this.lbl_DescripcionBusca.Name = "lbl_DescripcionBusca";
            this.lbl_DescripcionBusca.Size = new System.Drawing.Size(91, 16);
            this.lbl_DescripcionBusca.TabIndex = 11;
            this.lbl_DescripcionBusca.Text = "DESCRIPCION";
            // 
            // lbl_TituloBusqueda
            // 
            this.lbl_TituloBusqueda.AutoSize = true;
            this.lbl_TituloBusqueda.BackColor = System.Drawing.Color.White;
            this.lbl_TituloBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_TituloBusqueda.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloBusqueda.Location = new System.Drawing.Point(10, 20);
            this.lbl_TituloBusqueda.Name = "lbl_TituloBusqueda";
            this.lbl_TituloBusqueda.Size = new System.Drawing.Size(233, 31);
            this.lbl_TituloBusqueda.TabIndex = 12;
            this.lbl_TituloBusqueda.Text = "Busqueda por Filtros";
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(10, 154);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(812, 396);
            this.dgvArticulos.TabIndex = 13;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick_1);
            // 
            // lbl_IdBusca
            // 
            this.lbl_IdBusca.AutoSize = true;
            this.lbl_IdBusca.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_IdBusca.Location = new System.Drawing.Point(13, 133);
            this.lbl_IdBusca.Name = "lbl_IdBusca";
            this.lbl_IdBusca.Size = new System.Drawing.Size(21, 16);
            this.lbl_IdBusca.TabIndex = 14;
            this.lbl_IdBusca.Text = "ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(362, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "MARCA";
            // 
            // db_BusquedaMarca
            // 
            this.db_BusquedaMarca.FormattingEnabled = true;
            this.db_BusquedaMarca.Location = new System.Drawing.Point(474, 48);
            this.db_BusquedaMarca.Name = "db_BusquedaMarca";
            this.db_BusquedaMarca.Size = new System.Drawing.Size(89, 21);
            this.db_BusquedaMarca.TabIndex = 20;
            // 
            // lbl_RangoPrecioBusqueda
            // 
            this.lbl_RangoPrecioBusqueda.AutoSize = true;
            this.lbl_RangoPrecioBusqueda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RangoPrecioBusqueda.ForeColor = System.Drawing.SystemColors.GrayText;
            this.lbl_RangoPrecioBusqueda.Location = new System.Drawing.Point(641, 31);
            this.lbl_RangoPrecioBusqueda.Name = "lbl_RangoPrecioBusqueda";
            this.lbl_RangoPrecioBusqueda.Size = new System.Drawing.Size(113, 16);
            this.lbl_RangoPrecioBusqueda.TabIndex = 10;
            this.lbl_RangoPrecioBusqueda.Text = "Rango De Precio";
            this.lbl_RangoPrecioBusqueda.Click += new System.EventHandler(this.lbl_RangoPrecioBusqueda_Click);
            // 
            // db_BusquedaCategoria
            // 
            this.db_BusquedaCategoria.FormattingEnabled = true;
            this.db_BusquedaCategoria.Location = new System.Drawing.Point(379, 49);
            this.db_BusquedaCategoria.Name = "db_BusquedaCategoria";
            this.db_BusquedaCategoria.Size = new System.Drawing.Size(89, 21);
            this.db_BusquedaCategoria.TabIndex = 22;
            this.db_BusquedaCategoria.SelectedIndexChanged += new System.EventHandler(this.db_BusquedaCategoria_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(458, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = "CATEGORIA";
            // 
            // TbPrecioMIN
            // 
            this.TbPrecioMIN.Location = new System.Drawing.Point(617, 50);
            this.TbPrecioMIN.Name = "TbPrecioMIN";
            this.TbPrecioMIN.Size = new System.Drawing.Size(73, 20);
            this.TbPrecioMIN.TabIndex = 24;
            // 
            // TbPrecioMAX
            // 
            this.TbPrecioMAX.Location = new System.Drawing.Point(704, 50);
            this.TbPrecioMAX.Name = "TbPrecioMAX";
            this.TbPrecioMAX.Size = new System.Drawing.Size(73, 20);
            this.TbPrecioMAX.TabIndex = 25;
            // 
            // btnAplicarFiltros
            // 
            this.btnAplicarFiltros.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.25F);
            this.btnAplicarFiltros.Location = new System.Drawing.Point(744, 103);
            this.btnAplicarFiltros.Name = "btnAplicarFiltros";
            this.btnAplicarFiltros.Size = new System.Drawing.Size(69, 19);
            this.btnAplicarFiltros.TabIndex = 26;
            this.btnAplicarFiltros.Text = "APLICAR";
            this.btnAplicarFiltros.UseVisualStyleBackColor = true;
            this.btnAplicarFiltros.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label3.Location = new System.Drawing.Point(630, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 27;
            this.label3.Text = "Minimo";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 7F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label4.Location = new System.Drawing.Point(716, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 12);
            this.label4.TabIndex = 28;
            this.label4.Text = "Maximo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(362, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 18);
            this.label5.TabIndex = 29;
            this.label5.Text = "FILTROS:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label6.Location = new System.Drawing.Point(386, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 16);
            this.label6.TabIndex = 30;
            this.label6.Text = "Categorias";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.SystemColors.GrayText;
            this.label7.Location = new System.Drawing.Point(490, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 16);
            this.label7.TabIndex = 31;
            this.label7.Text = "Marcas";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(757, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 16);
            this.label8.TabIndex = 32;
            this.label8.Text = "PRECIO";
            // 
            // wf_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(834, 561);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAplicarFiltros);
            this.Controls.Add(this.TbPrecioMAX);
            this.Controls.Add(this.TbPrecioMIN);
            this.Controls.Add(this.db_BusquedaCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.db_BusquedaMarca);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_IdBusca);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.lbl_TituloBusqueda);
            this.Controls.Add(this.lbl_DescripcionBusca);
            this.Controls.Add(this.lbl_RangoPrecioBusqueda);
            this.Controls.Add(this.lbl_CodigoBusca);
            this.Controls.Add(this.lbl_NombreBusca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(850, 600);
            this.Name = "wf_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_Busqueda";
            this.Load += new System.EventHandler(this.wf_Busqueda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lbl_NombreBusca;
        private Label lbl_CodigoBusca;
        private Label lbl_DescripcionBusca;
        private Label lbl_TituloBusqueda;
        private DataGridView dgvArticulos;
        private Label lbl_IdBusca;
        private Label label1;
        private ComboBox db_BusquedaMarca;
        private Label lbl_RangoPrecioBusqueda;
        private ComboBox db_BusquedaCategoria;
        private Label label2;
        private TextBox TbPrecioMIN;
        private TextBox TbPrecioMAX;
        private Button btnAplicarFiltros;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}