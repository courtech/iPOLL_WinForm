namespace VOTING_SYSTEM_IDKENERMOR
{
    partial class CandidateControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CandidateControl));
            this.name = new System.Windows.Forms.Label();
            this.partylist = new System.Windows.Forms.Label();
            this.photo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photo)).BeginInit();
            this.SuspendLayout();
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(84, 10);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(113, 23);
            this.name.TabIndex = 1;
            this.name.Text = "Name";
            // 
            // partylist
            // 
            this.partylist.Location = new System.Drawing.Point(85, 33);
            this.partylist.Name = "partylist";
            this.partylist.Size = new System.Drawing.Size(112, 18);
            this.partylist.TabIndex = 2;
            this.partylist.Text = "Partylist";
            // 
            // photo
            // 
            this.photo.Image = ((System.Drawing.Image)(resources.GetObject("photo.Image")));
            this.photo.Location = new System.Drawing.Point(0, 0);
            this.photo.Name = "photo";
            this.photo.Size = new System.Drawing.Size(64, 60);
            this.photo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.photo.TabIndex = 0;
            this.photo.TabStop = false;
            // 
            // CandidateControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.partylist);
            this.Controls.Add(this.name);
            this.Controls.Add(this.photo);
            this.Name = "CandidateControl";
            this.Size = new System.Drawing.Size(200, 60);
            this.Load += new System.EventHandler(this.CandidateControl_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox photo;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label partylist;
    }
}
