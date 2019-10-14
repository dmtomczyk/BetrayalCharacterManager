using BetrayalApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// MainViewModel (VM for MainWindow.xaml)
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            // Setting the default view to OverviewMode. Also explicitly confirming the other modes are false.
            OverviewMode = false;
            EditMode = false;
            AddMode = false;

            // Defaults
            AtLeastOneCharacter = false;

            // Setting Combobox Integers
            ValidValuesForCharacters = new ObservableCollection<int>();
            for (int i = 0; i < 11; i++)
            {
                ValidValuesForCharacters.Add(i);
            }

            // Initializing AllCharacters O.C.
            AllCharacters = new ObservableCollection<PlayerCharacter>();
        }

        #region Member Properties

        //public EditViewModel EditVMInstance { get; set; }
        private EditViewModel _editVMInstance;
        public EditViewModel EditVMInstance
        {
            get => _editVMInstance;
            set => Set(ref _editVMInstance, value);
        }

        private bool _atLeastOneCharacter;
        /// <summary>
        /// Stores whether or not at least one character exists.
        /// </summary>
        public bool AtLeastOneCharacter
        {
            get => _atLeastOneCharacter;
            set => Set(ref _atLeastOneCharacter, value);
        }

        private PlayerCharacter _selectedCharacter;
        /// <summary>
        /// Stores the currently selected character within the ListBox.
        /// </summary>
        public PlayerCharacter SelectedCharacter
        {
            get => _selectedCharacter;
            set => Set(ref _selectedCharacter, value);
        }

        private PlayerCharacter _editingCharacter;
        /// <summary>
        /// Stores the old values for the character being edited to allow us to get an accurate index.
        /// </summary>
        public PlayerCharacter EditingCharacter
        {
            get => _editingCharacter;
            set => Set(ref _editingCharacter, value);
        }

        private ObservableCollection<PlayerCharacter> _allCharacters;
        /// <summary>
        /// Stores all valid characters in the ListBox.
        /// </summary>
        public ObservableCollection<PlayerCharacter> AllCharacters
        {
            get => _allCharacters;
            set => Set(ref _allCharacters, value);
        }

        private ObservableCollection<int> _validValuesForCharacters;
        /// <summary>
        /// Stores all valid values for character values (1-10)
        /// </summary>
        public ObservableCollection<int> ValidValuesForCharacters
        {
            get => _validValuesForCharacters;
            set => Set(ref _validValuesForCharacters, value);
        }

        private bool _addMode;
        /// <summary>
        /// Stores whether or not AddMode is true;
        /// </summary>
        public bool AddMode
        {
            get => _addMode;
            set => Set(ref _addMode, value);
        }

        private bool _editMode;
        /// <summary>
        /// Stores whether or not EditMode is true;
        /// </summary>
        public bool EditMode
        {
            get => _editMode;
            set => Set(ref _editMode, value);
        }

        private bool _overviewMode;
        /// <summary>
        /// Stores whether or not OverviewMode is true;
        /// </summary>
        public bool OverviewMode
        {
            get => _overviewMode;
            set => Set(ref _overviewMode, value);
        }

        #endregion // End of Member Properties

        #region Commands

        /// <summary>
        /// This command sets up the EditPlayerView
        /// </summary>
        public ICommand ShowEditPlayerCommand => new RelayCommand(() =>
        {
            ChangeMode("edit");
            EditVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<EditViewModel>();
        });

        /// <summary>
        /// This command signals the start of Adding a new character.
        /// </summary>
        public ICommand AddCharacterCommand => new RelayCommand(() =>
        {
            CleanUpViewModels();
            ChangeMode("add");
        });

        /// <summary>
        /// This command signals the start of editing an existing character.
        /// </summary>
        public ICommand EditCharacterCommand => new RelayCommand(() =>
        {
            CleanUpViewModels();
            ChangeMode("edit");
        });

        /// <summary>
        /// This command signals the viewing of the overview
        /// </summary>
        public ICommand OverviewCommand => new RelayCommand(() =>
        {
            ChangeMode("overview");
        });

        /// <summary>
        /// This command signals the start of saving a new player.
        /// </summary>
        public ICommand SavePlayerCommand => new RelayCommand(() =>
        {
            if (CharHasUniqueName() || AllCharacters.Count == 0)
            {
                AllCharacters.Add(SelectedCharacter);
                AtLeastOneCharacter = true;
                ChangeMode("overview");
            }
            else
            {
                MessageBox.Show("Player's name must be unique!");
            }
        });

        /// <summary>
        /// This command signals the start of updating an existing player.
        /// </summary>
        public ICommand UpdatePlayerCommand => new RelayCommand(() =>
        {
            UpdatePlayerInformation();
        });

        /// <summary>
        /// This command signals the start of removing an existing player.
        /// </summary>
        public ICommand RemovePlayerCommand => new RelayCommand(() =>
        {
            RemovePlayer();
        });

        #endregion // End of Commands

        #region Methods

        /// <summary>
        /// This method clears all ViewModel Properties declared within MainViewModel.
        /// <para>It should be invoked BEFORE adding / creating a new VM instance to ensure it does not get removed accidentally.</para>
        /// </summary>
        private void CleanUpViewModels()
        {
            if (EditVMInstance != null)
                EditVMInstance = null;
        }

        /// <summary>
        /// This method ensures that only one mode is active at one time by handling all mode changes..
        /// <para>
        /// Accepts "add", "edit", and "overview"
        /// </para>
        /// </summary>
        /// <param name="newMode"></param>
        private void ChangeMode(string newMode)
        {
            switch (newMode)
            {
                case "add":
                    SetupAddMode();
                    break;
                case "edit":
                    SetupEditMode();
                    break;
                case "overview":
                    SetupOverviewMode();
                    break;
                default:
                    break;

            }
        }

        /// <summary>
        /// Sets all required params, etc. to initiate AddMode.
        /// </summary>
        private void SetupAddMode()
        {
            EditMode = false;
            OverviewMode = false;
            AddMode = true;

            SelectedCharacter = new PlayerCharacter();
            SelectedCharacter.CheckForValidValues();
        }

        /// <summary>
        /// Sets all required params, etc. to initiate EditMode.
        /// </summary>
        private void SetupEditMode()
        {
            OverviewMode = false;
            AddMode = false;
            EditMode = true;

            EditingCharacter = new PlayerCharacter();
            EditingCharacter = SelectedCharacter;   // Pass by value or reference?
        }

        /// <summary>
        /// Sets all required params, etc. to initiate AddMode.
        /// </summary>
        private void SetupOverviewMode()
        {
            EditMode = false;
            AddMode = false;
            OverviewMode = true;
        }

        /// <summary>
        /// Checks if the <see cref="SelectedCharacter"/> Name matches any names in <see cref="AllCharacters"/>.
        /// <br/>-> If any of the names match, we don't add the new character!.
        /// </summary>
        /// <returns></returns>
        private bool CharHasUniqueName()
        {
            bool cleanName = true;
            int index = AllCharacters.IndexOf(EditingCharacter);

            for (int i = 0; i < AllCharacters.Count; i++)
            {
                // Don't need to check the current players name against itself!
                if (i == index)
                    continue;
                else
                {
                    if (AllCharacters[i].Name.ToLower() == SelectedCharacter.Name.ToLower())
                    {
                        cleanName = false;
                    }
                }
            }

            return cleanName;
        }

        /// <summary>
        /// Updates a players information.
        /// </summary>
        private void UpdatePlayerInformation()
        {
            // Only allow saving if name is unique
            if (CharHasUniqueName() || AllCharacters.Count == 0)
            {
                int index = AllCharacters.IndexOf(SelectedCharacter);
                AllCharacters[index] = SelectedCharacter;
                AtLeastOneCharacter = true;
                ChangeMode("overview");
            }
            else
            {
                MessageBox.Show("Player's name must be unique!");
            }
        }

        /// <summary>
        /// Removes the currently selected character from AllCharacters.
        /// </summary>
        private void RemovePlayer()
        {
            AllCharacters.Remove(SelectedCharacter);
        }

        #endregion // End of Methods

    }
}