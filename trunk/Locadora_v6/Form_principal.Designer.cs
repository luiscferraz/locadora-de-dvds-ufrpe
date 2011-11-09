namespace Locadora_v6
{
    partial class Form_principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_principal));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lb_status1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lb_status2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.bt_clientes = new System.Windows.Forms.Button();
            this.bt_acervo = new System.Windows.Forms.Button();
            this.bt_loc_dev = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bt_funcionarios = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_fornecedores = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_caixa = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status1,
            this.lb_status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(716, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_status1
            // 
            this.lb_status1.Name = "lb_status1";
            this.lb_status1.Size = new System.Drawing.Size(135, 17);
            this.lb_status1.Text = "toolStripStatusLabel1";
            // 
            // lb_status2
            // 
            this.lb_status2.Name = "lb_status2";
            this.lb_status2.Size = new System.Drawing.Size(135, 17);
            this.lb_status2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bt_clientes.Image")));
            this.bt_clientes.Location = new System.Drawing.Point(31, 21);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(133, 140);
            this.bt_clientes.TabIndex = 11;
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // bt_acervo
            // 
            this.bt_acervo.Image = ((System.Drawing.Image)(resources.GetObject("bt_acervo.Image")));
            this.bt_acervo.Location = new System.Drawing.Point(206, 21);
            this.bt_acervo.Name = "bt_acervo";
            this.bt_acervo.Size = new System.Drawing.Size(133, 140);
            this.bt_acervo.TabIndex = 12;
            this.bt_acervo.UseVisualStyleBackColor = true;
            this.bt_acervo.Click += new System.EventHandler(this.bt_acervo_Click);
            // 
            // bt_loc_dev
            // 
            this.bt_loc_dev.Image = ((System.Drawing.Image)(resources.GetObject("bt_loc_dev.Image")));
            this.bt_loc_dev.Location = new System.Drawing.Point(380, 21);
            this.bt_loc_dev.Name = "bt_loc_dev";
            this.bt_loc_dev.Size = new System.Drawing.Size(133, 140);
            this.bt_loc_dev.TabIndex = 13;
            this.bt_loc_dev.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(250, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Acervo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(377, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 16);
            this.label3.TabIndex = 16;
            this.label3.Text = "Locação e Devolução";
            // 
            // bt_funcionarios
            // 
            this.bt_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_funcionarios.Image")));
            this.bt_funcionarios.Location = new System.Drawing.Point(554, 21);
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Size = new System.Drawing.Size(133, 140);
            this.bt_funcionarios.TabIndex = 17;
            this.bt_funcionarios.UseVisualStyleBackColor = true;
            this.bt_funcionarios.Click += new System.EventHandler(this.bt_funcionarios_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Funcionários";
            // 
            // bt_fornecedores
            // 
            this.bt_fornecedores.Image = ((System.Drawing.Image)(resources.GetObject("bt_fornecedores.Image")));
            this.bt_fornecedores.Location = new System.Drawing.Point(31, 230);
            this.bt_fornecedores.Name = "bt_fornecedores";
            this.bt_fornecedores.Size = new System.Drawing.Size(133, 140);
            this.bt_fornecedores.TabIndex = 19;
            this.bt_fornecedores.UseVisualStyleBackColor = true;
            this.bt_fornecedores.Click += new System.EventHandler(this.bt_fornecedores_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 386);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Fornecedores";
            // 
            // bt_caixa
            // 
            this.bt_caixa.Image = ((System.Drawing.Image)(resources.GetObject("bt_caixa.Image")));
            this.bt_caixa.Location = new System.Drawing.Point(206, 230);
            this.bt_caixa.Name = "bt_caixa";
            this.bt_caixa.Size = new System.Drawing.Size(133, 140);
            this.bt_caixa.TabIndex = 21;
            this.bt_caixa.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 16);
            this.label6.TabIndex = 22;
            this.label6.Text = "Caixa";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(380, 230);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(133, 140);
            this.button2.TabIndex = 24;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(424, 386);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 16);
            this.label7.TabIndex = 25;
            this.label7.Text = "Contas";
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(554, 230);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(133, 139);
            this.button3.TabIndex = 26;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(583, 386);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 16);
            this.label8.TabIndex = 27;
            this.label8.Text = "Ferramentas";
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(716, 447);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bt_caixa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.bt_fornecedores);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_funcionarios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bt_loc_dev);
            this.Controls.Add(this.bt_acervo);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.statusStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de DVD\'s";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.Button bt_acervo;
        private System.Windows.Forms.Button bt_loc_dev;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bt_funcionarios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_fornecedores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_caixa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label8;
    }
}