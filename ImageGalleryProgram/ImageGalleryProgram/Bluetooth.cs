using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    public class Bluetooth: IGallery
    {
        public void Send()
        {
            Console.WriteLine("Image sent through Bluetooth");
        }
    }
}
