
namespace Sistema_de_Atendimento
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblGcaract = new System.Windows.Forms.Label();
            this.lblPcaract = new System.Windows.Forms.Label();
            this.lblLetraPrio = new System.Windows.Forms.Label();
            this.lblLetraGeral = new System.Windows.Forms.Label();
            this.btnPrioritarios = new System.Windows.Forms.Button();
            this.btnGeral = new System.Windows.Forms.Button();
            this.lblNumPrio = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblNumGeral = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGiche = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDisplayNum = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblSenhasEspera = new System.Windows.Forms.Label();
            this.btnGuichet3 = new System.Windows.Forms.Button();
            this.btnGuichet2 = new System.Windows.Forms.Button();
            this.btnGuichet1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Navy;
            this.groupBox1.Controls.Add(this.lblGcaract);
            this.groupBox1.Controls.Add(this.lblPcaract);
            this.groupBox1.Controls.Add(this.lblLetraPrio);
            this.groupBox1.Controls.Add(this.lblLetraGeral);
            this.groupBox1.Controls.Add(this.btnPrioritarios);
            this.groupBox1.Controls.Add(this.btnGeral);
            this.groupBox1.Controls.Add(this.lblNumPrio);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblNumGeral);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox1.Location = new System.Drawing.Point(26, 367);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(466, 230);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Senhas";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblGcaract
            // 
            this.lblGcaract.AutoSize = true;
            this.lblGcaract.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGcaract.ForeColor = System.Drawing.Color.Orange;
            this.lblGcaract.Location = new System.Drawing.Point(247, 74);
            this.lblGcaract.Name = "lblGcaract";
            this.lblGcaract.Size = new System.Drawing.Size(55, 33);
            this.lblGcaract.TabIndex = 8;
            this.lblGcaract.Text = "G -";
            // 
            // lblPcaract
            // 
            this.lblPcaract.AutoSize = true;
            this.lblPcaract.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPcaract.ForeColor = System.Drawing.Color.Orange;
            this.lblPcaract.Location = new System.Drawing.Point(247, 153);
            this.lblPcaract.Name = "lblPcaract";
            this.lblPcaract.Size = new System.Drawing.Size(53, 33);
            this.lblPcaract.TabIndex = 7;
            this.lblPcaract.Text = "P -";
            this.lblPcaract.Click += new System.EventHandler(this.lblPcaract_Click);
            // 
            // lblLetraPrio
            // 
            this.lblLetraPrio.AutoSize = true;
            this.lblLetraPrio.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraPrio.ForeColor = System.Drawing.Color.Orange;
            this.lblLetraPrio.Location = new System.Drawing.Point(301, 153);
            this.lblLetraPrio.Name = "lblLetraPrio";
            this.lblLetraPrio.Size = new System.Drawing.Size(33, 33);
            this.lblLetraPrio.TabIndex = 6;
            this.lblLetraPrio.Text = "A";
            this.lblLetraPrio.Click += new System.EventHandler(this.lblLetraPrio_Click);
            // 
            // lblLetraGeral
            // 
            this.lblLetraGeral.AutoSize = true;
            this.lblLetraGeral.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLetraGeral.ForeColor = System.Drawing.Color.Orange;
            this.lblLetraGeral.Location = new System.Drawing.Point(301, 74);
            this.lblLetraGeral.Name = "lblLetraGeral";
            this.lblLetraGeral.Size = new System.Drawing.Size(33, 33);
            this.lblLetraGeral.TabIndex = 5;
            this.lblLetraGeral.Text = "A";
            this.lblLetraGeral.Click += new System.EventHandler(this.lblLetraGeral_Click);
            // 
            // btnPrioritarios
            // 
            this.btnPrioritarios.BackColor = System.Drawing.Color.Silver;
            this.btnPrioritarios.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrioritarios.ForeColor = System.Drawing.Color.Navy;
            this.btnPrioritarios.Location = new System.Drawing.Point(93, 149);
            this.btnPrioritarios.Name = "btnPrioritarios";
            this.btnPrioritarios.Size = new System.Drawing.Size(133, 48);
            this.btnPrioritarios.TabIndex = 4;
            this.btnPrioritarios.Text = "Prioritários";
            this.btnPrioritarios.UseVisualStyleBackColor = false;
            this.btnPrioritarios.Click += new System.EventHandler(this.btnPrioritarios_Click);
            // 
            // btnGeral
            // 
            this.btnGeral.BackColor = System.Drawing.Color.Silver;
            this.btnGeral.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeral.ForeColor = System.Drawing.Color.Navy;
            this.btnGeral.Location = new System.Drawing.Point(93, 70);
            this.btnGeral.Name = "btnGeral";
            this.btnGeral.Size = new System.Drawing.Size(133, 48);
            this.btnGeral.TabIndex = 3;
            this.btnGeral.Text = "Geral";
            this.btnGeral.UseVisualStyleBackColor = false;
            this.btnGeral.Click += new System.EventHandler(this.btnGeral_Click);
            // 
            // lblNumPrio
            // 
            this.lblNumPrio.AutoSize = true;
            this.lblNumPrio.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumPrio.ForeColor = System.Drawing.Color.Orange;
            this.lblNumPrio.Location = new System.Drawing.Point(342, 153);
            this.lblNumPrio.Name = "lblNumPrio";
            this.lblNumPrio.Size = new System.Drawing.Size(49, 33);
            this.lblNumPrio.TabIndex = 2;
            this.lblNumPrio.Text = "00";
            this.lblNumPrio.Click += new System.EventHandler(this.lblNumPrio_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(165, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Atendimento";
            // 
            // lblNumGeral
            // 
            this.lblNumGeral.AutoSize = true;
            this.lblNumGeral.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumGeral.ForeColor = System.Drawing.Color.Orange;
            this.lblNumGeral.Location = new System.Drawing.Point(342, 74);
            this.lblNumGeral.Name = "lblNumGeral";
            this.lblNumGeral.Size = new System.Drawing.Size(49, 33);
            this.lblNumGeral.TabIndex = 0;
            this.lblNumGeral.Text = "00";
            this.lblNumGeral.Click += new System.EventHandler(this.lblNumGeral_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumBlue;
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.lblGiche);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lblDisplayNum);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.LightGray;
            this.groupBox2.Location = new System.Drawing.Point(26, 38);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(982, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Quadro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listBox1);
            this.panel1.Location = new System.Drawing.Point(516, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 238);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Senhas Anteriores";
            // 
            // listBox1
            // 
            this.listBox1.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.listBox1.BackColor = System.Drawing.Color.MediumBlue;
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Gold;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 26;
            this.listBox1.Location = new System.Drawing.Point(69, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.listBox1.Size = new System.Drawing.Size(128, 130);
            this.listBox1.TabIndex = 4;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.OrangeRed;
            this.label4.Location = new System.Drawing.Point(94, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 32);
            this.label4.TabIndex = 3;
            this.label4.Text = "Senha";
            // 
            // lblGiche
            // 
            this.lblGiche.AutoSize = true;
            this.lblGiche.Font = new System.Drawing.Font("Tahoma", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiche.ForeColor = System.Drawing.Color.MintCream;
            this.lblGiche.Location = new System.Drawing.Point(294, 158);
            this.lblGiche.Name = "lblGiche";
            this.lblGiche.Size = new System.Drawing.Size(40, 42);
            this.lblGiche.TabIndex = 2;
            this.lblGiche.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(94, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Balcão";
            // 
            // lblDisplayNum
            // 
            this.lblDisplayNum.AutoSize = true;
            this.lblDisplayNum.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisplayNum.ForeColor = System.Drawing.Color.Yellow;
            this.lblDisplayNum.Location = new System.Drawing.Point(285, 74);
            this.lblDisplayNum.Name = "lblDisplayNum";
            this.lblDisplayNum.Size = new System.Drawing.Size(57, 39);
            this.lblDisplayNum.TabIndex = 0;
            this.lblDisplayNum.Text = "00";
            this.lblDisplayNum.Click += new System.EventHandler(this.lblDisplayNum_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.SteelBlue;
            this.groupBox3.Controls.Add(this.lblSenhasEspera);
            this.groupBox3.Controls.Add(this.btnGuichet3);
            this.groupBox3.Controls.Add(this.btnGuichet2);
            this.groupBox3.Controls.Add(this.btnGuichet1);
            this.groupBox3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.PaleTurquoise;
            this.groupBox3.Location = new System.Drawing.Point(542, 367);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(466, 230);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Balcão";
            // 
            // lblSenhasEspera
            // 
            this.lblSenhasEspera.AutoSize = true;
            this.lblSenhasEspera.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSenhasEspera.ForeColor = System.Drawing.Color.Black;
            this.lblSenhasEspera.Location = new System.Drawing.Point(101, 36);
            this.lblSenhasEspera.Name = "lblSenhasEspera";
            this.lblSenhasEspera.Size = new System.Drawing.Size(0, 18);
            this.lblSenhasEspera.TabIndex = 3;
            this.lblSenhasEspera.Click += new System.EventHandler(this.lblSenhasEspera_Click);
            // 
            // btnGuichet3
            // 
            this.btnGuichet3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuichet3.Location = new System.Drawing.Point(344, 85);
            this.btnGuichet3.Name = "btnGuichet3";
            this.btnGuichet3.Size = new System.Drawing.Size(90, 72);
            this.btnGuichet3.TabIndex = 2;
            this.btnGuichet3.Text = "3";
            this.btnGuichet3.UseVisualStyleBackColor = true;
            this.btnGuichet3.Click += new System.EventHandler(this.btnGuichet3_Click);
            // 
            // btnGuichet2
            // 
            this.btnGuichet2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuichet2.Location = new System.Drawing.Point(193, 85);
            this.btnGuichet2.Name = "btnGuichet2";
            this.btnGuichet2.Size = new System.Drawing.Size(93, 72);
            this.btnGuichet2.TabIndex = 1;
            this.btnGuichet2.Text = " 2";
            this.btnGuichet2.UseVisualStyleBackColor = true;
            this.btnGuichet2.Click += new System.EventHandler(this.btnGuichet2_Click);
            // 
            // btnGuichet1
            // 
            this.btnGuichet1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnGuichet1.Location = new System.Drawing.Point(39, 85);
            this.btnGuichet1.Name = "btnGuichet1";
            this.btnGuichet1.Size = new System.Drawing.Size(92, 72);
            this.btnGuichet1.TabIndex = 0;
            this.btnGuichet1.Text = "1";
            this.btnGuichet1.UseVisualStyleBackColor = true;
            this.btnGuichet1.Click += new System.EventHandler(this.btnGuichet1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha Atual";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1039, 623);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblLetraPrio;
        private System.Windows.Forms.Label lblLetraGeral;
        private System.Windows.Forms.Button btnPrioritarios;
        private System.Windows.Forms.Button btnGeral;
        private System.Windows.Forms.Label lblNumPrio;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblNumGeral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGiche;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDisplayNum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGuichet3;
        private System.Windows.Forms.Button btnGuichet2;
        private System.Windows.Forms.Button btnGuichet1;
        private System.Windows.Forms.Label lblPcaract;
        private System.Windows.Forms.Label lblSenhasEspera;
        private System.Windows.Forms.Label lblGcaract;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
    }
}

