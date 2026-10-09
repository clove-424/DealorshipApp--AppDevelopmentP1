namespace CarolineLoveProject1.View
{
    partial class ShopperForm
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
            shopperLabel = new Label();
            moneyAvailableLabel = new Label();
            shopperNameTextBox = new TextBox();
            moneyAvailableTextBox = new TextBox();
            submitShopperButton = new Button();
            SuspendLayout();
            // 
            // shopperLabel
            // 
            shopperLabel.AutoSize = true;
            shopperLabel.Location = new Point(155, 74);
            shopperLabel.Name = "shopperLabel";
            shopperLabel.Size = new Size(112, 20);
            shopperLabel.TabIndex = 0;
            shopperLabel.Text = "Shopper Name:";
            // 
            // moneyAvailableLabel
            // 
            moneyAvailableLabel.AutoSize = true;
            moneyAvailableLabel.Location = new Point(150, 149);
            moneyAvailableLabel.Name = "moneyAvailableLabel";
            moneyAvailableLabel.Size = new Size(117, 20);
            moneyAvailableLabel.TabIndex = 2;
            moneyAvailableLabel.Text = "Budget Amount:";
            // 
            // shopperNameTextBox
            // 
            shopperNameTextBox.Location = new Point(273, 71);
            shopperNameTextBox.Name = "shopperNameTextBox";
            shopperNameTextBox.Size = new Size(125, 27);
            shopperNameTextBox.TabIndex = 1;
            // 
            // moneyAvailableTextBox
            // 
            moneyAvailableTextBox.Location = new Point(273, 146);
            moneyAvailableTextBox.Name = "moneyAvailableTextBox";
            moneyAvailableTextBox.Size = new Size(125, 27);
            moneyAvailableTextBox.TabIndex = 3;
            // 
            // submitShopperButton
            // 
            submitShopperButton.Location = new Point(223, 252);
            submitShopperButton.Name = "submitShopperButton";
            submitShopperButton.Size = new Size(94, 29);
            submitShopperButton.TabIndex = 4;
            submitShopperButton.Text = "Submit";
            submitShopperButton.UseVisualStyleBackColor = true;
            submitShopperButton.Click += AddShopperButtonClick;
            // 
            // ShopperForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(542, 324);
            Controls.Add(submitShopperButton);
            Controls.Add(moneyAvailableTextBox);
            Controls.Add(shopperNameTextBox);
            Controls.Add(moneyAvailableLabel);
            Controls.Add(shopperLabel);
            Name = "ShopperForm";
            Text = "Add Shopper Information";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shopperLabel;
        private Label moneyAvailableLabel;
        private TextBox shopperNameTextBox;
        private TextBox moneyAvailableTextBox;
        private Button submitShopperButton;
    }
}