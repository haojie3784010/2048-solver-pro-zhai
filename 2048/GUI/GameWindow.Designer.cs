namespace GUI
{
	partial class GameWindow
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
            this.boardContainer = new System.Windows.Forms.Panel();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioRandom = new System.Windows.Forms.RadioButton();
            this.radioMonteCarlo = new System.Windows.Forms.RadioButton();
            this.radioExpectimax = new System.Windows.Forms.RadioButton();
            this.groupMonteCarlo = new System.Windows.Forms.GroupBox();
            this.numericMonteCarloTime = new System.Windows.Forms.NumericUpDown();
            this.numericMonteCarloCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.radioMonteCarloTime = new System.Windows.Forms.RadioButton();
            this.radioMonteCarloCount = new System.Windows.Forms.RadioButton();
            this.groupExpectimax = new System.Windows.Forms.GroupBox();
            this.numericExpectimaxDepth = new System.Windows.Forms.NumericUpDown();
            this.radioExpectimaxDepth = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.numericLimitSimulationSpeed = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.checkBoxLimitSimulationSpeed = new System.Windows.Forms.CheckBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupMonteCarlo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonteCarloTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonteCarloCount)).BeginInit();
            this.groupExpectimax.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExpectimaxDepth)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimitSimulationSpeed)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // boardContainer
            // 
            this.boardContainer.Location = new System.Drawing.Point(334, 61);
            this.boardContainer.Margin = new System.Windows.Forms.Padding(2);
            this.boardContainer.Name = "boardContainer";
            this.boardContainer.Size = new System.Drawing.Size(450, 450);
            this.boardContainer.TabIndex = 0;
            this.boardContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.boardContainer_Paint);
            // 
            // scoreLabel
            // 
            this.scoreLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.scoreLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.scoreLabel.Location = new System.Drawing.Point(13, 18);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(231, 30);
            this.scoreLabel.TabIndex = 1;
            this.scoreLabel.Text = "Score: 0";
            // 
            // nameLabel
            // 
            this.nameLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.nameLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.nameLabel.Location = new System.Drawing.Point(0, 0);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(319, 43);
            this.nameLabel.TabIndex = 2;
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.nameLabel.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioRandom);
            this.groupBox1.Controls.Add(this.radioMonteCarlo);
            this.groupBox1.Controls.Add(this.radioExpectimax);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Location = new System.Drawing.Point(0, 180);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(319, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Algorithm type";
            // 
            // radioRandom
            // 
            this.radioRandom.AutoSize = true;
            this.radioRandom.Location = new System.Drawing.Point(14, 64);
            this.radioRandom.Margin = new System.Windows.Forms.Padding(2);
            this.radioRandom.Name = "radioRandom";
            this.radioRandom.Size = new System.Drawing.Size(59, 16);
            this.radioRandom.TabIndex = 2;
            this.radioRandom.Text = "Random";
            this.radioRandom.UseVisualStyleBackColor = true;
            this.radioRandom.CheckedChanged += new System.EventHandler(this.radioRandom_CheckedChanged);
            // 
            // radioMonteCarlo
            // 
            this.radioMonteCarlo.AutoSize = true;
            this.radioMonteCarlo.Location = new System.Drawing.Point(14, 44);
            this.radioMonteCarlo.Margin = new System.Windows.Forms.Padding(2);
            this.radioMonteCarlo.Name = "radioMonteCarlo";
            this.radioMonteCarlo.Size = new System.Drawing.Size(149, 16);
            this.radioMonteCarlo.TabIndex = 1;
            this.radioMonteCarlo.Text = "MonteCarlo Pure Seach";
            this.radioMonteCarlo.UseVisualStyleBackColor = true;
            this.radioMonteCarlo.CheckedChanged += new System.EventHandler(this.radioMonteCarlo_CheckedChanged);
            // 
            // radioExpectimax
            // 
            this.radioExpectimax.AutoSize = true;
            this.radioExpectimax.Checked = true;
            this.radioExpectimax.Location = new System.Drawing.Point(14, 24);
            this.radioExpectimax.Margin = new System.Windows.Forms.Padding(2);
            this.radioExpectimax.Name = "radioExpectimax";
            this.radioExpectimax.Size = new System.Drawing.Size(83, 16);
            this.radioExpectimax.TabIndex = 0;
            this.radioExpectimax.TabStop = true;
            this.radioExpectimax.Text = "ExpectiMax";
            this.radioExpectimax.UseVisualStyleBackColor = true;
            this.radioExpectimax.CheckedChanged += new System.EventHandler(this.radioExpectimax_CheckedChanged);
            // 
            // groupMonteCarlo
            // 
            this.groupMonteCarlo.Controls.Add(this.numericMonteCarloTime);
            this.groupMonteCarlo.Controls.Add(this.numericMonteCarloCount);
            this.groupMonteCarlo.Controls.Add(this.label1);
            this.groupMonteCarlo.Controls.Add(this.radioMonteCarloTime);
            this.groupMonteCarlo.Controls.Add(this.radioMonteCarloCount);
            this.groupMonteCarlo.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupMonteCarlo.Location = new System.Drawing.Point(0, 266);
            this.groupMonteCarlo.Margin = new System.Windows.Forms.Padding(2);
            this.groupMonteCarlo.Name = "groupMonteCarlo";
            this.groupMonteCarlo.Padding = new System.Windows.Forms.Padding(2);
            this.groupMonteCarlo.Size = new System.Drawing.Size(319, 69);
            this.groupMonteCarlo.TabIndex = 4;
            this.groupMonteCarlo.TabStop = false;
            this.groupMonteCarlo.Text = "Depth settings";
            this.groupMonteCarlo.Visible = false;
            // 
            // numericMonteCarloTime
            // 
            this.numericMonteCarloTime.Location = new System.Drawing.Point(185, 44);
            this.numericMonteCarloTime.Margin = new System.Windows.Forms.Padding(2);
            this.numericMonteCarloTime.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMonteCarloTime.Name = "numericMonteCarloTime";
            this.numericMonteCarloTime.Size = new System.Drawing.Size(50, 21);
            this.numericMonteCarloTime.TabIndex = 6;
            this.numericMonteCarloTime.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // numericMonteCarloCount
            // 
            this.numericMonteCarloCount.Location = new System.Drawing.Point(185, 23);
            this.numericMonteCarloCount.Margin = new System.Windows.Forms.Padding(2);
            this.numericMonteCarloCount.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericMonteCarloCount.Name = "numericMonteCarloCount";
            this.numericMonteCarloCount.Size = new System.Drawing.Size(50, 21);
            this.numericMonteCarloCount.TabIndex = 5;
            this.numericMonteCarloCount.Value = new decimal(new int[] {
            400,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 12);
            this.label1.TabIndex = 4;
            this.label1.Text = "/ms";
            // 
            // radioMonteCarloTime
            // 
            this.radioMonteCarloTime.AutoSize = true;
            this.radioMonteCarloTime.Location = new System.Drawing.Point(14, 44);
            this.radioMonteCarloTime.Margin = new System.Windows.Forms.Padding(2);
            this.radioMonteCarloTime.Name = "radioMonteCarloTime";
            this.radioMonteCarloTime.Size = new System.Drawing.Size(161, 16);
            this.radioMonteCarloTime.TabIndex = 1;
            this.radioMonteCarloTime.TabStop = true;
            this.radioMonteCarloTime.Text = "Fixed random walks time";
            this.radioMonteCarloTime.UseVisualStyleBackColor = true;
            // 
            // radioMonteCarloCount
            // 
            this.radioMonteCarloCount.AutoSize = true;
            this.radioMonteCarloCount.Checked = true;
            this.radioMonteCarloCount.Location = new System.Drawing.Point(14, 23);
            this.radioMonteCarloCount.Margin = new System.Windows.Forms.Padding(2);
            this.radioMonteCarloCount.Name = "radioMonteCarloCount";
            this.radioMonteCarloCount.Size = new System.Drawing.Size(167, 16);
            this.radioMonteCarloCount.TabIndex = 0;
            this.radioMonteCarloCount.TabStop = true;
            this.radioMonteCarloCount.Text = "Fixed random walks count";
            this.radioMonteCarloCount.UseVisualStyleBackColor = true;
            // 
            // groupExpectimax
            // 
            this.groupExpectimax.Controls.Add(this.numericExpectimaxDepth);
            this.groupExpectimax.Controls.Add(this.radioExpectimaxDepth);
            this.groupExpectimax.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupExpectimax.Location = new System.Drawing.Point(0, 335);
            this.groupExpectimax.Margin = new System.Windows.Forms.Padding(2);
            this.groupExpectimax.Name = "groupExpectimax";
            this.groupExpectimax.Padding = new System.Windows.Forms.Padding(2);
            this.groupExpectimax.Size = new System.Drawing.Size(319, 48);
            this.groupExpectimax.TabIndex = 5;
            this.groupExpectimax.TabStop = false;
            this.groupExpectimax.Text = "Depth settings";
            // 
            // numericExpectimaxDepth
            // 
            this.numericExpectimaxDepth.Location = new System.Drawing.Point(185, 23);
            this.numericExpectimaxDepth.Margin = new System.Windows.Forms.Padding(2);
            this.numericExpectimaxDepth.Name = "numericExpectimaxDepth";
            this.numericExpectimaxDepth.Size = new System.Drawing.Size(50, 21);
            this.numericExpectimaxDepth.TabIndex = 6;
            this.numericExpectimaxDepth.Value = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numericExpectimaxDepth.ValueChanged += new System.EventHandler(this.numericExpectimaxDepth_ValueChanged);
            // 
            // radioExpectimaxDepth
            // 
            this.radioExpectimaxDepth.AutoSize = true;
            this.radioExpectimaxDepth.Checked = true;
            this.radioExpectimaxDepth.Location = new System.Drawing.Point(14, 23);
            this.radioExpectimaxDepth.Margin = new System.Windows.Forms.Padding(2);
            this.radioExpectimaxDepth.Name = "radioExpectimaxDepth";
            this.radioExpectimaxDepth.Size = new System.Drawing.Size(113, 16);
            this.radioExpectimaxDepth.TabIndex = 0;
            this.radioExpectimaxDepth.TabStop = true;
            this.radioExpectimaxDepth.Text = "Fixed max depth";
            this.radioExpectimaxDepth.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupExpectimax);
            this.panel1.Controls.Add(this.groupMonteCarlo);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox5);
            this.panel1.Controls.Add(this.nameLabel);
            this.panel1.Location = new System.Drawing.Point(11, 11);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(319, 500);
            this.panel1.TabIndex = 3;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.numericLimitSimulationSpeed);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.checkBoxLimitSimulationSpeed);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(0, 135);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(319, 45);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Speed settings";
            // 
            // numericLimitSimulationSpeed
            // 
            this.numericLimitSimulationSpeed.Location = new System.Drawing.Point(185, 16);
            this.numericLimitSimulationSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.numericLimitSimulationSpeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericLimitSimulationSpeed.Name = "numericLimitSimulationSpeed";
            this.numericLimitSimulationSpeed.Size = new System.Drawing.Size(50, 21);
            this.numericLimitSimulationSpeed.TabIndex = 7;
            this.numericLimitSimulationSpeed.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.numericLimitSimulationSpeed.ValueChanged += new System.EventHandler(this.numericLimitSimulationSpeed_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "/ms";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // checkBoxLimitSimulationSpeed
            // 
            this.checkBoxLimitSimulationSpeed.AutoSize = true;
            this.checkBoxLimitSimulationSpeed.Location = new System.Drawing.Point(14, 16);
            this.checkBoxLimitSimulationSpeed.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxLimitSimulationSpeed.Name = "checkBoxLimitSimulationSpeed";
            this.checkBoxLimitSimulationSpeed.Size = new System.Drawing.Size(144, 16);
            this.checkBoxLimitSimulationSpeed.TabIndex = 1;
            this.checkBoxLimitSimulationSpeed.Text = "Limit movement speed";
            this.checkBoxLimitSimulationSpeed.UseVisualStyleBackColor = true;
            this.checkBoxLimitSimulationSpeed.CheckedChanged += new System.EventHandler(this.checkBoxLimitSimulationSpeed_CheckedChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.buttonPause);
            this.groupBox5.Controls.Add(this.buttonStop);
            this.groupBox5.Controls.Add(this.buttonStart);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox5.Location = new System.Drawing.Point(0, 43);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox5.Size = new System.Drawing.Size(319, 92);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Button";
            // 
            // buttonPause
            // 
            this.buttonPause.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonPause.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPause.Location = new System.Drawing.Point(130, 20);
            this.buttonPause.Margin = new System.Windows.Forms.Padding(2);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(62, 66);
            this.buttonPause.TabIndex = 2;
            this.buttonPause.Text = "PAUSE";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Visible = false;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStop.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStop.Location = new System.Drawing.Point(68, 20);
            this.buttonStop.Margin = new System.Windows.Forms.Padding(2);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(62, 66);
            this.buttonStop.TabIndex = 1;
            this.buttonStop.Text = "RETURN";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Visible = false;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonStart.Location = new System.Drawing.Point(6, 20);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(62, 66);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "START";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.scoreLabel);
            this.groupBox2.Location = new System.Drawing.Point(334, 11);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(248, 46);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Score";
            // 
            // GameWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(795, 580);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.boardContainer);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GameWindow";
            this.Text = "2048-solver pro(zhai)";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameWindow_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupMonteCarlo.ResumeLayout(false);
            this.groupMonteCarlo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonteCarloTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMonteCarloCount)).EndInit();
            this.groupExpectimax.ResumeLayout(false);
            this.groupExpectimax.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericExpectimaxDepth)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLimitSimulationSpeed)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel boardContainer;
		private System.Windows.Forms.Label scoreLabel;
		private System.Windows.Forms.Label nameLabel;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioExpectimax;
		private System.Windows.Forms.RadioButton radioRandom;
		private System.Windows.Forms.RadioButton radioMonteCarlo;
		private System.Windows.Forms.GroupBox groupMonteCarlo;
		private System.Windows.Forms.RadioButton radioMonteCarloTime;
		private System.Windows.Forms.RadioButton radioMonteCarloCount;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.GroupBox groupExpectimax;
		private System.Windows.Forms.RadioButton radioExpectimaxDepth;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.CheckBox checkBoxLimitSimulationSpeed;
		private System.Windows.Forms.NumericUpDown numericMonteCarloTime;
		private System.Windows.Forms.NumericUpDown numericMonteCarloCount;
		private System.Windows.Forms.NumericUpDown numericExpectimaxDepth;
		private System.Windows.Forms.NumericUpDown numericLimitSimulationSpeed;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.Button buttonPause;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}