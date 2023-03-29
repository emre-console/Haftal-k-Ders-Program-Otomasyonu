namespace HaftalikDersProgrami
{
    partial class ProgramOlusturucu
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.listPazartesi = new System.Windows.Forms.FlowLayoutPanel();
            this.listSalı = new System.Windows.Forms.FlowLayoutPanel();
            this.listÇarşamba = new System.Windows.Forms.FlowLayoutPanel();
            this.listPerşembe = new System.Windows.Forms.FlowLayoutPanel();
            this.listCuma = new System.Windows.Forms.FlowLayoutPanel();
            this.yazdir = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(827, 625);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(827, 33);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pazartesi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(165, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(332, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Çarşamba";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(510, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Perşembe";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(661, 8);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Cuma";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.listPazartesi);
            this.flowLayoutPanel1.Controls.Add(this.listSalı);
            this.flowLayoutPanel1.Controls.Add(this.listÇarşamba);
            this.flowLayoutPanel1.Controls.Add(this.listPerşembe);
            this.flowLayoutPanel1.Controls.Add(this.listCuma);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 33);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(827, 592);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // listPazartesi
            // 
            this.listPazartesi.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPazartesi.Location = new System.Drawing.Point(3, 3);
            this.listPazartesi.Name = "listPazartesi";
            this.listPazartesi.Size = new System.Drawing.Size(156, 1000);
            this.listPazartesi.TabIndex = 0;
            // 
            // listSalı
            // 
            this.listSalı.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listSalı.Location = new System.Drawing.Point(165, 3);
            this.listSalı.Name = "listSalı";
            this.listSalı.Size = new System.Drawing.Size(156, 1000);
            this.listSalı.TabIndex = 1;
            // 
            // listÇarşamba
            // 
            this.listÇarşamba.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listÇarşamba.Location = new System.Drawing.Point(327, 3);
            this.listÇarşamba.Name = "listÇarşamba";
            this.listÇarşamba.Size = new System.Drawing.Size(156, 1000);
            this.listÇarşamba.TabIndex = 1;
            // 
            // listPerşembe
            // 
            this.listPerşembe.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listPerşembe.Location = new System.Drawing.Point(489, 3);
            this.listPerşembe.Name = "listPerşembe";
            this.listPerşembe.Size = new System.Drawing.Size(156, 1000);
            this.listPerşembe.TabIndex = 1;
            // 
            // listCuma
            // 
            this.listCuma.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.listCuma.Location = new System.Drawing.Point(651, 3);
            this.listCuma.Name = "listCuma";
            this.listCuma.Size = new System.Drawing.Size(156, 1000);
            this.listCuma.TabIndex = 1;
            // 
            // yazdir
            // 
            this.yazdir.Location = new System.Drawing.Point(787, 645);
            this.yazdir.Name = "yazdir";
            this.yazdir.Size = new System.Drawing.Size(75, 23);
            this.yazdir.TabIndex = 1;
            this.yazdir.Text = "Yazdır";
            this.yazdir.UseVisualStyleBackColor = true;
            this.yazdir.Click += new System.EventHandler(this.yazdir_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.DocumentName = "printable";
            // 
            // ProgramOlusturucu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 680);
            this.Controls.Add(this.yazdir);
            this.Controls.Add(this.panel1);
            this.Name = "ProgramOlusturucu";
            this.Text = "ProgramOlusturucu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProgramOlusturucu_FormClosed);
            this.Load += new System.EventHandler(this.ProgramOlusturucu_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel listPazartesi;
        private System.Windows.Forms.FlowLayoutPanel listSalı;
        private System.Windows.Forms.FlowLayoutPanel listÇarşamba;
        private System.Windows.Forms.FlowLayoutPanel listPerşembe;
        private System.Windows.Forms.FlowLayoutPanel listCuma;
        private System.Windows.Forms.Button yazdir;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}