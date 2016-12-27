using System.Drawing;
using System.Windows.Forms;
using stdole;

namespace ExcelTableConverter.AddIn
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
      ImageList newImageList = new ImageList();
      newImageList.Images.Add(newIcon);
      IPictureDisp tempImage = Convert(newImageList.Images[0]);

      return tempImage;
    }

  }
}
