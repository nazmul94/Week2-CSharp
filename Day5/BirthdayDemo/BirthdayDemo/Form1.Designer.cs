namespace BirthdayDemo
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelMessage = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthdate = new System.Windows.Forms.DateTimePicker();
            this.birthdayMessageButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(420, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Please enter your name:";
            this.label1.Click += new System.EventHandler(this.Form1_Load);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 14.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(493, 57);
            this.label2.TabIndex = 1;
            this.label2.Text = "Please select your birthdate:";
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Location = new System.Drawing.Point(51, 370);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(93, 32);
            this.labelMessage.TabIndex = 2;
            this.labelMessage.Text = "label3";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(576, 113);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(851, 58);
            this.textBox1.TabIndex = 3;
            // 
            // dateTimePickerBirthdate
            // 
            this.dateTimePickerBirthdate.Font = new System.Drawing.Font("Modern No. 20", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthdate.Location = new System.Drawing.Point(576, 207);
            this.dateTimePickerBirthdate.Name = "dateTimePickerBirthdate";
            this.dateTimePickerBirthdate.Size = new System.Drawing.Size(851, 58);
            this.dateTimePickerBirthdate.TabIndex = 4;
            this.dateTimePickerBirthdate.ValueChanged += new System.EventHandler(this.dateTimePickerBirthdate_ValueChanged);
            // 
            // birthdayMessageButton
            // 
            this.birthdayMessageButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthdayMessageButton.Location = new System.Drawing.Point(266, 472);
            this.birthdayMessageButton.Name = "birthdayMessageButton";
            this.birthdayMessageButton.Size = new System.Drawing.Size(957, 125);
            this.birthdayMessageButton.TabIndex = 5;
            this.birthdayMessageButton.Text = "Get your birthday message";
            this.birthdayMessageButton.UseVisualStyleBackColor = true;
            this.birthdayMessageButton.Click += new System.EventHandler(this.birthdayMessageButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(505, 661);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(517, 83);
            this.closeButton.TabIndex = 6;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1485, 923);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.birthdayMessageButton);
            this.Controls.Add(this.dateTimePickerBirthdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthdate;
        private System.Windows.Forms.Button birthdayMessageButton;
        private System.Windows.Forms.Button closeButton;
    }
}

