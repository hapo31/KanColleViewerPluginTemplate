using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;

using Grabacr07.KanColleViewer.Composition;
using Grabacr07.KanColleWrapper;

namespace KanColleViewerPluginTemplate
{
	[Export(typeof(IToolPlugin))]
	[ExportMetadata("Title", "")]
	[ExportMetadata("Description", "")]
	[ExportMetadata("Version", "")]
	[ExportMetadata("Author", "")]
	public class PluginEntry : IToolPlugin
	{

		public string ToolName
		{
			get { return "Plugin Name"; }
		}

		public object GetToolView()
		{
			return null;
		}

		public object GetSettingsView()
		{
			return null;
		}
	}
}
