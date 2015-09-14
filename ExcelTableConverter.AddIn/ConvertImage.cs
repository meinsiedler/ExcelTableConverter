using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using stdole;

namespace MEExcelTools
{
  public sealed class ConvertImage : System.Windows.Forms.AxHost
  {
    private ConvertImage()
      : base(null)
    {
    }

    public static IPictureDisp Convert(Image image)
    {
      return (IPictureDisp) GetIPictureDispFromPicture(image);
    }

    public static IPictureDisp GetIPictureDispImage(Bitmap bitmap)
    {
      Bitmap newIcon = bitmap;
      newIcon.MakeTransparent();
      ImageList newImageList = new ImageList();
      newImageList.Images.Add(newIcon);
      IPictureDisp tempImage = Convert(newImageList.Images[0]);

      return tempImage;
    }

  }
}
