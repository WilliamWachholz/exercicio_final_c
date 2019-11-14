namespace Escola.Views
{
    partial class AlunoView
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbNivelEscolaridade = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(95, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(14, 214);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(155, 44);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtDataNascimento.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Data Nascimento";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(155, 12);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(199, 20);
            this.tbNome.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nome";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Nível Escolaridade";
            // 
            // cbNivelEscolaridade
            // 
            this.cbNivelEscolaridade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNivelEscolaridade.FormattingEnabled = true;
            this.cbNivelEscolaridade.Items.AddRange(new object[] {
            "Fundamental",
            "Médio"});
            this.cbNivelEscolaridade.Location = new System.Drawing.Point(155, 86);
            this.cbNivelEscolaridade.Name = "cbNivelEscolaridade";
            this.cbNivelEscolaridade.Size = new System.Drawing.Size(121, 21);
            this.cbNivelEscolaridade.TabIndex = 15;
            // 
            // AlunoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 260);
            this.Controls.Add(this.cbNivelEscolaridade);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "AlunoView";
            this.Text = "Cadastro de Aluno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbNivelEscolaridade;
    }
}