using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FPCardTracker
{
    public partial class frmFPCardTracker : Form
    {
        LiveSplitState state;
        ASLComponent aslComponent;
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush magentaBrush = new SolidBrush(Color.Magenta);
        List<int> cardsInRoom = new List<int>();
        List<int> achievementsInRoom = new List<int>();

        public frmFPCardTracker()
        {
            InitializeComponent();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            state = new LiveSplitState();
            aslComponent = new ASLComponent(state);
            //this.Controls.Add(aslComponent.GetSettingsControl(new LayoutMode()));

            CardStatus.LoadImages();
            CardSelector.LoadImages();
            LevelStatus.LoadImages();

            AchievementStatus.LoadImages();
            AchievementSelector.LoadImages();

            CardStatus.Cards = CardStatus.GenerateCards();
            AchievementStatus.Achievements = AchievementStatus.GenerateAchievements();
            RoomStatus.InitializeRoomToCardMap();
            RoomStatus.InitializeRoomToAchievementMap();
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            pbCardStatus.Invalidate();
            CardStatus.UpdateCards();
            CardSelector.UpdateCardSelector();

            //dynamic vars = aslComponent.Script.Vars;
            if (aslComponent.Script != null && aslComponent.Script.State != null) {
                ExpandoObject vars = aslComponent.Script.Vars;
                if (vars != null)
                {
                    lblDebug.Text = "Vars populated: ";

                    try
                    {
                        dynamic current;
                        dynamic old;
                        current = aslComponent.Script.State.Data;
                        old = aslComponent.Script.OldState.Data;
                        if (current.roomID != null)
                        {
                            int roomID = current.roomID;
                            int oldRoomID = old.roomID;
                            lblDebug.Text += "Room ID: " + roomID.ToString();
                            if (roomID != oldRoomID) {
                                Console.WriteLine("Room ID: " + roomID.ToString());
                            }
                            UpdateCardsInRoom(roomID);
                            UpdateAchievementsInRoom(roomID);


                            UpdateCardsCollected((IDictionary<String, object>)current);
                            UpdateAchievementsCollected((IDictionary<String, object>)current);
                        }
                    }
                    catch (Exception ex) {
                        // Maybe actually handle this for reals later.
                        Console.WriteLine(ex.Message);
                    }
                     
                    
                }
                else
                {
                    lblDebug.Text = "Waiting on Vars to populate.";
                }
            }
        }

        private void pbCardStatus_Paint(object sender, PaintEventArgs e)
        {
            //e.Graphics.FillRectangle(blackBrush, 0, 0, 320, 320);

            for (int i = 0; i < CardStatus.Cards.Count; i++) {
                CardStatus.DrawCard(e, CardStatus.Cards[i]);
            }

            foreach (int cardID in cardsInRoom) {
                CardSelector.DrawSelector(e, CardStatus.Cards[cardID - 1]);
            }

            for (int i = 0; i < AchievementStatus.Achievements.Count; i++)
            {
                AchievementStatus.DrawAchievement(e, AchievementStatus.Achievements[i]);
            }

            foreach (int achievementID in cardsInRoom)
            {
                AchievementSelector.DrawSelector(e, AchievementStatus.Achievements[achievementID - 1]);
            }
        }

        private void UpdateCardsInRoom(int roomID) 
        {
            cardsInRoom = RoomStatus.GetCardsInRoom(roomID);
        }

        private void UpdateAchievementsInRoom(int roomID)
        {
            achievementsInRoom = RoomStatus.GetAchievementsInRoom(roomID);
        }

        private void UpdateCardsCollected(IDictionary<String, object> current) 
        {
            for (int i = 0; i < CardStatus.Cards.Count; i++) 
            {
                CardStatus.Cards[i].SetCollected((int)(current["card" + (i + 1)]));
            }
        }

        private void UpdateAchievementsCollected(IDictionary<String, object> current)
        {
            for (int i = 0; i < AchievementStatus.Achievements.Count; i++)
            {
                AchievementStatus.Achievements[i].SetCollected((int)(current["achievement" + (i + 1)]));
            }
        }
    }
}
