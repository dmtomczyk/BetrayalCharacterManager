using BetrayalApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.ObjectModel;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// OverviewViewModel (VM for OverviewView.xaml)
    /// </summary>
    public class OverviewViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the EditViewModel class.
        /// </summary>
        public OverviewViewModel()
        {
            // TODO: Determine if I should store only player names in MainViewModel
            // and store all characters only here, or just leave it as is?
            // If I choose to implement more commands in here such as
            //  - IncrementValueCommand, etc. then that would be the best solution
            // as we will be not only accessing, but modifying AllCharacters values.
            AllCharacters = MVMInstance.AllCharacters;
        }

        #region Member Properties

        private readonly MainViewModel MVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<MainViewModel>();

        private ObservableCollection<PlayerCharacter> _allCharacters;
        /// <summary>
        /// Stores all valid characters in the ListBox.
        /// </summary>
        public ObservableCollection<PlayerCharacter> AllCharacters
        {
            get => _allCharacters;
            set => Set(ref _allCharacters, value);
        }

        #endregion // End of Member Properties 

        #region Commands

        /// <summary>
        /// This command can be used to update the characters given value
        /// <br/>by using command paramaters to increment specific values, etc.
        /// <para>throws NotImplementedException()</para>
        /// </summary>
        public ICommand IncrementCharacterValueCommand => new RelayCommand(() =>
        {
            // TODO: Implement?
            throw new NotImplementedException();
        });

        #endregion
    }
}