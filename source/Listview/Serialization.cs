using System;
using System.ComponentModel;
using System.Xml.Schema;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace h3Innovations.ListviewExtensions
{
	/// <summary>
	/// Description of Serialization.
	/// </summary>
	public static class Serialization
	{
		public static void SerializeColumns(Listview.ColumnHeaderCollection headers, string ApplicationName, string ListviewName) {
			List<ColumnEntry> cols = new List<Serialization.ColumnEntry>();
			foreach (System.Windows.Forms.ColumnHeader header in headers) {
				cols.Add(new ColumnEntry(header.Width, header.Index));
			}
			
			string filespec = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ApplicationName + "." + ListviewName + ".xml");
			StreamWriter stream = new StreamWriter(filespec);
			XmlSerializer serializer = new XmlSerializer(typeof(List<ColumnEntry>));
			serializer.Serialize(stream, (cols));
			stream.Close();				
			
		}
		public static void DeserializeColumns(Listview.ColumnHeaderCollection headers, string ApplicationName, string ListviewName) {
			try {
				string filespec = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, ApplicationName + "." + ListviewName + ".xml");
				StreamReader stream = new StreamReader(@filespec);
				XmlSerializer serializer = new XmlSerializer(typeof(List<ColumnEntry>));
				List<ColumnEntry> cols = (List<ColumnEntry>)serializer.Deserialize(stream);
				stream.Close();		
				foreach (ColumnEntry col in cols) {headers[col.headerIndex].Width = col.width;}
			} catch (Exception) {
				
				//TEMP: just swallow the exception for now
			}
		}
		[Serializable()]
		public class ColumnEntry {
			[XmlAttribute("width")]
			public int width {get; set;}
			[XmlAttribute("subitemIndex")]
			public int headerIndex {get; set;}
			public ColumnEntry() {}
			public ColumnEntry(int headerWidth, int headerIdx) {
				width = headerWidth;
				headerIndex = headerIdx;
			}
				
		}
	}
}
