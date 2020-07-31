namespace WindowsKeyBinder
{
    partial class FormBind
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.PressKeyLabel = new System.Windows.Forms.Label();
            this.SetApplicationButton = new System.Windows.Forms.Button();
            this.ApplicationLabel = new System.Windows.Forms.Label();
            this.KeyLabel = new System.Windows.Forms.Label();
            this.ApplyChangesButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // KeyLabel
            // 
            this.PressKeyLabel.AutoSize = true;
            this.PressKeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PressKeyLabel.Location = new System.Drawing.Point(12, 25);
            this.PressKeyLabel.Name = "KeyLabel";
            this.PressKeyLabel.Size = new System.Drawing.Size(144, 20);
            this.PressKeyLabel.TabIndex = 7;
            this.PressKeyLabel.Text = "Press a Mouse Key";
            // 
            // SetApplicationButton
            // 
            this.SetApplicationButton.AutoSize = true;
            this.SetApplicationButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.SetApplicationButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetApplicationButton.Location = new System.Drawing.Point(12, 69);
            this.SetApplicationButton.Name = "SetApplicationButton";
            this.SetApplicationButton.Size = new System.Drawing.Size(132, 51);
            this.SetApplicationButton.TabIndex = 6;
            this.SetApplicationButton.Text = "Set Application";
            this.SetApplicationButton.UseVisualStyleBackColor = false;
            this.SetApplicationButton.Click += new System.EventHandler(this.SetApplicationButton_Click);
            // 
            // ApplicationLabel
            // 
            this.ApplicationLabel.AutoSize = true;
            this.ApplicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplicationLabel.Location = new System.Drawing.Point(210, 84);
            this.ApplicationLabel.Name = "ApplicationLabel";
            this.ApplicationLabel.Size = new System.Drawing.Size(140, 20);
            this.ApplicationLabel.TabIndex = 5;
            this.ApplicationLabel.Text = "No Application Set";
            // 
            // label1
            // 
            this.KeyLabel.AutoSize = true;
            this.KeyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyLabel.Location = new System.Drawing.Point(206, 25);
            this.KeyLabel.Name = "label1";
            this.KeyLabel.Size = new System.Drawing.Size(87, 20);
            this.KeyLabel.TabIndex = 8;
            this.KeyLabel.Text = "No key set ";
            // 
            // button1
            // 
            this.ApplyChangesButton.AutoSize = true;
            this.ApplyChangesButton.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ApplyChangesButton.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyChangesButton.Location = new System.Drawing.Point(313, 155);
            this.ApplyChangesButton.Name = "button1";
            this.ApplyChangesButton.Size = new System.Drawing.Size(132, 51);
            this.ApplyChangesButton.TabIndex = 9;
            this.ApplyChangesButton.Text = "Apply Changes";
            this.ApplyChangesButton.UseVisualStyleBackColor = false;
            this.ApplyChangesButton.Click += new System.EventHandler(this.ApplyChangesButton_Click);
            // 
            // FormBind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(807, 218);
            this.Controls.Add(this.ApplyChangesButton);
            this.Controls.Add(this.PressKeyLabel);
            this.Controls.Add(this.KeyLabel);
            this.Controls.Add(this.SetApplicationButton);
            this.Controls.Add(this.ApplicationLabel);
            this.Name = "FormBind";
            this.Text = "FormBind";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        public System.Windows.Forms.Label ApplicationLabel;
        private System.Windows.Forms.Button SetApplicationButton;
        public System.Windows.Forms.Label PressKeyLabel;
        public System.Windows.Forms.Label KeyLabel;
        private System.Windows.Forms.Button ApplyChangesButton;
    }
}