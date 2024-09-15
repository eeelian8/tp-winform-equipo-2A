using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_MarcasCategorias
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
            this.btn_AgregarMarcasMC = new System.Windows.Forms.Button();
            this.btn_EliminarMarcasMC = new System.Windows.Forms.Button();
            this.gb_MarcasMC = new System.Windows.Forms.GroupBox();
            this.lv_MarcasMC = new System.Windows.Forms.ListView();
            this.gb_CategoriasMC = new System.Windows.Forms.GroupBox();
            this.lv_CategoriasMC = new System.Windows.Forms.ListView();
            this.btn_EliminarCategoriasMC = new System.Windows.Forms.Button();
            this.btn_AgregarCategoriasMC = new System.Windows.Forms.Button();
            this.gb_MarcasMC.SuspendLayout();
            this.gb_CategoriasMC.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_AgregarMarcasMC
            // 
            this.btn_AgregarMarcasMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AgregarMarcasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarMarcasMC.Location = new System.Drawing.Point(11, 24);
            this.btn_AgregarMarcasMC.Name = "btn_AgregarMarcasMC";
            this.btn_AgregarMarcasMC.Size = new System.Drawing.Size(84, 31);
            this.btn_AgregarMarcasMC.TabIndex = 0;
            this.btn_AgregarMarcasMC.Text = "Agregar";
            this.btn_AgregarMarcasMC.UseVisualStyleBackColor = false;
            this.btn_AgregarMarcasMC.Click += new System.EventHandler(this.btn_AgregarMarcasMC_Click);
            // 
            // btn_EliminarMarcasMC
            // 
            this.btn_EliminarMarcasMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_EliminarMarcasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_EliminarMarcasMC.Location = new System.Drawing.Point(110, 24);
            this.btn_EliminarMarcasMC.Name = "btn_EliminarMarcasMC";
            this.btn_EliminarMarcasMC.Size = new System.Drawing.Size(84, 31);
            this.btn_EliminarMarcasMC.TabIndex = 1;
            this.btn_EliminarMarcasMC.Text = "Eliminar";
            this.btn_EliminarMarcasMC.UseVisualStyleBackColor = false;
            this.btn_EliminarMarcasMC.Click += new System.EventHandler(this.btn_EliminarMarcasMC_Click);
            // 
            // gb_MarcasMC
            // 
            this.gb_MarcasMC.Controls.Add(this.lv_MarcasMC);
            this.gb_MarcasMC.Controls.Add(this.btn_EliminarMarcasMC);
            this.gb_MarcasMC.Controls.Add(this.btn_AgregarMarcasMC);
            this.gb_MarcasMC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_MarcasMC.Location = new System.Drawing.Point(6, 18);
            this.gb_MarcasMC.Name = "gb_MarcasMC";
            this.gb_MarcasMC.Size = new System.Drawing.Size(207, 359);
            this.gb_MarcasMC.TabIndex = 6;
            this.gb_MarcasMC.TabStop = false;
            this.gb_MarcasMC.Text = "Marcas";
            // 
            // lv_MarcasMC
            // 
            this.lv_MarcasMC.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_MarcasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_MarcasMC.HideSelection = false;
            this.lv_MarcasMC.Location = new System.Drawing.Point(11, 73);
            this.lv_MarcasMC.MultiSelect = false;
            this.lv_MarcasMC.Name = "lv_MarcasMC";
            this.lv_MarcasMC.ShowGroups = false;
            this.lv_MarcasMC.Size = new System.Drawing.Size(183, 277);
            this.lv_MarcasMC.TabIndex = 6;
            this.lv_MarcasMC.TileSize = new System.Drawing.Size(220, 20);
            this.lv_MarcasMC.UseCompatibleStateImageBehavior = false;
            this.lv_MarcasMC.View = System.Windows.Forms.View.Tile;
            // 
            // gb_CategoriasMC
            // 
            this.gb_CategoriasMC.Controls.Add(this.lv_CategoriasMC);
            this.gb_CategoriasMC.Controls.Add(this.btn_EliminarCategoriasMC);
            this.gb_CategoriasMC.Controls.Add(this.btn_AgregarCategoriasMC);
            this.gb_CategoriasMC.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_CategoriasMC.Location = new System.Drawing.Point(240, 21);
            this.gb_CategoriasMC.Name = "gb_CategoriasMC";
            this.gb_CategoriasMC.Size = new System.Drawing.Size(207, 359);
            this.gb_CategoriasMC.TabIndex = 7;
            this.gb_CategoriasMC.TabStop = false;
            this.gb_CategoriasMC.Text = "Categorias";
            // 
            // lv_CategoriasMC
            // 
            this.lv_CategoriasMC.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lv_CategoriasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_CategoriasMC.HideSelection = false;
            this.lv_CategoriasMC.Location = new System.Drawing.Point(11, 70);
            this.lv_CategoriasMC.MultiSelect = false;
            this.lv_CategoriasMC.Name = "lv_CategoriasMC";
            this.lv_CategoriasMC.Size = new System.Drawing.Size(183, 277);
            this.lv_CategoriasMC.TabIndex = 7;
            this.lv_CategoriasMC.TileSize = new System.Drawing.Size(200, 20);
            this.lv_CategoriasMC.UseCompatibleStateImageBehavior = false;
            this.lv_CategoriasMC.View = System.Windows.Forms.View.Tile;
            // 
            // btn_EliminarCategoriasMC
            // 
            this.btn_EliminarCategoriasMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_EliminarCategoriasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_EliminarCategoriasMC.Location = new System.Drawing.Point(110, 24);
            this.btn_EliminarCategoriasMC.Name = "btn_EliminarCategoriasMC";
            this.btn_EliminarCategoriasMC.Size = new System.Drawing.Size(84, 31);
            this.btn_EliminarCategoriasMC.TabIndex = 1;
            this.btn_EliminarCategoriasMC.Text = "Eliminar";
            this.btn_EliminarCategoriasMC.UseVisualStyleBackColor = false;
            this.btn_EliminarCategoriasMC.Click += new System.EventHandler(this.btn_EliminarCategoriasMC_Click);
            // 
            // btn_AgregarCategoriasMC
            // 
            this.btn_AgregarCategoriasMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_AgregarCategoriasMC.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold);
            this.btn_AgregarCategoriasMC.Location = new System.Drawing.Point(11, 24);
            this.btn_AgregarCategoriasMC.Name = "btn_AgregarCategoriasMC";
            this.btn_AgregarCategoriasMC.Size = new System.Drawing.Size(84, 31);
            this.btn_AgregarCategoriasMC.TabIndex = 0;
            this.btn_AgregarCategoriasMC.Text = "Agregar";
            this.btn_AgregarCategoriasMC.UseVisualStyleBackColor = false;
            this.btn_AgregarCategoriasMC.Click += new System.EventHandler(this.btn_AgregarCategoriasMC_Click);
            // 
            // wf_MarcasCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 390);
            this.Controls.Add(this.gb_CategoriasMC);
            this.Controls.Add(this.gb_MarcasMC);
            this.MaximizeBox = false;
            this.Name = "wf_MarcasCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_MarcasCategorias";
            this.Load += new System.EventHandler(this.wf_MarcasCategorias_Load_1);
            this.gb_MarcasMC.ResumeLayout(false);
            this.gb_CategoriasMC.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_AgregarMarcasMC;
        private Button btn_EliminarMarcasMC;
        private GroupBox gb_MarcasMC;
        private GroupBox gb_CategoriasMC;
        private Button btn_EliminarCategoriasMC;
        private Button btn_AgregarCategoriasMC;
        private ListView lv_MarcasMC;
        private ListView lv_CategoriasMC;
    }
}