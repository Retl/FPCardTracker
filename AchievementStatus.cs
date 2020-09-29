using FPCardTracker;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPCardTracker
{
    class AchievementStatus
    {
        private static int maxAchievementCount = 56;

        private int left = 0;
        private int top = 0;

        private bool collected = false;

        int frameNum = 0;
        int fakeFrameNum = 0;
        static int frameLast = 63;
        static int frameLastWithWait = 63;

        ACHIEVEMENT_ID achievementId = ACHIEVEMENT_ID.NOTHING;

        private static List<Image> images = new List<Image>();
        private static List<Image> imagesMissing = new List<Image>();
        private static List<AchievementStatus> achievements = new List<AchievementStatus>();

        public int FrameNum { get => frameNum; set => frameNum = value; }
        public static int FrameLast { get => frameLast; set => frameLast = value; }
        public static List<Image> Images { get => images; set => images = value; }
        public static List<Image> ImagesMissing { get => imagesMissing; set => imagesMissing = value; }



        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }
        public bool Collected { get => collected; set => collected = value; }
        public static int MaxAchievementCount { get => maxAchievementCount; set => maxAchievementCount = value; }
        public static int FrameLastWithWait { get => frameLastWithWait; set => frameLastWithWait = value; }
        public int FakeFrameNum { get => fakeFrameNum; set => fakeFrameNum = value; }
        internal static List<AchievementStatus> Achievements { get => achievements; set => achievements = value; }
        public ACHIEVEMENT_ID AchievementId { get => achievementId; set => achievementId = value; }

        public static List<AchievementStatus> GenerateAchievements()
        {
            // AchievementOnlyScreenSize: 254, 359
            int anchorLeft = 0;
            int anchorTop = 300;
            int achievementsPerRow = 8;
            int achievementSpacingHorizontal = 40;
            int achievementSpacingVertical = 40;

            List<AchievementStatus> achievements = new List<AchievementStatus>();

            for (int i = 0; i < MaxAchievementCount; i++)
            {
                AchievementStatus acs = new AchievementStatus();
                achievements.Add(acs);


                achievements[i].Left = anchorLeft + (achievementSpacingHorizontal * (i % achievementsPerRow));
                achievements[i].Top = anchorTop + (achievementSpacingVertical * (i / achievementsPerRow));
                achievements[i].FakeFrameNum = ((FrameLastWithWait - i) % FrameLastWithWait);
                achievements[i].FrameNum = ((FrameLastWithWait - i) % FrameLastWithWait);
                achievements[i].AchievementId = (ACHIEVEMENT_ID)i;

                if (achievements[i].FakeFrameNum > FrameLast)
                {
                    achievements[i].FrameNum = 1;
                }

                //pbAchievements[i].Left = anchorLeft + (achievementSpacingHorizontal * (i % achievementsPerRow));

            }

            return achievements;

        }

        public static void LoadImages()
        {
            string basePath = ".\\img\\Achievement_";
            string ext = ".png";
            //images.Add(Image.FromFile(basePath + "Missing" + ext));
            for (int i = 0; i < FrameLast; i++)
            {
                Images.Add(Image.FromFile(basePath + (i + 2).ToString("00") + ext)); // Unlike AchievementSelector, these indexes match the filename.
            }
            for (int i = 0; i < FrameLast; i++)
            {
                ImagesMissing.Add(Image.FromFile(basePath + "Locked_" + (i + 2).ToString("00") + ext)); // Unlike AchievementSelector, these indexes match the filename.
            }
        }

        public static void UpdateAchievements()
        {
            /*foreach (AchievementStatus achievement in achievements)
            {
                achievement.FrameNum++;
                achievement.FakeFrameNum++;

                if (achievement.FakeFrameNum > FrameLast)
                {
                    achievement.FrameNum = 1;
                }

                if (achievement.FakeFrameNum > FrameLastWithWait)
                {
                    achievement.FakeFrameNum = 1;
                }
            }*/

        }

        internal void SetCollected(int yesOrNo)
        {
            if (yesOrNo > 0)
            {
                Collected = true;
            }
            else
            {
                Collected = false;
            }
        }

        public static void DrawAchievement(PaintEventArgs e, AchievementStatus achievementStatus)
        {
            if (!achievementStatus.collected)
            {
                e.Graphics.DrawImage(ImagesMissing[(int)(achievementStatus.AchievementId)], new Point(achievementStatus.Left, achievementStatus.Top));
            }
            else
            {
                e.Graphics.DrawImage(images[(int)(achievementStatus.AchievementId)], new Point(achievementStatus.Left, achievementStatus.Top));
            }
        }
    }
}
