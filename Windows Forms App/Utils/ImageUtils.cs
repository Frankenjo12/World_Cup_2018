using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows_Forms_App.Utils
{
    public class ImageUtils
    {
        private ImageUtils() { }

        public static void SetImage(PictureBox pbPlayer, string path)
        {
            try
            {
                pbPlayer.Image?.Dispose();
                pbPlayer.Image = Image.FromFile(path);
                pbPlayer.SizeMode = PictureBoxSizeMode.StretchImage;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
