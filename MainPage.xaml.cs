using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Input;
using Microsoft.Phone.Controls;

namespace Hompus.PullDownToRefreshDemo
{
    public partial class MainPage : PhoneApplicationPage
    {
        public List<string> Images
        {
            get; 
            set;
        }

        public MainPage()
        {
            InitializeComponent();

            this.Images = new List<string>()
            {
                "http://dummyimage.com/480/F/00/.jpg?text=A",
                "http://dummyimage.com/480/D/00/.jpg?text=B",
                "http://dummyimage.com/480/E/00/.jpg?text=C",
                "http://dummyimage.com/480/C/00/.jpg?text=D",
                "http://dummyimage.com/480/A/00/.jpg?text=E",
                "http://dummyimage.com/480/B/00/.jpg?text=F",
                "http://dummyimage.com/480/8/00/.jpg?text=G",
                "http://dummyimage.com/480/9/00/.jpg?text=H",
                "http://dummyimage.com/480/6/FF/.jpg?text=I",
                "http://dummyimage.com/480/7/FF/.jpg?text=J",
                "http://dummyimage.com/480/4/FF/.jpg?text=K",
                "http://dummyimage.com/480/5/FF/.jpg?text=L",
                "http://dummyimage.com/480/2/FF/.jpg?text=M",
                "http://dummyimage.com/480/3/FF/.jpg?text=N",
                "http://dummyimage.com/480/00/FF/.jpg?text=O",
                "http://dummyimage.com/480/1/FF/.jpg?text=P",
                "http://dummyimage.com/480/F/00/.jpg?text=Q",
                "http://dummyimage.com/480/D/00/.jpg?text=R",
                "http://dummyimage.com/480/E/00/.jpg?text=S",
                "http://dummyimage.com/480/C/00/.jpg?text=T",
                "http://dummyimage.com/480/A/00/.jpg?text=U",
                "http://dummyimage.com/480/B/00/.jpg?text=V",
                "http://dummyimage.com/480/8/00/.jpg?text=W",
                "http://dummyimage.com/480/9/00/.jpg?text=X",
                "http://dummyimage.com/480/6/FF/.jpg?text=Y",
                "http://dummyimage.com/480/7/FF/.jpg?text=Z"
            };
        }
        
        private void refreshPanelRefreshRequested(object sender, EventArgs e)
        {
            MessageBox.Show("Refresh triggered");
        }

        private void ImageOnTap(object sender, GestureEventArgs e)
        {
            NavigationService.Navigate(new Uri("/DetailPage.xaml", UriKind.Relative));
        }
    }
}