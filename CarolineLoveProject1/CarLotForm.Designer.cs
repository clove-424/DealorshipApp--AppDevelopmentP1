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
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            carLotMenuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // carLotListBox
            // 
            carLotListBox.FormattingEnabled = true;
            carLotListBox.Location = new Point(123, 68);
            carLotListBox.Margin = new Padding(3, 4, 3, 4);
            carLotListBox.Name = "carLotListBox";
            carLotListBox.Size = new Size(398, 284);
            carLotListBox.TabIndex = 1;
            // 
            // carLotMenuStrip
            // 
            carLotMenuStrip.ImageScalingSize = new Size(20, 20);
            carLotMenuStrip.Items.AddRange(new ToolStripItem[] { optionsToolStripMenuItem });
            carLotMenuStrip.Location = new Point(0, 0);
            carLotMenuStrip.Name = "carLotMenuStrip";
            carLotMenuStrip.Size = new Size(652, 28);
            carLotMenuStrip.TabIndex = 1;
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
            addCarToolStripMenuItem.Size = new Size(224, 26);
            addCarToolStripMenuItem.Text = "Add Car to Lot";
            addCarToolStripMenuItem.Click += AddCarMenuItemClick;
            // 
            // inventoryDetailsMenuItem
            // 
            inventoryDetailsMenuItem.Name = "inventoryDetailsMenuItem";
            inventoryDetailsMenuItem.Size = new Size(224, 26);
            inventoryDetailsMenuItem.Text = "Inventory Details";
            // 
            // exitMenuItem
            // 
            exitMenuItem.Name = "exitMenuItem";
            exitMenuItem.Size = new Size(224, 26);
            exitMenuItem.Text = "Exit";
            // 
            // button1
            // 
            button1.Location = new Point(161, 376);
            button1.Name = "button1";
            button1.Size = new Size(138, 29);
            button1.TabIndex = 2;
            button1.Text = "Add Shopper";
            button1.UseVisualStyleBackColor = true;
            button1.Click += PurchaseCarClick;
            // 
            // button2
            // 
            button2.Location = new Point(341, 376);
            button2.Name = "button2";
            button2.Size = new Size(138, 29);
            button2.TabIndex = 3;
            button2.Text = "Purchase Car";
            button2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(123, 44);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 0;
            label1.Text = "Inventory";
            // 
            // CarLotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(652, 423);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
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
        private Button button1;
        private Button button2;
        private Label label1;
    }
}
