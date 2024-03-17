namespace WaveViewer
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.waveViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.waveViewerToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
			this.lblAbout = new System.Windows.Forms.Label();
			this.panelAbout = new System.Windows.Forms.Panel();
			this.panelWaveViewer = new System.Windows.Forms.Panel();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.lblX = new System.Windows.Forms.Label();
			this.lblY = new System.Windows.Forms.Label();
			this.lblMax = new System.Windows.Forms.Label();
			this.lblMedian = new System.Windows.Forms.Label();
			this.btnExit = new System.Windows.Forms.Button();
			this.menuStrip1.SuspendLayout();
			this.panelAbout.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.waveViewerToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(1115, 24);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// waveViewerToolStripMenuItem
			// 
			this.waveViewerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.waveViewerToolStripMenuItem1});
			this.waveViewerToolStripMenuItem.Name = "waveViewerToolStripMenuItem";
			this.waveViewerToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
			this.waveViewerToolStripMenuItem.Text = "Tool";
			this.waveViewerToolStripMenuItem.Click += new System.EventHandler(this.mainToolStripMenuItem_Click);
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// waveViewerToolStripMenuItem1
			// 
			this.waveViewerToolStripMenuItem1.Name = "waveViewerToolStripMenuItem1";
			this.waveViewerToolStripMenuItem1.Size = new System.Drawing.Size(141, 22);
			this.waveViewerToolStripMenuItem1.Text = "Wave Viewer";
			this.waveViewerToolStripMenuItem1.Click += new System.EventHandler(this.waveViewerToolStripMenuItem1_Click);
			// 
			// lblAbout
			// 
			this.lblAbout.AutoSize = true;
			this.lblAbout.Location = new System.Drawing.Point(17, 12);
			this.lblAbout.Name = "lblAbout";
			this.lblAbout.Size = new System.Drawing.Size(298, 143);
			this.lblAbout.TabIndex = 1;
			this.lblAbout.Text = resources.GetString("lblAbout.Text");
			// 
			// panelAbout
			// 
			this.panelAbout.BackColor = System.Drawing.SystemColors.Control;
			this.panelAbout.Controls.Add(this.lblAbout);
			this.panelAbout.Location = new System.Drawing.Point(743, 39);
			this.panelAbout.Name = "panelAbout";
			this.panelAbout.Size = new System.Drawing.Size(350, 187);
			this.panelAbout.TabIndex = 2;
			this.panelAbout.Visible = false;
			// 
			// panelWaveViewer
			// 
			this.panelWaveViewer.BackColor = System.Drawing.SystemColors.Control;
			this.panelWaveViewer.Location = new System.Drawing.Point(13, 39);
			this.panelWaveViewer.Name = "panelWaveViewer";
			this.panelWaveViewer.Size = new System.Drawing.Size(697, 360);
			this.panelWaveViewer.TabIndex = 3;
			this.panelWaveViewer.Visible = false;
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(478, 405);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(113, 39);
			this.btnStart.TabIndex = 4;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Visible = false;
			this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(597, 405);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(113, 39);
			this.btnStop.TabIndex = 5;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Visible = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// lblX
			// 
			this.lblX.AutoSize = true;
			this.lblX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblX.Location = new System.Drawing.Point(12, 409);
			this.lblX.Name = "lblX";
			this.lblX.Size = new System.Drawing.Size(50, 25);
			this.lblX.TabIndex = 6;
			this.lblX.Text = "X=0";
			this.lblX.Visible = false;
			// 
			// lblY
			// 
			this.lblY.AutoSize = true;
			this.lblY.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblY.Location = new System.Drawing.Point(12, 434);
			this.lblY.Name = "lblY";
			this.lblY.Size = new System.Drawing.Size(51, 25);
			this.lblY.TabIndex = 7;
			this.lblY.Text = "Y=0";
			this.lblY.Visible = false;
			// 
			// lblMax
			// 
			this.lblMax.AutoSize = true;
			this.lblMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMax.Location = new System.Drawing.Point(100, 409);
			this.lblMax.Name = "lblMax";
			this.lblMax.Size = new System.Drawing.Size(82, 25);
			this.lblMax.TabIndex = 8;
			this.lblMax.Text = "MAX=0";
			this.lblMax.Visible = false;
			// 
			// lblMedian
			// 
			this.lblMedian.AutoSize = true;
			this.lblMedian.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblMedian.Location = new System.Drawing.Point(100, 434);
			this.lblMedian.Name = "lblMedian";
			this.lblMedian.Size = new System.Drawing.Size(117, 25);
			this.lblMedian.TabIndex = 9;
			this.lblMedian.Text = "MEDIAN=0";
			this.lblMedian.Visible = false;
			// 
			// btnExit
			// 
			this.btnExit.Location = new System.Drawing.Point(922, 485);
			this.btnExit.Name = "btnExit";
			this.btnExit.Size = new System.Drawing.Size(181, 39);
			this.btnExit.TabIndex = 10;
			this.btnExit.Text = "Exit";
			this.btnExit.UseVisualStyleBackColor = true;
			this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonShadow;
			this.ClientSize = new System.Drawing.Size(1115, 536);
			this.Controls.Add(this.btnExit);
			this.Controls.Add(this.lblMedian);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.lblX);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.lblMax);
			this.Controls.Add(this.panelWaveViewer);
			this.Controls.Add(this.lblY);
			this.Controls.Add(this.panelAbout);
			this.Controls.Add(this.menuStrip1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "Form1";
			this.Text = "Form1";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.panelAbout.ResumeLayout(false);
			this.panelAbout.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem waveViewerToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem waveViewerToolStripMenuItem1;
		private System.Windows.Forms.Label lblAbout;
		private System.Windows.Forms.Panel panelAbout;
		private System.Windows.Forms.Panel panelWaveViewer;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label lblX;
		private System.Windows.Forms.Label lblY;
		private System.Windows.Forms.Label lblMax;
		private System.Windows.Forms.Label lblMedian;
		private System.Windows.Forms.Button btnExit;
	}
}

