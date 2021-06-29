using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class ImageGallery
    {
        IGallery galary;
        public ImageGallery(IGallery image)
        {
            this.galary = image;
        }
        public void Share()
        {
            galary.Send();
        }
    }
}
