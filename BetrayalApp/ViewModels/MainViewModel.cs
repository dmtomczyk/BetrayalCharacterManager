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
            //OverviewMode = false;
            //EditMode = false;
            //AddMode = false;

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
        /// <summary>
        /// Stores one instance of EditViewModel that is linked to EditView in MainWindow.xaml.
        /// </summary>
        public EditViewModel EditVMInstance
        {
            get => _editVMInstance;
            set => Set(ref _editVMInstance, value);
        }

        private AddViewModel _addVMInstance;
        /// <summary>
        /// Stores one instance of AddViewModel that is linked to EditView in MainWindow.xaml.
        /// </summary>
        public AddViewModel AddVMInstance
        {
            get => _addVMInstance;
            set => Set(ref _addVMInstance, value);
        }

        private OverviewViewModel _overviewVMInstance;
        /// <summary>
        /// Stores one instance of OverviewViewModel that is linked to OverviewView in MainWindow.xaml.
        /// </summary>
        public OverviewViewModel OverviewVMInstance
        {
            get => _overviewVMInstance;
            set => Set(ref _overviewVMInstance, value);
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

        #endregion // End of Member Properties

        #region Commands

        /// <summary>
        /// This command sets up the EditPlayerView
        /// </summary>
        public ICommand ShowEditPlayerCommand => new RelayCommand(() =>
        {
            CleanUpViewModels();
            EditVMInstance = new EditViewModel();
            ChangeMode("edit");
        });

        /// <summary>
        /// This command signals the start of Adding a new character.
        /// </summary>
        public ICommand AddCharacterCommand => new RelayCommand(() =>
        {
            CleanUpViewModels();
            SelectedCharacter = null;
            AddVMInstance = null;
            AddVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<AddViewModel>();
            //AddVMInstance?.Cleanup();
            AddVMInstance = new AddViewModel();
            ChangeMode("add");
        });

        /// <summary>
        /// This command signals the start of editing an existing character.
        /// </summary>
        public ICommand EditCharacterCommand => new RelayCommand(() =>
        {
            // TODO: 
        });

        /// <summary>
        /// This command signals the viewing of the overview
        /// </summary>
        public ICommand ShowOverviewCommand => new RelayCommand(() =>
        {
            CleanUpViewModels();
            OverviewVMInstance = new OverviewViewModel();
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

            if (AddVMInstance != null)
                AddVMInstance.Cleanup();

            if (OverviewVMInstance != null)
                OverviewVMInstance = null;
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
            //AddVMInstance.NewCharacter = new PlayerCharacter();
            //AddVMInstance.NewCharacter.CheckForValidValues();
        }

        /// <summary>
        /// Sets all required params, etc. to initiate EditMode.
        /// </summary>
        private void SetupEditMode()
        {
            //EditVMInstance.SelectedCharacter = new PlayerCharacter();
            //EditVMInstance.SelectedCharacter = SelectedCharacter;
        }

        /// <summary>
        /// Sets all required params, etc. to initiate AddMode.
        /// </summary>
        private void SetupOverviewMode()
        {
            // TODO: 
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
            AllCharacters?.Remove(SelectedCharacter);
            if (AllCharacters?.Count < 1)
                AtLeastOneCharacter = false;
        }

        #endregion // End of Methods

    }
}