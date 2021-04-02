namespace Horse_Race
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxFinish = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.alBet = new System.Windows.Forms.Label();
            this.bobBet = new System.Windows.Forms.Label();
            this.joeBet = new System.Windows.Forms.Label();
            this.HorseNumber = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.BetAmount = new System.Windows.Forms.NumericUpDown();
            this.Bets = new System.Windows.Forms.Button();
            this.race = new System.Windows.Forms.Button();
            this.pictureBoxAt3 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAt2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxAt1 = new System.Windows.Forms.PictureBox();
            this.BettorName = new System.Windows.Forms.Label();
            this.MinimumBet = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bobButton = new System.Windows.Forms.RadioButton();
            this.joeButton = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.bettingroup = new System.Windows.Forms.GroupBox();
            this.alButton = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBoxAt4 = new System.Windows.Forms.PictureBox();
            this.racetrack = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxRedLight = new System.Windows.Forms.PictureBox();
            this.pictureBoxGreenLight = new System.Windows.Forms.PictureBox();
            this.btnKapat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt1)).BeginInit();
            this.bettingroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedLight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenLight)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxFinish
            // 
            this.pictureBoxFinish.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxFinish.Image")));
            this.pictureBoxFinish.Location = new System.Drawing.Point(568, 0);
            this.pictureBoxFinish.Name = "pictureBoxFinish";
            this.pictureBoxFinish.Size = new System.Drawing.Size(63, 283);
            this.pictureBoxFinish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxFinish.TabIndex = 34;
            this.pictureBoxFinish.TabStop = false;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkRed;
            this.label4.Location = new System.Drawing.Point(-4, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(575, 10);
            this.label4.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DarkRed;
            this.label3.Location = new System.Drawing.Point(-5, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(576, 10);
            this.label3.TabIndex = 32;
            // 
            // alBet
            // 
            this.alBet.BackColor = System.Drawing.Color.White;
            this.alBet.Location = new System.Drawing.Point(218, 165);
            this.alBet.Name = "alBet";
            this.alBet.Size = new System.Drawing.Size(190, 25);
            this.alBet.TabIndex = 16;
            this.alBet.Text = "alBetLabel";
            // 
            // bobBet
            // 
            this.bobBet.BackColor = System.Drawing.Color.White;
            this.bobBet.Location = new System.Drawing.Point(218, 127);
            this.bobBet.Name = "bobBet";
            this.bobBet.Size = new System.Drawing.Size(190, 24);
            this.bobBet.TabIndex = 15;
            this.bobBet.Text = "bobBetLabel";
            // 
            // joeBet
            // 
            this.joeBet.BackColor = System.Drawing.Color.White;
            this.joeBet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.joeBet.Location = new System.Drawing.Point(215, 84);
            this.joeBet.Name = "joeBet";
            this.joeBet.Size = new System.Drawing.Size(193, 25);
            this.joeBet.TabIndex = 14;
            this.joeBet.Text = "joeBetLabel";
            // 
            // HorseNumber
            // 
            this.HorseNumber.Location = new System.Drawing.Point(378, 210);
            this.HorseNumber.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.HorseNumber.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.HorseNumber.Name = "HorseNumber";
            this.HorseNumber.Size = new System.Drawing.Size(55, 21);
            this.HorseNumber.TabIndex = 13;
            this.HorseNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(215, 210);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(157, 15);
            this.label6.TabIndex = 12;
            this.label6.Text = "bucks on horse number";
            // 
            // BetAmount
            // 
            this.BetAmount.Location = new System.Drawing.Point(159, 208);
            this.BetAmount.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.BetAmount.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.BetAmount.Name = "BetAmount";
            this.BetAmount.Size = new System.Drawing.Size(50, 21);
            this.BetAmount.TabIndex = 11;
            this.BetAmount.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Bets
            // 
            this.Bets.Location = new System.Drawing.Point(81, 206);
            this.Bets.Name = "Bets";
            this.Bets.Size = new System.Drawing.Size(58, 23);
            this.Bets.TabIndex = 10;
            this.Bets.Text = "Bets";
            this.Bets.UseVisualStyleBackColor = true;
            this.Bets.Click += new System.EventHandler(this.Bets_Click);
            // 
            // race
            // 
            this.race.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.race.Location = new System.Drawing.Point(426, 34);
            this.race.Name = "race";
            this.race.Size = new System.Drawing.Size(155, 150);
            this.race.TabIndex = 9;
            this.race.Text = "Race";
            this.race.UseVisualStyleBackColor = true;
            this.race.Click += new System.EventHandler(this.race_Click);
            // 
            // pictureBoxAt3
            // 
            this.pictureBoxAt3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAt3.Image")));
            this.pictureBoxAt3.Location = new System.Drawing.Point(8, 154);
            this.pictureBoxAt3.Name = "pictureBoxAt3";
            this.pictureBoxAt3.Size = new System.Drawing.Size(81, 50);
            this.pictureBoxAt3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAt3.TabIndex = 37;
            this.pictureBoxAt3.TabStop = false;
            // 
            // pictureBoxAt2
            // 
            this.pictureBoxAt2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAt2.Image")));
            this.pictureBoxAt2.Location = new System.Drawing.Point(8, 88);
            this.pictureBoxAt2.Name = "pictureBoxAt2";
            this.pictureBoxAt2.Size = new System.Drawing.Size(81, 50);
            this.pictureBoxAt2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAt2.TabIndex = 36;
            this.pictureBoxAt2.TabStop = false;
            // 
            // pictureBoxAt1
            // 
            this.pictureBoxAt1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAt1.Image")));
            this.pictureBoxAt1.Location = new System.Drawing.Point(8, 22);
            this.pictureBoxAt1.Name = "pictureBoxAt1";
            this.pictureBoxAt1.Size = new System.Drawing.Size(81, 50);
            this.pictureBoxAt1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAt1.TabIndex = 35;
            this.pictureBoxAt1.TabStop = false;
            // 
            // BettorName
            // 
            this.BettorName.AutoSize = true;
            this.BettorName.Location = new System.Drawing.Point(15, 206);
            this.BettorName.Name = "BettorName";
            this.BettorName.Size = new System.Drawing.Size(43, 15);
            this.BettorName.TabIndex = 8;
            this.BettorName.Text = "name";
            // 
            // MinimumBet
            // 
            this.MinimumBet.AutoSize = true;
            this.MinimumBet.Location = new System.Drawing.Point(15, 56);
            this.MinimumBet.Name = "MinimumBet";
            this.MinimumBet.Size = new System.Drawing.Size(124, 15);
            this.MinimumBet.TabIndex = 4;
            this.MinimumBet.Text = "minimumBetLabel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(209, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "Bets";
            // 
            // bobButton
            // 
            this.bobButton.AutoSize = true;
            this.bobButton.Location = new System.Drawing.Point(18, 127);
            this.bobButton.Name = "bobButton";
            this.bobButton.Size = new System.Drawing.Size(49, 19);
            this.bobButton.TabIndex = 1;
            this.bobButton.TabStop = true;
            this.bobButton.Text = "bob";
            this.bobButton.UseVisualStyleBackColor = true;
            this.bobButton.CheckedChanged += new System.EventHandler(this.bobButton_CheckedChanged);
            // 
            // joeButton
            // 
            this.joeButton.AutoSize = true;
            this.joeButton.Location = new System.Drawing.Point(18, 90);
            this.joeButton.Name = "joeButton";
            this.joeButton.Size = new System.Drawing.Size(45, 19);
            this.joeButton.TabIndex = 0;
            this.joeButton.TabStop = true;
            this.joeButton.Text = "joe";
            this.joeButton.UseVisualStyleBackColor = true;
            this.joeButton.CheckedChanged += new System.EventHandler(this.joeButton_CheckedChanged);
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.DarkRed;
            this.label7.Location = new System.Drawing.Point(-3, 273);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(574, 10);
            this.label7.TabIndex = 39;
            // 
            // bettingroup
            // 
            this.bettingroup.BackColor = System.Drawing.Color.Green;
            this.bettingroup.Controls.Add(this.alBet);
            this.bettingroup.Controls.Add(this.bobBet);
            this.bettingroup.Controls.Add(this.joeBet);
            this.bettingroup.Controls.Add(this.HorseNumber);
            this.bettingroup.Controls.Add(this.label6);
            this.bettingroup.Controls.Add(this.BetAmount);
            this.bettingroup.Controls.Add(this.Bets);
            this.bettingroup.Controls.Add(this.race);
            this.bettingroup.Controls.Add(this.BettorName);
            this.bettingroup.Controls.Add(this.MinimumBet);
            this.bettingroup.Controls.Add(this.label5);
            this.bettingroup.Controls.Add(this.alButton);
            this.bettingroup.Controls.Add(this.bobButton);
            this.bettingroup.Controls.Add(this.joeButton);
            this.bettingroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bettingroup.Location = new System.Drawing.Point(17, 289);
            this.bettingroup.Name = "bettingroup";
            this.bettingroup.Size = new System.Drawing.Size(604, 231);
            this.bettingroup.TabIndex = 38;
            this.bettingroup.TabStop = false;
            this.bettingroup.Text = "Betting Group";
            // 
            // alButton
            // 
            this.alButton.AutoSize = true;
            this.alButton.Location = new System.Drawing.Point(18, 165);
            this.alButton.Name = "alButton";
            this.alButton.Size = new System.Drawing.Size(37, 19);
            this.alButton.TabIndex = 2;
            this.alButton.TabStop = true;
            this.alButton.Text = "al";
            this.alButton.UseVisualStyleBackColor = true;
            this.alButton.CheckedChanged += new System.EventHandler(this.alButton_CheckedChanged);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(-1, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(572, 12);
            this.label2.TabIndex = 31;
            // 
            // pictureBoxAt4
            // 
            this.pictureBoxAt4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAt4.Image")));
            this.pictureBoxAt4.Location = new System.Drawing.Point(8, 220);
            this.pictureBoxAt4.Name = "pictureBoxAt4";
            this.pictureBoxAt4.Size = new System.Drawing.Size(81, 50);
            this.pictureBoxAt4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAt4.TabIndex = 40;
            this.pictureBoxAt4.TabStop = false;
            // 
            // racetrack
            // 
            this.racetrack.Image = ((System.Drawing.Image)(resources.GetObject("racetrack.Image")));
            this.racetrack.Location = new System.Drawing.Point(-3, 0);
            this.racetrack.Name = "racetrack";
            this.racetrack.Size = new System.Drawing.Size(634, 283);
            this.racetrack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.racetrack.TabIndex = 41;
            this.racetrack.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(-2, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(573, 10);
            this.label1.TabIndex = 42;
            // 
            // pictureBoxRedLight
            // 
            this.pictureBoxRedLight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxRedLight.Image")));
            this.pictureBoxRedLight.Location = new System.Drawing.Point(568, 207);
            this.pictureBoxRedLight.Name = "pictureBoxRedLight";
            this.pictureBoxRedLight.Size = new System.Drawing.Size(63, 38);
            this.pictureBoxRedLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxRedLight.TabIndex = 44;
            this.pictureBoxRedLight.TabStop = false;
            // 
            // pictureBoxGreenLight
            // 
            this.pictureBoxGreenLight.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxGreenLight.Image")));
            this.pictureBoxGreenLight.Location = new System.Drawing.Point(568, 251);
            this.pictureBoxGreenLight.Name = "pictureBoxGreenLight";
            this.pictureBoxGreenLight.Size = new System.Drawing.Size(63, 32);
            this.pictureBoxGreenLight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGreenLight.TabIndex = 43;
            this.pictureBoxGreenLight.TabStop = false;
            this.pictureBoxGreenLight.Visible = false;
            // 
            // btnKapat
            // 
            this.btnKapat.BackColor = System.Drawing.Color.Red;
            this.btnKapat.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKapat.BackgroundImage")));
            this.btnKapat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnKapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Location = new System.Drawing.Point(577, 0);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(54, 39);
            this.btnKapat.TabIndex = 45;
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Green;
            this.ClientSize = new System.Drawing.Size(628, 520);
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.pictureBoxRedLight);
            this.Controls.Add(this.pictureBoxGreenLight);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxFinish);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBoxAt3);
            this.Controls.Add(this.pictureBoxAt2);
            this.Controls.Add(this.pictureBoxAt1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bettingroup);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBoxAt4);
            this.Controls.Add(this.racetrack);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxFinish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HorseNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BetAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt1)).EndInit();
            this.bettingroup.ResumeLayout(false);
            this.bettingroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAt4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racetrack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRedLight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGreenLight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxFinish;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label alBet;
        private System.Windows.Forms.Label bobBet;
        private System.Windows.Forms.Label joeBet;
        private System.Windows.Forms.NumericUpDown HorseNumber;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown BetAmount;
        private System.Windows.Forms.Button Bets;
        private System.Windows.Forms.Button race;
        private System.Windows.Forms.PictureBox pictureBoxAt3;
        private System.Windows.Forms.PictureBox pictureBoxAt2;
        private System.Windows.Forms.PictureBox pictureBoxAt1;
        private System.Windows.Forms.Label BettorName;
        private System.Windows.Forms.Label MinimumBet;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton bobButton;
        private System.Windows.Forms.RadioButton joeButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox bettingroup;
        private System.Windows.Forms.RadioButton alButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBoxAt4;
        private System.Windows.Forms.PictureBox racetrack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxRedLight;
        private System.Windows.Forms.PictureBox pictureBoxGreenLight;
        private System.Windows.Forms.Button btnKapat;
    }
}

