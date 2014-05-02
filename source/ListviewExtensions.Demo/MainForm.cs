using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace ListviewExtensions.Demo
{

	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			//webBrowser1.Navigate("res://ListviewExtensions.Demo.exe/help.htm");
			Stream docStream =Assembly.GetExecutingAssembly().GetManifestResourceStream("help.htm");
			webBrowser1.DocumentStream = docStream;
		}
		
		void Button4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void Button2Click(object sender, EventArgs e)
		{
			listview1.SaveColumns();
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			listview1.LoadColumns();
		}
	}
}
