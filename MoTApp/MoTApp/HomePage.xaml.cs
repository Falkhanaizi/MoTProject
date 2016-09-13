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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace MoTApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            this.InitializeComponent();

            ObservableCollection<Update> updates = new ObservableCollection<Update> { new Update("Assets/BahrainBus1.jpg","hdlkashdkah \n fdsfsd"),
            new Update("Assets/BahrainBus2.jpg","hdlkashdkah \n \n \n \n fdsfsd"),
            new Update("Assets/BahrainBus3.jpg","hdlkashdkah \n fdsfsd"),
            new Update("Assets/BahrainBus4.jpg","hdlkashdkah \n \n fdsfsd")
            };

            ForUpdatesView.ItemsSource = updates;
        }

    }

    internal class Update
    {
        public string ImageSource { get; private set; }
        public string UpdateText { get; private set; }

        public Update(string source, string text)
        {
            ImageSource = source;
            UpdateText = text;
        }
    }
}
