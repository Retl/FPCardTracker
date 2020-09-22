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
    class CardStatus
    {
        private static int maxCardCount = 100;
        
        private int left = 0;
        private int top = 0;

        private bool collected = false;

        int frameNum = 0;
        int fakeFrameNum = 0;
        static int frameLast = 11;
        static int frameLastWithWait = 11 + 120;

        private static List<Image> images = new List<Image>();
        private static List<CardStatus> cards = new List<CardStatus>();

        public int FrameNum { get => frameNum; set => frameNum = value; }
        public static int FrameLast { get => frameLast; set => frameLast = value; }
        public static List<Image> Images { get => images; set => images = value; }



        public int Left { get => left; set => left = value; }
        public int Top { get => top; set => top = value; }
        public bool Collected { get => collected; set => collected = value; }
        public static int MaxCardCount { get => maxCardCount; set => maxCardCount = value; }
        public static int FrameLastWithWait { get => frameLastWithWait; set => frameLastWithWait = value; }
        public int FakeFrameNum { get => fakeFrameNum; set => fakeFrameNum = value; }
        internal static List<CardStatus> Cards { get => cards; set => cards = value; }

        public static List<CardStatus> GenerateCards() 
        {
            int anchorLeft = 0;
            int anchorTop = 0;
            int cardsPerRow = 10;
            int cardSpacingHorizontal = 24;
            int cardSpacingVertical = 30;

            List<CardStatus> cards = new List<CardStatus>();

            for (int i = 0; i < MaxCardCount; i++)
            {
                CardStatus cs = new CardStatus();
                cards.Add(cs);

                cards[i].Left = anchorLeft + (cardSpacingHorizontal * (i % 10));
                cards[i].Top = anchorTop + (cardSpacingVertical * (i / cardsPerRow));
                cards[i].FakeFrameNum = (i % FrameLastWithWait);
                cards[i].FrameNum = (i % FrameLastWithWait);

                if (cards[i].FakeFrameNum > FrameLast)
                {
                    cards[i].FrameNum = 1;
                }

                //pbCards[i].Left = anchorLeft + (cardSpacingHorizontal * (i % cardsPerRow));

            }

            return cards;

        }

        public static void LoadImages() {
            string basePath = ".\\img\\Card_";
            string ext = ".png";
            images.Add(Image.FromFile(basePath + "Missing" + ext));
            for (int i = 0; i < FrameLast; i++)
            {
                Images.Add(Image.FromFile(basePath + (i + 1).ToString("00") + ext)); // Unlike CardSelector, these indexes match the filename.
            }
        }

        public static void UpdateCards()
        {
            foreach (CardStatus card in cards)
            {
                card.FrameNum++;
                card.FakeFrameNum++;

                if (card.FakeFrameNum > FrameLast)
                {
                    card.FrameNum = 1;
                }

                if (card.FakeFrameNum > FrameLastWithWait)
                {
                    card.FakeFrameNum = 1;
                }
            }

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

        public static void DrawCard(PaintEventArgs e, CardStatus cardStatus)
        {
            if (!cardStatus.collected)
            {
                e.Graphics.DrawImage(images[0], new Point(cardStatus.Left, cardStatus.Top));
            }
            else 
            {
                e.Graphics.DrawImage(images[cardStatus.FrameNum], new Point(cardStatus.Left, cardStatus.Top));
            }
        }
    }
}
