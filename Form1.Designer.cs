namespace TypeForMe
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ToggleButton = new Button();
            SecondsTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            countdownLabel = new Label();
            DeleteCheckBox = new CheckBox();
            label3 = new Label();
            KeyTextBox = new TextBox();
            RandomCheckBox = new CheckBox();
            SuspendLayout();
            // 
            // ToggleButton
            // 
            ToggleButton.Anchor = AnchorStyles.Bottom;
            ToggleButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            ToggleButton.Location = new Point(87, 120);
            ToggleButton.Name = "ToggleButton";
            ToggleButton.Size = new Size(82, 32);
            ToggleButton.TabIndex = 5;
            ToggleButton.Text = "Start";
            ToggleButton.UseVisualStyleBackColor = true;
            ToggleButton.Click += Button_Click;
            // 
            // SecondsTextBox
            // 
            SecondsTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            SecondsTextBox.Location = new Point(192, 12);
            SecondsTextBox.Name = "SecondsTextBox";
            SecondsTextBox.Size = new Size(47, 23);
            SecondsTextBox.TabIndex = 1;
            SecondsTextBox.Text = "60";
            SecondsTextBox.TextChanged += SecondsTextBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(158, 15);
            label1.TabIndex = 2;
            label1.Text = "Seconds Between Keystrokes";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 92);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 3;
            label2.Text = "Next Keystroke:";
            // 
            // countdownLabel
            // 
            countdownLabel.AutoSize = true;
            countdownLabel.Location = new Point(107, 92);
            countdownLabel.Name = "countdownLabel";
            countdownLabel.Size = new Size(0, 15);
            countdownLabel.TabIndex = 4;
            // 
            // DeleteCheckBox
            // 
            DeleteCheckBox.AutoSize = true;
            DeleteCheckBox.Location = new Point(12, 67);
            DeleteCheckBox.Name = "DeleteCheckBox";
            DeleteCheckBox.Size = new Size(182, 19);
            DeleteCheckBox.TabIndex = 4;
            DeleteCheckBox.Text = "Immediately Delete Keystroke";
            DeleteCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 41);
            label3.Name = "label3";
            label3.Size = new Size(68, 15);
            label3.TabIndex = 7;
            label3.Text = "Key To Type";
            // 
            // KeyTextBox
            // 
            KeyTextBox.Enabled = false;
            KeyTextBox.Location = new Point(91, 38);
            KeyTextBox.MaxLength = 1;
            KeyTextBox.Name = "KeyTextBox";
            KeyTextBox.Size = new Size(21, 23);
            KeyTextBox.TabIndex = 2;
            // 
            // RandomCheckBox
            // 
            RandomCheckBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            RandomCheckBox.AutoSize = true;
            RandomCheckBox.Checked = true;
            RandomCheckBox.CheckState = CheckState.Checked;
            RandomCheckBox.Location = new Point(163, 41);
            RandomCheckBox.Name = "RandomCheckBox";
            RandomCheckBox.Size = new Size(85, 19);
            RandomCheckBox.TabIndex = 3;
            RandomCheckBox.Text = "Randomize";
            RandomCheckBox.UseVisualStyleBackColor = true;
            RandomCheckBox.CheckedChanged += RandomCheckBox_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(252, 161);
            Controls.Add(RandomCheckBox);
            Controls.Add(KeyTextBox);
            Controls.Add(label3);
            Controls.Add(DeleteCheckBox);
            Controls.Add(countdownLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(SecondsTextBox);
            Controls.Add(ToggleButton);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Form1";
            Text = "AFK";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ToggleButton;
        private TextBox SecondsTextBox;
        private Label label1;
        private Label label2;
        private Label countdownLabel;
        private CheckBox DeleteCheckBox;
        private Label label3;
        private TextBox KeyTextBox;
        private CheckBox RandomCheckBox;
    }
}