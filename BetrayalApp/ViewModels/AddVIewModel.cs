using BetrayalApp.Models;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System;
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
        private MainViewModel MVMInstance = CommonServiceLocator.ServiceLocator.Current.GetInstance<MainViewModel>();

        /// <summary>
        /// Initializes a new instance of the EditViewModel class.
        /// <para>The ViewModels current properties get saved to the NewCharacters values when the user clicks <see cref="SavePlayerCommand"/></para>
        /// </summary>
        public AddViewModel()
        {
            // Populating the possible list of characters the user can choose from.
            AllBaseCharacters = PopulateBaseCharacters();
            NewCharacter = new PlayerCharacter();
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

        #endregion

        #region Commands

        /// <summary>
        /// This command calls the <see cref="SaveNewPlayer"/> Method to save new information.
        /// </summary>
        public ICommand SavePlayerCommand => new RelayCommand(() =>
        {
            SaveNewPlayer();
        });

        #endregion // End of Commands

        /// <summary>
        /// This method is responsible for returning a list of all BaseCharacters (Chars that came with the game)
        /// </summary>
        /// <returns></returns>
        private List<DefaultCharacter> PopulateBaseCharacters()
        {
            // Populating list of default characters for player to choose from.
            var allBaseChars = new List<DefaultCharacter>
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
                    DefaultSpeedIndex = 3,
                    DefaultMightIndex = 4,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 4,
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
                    DefaultSpeedIndex = 4,
                    DefaultMightIndex = 4,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 3,
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
                    DefaultSpeedIndex = 3,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 5,
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
                    DefaultSpeedIndex = 4,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 5,
                    DefaultKnowledgeIndex = 3,
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
                    DefaultSpeedIndex = 4,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 4,
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
                    DefaultSpeedIndex = 3,
                    DefaultMightIndex = 4,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 4,
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
                    DefaultSpeedIndex = 5,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 3,
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
                    DefaultSpeedIndex = 5,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 3,
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
                    DefaultSpeedIndex = 4,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 4,
                    DefaultKnowledgeIndex = 3,
                    SpeedIncrements = new List<int>
                    {
                        3, 3, 3, 4, 6, 6, 7, 7
                    },
                    MightIncrements = new List<int>
                    {
                        2, 3, 3, 4, 5, 5, 6, 8
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
                    DefaultSpeedIndex = 3,
                    DefaultMightIndex = 4,
                    DefaultSanityIndex = 4,
                    DefaultKnowledgeIndex = 3,
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
                    DefaultSpeedIndex = 3,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 5,
                    DefaultKnowledgeIndex = 4,
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
                    DefaultSpeedIndex = 4,
                    DefaultMightIndex = 3,
                    DefaultSanityIndex = 3,
                    DefaultKnowledgeIndex = 5,
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

            return allBaseChars;
        }

        /// <summary>
        /// This method adds the <see cref="NewCharacter"/> to <see cref="MainViewModel.AllCharacters"/>'s list of AllCharacters.
        /// </summary>
        private void SaveNewPlayer()
        {
            // Setting Players Current Values equal to their chosen characters base values
            NewCharacter.Speed = SelectedBaseCharacter.DefaultSpeed;
            NewCharacter.Might = SelectedBaseCharacter.DefaultMight;
            NewCharacter.Sanity = SelectedBaseCharacter.DefaultSpeed;
            NewCharacter.Knowledge = SelectedBaseCharacter.DefaultKnowledge;

            // Setting Default Indexes
            NewCharacter.CurrentSpeedIndex = SelectedBaseCharacter.DefaultSpeedIndex;
            NewCharacter.CurrentMightIndex = SelectedBaseCharacter.DefaultMightIndex;
            NewCharacter.CurrentSanityIndex = SelectedBaseCharacter.DefaultSanityIndex;
            NewCharacter.CurrentKnowledgeIndex = SelectedBaseCharacter.DefaultKnowledgeIndex;

            // Setting this property in case we decide to use the Base Characters stats in the future
            NewCharacter.SelectedBaseCharacter = SelectedBaseCharacter;

            // Adding the new player to the list of players stored in MainViewModel
            MVMInstance.AllCharacters.Add(NewCharacter);

            // Setting this to true since we can guarantee there is at least one character
            // NOTE: This property is what we use to allow the user to click the "Overview" button
            MVMInstance.AtLeastOneCharacter = true;
            
            // Clearing the VM to cleanup the UI
            MVMInstance.AddVMInstance = null;

            MessengerInstance.Unregister(this);
        }

    }

}