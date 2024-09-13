using System.Drawing;
using System.Windows.Forms;

namespace TPWinForm_equipo_2A
{
    partial class wf_ADM_EliminarArticulo
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
            this.lbl_NroArticuloEA = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_EliminarEA = new System.Windows.Forms.Button();
            this.input_NroArticuloEA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbl_NroArticuloEA
            // 
            this.lbl_NroArticuloEA.AutoSize = true;
            this.lbl_NroArticuloEA.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroArticuloEA.Location = new System.Drawing.Point(22, 58);
            this.lbl_NroArticuloEA.Name = "lbl_NroArticuloEA";
            this.lbl_NroArticuloEA.Size = new System.Drawing.Size(277, 19);
            this.lbl_NroArticuloEA.TabIndex = 0;
            this.lbl_NroArticuloEA.Text = "INGRESE EL CODIGO DE ARTICULO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 273);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // btn_EliminarEA
            // 
            this.btn_EliminarEA.BackColor = System.Drawing.Color.Tomato;
            this.btn_EliminarEA.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_EliminarEA.ForeColor = System.Drawing.Color.Black;
            this.btn_EliminarEA.Location = new System.Drawing.Point(120, 192);
            this.btn_EliminarEA.Name = "btn_EliminarEA";
            this.btn_EliminarEA.Size = new System.Drawing.Size(92, 31);
            this.btn_EliminarEA.TabIndex = 2;
            this.btn_EliminarEA.Text = "ELIMINAR";
            this.btn_EliminarEA.UseVisualStyleBackColor = false;
            // 
            // input_NroArticuloEA
            // 
            this.input_NroArticuloEA.Location = new System.Drawing.Point(70, 80);
            this.input_NroArticuloEA.Name = "input_NroArticuloEA";
            this.input_NroArticuloEA.Size = new System.Drawing.Size(180, 20);
            this.input_NroArticuloEA.TabIndex = 3;
            // 
            // wf_ADM_EliminarArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 270);
            this.Controls.Add(this.input_NroArticuloEA);
            this.Controls.Add(this.btn_EliminarEA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_NroArticuloEA);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(337, 309);
            this.Name = "wf_ADM_EliminarArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_EliminarArticulo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lbl_NroArticuloEA;
        private Label label2;
        private Button btn_EliminarEA;
        private TextBox input_NroArticuloEA;
    }
}