namespace SlutUppgift
{
    partial class Form5
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
            this.upperLimitTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.runButton = new System.Windows.Forms.Button();
            this.testNumberTextBox = new System.Windows.Forms.TextBox();
            this.testButton = new System.Windows.Forms.Button();
            this.indexTextBox = new System.Windows.Forms.TextBox();
            this.showButton = new System.Windows.Forms.Button();
            this.showAllButton = new System.Windows.Forms.Button();
            this.runResultLabel = new System.Windows.Forms.Label();
            this.testResultLabel = new System.Windows.Forms.Label();
            this.showResultLabel = new System.Windows.Forms.Label();
            this.allPrimesRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // upperLimitTextBox
            // 
            this.upperLimitTextBox.Location = new System.Drawing.Point(326, 48);
            this.upperLimitTextBox.Name = "upperLimitTextBox";
            this.upperLimitTextBox.Size = new System.Drawing.Size(100, 23);
            this.upperLimitTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(326, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Övre gränsen";
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(326, 77);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 2;
            this.runButton.Text = "Kör";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // testNumberTextBox
            // 
            this.testNumberTextBox.Location = new System.Drawing.Point(326, 161);
            this.testNumberTextBox.Name = "testNumberTextBox";
            this.testNumberTextBox.Size = new System.Drawing.Size(100, 23);
            this.testNumberTextBox.TabIndex = 3;
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(326, 190);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 4;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // indexTextBox
            // 
            this.indexTextBox.Location = new System.Drawing.Point(326, 267);
            this.indexTextBox.Name = "indexTextBox";
            this.indexTextBox.Size = new System.Drawing.Size(100, 23);
            this.indexTextBox.TabIndex = 5;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(326, 296);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 6;
            this.showButton.Text = "Visa";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(21, 121);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(114, 23);
            this.showAllButton.TabIndex = 7;
            this.showAllButton.Text = "Visa alla primtal";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // runResultLabel
            // 
            this.runResultLabel.AutoSize = true;
            this.runResultLabel.Location = new System.Drawing.Point(21, 48);
            this.runResultLabel.Name = "runResultLabel";
            this.runResultLabel.Size = new System.Drawing.Size(0, 15);
            this.runResultLabel.TabIndex = 8;
            // 
            // testResultLabel
            // 
            this.testResultLabel.AutoSize = true;
            this.testResultLabel.Location = new System.Drawing.Point(326, 216);
            this.testResultLabel.Name = "testResultLabel";
            this.testResultLabel.Size = new System.Drawing.Size(0, 15);
            this.testResultLabel.TabIndex = 9;
            // 
            // showResultLabel
            // 
            this.showResultLabel.AutoSize = true;
            this.showResultLabel.Location = new System.Drawing.Point(326, 324);
            this.showResultLabel.Name = "showResultLabel";
            this.showResultLabel.Size = new System.Drawing.Size(0, 15);
            this.showResultLabel.TabIndex = 10;
            // 
            // allPrimesRichTextBox
            // 
            this.allPrimesRichTextBox.Location = new System.Drawing.Point(21, 150);
            this.allPrimesRichTextBox.Name = "allPrimesRichTextBox";
            this.allPrimesRichTextBox.ReadOnly = true;
            this.allPrimesRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.allPrimesRichTextBox.Size = new System.Drawing.Size(255, 189);
            this.allPrimesRichTextBox.TabIndex = 11;
            this.allPrimesRichTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(326, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 15);
            this.label2.TabIndex = 12;
            this.label2.Text = "Undersök om ett tal är ett primtal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(326, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(230, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ange indexet för det primtal som ska visas";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 361);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.allPrimesRichTextBox);
            this.Controls.Add(this.showResultLabel);
            this.Controls.Add(this.testResultLabel);
            this.Controls.Add(this.runResultLabel);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.indexTextBox);
            this.Controls.Add(this.testButton);
            this.Controls.Add(this.testNumberTextBox);
            this.Controls.Add(this.runButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.upperLimitTextBox);
            this.Name = "Form5";
            this.Text = "Form5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox upperLimitTextBox;
        private Label label1;
        private Button runButton;
        private TextBox testNumberTextBox;
        private Button testButton;
        private TextBox indexTextBox;
        private Button showButton;
        private Button showAllButton;
        private Label runResultLabel;
        private Label testResultLabel;
        private Label showResultLabel;
        private RichTextBox allPrimesRichTextBox;
        private Label label2;
        private Label label3;
    }
}