using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BetrayalApp.DesignData.Models
{
    public class DefaultCharacter : INotifyPropertyChanged
    {
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

        private int _defaultAge;
        /// <summary>
        /// Stores the characters age
        /// </summary>
        public int DefaultAge
        {
            get => _defaultAge;
            set
            {
                if (value != _defaultAge)
                {
                    this._defaultAge = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _defaultBirthdate;
        /// <summary>
        /// Stores the characters birthdate.
        /// </summary>
        public string DefaultBirthdate
        {
            get => _defaultBirthdate;
            set
            {
                if (value != _defaultBirthdate)
                {
                    this._defaultBirthdate = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private string _defaultName;
        /// <summary>
        /// Stores the characters name (Joe, Daymian, etc.)
        /// </summary>
        public string DefaultName
        {
            get => _defaultName;
            set
            {
                if (value != _defaultName)
                {
                    this._defaultName = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _defaultMight;
        /// <summary>
        /// Stores the characters might value (1-10)
        /// </summary>
        public int DefaultMight
        {
            get => _defaultMight;
            set
            {
                if (value != _defaultMight)
                {
                    this._defaultMight = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _defaultSpeed;
        /// <summary>
        /// Stores the characters speed value (1-10)
        /// </summary>
        public int DefaultSpeed
        {
            get => _defaultSpeed;
            set
            {
                if (value != _defaultSpeed)
                {
                    this._defaultSpeed = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _defaultSanity;
        /// <summary>
        /// Stores the characters sanity value (1-10)
        /// </summary>
        public int DefaultSaniity
        {
            get => _defaultSanity;
            set
            {
                if (value != _defaultSanity)
                {
                    this._defaultSanity = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private int _defaultKnowledge;
        /// <summary>
        /// Stores the characters knowledge value (1-10)
        /// </summary>
        public int DefaultKnowledge
        {
            get => _defaultKnowledge;
            set
            {
                if (value != _defaultKnowledge)
                {
                    this._defaultKnowledge = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<int> _mightIncrements;
        /// <summary>
        /// Stores the valid increments for this characters might values.
        /// </summary>
        public List<int> MightIncrements
        {
            get => _mightIncrements;
            set
            {
                if (value != _mightIncrements)
                {
                    _mightIncrements = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<int> _speedIncrements;
        /// <summary>
        /// Stores the valid increments for this characters speed values.
        /// </summary>
        public List<int> SpeedIncrements
        {
            get => _speedIncrements;
            set
            {
                if (value != _speedIncrements)
                {
                    _speedIncrements = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<int> _knowledgeIncrements;
        /// <summary>
        /// Stores the valid increments for this characters knowledge values.
        /// </summary>
        public List<int> KnowledgeIncrements
        {
            get => _knowledgeIncrements;
            set
            {
                if (value != _knowledgeIncrements)
                {
                    _knowledgeIncrements = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private List<int> _sanityIncrements;
        /// <summary>
        /// Stores the valid increments for this characters Sanity values.
        /// </summary>
        public List<int> SanityIncrements
        {
            get => _sanityIncrements;
            set
            {
                if (value != _sanityIncrements)
                {
                    _sanityIncrements = value;
                    NotifyPropertyChanged();
                }
            }
        }

        #endregion // End of Member Properties
    }

}
