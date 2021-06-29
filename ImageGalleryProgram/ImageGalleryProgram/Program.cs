using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageGalleryProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Gmail _mailAccount = new Gmail();
            ImageGallery _imageGallery = new ImageGallery(_mailAccount);
            _imageGallery.Share();

            Bluetooth _blueToothDevice = new Bluetooth();
            ImageGallery _bluetoothGallery = new ImageGallery(_blueToothDevice);
            _bluetoothGallery.Share();

            Whatsapp _messanger = new Whatsapp();
            ImageGallery _whatsappGallery = new ImageGallery(_messanger);
            _whatsappGallery.Share();
            Console.ReadLine();
        }
    }
}
