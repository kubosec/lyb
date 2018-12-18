using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.Collections.Generic;
using System.Text;

namespace Financial
{
    class FancyText
    {
        /// <summary>
        /// 文本阴影深度(象素)
        /// </summary>
        private const int blurAmount = 5;

        /// <summary>
        ///由文本得到一幅图片,该图片显示了带有光晕的文本
        /// </summary>
        /// <param name="strText">文本</param>
        /// <param name="fnt">文本字体</param>
        /// <param name="clrFore">字体前景色</param>
        /// <param name="clrBack">字体背景色</param>
        /// <returns>返回特色字体的图片,背景透明</returns>
        public static Image ImageFromText(string strText, Font fnt, Color clrFore, Color clrBack)
        {
            Bitmap bmpOut = null;

            using (Graphics g = Graphics.FromHwnd(IntPtr.Zero))
            {
                SizeF sz = g.MeasureString(strText, fnt);
                using (Bitmap bmp = new Bitmap((int)sz.Width, (int)sz.Height))
                using (Graphics gBmp = Graphics.FromImage(bmp))
                using (SolidBrush brBack = new SolidBrush(Color.FromArgb(16, clrBack.R, clrBack.G, clrBack.B)))
                using (SolidBrush brFore = new SolidBrush(clrFore))
                {
                    gBmp.SmoothingMode = SmoothingMode.HighQuality;
                    gBmp.InterpolationMode = InterpolationMode.HighQualityBilinear;
                    gBmp.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                    gBmp.DrawString(strText, fnt, brBack, 0, 0);

                    bmpOut = new Bitmap(bmp.Width + blurAmount, bmp.Height + blurAmount);

                    using (Graphics gBmpOut = Graphics.FromImage(bmpOut))
                    {
                        gBmpOut.SmoothingMode = SmoothingMode.HighQuality;
                        gBmpOut.InterpolationMode = InterpolationMode.HighQualityBilinear;
                        gBmpOut.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                        //阴影光晕
                        for (int x = 0; x <= blurAmount; x++)
                        {
                            for (int y = 0; y <= blurAmount; y++)
                            {
                                gBmpOut.DrawImageUnscaled(bmp, x, y);
                            }
                        }


                        gBmpOut.DrawString(strText, fnt, brFore, blurAmount / 2, blurAmount / 2);
                    }
                }
            }

            return bmpOut;
        }
    }
}
