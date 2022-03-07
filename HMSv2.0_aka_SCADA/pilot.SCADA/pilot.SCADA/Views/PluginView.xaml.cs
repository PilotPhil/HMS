
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pilot.SCADA.Views
{
    /// <summary>
    /// PluginView.xaml 的交互逻辑
    /// </summary>
    public partial class PluginView : UserControl
    {
        public PluginView()
        {
            InitializeComponent();

            SSSSSSSS();
        }

        private CompositionContainer container = null;

        private void SSSSSSSS()
        {
            //var dir = new DirectoryInfo(System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Plugin"));
            //if (dir.Exists)
            //{
            //    var catalog = new DirectoryCatalog(dir.FullName, "*.dll");
            //    container = new CompositionContainer(catalog);
            //    try
            //    {
            //        container.ComposeParts(this);
            //    }
            //    catch (CompositionException compositionEx)
            //    {
            //        Console.WriteLine(compositionEx.ToString());
            //    }

            //    IEnumerable<IPlugin> plugins = container.GetExportedValues<IPlugin>();

            //    foreach (var plugin in plugins)
            //    {
            //        this.tab.Items.Add(new TabItem() { Header = plugin.ToString(), Content = plugin });
            //    }
            //}
        }
    }
}
