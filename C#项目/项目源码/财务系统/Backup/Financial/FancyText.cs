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
        /// �ı���Ӱ���(����)
        /// </summary>
        private const int blurAmount = 5;

        /// <summary>
        ///���ı��õ�һ��ͼƬ,��ͼƬ��ʾ�˴��й��ε��ı�
        /// </summary>
        /// <param name="strText">�ı�</param>
        /// <param name="fnt">�ı�����</param>
        /// <param name="clrFore">����ǰ��ɫ</param>
        /// <param name="clrBack">���屳��ɫ</param>
        /// <returns>������ɫ�����ͼƬ,����͸��</returns>
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

                        //��Ӱ����
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
