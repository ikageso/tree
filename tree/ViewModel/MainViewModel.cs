using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Collections.ObjectModel;
using tree.Model;

namespace tree.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {
            ////if (IsInDesignMode)
            ////{
            ////    // Code runs in Blend --> create design time data.
            ////}
            ////else
            ////{
            ////    // Code runs "for real"
            ////}
        }

        private ObservableCollection<ObservableCollection<MovieFile>> _MovieFileList = null;
        /// <summary>
        /// ÉÄÅ[ÉrÅ[àÍóó
        /// </summary>
        public ObservableCollection<ObservableCollection<MovieFile>> MovieFileList
        {
            get
            {
                return _MovieFileList;
            }
        }

        private RelayCommand<string> _LoadCommand;
        /// <summary>
        /// LoadCommand
        /// </summary>
        public RelayCommand<string> LoadCommand
        {
            get
            {
                if (_LoadCommand == null)
                {
                    _LoadCommand = new RelayCommand<string>((x) =>
                    {
                        _MovieFileList = MovieFileManager.GetMovieFileList();
                        RaisePropertyChanged("MovieFileList");
                    });
                }

                return _LoadCommand;
            }
        }

        private bool _IsTile = false;
        /// <summary>
        /// IsTile
        /// </summary>
        public bool IsTile
        {
            get
            {
                return _IsTile;
            }
            set
            {
                _IsTile = value;
                RaisePropertyChanged("IsTile");
            }
        }


    }
}