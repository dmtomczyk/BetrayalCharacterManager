using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// AddViewModel (VM for AddView.xaml)
    /// </summary>
    public class AddViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the EditViewModel class.
        /// </summary>
        public AddViewModel()
        {
        }

        #region Member Properties

        public string TempTest { get; set; }

        #endregion // End of Member Properties 

        #region Commands

        /// <summary>
        /// This command calls the SavePlayer Method to save new information.
        /// </summary>
        public ICommand SavePlayerCommand => new RelayCommand(() =>
        {

        });

        #endregion // End of Commands
    }
}