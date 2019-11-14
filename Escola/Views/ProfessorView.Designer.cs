namespace Escola.Views
{
    partial class ProfessorView
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtDataNascimento = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cbFormacao = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nome";
            // 
            // tbNome
            // 
            this.tbNome.Location = new System.Drawing.Point(153, 13);
            this.tbNome.Name = "tbNome";
            this.tbNome.Size = new System.Drawing.Size(199, 20);
            this.tbNome.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Nascimento";
            // 
            // dtDataNascimento
            // 
            this.dtDataNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDataNascimento.Location = new System.Drawing.Point(153, 45);
            this.dtDataNascimento.Name = "dtDataNascimento";
            this.dtDataNascimento.Size = new System.Drawing.Size(102, 20);
            this.dtDataNascimento.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Formação";
            // 
            // cbFormacao
            // 
            this.cbFormacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFormacao.FormattingEnabled = true;
            this.cbFormacao.Items.AddRange(new object[] {
            "Bacharel",
            "Doutor"});
            this.cbFormacao.Location = new System.Drawing.Point(153, 80);
            this.cbFormacao.Name = "cbFormacao";
            this.cbFormacao.Size = new System.Drawing.Size(121, 21);
            this.cbFormacao.TabIndex = 5;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(12, 215);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(93, 215);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // ProfessorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 250);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbFormacao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtDataNascimento);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbNome);
            this.Controls.Add(this.label1);
            this.Name = "ProfessorView";
            this.Text = "Cadastro de Professor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtDataNascimento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbFormacao;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancelar;
    }
}