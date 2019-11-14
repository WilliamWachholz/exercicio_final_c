namespace Escola.Views
{
    partial class DadosTurmaView
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
            this.tbDados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbDados
            // 
            this.tbDados.Location = new System.Drawing.Point(13, 13);
            this.tbDados.Multiline = true;
            this.tbDados.Name = "tbDados";
            this.tbDados.ReadOnly = true;
            this.tbDados.Size = new System.Drawing.Size(351, 291);
            this.tbDados.TabIndex = 0;
            // 
            // DadosTurmaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 316);
            this.Controls.Add(this.tbDados);
            this.Name = "DadosTurmaView";
            this.Text = "DadosTurmaView";
            this.Shown += new System.EventHandler(this.DadosTurmaView_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDados;
    }
}