namespace CarolineLoveProject1
{
    public partial class CarLotForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            carLotListBox = new ListBox();
            carLotMenuStrip = new MenuStrip();
            optionsToolStripMenuItem = new ToolStripMenuItem();
            addCarToolStripMenuItem = new ToolStripMenuItem();
            inventoryDetailsMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            addShopperButton = new Button();
            purchaseCarButton = new Button();
            label1 = new Label();
            shopperNameLabel = new Label();
            shopperTotalLabel = new Label();
            carLotMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // carLotListBox
            // 
            carLotListBox.FormattingEnabled = true;
            carLotListBox.Location = new Point(133, 155);
            carLotListBox.Margin = new Padding(3, 4, 3, 4);
            carLotListBox.Name = "carLotListBox";
            carLotListBox.Size = new Size(398, 264);
            carLotListBox.TabIndex = 5;
            // 
            // carLotMenuStrip
            // 
            carLotMenuStrip.ImageScalingSize = new Size(20, 20);
            carLotMenuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            carLotMenuStrip.Location = new Point(0, 0);
            carLotMenuStrip.Name = "carLotMenuStrip";
            carLotMenuStrip.Size = new Size(652, 28);
            carLotMenuStrip.TabIndex = 0;
            carLotMenuStrip.Text = "carLotMenuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCarToolStripMenuItem, inventoryDetailsMenuItem, exitMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addCarToolStripMenuItem
            // 
            addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            addCarToolStripMenuItem.Size = new Size(203, 26);
            addCarToolStripMenuItem.Text = "Add Car to Lot";
            addCarToolStripMenuItem.Click += AddCarMenuItemClick;
            // 
            // inventoryDetailsMenuItem
            // 
            inventoryDetailsMenuItem.Name = "inventoryDetailsMenuItem";
            inventoryDetailsMenuItem.Size = new Size(203, 26);
            inventoryDetailsMenuItem.Text = "Inventory Details";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(203, 26);
            exitMenuItem.Text = "Exit";
            // 
            // addShopperButton
            // 
            addShopperButton.Location = new Point(133, 31);
            addShopperButton.Name = "addShopperButton";
            addShopperButton.Size = new Size(126, 29);
            addShopperButton.TabIndex = 1;
            addShopperButton.Text = "Add Shopper";
            addShopperButton.UseVisualStyleBackColor = true;
            addShopperButton.Click += AddShopperClick;
            // 
            // purchaseCarButton
            // 
            purchaseCarButton.Location = new Point(133, 426);
            purchaseCarButton.Name = "purchaseCarButton";
            purchaseCarButton.Size = new Size(138, 29);
            purchaseCarButton.TabIndex = 6;
            purchaseCarButton.Text = "Purchase Car";
            purchaseCarButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(133, 131);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Inventory";
            // 
            // shopperNameLabel
            // 
            shopperNameLabel.Location = new Point(314, 29);
            shopperNameLabel.Name = "shopperNameLabel";
            shopperNameLabel.Size = new Size(338, 20);
            shopperNameLabel.TabIndex = 2;
            shopperNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // shopperTotalLabel
            // 
            shopperTotalLabel.Location = new Point(314, 49);
            shopperTotalLabel.Name = "shopperTotalLabel";
            shopperTotalLabel.Size = new Size(338, 20);
            shopperTotalLabel.TabIndex = 3;
            shopperTotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 480);
            Controls.Add(shopperTotalLabel);
            Controls.Add(shopperNameLabel);
            Controls.Add(label1);
            Controls.Add(purchaseCarButton);
            Controls.Add(addShopperButton);
            Controls.Add(carLotListBox);
            Controls.Add(carLotMenuStrip);
            MainMenuStrip = carLotMenuStrip;
            Margin = new Padding(3, 4, 3, 4);
            Name = "CarLotForm";
            Text = "Caroline Love Project 1";
            carLotMenuStrip.ResumeLayout(false);
            carLotMenuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox carLotListBox;
        private MenuStrip carLotMenuStrip;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private ToolStripMenuItem addCarToolStripMenuItem;
        private ToolStripMenuItem inventoryDetailsMenuItem;
        private ToolStripMenuItem exitMenuItem;
        private Button addShopperButton;
        private Button purchaseCarButton;
        private Label label1;
        private Label shopperNameLabel;
        private Label shopperTotalLabel;
    }
}
