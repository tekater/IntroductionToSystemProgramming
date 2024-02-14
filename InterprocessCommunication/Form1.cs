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
using System.Runtime.InteropServices;
using System.IO;
using System.Reflection;
using System.Management;

namespace InterprocessCommunication
{
	public partial class Form1 : Form
	{
		const uint WM_SETTEXT = 0X0C;
		[DllImport("user32.dll")]
		public static extern IntPtr SendMessage(IntPtr hwnd, uint uMsg, int wParam, [MarshalAs(UnmanagedType.LPStr)] string lParam);
		List<Process> processes = new List<Process>();
		int count = 0;
		public Form1()
		{
			InitializeComponent();
			LoadAvailableAssemblies();
			btnStart.Enabled = false;
			btnCloseWindow.Enabled = false;
		}

		void LoadAvailableAssemblies()
		{
			/*MessageBox.Show
				(
				this,
				Application.StartupPath,
				"Super Puper Duper Mega INFORMATION",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
				);*/
			string except = new FileInfo(Application.ExecutablePath).Name;
			except.Substring(0, except.IndexOf("."));
			string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");

			foreach (string file in files)
			{
				string fileName = new FileInfo(file).Name;

				if (fileName.IndexOf(except) == -1)
				{
					lbAssemblies.Items.Add(fileName);
				}
			}
		}

		void RunProcess(string assemlyName)
		{
			Process proc = Process.Start(assemlyName);
			//proc.Start(assemlyName);

			//Process proc = new Process.Start(AssemlyName);

			processes.Add(proc);
			if (Process.GetCurrentProcess().Id == GetParentProcessID(proc.Id));
			{
				/*MessageBox.Show
					(
					this,
					proc.ProcessName + " дочерний поток текущего процесса.",
					"Info",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
					);*/

				proc.EnableRaisingEvents = true;
				proc.Exited += Proc_Exited;

				SendMessage(proc.MainWindowHandle, WM_SETTEXT, 0, $"Child process #{count++}");

				if (!lbProcesses.Items.Contains(proc.ProcessName))
				{
					lbProcesses.Items.Add(proc.ProcessName);
					lbAssemblies.Items.Remove(lbAssemblies.SelectedItem);
				}
			}

		}

		private void Proc_Exited(object sender, EventArgs e)
		{
			Process proc = sender as Process;

			lbProcesses.Items.Remove(proc.ProcessName);
			lbAssemblies.Items.Add(proc.ProcessName);

			processes.Remove(proc);

			count--;
			int index = 0;

			foreach (Process process in processes)
			{
				SendMessage(process.MainWindowHandle, WM_SETTEXT, 0, $"Child process #{++index}");
			}
			//throw new NotImplementedException();
		}

		int GetParentProcessID(int id)
		{
			int parentId = 0;

			using (System.Management.ManagementObject obj = new ManagementObject($"win32_process.handle = {id}"))
			{
				obj.Get();
				parentId = Convert.ToInt32(obj["ParentProcessId"]);
			}

			return parentId;
		}

		delegate void ProcessDelegate(Process proc);
		void ExecuteOnProcessByName(string processName,ProcessDelegate function)
		{
			Process[] processes = Process.GetProcessesByName(processName);
			foreach(Process process in processes)
			{
				if (Process.GetCurrentProcess().Id == GetParentProcessID(process.Id))
				{
					function(process);
				}
			}
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			RunProcess(lbAssemblies.SelectedItem.ToString());
		}

		void Kill(Process proc)
		{
			proc.Kill();
		}

		private void btnStop_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lbProcesses.SelectedItems.ToString(), Kill);
			lbProcesses.Items.Remove(lbProcesses.SelectedItem);
		}

		private void Form1_Load(object sender, EventArgs e){}
		void CloseMainWindow(Process proc)
		{
			proc.CloseMainWindow();
		}
		private void btnCloseWindow_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lbProcesses.SelectedItems.ToString(), CloseMainWindow);
			lbProcesses.Items.Remove(lbProcesses.SelectedItem);
		}
		void Refresh(Process proc)
		{
			proc.Refresh();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			ExecuteOnProcessByName(lbProcesses.SelectedItem.ToString(), Refresh);
		}

		private void lbAssemblies_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lbAssemblies.SelectedItems.Count == 0)
			{
				btnStart.Enabled = false;
			}
			else
			{
				btnStart.Enabled = true;
			}
		}

		private void lbProcesses_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(lbProcesses.SelectedItems.Count == 0)
			{
				btnStop.Enabled = false;
				btnCloseWindow.Enabled = false;
			}
			else
			{
				btnStop.Enabled = true;
				btnCloseWindow.Enabled = true;
			}
		}

		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			foreach(Process process in processes)
			{
				process.Kill();
			}
		}
	}
}
