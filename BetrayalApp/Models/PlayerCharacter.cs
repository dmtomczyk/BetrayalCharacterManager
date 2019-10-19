using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BetrayalApp.Models
{
    /// <summary>
    /// One PlayerCharacter instance contains all valid <see cref="DefaultCharacter"/>.
    /// <para>Each <see cref="DefaultCharacter"/> contains their respective increments for each 'stat'</para>
    /// </summary>
    public class PlayerCharacter : INotifyPropertyChanged
    {

        /// <summary>
        /// Instantiating a new playerCharacter with a List of valid DefaultCharacters to choose from.
        /// </summary>
        public PlayerCharacter()
        {

        }

        #region INotifyPropertyChanged Implementation

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

        private DefaultCharacter _selectedBaseCharacter;
        /// <summary>
        /// Stores the players "base" character. (Deterines base and valid increments.
        /// </summary>
        public DefaultCharacter SelectedBaseCharacter
        {
            get => _selectedBaseCharacter;
            set
            {
                if (value != _selectedBaseCharacter)
                {
                    this._selectedBaseCharacter = value;
                    NotifyPropertyChanged();
                }
            }
        }

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

        private int _currentMightIndex;
        /// <summary>
        /// Stores the characters might index,
        /// </summary>
        public int CurrentMightIndex
        {
            get
            {
                //CheckForValidValues();
                return _currentMightIndex;
            }
            set
            {
                if (value != _currentMightIndex)
                {
                    this._currentMightIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _currentSpeedIndex;
        /// <summary>
        /// Stores the characters dpeed index.
        /// </summary>
        public int CurrentSpeedIndex
        {
            get
            {
                //CheckForValidValues();
                return _currentSpeedIndex;
            }
            set
            {
                if (value != _currentSpeedIndex)
                {
                    this._currentSpeedIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _currentSanityIndex;
        /// <summary>
        /// Stores the characters sanity index.
        /// </summary>
        public int CurrentSanityIndex
        {
            get
            {
                //CheckForValidValues();
                return _currentSanityIndex;
            }
            set
            {
                if (value != _currentSanityIndex)
                {
                    this._currentSanityIndex = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _currentKnowledgeIndex;
        /// <summary>
        /// Stores the characters knowledge index.
        /// </summary>
        public int CurrentKnowledgeIndex
        {
            get
            {
                //CheckForValidValues();
                return _currentKnowledgeIndex;
            }
            set
            {
                if (value != _currentKnowledgeIndex)
                {
                    this._currentKnowledgeIndex = value;
                    NotifyPropertyChanged();
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

        private bool? _isTraitor;
        /// <summary>
        /// Stores the characters IsTraitor value
        /// </summary>
        public bool? IsTraitor
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

}
