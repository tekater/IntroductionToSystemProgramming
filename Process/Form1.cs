using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

/* 
 COMMIT CHANGES:
 1. ADD/DEL DONE
 1.1. FORM UPDATE
 2. ProcInfo DONE
 3. 
 */

namespace Process
{
	public partial class Form1 : Form
	{
		List<System.Diagnostics.Process> process_list;
		public Form1()
		{
			InitializeComponent();
			//rtbProcessName.Text = "notepad";
			process_list = new List<System.Diagnostics.Process>();
			AllignText();
			//InitProcess();
			lvProcesses.Columns.Add("PID");
			lvProcesses.Columns.Add("NAME");
		}
		void InitProcess()
		{
			AllignText();
			myProcess = new System.Diagnostics.Process();
			myProcess.StartInfo = new System.Diagnostics.ProcessStartInfo(rtbProcessName.Text);
			myProcess.Start();

			process_list.Add(myProcess);
			//lvProcesses.Items.Add(myProcess.ToString());

			lvProcesses.Items.Add(myProcess.Id.ToString());
			lvProcesses.Items[lvProcesses.Items.Count - 1].SubItems.Add(myProcess.ProcessName);
		}
		void AllignText()
		{
			rtbProcessName.SelectAll();
			rtbProcessName.SelectionAlignment = HorizontalAlignment.Center;
		}
		private void btnStart_Click(object sender, EventArgs e)
		{
			InitProcess();
			timer1.Enabled = true;
			this.TopMost = true;
		}
		private void btnStop_Click(object sender, EventArgs e)
		{
			//if (process_list.Count > 0)
			if(lvProcesses.Items.Count > 0)
			{
				try
				{
					//myProcess = process_list.Last();
					myProcess = System.Diagnostics.Process.GetProcessById(Convert.ToInt32(lvProcesses.Items[lvProcesses.Items.Count - 1].Text));

					myProcess.CloseMainWindow();    // Закрывает процесс
					//myProcess.WaitForExit();		// Ждёт закрытия процесса
					myProcess.Close();              // Освобождает ресурсы, занимаемые процессом
					//myProcess.Kill();				// Секир башка

					//process_list.RemoveAt(process_list.Count - 1);
					lvProcesses.Items.RemoveAt(lvProcesses.Items.Count - 1);
				}
				catch (Exception ex)
				{
					//process_list.RemoveAt(process_list.Count - 1);
					lvProcesses.Items.RemoveAt(lvProcesses.Items.Count - 1);
				}
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			//btnStop_Click(sender, e);
			/*foreach(System.Diagnostics.Process i in process_list)
			{
				i.CloseMainWindow();
				i.Close();
				process_list.RemoveAt(0);
			}*/

			while (process_list.Count > 0)
			{
				try
				{
					process_list.First().CloseMainWindow();
					process_list.First().Close();
					process_list.RemoveAt(0);
				}
				catch (Exception ex)
				{
					process_list.RemoveAt(0);
				}
			}

			/*while(lvProcesses.Items.Count > 0)
			{
				try
				{
					process_list.First().CloseMainWindow();
					process_list.First().Close();
					process_list.RemoveAt(0);
				}
				catch (Exception ex)
				{
					process_list.RemoveAt(0);
				}
			}*/
			 
		}
		void Info() //Выяснить, почему при закрытии калькулятора падает исключение - калькулятор запускается в несколько потоков, поэтому при закрытии первого потока не затрагивает сам процесс.
		{			// Калькулятор запускается как самостоятельный процесс.
			if (process_list.Count > 0)
			{
				myProcess = process_list.First();
				//lblProcessInfo.Text = "Process info:\n";
				//lblProcessInfo.Text = "";
				//lblProcessInfo.Text = "Total process Count: "		+	$"{process_list.Count}					\n";
				lblProcessInfo.Text = "Total process Count: "		+	$"{lvProcesses.Items.Count}				\n";
				lblProcessInfo.Text += "Current Process															\n";
				lblProcessInfo.Text += "Name: "						+	$"{myProcess.ProcessName}				\n";
				lblProcessInfo.Text += "PID: "						+	$"{myProcess.Id}						\n";
				lblProcessInfo.Text += "Session Id: "				+	$"{myProcess.SessionId}					\n";
				lblProcessInfo.Text += "Base Priority: "			+	$"{myProcess.BasePriority}				\n";
				lblProcessInfo.Text += "Priority Class: "			+	$"{myProcess.PriorityClass}				\n";
				lblProcessInfo.Text += "Start Time: "				+	$"{myProcess.StartTime.Hour}:"			+
																		$"{myProcess.StartTime.Minute}			\n";
				lblProcessInfo.Text += "Total Processor Time: "		+	$"{myProcess.TotalProcessorTime.Seconds}\n";
				lblProcessInfo.Text += "User Processor Time: "		+	$"{myProcess.UserProcessorTime.Seconds}	\n";
				lblProcessInfo.Text += "Affinity: "					+	$"{myProcess.ProcessorAffinity}			\n";
				lblProcessInfo.Text += "Threads: "					+	$"{myProcess.Threads.Count}				\n";
			}
			else
			{
				lblProcessInfo.Text = "LoadInfo...";
				timer1.Enabled = false;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Info();
		}
	}
}