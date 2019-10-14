using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// AddViewModel (VM for AddView.xaml)
    /// <para>Each </para>
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

        private bool _isVisible;
        /// <summary>
        /// Tracks whether the VM is visible to the user.
        /// </summary>
        public bool IsVisible
        {
            get => _isVisible;
            set => Set(ref _isVisible, value);
        }

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