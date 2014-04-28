using System;
using System.Windows;
using System.Collections.Generic;

namespace h3Innovations {
	public class Listview : System.Windows.Forms.ListView  
	{
		public Listview() {}
		public void SaveColumns() {
			string appName = "";
			try {
				appName = AppDomain.CurrentDomain.ApplicationIdentity.FullName;	
			} catch (Exception) {
			} finally {
				if (appName == "") {appName = "Debug";}
				ListviewExtensions.Serialization.SerializeColumns(Columns, appName, Name);
			}
			
			
		}
		public void LoadColumns() {
			string appName = "";
			try {
				appName = AppDomain.CurrentDomain.ApplicationIdentity.FullName;	
			} catch (Exception) {
			} finally {
				if (appName == "") {appName = "Debug";}
				ListviewExtensions.Serialization.DeserializeColumns(Columns, appName, Name);
			}
			
		}
	}
}