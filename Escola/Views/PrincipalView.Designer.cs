namespace Escola.Views
{
    partial class PrincipalView
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
            this.btnDisciplina = new System.Windows.Forms.Button();
            this.btnProfessor = new System.Windows.Forms.Button();
            this.btnAluno = new System.Windows.Forms.Button();
            this.btnTurma = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDisciplina
            // 
            this.btnDisciplina.Location = new System.Drawing.Point(13, 13);
            this.btnDisciplina.Name = "btnDisciplina";
            this.btnDisciplina.Size = new System.Drawing.Size(129, 23);
            this.btnDisciplina.TabIndex = 0;
            this.btnDisciplina.Text = "Cadastro de Disciplina";
            this.btnDisciplina.UseVisualStyleBackColor = true;
            this.btnDisciplina.Click += new System.EventHandler(this.btnDisciplina_Click);
            // 
            // btnProfessor
            // 
            this.btnProfessor.Location = new System.Drawing.Point(149, 13);
            this.btnProfessor.Name = "btnProfessor";
            this.btnProfessor.Size = new System.Drawing.Size(150, 23);
            this.btnProfessor.TabIndex = 1;
            this.btnProfessor.Text = "Cadastro de Professor";
            this.btnProfessor.UseVisualStyleBackColor = true;
            this.btnProfessor.Click += new System.EventHandler(this.btnProfessor_Click);
            // 
            // btnAluno
            // 
            this.btnAluno.Location = new System.Drawing.Point(306, 13);
            this.btnAluno.Name = "btnAluno";
            this.btnAluno.Size = new System.Drawing.Size(152, 23);
            this.btnAluno.TabIndex = 2;
            this.btnAluno.Text = "Cadastro de Aluno";
            this.btnAluno.UseVisualStyleBackColor = true;
            this.btnAluno.Click += new System.EventHandler(this.btnAluno_Click);
            // 
            // btnTurma
            // 
            this.btnTurma.Location = new System.Drawing.Point(13, 63);
            this.btnTurma.Name = "btnTurma";
            this.btnTurma.Size = new System.Drawing.Size(129, 23);
            this.btnTurma.TabIndex = 3;
            this.btnTurma.Text = "Iniciar Nova Turma";
            this.btnTurma.UseVisualStyleBackColor = true;
            this.btnTurma.Click += new System.EventHandler(this.btnTurma_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(383, 313);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 4;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // PrincipalView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 348);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnTurma);
            this.Controls.Add(this.btnAluno);
            this.Controls.Add(this.btnProfessor);
            this.Controls.Add(this.btnDisciplina);
            this.Name = "PrincipalView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema de Escola";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDisciplina;
        private System.Windows.Forms.Button btnProfessor;
        private System.Windows.Forms.Button btnAluno;
        private System.Windows.Forms.Button btnTurma;
        private System.Windows.Forms.Button btnFechar;
    }
}