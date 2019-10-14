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
            // Creating list of default characters for player to choose from.
            DefaultCharacters = new List<DefaultCharacter>
            {

                // Missy Dubourde
                new DefaultCharacter()
                {
                    DefaultName = "Missy Dubourde",
                    DefaultAge = 9,
                    DefaultBirthdate = "February 14",
                    DefaultSpeed = 5,
                    DefaultMight = 3,
                    DefaultSaniity = 3,
                    DefaultKnowledge = 4,
                    SpeedIncrements = new List<int>
                    {
                        3, 4, 5, 6, 6, 6, 7, 7
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 3, 4, 5, 6, 7
                    },
                    SanityIncrements = new List<int>
                    {
                        1, 2, 3, 4, 5, 5, 6, 7
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        2, 3, 4, 4, 5, 6, 6, 6
                    }
                },
                // Zoe Ingstrom
                new DefaultCharacter()
                {
                    DefaultName = "Zoe Ingstrom",
                    DefaultAge = 8,
                    DefaultBirthdate = "November 5",
                    DefaultSpeed = 4,
                    DefaultMight = 3,
                    DefaultSaniity = 5,
                    DefaultKnowledge = 3,
                    SpeedIncrements = new List<int>
                    {
                        4, 4, 4, 4, 5, 6, 8, 8
                    },
                    MightIncrements = new List<int>
                    {
                        2, 2, 3, 3, 4, 4, 6, 7
                    },
                    SanityIncrements = new List<int>
                    {
                        3, 4, 5, 5, 6, 6, 7, 8
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        1, 2, 3, 4, 4, 5, 5, 5
                    }
                },
                // Heather Granville
                new DefaultCharacter()
                {
                    DefaultName = "Heather Granville",
                    DefaultAge = 18,
                    DefaultBirthdate = "August 2",
                    DefaultSpeed = 4,
                    DefaultMight = 3,
                    DefaultSaniity = 3,
                    DefaultKnowledge = 5
                },
                // Jenny LeClerc
                new DefaultCharacter()
                {
                    DefaultName = "Jenny LeClerc",
                    DefaultAge = 21,
                    DefaultBirthdate = "March 4",
                    DefaultSpeed = 4,
                    DefaultMight = 4,
                    DefaultSaniity = 4,
                    DefaultKnowledge = 3
                },
                // Vivian Lopez
                new DefaultCharacter()
                {
                    DefaultName = "Vivian Lopez",
                    DefaultAge = 42,
                    DefaultBirthdate = "January 11",
                    DefaultSpeed = 4,
                    DefaultMight = 2,
                    DefaultSaniity = 4,
                    DefaultKnowledge = 5
                },
                // Madam Zostra
                new DefaultCharacter()
                {
                    DefaultName = "Madam Zostra",
                    DefaultAge = 37,
                    DefaultBirthdate = "December 10",
                    DefaultSpeed = 3,
                    DefaultMight = 4,
                    DefaultSaniity = 4,
                    DefaultKnowledge = 4
                },
                // Darrin 'Flash' Williams
                new DefaultCharacter()
                {
                    DefaultName = "Darrin 'Flash' Williams",
                    DefaultAge = 20,
                    DefaultBirthdate = "June 6",
                    DefaultSpeed = 6,
                    DefaultMight = 3,
                    DefaultSaniity = 3,
                    DefaultKnowledge = 3
                },
                // Ox Bellows
                new DefaultCharacter()
                {
                    DefaultName = "Ox Bellows",
                    DefaultAge = 20,
                    DefaultBirthdate = "June 6",
                    DefaultSpeed = 4,
                    DefaultMight = 5,
                    DefaultSaniity = 3,
                    DefaultKnowledge = 3
                },
                // Peter Akimoto
                new DefaultCharacter()
                {
                    DefaultName = "Peter Akimoto",
                    DefaultAge = 13,
                    DefaultBirthdate = "September 3",
                    DefaultSpeed = 4,
                    DefaultMight = 3,
                    DefaultSaniity = 4,
                    DefaultKnowledge = 4
                },
                // Brandon Jaspers
                new DefaultCharacter()
                {
                    DefaultName = "Brandon Jaspers",
                    DefaultAge = 12,
                    DefaultBirthdate = "May 12",
                    DefaultSpeed = 4,
                    DefaultMight = 4,
                    DefaultSaniity = 4,
                    DefaultKnowledge = 3
                },
                // Father Rhinehart
                new DefaultCharacter()
                {
                    DefaultName = "Father Rhinehart",
                    DefaultAge = 62,
                    DefaultBirthdate = "April 29",
                    DefaultSpeed = 3,
                    DefaultMight = 2,
                    DefaultSaniity = 6,
                    DefaultKnowledge = 4
                },
                // Professor Longfellow
                new DefaultCharacter()
                {
                    DefaultName = "Professor Longfellow",
                    DefaultAge = 57,
                    DefaultBirthdate = "July 27",
                    DefaultSpeed = 4,
                    DefaultMight = 3,
                    DefaultSaniity = 3,
                    DefaultKnowledge = 5
                }
            };
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

        private DefaultCharacter _selectedCharacter;
        /// <summary>
        /// Stores the players "base" character. (Deterines base and valid increments.
        /// </summary>
        public DefaultCharacter SelectedCharacter
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

        private List<DefaultCharacter> _defaultCharacters;
        /// <summary>
        /// Stores all valid Characters to serve as a base.
        /// </summary>
        public List<DefaultCharacter> DefaultCharacters
        {
            get => _defaultCharacters;
            set
            {
                if (value != _defaultCharacters)
                {
                    this._defaultCharacters = value;
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
