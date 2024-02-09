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
			//rtbProcessName.Text = "notepad";
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
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			myProcess.CloseMainWindow();    // Закрывает процесс
			//myProcess.WaitForExit();		// Ждёт закрытия процесса
			myProcess.Close();              // Освобождает ресурсы, занимаемые процессом
			//myProcess.Kill();				// Секир башка
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			btnStop_Click(sender, e);
		}
		void Info() //Выяснить, почему при закрытии калькулятора падает исключение - калькулятор запускается в несколько потоков, поэтому при закрытии первого потока не затрагивает сам процесс.
		{
			lblProcessInfo.Text = "Process info:\n";
			lblProcessInfo.Text += $"Name:					{myProcess.ProcessName}			\n";
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

		private void timer1_Tick(object sender, EventArgs e)
		{
			Info();
		}
	}
}