namespace SlutUppgift
{
    partial class Form6
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
            this.decimalTextBox = new System.Windows.Forms.TextBox();
            this.baseTextBox = new System.Windows.Forms.TextBox();
            this.convertButton = new System.Windows.Forms.Button();
            this.resultLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // decimalTextBox
            // 
            this.decimalTextBox.Location = new System.Drawing.Point(245, 34);
            this.decimalTextBox.Name = "decimalTextBox";
            this.decimalTextBox.Size = new System.Drawing.Size(100, 23);
            this.decimalTextBox.TabIndex = 0;
            // 
            // baseTextBox
            // 
            this.baseTextBox.Location = new System.Drawing.Point(245, 74);
            this.baseTextBox.Name = "baseTextBox";
            this.baseTextBox.Size = new System.Drawing.Size(100, 23);
            this.baseTextBox.TabIndex = 1;
            // 
            // convertButton
            // 
            this.convertButton.Location = new System.Drawing.Point(140, 114);
            this.convertButton.Name = "convertButton";
            this.convertButton.Size = new System.Drawing.Size(75, 23);
            this.convertButton.TabIndex = 2;
            this.convertButton.Text = "Konvertera";
            this.convertButton.UseVisualStyleBackColor = true;
            this.convertButton.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // resultLabel
            // 
            this.resultLabel.AutoSize = true;
            this.resultLabel.Location = new System.Drawing.Point(12, 140);
            this.resultLabel.Name = "resultLabel";
            this.resultLabel.Size = new System.Drawing.Size(0, 15);
            this.resultLabel.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vilket tal i talbasen 10 vill du omvandla?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Vilken talbas vill du omvandla till?";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 213);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.resultLabel);
            this.Controls.Add(this.convertButton);
            this.Controls.Add(this.baseTextBox);
            this.Controls.Add(this.decimalTextBox);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox decimalTextBox;
        private TextBox baseTextBox;
        private Button convertButton;
        private Label resultLabel;
        private Label label1;
        private Label label2;
    }
}