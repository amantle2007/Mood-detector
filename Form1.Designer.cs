namespace MoodDetector
{
    partial class TfrmMood
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
            this.pnlMood = new System.Windows.Forms.Panel();
            this.cmbMood = new System.Windows.Forms.ComboBox();
            this.btnWord = new System.Windows.Forms.Button();
            this.lblMoodDetector = new System.Windows.Forms.Label();
            this.pnlMood.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMood
            // 
            this.pnlMood.Controls.Add(this.lblMoodDetector);
            this.pnlMood.Controls.Add(this.btnWord);
            this.pnlMood.Controls.Add(this.cmbMood);
            this.pnlMood.Location = new System.Drawing.Point(-2, 0);
            this.pnlMood.Name = "pnlMood";
            this.pnlMood.Size = new System.Drawing.Size(500, 509);
            this.pnlMood.TabIndex = 0;
            // 
            // cmbMood
            // 
            this.cmbMood.FormattingEnabled = true;
            this.cmbMood.Items.AddRange(new object[] {
            "Happy",
            "Sad",
            "Tired",
            "Bored",
            "Angry",
            "Loving",
            "Jealous"});
            this.cmbMood.Location = new System.Drawing.Point(42, 181);
            this.cmbMood.Name = "cmbMood";
            this.cmbMood.Size = new System.Drawing.Size(414, 24);
            this.cmbMood.TabIndex = 0;
            // 
            // btnWord
            // 
            this.btnWord.Font = new System.Drawing.Font("Kristen ITC", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWord.Location = new System.Drawing.Point(42, 226);
            this.btnWord.Name = "btnWord";
            this.btnWord.Size = new System.Drawing.Size(414, 56);
            this.btnWord.TabIndex = 1;
            this.btnWord.Text = "What\'s my word of the day?";
            this.btnWord.UseVisualStyleBackColor = true;
            this.btnWord.Click += new System.EventHandler(this.btnWord_Click);
            // 
            // lblMoodDetector
            // 
            this.lblMoodDetector.AutoSize = true;
            this.lblMoodDetector.Font = new System.Drawing.Font("Kristen ITC", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoodDetector.Location = new System.Drawing.Point(81, 34);
            this.lblMoodDetector.Name = "lblMoodDetector";
            this.lblMoodDetector.Size = new System.Drawing.Size(326, 51);
            this.lblMoodDetector.TabIndex = 2;
            this.lblMoodDetector.Text = "Mood Detector";
            // 
            // TfrmMood
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(495, 509);
            this.Controls.Add(this.pnlMood);
            this.Name = "TfrmMood";
            this.Text = "Mood Detector";
            this.pnlMood.ResumeLayout(false);
            this.pnlMood.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMood;
        private System.Windows.Forms.ComboBox cmbMood;
        private System.Windows.Forms.Label lblMoodDetector;
        private System.Windows.Forms.Button btnWord;
    }
}

