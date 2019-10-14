using BetrayalApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.Generic;
using System.Windows.Input;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// AddViewModel (VM for AddView.xaml)
    /// <para>Each </para>
    /// </summary>
    public class AddViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the EditViewModel class.
        /// <para>The ViewModels current properties get saved to the NewCharacters values when the user clicks <see cref="SavePlayerCommand"/></para>
        /// </summary>
        public AddViewModel()
        {
            // Populating list of default characters for player to choose from.
            AllBaseCharacters = new List<DefaultCharacter>
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
                    DefaultKnowledge = 5,
                    SpeedIncrements = new List<int>
                    {
                        3, 3, 4, 5, 6, 6, 7, 8
                    },
                    MightIncrements = new List<int>
                    {
                        3, 3, 3, 4, 5, 6, 7, 8
                    },
                    SanityIncrements = new List<int>
                    {
                        3, 3, 3, 4, 5, 6, 6, 6
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 6, 7, 8
                    }
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
                    DefaultKnowledge = 3,
                    SpeedIncrements = new List<int>
                    {
                        2, 3, 4, 4, 4, 5, 6, 8
                    },
                    MightIncrements = new List<int>
                    {
                        3, 4, 4, 4, 4, 5, 6, 8
                    },
                    SanityIncrements = new List<int>
                    {
                        1, 1, 2, 4, 4, 4, 5, 6
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        2, 3, 3, 4, 4, 5, 6, 8
                    }
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
                    DefaultKnowledge = 5,
                    SpeedIncrements = new List<int>
                    {
                        3, 4, 4, 4, 4, 6, 7, 8
                    },
                    MightIncrements = new List<int>
                    {
                        2, 2, 2, 4, 4, 5, 6, 6
                    },
                    SanityIncrements = new List<int>
                    {
                        4, 4, 4, 5, 6, 7, 8, 8
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        4, 5, 5, 5, 5, 6, 6, 7
                    }
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
                    DefaultKnowledge = 4,
                    SpeedIncrements = new List<int>
                    {
                        2, 3, 3, 5, 5, 6, 6, 7
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 5, 5, 6
                    },
                    SanityIncrements = new List<int>
                    {
                        4, 4, 4, 5, 6, 7, 8, 8
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        1, 3, 4, 4, 4, 5, 6, 6
                    }
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
                    DefaultKnowledge = 3,
                    SpeedIncrements = new List<int>
                    {
                        4, 4, 4, 5, 6, 7, 7, 8
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 6, 6, 7
                    },
                    SanityIncrements = new List<int>
                    {
                        1, 2, 3, 4, 5, 5, 5, 7
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 5, 5, 7
                    }
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
                    DefaultKnowledge = 3,
                    SpeedIncrements = new List<int>
                    {
                        2, 2, 2, 3, 4, 5, 5, 6
                    },
                    MightIncrements = new List<int>
                    {
                        4, 5, 5, 6, 6, 7, 8, 8
                    },
                    SanityIncrements = new List<int>
                    {
                        2, 2, 3, 4, 5, 5, 6, 7
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        2, 2, 3, 3, 5, 5, 6, 6
                    }
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
                    DefaultKnowledge = 4,
                    SpeedIncrements = new List<int>
                    {
                        3, 3, 3, 4, 6, 6, 7, 7
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 5 6, 8
                    },
                    SanityIncrements = new List<int>
                    {
                        3, 4, 4, 4, 5, 6, 6, 7
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        3, 4, 4, 5, 6 , 7, 7, 8
                    }
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
                    DefaultKnowledge = 3,
                    SpeedIncrements = new List<int>
                    {
                        3, 4, 4, 4, 5, 6, 7, 8
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 6, 6, 7
                    },
                    SanityIncrements = new List<int>
                    {
                        3, 3, 3, 4, 5, 6, 7, 8
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        1, 3, 3, 5, 5, 6 , 6, 7
                    }
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
                    DefaultKnowledge = 4,
                    SpeedIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 6, 7, 7
                    },
                    MightIncrements = new List<int>
                    {
                        1, 2, 2, 4, 4, 5, 5, 7
                    },
                    SanityIncrements = new List<int>
                    {
                        3, 4, 5, 5, 6, 7, 7, 8
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        1, 3, 3, 4, 5, 6, 6, 8
                    }
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
                    DefaultKnowledge = 5,
                    SpeedIncrements = new List<int>
                    {
                        2, 2, 4, 4, 5, 5, 6, 6
                    },
                    MightIncrements = new List<int>
                    {
                        1, 2, 3, 4, 5, 5, 6, 6
                    },
                    SanityIncrements = new List<int>
                    {
                        1, 3, 3, 4, 5, 5, 6, 7
                    },
                    KnowledgeIncrements = new List<int>
                    {
                        4, 5, 5, 5, 5, 6, 7, 8
                    }
                }
            };
        }

        #region Member Properties

        private DefaultCharacter _selectedBaseCharacter;
        /// <summary>
        /// Stores currently selected base character.
        /// </summary>
        public DefaultCharacter SelectedBaseCharacter
        {
            get => _selectedBaseCharacter;
            set => Set(ref _selectedBaseCharacter, value);
        }

        private List<DefaultCharacter> _allBaseCharacters;
        /// <summary>
        /// Stores all base characters.
        /// </summary>
        public List<DefaultCharacter> AllBaseCharacters
        {
            get => _allBaseCharacters;
            set => Set(ref _allBaseCharacters, value);
        }

        private PlayerCharacter _newCharacter;
        /// <summary>
        /// Stores the currently selected character within the ListBox.
        /// </summary>
        public PlayerCharacter NewCharacter
        {
            get => _newCharacter;
            set => Set(ref _newCharacter, value);
        }

        #endregion // End of Member Properties 

        #region Commands

        /// <summary>
        /// This command calls the SavePlayer Method to save new information.
        /// </summary>
        public ICommand SavePlayerCommand => new RelayCommand(() =>
        {

        });

        #endregion // End of Commands
    }
}