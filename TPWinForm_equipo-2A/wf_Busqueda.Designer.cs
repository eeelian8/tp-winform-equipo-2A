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
            this.lv_Busqueda = new System.Windows.Forms.ListView();
            this.lb_BusquedaMarca = new System.Windows.Forms.ListBox();
            this.lb_BusquedaCategoria = new System.Windows.Forms.ListBox();
            this.lb_RangoPrecio1 = new System.Windows.Forms.ListBox();
            this.lb_RangoPrecio2 = new System.Windows.Forms.ListBox();
            this.lb_BusquedaNombre = new System.Windows.Forms.ListBox();
            this.lbl_MarcaBusqueda = new System.Windows.Forms.Label();
            this.lbl_CategoriaBusqueda = new System.Windows.Forms.Label();
            this.lbl_RangoPrecioBusqueda = new System.Windows.Forms.Label();
            this.lbl_NombreBusqueda = new System.Windows.Forms.Label();
            this.lbl_TituloBusqueda = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lv_Busqueda
            // 
            this.lv_Busqueda.HideSelection = false;
            this.lv_Busqueda.Location = new System.Drawing.Point(10, 117);
            this.lv_Busqueda.Name = "lv_Busqueda";
            this.lv_Busqueda.Size = new System.Drawing.Size(427, 305);
            this.lv_Busqueda.TabIndex = 0;
            this.lv_Busqueda.UseCompatibleStateImageBehavior = false;
            // 
            // lb_BusquedaMarca
            // 
            this.lb_BusquedaMarca.BackColor = System.Drawing.Color.White;
            this.lb_BusquedaMarca.FormattingEnabled = true;
            this.lb_BusquedaMarca.Location = new System.Drawing.Point(12, 83);
            this.lb_BusquedaMarca.Name = "lb_BusquedaMarca";
            this.lb_BusquedaMarca.Size = new System.Drawing.Size(91, 17);
            this.lb_BusquedaMarca.TabIndex = 1;
            // 
            // lb_BusquedaCategoria
            // 
            this.lb_BusquedaCategoria.BackColor = System.Drawing.Color.White;
            this.lb_BusquedaCategoria.FormattingEnabled = true;
            this.lb_BusquedaCategoria.Location = new System.Drawing.Point(108, 83);
            this.lb_BusquedaCategoria.Name = "lb_BusquedaCategoria";
            this.lb_BusquedaCategoria.Size = new System.Drawing.Size(97, 17);
            this.lb_BusquedaCategoria.TabIndex = 2;
            // 
            // lb_RangoPrecio1
            // 
            this.lb_RangoPrecio1.BackColor = System.Drawing.Color.White;
            this.lb_RangoPrecio1.FormattingEnabled = true;
            this.lb_RangoPrecio1.Location = new System.Drawing.Point(210, 83);
            this.lb_RangoPrecio1.Name = "lb_RangoPrecio1";
            this.lb_RangoPrecio1.Size = new System.Drawing.Size(61, 17);
            this.lb_RangoPrecio1.TabIndex = 3;
            // 
            // lb_RangoPrecio2
            // 
            this.lb_RangoPrecio2.BackColor = System.Drawing.Color.White;
            this.lb_RangoPrecio2.FormattingEnabled = true;
            this.lb_RangoPrecio2.Location = new System.Drawing.Point(275, 83);
            this.lb_RangoPrecio2.Name = "lb_RangoPrecio2";
            this.lb_RangoPrecio2.Size = new System.Drawing.Size(61, 17);
            this.lb_RangoPrecio2.TabIndex = 4;
            // 
            // lb_BusquedaNombre
            // 
            this.lb_BusquedaNombre.BackColor = System.Drawing.Color.White;
            this.lb_BusquedaNombre.FormattingEnabled = true;
            this.lb_BusquedaNombre.Location = new System.Drawing.Point(340, 83);
            this.lb_BusquedaNombre.Name = "lb_BusquedaNombre";
            this.lb_BusquedaNombre.Size = new System.Drawing.Size(97, 17);
            this.lb_BusquedaNombre.TabIndex = 6;
            // 
            // lbl_MarcaBusqueda
            // 
            this.lbl_MarcaBusqueda.AutoSize = true;
            this.lbl_MarcaBusqueda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_MarcaBusqueda.Location = new System.Drawing.Point(12, 65);
            this.lbl_MarcaBusqueda.Name = "lbl_MarcaBusqueda";
            this.lbl_MarcaBusqueda.Size = new System.Drawing.Size(60, 16);
            this.lbl_MarcaBusqueda.TabIndex = 7;
            this.lbl_MarcaBusqueda.Text = "MARCA:";
            // 
            // lbl_CategoriaBusqueda
            // 
            this.lbl_CategoriaBusqueda.AutoSize = true;
            this.lbl_CategoriaBusqueda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_CategoriaBusqueda.Location = new System.Drawing.Point(108, 65);
            this.lbl_CategoriaBusqueda.Name = "lbl_CategoriaBusqueda";
            this.lbl_CategoriaBusqueda.Size = new System.Drawing.Size(85, 16);
            this.lbl_CategoriaBusqueda.TabIndex = 8;
            this.lbl_CategoriaBusqueda.Text = "CATEGORIA:";
            // 
            // lbl_RangoPrecioBusqueda
            // 
            this.lbl_RangoPrecioBusqueda.AutoSize = true;
            this.lbl_RangoPrecioBusqueda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_RangoPrecioBusqueda.Location = new System.Drawing.Point(222, 65);
            this.lbl_RangoPrecioBusqueda.Name = "lbl_RangoPrecioBusqueda";
            this.lbl_RangoPrecioBusqueda.Size = new System.Drawing.Size(126, 16);
            this.lbl_RangoPrecioBusqueda.TabIndex = 10;
            this.lbl_RangoPrecioBusqueda.Text = "RANGO DE PRECIO:";
            // 
            // lbl_NombreBusqueda
            // 
            this.lbl_NombreBusqueda.AutoSize = true;
            this.lbl_NombreBusqueda.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.lbl_NombreBusqueda.Location = new System.Drawing.Point(340, 65);
            this.lbl_NombreBusqueda.Name = "lbl_NombreBusqueda";
            this.lbl_NombreBusqueda.Size = new System.Drawing.Size(64, 16);
            this.lbl_NombreBusqueda.TabIndex = 11;
            this.lbl_NombreBusqueda.Text = "NOMBRE:";
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
            // wf_Busqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(451, 432);
            this.Controls.Add(this.lbl_TituloBusqueda);
            this.Controls.Add(this.lbl_NombreBusqueda);
            this.Controls.Add(this.lbl_RangoPrecioBusqueda);
            this.Controls.Add(this.lbl_CategoriaBusqueda);
            this.Controls.Add(this.lbl_MarcaBusqueda);
            this.Controls.Add(this.lb_BusquedaNombre);
            this.Controls.Add(this.lb_RangoPrecio2);
            this.Controls.Add(this.lb_RangoPrecio1);
            this.Controls.Add(this.lb_BusquedaCategoria);
            this.Controls.Add(this.lb_BusquedaMarca);
            this.Controls.Add(this.lv_Busqueda);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(467, 471);
            this.Name = "wf_Busqueda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_Busqueda";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView lv_Busqueda;
        private ListBox lb_BusquedaMarca;
        private ListBox lb_BusquedaCategoria;
        private ListBox lb_RangoPrecio1;
        private ListBox lb_RangoPrecio2;
        private ListBox lb_BusquedaNombre;
        private Label lbl_MarcaBusqueda;
        private Label lbl_CategoriaBusqueda;
        private Label lbl_RangoPrecioBusqueda;
        private Label lbl_NombreBusqueda;
        private Label lbl_TituloBusqueda;
    }
}