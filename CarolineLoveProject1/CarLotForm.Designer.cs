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
            clearSearchMenuItem = new ToolStripMenuItem();
            exitMenuItem = new ToolStripMenuItem();
            addShopperButton = new Button();
            purchaseCarButton = new Button();
            label1 = new Label();
            shopperNameLabel = new Label();
            shopperTotalLabel = new Label();
            button1 = new Button();
            clearSearchButton = new Button();
            searchMakeModelButton = new Button();
            viewPurchasesButton = new Button();
            carLotMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // carLotListBox
            // 
            carLotListBox.FormattingEnabled = true;
            carLotListBox.Location = new Point(59, 147);
            carLotListBox.Margin = new Padding(3, 4, 3, 4);
            carLotListBox.Name = "carLotListBox";
            carLotListBox.Size = new Size(534, 264);
            carLotListBox.TabIndex = 5;
            // 
            // carLotMenuStrip
            // 
            carLotMenuStrip.ImageScalingSize = new Size(20, 20);
            carLotMenuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            carLotMenuStrip.Location = new Point(0, 0);
            carLotMenuStrip.Name = "carLotMenuStrip";
            carLotMenuStrip.Padding = new Padding(6, 3, 0, 3);
            carLotMenuStrip.Size = new Size(651, 30);
            carLotMenuStrip.TabIndex = 0;
            carLotMenuStrip.Text = "carLotMenuStrip";
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addCarToolStripMenuItem, inventoryDetailsMenuItem, clearSearchMenuItem, exitMenuItem });
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new Size(75, 24);
            optionsToolStripMenuItem.Text = "Options";
            // 
            // addCarToolStripMenuItem
            // 
            addCarToolStripMenuItem.Name = "addCarToolStripMenuItem";
            addCarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.A;
            addCarToolStripMenuItem.Size = new Size(267, 26);
            addCarToolStripMenuItem.Text = "A&dd Car to Lot";
            addCarToolStripMenuItem.Click += AddCarMenuItemClick;
            // 
            // inventoryDetailsMenuItem
            // 
            inventoryDetailsMenuItem.Name = "inventoryDetailsMenuItem";
            inventoryDetailsMenuItem.ShortcutKeys = Keys.Control | Keys.D;
            inventoryDetailsMenuItem.Size = new Size(267, 26);
            inventoryDetailsMenuItem.Text = "&Detailed Inventory";
            inventoryDetailsMenuItem.Click += InventoryDetailsClick;
            // 
            // clearSearchMenuItem
            // 
            clearSearchMenuItem.Name = "clearSearchMenuItem";
            clearSearchMenuItem.ShortcutKeys = Keys.Control | Keys.L;
            clearSearchMenuItem.Size = new Size(267, 26);
            clearSearchMenuItem.Text = "C&lear List Search";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.ShortcutKeys = Keys.Control | Keys.Q;
            exitMenuItem.Size = new Size(267, 26);
            exitMenuItem.Text = "E&xit";
            exitMenuItem.Click += ExitFormClick;
            // 
            // addShopperButton
            // 
            addShopperButton.Location = new Point(8, 29);
            addShopperButton.Name = "addShopperButton";
            addShopperButton.Size = new Size(126, 29);
            addShopperButton.TabIndex = 1;
            addShopperButton.Text = "Add Shopper";
            addShopperButton.UseVisualStyleBackColor = true;
            addShopperButton.Click += AddShopperClick;
            // 
            // purchaseCarButton
            // 
            purchaseCarButton.Location = new Point(455, 418);
            purchaseCarButton.Name = "purchaseCarButton";
            purchaseCarButton.Size = new Size(138, 29);
            purchaseCarButton.TabIndex = 7;
            purchaseCarButton.Text = "Purchase Car";
            purchaseCarButton.UseVisualStyleBackColor = true;
            purchaseCarButton.Click += PurchaseCarClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 123);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 4;
            label1.Text = "Inventory";
            // 
            // shopperNameLabel
            // 
            shopperNameLabel.Location = new Point(304, 29);
            shopperNameLabel.Name = "shopperNameLabel";
            shopperNameLabel.Size = new Size(338, 20);
            shopperNameLabel.TabIndex = 2;
            shopperNameLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // shopperTotalLabel
            // 
            shopperTotalLabel.Location = new Point(304, 49);
            shopperTotalLabel.Name = "shopperTotalLabel";
            shopperTotalLabel.Size = new Size(338, 20);
            shopperTotalLabel.TabIndex = 3;
            shopperTotalLabel.TextAlign = ContentAlignment.TopRight;
            // 
            // button1
            // 
            button1.Location = new Point(437, 114);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 6;
            button1.Text = "Detailed Inventory";
            button1.UseVisualStyleBackColor = true;
            button1.Click += InventoryDetailsClick;
            // 
            // clearSearchButton
            // 
            clearSearchButton.Location = new Point(206, 418);
            clearSearchButton.Name = "clearSearchButton";
            clearSearchButton.Size = new Size(116, 29);
            clearSearchButton.TabIndex = 8;
            clearSearchButton.Text = "Clear Search";
            clearSearchButton.UseVisualStyleBackColor = true;
            clearSearchButton.Click += ClearSearchButtonClick;
            // 
            // searchMakeModelButton
            // 
            searchMakeModelButton.Location = new Point(59, 418);
            searchMakeModelButton.Name = "searchMakeModelButton";
            searchMakeModelButton.Size = new Size(141, 29);
            searchMakeModelButton.TabIndex = 9;
            searchMakeModelButton.Text = "Search By Make";
            searchMakeModelButton.UseVisualStyleBackColor = true;
            searchMakeModelButton.Click += SearchByMakeClick;
            // 
            // viewPurchasesButton
            // 
            viewPurchasesButton.Location = new Point(8, 64);
            viewPurchasesButton.Name = "viewPurchasesButton";
            viewPurchasesButton.Size = new Size(126, 29);
            viewPurchasesButton.TabIndex = 10;
            viewPurchasesButton.Text = "View Purchases";
            viewPurchasesButton.UseVisualStyleBackColor = true;
            viewPurchasesButton.Click += ViewPurchasesButtonClick;
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(651, 483);
            Controls.Add(viewPurchasesButton);
            Controls.Add(searchMakeModelButton);
            Controls.Add(clearSearchButton);
            Controls.Add(button1);
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
        private Button button1;
        private ToolStripMenuItem clearSearchMenuItem;
        private Button clearSearchButton;
        private Button searchMakeModelButton;
        private Button viewPurchasesButton;
    }
}
