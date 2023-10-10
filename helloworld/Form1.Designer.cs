namespace helloworld
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
            this.FristNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.fullNameLabel = new System.Windows.Forms.MaskedTextBox();
            this.showNameButton = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FristNameTextBox
            // 
            this.FristNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FristNameTextBox.Location = new System.Drawing.Point(337, 43);
            this.FristNameTextBox.Name = "FristNameTextBox";
            this.FristNameTextBox.Size = new System.Drawing.Size(274, 29);
            this.FristNameTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Enter Your Frist Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(94, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Your Last Name:";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastNameTextBox.Location = new System.Drawing.Point(337, 105);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(274, 29);
            this.LastNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(94, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "this is your full Name:";
            // 
            // fullNameLabel
            // 
            this.fullNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullNameLabel.Location = new System.Drawing.Point(337, 178);
            this.fullNameLabel.Name = "fullNameLabel";
            this.fullNameLabel.Size = new System.Drawing.Size(274, 29);
            this.fullNameLabel.TabIndex = 5;
            // 
            // showNameButton
            // 
            this.showNameButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showNameButton.Location = new System.Drawing.Point(155, 277);
            this.showNameButton.Name = "showNameButton";
            this.showNameButton.Size = new System.Drawing.Size(126, 39);
            this.showNameButton.TabIndex = 7;
            this.showNameButton.Text = "show name";
            this.showNameButton.UseVisualStyleBackColor = true;
            this.showNameButton.Click += new System.EventHandler(this.showNameButton_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(352, 277);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(126, 39);
            this.ExitButton.TabIndex = 8;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = true;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 425);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.showNameButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.fullNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FristNameTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox FristNameTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox LastNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox fullNameLabel;
        private System.Windows.Forms.Button showNameButton;
        private System.Windows.Forms.Button ExitButton;
    }
}

