namespace Eeveelution_Race_Betting_Simulator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.raceButton = new System.Windows.Forms.Button();
            this.espeonPictureBox = new System.Windows.Forms.PictureBox();
            this.racetrackPictureBox = new System.Windows.Forms.PictureBox();
            this.flareonPictureBox = new System.Windows.Forms.PictureBox();
            this.leafeonPictureBox = new System.Windows.Forms.PictureBox();
            this.umbreonPictureBox = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.angellosBetInfoLabel = new System.Windows.Forms.Label();
            this.ingrossoBetInfoLabel = new System.Windows.Forms.Label();
            this.axwelBetInfoLabel = new System.Windows.Forms.Label();
            this.domainUpDown1 = new System.Windows.Forms.DomainUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betValueNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.betConfirmButton = new System.Windows.Forms.Button();
            this.bottomNameLabel = new System.Windows.Forms.Label();
            this.angelloRadioButton = new System.Windows.Forms.RadioButton();
            this.ingrossoRadioButton = new System.Windows.Forms.RadioButton();
            this.axwelRadioButton = new System.Windows.Forms.RadioButton();
            this.minimumBetLabel = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timerUpdate = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.espeonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flareonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafeonPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbreonPictureBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betValueNumericUpDown)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // raceButton
            // 
            this.raceButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raceButton.Location = new System.Drawing.Point(481, 41);
            this.raceButton.Name = "raceButton";
            this.raceButton.Size = new System.Drawing.Size(201, 110);
            this.raceButton.TabIndex = 0;
            this.raceButton.Text = "Race!";
            this.raceButton.UseVisualStyleBackColor = true;
            this.raceButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // espeonPictureBox
            // 
            this.espeonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("espeonPictureBox.Image")));
            this.espeonPictureBox.Location = new System.Drawing.Point(26, 12);
            this.espeonPictureBox.Name = "espeonPictureBox";
            this.espeonPictureBox.Size = new System.Drawing.Size(100, 50);
            this.espeonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.espeonPictureBox.TabIndex = 1;
            this.espeonPictureBox.TabStop = false;
            // 
            // racetrackPictureBox
            // 
            this.racetrackPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("racetrackPictureBox.Image")));
            this.racetrackPictureBox.Location = new System.Drawing.Point(26, 12);
            this.racetrackPictureBox.Name = "racetrackPictureBox";
            this.racetrackPictureBox.Size = new System.Drawing.Size(700, 248);
            this.racetrackPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrackPictureBox.TabIndex = 2;
            this.racetrackPictureBox.TabStop = false;
            // 
            // flareonPictureBox
            // 
            this.flareonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("flareonPictureBox.Image")));
            this.flareonPictureBox.Location = new System.Drawing.Point(26, 69);
            this.flareonPictureBox.Name = "flareonPictureBox";
            this.flareonPictureBox.Size = new System.Drawing.Size(100, 50);
            this.flareonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.flareonPictureBox.TabIndex = 3;
            this.flareonPictureBox.TabStop = false;
            // 
            // leafeonPictureBox
            // 
            this.leafeonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("leafeonPictureBox.Image")));
            this.leafeonPictureBox.Location = new System.Drawing.Point(26, 126);
            this.leafeonPictureBox.Name = "leafeonPictureBox";
            this.leafeonPictureBox.Size = new System.Drawing.Size(100, 58);
            this.leafeonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leafeonPictureBox.TabIndex = 4;
            this.leafeonPictureBox.TabStop = false;
            // 
            // umbreonPictureBox
            // 
            this.umbreonPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("umbreonPictureBox.Image")));
            this.umbreonPictureBox.Location = new System.Drawing.Point(26, 197);
            this.umbreonPictureBox.Name = "umbreonPictureBox";
            this.umbreonPictureBox.Size = new System.Drawing.Size(100, 60);
            this.umbreonPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.umbreonPictureBox.TabIndex = 5;
            this.umbreonPictureBox.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.angellosBetInfoLabel);
            this.groupBox1.Controls.Add(this.ingrossoBetInfoLabel);
            this.groupBox1.Controls.Add(this.axwelBetInfoLabel);
            this.groupBox1.Controls.Add(this.domainUpDown1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betValueNumericUpDown);
            this.groupBox1.Controls.Add(this.betConfirmButton);
            this.groupBox1.Controls.Add(this.bottomNameLabel);
            this.groupBox1.Controls.Add(this.angelloRadioButton);
            this.groupBox1.Controls.Add(this.ingrossoRadioButton);
            this.groupBox1.Controls.Add(this.axwelRadioButton);
            this.groupBox1.Controls.Add(this.minimumBetLabel);
            this.groupBox1.Controls.Add(this.raceButton);
            this.groupBox1.Location = new System.Drawing.Point(26, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 173);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlour";
            // 
            // angellosBetInfoLabel
            // 
            this.angellosBetInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.angellosBetInfoLabel.Location = new System.Drawing.Point(194, 101);
            this.angellosBetInfoLabel.Name = "angellosBetInfoLabel";
            this.angellosBetInfoLabel.Size = new System.Drawing.Size(191, 20);
            this.angellosBetInfoLabel.TabIndex = 12;
            this.angellosBetInfoLabel.Text = "Angello\'s Bet Info";
            // 
            // ingrossoBetInfoLabel
            // 
            this.ingrossoBetInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ingrossoBetInfoLabel.Location = new System.Drawing.Point(194, 76);
            this.ingrossoBetInfoLabel.Name = "ingrossoBetInfoLabel";
            this.ingrossoBetInfoLabel.Size = new System.Drawing.Size(191, 20);
            this.ingrossoBetInfoLabel.TabIndex = 11;
            this.ingrossoBetInfoLabel.Text = "Ingrosso\'s Bet Info";
            // 
            // axwelBetInfoLabel
            // 
            this.axwelBetInfoLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.axwelBetInfoLabel.Location = new System.Drawing.Point(194, 53);
            this.axwelBetInfoLabel.Name = "axwelBetInfoLabel";
            this.axwelBetInfoLabel.Size = new System.Drawing.Size(191, 20);
            this.axwelBetInfoLabel.TabIndex = 10;
            this.axwelBetInfoLabel.Text = "Axwel\'s Bet Info";
            // 
            // domainUpDown1
            // 
            this.domainUpDown1.Location = new System.Drawing.Point(270, 135);
            this.domainUpDown1.Name = "domainUpDown1";
            this.domainUpDown1.Size = new System.Drawing.Size(124, 20);
            this.domainUpDown1.TabIndex = 9;
            this.domainUpDown1.Text = "Select an Eeveelution";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(219, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "bucks on ";
            // 
            // betValueNumericUpDown
            // 
            this.betValueNumericUpDown.Location = new System.Drawing.Point(168, 136);
            this.betValueNumericUpDown.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.betValueNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betValueNumericUpDown.Name = "betValueNumericUpDown";
            this.betValueNumericUpDown.Size = new System.Drawing.Size(45, 20);
            this.betValueNumericUpDown.TabIndex = 7;
            this.betValueNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betConfirmButton
            // 
            this.betConfirmButton.Location = new System.Drawing.Point(87, 135);
            this.betConfirmButton.Name = "betConfirmButton";
            this.betConfirmButton.Size = new System.Drawing.Size(75, 23);
            this.betConfirmButton.TabIndex = 6;
            this.betConfirmButton.Text = "bets";
            this.betConfirmButton.UseVisualStyleBackColor = true;
            this.betConfirmButton.Click += new System.EventHandler(this.betConfirmButton_Click);
            // 
            // bottomNameLabel
            // 
            this.bottomNameLabel.AutoSize = true;
            this.bottomNameLabel.Location = new System.Drawing.Point(21, 140);
            this.bottomNameLabel.Name = "bottomNameLabel";
            this.bottomNameLabel.Size = new System.Drawing.Size(33, 13);
            this.bottomNameLabel.TabIndex = 5;
            this.bottomNameLabel.Text = "name";
            // 
            // angelloRadioButton
            // 
            this.angelloRadioButton.AutoSize = true;
            this.angelloRadioButton.Location = new System.Drawing.Point(11, 101);
            this.angelloRadioButton.Name = "angelloRadioButton";
            this.angelloRadioButton.Size = new System.Drawing.Size(118, 17);
            this.angelloRadioButton.TabIndex = 4;
            this.angelloRadioButton.TabStop = true;
            this.angelloRadioButton.Text = "angelloRadioButton";
            this.angelloRadioButton.UseVisualStyleBackColor = true;
            this.angelloRadioButton.CheckedChanged += new System.EventHandler(this.angelloRadioButton_CheckedChanged);
            // 
            // ingrossoRadioButton
            // 
            this.ingrossoRadioButton.AutoSize = true;
            this.ingrossoRadioButton.Location = new System.Drawing.Point(11, 76);
            this.ingrossoRadioButton.Name = "ingrossoRadioButton";
            this.ingrossoRadioButton.Size = new System.Drawing.Size(124, 17);
            this.ingrossoRadioButton.TabIndex = 3;
            this.ingrossoRadioButton.TabStop = true;
            this.ingrossoRadioButton.Text = "IngrossoRadioButton";
            this.ingrossoRadioButton.UseVisualStyleBackColor = true;
            this.ingrossoRadioButton.CheckedChanged += new System.EventHandler(this.ingrossoRadioButton_CheckedChanged);
            // 
            // axwelRadioButton
            // 
            this.axwelRadioButton.AutoSize = true;
            this.axwelRadioButton.Checked = true;
            this.axwelRadioButton.Location = new System.Drawing.Point(11, 53);
            this.axwelRadioButton.Name = "axwelRadioButton";
            this.axwelRadioButton.Size = new System.Drawing.Size(111, 17);
            this.axwelRadioButton.TabIndex = 2;
            this.axwelRadioButton.TabStop = true;
            this.axwelRadioButton.Text = "axwelRadioButton";
            this.axwelRadioButton.UseVisualStyleBackColor = true;
            this.axwelRadioButton.CheckedChanged += new System.EventHandler(this.axwelRadioButton_CheckedChanged);
            // 
            // minimumBetLabel
            // 
            this.minimumBetLabel.AutoSize = true;
            this.minimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimumBetLabel.Location = new System.Drawing.Point(7, 20);
            this.minimumBetLabel.Name = "minimumBetLabel";
            this.minimumBetLabel.Size = new System.Drawing.Size(155, 20);
            this.minimumBetLabel.TabIndex = 1;
            this.minimumBetLabel.Text = "minimum Bet label";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timerUpdate});
            this.statusStrip1.Location = new System.Drawing.Point(0, 455);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(749, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timerUpdate
            // 
            this.timerUpdate.Name = "timerUpdate";
            this.timerUpdate.Size = new System.Drawing.Size(168, 17);
            this.timerUpdate.Text = "2:00 remaining until next Race!";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 50;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 477);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.umbreonPictureBox);
            this.Controls.Add(this.leafeonPictureBox);
            this.Controls.Add(this.flareonPictureBox);
            this.Controls.Add(this.espeonPictureBox);
            this.Controls.Add(this.racetrackPictureBox);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "PokeRace";
            ((System.ComponentModel.ISupportInitialize)(this.espeonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrackPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flareonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leafeonPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umbreonPictureBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.betValueNumericUpDown)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button raceButton;
        private System.Windows.Forms.PictureBox espeonPictureBox;
        private System.Windows.Forms.PictureBox racetrackPictureBox;
        private System.Windows.Forms.PictureBox flareonPictureBox;
        private System.Windows.Forms.PictureBox leafeonPictureBox;
        private System.Windows.Forms.PictureBox umbreonPictureBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label angellosBetInfoLabel;
        private System.Windows.Forms.Label ingrossoBetInfoLabel;
        private System.Windows.Forms.Label axwelBetInfoLabel;
        private System.Windows.Forms.DomainUpDown domainUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betValueNumericUpDown;
        private System.Windows.Forms.Button betConfirmButton;
        private System.Windows.Forms.Label bottomNameLabel;
        private System.Windows.Forms.RadioButton angelloRadioButton;
        private System.Windows.Forms.RadioButton ingrossoRadioButton;
        private System.Windows.Forms.RadioButton axwelRadioButton;
        private System.Windows.Forms.Label minimumBetLabel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel timerUpdate;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

