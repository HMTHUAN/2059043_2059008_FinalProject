
namespace FinalProject
{
    partial class frmMain
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
            this.lbsQuestions = new System.Windows.Forms.ListBox();
            this.btnADD = new System.Windows.Forms.Button();
            this.txtQuestion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtABC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbsQuestions
            // 
            this.lbsQuestions.FormattingEnabled = true;
            this.lbsQuestions.ItemHeight = 16;
            this.lbsQuestions.Location = new System.Drawing.Point(12, 217);
            this.lbsQuestions.Name = "lbsQuestions";
            this.lbsQuestions.Size = new System.Drawing.Size(704, 292);
            this.lbsQuestions.TabIndex = 0;
            // 
            // btnADD
            // 
            this.btnADD.Location = new System.Drawing.Point(425, 25);
            this.btnADD.Name = "btnADD";
            this.btnADD.Size = new System.Drawing.Size(141, 28);
            this.btnADD.TabIndex = 1;
            this.btnADD.Text = "add Question";
            this.btnADD.UseVisualStyleBackColor = true;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // txtQuestion
            // 
            this.txtQuestion.Location = new System.Drawing.Point(88, 26);
            this.txtQuestion.Name = "txtQuestion";
            this.txtQuestion.Size = new System.Drawing.Size(314, 22);
            this.txtQuestion.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Question";
            // 
            // txtContent
            // 
            this.txtContent.Location = new System.Drawing.Point(88, 69);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(314, 22);
            this.txtContent.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Content";
            // 
            // txtABC
            // 
            this.txtABC.Location = new System.Drawing.Point(88, 112);
            this.txtABC.Multiline = true;
            this.txtABC.Name = "txtABC";
            this.txtABC.Size = new System.Drawing.Size(314, 97);
            this.txtABC.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "ABC";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(425, 97);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(141, 28);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1457, 519);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtABC);
            this.Controls.Add(this.txtContent);
            this.Controls.Add(this.txtQuestion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.lbsQuestions);
            this.Name = "frmMain";
            this.Text = "Test Trắc Nghiệm";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbsQuestions;
        private System.Windows.Forms.Button btnADD;
        private System.Windows.Forms.TextBox txtQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtABC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSave;
    }
}

