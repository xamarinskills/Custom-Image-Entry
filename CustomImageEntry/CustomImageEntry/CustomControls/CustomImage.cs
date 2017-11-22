using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomImageEntry.CustomControls
{
   public class CustomImage:Image
    {
        public event EventHandler ImageClicked;
        public CustomImage()
        {
            var tgr = new TapGestureRecognizer { NumberOfTapsRequired = 1 };
            tgr.Tapped += ImageOn_Clicked;
            this.GestureRecognizers.Add(tgr);
        }
        public virtual void ImageOn_Clicked(object sender, EventArgs e)
        {
            ImageClicked?.Invoke(sender, e);
        }
    }
}
