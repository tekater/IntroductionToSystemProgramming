using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManager
{
	public partial class MainForm : Form
	{
		string path_process;
		PerformanceCounter cpu;
		PerformanceCounter ram;
		public MainForm()
		{
			InitializeComponent();
			LoadProc();
		}
		void LoadProc()
		{
			ListViewItem lvItem = new ListViewItem();
			Process[] processes = Process.GetProcesses();
			lv_ProcList.Items.Clear();

			foreach (Process process in processes)
			{
				cpu = new PerformanceCounter("Process", "% Processor Time",		process.ProcessName);
				ram = new PerformanceCounter("Process", "Working Set - Private",process.ProcessName);

				string[] items = null;
				items = new string[] 
				{
					process.ProcessName,
					process.Id.ToString(),
					$"{Convert.ToString(Convert.ToInt32(ram.NextValue() / 1000000))} Mb",
					cpu.NextValue().ToString() 
				};

				lvItem = new ListViewItem(items);
				lvItem.Group = (process.MainWindowHandle == IntPtr.Zero ? lv_ProcList.Groups["BGProc"] : lv_ProcList.Groups["Applications"]);

				lv_ProcList.Items.Add(lvItem);
			}
		}

		private void btn_KillProcess_Click(object sender, EventArgs e)
		{
			Process Crewmate = Process.GetProcessById(Convert.ToInt32(lv_ProcList.SelectedItems[0].SubItems[1].Text));
			Crewmate.Kill(); Thread.Sleep(200); LoadProc();
		}
	}
}
