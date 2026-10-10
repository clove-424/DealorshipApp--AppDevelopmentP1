namespace CarolineLoveProject1.View
{
    partial class ShopperPurchasesForm
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
            shopperPurchasesLabel = new Label();
            shopperPurchasesListBox = new ListBox();
            SuspendLayout();
            // 
            // shopperPurchasesLabel
            // 
            shopperPurchasesLabel.AutoSize = true;
            shopperPurchasesLabel.Location = new Point(78, 21);
            shopperPurchasesLabel.Name = "shopperPurchasesLabel";
            shopperPurchasesLabel.Size = new Size(0, 20);
            shopperPurchasesLabel.TabIndex = 0;
            // 
            // shopperPurchasesListBox
            // 
            shopperPurchasesListBox.FormattingEnabled = true;
            shopperPurchasesListBox.Location = new Point(78, 44);
            shopperPurchasesListBox.Name = "shopperPurchasesListBox";
            shopperPurchasesListBox.Size = new Size(318, 324);
            shopperPurchasesListBox.TabIndex = 1;
            // 
            // ShopperPurchasesForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(474, 405);
            Controls.Add(shopperPurchasesListBox);
            Controls.Add(shopperPurchasesLabel);
            Name = "ShopperPurchasesForm";
            Text = "Shopper Purchases";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label shopperPurchasesLabel;
        private ListBox shopperPurchasesListBox;
    }
}