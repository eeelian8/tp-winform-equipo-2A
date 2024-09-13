namespace TPWinForm_equipo_2A
{
    partial class wf_AltaCategoria
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
            this.btn_agregarAltaCategoria = new System.Windows.Forms.Button();
            this.lbl_AltaCategoria = new System.Windows.Forms.Label();
            this.input_nombreAltaCategoria = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_agregarAltaCategoria
            // 
            this.btn_agregarAltaCategoria.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_agregarAltaCategoria.Location = new System.Drawing.Point(137, 140);
            this.btn_agregarAltaCategoria.Name = "btn_agregarAltaCategoria";
            this.btn_agregarAltaCategoria.Size = new System.Drawing.Size(118, 33);
            this.btn_agregarAltaCategoria.TabIndex = 5;
            this.btn_agregarAltaCategoria.Text = "AGREGAR";
            this.btn_agregarAltaCategoria.UseVisualStyleBackColor = false;
            this.btn_agregarAltaCategoria.Click += new System.EventHandler(this.btn_agregarAltaCategoria_Click);
            // 
            // lbl_AltaCategoria
            // 
            this.lbl_AltaCategoria.AutoSize = true;
            this.lbl_AltaCategoria.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AltaCategoria.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AltaCategoria.Location = new System.Drawing.Point(22, 20);
            this.lbl_AltaCategoria.Name = "lbl_AltaCategoria";
            this.lbl_AltaCategoria.Size = new System.Drawing.Size(346, 23);
            this.lbl_AltaCategoria.TabIndex = 4;
            this.lbl_AltaCategoria.Text = "AGREGAR UNA NUEVA CATEGORIA";
            this.lbl_AltaCategoria.Click += new System.EventHandler(this.label1_Click);
            // 
            // input_nombreAltaCategoria
            // 
            this.input_nombreAltaCategoria.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_nombreAltaCategoria.Location = new System.Drawing.Point(46, 63);
            this.input_nombreAltaCategoria.Name = "input_nombreAltaCategoria";
            this.input_nombreAltaCategoria.Size = new System.Drawing.Size(301, 30);
            this.input_nombreAltaCategoria.TabIndex = 3;
            // 
            // wf_AltaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(392, 192);
            this.Controls.Add(this.btn_agregarAltaCategoria);
            this.Controls.Add(this.lbl_AltaCategoria);
            this.Controls.Add(this.input_nombreAltaCategoria);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(408, 231);
            this.Name = "wf_AltaCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "wf_AltaCategoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_agregarAltaCategoria;
        private System.Windows.Forms.Label lbl_AltaCategoria;
        private System.Windows.Forms.TextBox input_nombreAltaCategoria;
    }
}