namespace EscapeRoom
{
    partial class frmEscaped
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEscaped));
            this.pctForestb = new System.Windows.Forms.PictureBox();
            this.tmrMain = new System.Windows.Forms.Timer(this.components);
            this.pctFloor = new System.Windows.Forms.PictureBox();
            this.pctRoof = new System.Windows.Forms.PictureBox();
            this.pctKnight = new System.Windows.Forms.PictureBox();
            this.pctForesta = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pctForestb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFloor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRoof)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctForesta)).BeginInit();
            this.SuspendLayout();
            // 
            // pctForestb
            // 
            this.pctForestb.Image = ((System.Drawing.Image)(resources.GetObject("pctForestb.Image")));
            this.pctForestb.Location = new System.Drawing.Point(1414, 301);
            this.pctForestb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctForestb.Name = "pctForestb";
            this.pctForestb.Size = new System.Drawing.Size(1424, 352);
            this.pctForestb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctForestb.TabIndex = 60;
            this.pctForestb.TabStop = false;
            // 
            // tmrMain
            // 
            this.tmrMain.Enabled = true;
            this.tmrMain.Interval = 1;
            this.tmrMain.Tick += new System.EventHandler(this.tmrMain_Tick);
            // 
            // pctFloor
            // 
            this.pctFloor.BackColor = System.Drawing.Color.Black;
            this.pctFloor.Location = new System.Drawing.Point(-1, 641);
            this.pctFloor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctFloor.Name = "pctFloor";
            this.pctFloor.Size = new System.Drawing.Size(1680, 209);
            this.pctFloor.TabIndex = 58;
            this.pctFloor.TabStop = false;
            // 
            // pctRoof
            // 
            this.pctRoof.BackColor = System.Drawing.Color.Black;
            this.pctRoof.Location = new System.Drawing.Point(-1, 0);
            this.pctRoof.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctRoof.Name = "pctRoof";
            this.pctRoof.Size = new System.Drawing.Size(1680, 306);
            this.pctRoof.TabIndex = 57;
            this.pctRoof.TabStop = false;
            // 
            // pctKnight
            // 
            this.pctKnight.BackColor = System.Drawing.Color.Transparent;
            this.pctKnight.Image = global::EscapeRoom.Properties.Resources.knight;
            this.pctKnight.Location = new System.Drawing.Point(19, 585);
            this.pctKnight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctKnight.Name = "pctKnight";
            this.pctKnight.Size = new System.Drawing.Size(79, 56);
            this.pctKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctKnight.TabIndex = 61;
            this.pctKnight.TabStop = false;
            // 
            // pctForesta
            // 
            this.pctForesta.Image = ((System.Drawing.Image)(resources.GetObject("pctForesta.Image")));
            this.pctForesta.Location = new System.Drawing.Point(-1, 301);
            this.pctForesta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctForesta.Name = "pctForesta";
            this.pctForesta.Size = new System.Drawing.Size(1424, 352);
            this.pctForesta.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctForesta.TabIndex = 59;
            this.pctForesta.TabStop = false;
            this.pctForesta.Click += new System.EventHandler(this.pctForesta_Click);
            // 
            // frmEscaped
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.pctKnight);
            this.Controls.Add(this.pctRoof);
            this.Controls.Add(this.pctFloor);
            this.Controls.Add(this.pctForesta);
            this.Controls.Add(this.pctForestb);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmEscaped";
            this.Text = "frmEscaped";
            this.Load += new System.EventHandler(this.frmEscaped_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmEscaped_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.frmEscaped_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pctForestb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctFloor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctRoof)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctForesta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox pctForestb;
        private System.Windows.Forms.Timer tmrMain;
        private PictureBox pctFloor;
        private PictureBox pctRoof;
        private PictureBox pctKnight;
        private PictureBox pctForesta;
    }
}