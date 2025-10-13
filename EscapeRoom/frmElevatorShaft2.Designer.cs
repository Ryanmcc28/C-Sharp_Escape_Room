namespace EscapeRoom
{
    partial class frmElevatorShaft2
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pctElevator = new System.Windows.Forms.PictureBox();
            this.pctKnight = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctElevator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).BeginInit();
            this.SuspendLayout();
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
            this.label1.Location = new System.Drawing.Point(117, 338);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(445, 117);
            this.label1.TabIndex = 72;
            this.label1.Text = "LOADING....";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Black;
            this.pictureBox1.Location = new System.Drawing.Point(977, -23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(911, 928);
            this.pictureBox1.TabIndex = 71;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(-125, -110);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(903, 928);
            this.pictureBox2.TabIndex = 70;
            this.pictureBox2.TabStop = false;
            // 
            // pctElevator
            // 
            this.pctElevator.Image = global::EscapeRoom.Properties.Resources.Wooden_Platform1;
            this.pctElevator.Location = new System.Drawing.Point(774, 9);
            this.pctElevator.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctElevator.Name = "pctElevator";
            this.pctElevator.Size = new System.Drawing.Size(209, 26);
            this.pctElevator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctElevator.TabIndex = 69;
            this.pctElevator.TabStop = false;
            // 
            // pctKnight
            // 
            this.pctKnight.BackColor = System.Drawing.Color.Transparent;
            this.pctKnight.Image = global::EscapeRoom.Properties.Resources.knight;
            this.pctKnight.Location = new System.Drawing.Point(836, -43);
            this.pctKnight.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pctKnight.Name = "pctKnight";
            this.pctKnight.Size = new System.Drawing.Size(79, 56);
            this.pctKnight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctKnight.TabIndex = 68;
            this.pctKnight.TabStop = false;
            // 
            // frmElevatorShaft2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pctElevator);
            this.Controls.Add(this.pctKnight);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmElevatorShaft2";
            this.Text = "d";
            this.Load += new System.EventHandler(this.frmElevatorShaft2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctElevator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pctKnight)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pctElevator;
        private PictureBox pctKnight;
    }
}