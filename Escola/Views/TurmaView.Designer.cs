namespace Escola.Views
{
    partial class TurmaView
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
            this.tbDescricao = new System.Windows.Forms.TextBox();
            this.Ano = new System.Windows.Forms.Label();
            this.nuAno = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.cbProfessor = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbDisciplina = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgAlunos = new System.Windows.Forms.DataGridView();
            this.Checar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIniciar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nuAno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição";
            // 
            // tbDescricao
            // 
            this.tbDescricao.Location = new System.Drawing.Point(86, 10);
            this.tbDescricao.Name = "tbDescricao";
            this.tbDescricao.Size = new System.Drawing.Size(121, 20);
            this.tbDescricao.TabIndex = 1;
            // 
            // Ano
            // 
            this.Ano.AutoSize = true;
            this.Ano.Location = new System.Drawing.Point(237, 13);
            this.Ano.Name = "Ano";
            this.Ano.Size = new System.Drawing.Size(26, 13);
            this.Ano.TabIndex = 2;
            this.Ano.Text = "Ano";
            // 
            // nuAno
            // 
            this.nuAno.Location = new System.Drawing.Point(306, 11);
            this.nuAno.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nuAno.Name = "nuAno";
            this.nuAno.Size = new System.Drawing.Size(120, 20);
            this.nuAno.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Professor";
            // 
            // cbProfessor
            // 
            this.cbProfessor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbProfessor.FormattingEnabled = true;
            this.cbProfessor.Location = new System.Drawing.Point(86, 40);
            this.cbProfessor.Name = "cbProfessor";
            this.cbProfessor.Size = new System.Drawing.Size(121, 21);
            this.cbProfessor.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(237, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Disciplina";
            // 
            // cbDisciplina
            // 
            this.cbDisciplina.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDisciplina.FormattingEnabled = true;
            this.cbDisciplina.Location = new System.Drawing.Point(305, 40);
            this.cbDisciplina.Name = "cbDisciplina";
            this.cbDisciplina.Size = new System.Drawing.Size(121, 21);
            this.cbDisciplina.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Alunos";
            // 
            // dgAlunos
            // 
            this.dgAlunos.AllowUserToAddRows = false;
            this.dgAlunos.AllowUserToDeleteRows = false;
            this.dgAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAlunos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Checar,
            this.Id,
            this.Nome});
            this.dgAlunos.Location = new System.Drawing.Point(86, 87);
            this.dgAlunos.Name = "dgAlunos";
            this.dgAlunos.Size = new System.Drawing.Size(340, 150);
            this.dgAlunos.TabIndex = 9;
            this.dgAlunos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellContentClick);
            this.dgAlunos.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgAlunos_CellValueChanged);
            // 
            // Checar
            // 
            this.Checar.HeaderText = "#";
            this.Checar.Name = "Checar";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // Nome
            // 
            this.Nome.DataPropertyName = "Nome";
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(19, 270);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(75, 23);
            this.btnIniciar.TabIndex = 10;
            this.btnIniciar.Text = "Iniciar";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // TurmaView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 305);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.dgAlunos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbDisciplina);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbProfessor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nuAno);
            this.Controls.Add(this.Ano);
            this.Controls.Add(this.tbDescricao);
            this.Controls.Add(this.label1);
            this.Name = "TurmaView";
            this.Text = "TurmaView";
            ((System.ComponentModel.ISupportInitialize)(this.nuAno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgAlunos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbDescricao;
        private System.Windows.Forms.Label Ano;
        private System.Windows.Forms.NumericUpDown nuAno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbProfessor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbDisciplina;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgAlunos;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Checar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
    }
}