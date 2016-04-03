namespace SetSource
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblJiraTask = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.btnJiratw = new System.Windows.Forms.Button();
            this.btnJinteg = new System.Windows.Forms.Button();
            this.txtJiratwNumber = new System.Windows.Forms.MaskedTextBox();
            this.txtJintegNumber = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "JIRATW-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "JINTEG-";
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(518, 297);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 7;
            this.btnNext.Text = ">>";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(35, 297);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 9;
            this.btnReset.Text = "Очистить";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblJiraTask
            // 
            this.lblJiraTask.AutoSize = true;
            this.lblJiraTask.Location = new System.Drawing.Point(38, 126);
            this.lblJiraTask.Name = "lblJiraTask";
            this.lblJiraTask.Size = new System.Drawing.Size(101, 13);
            this.lblJiraTask.TabIndex = 10;
            this.lblJiraTask.Text = "Jira task Information";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.ForeColor = System.Drawing.Color.Crimson;
            this.lblError.Location = new System.Drawing.Point(38, 165);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(49, 13);
            this.lblError.TabIndex = 11;
            this.lblError.Text = "Error text";
            // 
            // btnJiratw
            // 
            this.btnJiratw.Location = new System.Drawing.Point(156, 39);
            this.btnJiratw.Name = "btnJiratw";
            this.btnJiratw.Size = new System.Drawing.Size(46, 23);
            this.btnJiratw.TabIndex = 12;
            this.btnJiratw.Text = ">";
            this.btnJiratw.UseVisualStyleBackColor = true;
            this.btnJiratw.Click += new System.EventHandler(this.btnJiratw_Click);
            // 
            // btnJinteg
            // 
            this.btnJinteg.Location = new System.Drawing.Point(156, 78);
            this.btnJinteg.Name = "btnJinteg";
            this.btnJinteg.Size = new System.Drawing.Size(46, 23);
            this.btnJinteg.TabIndex = 13;
            this.btnJinteg.Text = ">";
            this.btnJinteg.UseVisualStyleBackColor = true;
            this.btnJinteg.Click += new System.EventHandler(this.btnJinteg_Click);
            // 
            // txtJiratwNumber
            // 
            this.txtJiratwNumber.HidePromptOnLeave = true;
            this.txtJiratwNumber.Location = new System.Drawing.Point(86, 41);
            this.txtJiratwNumber.Mask = "000000";
            this.txtJiratwNumber.Name = "txtJiratwNumber";
            this.txtJiratwNumber.Size = new System.Drawing.Size(53, 20);
            this.txtJiratwNumber.TabIndex = 14;
            this.txtJiratwNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtJiratwNumber.TextChanged += new System.EventHandler(this.txtJiratwNumber_TextChanged);
            // 
            // txtJintegNumber
            // 
            this.txtJintegNumber.HidePromptOnLeave = true;
            this.txtJintegNumber.Location = new System.Drawing.Point(86, 80);
            this.txtJintegNumber.Mask = "000000";
            this.txtJintegNumber.Name = "txtJintegNumber";
            this.txtJintegNumber.Size = new System.Drawing.Size(53, 20);
            this.txtJintegNumber.TabIndex = 15;
            this.txtJintegNumber.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.txtJintegNumber.TextChanged += new System.EventHandler(this.txtJintegNumber_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(612, 343);
            this.Controls.Add(this.txtJintegNumber);
            this.Controls.Add(this.txtJiratwNumber);
            this.Controls.Add(this.btnJinteg);
            this.Controls.Add(this.btnJiratw);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblJiraTask);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Номер задачи в Jira";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblJiraTask;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnJiratw;
        private System.Windows.Forms.Button btnJinteg;
        private System.Windows.Forms.MaskedTextBox txtJiratwNumber;
        private System.Windows.Forms.MaskedTextBox txtJintegNumber;


    }
}

