using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPCardTracker
{
    class LevelStatus
    {
        string levelName = "?????";
        static int frameNum = 0;
        static int frameLast = 15;

        private static List<Image> images = new List<Image>();

        public static int FrameNum { get => frameNum; set => frameNum = value; }
        public static int FrameLast { get => frameLast; set => frameLast = value; }
        public static List<Image> Images { get => images; set => images = value; }

        public static void LoadImages()
        {
            string basePath = ".\\img\\Stage_Icon_";
            string ext = ".png";
            for (int i = 1; i < FrameLast; i++)
            {
                Images.Add(Image.FromFile(basePath + i.ToString("00") + ext));
            }
        }
    }
}
