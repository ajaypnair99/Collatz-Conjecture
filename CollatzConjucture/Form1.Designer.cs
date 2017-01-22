namespace CollatzConjucture
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
            this.InputNumberBox = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.BenchmarkButton = new System.Windows.Forms.Button();
            this.TextColorLabel = new System.Windows.Forms.Label();
            this.RedRadioButton = new System.Windows.Forms.RadioButton();
            this.GreenRadioButton = new System.Windows.Forms.RadioButton();
            this.YelloRadioButton = new System.Windows.Forms.RadioButton();
            this.LogBackColor = new System.Windows.Forms.Label();
            this.BackcolorBlack = new System.Windows.Forms.RadioButton();
            this.BackColorWhite = new System.Windows.Forms.RadioButton();
            this.PreciseTiming = new System.Windows.Forms.CheckBox();
            this.SeriesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputNumberBox
            // 
            this.InputNumberBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberBox.ForeColor = System.Drawing.Color.Red;
            this.InputNumberBox.Location = new System.Drawing.Point(13, 13);
            this.InputNumberBox.Multiline = true;
            this.InputNumberBox.Name = "InputNumberBox";
            this.InputNumberBox.Size = new System.Drawing.Size(267, 67);
            this.InputNumberBox.TabIndex = 0;
            this.InputNumberBox.Text = "Enter an integer";
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeButton.Location = new System.Drawing.Point(286, 13);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(160, 67);
            this.ComputeButton.TabIndex = 1;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ResultLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultLabel.ForeColor = System.Drawing.Color.Red;
            this.ResultLabel.Location = new System.Drawing.Point(12, 220);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(434, 328);
            this.ResultLabel.TabIndex = 2;
            this.ResultLabel.Text = "Log :";
            // 
            // BenchmarkButton
            // 
            this.BenchmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenchmarkButton.Location = new System.Drawing.Point(12, 86);
            this.BenchmarkButton.Name = "BenchmarkButton";
            this.BenchmarkButton.Size = new System.Drawing.Size(160, 67);
            this.BenchmarkButton.TabIndex = 3;
            this.BenchmarkButton.Text = "Benchmark";
            this.BenchmarkButton.UseVisualStyleBackColor = true;
            this.BenchmarkButton.Click += new System.EventHandler(this.BenchmarkButton_Click);
            // 
            // TextColorLabel
            // 
            this.TextColorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextColorLabel.Location = new System.Drawing.Point(178, 86);
            this.TextColorLabel.Name = "TextColorLabel";
            this.TextColorLabel.Size = new System.Drawing.Size(100, 30);
            this.TextColorLabel.TabIndex = 4;
            this.TextColorLabel.Text = "Text Color";
            // 
            // RedRadioButton
            // 
            this.RedRadioButton.AutoSize = true;
            this.RedRadioButton.Location = new System.Drawing.Point(181, 120);
            this.RedRadioButton.Name = "RedRadioButton";
            this.RedRadioButton.Size = new System.Drawing.Size(45, 17);
            this.RedRadioButton.TabIndex = 5;
            this.RedRadioButton.TabStop = true;
            this.RedRadioButton.Text = "Red";
            this.RedRadioButton.UseVisualStyleBackColor = true;
            this.RedRadioButton.CheckedChanged += new System.EventHandler(this.RedRadioButton_CheckedChanged);
            // 
            // GreenRadioButton
            // 
            this.GreenRadioButton.AutoSize = true;
            this.GreenRadioButton.Location = new System.Drawing.Point(249, 120);
            this.GreenRadioButton.Name = "GreenRadioButton";
            this.GreenRadioButton.Size = new System.Drawing.Size(54, 17);
            this.GreenRadioButton.TabIndex = 6;
            this.GreenRadioButton.TabStop = true;
            this.GreenRadioButton.Text = "Green";
            this.GreenRadioButton.UseVisualStyleBackColor = true;
            this.GreenRadioButton.CheckedChanged += new System.EventHandler(this.GreenRadioButton_CheckedChanged);
            // 
            // YelloRadioButton
            // 
            this.YelloRadioButton.AutoSize = true;
            this.YelloRadioButton.Location = new System.Drawing.Point(326, 120);
            this.YelloRadioButton.Name = "YelloRadioButton";
            this.YelloRadioButton.Size = new System.Drawing.Size(56, 17);
            this.YelloRadioButton.TabIndex = 7;
            this.YelloRadioButton.TabStop = true;
            this.YelloRadioButton.Text = "Yellow";
            this.YelloRadioButton.UseVisualStyleBackColor = true;
            this.YelloRadioButton.CheckedChanged += new System.EventHandler(this.YelloRadioButton_CheckedChanged);
            // 
            // LogBackColor
            // 
            this.LogBackColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogBackColor.Location = new System.Drawing.Point(15, 168);
            this.LogBackColor.Name = "LogBackColor";
            this.LogBackColor.Size = new System.Drawing.Size(100, 30);
            this.LogBackColor.TabIndex = 8;
            this.LogBackColor.Text = "Back Color";
            // 
            // BackcolorBlack
            // 
            this.BackcolorBlack.AutoSize = true;
            this.BackcolorBlack.Location = new System.Drawing.Point(127, 170);
            this.BackcolorBlack.Name = "BackcolorBlack";
            this.BackcolorBlack.Size = new System.Drawing.Size(52, 17);
            this.BackcolorBlack.TabIndex = 9;
            this.BackcolorBlack.TabStop = true;
            this.BackcolorBlack.Text = "Black";
            this.BackcolorBlack.UseVisualStyleBackColor = true;
            this.BackcolorBlack.CheckedChanged += new System.EventHandler(this.BackcolorBlack_CheckedChanged);
            // 
            // BackColorWhite
            // 
            this.BackColorWhite.AutoSize = true;
            this.BackColorWhite.Location = new System.Drawing.Point(185, 170);
            this.BackColorWhite.Name = "BackColorWhite";
            this.BackColorWhite.Size = new System.Drawing.Size(53, 17);
            this.BackColorWhite.TabIndex = 10;
            this.BackColorWhite.TabStop = true;
            this.BackColorWhite.Text = "White";
            this.BackColorWhite.UseVisualStyleBackColor = true;
            this.BackColorWhite.CheckedChanged += new System.EventHandler(this.BackColorWhite_CheckedChanged);
            // 
            // PreciseTiming
            // 
            this.PreciseTiming.Location = new System.Drawing.Point(270, 170);
            this.PreciseTiming.Name = "PreciseTiming";
            this.PreciseTiming.Size = new System.Drawing.Size(104, 24);
            this.PreciseTiming.TabIndex = 11;
            this.PreciseTiming.Text = "Precise Time ";
            this.PreciseTiming.UseVisualStyleBackColor = true;
            // 
            // SeriesButton
            // 
            this.SeriesButton.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SeriesButton.Location = new System.Drawing.Point(380, 143);
            this.SeriesButton.Name = "SeriesButton";
            this.SeriesButton.Size = new System.Drawing.Size(65, 55);
            this.SeriesButton.TabIndex = 12;
            this.SeriesButton.Text = "Series";
            this.SeriesButton.UseVisualStyleBackColor = true;
            this.SeriesButton.Click += new System.EventHandler(this.SeriesButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 557);
            this.Controls.Add(this.SeriesButton);
            this.Controls.Add(this.PreciseTiming);
            this.Controls.Add(this.BackColorWhite);
            this.Controls.Add(this.BackcolorBlack);
            this.Controls.Add(this.LogBackColor);
            this.Controls.Add(this.YelloRadioButton);
            this.Controls.Add(this.GreenRadioButton);
            this.Controls.Add(this.RedRadioButton);
            this.Controls.Add(this.TextColorLabel);
            this.Controls.Add(this.BenchmarkButton);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.InputNumberBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox InputNumberBox;
        private System.Windows.Forms.Button ComputeButton;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.Button BenchmarkButton;
        private System.Windows.Forms.Label TextColorLabel;
        private System.Windows.Forms.RadioButton RedRadioButton;
        private System.Windows.Forms.RadioButton GreenRadioButton;
        private System.Windows.Forms.RadioButton YelloRadioButton;
        private System.Windows.Forms.Label LogBackColor;
        private System.Windows.Forms.RadioButton BackcolorBlack;
        private System.Windows.Forms.RadioButton BackColorWhite;
        private System.Windows.Forms.CheckBox PreciseTiming;
        private System.Windows.Forms.Button SeriesButton;
    }
}

