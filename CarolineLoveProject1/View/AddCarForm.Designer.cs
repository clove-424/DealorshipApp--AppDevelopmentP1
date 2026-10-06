namespace CarolineLoveProject1.View
{
    partial class AddCarForm
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
            addCarMenuStrip = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            backMenuItem = new ToolStripMenuItem();
            makeLabel = new Label();
            modelLabel = new Label();
            mpgLabel = new Label();
            priceLabel = new Label();
            makeTextBox = new TextBox();
            modelTextBox = new TextBox();
            mpgTextBox = new TextBox();
            priceTextBox = new TextBox();
            addCarButton = new Button();
            addCarMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // addCarMenuStrip
            // 
            addCarMenuStrip.ImageScalingSize = new Size(20, 20);
            addCarMenuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            addCarMenuStrip.Location = new Point(0, 0);
            addCarMenuStrip.Name = "addCarMenuStrip";
            addCarMenuStrip.Size = new Size(652, 28);
            addCarMenuStrip.TabIndex = 0;
            addCarMenuStrip.Text = "addCarMenuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { backMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // backMenuItem
            // 
            backMenuItem.Name = "backMenuItem";
            backMenuItem.Size = new Size(123, 26);
            backMenuItem.Text = "Back";
            backMenuItem.Click += BackToMainMenuClick;
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(220, 85);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(48, 20);
            makeLabel.TabIndex = 1;
            makeLabel.Text = "Make:";
            // 
            // modelLabel
            // 
            modelLabel.AutoSize = true;
            modelLabel.Location = new Point(220, 139);
            modelLabel.Name = "modelLabel";
            modelLabel.Size = new Size(55, 20);
            modelLabel.TabIndex = 3;
            modelLabel.Text = "Model:";
            // 
            // mpgLabel
            // 
            mpgLabel.AutoSize = true;
            mpgLabel.Location = new Point(220, 196);
            mpgLabel.Name = "mpgLabel";
            mpgLabel.Size = new Size(43, 20);
            mpgLabel.TabIndex = 5;
            mpgLabel.Text = "MPG:";
            // 
            // priceLabel
            // 
            priceLabel.AutoSize = true;
            priceLabel.Location = new Point(220, 258);
            priceLabel.Name = "priceLabel";
            priceLabel.Size = new Size(44, 20);
            priceLabel.TabIndex = 7;
            priceLabel.Text = "Price:";
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(303, 82);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(125, 27);
            makeTextBox.TabIndex = 2;
            // 
            // modelTextBox
            // 
            modelTextBox.Location = new Point(303, 136);
            modelTextBox.Name = "modelTextBox";
            modelTextBox.Size = new Size(125, 27);
            modelTextBox.TabIndex = 4;
            // 
            // mpgTextBox
            // 
            mpgTextBox.Location = new Point(303, 193);
            mpgTextBox.Name = "mpgTextBox";
            mpgTextBox.Size = new Size(125, 27);
            mpgTextBox.TabIndex = 6;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(303, 255);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(125, 27);
            priceTextBox.TabIndex = 8;
            // 
            // addCarButton
            // 
            addCarButton.Location = new Point(220, 342);
            addCarButton.Name = "addCarButton";
            addCarButton.Size = new Size(208, 29);
            addCarButton.TabIndex = 9;
            addCarButton.Text = "Add To Inventory";
            addCarButton.UseVisualStyleBackColor = true;
            addCarButton.Click += AddCarButtonClick;
            // 
            // AddCarForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 423);
            Controls.Add(addCarButton);
            Controls.Add(priceTextBox);
            Controls.Add(mpgTextBox);
            Controls.Add(modelTextBox);
            Controls.Add(makeTextBox);
            Controls.Add(priceLabel);
            Controls.Add(mpgLabel);
            Controls.Add(modelLabel);
            Controls.Add(makeLabel);
            Controls.Add(addCarMenuStrip);
            MainMenuStrip = addCarMenuStrip;
            Name = "AddCarForm";
            Text = "AddCarForm";
            addCarMenuStrip.ResumeLayout(false);
            addCarMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip addCarMenuStrip;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem backMenuItem;
        private Label makeLabel;
        private Label modelLabel;
        private Label mpgLabel;
        private Label priceLabel;
        private TextBox makeTextBox;
        private TextBox modelTextBox;
        private TextBox mpgTextBox;
        private TextBox priceTextBox;
        private Button addCarButton;
    }
}