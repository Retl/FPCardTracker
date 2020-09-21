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
            this.Controls.Add(aslComponent.GetSettingsControl(new LayoutMode()));
        }

        private void tmrUpdate_Tick(object sender, EventArgs e)
        {
            //dynamic vars = aslComponent.Script.Vars;
            if (aslComponent.Script != null && aslComponent.Script.State != null) {
                ExpandoObject vars = aslComponent.Script.Vars;
                if (vars != null)
                {
                    lblDebug.Text = "Vars populated: ";

                    dynamic current = aslComponent.Script.State.Data;
                    if (current.roomID != null) {
                        int roomID = current.roomID;
                        lblDebug.Text += "Room ID: " + roomID.ToString();
                    }
                }
                else
                {
                    lblDebug.Text = "Waiting on Vars to populate.";
                }
            }
        }
    }
}
