using BetrayalApp.ViewModels;
using GalaSoft.MvvmLight.Messaging;
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
            InitializeComponent();

            Messenger.Default.Register<NotificationMessage>(this, (NotificationMessage) =>
            {
                if (DataContext is MainViewModel mvm)
                {

                }
            });

        }

        #region Button Click Events

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "add"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddCharacter_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
        }

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "edit"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EditCharacter_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
        }

        /// <summary>
        /// Calls <see cref="ChangeMode(string)"/> with a paramater of "overview"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ViewOverview_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
        }

        /// <summary>
        /// Event handler for saving a new player click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SaveNewPlayer_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
        }

        /// <summary>
        /// Event handler for updating an existing player click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void UpdatePlayer_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
        }

        /// <summary>
        /// Handles the remove player click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RemovePlayer_Click(object sender, RoutedEventArgs e)
        {
            // DONE: Converted to Command in MainViewModel
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

        private bool _isTraitor;
        /// <summary>
        /// Stores the characters IsTraitor value
        /// </summary>
        public bool IsTraitor
        {
            get
            {
                //CheckForValidValues();
                return _isTraitor;
            }
            set
            {
                if (value != _isTraitor)
                {
                    this._isTraitor = value;
                    NotifyPropertyChanged();
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
