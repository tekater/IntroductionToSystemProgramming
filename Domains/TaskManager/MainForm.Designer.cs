namespace TaskManager
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
			System.Windows.Forms.ListViewGroup listViewGroup1 = new System.Windows.Forms.ListViewGroup("Applications", System.Windows.Forms.HorizontalAlignment.Left);
			System.Windows.Forms.ListViewGroup listViewGroup2 = new System.Windows.Forms.ListViewGroup("BGProc", System.Windows.Forms.HorizontalAlignment.Left);
			this.lv_ProcList = new System.Windows.Forms.ListView();
			this.NameProcesses = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.Memory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.CPU = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.btn_KillProcess = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lv_ProcList
			// 
			this.lv_ProcList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProcesses,
            this.PID,
            this.Memory,
            this.CPU});
			this.lv_ProcList.FullRowSelect = true;
			listViewGroup1.Header = "Applications";
			listViewGroup1.Name = "Applications";
			listViewGroup2.Header = "BGProc";
			listViewGroup2.Name = "BGProc";
			this.lv_ProcList.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup1,
            listViewGroup2});
			this.lv_ProcList.HideSelection = false;
			this.lv_ProcList.Location = new System.Drawing.Point(48, 12);
			this.lv_ProcList.Name = "lv_ProcList";
			this.lv_ProcList.Size = new System.Drawing.Size(641, 363);
			this.lv_ProcList.Sorting = System.Windows.Forms.SortOrder.Ascending;
			this.lv_ProcList.TabIndex = 0;
			this.lv_ProcList.UseCompatibleStateImageBehavior = false;
			this.lv_ProcList.View = System.Windows.Forms.View.Details;
			// 
			// NameProcesses
			// 
			this.NameProcesses.Text = "Name";
			this.NameProcesses.Width = 127;
			// 
			// PID
			// 
			this.PID.Text = "PID";
			this.PID.Width = 108;
			// 
			// Memory
			// 
			this.Memory.Text = "Memory";
			this.Memory.Width = 91;
			// 
			// CPU
			// 
			this.CPU.Text = "CPU";
			this.CPU.Width = 140;
			// 
			// btn_KillProcess
			// 
			this.btn_KillProcess.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_KillProcess.Location = new System.Drawing.Point(707, 420);
			this.btn_KillProcess.Margin = new System.Windows.Forms.Padding(2);
			this.btn_KillProcess.Name = "btn_KillProcess";
			this.btn_KillProcess.Size = new System.Drawing.Size(82, 19);
			this.btn_KillProcess.TabIndex = 4;
			this.btn_KillProcess.Text = "Kill Process";
			this.btn_KillProcess.UseVisualStyleBackColor = true;
			this.btn_KillProcess.Click += new System.EventHandler(this.btn_KillProcess_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btn_KillProcess);
			this.Controls.Add(this.lv_ProcList);
			this.Name = "MainForm";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListView lv_ProcList;
		private System.Windows.Forms.ColumnHeader NameProcesses;
		private System.Windows.Forms.ColumnHeader PID;
		private System.Windows.Forms.ColumnHeader Memory;
		private System.Windows.Forms.ColumnHeader CPU;
		private System.Windows.Forms.Button btn_KillProcess;
	}
}

