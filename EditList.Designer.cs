namespace CopypastaManager
{
    partial class EditListForm
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
            checkedListBox1 = new CheckedListBox();
            LabelCopypastaList = new Label();
            LabelEnterDesc = new Label();
            uxDescriptionBox = new TextBox();
            LabelEnterCopypasta = new Label();
            button2 = new Button();
            uxCancelAdd = new Button();
            uxEnterCopypastaName = new TextBox();
            labelEnterCopypastaName = new Label();
            uxSelectTypeBox = new GroupBox();
            uxSelectGeneral = new RadioButton();
            uxSelectProfessional = new RadioButton();
            uxEnterCopypasta = new RichTextBox();
            uxSelectTypeBox.SuspendLayout();
            SuspendLayout();
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(12, 26);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.ScrollAlwaysVisible = true;
            checkedListBox1.Size = new Size(190, 508);
            checkedListBox1.TabIndex = 0;
            // 
            // LabelCopypastaList
            // 
            LabelCopypastaList.AutoSize = true;
            LabelCopypastaList.Location = new Point(12, 8);
            LabelCopypastaList.Name = "LabelCopypastaList";
            LabelCopypastaList.Size = new Size(196, 15);
            LabelCopypastaList.TabIndex = 1;
            LabelCopypastaList.Text = "Select a Copypasta to Edit or Delete:";
            // 
            // LabelEnterDesc
            // 
            LabelEnterDesc.AutoSize = true;
            LabelEnterDesc.Location = new Point(208, 106);
            LabelEnterDesc.Name = "LabelEnterDesc";
            LabelEnterDesc.Size = new Size(186, 15);
            LabelEnterDesc.TabIndex = 21;
            LabelEnterDesc.Text = "Copypasta Description (Optional):";
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.BackColor = SystemColors.Window;
            uxDescriptionBox.Location = new Point(208, 124);
            uxDescriptionBox.MaxLength = 500;
            uxDescriptionBox.Multiline = true;
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.ReadOnly = true;
            uxDescriptionBox.Size = new Size(460, 40);
            uxDescriptionBox.TabIndex = 20;
            // 
            // LabelEnterCopypasta
            // 
            LabelEnterCopypasta.AutoSize = true;
            LabelEnterCopypasta.Location = new Point(208, 175);
            LabelEnterCopypasta.Name = "LabelEnterCopypasta";
            LabelEnterCopypasta.Size = new Size(71, 15);
            LabelEnterCopypasta.TabIndex = 19;
            LabelEnterCopypasta.Text = "Copypasta*:";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(441, 498);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 18;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // uxCancelAdd
            // 
            uxCancelAdd.BackColor = Color.FromArgb(255, 192, 192);
            uxCancelAdd.FlatStyle = FlatStyle.Flat;
            uxCancelAdd.Location = new Point(341, 498);
            uxCancelAdd.Name = "uxCancelAdd";
            uxCancelAdd.Size = new Size(94, 36);
            uxCancelAdd.TabIndex = 17;
            uxCancelAdd.Text = "Cancel";
            uxCancelAdd.UseVisualStyleBackColor = false;
            // 
            // uxEnterCopypastaName
            // 
            uxEnterCopypastaName.Location = new Point(358, 34);
            uxEnterCopypastaName.MaxLength = 26;
            uxEnterCopypastaName.Name = "uxEnterCopypastaName";
            uxEnterCopypastaName.Size = new Size(310, 23);
            uxEnterCopypastaName.TabIndex = 16;
            uxEnterCopypastaName.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // labelEnterCopypastaName
            // 
            labelEnterCopypastaName.AutoSize = true;
            labelEnterCopypastaName.Location = new Point(358, 16);
            labelEnterCopypastaName.Name = "labelEnterCopypastaName";
            labelEnterCopypastaName.Size = new Size(106, 15);
            labelEnterCopypastaName.TabIndex = 15;
            labelEnterCopypastaName.Text = "Copypasta Name*:";
            // 
            // uxSelectTypeBox
            // 
            uxSelectTypeBox.BackColor = Color.Transparent;
            uxSelectTypeBox.Controls.Add(uxSelectGeneral);
            uxSelectTypeBox.Controls.Add(uxSelectProfessional);
            uxSelectTypeBox.Location = new Point(214, 12);
            uxSelectTypeBox.Name = "uxSelectTypeBox";
            uxSelectTypeBox.Padding = new Padding(2, 0, 2, 0);
            uxSelectTypeBox.Size = new Size(114, 72);
            uxSelectTypeBox.TabIndex = 14;
            uxSelectTypeBox.TabStop = false;
            uxSelectTypeBox.Text = "Copypasta Type*:";
            // 
            // uxSelectGeneral
            // 
            uxSelectGeneral.AutoSize = true;
            uxSelectGeneral.BackColor = Color.Transparent;
            uxSelectGeneral.Location = new Point(16, 22);
            uxSelectGeneral.Name = "uxSelectGeneral";
            uxSelectGeneral.Size = new Size(65, 19);
            uxSelectGeneral.TabIndex = 2;
            uxSelectGeneral.TabStop = true;
            uxSelectGeneral.Text = "General";
            uxSelectGeneral.UseVisualStyleBackColor = false;
            // 
            // uxSelectProfessional
            // 
            uxSelectProfessional.AutoSize = true;
            uxSelectProfessional.BackColor = Color.Transparent;
            uxSelectProfessional.Location = new Point(16, 47);
            uxSelectProfessional.Name = "uxSelectProfessional";
            uxSelectProfessional.Size = new Size(89, 19);
            uxSelectProfessional.TabIndex = 3;
            uxSelectProfessional.TabStop = true;
            uxSelectProfessional.Text = "Professional";
            uxSelectProfessional.UseVisualStyleBackColor = false;
            // 
            // uxEnterCopypasta
            // 
            uxEnterCopypasta.Location = new Point(208, 193);
            uxEnterCopypasta.MaxLength = 50000;
            uxEnterCopypasta.Name = "uxEnterCopypasta";
            uxEnterCopypasta.Size = new Size(460, 286);
            uxEnterCopypasta.TabIndex = 13;
            uxEnterCopypasta.Text = "";
            // 
            // EditListForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 544);
            Controls.Add(LabelEnterDesc);
            Controls.Add(uxDescriptionBox);
            Controls.Add(LabelEnterCopypasta);
            Controls.Add(button2);
            Controls.Add(uxCancelAdd);
            Controls.Add(uxEnterCopypastaName);
            Controls.Add(labelEnterCopypastaName);
            Controls.Add(uxSelectTypeBox);
            Controls.Add(uxEnterCopypasta);
            Controls.Add(LabelCopypastaList);
            Controls.Add(checkedListBox1);
            Name = "EditListForm";
            Text = "Edit Copypasta List";
            uxSelectTypeBox.ResumeLayout(false);
            uxSelectTypeBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBox1;
        private Label LabelCopypastaList;
        private Label LabelEnterDesc;
        private TextBox uxDescriptionBox;
        private Label LabelEnterCopypasta;
        private Button button2;
        private Button uxCancelAdd;
        private TextBox uxEnterCopypastaName;
        private Label labelEnterCopypastaName;
        private GroupBox uxSelectTypeBox;
        private RadioButton uxSelectGeneral;
        private RadioButton uxSelectProfessional;
        private RichTextBox uxEnterCopypasta;
    }
}