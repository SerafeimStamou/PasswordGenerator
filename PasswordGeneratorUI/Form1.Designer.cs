
namespace PasswordGeneratorUI
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
            this.IncludeUppercase = new System.Windows.Forms.CheckBox();
            this.IncludeLowerCase = new System.Windows.Forms.CheckBox();
            this.IncludeNumbers = new System.Windows.Forms.CheckBox();
            this.Symbols = new System.Windows.Forms.CheckBox();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.PasswordLengthTrackBar = new System.Windows.Forms.TrackBar();
            this.GeneratePasswordBtn = new System.Windows.Forms.Button();
            this.LengthLabel = new System.Windows.Forms.Label();
            this.Label = new System.Windows.Forms.Label();
            this.CopyToClipBoardBtn = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // IncludeUppercase
            // 
            this.IncludeUppercase.AutoSize = true;
            this.IncludeUppercase.Checked = true;
            this.IncludeUppercase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeUppercase.Location = new System.Drawing.Point(3, 3);
            this.IncludeUppercase.Name = "IncludeUppercase";
            this.IncludeUppercase.Size = new System.Drawing.Size(103, 24);
            this.IncludeUppercase.TabIndex = 0;
            this.IncludeUppercase.Text = "UpperCase";
            this.IncludeUppercase.UseVisualStyleBackColor = true;
            this.IncludeUppercase.CheckedChanged += new System.EventHandler(this.IncludeUppercase_CheckedChanged);
            // 
            // IncludeLowerCase
            // 
            this.IncludeLowerCase.AutoSize = true;
            this.IncludeLowerCase.Checked = true;
            this.IncludeLowerCase.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeLowerCase.Location = new System.Drawing.Point(3, 61);
            this.IncludeLowerCase.Name = "IncludeLowerCase";
            this.IncludeLowerCase.Size = new System.Drawing.Size(102, 24);
            this.IncludeLowerCase.TabIndex = 1;
            this.IncludeLowerCase.Text = "LowerCase";
            this.IncludeLowerCase.UseVisualStyleBackColor = true;
            this.IncludeLowerCase.CheckedChanged += new System.EventHandler(this.IncludeLowerCase_CheckedChanged);
            // 
            // IncludeNumbers
            // 
            this.IncludeNumbers.AutoSize = true;
            this.IncludeNumbers.Checked = true;
            this.IncludeNumbers.CheckState = System.Windows.Forms.CheckState.Checked;
            this.IncludeNumbers.Location = new System.Drawing.Point(3, 130);
            this.IncludeNumbers.Name = "IncludeNumbers";
            this.IncludeNumbers.Size = new System.Drawing.Size(91, 24);
            this.IncludeNumbers.TabIndex = 2;
            this.IncludeNumbers.Text = "Numbers";
            this.IncludeNumbers.UseVisualStyleBackColor = true;
            this.IncludeNumbers.CheckedChanged += new System.EventHandler(this.IncludeNumbers_CheckedChanged);
            // 
            // Symbols
            // 
            this.Symbols.AutoSize = true;
            this.Symbols.Checked = true;
            this.Symbols.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Symbols.Location = new System.Drawing.Point(3, 199);
            this.Symbols.Name = "Symbols";
            this.Symbols.Size = new System.Drawing.Size(87, 24);
            this.Symbols.TabIndex = 3;
            this.Symbols.Text = "Symbols";
            this.Symbols.UseVisualStyleBackColor = true;
            this.Symbols.CheckedChanged += new System.EventHandler(this.Symbols_CheckedChanged);
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(35, 273);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(1155, 27);
            this.PasswordTextBox.TabIndex = 4;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // PasswordLengthTrackBar
            // 
            this.PasswordLengthTrackBar.Location = new System.Drawing.Point(193, 61);
            this.PasswordLengthTrackBar.Maximum = 50;
            this.PasswordLengthTrackBar.Minimum = 1;
            this.PasswordLengthTrackBar.Name = "PasswordLengthTrackBar";
            this.PasswordLengthTrackBar.Size = new System.Drawing.Size(915, 56);
            this.PasswordLengthTrackBar.TabIndex = 5;
            this.PasswordLengthTrackBar.Value = 1;
            this.PasswordLengthTrackBar.Scroll += new System.EventHandler(this.PasswordLengthTrackBar_Scroll);
            // 
            // GeneratePasswordBtn
            // 
            this.GeneratePasswordBtn.Location = new System.Drawing.Point(467, 340);
            this.GeneratePasswordBtn.Name = "GeneratePasswordBtn";
            this.GeneratePasswordBtn.Size = new System.Drawing.Size(116, 54);
            this.GeneratePasswordBtn.TabIndex = 6;
            this.GeneratePasswordBtn.Text = "Generate Password";
            this.GeneratePasswordBtn.UseVisualStyleBackColor = true;
            this.GeneratePasswordBtn.Click += new System.EventHandler(this.GeneratePasswordBtn_Click);
            // 
            // LengthLabel
            // 
            this.LengthLabel.AutoSize = true;
            this.LengthLabel.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LengthLabel.Location = new System.Drawing.Point(1162, 61);
            this.LengthLabel.Name = "LengthLabel";
            this.LengthLabel.Size = new System.Drawing.Size(28, 35);
            this.LengthLabel.TabIndex = 7;
            this.LengthLabel.Text = "1";
            this.LengthLabel.Click += new System.EventHandler(this.LengthLabel_Click);
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Label.Location = new System.Drawing.Point(508, 9);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(243, 41);
            this.Label.TabIndex = 8;
            this.Label.Text = "Password Length";
            this.Label.Click += new System.EventHandler(this.Label_Click);
            // 
            // CopyToClipBoardBtn
            // 
            this.CopyToClipBoardBtn.Location = new System.Drawing.Point(753, 340);
            this.CopyToClipBoardBtn.Name = "CopyToClipBoardBtn";
            this.CopyToClipBoardBtn.Size = new System.Drawing.Size(116, 54);
            this.CopyToClipBoardBtn.TabIndex = 9;
            this.CopyToClipBoardBtn.Text = "Copy to Clipboard";
            this.CopyToClipBoardBtn.UseVisualStyleBackColor = true;
            this.CopyToClipBoardBtn.Click += new System.EventHandler(this.CopyToClipBoardBtn_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.AutoSize = true;
            this.ErrorMessage.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.Location = new System.Drawing.Point(431, 213);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(0, 41);
            this.ErrorMessage.TabIndex = 10;
            this.ErrorMessage.Click += new System.EventHandler(this.ErrorMessage_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 579);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.CopyToClipBoardBtn);
            this.Controls.Add(this.Label);
            this.Controls.Add(this.LengthLabel);
            this.Controls.Add(this.GeneratePasswordBtn);
            this.Controls.Add(this.PasswordLengthTrackBar);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.Symbols);
            this.Controls.Add(this.IncludeNumbers);
            this.Controls.Add(this.IncludeLowerCase);
            this.Controls.Add(this.IncludeUppercase);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordLengthTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IncludeUppercase;
        private System.Windows.Forms.CheckBox IncludeLowerCase;
        private System.Windows.Forms.CheckBox IncludeNumbers;
        private System.Windows.Forms.CheckBox Symbols;
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TrackBar PasswordLengthTrackBar;
        private System.Windows.Forms.Button GeneratePasswordBtn;
        private System.Windows.Forms.Label LengthLabel;
        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.Button CopyToClipBoardBtn;
        private System.Windows.Forms.Label ErrorMessage;
    }
}

