using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace tree.Model
{
    public class MovieFileManager
    {
        public static ObservableCollection<ObservableCollection<MovieFile>> GetMovieFileList()
        {
            var movieFileList = new ObservableCollection<ObservableCollection<MovieFile>>();

            var makeImageFunc = new Func<string, BitmapImage>((file) =>
            {
                BitmapImage bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.UriSource = new Uri(System.IO.Path.GetFullPath(file));
                bitmapImage.EndInit();

                return bitmapImage;
            });

            for (int i = 0; i < 5; i++)
            {
                var data =
                    new ObservableCollection<MovieFile>() {
                        new MovieFile()
                        {
                            Title = i.ToString(),
                            Time = new TimeSpan(0,0,10),
                            Image = makeImageFunc(@"DummyData\1.jpg"),
                        }
                    };

                if (i == 2)
                {
                    data.First().DetailFileList = new ObservableCollection<ObservableCollection<MovieFile>>()
                            {
                                new ObservableCollection<MovieFile>() {
                                    new MovieFile()
                                    {
                                        Title = i.ToString() + "1",
                                        Time = new TimeSpan(0,0,10),
                                        Image = makeImageFunc(@"DummyData\1.jpg"),
                                        DetailFileList = new ObservableCollection<ObservableCollection<MovieFile>>()
                                        {
                                            new ObservableCollection<MovieFile>() {
                                                new MovieFile()
                                                {
                                                    Title = i.ToString() + "1",
                                                    Time = new TimeSpan(0,0,10),
                                                    Image = makeImageFunc(@"DummyData\1.jpg"),
                                                },
                                            },
                                            new ObservableCollection<MovieFile>() {
                                                new MovieFile()
                                                {
                                                    Title = i.ToString() + "2",
                                                    Time = new TimeSpan(0,0,10),
                                                    Image = makeImageFunc(@"DummyData\1.jpg"),
                                                },
                                            },
                                            new ObservableCollection<MovieFile>() {
                                                new MovieFile()
                                                {
                                                    Title = i.ToString() + "3",
                                                    Time = new TimeSpan(0,0,10),
                                                    Image = makeImageFunc(@"DummyData\1.jpg"),
                                                },
                                            },

                                        },
                                    },
                                },
                                new ObservableCollection<MovieFile>() {
                                    new MovieFile()
                                    {
                                        Title = i.ToString() + "2",
                                        Time = new TimeSpan(0,0,10),
                                        Image = makeImageFunc(@"DummyData\1.jpg"),
                                    },
                                },
                                new ObservableCollection<MovieFile>() {
                                    new MovieFile()
                                    {
                                        Title = i.ToString() + "3",
                                        Time = new TimeSpan(0,0,10),
                                        Image = makeImageFunc(@"DummyData\1.jpg"),
                                    },
                                },
                            };
                }

            movieFileList.Add(data);
            }

            return movieFileList;
        }
    }
}
