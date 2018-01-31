namespace RustFurnaceSimulator
{
    partial class RustFurnace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RustFurnace));
            this.resultAmount = new System.Windows.Forms.Label();
            this.Result = new System.Windows.Forms.Label();
            this.ttcValue = new System.Windows.Forms.Label();
            this.ttc = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.woodTrackBar = new System.Windows.Forms.TrackBar();
            this.woodAmountLabel = new System.Windows.Forms.Label();
            this.woodAmount = new System.Windows.Forms.TextBox();
            this.oreTrackBar = new System.Windows.Forms.TrackBar();
            this.oreAmountLabel = new System.Windows.Forms.Label();
            this.oreAmount = new System.Windows.Forms.TextBox();
            this.OreTypes = new System.Windows.Forms.GroupBox();
            this.HQOre = new System.Windows.Forms.RadioButton();
            this.SulfurOre = new System.Windows.Forms.RadioButton();
            this.MetalOre = new System.Windows.Forms.RadioButton();
            this.highQuality = new System.Windows.Forms.PictureBox();
            this.sulfur = new System.Windows.Forms.PictureBox();
            this.metalFragments = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.woodTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oreTrackBar)).BeginInit();
            this.OreTypes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sulfur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalFragments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // resultAmount
            // 
            this.resultAmount.AutoSize = true;
            this.resultAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.resultAmount.Location = new System.Drawing.Point(473, 327);
            this.resultAmount.Name = "resultAmount";
            this.resultAmount.Size = new System.Drawing.Size(0, 25);
            this.resultAmount.TabIndex = 36;
            // 
            // Result
            // 
            this.Result.AutoSize = true;
            this.Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Result.Location = new System.Drawing.Point(436, 279);
            this.Result.Name = "Result";
            this.Result.Size = new System.Drawing.Size(66, 25);
            this.Result.TabIndex = 35;
            this.Result.Text = "Result";
            // 
            // ttcValue
            // 
            this.ttcValue.AutoSize = true;
            this.ttcValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.ttcValue.Location = new System.Drawing.Point(256, 335);
            this.ttcValue.Name = "ttcValue";
            this.ttcValue.Size = new System.Drawing.Size(0, 17);
            this.ttcValue.TabIndex = 34;
            // 
            // ttc
            // 
            this.ttc.AutoSize = true;
            this.ttc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ttc.Location = new System.Drawing.Point(241, 279);
            this.ttc.Name = "ttc";
            this.ttc.Size = new System.Drawing.Size(129, 25);
            this.ttc.TabIndex = 33;
            this.ttc.Text = "Time to Cook";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(405, 415);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(156, 50);
            this.exitButton.TabIndex = 32;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(214, 415);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(156, 50);
            this.clearButton.TabIndex = 31;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 415);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(156, 50);
            this.calculateButton.TabIndex = 30;
            this.calculateButton.Text = "Smelt";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // woodTrackBar
            // 
            this.woodTrackBar.Location = new System.Drawing.Point(281, 194);
            this.woodTrackBar.Name = "woodTrackBar";
            this.woodTrackBar.Size = new System.Drawing.Size(195, 45);
            this.woodTrackBar.TabIndex = 29;
            this.woodTrackBar.Scroll += new System.EventHandler(this.woodTrackBar_Scroll);
            // 
            // woodAmountLabel
            // 
            this.woodAmountLabel.AutoSize = true;
            this.woodAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.woodAmountLabel.Location = new System.Drawing.Point(308, 127);
            this.woodAmountLabel.Name = "woodAmountLabel";
            this.woodAmountLabel.Size = new System.Drawing.Size(144, 25);
            this.woodAmountLabel.TabIndex = 28;
            this.woodAmountLabel.Text = "Wood Amount:";
            // 
            // woodAmount
            // 
            this.woodAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.woodAmount.Location = new System.Drawing.Point(281, 158);
            this.woodAmount.Name = "woodAmount";
            this.woodAmount.Size = new System.Drawing.Size(195, 30);
            this.woodAmount.TabIndex = 26;
            this.woodAmount.Text = "0";
            this.woodAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.woodAmount_KeyPress);
            // 
            // oreTrackBar
            // 
            this.oreTrackBar.Location = new System.Drawing.Point(281, 79);
            this.oreTrackBar.Name = "oreTrackBar";
            this.oreTrackBar.Size = new System.Drawing.Size(195, 45);
            this.oreTrackBar.TabIndex = 25;
            this.oreTrackBar.Scroll += new System.EventHandler(this.oreTrackBar_Scroll);
            // 
            // oreAmountLabel
            // 
            this.oreAmountLabel.AutoSize = true;
            this.oreAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.oreAmountLabel.Location = new System.Drawing.Point(308, 12);
            this.oreAmountLabel.Name = "oreAmountLabel";
            this.oreAmountLabel.Size = new System.Drawing.Size(124, 25);
            this.oreAmountLabel.TabIndex = 24;
            this.oreAmountLabel.Text = "Ore Amount:";
            // 
            // oreAmount
            // 
            this.oreAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.oreAmount.Location = new System.Drawing.Point(281, 43);
            this.oreAmount.Name = "oreAmount";
            this.oreAmount.Size = new System.Drawing.Size(195, 30);
            this.oreAmount.TabIndex = 22;
            this.oreAmount.Text = "0";
            this.oreAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.oreAmount_KeyPress);
            // 
            // OreTypes
            // 
            this.OreTypes.Controls.Add(this.pictureBox3);
            this.OreTypes.Controls.Add(this.HQOre);
            this.OreTypes.Controls.Add(this.pictureBox1);
            this.OreTypes.Controls.Add(this.pictureBox2);
            this.OreTypes.Controls.Add(this.SulfurOre);
            this.OreTypes.Controls.Add(this.MetalOre);
            this.OreTypes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OreTypes.Location = new System.Drawing.Point(12, 12);
            this.OreTypes.Name = "OreTypes";
            this.OreTypes.Size = new System.Drawing.Size(217, 392);
            this.OreTypes.TabIndex = 23;
            this.OreTypes.TabStop = false;
            this.OreTypes.Text = "Ore Type";
            this.OreTypes.Enter += new System.EventHandler(this.OreTypes_Enter_1);
            // 
            // HQOre
            // 
            this.HQOre.AutoSize = true;
            this.HQOre.Location = new System.Drawing.Point(15, 275);
            this.HQOre.Name = "HQOre";
            this.HQOre.Size = new System.Drawing.Size(118, 17);
            this.HQOre.TabIndex = 2;
            this.HQOre.Text = "High Quality Ore";
            this.HQOre.UseVisualStyleBackColor = true;
            // 
            // SulfurOre
            // 
            this.SulfurOre.AutoSize = true;
            this.SulfurOre.Location = new System.Drawing.Point(15, 160);
            this.SulfurOre.Name = "SulfurOre";
            this.SulfurOre.Size = new System.Drawing.Size(82, 17);
            this.SulfurOre.TabIndex = 1;
            this.SulfurOre.Text = "Sulfur Ore";
            this.SulfurOre.UseVisualStyleBackColor = true;
            // 
            // MetalOre
            // 
            this.MetalOre.AutoSize = true;
            this.MetalOre.Checked = true;
            this.MetalOre.Location = new System.Drawing.Point(15, 35);
            this.MetalOre.Name = "MetalOre";
            this.MetalOre.Size = new System.Drawing.Size(80, 17);
            this.MetalOre.TabIndex = 0;
            this.MetalOre.TabStop = true;
            this.MetalOre.Text = "Metal Ore";
            this.MetalOre.UseVisualStyleBackColor = true;
            // 
            // highQuality
            // 
            this.highQuality.Image = global::RustFurnaceSimulator.Properties.Resources.High_Quality_Metal_icon;
            this.highQuality.Location = new System.Drawing.Point(414, 307);
            this.highQuality.Name = "highQuality";
            this.highQuality.Size = new System.Drawing.Size(62, 76);
            this.highQuality.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.highQuality.TabIndex = 38;
            this.highQuality.TabStop = false;
            this.highQuality.Visible = false;
            // 
            // sulfur
            // 
            this.sulfur.Image = global::RustFurnaceSimulator.Properties.Resources.Sulfur_icon;
            this.sulfur.Location = new System.Drawing.Point(405, 307);
            this.sulfur.Name = "sulfur";
            this.sulfur.Size = new System.Drawing.Size(71, 79);
            this.sulfur.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sulfur.TabIndex = 37;
            this.sulfur.TabStop = false;
            this.sulfur.Visible = false;
            // 
            // metalFragments
            // 
            this.metalFragments.Image = global::RustFurnaceSimulator.Properties.Resources.Metal_Fragments_icon;
            this.metalFragments.Location = new System.Drawing.Point(414, 310);
            this.metalFragments.Name = "metalFragments";
            this.metalFragments.Size = new System.Drawing.Size(62, 76);
            this.metalFragments.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.metalFragments.TabIndex = 27;
            this.metalFragments.TabStop = false;
            this.metalFragments.Visible = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::RustFurnaceSimulator.Properties.Resources.High_Quality_Metal_Ore_icon;
            this.pictureBox3.Location = new System.Drawing.Point(71, 298);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(62, 76);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RustFurnaceSimulator.Properties.Resources.Sulfur_Ore_icon;
            this.pictureBox1.Location = new System.Drawing.Point(71, 183);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(62, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::RustFurnaceSimulator.Properties.Resources.Metal_Ore_icon;
            this.pictureBox2.Location = new System.Drawing.Point(71, 58);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(62, 76);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            // 
            // RustFurnace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 478);
            this.Controls.Add(this.highQuality);
            this.Controls.Add(this.sulfur);
            this.Controls.Add(this.resultAmount);
            this.Controls.Add(this.Result);
            this.Controls.Add(this.metalFragments);
            this.Controls.Add(this.ttcValue);
            this.Controls.Add(this.ttc);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.woodTrackBar);
            this.Controls.Add(this.woodAmountLabel);
            this.Controls.Add(this.woodAmount);
            this.Controls.Add(this.oreTrackBar);
            this.Controls.Add(this.oreAmountLabel);
            this.Controls.Add(this.oreAmount);
            this.Controls.Add(this.OreTypes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RustFurnace";
            this.Text = "Rust Furnace Calculator";
            this.Load += new System.EventHandler(this.RustFurnace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.woodTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oreTrackBar)).EndInit();
            this.OreTypes.ResumeLayout(false);
            this.OreTypes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.highQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sulfur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.metalFragments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox highQuality;
        private System.Windows.Forms.PictureBox sulfur;
        private System.Windows.Forms.Label resultAmount;
        private System.Windows.Forms.Label Result;
        private System.Windows.Forms.PictureBox metalFragments;
        private System.Windows.Forms.Label ttcValue;
        private System.Windows.Forms.Label ttc;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.TrackBar woodTrackBar;
        private System.Windows.Forms.Label woodAmountLabel;
        private System.Windows.Forms.TextBox woodAmount;
        private System.Windows.Forms.TrackBar oreTrackBar;
        private System.Windows.Forms.Label oreAmountLabel;
        private System.Windows.Forms.TextBox oreAmount;
        private System.Windows.Forms.GroupBox OreTypes;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.RadioButton HQOre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.RadioButton SulfurOre;
        private System.Windows.Forms.RadioButton MetalOre;
    }
}

