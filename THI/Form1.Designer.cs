
namespace THI
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
            this.components = new System.ComponentModel.Container();
            this.rbtA = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHoten = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.rbtB = new System.Windows.Forms.RadioButton();
            this.rbtD = new System.Windows.Forms.RadioButton();
            this.rbtC = new System.Windows.Forms.RadioButton();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtD = new System.Windows.Forms.TextBox();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtA = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.LBLTime = new System.Windows.Forms.Label();
            this.txtReadfile = new System.Windows.Forms.TextBox();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbtA
            // 
            this.rbtA.AutoSize = true;
            this.rbtA.Location = new System.Drawing.Point(6, 21);
            this.rbtA.Name = "rbtA";
            this.rbtA.Size = new System.Drawing.Size(38, 21);
            this.rbtA.TabIndex = 0;
            this.rbtA.TabStop = true;
            this.rbtA.Text = "A";
            this.rbtA.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhập tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "MÃ NV";
            // 
            // txtHoten
            // 
            this.txtHoten.Location = new System.Drawing.Point(178, 53);
            this.txtHoten.Name = "txtHoten";
            this.txtHoten.Size = new System.Drawing.Size(197, 22);
            this.txtHoten.TabIndex = 2;
            this.txtHoten.TextChanged += new System.EventHandler(this.txtHoten_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.Red;
            this.btnSubmit.Location = new System.Drawing.Point(800, 463);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(134, 46);
            this.btnSubmit.TabIndex = 3;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // rbtB
            // 
            this.rbtB.AutoSize = true;
            this.rbtB.Location = new System.Drawing.Point(229, 21);
            this.rbtB.Name = "rbtB";
            this.rbtB.Size = new System.Drawing.Size(38, 21);
            this.rbtB.TabIndex = 0;
            this.rbtB.TabStop = true;
            this.rbtB.Text = "B";
            this.rbtB.UseVisualStyleBackColor = true;
            // 
            // rbtD
            // 
            this.rbtD.AutoSize = true;
            this.rbtD.Location = new System.Drawing.Point(229, 100);
            this.rbtD.Name = "rbtD";
            this.rbtD.Size = new System.Drawing.Size(39, 21);
            this.rbtD.TabIndex = 0;
            this.rbtD.TabStop = true;
            this.rbtD.Text = "D";
            this.rbtD.UseVisualStyleBackColor = true;
            // 
            // rbtC
            // 
            this.rbtC.AutoSize = true;
            this.rbtC.Location = new System.Drawing.Point(6, 100);
            this.rbtC.Name = "rbtC";
            this.rbtC.Size = new System.Drawing.Size(38, 21);
            this.rbtC.TabIndex = 0;
            this.rbtC.TabStop = true;
            this.rbtC.Text = "C";
            this.rbtC.UseVisualStyleBackColor = true;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(178, 88);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(197, 22);
            this.txtMSSV.TabIndex = 2;
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Aqua;
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(507, 185);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(195, 60);
            this.btnStart.TabIndex = 3;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(127, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(223, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtHoten);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(485, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(449, 162);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtC);
            this.groupBox2.Controls.Add(this.txtD);
            this.groupBox2.Controls.Add(this.txtC);
            this.groupBox2.Controls.Add(this.txtB);
            this.groupBox2.Controls.Add(this.txtA);
            this.groupBox2.Controls.Add(this.rbtD);
            this.groupBox2.Controls.Add(this.rbtB);
            this.groupBox2.Controls.Add(this.rbtA);
            this.groupBox2.Location = new System.Drawing.Point(485, 251);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(449, 201);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            // 
            // txtD
            // 
            this.txtD.Enabled = false;
            this.txtD.Location = new System.Drawing.Point(292, 100);
            this.txtD.Multiline = true;
            this.txtD.Name = "txtD";
            this.txtD.Size = new System.Drawing.Size(151, 65);
            this.txtD.TabIndex = 2;
            // 
            // txtC
            // 
            this.txtC.Enabled = false;
            this.txtC.Location = new System.Drawing.Point(50, 100);
            this.txtC.Multiline = true;
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(151, 65);
            this.txtC.TabIndex = 2;
            // 
            // txtB
            // 
            this.txtB.Enabled = false;
            this.txtB.Location = new System.Drawing.Point(292, 20);
            this.txtB.Multiline = true;
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(151, 65);
            this.txtB.TabIndex = 2;
            // 
            // txtA
            // 
            this.txtA.Enabled = false;
            this.txtA.Location = new System.Drawing.Point(50, 20);
            this.txtA.Multiline = true;
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(151, 65);
            this.txtA.TabIndex = 2;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // LBLTime
            // 
            this.LBLTime.AutoSize = true;
            this.LBLTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTime.Location = new System.Drawing.Point(794, 191);
            this.LBLTime.Name = "LBLTime";
            this.LBLTime.Size = new System.Drawing.Size(41, 44);
            this.LBLTime.TabIndex = 1;
            this.LBLTime.Text = "0";
            // 
            // txtReadfile
            // 
            this.txtReadfile.Enabled = false;
            this.txtReadfile.Location = new System.Drawing.Point(12, 12);
            this.txtReadfile.Multiline = true;
            this.txtReadfile.Name = "txtReadfile";
            this.txtReadfile.Size = new System.Drawing.Size(467, 492);
            this.txtReadfile.TabIndex = 8;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Aqua;
            this.btnPrevious.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrevious.Location = new System.Drawing.Point(513, 469);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(110, 35);
            this.btnPrevious.TabIndex = 9;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = false;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Aqua;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(663, 469);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(110, 35);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 516);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.txtReadfile);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LBLTime);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbtA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtHoten;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.RadioButton rbtB;
        private System.Windows.Forms.RadioButton rbtD;
        private System.Windows.Forms.RadioButton rbtC;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label LBLTime;
        private System.Windows.Forms.TextBox txtReadfile;
        private System.Windows.Forms.TextBox txtD;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnNext;
    }
}

