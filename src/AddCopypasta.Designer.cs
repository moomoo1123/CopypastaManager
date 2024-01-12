namespace CopypastaManager
{
    partial class AddCopypastaForm
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
            uxEnterCopypasta = new RichTextBox();
            uxSelectTypeBox = new GroupBox();
            uxSelectGeneral = new RadioButton();
            uxSelectProfessional = new RadioButton();
            labelEnterCopypastaName = new Label();
            textBox1 = new TextBox();
            uxCancelAdd = new Button();
            button2 = new Button();
            LabelEnterCopypasta = new Label();
            uxDescriptionBox = new TextBox();
            LabelEnterDesc = new Label();
            uxSelectTypeBox.SuspendLayout();
            SuspendLayout();
            // 
            // uxEnterCopypasta
            // 
            uxEnterCopypasta.Location = new Point(11, 187);
            uxEnterCopypasta.MaxLength = 50000;
            uxEnterCopypasta.Name = "uxEnterCopypasta";
            uxEnterCopypasta.Size = new Size(460, 286);
            uxEnterCopypasta.TabIndex = 0;
            uxEnterCopypasta.Text = "";
            // 
            // uxSelectTypeBox
            // 
            uxSelectTypeBox.BackColor = Color.Transparent;
            uxSelectTypeBox.Controls.Add(uxSelectGeneral);
            uxSelectTypeBox.Controls.Add(uxSelectProfessional);
            uxSelectTypeBox.Location = new Point(12, 12);
            uxSelectTypeBox.Name = "uxSelectTypeBox";
            uxSelectTypeBox.Padding = new Padding(2, 0, 2, 0);
            uxSelectTypeBox.Size = new Size(156, 84);
            uxSelectTypeBox.TabIndex = 5;
            uxSelectTypeBox.TabStop = false;
            uxSelectTypeBox.Text = "Select Copypasta Type*:";
            // 
            // uxSelectGeneral
            // 
            uxSelectGeneral.AutoSize = true;
            uxSelectGeneral.BackColor = Color.Transparent;
            uxSelectGeneral.Location = new Point(17, 22);
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
            uxSelectProfessional.Location = new Point(17, 47);
            uxSelectProfessional.Name = "uxSelectProfessional";
            uxSelectProfessional.Size = new Size(89, 19);
            uxSelectProfessional.TabIndex = 3;
            uxSelectProfessional.TabStop = true;
            uxSelectProfessional.Text = "Professional";
            uxSelectProfessional.UseVisualStyleBackColor = false;
            // 
            // labelEnterCopypastaName
            // 
            labelEnterCopypastaName.AutoSize = true;
            labelEnterCopypastaName.Location = new Point(174, 12);
            labelEnterCopypastaName.Name = "labelEnterCopypastaName";
            labelEnterCopypastaName.Size = new Size(106, 15);
            labelEnterCopypastaName.TabIndex = 6;
            labelEnterCopypastaName.Text = "Copypasta Name*:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(175, 30);
            textBox1.MaxLength = 26;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(296, 23);
            textBox1.TabIndex = 7;
            textBox1.Text = "WWWWWWWWWWWWWWWWWWWWWWWWWW";
            // 
            // uxCancelAdd
            // 
            uxCancelAdd.BackColor = Color.FromArgb(255, 192, 192);
            uxCancelAdd.FlatStyle = FlatStyle.Flat;
            uxCancelAdd.Location = new Point(147, 479);
            uxCancelAdd.Name = "uxCancelAdd";
            uxCancelAdd.Size = new Size(94, 36);
            uxCancelAdd.TabIndex = 8;
            uxCancelAdd.Text = "Cancel";
            uxCancelAdd.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(192, 255, 192);
            button2.FlatStyle = FlatStyle.Popup;
            button2.Location = new Point(247, 479);
            button2.Name = "button2";
            button2.Size = new Size(94, 36);
            button2.TabIndex = 9;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = false;
            // 
            // LabelEnterCopypasta
            // 
            LabelEnterCopypasta.AutoSize = true;
            LabelEnterCopypasta.Location = new Point(11, 169);
            LabelEnterCopypasta.Name = "LabelEnterCopypasta";
            LabelEnterCopypasta.Size = new Size(128, 15);
            LabelEnterCopypasta.TabIndex = 10;
            LabelEnterCopypasta.Text = "Enter your Copypasta*:";
            // 
            // uxDescriptionBox
            // 
            uxDescriptionBox.BackColor = SystemColors.Window;
            uxDescriptionBox.BorderStyle = BorderStyle.FixedSingle;
            uxDescriptionBox.Location = new Point(12, 122);
            uxDescriptionBox.MaxLength = 500;
            uxDescriptionBox.Multiline = true;
            uxDescriptionBox.Name = "uxDescriptionBox";
            uxDescriptionBox.ReadOnly = true;
            uxDescriptionBox.Size = new Size(459, 40);
            uxDescriptionBox.TabIndex = 11;
            // 
            // LabelEnterDesc
            // 
            LabelEnterDesc.AutoSize = true;
            LabelEnterDesc.Location = new Point(11, 104);
            LabelEnterDesc.Name = "LabelEnterDesc";
            LabelEnterDesc.Size = new Size(216, 15);
            LabelEnterDesc.TabIndex = 12;
            LabelEnterDesc.Text = "Enter Copypasta Description (Optional):";
            // 
            // AddCopypastaForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(485, 525);
            Controls.Add(LabelEnterDesc);
            Controls.Add(uxDescriptionBox);
            Controls.Add(LabelEnterCopypasta);
            Controls.Add(button2);
            Controls.Add(uxCancelAdd);
            Controls.Add(textBox1);
            Controls.Add(labelEnterCopypastaName);
            Controls.Add(uxSelectTypeBox);
            Controls.Add(uxEnterCopypasta);
            Name = "AddCopypastaForm";
            Text = "Add a Copypasta";
            uxSelectTypeBox.ResumeLayout(false);
            uxSelectTypeBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox uxEnterCopypasta;
        private GroupBox uxSelectTypeBox;
        private RadioButton uxSelectGeneral;
        private RadioButton uxSelectProfessional;
        private Label labelEnterCopypastaName;
        private TextBox textBox1;
        private Button uxCancelAdd;
        private Button button2;
        private Label LabelEnterCopypasta;
        private TextBox uxDescriptionBox;
        private Label LabelEnterDesc;
    }
}