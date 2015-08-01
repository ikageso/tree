using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;

namespace tree.Model
{
    public class MovieFile : INotifyPropertyChanged
    {

        private ObservableCollection<ObservableCollection<MovieFile>> _DetailFileList = null;

        /// <summary>
        /// DetailFileList
        /// </summary>
        public ObservableCollection<ObservableCollection<MovieFile>> DetailFileList
        {
            get
            {
                return _DetailFileList;
            }
            set
            {
                _DetailFileList = value;
            }
        }

        public bool IsDetail
        {
            get
            {
                return _DetailFileList == null || _DetailFileList.Count == 0 ? false : true;
            }
        }


        private string _Title;
        /// <summary>
        /// Title
        /// </summary>
        public string Title
        {
            get
            {
                return _Title;
            }
            set
            {
                _Title = value;
                RaisePropertyChanged("Title");
            }
        }


        private BitmapImage _Image;

        public BitmapImage Image
        {
            get
            {
                return _Image;
            }

            set
            {
                _Image = value;
                RaisePropertyChanged("Image");
            }
        }

        private TimeSpan _Time;
        /// <summary>
        /// Time
        /// </summary>
        public TimeSpan Time
        {
            get
            {
                return _Time;
            }
            set
            {
                _Time = value;
                RaisePropertyChanged("Time");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void RaisePropertyChanged(string name)
        {
            if (PropertyChanged == null) return;

            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

    }
}
