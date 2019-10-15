using CommonServiceLocator;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;

namespace BetrayalApp.ViewModels
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);

            // Registering all of the ViewModels
            SimpleIoc.Default.Register<MainViewModel>();
            SimpleIoc.Default.Register<EditViewModel>();
            SimpleIoc.Default.Register<AddViewModel>();
            SimpleIoc.Default.Register<OverviewViewModel>();

        }

        public MainViewModel MainViewModel
        {
            get => ServiceLocator.Current.GetInstance<MainViewModel>();
        }
        public EditViewModel EditViewModel
        {
            get => ServiceLocator.Current.GetInstance<EditViewModel>();
        }
        public AddViewModel AddViewModel
        {
            get => ServiceLocator.Current.GetInstance<AddViewModel>();
        }
        public OverviewViewModel OverviewViewModel
        {
            get => ServiceLocator.Current.GetInstance<OverviewViewModel>();
        }

        public static void Cleanup()
        {
            
        }
    }
}