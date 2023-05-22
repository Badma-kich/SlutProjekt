namespace SlutUppgift
{
    partial class Form3
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
            this.rollButton = new System.Windows.Forms.Button();
            this.numberOfRollsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.resultsListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRollsNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // rollButton
            // 
            this.rollButton.Location = new System.Drawing.Point(12, 108);
            this.rollButton.Name = "rollButton";
            this.rollButton.Size = new System.Drawing.Size(120, 36);
            this.rollButton.TabIndex = 0;
            this.rollButton.Text = "Kasta";
            this.rollButton.UseVisualStyleBackColor = true;
            this.rollButton.Click += new System.EventHandler(this.rollButton_Click);
            // 
            // numberOfRollsNumericUpDown
            // 
            this.numberOfRollsNumericUpDown.Location = new System.Drawing.Point(12, 74);
            this.numberOfRollsNumericUpDown.Name = "numberOfRollsNumericUpDown";
            this.numberOfRollsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.numberOfRollsNumericUpDown.TabIndex = 1;
            // 
            // resultsListBox
            // 
            this.resultsListBox.FormattingEnabled = true;
            this.resultsListBox.ItemHeight = 15;
            this.resultsListBox.Location = new System.Drawing.Point(148, 65);
            this.resultsListBox.Name = "resultsListBox";
            this.resultsListBox.Size = new System.Drawing.Size(191, 94);
            this.resultsListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Hur många tärningar vill du kasta?";
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 181);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultsListBox);
            this.Controls.Add(this.numberOfRollsNumericUpDown);
            this.Controls.Add(this.rollButton);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRollsNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button rollButton;
        private NumericUpDown numberOfRollsNumericUpDown;
        private ListBox resultsListBox;
        private Label label1;
    }
}