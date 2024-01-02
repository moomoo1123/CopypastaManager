namespace CopypastaManager
{
    partial class CopypastaManager
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
            uxCopypastaBox = new RichTextBox();
            uxCopyPastaListView = new ListView();
            uxListModeGeneral = new RadioButton();
            uxListModeProfessional = new RadioButton();
            uxListModeGroupBox = new GroupBox();
            uxDescriptionBox = new TextBox();
            uxEditListButton = new Button();
            uxAddCopypastaButton = new Button();
            uxMRCLabel = new Label();
            uxRecentCopyText = new TextBox();
            uxCopyButton = new Button();
            textBox1 = new TextBox();
            uxListModeGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // uxCopypastaBox
            // 
            uxCopypastaBox.BorderStyle = BorderStyle.None;
            uxCopypastaBox.Location = new Point(229, 132);
            uxCopypastaBox.Margin = new Padding(3, 4, 3, 4);
            uxCopypastaBox.MaxLength = 50000;
            uxCopypastaBox.Name = "uxCopypastaBox";
            uxCopypastaBox.ReadOnly = true;
            uxCopypastaBox.ScrollBars = RichTextBoxScrollBars.ForcedVertical;
            uxCopypastaBox.Size = new Size(460, 286);
            uxCopypastaBox.TabIndex = 0;
            uxCopypastaBox.Text = "";
            // 
            // uxCopyPastaListView
            // 
            uxCopyPastaListView.Location = new Point(12, 85);
            uxCopyPastaListView.Name = "uxCopyPastaListView";
            uxCopyPastaListView.Size = new Size(194, 333);
            uxCopyPastaListView.TabIndex = 1;
            uxCopyPastaListView.UseCompatibleStateImageBehavior = false;
            // 
            // uxListModeGeneral
            // 
            uxListModeGeneral.AutoSize = true;
            uxListModeGeneral.BackColor = Color.Transparent;
            uxListModeGeneral.Location = new Point(20, 22);
            uxListModeGeneral.Name = "uxListModeGeneral";
            uxListModeGeneral.Size = new Size(65, 19);
            uxListModeGeneral.TabIndex = 2;
            uxListModeGeneral.TabStop = true;
            uxListModeGeneral.Text = "General";
            uxListModeGeneral.UseVisualStyleBackColor = false;
            // 
            // uxListModeProfessional
            // 
            uxListModeProfessional.AutoSize = true;
            uxListModeProfessional.BackColor = Color.Transparent;
            uxListModeProfessional.Location = new Point(20, 43);
            uxListModeProfessional.Name = "uxListModeProfessional";
            uxListModeProfessional.Size = new Size(89, 19);
            uxListModeProfessional.TabIndex = 3;
            uxListModeProfessional.TabStop = true;
            uxListModeProfessional.Text = "Professional";
            uxListModeProfessional.UseVisualStyleBackColor = false;
            // 
            // uxListModeGroupBox
            // 
            uxListModeGroupBox.BackColor = Color.Transparent;
            uxListModeGroupBox.Controls.Add(uxListModeGeneral);
            uxListModeGroupBox.Controls.Add(uxListModeProfessional);
            uxListModeGroupBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxListModeGroupBox.Location = new Point(12, 12);
            uxListModeGroupBox.Name = "uxListModeGroupBox";
            uxListModeGroupBox.Padding = new Padding(2, 0, 2, 0);
            uxListModeGroupBox.Size = new Size(126, 67);
            uxListModeGroupBox.TabIndex = 4;
            uxListModeGroupBox.TabStop = false;
            uxListModeGroupBox.Text = "Select:";
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.BackColor = SystemColors.Menu;
            uxDescriptionBox.BorderStyle = BorderStyle.None;
            uxDescriptionBox.Location = new Point(228, 85);
            uxDescriptionBox.MaxLength = 500;
            uxDescriptionBox.Multiline = true;
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.Size = new Size(460, 40);
            uxDescriptionBox.TabIndex = 6;
            // 
            // uxEditListButton
            // 
            uxEditListButton.FlatStyle = FlatStyle.Popup;
            uxEditListButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxEditListButton.ForeColor = SystemColors.ActiveCaptionText;
            uxEditListButton.Location = new Point(12, 422);
            uxEditListButton.Name = "uxEditListButton";
            uxEditListButton.Size = new Size(94, 58);
            uxEditListButton.TabIndex = 7;
            uxEditListButton.Text = "Edit";
            uxEditListButton.UseVisualStyleBackColor = true;
            // 
            // uxAddCopypastaButton
            // 
            uxAddCopypastaButton.BackColor = SystemColors.ControlLight;
            uxAddCopypastaButton.FlatStyle = FlatStyle.Popup;
            uxAddCopypastaButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxAddCopypastaButton.Location = new Point(112, 422);
            uxAddCopypastaButton.Name = "uxAddCopypastaButton";
            uxAddCopypastaButton.Size = new Size(94, 58);
            uxAddCopypastaButton.TabIndex = 8;
            uxAddCopypastaButton.Text = "Add Copypasta";
            uxAddCopypastaButton.UseVisualStyleBackColor = false;
            // 
            // uxMRCLabel
            // 
            uxMRCLabel.AutoSize = true;
            uxMRCLabel.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxMRCLabel.Location = new Point(277, 439);
            uxMRCLabel.Name = "uxMRCLabel";
            uxMRCLabel.Size = new Size(176, 15);
            uxMRCLabel.TabIndex = 10;
            uxMRCLabel.Text = "Most Recent Copypasta Copied:";
            // 
            // uxRecentCopyText
            // 
            uxRecentCopyText.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxRecentCopyText.Location = new Point(228, 457);
            uxRecentCopyText.MaxLength = 52;
            uxRecentCopyText.Name = "uxRecentCopyText";
            uxRecentCopyText.ReadOnly = true;
            uxRecentCopyText.Size = new Size(287, 23);
            uxRecentCopyText.TabIndex = 11;
            uxRecentCopyText.TextAlign = HorizontalAlignment.Center;
            // 
            // uxCopyButton
            // 
            uxCopyButton.BackColor = Color.FromArgb(192, 255, 192);
            uxCopyButton.FlatStyle = FlatStyle.Popup;
            uxCopyButton.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            uxCopyButton.Location = new Point(532, 427);
            uxCopyButton.Name = "uxCopyButton";
            uxCopyButton.Size = new Size(157, 53);
            uxCopyButton.TabIndex = 12;
            uxCopyButton.Text = "Copy";
            uxCopyButton.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.ControlLight;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Arial Narrow", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            textBox1.Location = new Point(228, 37);
            textBox1.MaxLength = 26;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(460, 25);
            textBox1.TabIndex = 13;
            textBox1.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // CopypastaManager
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(702, 492);
            Controls.Add(textBox1);
            Controls.Add(uxCopyButton);
            Controls.Add(uxRecentCopyText);
            Controls.Add(uxMRCLabel);
            Controls.Add(uxAddCopypastaButton);
            Controls.Add(uxEditListButton);
            Controls.Add(uxDescriptionBox);
            Controls.Add(uxListModeGroupBox);
            Controls.Add(uxCopyPastaListView);
            Controls.Add(uxCopypastaBox);
            Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CopypastaManager";
            Text = "Copypasta Manager";
            uxListModeGroupBox.ResumeLayout(false);
            uxListModeGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox uxCopypastaBox;
        private ListView uxCopyPastaListView;
        private RadioButton uxListModeGeneral;
        private RadioButton uxListModeProfessional;
        private GroupBox uxListModeGroupBox;
        private TextBox uxDescriptionBox;
        private Button uxEditListButton;
        private Button uxAddCopypastaButton;
        private Label uxMRCLabel;
        private TextBox uxRecentCopyText;
        private Button uxCopyButton;
        private TextBox textBox1;
    }
}