namespace RotasAreas
{
    partial class frmRotas
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRotas));
            this.imgRotasAereas = new System.Windows.Forms.ImageList(this.components);
            this.dlgNomesCidades = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // imgRotasAereas
            // 
            this.imgRotasAereas.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgRotasAereas.ImageStream")));
            this.imgRotasAereas.TransparentColor = System.Drawing.Color.Transparent;
            this.imgRotasAereas.Images.SetKeyName(0, "Mapa Marte sem rotas.jpg");
            // 
            // dlgNomesCidades
            // 
            this.dlgNomesCidades.FileName = "openFileDialog1";
            this.dlgNomesCidades.FileOk += new System.ComponentModel.CancelEventHandler(this.dlgNomesCidades_FileOk);
            // 
            // frmRotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Name = "frmRotas";
            this.Text = "Rotas Aéreas entre cidades";
            this.Load += new System.EventHandler(this.frmRotas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imgRotasAereas;
        private System.Windows.Forms.OpenFileDialog dlgNomesCidades;
    }
}

