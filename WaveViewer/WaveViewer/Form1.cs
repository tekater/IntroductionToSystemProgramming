using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WaveViewer
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnStart_Click(object sender, EventArgs e)
		{

		}
		private void btnStop_Click(object sender, EventArgs e)
		{

		}

		private void mainToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if(panelAbout.Visible == false)
			{
				panelAbout.Visible = true;
			}
			else
			{
				panelAbout.Visible = false;
			}
		}

		private void waveViewerToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			if(panelWaveViewer.Visible == false)
			{
				panelWaveViewer.Visible = true;

				btnStart.Visible	= true;
				btnStop.Visible		= true;

				lblX.Visible		= true;
				lblY.Visible		= true;
				lblMedian.Visible	= true;
				lblMax.Visible		= true;
			}
			else
			{
				panelWaveViewer.Visible = false;

				btnStart.Visible	= false;
				btnStop.Visible		= false;

				lblX.Visible		= false;
				lblY.Visible		= false;
				lblMedian.Visible	= false;
				lblMax.Visible		= false;
			}
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
