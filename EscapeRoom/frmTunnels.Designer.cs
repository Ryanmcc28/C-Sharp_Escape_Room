namespace EscapeRoom
{
    partial class frmTunnels
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
            this.Wall2 = new System.Windows.Forms.PictureBox();
            this.Wall1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctFan = new System.Windows.Forms.PictureBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pctVent = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVent)).BeginInit();
            this.SuspendLayout();
            // 
            // Wall2
            // 
            this.Wall2.BackColor = System.Drawing.Color.Black;
            this.Wall2.Location = new System.Drawing.Point(-1, 0);
            this.Wall2.Name = "Wall2";
            this.Wall2.Size = new System.Drawing.Size(1920, 551);
            this.Wall2.TabIndex = 2;
            this.Wall2.TabStop = false;
            // 
            // Wall1
            // 
            this.Wall1.BackColor = System.Drawing.Color.Black;
            this.Wall1.Location = new System.Drawing.Point(-1, 620);
            this.Wall1.Name = "Wall1";
            this.Wall1.Size = new System.Drawing.Size(1920, 528);
            this.Wall1.TabIndex = 3;
            this.Wall1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::EscapeRoom.Properties.Resources.knight;
            this.pictureBox2.Location = new System.Drawing.Point(61, 547);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // pctFan
            // 
            this.pctFan.BackColor = System.Drawing.Color.Transparent;
            this.pctFan.Image = global::EscapeRoom.Properties.Resources.Broken_Fan_Crates;
            this.pctFan.Location = new System.Drawing.Point(-1, 544);
            this.pctFan.Name = "pctFan";
            this.pctFan.Size = new System.Drawing.Size(84, 78);
            this.pctFan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctFan.TabIndex = 26;
            this.pctFan.TabStop = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pctVent
            // 
            this.pctVent.BackColor = System.Drawing.Color.Transparent;
            this.pctVent.Image = global::EscapeRoom.Properties.Resources.GridCrate;
            this.pctVent.Location = new System.Drawing.Point(1806, 547);
            this.pctVent.Name = "pctVent";
            this.pctVent.Size = new System.Drawing.Size(84, 78);
            this.pctVent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctVent.TabIndex = 27;
            this.pctVent.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(748, 348);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(553, 145);
            this.label1.TabIndex = 28;
            this.label1.Text = "LOADING....";
            // 
            // frmTunnels
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Wall2);
            this.Controls.Add(this.Wall1);
            this.Controls.Add(this.pctVent);
            this.Controls.Add(this.pctFan);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTunnels";
            this.Text = "frmTunnels";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTunnels_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Wall2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Wall1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctVent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox Wall2;
        private PictureBox Wall1;
        private PictureBox pictureBox2;
        private PictureBox pctFan;
        private System.Windows.Forms.Timer tmrMain;
        private PictureBox pctVent;
        private Label label1;
    }
}