using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TextDrawer
{
	public partial class MainForm : Form
	{
		string text = "Nothing here yet";
		Font font;
		public MainForm()
		{
			InitializeComponent();
			font = new Font("Arial", 48);
			panel1.Paint += Panel1_Paint;
			this.Paint += MainForm_Paint;
		}

		private void Panel1_Paint(object sender, PaintEventArgs e)
		{
			if (text.Length > 0)
			{
				//1) Создаём картинку:
				Image img = new Bitmap(panel1.ClientRectangle.Width, panel1.ClientRectangle.Height);

				//2) Для того чтобы что-либо нарисовать, нужен контекст устройства.
				//   Получаем контекст устройства(в данном случае, устройством является картинка): 
				//		Контекст устройства - это "та штука на которой рисуют"
				//											с. Олег Анатольевич
				// DC (Device Context) - то на чём можно рисовать.
				Graphics imgDC = Graphics.FromImage(img);


				//3) Очищаем фон, а после задаём цвет фона:
				imgDC.Clear(BackColor);// Image Device Context

				//4) Загоняем текст в картинку, используя контекст этой картинки:
				imgDC.DrawString
					(
					text, font,                                         // Текс + Шрифт
					Brushes.Black,                                      // Цвет
					ClientRectangle,                                    // Фигура
					new StringFormat(StringFormatFlags.NoFontFallback)  // Шрифт по умолчанию
					);


				//5) Прорисовываем картинку
				e.Graphics.DrawImage(img, 0, 0);
			}
		}

		private void MainForm_Paint(object sender, PaintEventArgs e)
		{
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}

		private void fontToolStripMenuItem_Click_1(object sender, EventArgs e)
		{
			//1) Создаём диалог изменения шрифта:
			FontDialog fontDialog = new FontDialog();

			//2) Загружаем текущий шрифт в диалог:
			fontDialog.Font = this.font;

			//3) Применяем новые настройки шрифта:
			if (fontDialog.ShowDialog() == DialogResult.OK)
			{
				this.font = fontDialog.Font;
			}

			//4) Принудительно вызываем событие отрисовки панели:
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}

		public void SetText(string text)
		{
			this.text = text;
			Panel1_Paint(panel1, new PaintEventArgs(panel1.CreateGraphics(), panel1.ClientRectangle));
		}

		public void Move(Point newLocation, int width)
		{
			this.Location = newLocation;
			this.Width = width;
		}

		
	}
}
