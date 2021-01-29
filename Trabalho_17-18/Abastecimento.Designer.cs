namespace Trabalho_17_18
{
    partial class Abastecimento
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
            this.btnPagar = new System.Windows.Forms.Button();
            this.lbxCombustivel = new System.Windows.Forms.Label();
            this.lbxTipo = new System.Windows.Forms.ListBox();
            this.btnDesbloquear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.lblEstadoBomba = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtPagar = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(389, 388);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(81, 54);
            this.btnPagar.TabIndex = 0;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // lbxCombustivel
            // 
            this.lbxCombustivel.AutoSize = true;
            this.lbxCombustivel.Location = new System.Drawing.Point(277, 229);
            this.lbxCombustivel.Name = "lbxCombustivel";
            this.lbxCombustivel.Size = new System.Drawing.Size(106, 13);
            this.lbxCombustivel.TabIndex = 3;
            this.lbxCombustivel.Text = "Tipo de Combustivel:";
            // 
            // lbxTipo
            // 
            this.lbxTipo.FormattingEnabled = true;
            this.lbxTipo.Items.AddRange(new object[] {
            "Gasolina",
            "Gasolina+",
            "Gasóleo",
            "Gasóleo+"});
            this.lbxTipo.Location = new System.Drawing.Point(389, 229);
            this.lbxTipo.Name = "lbxTipo";
            this.lbxTipo.Size = new System.Drawing.Size(66, 69);
            this.lbxTipo.TabIndex = 4;
            this.lbxTipo.SelectedIndexChanged += new System.EventHandler(this.lbxTipo_SelectedIndexChanged);
            // 
            // btnDesbloquear
            // 
            this.btnDesbloquear.Location = new System.Drawing.Point(48, 388);
            this.btnDesbloquear.Name = "btnDesbloquear";
            this.btnDesbloquear.Size = new System.Drawing.Size(81, 54);
            this.btnDesbloquear.TabIndex = 5;
            this.btnDesbloquear.Text = "Desbloquear";
            this.btnDesbloquear.UseVisualStyleBackColor = true;
            this.btnDesbloquear.Click += new System.EventHandler(this.btnDesbloquear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Quantidade";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(125, 229);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 304);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Valor a Pagar";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(220, 388);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(81, 54);
            this.btnCalcular.TabIndex = 10;
            this.btnCalcular.Text = "Calcular Valor a Pagar";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Bombas";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(143, 101);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(28, 23);
            this.btn1.TabIndex = 13;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(177, 101);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(28, 23);
            this.btn2.TabIndex = 14;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Location = new System.Drawing.Point(211, 101);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(28, 23);
            this.btn3.TabIndex = 15;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.Location = new System.Drawing.Point(245, 101);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(28, 23);
            this.btn4.TabIndex = 16;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // lblEstadoBomba
            // 
            this.lblEstadoBomba.AutoSize = true;
            this.lblEstadoBomba.Location = new System.Drawing.Point(45, 159);
            this.lblEstadoBomba.Name = "lblEstadoBomba";
            this.lblEstadoBomba.Size = new System.Drawing.Size(100, 13);
            this.lblEstadoBomba.TabIndex = 17;
            this.lblEstadoBomba.Text = "Estado da Bomba   ";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(140, 159);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 18;
            // 
            // txtPagar
            // 
            this.txtPagar.Location = new System.Drawing.Point(125, 304);
            this.txtPagar.Name = "txtPagar";
            this.txtPagar.Size = new System.Drawing.Size(100, 20);
            this.txtPagar.TabIndex = 19;
            // 
            // Abastecimento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 516);
            this.Controls.Add(this.txtPagar);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblEstadoBomba);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDesbloquear);
            this.Controls.Add(this.lbxTipo);
            this.Controls.Add(this.lbxCombustivel);
            this.Controls.Add(this.btnPagar);
            this.Name = "Abastecimento";
            this.Text = "Bomba";
            this.Shown += new System.EventHandler(this.Abastecimento_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label lbxCombustivel;
        private System.Windows.Forms.ListBox lbxTipo;
        private System.Windows.Forms.Button btnDesbloquear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Label lblEstadoBomba;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtPagar;
    }
}

