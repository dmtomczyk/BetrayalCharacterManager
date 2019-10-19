using BetrayalApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
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
            //SelectedCharacter = new PlayerCharacter();
            SelectedCharacter = MVMInstance.SelectedCharacter;
            CurrentSpeed = SelectedCharacter.SelectedBaseCharacter.SpeedIncrements[SelectedCharacter.CurrentSpeedIndex];
        }

        #region Member Properties

        private MainViewModel MVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<MainViewModel>();

        private PlayerCharacter _selectedCharacter;
        public PlayerCharacter SelectedCharacter
        {
            get => _selectedCharacter;
            set => Set(ref _selectedCharacter, value);
        }

        private int _currentSpeed;
        /// <summary>
        /// Stores current speed for databinding purposes.
        /// </summary>
        public int CurrentSpeed
        {
            get => _currentSpeed;
            set => Set(ref _currentSpeed, value);
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
                    if(SelectedCharacter.CurrentKnowledgeIndex < 7)
                    {
                        SelectedCharacter.CurrentKnowledgeIndex++;
                        SelectedCharacter.Knowledge = SelectedCharacter.SelectedBaseCharacter.KnowledgeIncrements[SelectedCharacter.CurrentKnowledgeIndex];
                    }
                if (value == "sanity")
                    if (SelectedCharacter.CurrentSanityIndex < 7)
                    {
                        SelectedCharacter.CurrentSanityIndex++;
                        SelectedCharacter.Sanity = SelectedCharacter.SelectedBaseCharacter.SanityIncrements[SelectedCharacter.CurrentSanityIndex];
                    }
                if (value == "speed")
                    if (SelectedCharacter.CurrentSpeedIndex < 7)
                    {
                        SelectedCharacter.CurrentSpeedIndex++;
                        SelectedCharacter.Speed = SelectedCharacter.SelectedBaseCharacter.SpeedIncrements[SelectedCharacter.CurrentSpeedIndex];
                    }
                if (value == "might")
                    if (SelectedCharacter.CurrentMightIndex < 7)
                    {
                        SelectedCharacter.CurrentMightIndex++;
                        SelectedCharacter.Might = SelectedCharacter.SelectedBaseCharacter.MightIncrements[SelectedCharacter.CurrentMightIndex];
                    }
            }
            // Decrement
            else
            {
                if (value == "knowledge")
                    if (SelectedCharacter.CurrentKnowledgeIndex > 0)
                    {
                        SelectedCharacter.CurrentKnowledgeIndex--;
                        SelectedCharacter.Knowledge = SelectedCharacter.SelectedBaseCharacter.KnowledgeIncrements[SelectedCharacter.CurrentKnowledgeIndex];
                    }
                if (value == "sanity")
                    if (SelectedCharacter.CurrentSanityIndex > 0)
                    {
                        SelectedCharacter.CurrentSanityIndex--;
                        SelectedCharacter.Sanity = SelectedCharacter.SelectedBaseCharacter.SanityIncrements[SelectedCharacter.CurrentSanityIndex];
                    }
                if (value == "speed")
                    if (SelectedCharacter.CurrentSpeedIndex > 0)
                    {
                        SelectedCharacter.CurrentSpeedIndex--;
                        SelectedCharacter.Speed = SelectedCharacter.SelectedBaseCharacter.SpeedIncrements[SelectedCharacter.CurrentSpeedIndex];
                    }
                if (value == "might")
                    if (SelectedCharacter.CurrentMightIndex > 0)
                    {
                        SelectedCharacter.CurrentMightIndex--;
                        SelectedCharacter.Might = SelectedCharacter.SelectedBaseCharacter.MightIncrements[SelectedCharacter.CurrentMightIndex];
                    }
            }

        });

        /// <summary>
        /// Increments appropriate values based on command parameter.
        /// </summary>
        //public ICommand IncrementValueCommand => new RelayCommand<string>((s) => IncrementValues(s));

        #endregion // End of Commands

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