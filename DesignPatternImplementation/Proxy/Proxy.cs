using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternImplementation.Proxy
{
    public interface IImage
    {
        public void ShowImage(bool clicked);
    }

    public class ImageProxy : IImage
    {

        private string _imagePath;

        private IImage _proxifiedImage;

        public ImageProxy(string path)
        {
            _imagePath = path;
        }
        public void ShowImage(bool clicked)
        {
            if (clicked)
            {
                _proxifiedImage = new ActualImage(_imagePath);
                _proxifiedImage.ShowImage(true);
            }
            else
            {
                Console.WriteLine("Showing thumbnail of " + _imagePath);
            }
        }
    }

    public class ActualImage : IImage
    {
        private string _path;

        public ActualImage(string path)
        {
            _path = path;
            LoadHighResolutionImage(path);
        }

        private void LoadHighResolutionImage(string path)
        {
            Console.WriteLine("Reading large image from disk to memory of " + path);
        }
        public void ShowImage(bool clicked = true)
        {
            Console.WriteLine("Render large image of " + _path);
        }
    }
}
/*
    var image1 = new ImageProxy("sample/photo1");
    image1.ShowImage(false);

    var image2 = new ImageProxy("sample/photo2");
    image2.ShowImage(true);
*/
