namespace VOTING_SYSTEM_IDKENERMOR
{
    partial class Candidate
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl1name = new System.Windows.Forms.Label();
            this.lbl2partylist = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lbl1name
            // 
            this.lbl1name.AutoEllipsis = true;
            this.lbl1name.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1name.Location = new System.Drawing.Point(77, 10);
            this.lbl1name.Name = "lbl1name";
            this.lbl1name.Size = new System.Drawing.Size(123, 28);
            this.lbl1name.TabIndex = 1;
            this.lbl1name.Text = "Name";
            // 
            // lbl2partylist
            // 
            this.lbl2partylist.AutoEllipsis = true;
            this.lbl2partylist.Location = new System.Drawing.Point(81, 35);
            this.lbl2partylist.Name = "lbl2partylist";
            this.lbl2partylist.Size = new System.Drawing.Size(119, 25);
            this.lbl2partylist.TabIndex = 2;
            this.lbl2partylist.Text = "Partylist";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.ForeColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(-2, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(205, 10);
            this.panel1.TabIndex = 3;
            // 
            // Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl2partylist);
            this.Controls.Add(this.lbl1name);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Candidate";
            this.Size = new System.Drawing.Size(200, 60);
            this.Load += new System.EventHandler(this.Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl1name;
        private System.Windows.Forms.Label lbl2partylist;
        private System.Windows.Forms.Panel panel1;
    }
}
