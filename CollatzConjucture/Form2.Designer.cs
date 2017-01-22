namespace CollatzConjucture
{
    partial class Form2
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
            this.SeriesStart = new System.Windows.Forms.TextBox();
            this.SeriesEnd = new System.Windows.Forms.TextBox();
            this.LoglblF2 = new System.Windows.Forms.TextBox();
            this.ComputeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SeriesStart
            // 
            this.SeriesStart.Location = new System.Drawing.Point(13, 13);
            this.SeriesStart.Multiline = true;
            this.SeriesStart.Name = "SeriesStart";
            this.SeriesStart.Size = new System.Drawing.Size(184, 66);
            this.SeriesStart.TabIndex = 0;
            this.SeriesStart.Text = "Starting Number";
            // 
            // SeriesEnd
            // 
            this.SeriesEnd.Location = new System.Drawing.Point(259, 13);
            this.SeriesEnd.Multiline = true;
            this.SeriesEnd.Name = "SeriesEnd";
            this.SeriesEnd.Size = new System.Drawing.Size(184, 66);
            this.SeriesEnd.TabIndex = 1;
            this.SeriesEnd.Text = "Ending Number";
            // 
            // LoglblF2
            // 
            this.LoglblF2.Location = new System.Drawing.Point(13, 177);
            this.LoglblF2.Multiline = true;
            this.LoglblF2.Name = "LoglblF2";
            this.LoglblF2.Size = new System.Drawing.Size(430, 184);
            this.LoglblF2.TabIndex = 2;
            // 
            // ComputeButton
            // 
            this.ComputeButton.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputeButton.Location = new System.Drawing.Point(171, 85);
            this.ComputeButton.Name = "ComputeButton";
            this.ComputeButton.Size = new System.Drawing.Size(113, 86);
            this.ComputeButton.TabIndex = 3;
            this.ComputeButton.Text = "Compute";
            this.ComputeButton.UseVisualStyleBackColor = true;
            this.ComputeButton.Click += new System.EventHandler(this.ComputeButton_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 373);
            this.Controls.Add(this.ComputeButton);
            this.Controls.Add(this.LoglblF2);
            this.Controls.Add(this.SeriesEnd);
            this.Controls.Add(this.SeriesStart);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SeriesStart;
        private System.Windows.Forms.TextBox SeriesEnd;
        public System.Windows.Forms.TextBox LoglblF2;
        private System.Windows.Forms.Button ComputeButton;
    }
}