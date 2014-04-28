using System;
using System.Drawing;
using System.Windows.Forms;

namespace ListviewExtensions.Tests
{

	public partial class TestForm : Form
	{
		public TestForm()
		{

			InitializeComponent();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button1Click(object sender, EventArgs e)
		{
			listview1.SaveColumns();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listview1.LoadColumns();
		}
	}
}
