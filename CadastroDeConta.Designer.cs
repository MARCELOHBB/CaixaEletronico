namespace CaixaEletronico
{
    partial class CadastroDeConta
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
            this.titularConta = new System.Windows.Forms.TextBox();
            this.numeroDaConta = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.numeroDoRg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numeroDoCpf = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.numeroDaIdade = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Endereço = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tipoDeConta = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // titularConta
            // 
            this.titularConta.Location = new System.Drawing.Point(3, 29);
            this.titularConta.Name = "titularConta";
            this.titularConta.Size = new System.Drawing.Size(100, 20);
            this.titularConta.TabIndex = 0;
            // 
            // numeroDaConta
            // 
            this.numeroDaConta.Location = new System.Drawing.Point(3, 76);
            this.numeroDaConta.Name = "numeroDaConta";
            this.numeroDaConta.Size = new System.Drawing.Size(100, 20);
            this.numeroDaConta.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Adicionar conta\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Numero da conta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "RG:";
            // 
            // numeroDoRg
            // 
            this.numeroDoRg.Location = new System.Drawing.Point(3, 119);
            this.numeroDoRg.Name = "numeroDoRg";
            this.numeroDoRg.Size = new System.Drawing.Size(100, 20);
            this.numeroDoRg.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "CPF:";
            // 
            // numeroDoCpf
            // 
            this.numeroDoCpf.Location = new System.Drawing.Point(3, 165);
            this.numeroDoCpf.Name = "numeroDoCpf";
            this.numeroDoCpf.Size = new System.Drawing.Size(100, 20);
            this.numeroDoCpf.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(183, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Idade:";
            // 
            // numeroDaIdade
            // 
            this.numeroDaIdade.Location = new System.Drawing.Point(147, 29);
            this.numeroDaIdade.Name = "numeroDaIdade";
            this.numeroDaIdade.Size = new System.Drawing.Size(100, 20);
            this.numeroDaIdade.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(183, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Endereço:";
            // 
            // Endereço
            // 
            this.Endereço.Location = new System.Drawing.Point(147, 76);
            this.Endereço.Name = "Endereço";
            this.Endereço.Size = new System.Drawing.Size(100, 20);
            this.Endereço.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(186, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Tipo de conta:";
            // 
            // tipoDeConta
            // 
            this.tipoDeConta.Location = new System.Drawing.Point(162, 146);
            this.tipoDeConta.Name = "tipoDeConta";
            this.tipoDeConta.Size = new System.Drawing.Size(100, 20);
            this.tipoDeConta.TabIndex = 14;
            // 
            // CadastroDeConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 256);
            this.Controls.Add(this.tipoDeConta);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Endereço);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numeroDaIdade);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.numeroDoCpf);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.numeroDoRg);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.numeroDaConta);
            this.Controls.Add(this.titularConta);
            this.Name = "CadastroDeConta";
            this.Text = "CadastroDeConta";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox titularConta;
        private System.Windows.Forms.TextBox numeroDaConta;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox numeroDoRg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox numeroDoCpf;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox numeroDaIdade;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Endereço;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tipoDeConta;
    }
}