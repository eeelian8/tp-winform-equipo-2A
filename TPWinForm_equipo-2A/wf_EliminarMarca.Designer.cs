namespace TPWinForm_equipo_2A
{
    partial class wf_EliminarMarca
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
            this.btn_eliminarMarca = new System.Windows.Forms.Button();
            this.lbl_EliminarMarca = new System.Windows.Forms.Label();
            this.input_idEliminarMarca = new System.Windows.Forms.TextBox();
            this.lbl_estadoEliminacionMarca = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_eliminarMarca
            // 
            this.btn_eliminarMarca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_eliminarMarca.Location = new System.Drawing.Point(93, 153);
            this.btn_eliminarMarca.Name = "btn_eliminarMarca";
            this.btn_eliminarMarca.Size = new System.Drawing.Size(118, 33);
            this.btn_eliminarMarca.TabIndex = 5;
            this.btn_eliminarMarca.Text = "ELIMINAR";
            this.btn_eliminarMarca.UseVisualStyleBackColor = false;
            this.btn_eliminarMarca.Click += new System.EventHandler(this.btn_eliminarMarca_Click);
            // 
            // lbl_EliminarMarca
            // 
            this.lbl_EliminarMarca.AutoSize = true;
            this.lbl_EliminarMarca.Font = new System.Drawing.Font("Tahoma", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EliminarMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_EliminarMarca.Location = new System.Drawing.Point(38, 14);
            this.lbl_EliminarMarca.Name = "lbl_EliminarMarca";
            this.lbl_EliminarMarca.Size = new System.Drawing.Size(222, 19);
            this.lbl_EliminarMarca.TabIndex = 4;
            this.lbl_EliminarMarca.Text = "ELIMINAR MARCA POR ID";
            // 
            // input_idEliminarMarca
            // 
            this.input_idEliminarMarca.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_idEliminarMarca.Location = new System.Drawing.Point(59, 53);
            this.input_idEliminarMarca.Name = "input_idEliminarMarca";
            this.input_idEliminarMarca.Size = new System.Drawing.Size(181, 30);
            this.input_idEliminarMarca.TabIndex = 3;
            // 
            // lbl_estadoEliminacionMarca
            // 
            this.lbl_estadoEliminacionMarca.Location = new System.Drawing.Point(76, 109);
            this.lbl_estadoEliminacionMarca.Name = "lbl_estadoEliminacionMarca";
            this.lbl_estadoEliminacionMarca.Size = new System.Drawing.Size(184, 23);
            this.lbl_estadoEliminacionMarca.TabIndex = 10;
            // 
            // wf_EliminarMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(302, 208);
            this.Controls.Add(this.lbl_estadoEliminacionMarca);
            this.Controls.Add(this.btn_eliminarMarca);
            this.Controls.Add(this.lbl_EliminarMarca);
            this.Controls.Add(this.input_idEliminarMarca);
            this.Name = "wf_EliminarMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_EliminarMarca";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminarMarca;
        private System.Windows.Forms.Label lbl_EliminarMarca;
        private System.Windows.Forms.TextBox input_idEliminarMarca;
        private System.Windows.Forms.Label lbl_estadoEliminacionMarca;
    }
}