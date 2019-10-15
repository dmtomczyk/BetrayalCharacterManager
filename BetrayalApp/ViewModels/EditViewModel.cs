using BetrayalApp.Models;
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
            //SelectedCharacter = MVMInstance.SelectedCharacter;
        }

        #region Member Properties

        private MainViewModel MVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<MainViewModel>();

        private PlayerCharacter _selectedCharacter;
        public PlayerCharacter SelectedCharacter
        {
            get => _selectedCharacter;
            set => Set(ref _selectedCharacter, value);
        }

        #endregion // End of Member Properties 

        #region Commands

        /// <summary>
        /// This command calls the UpdatePlayer Method to save new information.
        /// </summary>
        public ICommand UpdatePlayerCommand => new RelayCommand(() =>
        {
            UpdatePlayer();
        });

        /// <summary>
        /// Increments appropriate values based on command parameter.
        /// </summary>
        public ICommand IncrementValueCommand => new RelayCommand<string>((parameter) =>
        {
            // Getting the operator & value to apply operator to from the command parameter
            string operate = parameter.Substring(0, 1);
            string value = parameter.Substring(1);

            // Incrementing by one
            if(operate == "+")
            {
                if (value == "knowledge")
                    SelectedCharacter.Knowledge++;
                if (value == "sanity")
                if (value == "speed")
                if (value == "might")
            }
            // Decrement
            else
            {

            }

        });

        /// <summary>
        /// Increments appropriate values based on command parameter.
        /// </summary>
        //public ICommand IncrementValueCommand => new RelayCommand<string>((s) => IncrementValues(s));

        #endregion // End of Commands

        /// <summary>
        /// This method gets called from <see cref="IncrementValueCommand"/> with the command paramater.
        /// </summary>
        /// <param name="s"></param>
        private void IncrementValues(string parameter)
        {
            // Getting the operator & value to apply operator to from the command parameter
            string operate = parameter.Substring(0, 1);
            string value = parameter.Substring(1);
        }

        /// <summary>
        /// This method cleans up the UI and "closes" editview.
        /// </summary>
        private void UpdatePlayer()
        {
            // NOTE: We don't need to "save" the updates since the values are databound and are
            // "saved" automatically. Maybe implement actual saving when the DB is setup.

            // Clearing the VM to cleanup the UI
            MVMInstance.EditVMInstance = null;
        }

    }

}