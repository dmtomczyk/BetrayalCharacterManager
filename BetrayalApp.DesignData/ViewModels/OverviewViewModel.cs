using BetrayalApp.DesignData.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BetrayalApp.DesignData
{
    /// <summary>
    /// DesignTime ViewModel for OverviewView.xaml in the BetrayalApp Project
    /// </summary>
    public class OverviewViewModel
    {
        // Populating data for designtime.
        public OverviewViewModel()
        {
            // Initializing AllCharacters O.C.
            AllCharacters = new ObservableCollection<PlayerCharacter>();

            PopulateAllCharacters();
        }

        #region Member Properties

        private ObservableCollection<PlayerCharacter> _allCharacters;
        /// <summary>
        /// Stores all valid characters in the ListBox.
        /// </summary>
        public ObservableCollection<PlayerCharacter> AllCharacters
        {
            get => _allCharacters;
            set
            {
                if (value != _allCharacters)
                    this._allCharacters = value;
            }
        }

        #endregion // End of Member Properties

        /// <summary>
        /// Populates <see cref="AllCharacters"/> with dummy data for designtime stuff.
        /// </summary>
        private void PopulateAllCharacters()
        {
            // Adding Daymian as Ox Bellows
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Daymian (Ox Bellows)",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });

            // Adding Player 2
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Player 2",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });

            // Adding Player 
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Player 3",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });

            // Adding Player 
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Player 4",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });

            // Adding Player 
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Player 5",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });

            // Adding Player 
            AllCharacters.Add(new PlayerCharacter()
            {
                IsTraitor = false,
                Name = "Player 6",
                Knowledge = 5,
                Might = 5,
                Speed = 5,
                Sanity = 5,
                AreValuesValid = true
            });
        }

    }

}
