
namespace ListviewExtensions.Demo
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.listview1 = new h3Innovations.Listview();
			this.SuspendLayout();
			// 
			// listview1
			// 
			this.listview1.Location = new System.Drawing.Point(8, 8);
			this.listview1.Name = "listview1";
			this.listview1.Size = new System.Drawing.Size(264, 168);
			this.listview1.TabIndex = 0;
			this.listview1.UseCompatibleStateImageBehavior = false;
			this.listview1.View = System.Windows.Forms.View.Details;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 264);
			this.Controls.Add(this.listview1);
			this.Name = "MainForm";
			this.Text = "ListviewExtensions.Demo";
			this.ResumeLayout(false);
		}
		private h3Innovations.Listview listview1;
	}
}
