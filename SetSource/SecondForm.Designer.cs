namespace SetSource
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            this.btnExit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvActs = new System.Windows.Forms.ListView();
            this.btnAddAct = new System.Windows.Forms.Button();
            this.btnDelAct = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(695, 573);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "Выход";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 573);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "<<";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelAct);
            this.groupBox1.Controls.Add(this.btnAddAct);
            this.groupBox1.Controls.Add(this.lvActs);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(340, 126);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Акты";
            // 
            // lvActs
            // 
            this.lvActs.Location = new System.Drawing.Point(13, 19);
            this.lvActs.Name = "lvActs";
            this.lvActs.Size = new System.Drawing.Size(279, 66);
            this.lvActs.TabIndex = 0;
            this.lvActs.UseCompatibleStateImageBehavior = false;
            // 
            // btnAddAct
            // 
            this.btnAddAct.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddAct.BackgroundImage")));
            this.btnAddAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAct.Location = new System.Drawing.Point(299, 20);
            this.btnAddAct.Name = "btnAddAct";
            this.btnAddAct.Size = new System.Drawing.Size(30, 30);
            this.btnAddAct.TabIndex = 1;
            this.btnAddAct.UseVisualStyleBackColor = true;
            // 
            // btnDelAct
            // 
            this.btnDelAct.BackgroundImage = global::SetSource.Properties.Resources.delete_button;
            this.btnDelAct.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnDelAct.Location = new System.Drawing.Point(299, 55);
            this.btnDelAct.Name = "btnDelAct";
            this.btnDelAct.Size = new System.Drawing.Size(30, 30);
            this.btnDelAct.TabIndex = 2;
            this.btnDelAct.UseVisualStyleBackColor = true;
            // 
            // SecondForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 608);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExit);
            this.Name = "SecondForm";
            this.Text = "Список артефактов по задаче ";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAddAct;
        private System.Windows.Forms.ListView lvActs;
        private System.Windows.Forms.Button btnDelAct;
    }
}