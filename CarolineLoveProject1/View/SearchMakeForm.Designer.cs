namespace CarolineLoveProject1.View
{
    partial class SearchMakeForm
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
            makeLabel = new Label();
            makeTextBox = new TextBox();
            submitButton = new Button();
            SuspendLayout();
            // 
            // makeLabel
            // 
            makeLabel.AutoSize = true;
            makeLabel.Location = new Point(111, 55);
            makeLabel.Name = "makeLabel";
            makeLabel.Size = new Size(48, 20);
            makeLabel.TabIndex = 0;
            makeLabel.Text = "Make:";
            // 
            // makeTextBox
            // 
            makeTextBox.Location = new Point(165, 52);
            makeTextBox.Name = "makeTextBox";
            makeTextBox.Size = new Size(183, 27);
            makeTextBox.TabIndex = 1;
            // 
            // submitButton
            // 
            submitButton.Location = new Point(178, 119);
            submitButton.Name = "submitButton";
            submitButton.Size = new Size(94, 29);
            submitButton.TabIndex = 2;
            submitButton.Text = "Submit";
            submitButton.UseVisualStyleBackColor = true;
            submitButton.Click += SubmitButtonClick;
            // 
            // SearchMakeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 183);
            Controls.Add(submitButton);
            Controls.Add(makeTextBox);
            Controls.Add(makeLabel);
            Name = "SearchMakeForm";
            Text = "Search Car";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label makeLabel;
        private TextBox makeTextBox;
        private Button submitButton;
    }
}