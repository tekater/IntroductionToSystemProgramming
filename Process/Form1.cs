using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Process
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			rtbProcessName.Text = "notepad";
			AllignText();
		}

		void InitProcess()
		{
			myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtbProcessName.Text);
		}
		void AllignText()
		{
			rtbProcessName.SelectAll();
			rtbProcessName.SelectionAlignment = HorizontalAlignment.Center;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			InitProcess();
			myProcess.Start();
			Info();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			myProcess.CloseMainWindow();	// Закрывает процесс
			myProcess.Close();				// Освобождает ресурсы, занимаемые процессом
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			btnStop_Click(sender, e);
		}
		void Info()
		{
			lblProcessInfo.Text = "Process info:\n";
			lblProcessInfo.Text += $"Name:			{myProcess.ProcessName}			\n";
			lblProcessInfo.Text += $"PID:					{myProcess.Id}					\n";
			lblProcessInfo.Text += $"Session Id:			{myProcess.SessionId}			\n";
			lblProcessInfo.Text += $"Base Priority:			{myProcess.BasePriority}		\n";
			lblProcessInfo.Text += $"Priority Class:		{myProcess.PriorityClass}		\n";
			lblProcessInfo.Text += $"Start Time:			{myProcess.StartTime}			\n";
			lblProcessInfo.Text += $"Total Processor Time:	{myProcess.TotalProcessorTime}	\n";
			lblProcessInfo.Text += $"User Processor Time:	{myProcess.UserProcessorTime}	\n";
			lblProcessInfo.Text += $"Affinity:				{myProcess.ProcessorAffinity}	\n";
			lblProcessInfo.Text += $"Threads:				{myProcess.Threads.Count}		\n";
		}
	}
}