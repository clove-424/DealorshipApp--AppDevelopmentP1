namespace CarolineLoveProject1.View
{
    partial class InventoryDetailsForm
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
            leastExpTextBox = new TextBox();
            mostExpTextBox = new TextBox();
            bestMpgTextBox = new TextBox();
            worstMpgTextBox = new TextBox();
            inventoryTextBox = new RichTextBox();
            inventoryCountLabel = new Label();
            leastExpCarLabel = new Label();
            mostExpCarClick = new Label();
            bestMpgLabel = new Label();
            worstMpgLabel = new Label();
            showStatsButton = new Button();
            SuspendLayout();
            // 
            // leastExpTextBox
            // 
            leastExpTextBox.Location = new Point(34, 320);
            leastExpTextBox.Name = "leastExpTextBox";
            leastExpTextBox.ReadOnly = true;
            leastExpTextBox.Size = new Size(421, 27);
            leastExpTextBox.TabIndex = 3;
            // 
            // mostExpTextBox
            // 
            mostExpTextBox.Location = new Point(34, 402);
            mostExpTextBox.Name = "mostExpTextBox";
            mostExpTextBox.ReadOnly = true;
            mostExpTextBox.Size = new Size(421, 27);
            mostExpTextBox.TabIndex = 5;
            // 
            // bestMpgTextBox
            // 
            bestMpgTextBox.Location = new Point(34, 493);
            bestMpgTextBox.Name = "bestMpgTextBox";
            bestMpgTextBox.ReadOnly = true;
            bestMpgTextBox.Size = new Size(421, 27);
            bestMpgTextBox.TabIndex = 7;
            // 
            // worstMpgTextBox
            // 
            worstMpgTextBox.Location = new Point(34, 581);
            worstMpgTextBox.Name = "worstMpgTextBox";
            worstMpgTextBox.ReadOnly = true;
            worstMpgTextBox.Size = new Size(421, 27);
            worstMpgTextBox.TabIndex = 9;
            // 
            // inventoryTextBox
            // 
            inventoryTextBox.Location = new Point(34, 36);
            inventoryTextBox.Name = "inventoryTextBox";
            inventoryTextBox.ReadOnly = true;
            inventoryTextBox.Size = new Size(421, 188);
            inventoryTextBox.TabIndex = 1;
            inventoryTextBox.Text = "";
            // 
            // inventoryCountLabel
            // 
            inventoryCountLabel.AutoSize = true;
            inventoryCountLabel.Location = new Point(34, 13);
            inventoryCountLabel.Name = "inventoryCountLabel";
            inventoryCountLabel.Size = new Size(0, 20);
            inventoryCountLabel.TabIndex = 0;
            // 
            // leastExpCarLabel
            // 
            leastExpCarLabel.AutoSize = true;
            leastExpCarLabel.Location = new Point(34, 297);
            leastExpCarLabel.Name = "leastExpCarLabel";
            leastExpCarLabel.Size = new Size(141, 20);
            leastExpCarLabel.TabIndex = 2;
            leastExpCarLabel.Text = "Least Expensive Car:";
            // 
            // mostExpCarClick
            // 
            mostExpCarClick.AutoSize = true;
            mostExpCarClick.Location = new Point(34, 379);
            mostExpCarClick.Name = "mostExpCarClick";
            mostExpCarClick.Size = new Size(140, 20);
            mostExpCarClick.TabIndex = 4;
            mostExpCarClick.Text = "Most Expensive Car:";
            // 
            // bestMpgLabel
            // 
            bestMpgLabel.AutoSize = true;
            bestMpgLabel.Location = new Point(34, 466);
            bestMpgLabel.Name = "bestMpgLabel";
            bestMpgLabel.Size = new Size(75, 20);
            bestMpgLabel.TabIndex = 6;
            bestMpgLabel.Text = "Best MPG:";
            // 
            // worstMpgLabel
            // 
            worstMpgLabel.AutoSize = true;
            worstMpgLabel.Location = new Point(34, 558);
            worstMpgLabel.Name = "worstMpgLabel";
            worstMpgLabel.Size = new Size(85, 20);
            worstMpgLabel.TabIndex = 8;
            worstMpgLabel.Text = "Worst MPG:";
            // 
            // showStatsButton
            // 
            showStatsButton.Location = new Point(171, 255);
            showStatsButton.Name = "showStatsButton";
            showStatsButton.Size = new Size(133, 29);
            showStatsButton.TabIndex = 10;
            showStatsButton.Text = "Show Stats";
            showStatsButton.UseVisualStyleBackColor = true;
            showStatsButton.Click += ShowStatsButtonClick;
            // 
            // InventoryDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(487, 635);
            Controls.Add(showStatsButton);
            Controls.Add(worstMpgLabel);
            Controls.Add(bestMpgLabel);
            Controls.Add(mostExpCarClick);
            Controls.Add(leastExpCarLabel);
            Controls.Add(inventoryCountLabel);
            Controls.Add(inventoryTextBox);
            Controls.Add(worstMpgTextBox);
            Controls.Add(bestMpgTextBox);
            Controls.Add(mostExpTextBox);
            Controls.Add(leastExpTextBox);
            Name = "InventoryDetailsForm";
            Text = "InventoryDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox leastExpTextBox;
        private TextBox mostExpTextBox;
        private TextBox bestMpgTextBox;
        private TextBox worstMpgTextBox;
        private RichTextBox inventoryTextBox;
        private Label inventoryCountLabel;
        private Label leastExpCarLabel;
        private Label mostExpCarClick;
        private Label bestMpgLabel;
        private Label worstMpgLabel;
        private Button showStatsButton;
    }
}