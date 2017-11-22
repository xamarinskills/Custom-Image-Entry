using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomImageEntry
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void ImageEntry_LeftImageClicked(object sender, EventArgs e)
        {
            DefaultEntry.Text = "Working Left Image Entry Clicked";
        }

        private void ImageEntry_RightImageClicked(object sender, EventArgs e)
        {
            DefaultEntry.Text = "Working Right Image Entry Clicked";
        }

        private void ImageEntry_LeftImageClicked_1(object sender, EventArgs e)
        {
            DefaultEntry.Text = "Working Both Entry Clicked ";
        }

        private void ImageEntry_RightImageClicked_1(object sender, EventArgs e)
        {
            DefaultEntry.Text = "Working Both Both Entry Clicked";
        }
    }
}
