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
            this.SuspendLayout();
            // 
            // InputNumberBox
            // 
            this.InputNumberBox.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputNumberBox.Location = new System.Drawing.Point(13, 13);
            this.InputNumberBox.Multiline = true;
            this.InputNumberBox.Name = "InputNumberBox";
            this.InputNumberBox.Size = new System.Drawing.Size(267, 67);
            this.InputNumberBox.TabIndex = 0;
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
            this.ResultLabel.Location = new System.Drawing.Point(12, 171);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(434, 377);
            this.ResultLabel.TabIndex = 2;
            // 
            // BenchmarkButton
            // 
            this.BenchmarkButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BenchmarkButton.Location = new System.Drawing.Point(120, 86);
            this.BenchmarkButton.Name = "BenchmarkButton";
            this.BenchmarkButton.Size = new System.Drawing.Size(160, 67);
            this.BenchmarkButton.TabIndex = 3;
            this.BenchmarkButton.Text = "Benchmark";
            this.BenchmarkButton.UseVisualStyleBackColor = true;
            this.BenchmarkButton.Click += new System.EventHandler(this.BenchmarkButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 557);
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
    }
}

