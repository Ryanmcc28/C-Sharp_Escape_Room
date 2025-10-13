namespace EscapeRoom
{
    partial class frmElevatorShaft
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
            this.pctElevator = new System.Windows.Forms.PictureBox();
            this.pctKnight = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pctElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pctElevator
            // 
            this.pctElevator.Image = global::EscapeRoom.Properties.Resources.Wooden_Platform1;
            this.pctElevator.Location = new System.Drawing.Point(718, 734);
            this.pctElevator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctElevator.Name = "pctElevator";
            this.pctElevator.Size = new System.Drawing.Size(209, 26);
            this.pctElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctElevator.TabIndex = 64;
            this.pctElevator.TabStop = false;
            // 
            // pctKnight
            // 
            this.pctKnight.BackColor = System.Drawing.Color.Transparent;
            this.pctKnight.Image = global::EscapeRoom.Properties.Resources.knight;
            this.pctKnight.Location = new System.Drawing.Point(781, 682);
            this.pctKnight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctKnight.Name = "pctKnight";
            this.pctKnight.Size = new System.Drawing.Size(79, 56);
            this.pctKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctKnight.TabIndex = 63;
            this.pctKnight.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-181, -81);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(902, 928);
            this.pictureBox2.TabIndex = 65;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(924, -112);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 928);
            this.pictureBox1.TabIndex = 66;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Impact", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(61, 368);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 117);
            this.label1.TabIndex = 67;
            this.label1.Text = "LOADING....";
            // 
            // frmElevatorShaft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pctElevator);
            this.Controls.Add(this.pctKnight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmElevatorShaft";
            this.Text = "frmElevatorShaft";
            this.Load += new System.EventHandler(this.frmElevatorShaft_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pctElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pctElevator;
        private PictureBox pctKnight;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private Label label1;
    }
}