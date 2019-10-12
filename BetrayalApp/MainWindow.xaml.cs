using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace BetrayalApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {

        #region INotifyPropertyChangedImplementation

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// This method is called in the setter of all member properties.
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        public MainWindow()
        {
            // Setting the default view to OverviewMode. Also explicitly confirming the other modes are false.
            OverviewMode = true;
            EditMode = false;
            AddMode = false;

            // Setting Combobox Integers
            ValidValuesForCharacters = new ObservableCollection<int>();
            for (int i = 0; i < 11; i++)
            {
                ValidValuesForCharacters.Add(i); 
            }

            // Initializing AllCharacters O.C.
            AllCharacters = new ObservableCollection<Character>();

            InitializeComponent();
        }

        #region Member Properties

        private Character _selectedCharacter;
        /// <summary>
        /// Stores the currently selected character within the ListBox.
        /// </summary>
        public Character SelectedCharacter
        {
            get => _selectedCharacter;
            set
            {
                if (value != _selectedCharacter)
                {
                    this._selectedCharacter = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<Character> _allCharacters;
        /// <summary>
        /// Stores all valid characters in the ListBox.
        /// </summary>
        public ObservableCollection<Character> AllCharacters
        {
            get => _allCharacters;
            set
            {
                if (value != _allCharacters)
                {
                    this._allCharacters = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private ObservableCollection<int> _validValuesForCharacters;
        /// <summary>
        /// Stores all valid values for character values (1-10)
        /// </summary>
        public ObservableCollection<int> ValidValuesForCharacters
        {
            get => _validValuesForCharacters;
            set
            {
                if (value != _validValuesForCharacters)
                {
                    this._validValuesForCharacters = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _addMode;
        /// <summary>
        /// Stores whether or not AddMode is true;
        /// </summary>
        public bool AddMode
        {
            get => _addMode;
            set
            {
                if (value != _addMode)
                {
                    this._addMode = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _editMode;
        /// <summary>
        /// Stores whether or not EditMode is true;
        /// </summary>
        public bool EditMode
        {
            get => _editMode;
            set
            {
                if (value != _editMode)
                {
                    this._editMode = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _overviewMode;
        /// <summary>
        /// Stores whether or not OverviewMode is true;
        /// </summary>
        public bool OverviewMode
        {
            get => _overviewMode;
            set
            {
                if (value != _overviewMode)
                {
                    this._overviewMode = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion // End of Member Properties

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
                    EditMode = false;
                    OverviewMode = false;
                    AddMode = true;
                    SetupAddMode();
                    break;
                case "edit":
                    OverviewMode = false;
                    AddMode = false;
                    EditMode = true;
                    SetupEditMode();
                    break;
                case "overview":
                    EditMode = false;
                    AddMode = false;
                    OverviewMode = true;
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
            SelectedCharacter = new Character();
            SelectedCharacter.CheckForValidValues();
        }

        /// <summary>
        /// Sets all required params, etc. to initiate EditMode.
        /// </summary>
        private void SetupEditMode()
        {
            // TODO: 
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
        private bool NewCharHasCleanName()
        {
            bool cleanName = true;

            // Ensuring unique name
            foreach (Character character in AllCharacters)
            {
                if (character.Name.ToLower() == SelectedCharacter.Name.ToLower())
                {
                    cleanName = false;
                }
            }

            return cleanName;
        }

        #region Button Click Events

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "add"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCharacter_Click(object sender, RoutedEventArgs e)
        {
            ChangeMode("add");
        }

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "edit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCharacter_Click(object sender, RoutedEventArgs e)
        {
            ChangeMode("edit");
        }

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "overview"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewOverview_Click(object sender, RoutedEventArgs e)
        {
            ChangeMode("overview");
        }

        /// <summary>
        /// Event handler for saving a new player click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNewPlayer_Click(object sender, RoutedEventArgs e)
        {

            if (NewCharHasCleanName())
            {
                AllCharacters.Add(SelectedCharacter);
                ChangeMode("overview");
            }
            else
            {
                MessageBox.Show("Player's name must be unique!");
            }

        }

        #endregion // End of Button Click Events

    }

    #region Character Class

    public class Character : INotifyPropertyChanged
    {
        #region INotifyPropertyChangedImplementation

        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// This method is called in the setter of all member properties.
        /// </summary>
        /// <param name="propertyName"></param>
        public void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        #region Member Properties

        private bool _areValuesValid;
        /// <summary>
        /// Stores whether the playes values are valid as of now
        /// </summary>
        public bool AreValuesValid
        {
            get => _areValuesValid;
            set
            {
                if (value != _areValuesValid)
                {
                    this._areValuesValid = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _name;
        /// <summary>
        /// Stores the characters name (Joe, Daymian, etc.)
        /// </summary>
        public string Name
        {
            get
            {
                //CheckForValidValues();
                return _name;
            }
            set
            {
                if (value != _name)
                {
                    this._name = value;
                    NotifyPropertyChanged();
                    CheckForValidValues();
                }
            }
        }

        private int _might;
        /// <summary>
        /// Stores the characters might value (1-10)
        /// </summary>
        public int Might
        {
            get
            {
                //CheckForValidValues();
                return _might;
            }
            set
            {
                if (value != _might)
                {
                    this._might = value;
                    NotifyPropertyChanged();
                    CheckForValidValues();
                }
            }
        }

        private int _speed;
        /// <summary>
        /// Stores the characters speed value (1-10)
        /// </summary>
        public int Speed
        {
            get
            {
                //CheckForValidValues();
                return _speed;
            }
            set
            {
                if (value != _speed)
                {
                    this._speed = value;
                    NotifyPropertyChanged();
                    CheckForValidValues();
                }
            }
        }

        private int _sanity;
        /// <summary>
        /// Stores the characters sanity value (1-10)
        /// </summary>
        public int Sanity
        {
            get
            {
                //CheckForValidValues();
                return _sanity;
            }
            set
            {
                if (value != _sanity)
                {
                    this._sanity = value;
                    NotifyPropertyChanged();

                    CheckForValidValues();
                }
            }
        }

        private int _knowledge;
        /// <summary>
        /// Stores the characters knowledge value (1-10)
        /// </summary>
        public int Knowledge
        {
            get
            {
                //CheckForValidValues();
                return _knowledge;
            }
            set
            {
                if (value != _knowledge)
                {
                    this._knowledge = value;
                    NotifyPropertyChanged();
                    CheckForValidValues();
                }
            }
        }

        #endregion // End of Member Properties

        /// <summary>
        /// Sets the value of <see cref="AreValuesValid"/> based on the SelectedCharacters current values.
        /// </summary>
        public void CheckForValidValues()
        {
            if ((this?.Might >= 0 && this?.Might <= 10)
                && (this?.Sanity >= 0 && this?.Sanity <= 10)
                && (this?.Speed >= 0 && this?.Speed <= 10)
                && (this?.Knowledge >= 0 && this?.Knowledge <= 10)
                && (this?.Name?.Length > 0 && this?.Name?.Length <= 25))
            {
                AreValuesValid = true;
            }
            else
            {
                AreValuesValid = false;
            }
        }

    }

    #endregion // End of Character Class
}
