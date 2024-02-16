namespace InterprocessCommunication
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
			this.lbProcesses = new System.Windows.Forms.ListBox();
			this.lbAssemblies = new System.Windows.Forms.ListBox();
			this.lblAssemblies = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnCloseWindow = new System.Windows.Forms.Button();
			this.btnRefresh = new System.Windows.Forms.Button();
			this.btnDirectory = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lbProcesses
			// 
			this.lbProcesses.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.lbProcesses.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbProcesses.FormattingEnabled = true;
			this.lbProcesses.ItemHeight = 20;
			this.lbProcesses.Location = new System.Drawing.Point(8, 27);
			this.lbProcesses.Name = "lbProcesses";
			this.lbProcesses.Size = new System.Drawing.Size(250, 244);
			this.lbProcesses.TabIndex = 0;
			this.lbProcesses.SelectedIndexChanged += new System.EventHandler(this.lbProcesses_SelectedIndexChanged);
			// 
			// lbAssemblies
			// 
			this.lbAssemblies.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.lbAssemblies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lbAssemblies.FormattingEnabled = true;
			this.lbAssemblies.ItemHeight = 20;
			this.lbAssemblies.Location = new System.Drawing.Point(440, 27);
			this.lbAssemblies.Name = "lbAssemblies";
			this.lbAssemblies.Size = new System.Drawing.Size(250, 244);
			this.lbAssemblies.TabIndex = 1;
			this.lbAssemblies.SelectedIndexChanged += new System.EventHandler(this.lbAssemblies_SelectedIndexChanged);
			// 
			// lblAssemblies
			// 
			this.lblAssemblies.AutoSize = true;
			this.lblAssemblies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblAssemblies.Location = new System.Drawing.Point(436, 4);
			this.lblAssemblies.Name = "lblAssemblies";
			this.lblAssemblies.Size = new System.Drawing.Size(164, 20);
			this.lblAssemblies.TabIndex = 2;
			this.lblAssemblies.Text = "Доступные сборки";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(4, 4);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Запущенные процессы";
			// 
			// btnStart
			// 
			this.btnStart.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnStart.Location = new System.Drawing.Point(264, 27);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(170, 34);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnStop.Location = new System.Drawing.Point(264, 107);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(170, 34);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnCloseWindow
			// 
			this.btnCloseWindow.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnCloseWindow.Location = new System.Drawing.Point(264, 234);
			this.btnCloseWindow.Name = "btnCloseWindow";
			this.btnCloseWindow.Size = new System.Drawing.Size(170, 34);
			this.btnCloseWindow.TabIndex = 6;
			this.btnCloseWindow.Text = "Close Window";
			this.btnCloseWindow.UseVisualStyleBackColor = false;
			this.btnCloseWindow.Click += new System.EventHandler(this.btnCloseWindow_Click);
			// 
			// btnRefresh
			// 
			this.btnRefresh.BackColor = System.Drawing.SystemColors.InactiveBorder;
			this.btnRefresh.Location = new System.Drawing.Point(264, 67);
			this.btnRefresh.Name = "btnRefresh";
			this.btnRefresh.Size = new System.Drawing.Size(170, 34);
			this.btnRefresh.TabIndex = 7;
			this.btnRefresh.Text = "Refresh";
			this.btnRefresh.UseVisualStyleBackColor = false;
			this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
			// 
			// btnDirectory
			// 
			this.btnDirectory.BackColor = System.Drawing.SystemColors.Info;
			this.btnDirectory.Location = new System.Drawing.Point(264, 194);
			this.btnDirectory.Name = "btnDirectory";
			this.btnDirectory.Size = new System.Drawing.Size(170, 34);
			this.btnDirectory.TabIndex = 8;
			this.btnDirectory.Text = "Directory";
			this.btnDirectory.UseVisualStyleBackColor = false;
			this.btnDirectory.Click += new System.EventHandler(this.btnDirectory_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Menu;
			this.ClientSize = new System.Drawing.Size(702, 280);
			this.Controls.Add(this.btnDirectory);
			this.Controls.Add(this.btnRefresh);
			this.Controls.Add(this.btnCloseWindow);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lblAssemblies);
			this.Controls.Add(this.lbAssemblies);
			this.Controls.Add(this.lbProcesses);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox lbProcesses;
		private System.Windows.Forms.ListBox lbAssemblies;
		private System.Windows.Forms.Label lblAssemblies;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Button btnCloseWindow;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDirectory;
	}
}

