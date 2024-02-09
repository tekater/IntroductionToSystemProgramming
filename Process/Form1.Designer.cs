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
			this.rtbProcessName = new System.Windows.Forms.RichTextBox();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblProcessInfo = new System.Windows.Forms.Label();
			this.myProcess = new System.Diagnostics.Process();
			this.SuspendLayout();
			// 
			// rtbProcessName
			// 
			this.rtbProcessName.Location = new System.Drawing.Point(12, 12);
			this.rtbProcessName.Name = "rtbProcessName";
			this.rtbProcessName.Size = new System.Drawing.Size(100, 24);
			this.rtbProcessName.TabIndex = 0;
			this.rtbProcessName.Text = "calc.exe";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(12, 64);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(100, 44);
			this.btnStart.TabIndex = 1;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(12, 114);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(100, 44);
			this.btnStop.TabIndex = 2;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblProcessInfo
			// 
			this.lblProcessInfo.AutoSize = true;
			this.lblProcessInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblProcessInfo.Location = new System.Drawing.Point(135, 12);
			this.lblProcessInfo.Name = "lblProcessInfo";
			this.lblProcessInfo.Size = new System.Drawing.Size(94, 20);
			this.lblProcessInfo.TabIndex = 3;
			this.lblProcessInfo.Text = "ProcessInfo";
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
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(420, 265);
			this.Controls.Add(this.lblProcessInfo);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.rtbProcessName);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RichTextBox rtbProcessName;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblProcessInfo;
		private System.Diagnostics.Process myProcess;
	}
}

