namespace parentalContribution
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripAddStudent = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripContrib = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripTotalContribution = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.TotalContrib1 = new System.Windows.Forms.TabPage();
            this.infoLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.GetContribution1 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.resultContrib = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.submitContrib = new System.Windows.Forms.Button();
            this.AddStudent1 = new System.Windows.Forms.TabPage();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.TextBox();
            this.monthBox = new System.Windows.Forms.TextBox();
            this.dayBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resultLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.contextMenuStrip2.SuspendLayout();
            this.TotalContrib1.SuspendLayout();
            this.GetContribution1.SuspendLayout();
            this.AddStudent1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripAddStudent,
            this.toolStripContrib,
            this.toolStripTotalContribution,
            this.openToolStripMenuItem,
            this.closeToolStripMenuItem});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(188, 114);
            // 
            // toolStripAddStudent
            // 
            this.toolStripAddStudent.Name = "toolStripAddStudent";
            this.toolStripAddStudent.Size = new System.Drawing.Size(187, 22);
            this.toolStripAddStudent.Text = "add student";
            this.toolStripAddStudent.Click += new System.EventHandler(this.toolStripAddStudent_Click);
            // 
            // toolStripContrib
            // 
            this.toolStripContrib.Name = "toolStripContrib";
            this.toolStripContrib.Size = new System.Drawing.Size(187, 22);
            this.toolStripContrib.Text = "get contribution";
            this.toolStripContrib.Click += new System.EventHandler(this.toolStripContrib_Click);
            // 
            // toolStripTotalContribution
            // 
            this.toolStripTotalContribution.Name = "toolStripTotalContribution";
            this.toolStripTotalContribution.Size = new System.Drawing.Size(187, 22);
            this.toolStripTotalContribution.Text = "get total contribution";
            this.toolStripTotalContribution.Click += new System.EventHandler(this.toolStripTotalContribution_Click);
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.openToolStripMenuItem.Text = "open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.closeToolStripMenuItem.Text = "close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click_1);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip2;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // TotalContrib1
            // 
            this.TotalContrib1.Controls.Add(this.infoLabel);
            this.TotalContrib1.Controls.Add(this.button1);
            this.TotalContrib1.Location = new System.Drawing.Point(4, 22);
            this.TotalContrib1.Name = "TotalContrib1";
            this.TotalContrib1.Size = new System.Drawing.Size(767, 417);
            this.TotalContrib1.TabIndex = 2;
            this.TotalContrib1.Text = "total contribution";
            this.TotalContrib1.UseVisualStyleBackColor = true;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(47, 166);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "label1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(47, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "School Info";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GetContribution1
            // 
            this.GetContribution1.Controls.Add(this.textBox1);
            this.GetContribution1.Controls.Add(this.resultContrib);
            this.GetContribution1.Controls.Add(this.label5);
            this.GetContribution1.Controls.Add(this.label6);
            this.GetContribution1.Controls.Add(this.submitContrib);
            this.GetContribution1.Location = new System.Drawing.Point(4, 22);
            this.GetContribution1.Name = "GetContribution1";
            this.GetContribution1.Padding = new System.Windows.Forms.Padding(3);
            this.GetContribution1.Size = new System.Drawing.Size(767, 417);
            this.GetContribution1.TabIndex = 1;
            this.GetContribution1.Text = "get contribution";
            this.GetContribution1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(110, 20);
            this.textBox1.TabIndex = 13;
            // 
            // resultContrib
            // 
            this.resultContrib.AutoSize = true;
            this.resultContrib.Location = new System.Drawing.Point(21, 201);
            this.resultContrib.Name = "resultContrib";
            this.resultContrib.Size = new System.Drawing.Size(35, 13);
            this.resultContrib.TabIndex = 9;
            this.resultContrib.Text = "label3";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name:";
            // 
            // submitContrib
            // 
            this.submitContrib.Location = new System.Drawing.Point(296, 126);
            this.submitContrib.Name = "submitContrib";
            this.submitContrib.Size = new System.Drawing.Size(75, 23);
            this.submitContrib.TabIndex = 6;
            this.submitContrib.Text = "Submit";
            this.submitContrib.UseVisualStyleBackColor = true;
            this.submitContrib.Click += new System.EventHandler(this.submitContrib_Click_1);
            // 
            // AddStudent1
            // 
            this.AddStudent1.Controls.Add(this.nameBox);
            this.AddStudent1.Controls.Add(this.yearBox);
            this.AddStudent1.Controls.Add(this.monthBox);
            this.AddStudent1.Controls.Add(this.dayBox);
            this.AddStudent1.Controls.Add(this.label1);
            this.AddStudent1.Controls.Add(this.resultLabel);
            this.AddStudent1.Controls.Add(this.submit);
            this.AddStudent1.Controls.Add(this.label4);
            this.AddStudent1.Controls.Add(this.label3);
            this.AddStudent1.Controls.Add(this.label2);
            this.AddStudent1.Location = new System.Drawing.Point(4, 22);
            this.AddStudent1.Name = "AddStudent1";
            this.AddStudent1.Padding = new System.Windows.Forms.Padding(3);
            this.AddStudent1.Size = new System.Drawing.Size(767, 417);
            this.AddStudent1.TabIndex = 0;
            this.AddStudent1.Text = "add student";
            this.AddStudent1.UseVisualStyleBackColor = true;
            // 
            // nameBox
            // 
            this.nameBox.Location = new System.Drawing.Point(9, 32);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(152, 20);
            this.nameBox.TabIndex = 0;
            this.nameBox.TextChanged += new System.EventHandler(this.nameBox_TextChanged);
            // 
            // yearBox
            // 
            this.yearBox.Location = new System.Drawing.Point(9, 92);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(155, 20);
            this.yearBox.TabIndex = 1;
            // 
            // monthBox
            // 
            this.monthBox.Location = new System.Drawing.Point(9, 156);
            this.monthBox.Name = "monthBox";
            this.monthBox.Size = new System.Drawing.Size(155, 20);
            this.monthBox.TabIndex = 2;
            // 
            // dayBox
            // 
            this.dayBox.ForeColor = System.Drawing.Color.Transparent;
            this.dayBox.Location = new System.Drawing.Point(9, 224);
            this.dayBox.Name = "dayBox";
            this.dayBox.Size = new System.Drawing.Size(155, 20);
            this.dayBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(9, 335);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 13);
            this.resultLabel.TabIndex = 9;
            // 
            // submit
            // 
            this.submit.Location = new System.Drawing.Point(367, 153);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(75, 23);
            this.submit.TabIndex = 8;
            this.submit.Text = "Submit";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Day of birth";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Month of birth";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Year of birth";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AddStudent1);
            this.tabControl1.Controls.Add(this.GetContribution1);
            this.tabControl1.Controls.Add(this.TotalContrib1);
            this.tabControl1.Location = new System.Drawing.Point(13, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(775, 443);
            this.tabControl1.TabIndex = 12;
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "AddStudent";
            this.Text = "Form1";
            this.Click += new System.EventHandler(this.AddStudent_Click);
            this.contextMenuStrip2.ResumeLayout(false);
            this.TotalContrib1.ResumeLayout(false);
            this.TotalContrib1.PerformLayout();
            this.GetContribution1.ResumeLayout(false);
            this.GetContribution1.PerformLayout();
            this.AddStudent1.ResumeLayout(false);
            this.AddStudent1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripAddStudent;
        private System.Windows.Forms.ToolStripMenuItem toolStripContrib;
        private System.Windows.Forms.ToolStripMenuItem toolStripTotalContribution;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TabPage TotalContrib1;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage GetContribution1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label resultContrib;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button submitContrib;
        private System.Windows.Forms.TabPage AddStudent1;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox yearBox;
        private System.Windows.Forms.TextBox monthBox;
        private System.Windows.Forms.TextBox dayBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label resultLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
    }
}

