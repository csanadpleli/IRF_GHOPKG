namespace IRF06_WORKSHOP
{
    partial class Form1
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.ribboncolorBurron = new System.Windows.Forms.Button();
            this.boxcolorButton = new System.Windows.Forms.Button();
            this.presentButton = new System.Windows.Forms.Button();
            this.ballcolorButton = new System.Windows.Forms.Button();
            this.nextLabel = new System.Windows.Forms.Label();
            this.ballButton = new System.Windows.Forms.Button();
            this.carButton = new System.Windows.Forms.Button();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.ribboncolorBurron);
            this.mainPanel.Controls.Add(this.boxcolorButton);
            this.mainPanel.Controls.Add(this.presentButton);
            this.mainPanel.Controls.Add(this.ballcolorButton);
            this.mainPanel.Controls.Add(this.nextLabel);
            this.mainPanel.Controls.Add(this.ballButton);
            this.mainPanel.Controls.Add(this.carButton);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(776, 426);
            this.mainPanel.TabIndex = 0;
            // 
            // ribboncolorBurron
            // 
            this.ribboncolorBurron.BackColor = System.Drawing.Color.DarkMagenta;
            this.ribboncolorBurron.Location = new System.Drawing.Point(166, 73);
            this.ribboncolorBurron.Name = "ribboncolorBurron";
            this.ribboncolorBurron.Size = new System.Drawing.Size(75, 23);
            this.ribboncolorBurron.TabIndex = 6;
            this.ribboncolorBurron.UseVisualStyleBackColor = false;
            this.ribboncolorBurron.Click += new System.EventHandler(this.ballcolorButton_Click);
            // 
            // boxcolorButton
            // 
            this.boxcolorButton.BackColor = System.Drawing.Color.DarkTurquoise;
            this.boxcolorButton.Location = new System.Drawing.Point(166, 44);
            this.boxcolorButton.Name = "boxcolorButton";
            this.boxcolorButton.Size = new System.Drawing.Size(75, 23);
            this.boxcolorButton.TabIndex = 5;
            this.boxcolorButton.UseVisualStyleBackColor = false;
            this.boxcolorButton.Click += new System.EventHandler(this.ballcolorButton_Click);
            // 
            // presentButton
            // 
            this.presentButton.Location = new System.Drawing.Point(166, 4);
            this.presentButton.Name = "presentButton";
            this.presentButton.Size = new System.Drawing.Size(75, 34);
            this.presentButton.TabIndex = 4;
            this.presentButton.Text = "PRESENT";
            this.presentButton.UseVisualStyleBackColor = true;
            this.presentButton.Click += new System.EventHandler(this.presentButton_Click);
            // 
            // ballcolorButton
            // 
            this.ballcolorButton.BackColor = System.Drawing.Color.Salmon;
            this.ballcolorButton.Location = new System.Drawing.Point(85, 44);
            this.ballcolorButton.Name = "ballcolorButton";
            this.ballcolorButton.Size = new System.Drawing.Size(75, 23);
            this.ballcolorButton.TabIndex = 3;
            this.ballcolorButton.UseVisualStyleBackColor = false;
            this.ballcolorButton.Click += new System.EventHandler(this.ballcolorButton_Click);
            // 
            // nextLabel
            // 
            this.nextLabel.AutoSize = true;
            this.nextLabel.Location = new System.Drawing.Point(293, 4);
            this.nextLabel.Name = "nextLabel";
            this.nextLabel.Size = new System.Drawing.Size(70, 13);
            this.nextLabel.TabIndex = 2;
            this.nextLabel.Text = "Coming Next:";
            this.nextLabel.Click += new System.EventHandler(this.nextLabel_Click);
            // 
            // ballButton
            // 
            this.ballButton.Location = new System.Drawing.Point(85, 4);
            this.ballButton.Name = "ballButton";
            this.ballButton.Size = new System.Drawing.Size(75, 34);
            this.ballButton.TabIndex = 1;
            this.ballButton.Text = "BALL";
            this.ballButton.UseVisualStyleBackColor = true;
            this.ballButton.Click += new System.EventHandler(this.ballButton_Click);
            // 
            // carButton
            // 
            this.carButton.Location = new System.Drawing.Point(4, 4);
            this.carButton.Name = "carButton";
            this.carButton.Size = new System.Drawing.Size(75, 34);
            this.carButton.TabIndex = 0;
            this.carButton.Text = "CAR";
            this.carButton.UseVisualStyleBackColor = true;
            this.carButton.Click += new System.EventHandler(this.carButton_Click);
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Label nextLabel;
        private System.Windows.Forms.Button ballButton;
        private System.Windows.Forms.Button carButton;
        private System.Windows.Forms.Button ballcolorButton;
        private System.Windows.Forms.Button ribboncolorBurron;
        private System.Windows.Forms.Button boxcolorButton;
        private System.Windows.Forms.Button presentButton;
    }
}

