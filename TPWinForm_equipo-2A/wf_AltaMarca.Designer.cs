namespace TPWinForm_equipo_2A
{
    partial class wf_AltaMarca
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
            this.input_nombreAltaMarca = new System.Windows.Forms.TextBox();
            this.lbl_AltaMarca = new System.Windows.Forms.Label();
            this.btn_agregarAltaMarca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // input_nombreAltaMarca
            // 
            this.input_nombreAltaMarca.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_nombreAltaMarca.Location = new System.Drawing.Point(46, 70);
            this.input_nombreAltaMarca.Name = "input_nombreAltaMarca";
            this.input_nombreAltaMarca.Size = new System.Drawing.Size(301, 30);
            this.input_nombreAltaMarca.TabIndex = 0;
            // 
            // lbl_AltaMarca
            // 
            this.lbl_AltaMarca.AutoSize = true;
            this.lbl_AltaMarca.Font = new System.Drawing.Font("Tahoma", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AltaMarca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_AltaMarca.Location = new System.Drawing.Point(46, 27);
            this.lbl_AltaMarca.Name = "lbl_AltaMarca";
            this.lbl_AltaMarca.Size = new System.Drawing.Size(301, 23);
            this.lbl_AltaMarca.TabIndex = 1;
            this.lbl_AltaMarca.Text = "AGREGAR UNA NUEVA MARCA";
            // 
            // btn_agregarAltaMarca
            // 
            this.btn_agregarAltaMarca.BackColor = System.Drawing.Color.PaleGreen;
            this.btn_agregarAltaMarca.Location = new System.Drawing.Point(137, 147);
            this.btn_agregarAltaMarca.Name = "btn_agregarAltaMarca";
            this.btn_agregarAltaMarca.Size = new System.Drawing.Size(118, 33);
            this.btn_agregarAltaMarca.TabIndex = 2;
            this.btn_agregarAltaMarca.Text = "AGREGAR";
            this.btn_agregarAltaMarca.UseVisualStyleBackColor = false;
            this.btn_agregarAltaMarca.Click += new System.EventHandler(this.btn_agregarAltaMarca_Click);
            // 
            // wf_AltaMarca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(392, 192);
            this.Controls.Add(this.btn_agregarAltaMarca);
            this.Controls.Add(this.lbl_AltaMarca);
            this.Controls.Add(this.input_nombreAltaMarca);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(408, 231);
            this.MinimumSize = new System.Drawing.Size(408, 231);
            this.Name = "wf_AltaMarca";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Alta de marca";
            this.Load += new System.EventHandler(this.wf_AltaMarca_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_nombreAltaMarca;
        private System.Windows.Forms.Label lbl_AltaMarca;
        private System.Windows.Forms.Button btn_agregarAltaMarca;
    }
}