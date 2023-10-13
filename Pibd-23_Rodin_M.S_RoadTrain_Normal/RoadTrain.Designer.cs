namespace Pibd_23_Rodin_M.S_RoadTrain_Normal
{
    partial class RoadTrain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RoadTrain));
            pictureBox1 = new PictureBox();
            ButtonRight = new Button();
            buttonLeft = new Button();
            buttonDown = new Button();
            buttonCreate = new Button();
            buttonIUP = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(800, 450);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ButtonRight
            // 
            ButtonRight.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            ButtonRight.BackgroundImage = (Image)resources.GetObject("ButtonRight.BackgroundImage");
            ButtonRight.BackgroundImageLayout = ImageLayout.Zoom;
            ButtonRight.Location = new Point(758, 372);
            ButtonRight.Name = "ButtonRight";
            ButtonRight.Size = new Size(30, 30);
            ButtonRight.TabIndex = 1;
            ButtonRight.UseVisualStyleBackColor = true;
            ButtonRight.Click += button1_Click;
            // 
            // buttonLeft
            // 
            buttonLeft.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonLeft.BackgroundImage = (Image)resources.GetObject("buttonLeft.BackgroundImage");
            buttonLeft.BackgroundImageLayout = ImageLayout.Zoom;
            buttonLeft.Location = new Point(686, 372);
            buttonLeft.Name = "buttonLeft";
            buttonLeft.Size = new Size(30, 30);
            buttonLeft.TabIndex = 2;
            buttonLeft.UseVisualStyleBackColor = true;
            // 
            // buttonDown
            // 
            buttonDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonDown.BackgroundImage = (Image)resources.GetObject("buttonDown.BackgroundImage");
            buttonDown.BackgroundImageLayout = ImageLayout.Zoom;
            buttonDown.Location = new Point(722, 336);
            buttonDown.Name = "buttonDown";
            buttonDown.Size = new Size(30, 30);
            buttonDown.TabIndex = 3;
            buttonDown.UseVisualStyleBackColor = true;
            buttonDown.Click += button3_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonCreate.Location = new Point(12, 372);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(32, 30);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "button4";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // buttonIUP
            // 
            buttonIUP.AccessibleName = "buttomUp";
            buttonIUP.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonIUP.BackgroundImage = (Image)resources.GetObject("buttonIUP.BackgroundImage");
            buttonIUP.BackgroundImageLayout = ImageLayout.Zoom;
            buttonIUP.Location = new Point(722, 372);
            buttonIUP.Name = "buttonIUP";
            buttonIUP.Size = new Size(30, 30);
            buttonIUP.TabIndex = 5;
            buttonIUP.UseVisualStyleBackColor = true;
            buttonIUP.Click += button5_Click;
            // 
            // RoadTrain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonIUP);
            Controls.Add(buttonCreate);
            Controls.Add(buttonDown);
            Controls.Add(buttonLeft);
            Controls.Add(ButtonRight);
            Controls.Add(pictureBox1);
            Name = "RoadTrain";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button ButtonRight;
        private Button buttonLeft;
        private Button buttonDown;
        private Button buttonCreate;
        private Button buttonIUP;
    }
}