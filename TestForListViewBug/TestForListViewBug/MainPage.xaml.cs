using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestForListViewBug
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public ObservableCollection<Recording> ListSource { get; set; }
        public MainPage()
        {
            this.InitializeComponent();
            int k = 0;
            int j = 0;
            ListSource = new ObservableCollection<Recording>();
            this.DataContext = this;
            for (int i = 0; i < 10; i++)
            {
                Recording recording = new Recording();
                recording.AddictionElement.Text = "TextBlock: " + i.ToString();
                recording.test= "TextBlock: " + i.ToString();
                ListSource.Add(recording);
            }

        }
    }

    public class Recording
    {
        public Recording()
        {
            AddictionElement = new TextBlock();
        }
        public TextBlock AddictionElement { get; set; }
        public string test { get; set; }
    }
}
