namespace TPWinForm_equipo_2A
{
    partial class wf_EliminarCategoria
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
            this.btn_eliminarCategoria = new System.Windows.Forms.Button();
            this.lbl_EliminarCategoria = new System.Windows.Forms.Label();
            this.input_idEliminarCategoria = new System.Windows.Forms.TextBox();
            this.lbl_estadoEliminacionCategoria = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_eliminarCategoria
            // 
            this.btn_eliminarCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eliminarCategoria.Location = new System.Drawing.Point(95, 147);
            this.btn_eliminarCategoria.Name = "btn_eliminarCategoria";
            this.btn_eliminarCategoria.Size = new System.Drawing.Size(118, 33);
            this.btn_eliminarCategoria.TabIndex = 8;
            this.btn_eliminarCategoria.Text = "ELIMINAR";
            this.btn_eliminarCategoria.UseVisualStyleBackColor = false;
            this.btn_eliminarCategoria.Click += new System.EventHandler(this.btn_eliminarCategoria_Click);
            // 
            // lbl_EliminarCategoria
            // 
            this.lbl_EliminarCategoria.AutoSize = true;
            this.lbl_EliminarCategoria.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EliminarCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_EliminarCategoria.Location = new System.Drawing.Point(18, 12);
            this.lbl_EliminarCategoria.Name = "lbl_EliminarCategoria";
            this.lbl_EliminarCategoria.Size = new System.Drawing.Size(260, 19);
            this.lbl_EliminarCategoria.TabIndex = 7;
            this.lbl_EliminarCategoria.Text = "ELIMINAR CATEGORIA POR ID";
            // 
            // input_idEliminarCategoria
            // 
            this.input_idEliminarCategoria.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_idEliminarCategoria.Location = new System.Drawing.Point(61, 51);
            this.input_idEliminarCategoria.Name = "input_idEliminarCategoria";
            this.input_idEliminarCategoria.Size = new System.Drawing.Size(181, 30);
            this.input_idEliminarCategoria.TabIndex = 6;
            // 
            // lbl_estadoEliminacionCategoria
            // 
            this.lbl_estadoEliminacionCategoria.Location = new System.Drawing.Point(72, 108);
            this.lbl_estadoEliminacionCategoria.Name = "lbl_estadoEliminacionCategoria";
            this.lbl_estadoEliminacionCategoria.Size = new System.Drawing.Size(184, 23);
            this.lbl_estadoEliminacionCategoria.TabIndex = 9;
            // 
            // wf_EliminarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(302, 208);
            this.Controls.Add(this.lbl_estadoEliminacionCategoria);
            this.Controls.Add(this.btn_eliminarCategoria);
            this.Controls.Add(this.lbl_EliminarCategoria);
            this.Controls.Add(this.input_idEliminarCategoria);
            this.MaximumSize = new System.Drawing.Size(318, 247);
            this.MinimumSize = new System.Drawing.Size(318, 247);
            this.Name = "wf_EliminarCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Eliminar categoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminarCategoria;
        private System.Windows.Forms.Label lbl_EliminarCategoria;
        private System.Windows.Forms.TextBox input_idEliminarCategoria;
        private System.Windows.Forms.Label lbl_estadoEliminacionCategoria;
    }
}