using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;

namespace VideoClub
{
  public static  class RezieImageClass
    {
        ///<Summary>
        ///Resize the image with specified width and height
        ///</Summary>
        ///<param name = "Image"> The image to resize </param>
        ///<param name = "Width" > The width to resize to </param>
        ///<param name = "height"> The height to resize to. </param>
        public static Bitmap ResizeImage (Image image , int width , int height)
        {
            //a holder for result
            Bitmap result = new Bitmap (width,height);

            //using graphics object to draw the resized image into the bitmap

            using (Graphics graphics = Graphics.FromImage(result))
            {
                //set the resize quality modes to high
                graphics.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
                //draw the image into the target bitmap
                graphics.DrawImage(image,0,0,result.Width,result.Height);
            }
            //return the resulting bitmap
            return result;

        }
    }
}
