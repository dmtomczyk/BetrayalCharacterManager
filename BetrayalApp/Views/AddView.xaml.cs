using System;
using System.Collections.Generic;
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

namespace BetrayalApp.Views
{
    /// <summary>
    /// Interaction logic for AddView.xaml
    /// </summary>
    public partial class AddView : UserControl
    {
        public AddView()
        {
            this.DataContext = this;
            InitializeComponent();

            Dispatcher.ShutdownStarted += OnDispatcherShutDownStarted;

            //Loaded += (s, e) => {
            //    Window.GetWindow(this)
            //        .Closing += (s1, e1) => Dispose();
            //};
        }

        private void OnDispatcherShutDownStarted(object sender, EventArgs e)
        {
            var Disposable = DataContext as IDisposable;

            if (!(Disposable is null))
            {
                Disposable.Dispose();
            }
        }

        //private void Dispose()
        //{
        //    // throw new NotImplementedException();
        //}
    }
}
