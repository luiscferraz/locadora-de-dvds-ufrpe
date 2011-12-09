namespace Locadora_de_DVDs
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
            this.button2 = new System.Windows.Forms.Button();
            this.bt_caixa = new System.Windows.Forms.Button();
            this.bt_fornecedores = new System.Windows.Forms.Button();
            this.bt_funcionarios = new System.Windows.Forms.Button();
            this.bt_acervo = new System.Windows.Forms.Button();
            this.bt_clientes = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lb_status1,
            this.lb_status2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 778);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1280, 22);
            this.statusStrip1.TabIndex = 44;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lb_status1
            // 
            this.lb_status1.Name = "lb_status1";
            this.lb_status1.Size = new System.Drawing.Size(131, 17);
            this.lb_status1.Text = "toolStripStatusLabel1";
            // 
            // lb_status2
            // 
            this.lb_status2.Name = "lb_status2";
            this.lb_status2.Size = new System.Drawing.Size(131, 17);
            this.lb_status2.Text = "toolStripStatusLabel2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(242, 591);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(153, 162);
            this.button2.TabIndex = 57;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // bt_caixa
            // 
            this.bt_caixa.Image = ((System.Drawing.Image)(resources.GetObject("bt_caixa.Image")));
            this.bt_caixa.Location = new System.Drawing.Point(43, 591);
            this.bt_caixa.Name = "bt_caixa";
            this.bt_caixa.Size = new System.Drawing.Size(153, 162);
            this.bt_caixa.TabIndex = 55;
            this.bt_caixa.UseVisualStyleBackColor = true;
            this.bt_caixa.Click += new System.EventHandler(this.bt_caixa_Click);
            // 
            // bt_fornecedores
            // 
            this.bt_fornecedores.Image = ((System.Drawing.Image)(resources.GetObject("bt_fornecedores.Image")));
            this.bt_fornecedores.Location = new System.Drawing.Point(242, 398);
            this.bt_fornecedores.Name = "bt_fornecedores";
            this.bt_fornecedores.Size = new System.Drawing.Size(153, 162);
            this.bt_fornecedores.TabIndex = 53;
            this.bt_fornecedores.UseVisualStyleBackColor = true;
            this.bt_fornecedores.Click += new System.EventHandler(this.bt_fornecedores_Click);
            // 
            // bt_funcionarios
            // 
            this.bt_funcionarios.Image = ((System.Drawing.Image)(resources.GetObject("bt_funcionarios.Image")));
            this.bt_funcionarios.Location = new System.Drawing.Point(242, 208);
            this.bt_funcionarios.Name = "bt_funcionarios";
            this.bt_funcionarios.Size = new System.Drawing.Size(153, 162);
            this.bt_funcionarios.TabIndex = 51;
            this.bt_funcionarios.UseVisualStyleBackColor = true;
            this.bt_funcionarios.Click += new System.EventHandler(this.bt_funcionarios_Click);
            // 
            // bt_acervo
            // 
            this.bt_acervo.Image = ((System.Drawing.Image)(resources.GetObject("bt_acervo.Image")));
            this.bt_acervo.Location = new System.Drawing.Point(43, 398);
            this.bt_acervo.Name = "bt_acervo";
            this.bt_acervo.Size = new System.Drawing.Size(153, 162);
            this.bt_acervo.TabIndex = 46;
            this.bt_acervo.UseVisualStyleBackColor = true;
            this.bt_acervo.Click += new System.EventHandler(this.bt_acervo_Click);
            // 
            // bt_clientes
            // 
            this.bt_clientes.Image = ((System.Drawing.Image)(resources.GetObject("bt_clientes.Image")));
            this.bt_clientes.Location = new System.Drawing.Point(43, 208);
            this.bt_clientes.Name = "bt_clientes";
            this.bt_clientes.Size = new System.Drawing.Size(153, 162);
            this.bt_clientes.TabIndex = 45;
            this.bt_clientes.UseVisualStyleBackColor = true;
            this.bt_clientes.Click += new System.EventHandler(this.bt_clientes_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(29, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(384, 765);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 58;
            this.pictureBox1.TabStop = false;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(43, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(352, 45);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Image = ((System.Drawing.Image)(resources.GetObject("button3.Image")));
            this.button3.Location = new System.Drawing.Point(43, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(352, 45);
            this.button3.TabIndex = 60;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.Location = new System.Drawing.Point(43, 149);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(352, 45);
            this.button4.TabIndex = 61;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(444, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(824, 745);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 62;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(476, 61);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(760, 681);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 63;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, -2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(1280, 26);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 64;
            this.pictureBox4.TabStop = false;
            // 
            // button5
            // 
            this.button5.Image = ((System.Drawing.Image)(resources.GetObject("button5.Image")));
            this.button5.Location = new System.Drawing.Point(1243, -2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(25, 26);
            this.button5.TabIndex = 65;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(989, 652);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(236, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 66;
            this.pictureBox5.TabStop = false;
            // 
            // Form_principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.bt_caixa);
            this.Controls.Add(this.bt_fornecedores);
            this.Controls.Add(this.bt_funcionarios);
            this.Controls.Add(this.bt_acervo);
            this.Controls.Add(this.bt_clientes);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Locadora de DVDs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status1;
        private System.Windows.Forms.ToolStripStatusLabel lb_status2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button bt_caixa;
        private System.Windows.Forms.Button bt_fornecedores;
        private System.Windows.Forms.Button bt_funcionarios;
        private System.Windows.Forms.Button bt_acervo;
        private System.Windows.Forms.Button bt_clientes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox5;

    }
}