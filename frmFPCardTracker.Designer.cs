namespace FPCardTracker
{
    partial class frmFPCardTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pbCardStatus = new System.Windows.Forms.PictureBox();
            this.tmrUpdate = new System.Windows.Forms.Timer(this.components);
            this.lblDebug = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbCardStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pbCardStatus
            // 
            this.pbCardStatus.Location = new System.Drawing.Point(468, 53);
            this.pbCardStatus.Name = "pbCardStatus";
            this.pbCardStatus.Size = new System.Drawing.Size(320, 240);
            this.pbCardStatus.TabIndex = 3;
            this.pbCardStatus.TabStop = false;
            // 
            // tmrUpdate
            // 
            this.tmrUpdate.Enabled = true;
            this.tmrUpdate.Interval = 33;
            this.tmrUpdate.Tick += new System.EventHandler(this.tmrUpdate_Tick);
            // 
            // lblDebug
            // 
            this.lblDebug.AutoSize = true;
            this.lblDebug.Location = new System.Drawing.Point(468, 13);
            this.lblDebug.Name = "lblDebug";
            this.lblDebug.Size = new System.Drawing.Size(93, 13);
            this.lblDebug.TabIndex = 4;
            this.lblDebug.Text = "Debug Messaging";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 293);
            this.Controls.Add(this.lblDebug);
            this.Controls.Add(this.pbCardStatus);
            this.Name = "Form1";
            this.Text = "Freedom Planet Card Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbCardStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pbCardStatus;
        private System.Windows.Forms.Timer tmrUpdate;
        private System.Windows.Forms.Label lblDebug;
    }
}

