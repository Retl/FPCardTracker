using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPCardTracker
{
    class CardSelector
    {
        static int frameNum = 0;
        static int frameLast = 12;

        private static List<Image> images = new List<Image>();

        public static int FrameNum { get => frameNum; set => frameNum = value; }
        public static int FrameLast { get => frameLast; set => frameLast = value; }
        public static List<Image> Images { get => images; set => images = value; }

        // Image image = Image.FromFile(".\\img\\");

        public static void LoadImages()
        {
            string basePath = ".\\img\\Card_";
            string ext = ".png";
            for (int i = 0; i < FrameLast; i++) {
                Images.Add(Image.FromFile(basePath + "Selector_" + (i + 1).ToString("00") + ext)); // These frame indexes are one less than the filename.
            }
        }

        public static void UpdateCardSelector() {
            FrameNum++;
            if (FrameNum >= FrameLast) { FrameNum = 0; }
        }

        public static void DrawSelector(PaintEventArgs e, CardStatus cardStatus) {
            e.Graphics.DrawImage(images[FrameNum], new Point(cardStatus.Left - 1, cardStatus.Top - 1));
        }
    }
}
