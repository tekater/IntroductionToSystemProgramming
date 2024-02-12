namespace Process
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.rtbProcessName = new System.Windows.Forms.RichTextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblProcessInfo = new System.Windows.Forms.Label();
			this.myProcess = new System.Diagnostics.Process();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.splitter1 = new System.Windows.Forms.Splitter();
			this.splitter2 = new System.Windows.Forms.Splitter();
			this.panelMainInfo = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.lblPanelInfo = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lvProcesses = new System.Windows.Forms.ListView();
			this.panelMainInfo.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// rtbProcessName
			// 
			this.rtbProcessName.BackColor = System.Drawing.SystemColors.InactiveCaption;
			this.rtbProcessName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbProcessName.Location = new System.Drawing.Point(12, 10);
			this.rtbProcessName.Name = "rtbProcessName";
			this.rtbProcessName.Size = new System.Drawing.Size(128, 31);
			this.rtbProcessName.TabIndex = 0;
			this.rtbProcessName.Text = "notepad";
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnStart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnStart.Location = new System.Drawing.Point(151, 10);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(121, 31);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.btnStop.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.btnStop.Location = new System.Drawing.Point(278, 10);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(121, 31);
			this.btnStop.TabIndex = 2;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblProcessInfo
			// 
			this.lblProcessInfo.AutoSize = true;
			this.lblProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblProcessInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblProcessInfo.Location = new System.Drawing.Point(3, 9);
			this.lblProcessInfo.Name = "lblProcessInfo";
			this.lblProcessInfo.Size = new System.Drawing.Size(85, 20);
			this.lblProcessInfo.TabIndex = 3;
			this.lblProcessInfo.Text = "LoadInfo...";
			// 
			// myProcess
			// 
			this.myProcess.StartInfo.Domain = "";
			this.myProcess.StartInfo.LoadUserProfile = false;
			this.myProcess.StartInfo.Password = null;
			this.myProcess.StartInfo.StandardErrorEncoding = null;
			this.myProcess.StartInfo.StandardOutputEncoding = null;
			this.myProcess.StartInfo.UserName = "";
			this.myProcess.SynchronizingObject = this;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// splitter1
			// 
			this.splitter1.Location = new System.Drawing.Point(0, 0);
			this.splitter1.Name = "splitter1";
			this.splitter1.Size = new System.Drawing.Size(3, 331);
			this.splitter1.TabIndex = 5;
			this.splitter1.TabStop = false;
			// 
			// splitter2
			// 
			this.splitter2.Location = new System.Drawing.Point(3, 0);
			this.splitter2.Name = "splitter2";
			this.splitter2.Size = new System.Drawing.Size(3, 331);
			this.splitter2.TabIndex = 6;
			this.splitter2.TabStop = false;
			// 
			// panelMainInfo
			// 
			this.panelMainInfo.BackColor = System.Drawing.SystemColors.Control;
			this.panelMainInfo.Controls.Add(this.lblProcessInfo);
			this.panelMainInfo.Location = new System.Drawing.Point(425, 49);
			this.panelMainInfo.Name = "panelMainInfo";
			this.panelMainInfo.Size = new System.Drawing.Size(388, 270);
			this.panelMainInfo.TabIndex = 7;
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.panel2.Controls.Add(this.lblPanelInfo);
			this.panel2.Location = new System.Drawing.Point(425, 10);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(388, 31);
			this.panel2.TabIndex = 8;
			// 
			// lblPanelInfo
			// 
			this.lblPanelInfo.AutoSize = true;
			this.lblPanelInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPanelInfo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.lblPanelInfo.Location = new System.Drawing.Point(3, 4);
			this.lblPanelInfo.Name = "lblPanelInfo";
			this.lblPanelInfo.Size = new System.Drawing.Size(98, 20);
			this.lblPanelInfo.TabIndex = 4;
			this.lblPanelInfo.Text = "ProcessInfo:";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.panel3);
			this.panel1.Location = new System.Drawing.Point(405, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(10, 331);
			this.panel1.TabIndex = 9;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Location = new System.Drawing.Point(7, -8);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(7, 341);
			this.panel3.TabIndex = 9;
			// 
			// lvProcesses
			// 
			this.lvProcesses.BackColor = System.Drawing.SystemColors.Control;
			this.lvProcesses.FullRowSelect = true;
			this.lvProcesses.HideSelection = false;
			this.lvProcesses.Location = new System.Drawing.Point(13, 49);
			this.lvProcesses.Name = "lvProcesses";
			this.lvProcesses.Size = new System.Drawing.Size(386, 270);
			this.lvProcesses.TabIndex = 10;
			this.lvProcesses.UseCompatibleStateImageBehavior = false;
			this.lvProcesses.View = System.Windows.Forms.View.Details;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GrayText;
			this.ClientSize = new System.Drawing.Size(821, 331);
			this.Controls.Add(this.lvProcesses);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panelMainInfo);
			this.Controls.Add(this.splitter2);
			this.Controls.Add(this.splitter1);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.rtbProcessName);
			this.ForeColor = System.Drawing.SystemColors.ControlText;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.panelMainInfo.ResumeLayout(false);
			this.panelMainInfo.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbProcessName;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblProcessInfo;
		private System.Diagnostics.Process myProcess;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.Splitter splitter2;
		private System.Windows.Forms.Splitter splitter1;
		private System.Windows.Forms.Panel panelMainInfo;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label lblPanelInfo;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ListView lvProcesses;
	}
}

