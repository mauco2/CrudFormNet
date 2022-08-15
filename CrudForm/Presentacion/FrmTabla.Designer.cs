
namespace CrudForm.Presentacion
{
    partial class FrmTabla
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
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblFecnac = new System.Windows.Forms.Label();
            this.LblCorreo = new System.Windows.Forms.Label();
            this.TxtNombre = new System.Windows.Forms.TextBox();
            this.TxtCorreo = new System.Windows.Forms.TextBox();
            this.DtpFecnac = new System.Windows.Forms.DateTimePicker();
            this.BtnGuardar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.Location = new System.Drawing.Point(22, 26);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(65, 20);
            this.LblNombre.TabIndex = 0;
            this.LblNombre.Text = "Nombre";
            // 
            // LblFecnac
            // 
            this.LblFecnac.AutoSize = true;
            this.LblFecnac.Location = new System.Drawing.Point(22, 133);
            this.LblFecnac.Name = "LblFecnac";
            this.LblFecnac.Size = new System.Drawing.Size(90, 20);
            this.LblFecnac.TabIndex = 1;
            this.LblFecnac.Text = "Fecha Nac.";
            // 
            // LblCorreo
            // 
            this.LblCorreo.AutoSize = true;
            this.LblCorreo.Location = new System.Drawing.Point(22, 79);
            this.LblCorreo.Name = "LblCorreo";
            this.LblCorreo.Size = new System.Drawing.Size(57, 20);
            this.LblCorreo.TabIndex = 2;
            this.LblCorreo.Text = "Correo";
            // 
            // TxtNombre
            // 
            this.TxtNombre.Location = new System.Drawing.Point(130, 26);
            this.TxtNombre.MaxLength = 50;
            this.TxtNombre.Name = "TxtNombre";
            this.TxtNombre.Size = new System.Drawing.Size(279, 26);
            this.TxtNombre.TabIndex = 1;
            // 
            // TxtCorreo
            // 
            this.TxtCorreo.Location = new System.Drawing.Point(130, 79);
            this.TxtCorreo.MaxLength = 50;
            this.TxtCorreo.Name = "TxtCorreo";
            this.TxtCorreo.Size = new System.Drawing.Size(279, 26);
            this.TxtCorreo.TabIndex = 2;
            // 
            // DtpFecnac
            // 
            this.DtpFecnac.Location = new System.Drawing.Point(130, 133);
            this.DtpFecnac.Name = "DtpFecnac";
            this.DtpFecnac.Size = new System.Drawing.Size(279, 26);
            this.DtpFecnac.TabIndex = 3;
            // 
            // BtnGuardar
            // 
            this.BtnGuardar.Location = new System.Drawing.Point(316, 238);
            this.BtnGuardar.Name = "BtnGuardar";
            this.BtnGuardar.Size = new System.Drawing.Size(93, 44);
            this.BtnGuardar.TabIndex = 4;
            this.BtnGuardar.Text = "Guadar";
            this.BtnGuardar.UseVisualStyleBackColor = true;
            this.BtnGuardar.Click += new System.EventHandler(this.BtnGuardar_Click);
            // 
            // FrmTabla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 311);
            this.Controls.Add(this.BtnGuardar);
            this.Controls.Add(this.DtpFecnac);
            this.Controls.Add(this.TxtCorreo);
            this.Controls.Add(this.TxtNombre);
            this.Controls.Add(this.LblCorreo);
            this.Controls.Add(this.LblFecnac);
            this.Controls.Add(this.LblNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmTabla";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " Datos de la Tabla";
            this.Load += new System.EventHandler(this.FrmTabla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblNombre;
        private System.Windows.Forms.Label LblFecnac;
        private System.Windows.Forms.Label LblCorreo;
        private System.Windows.Forms.TextBox TxtNombre;
        private System.Windows.Forms.TextBox TxtCorreo;
        private System.Windows.Forms.DateTimePicker DtpFecnac;
        private System.Windows.Forms.Button BtnGuardar;
    }
}