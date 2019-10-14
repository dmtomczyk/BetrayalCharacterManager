using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// EditViewModel (VM for EditView.xaml)
    /// </summary>
    public class EditViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the EditViewModel class.
        /// </summary>
        public EditViewModel()
        {
        }

        #region Member Properties

        public string TempTest { get; set; }

        #endregion // End of Member Properties 

        #region Commands

        /// <summary>
        /// This command calls the UpdatePlayer Method to save new information.
        /// </summary>
        public ICommand UpdatePlayerCommand => new RelayCommand(() =>
        {

        });

        #endregion // End of Commands
    }
}