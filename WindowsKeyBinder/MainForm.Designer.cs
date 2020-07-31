namespace WindowsKeyBinder
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputLabel = new System.Windows.Forms.Label();
            this.AddBind = new System.Windows.Forms.Button();
            this.BindListBox = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.RemoveBind = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InputLabel.Location = new System.Drawing.Point(96, 246);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(70, 20);
            this.InputLabel.TabIndex = 0;
            this.InputLabel.Text = "No Input";
            // 
            // AddBind
            // 
            this.AddBind.AutoSize = true;
            this.AddBind.BackColor = System.Drawing.SystemColors.HighlightText;
            this.AddBind.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddBind.Location = new System.Drawing.Point(75, 92);
            this.AddBind.Name = "AddBind";
            this.AddBind.Size = new System.Drawing.Size(132, 51);
            this.AddBind.TabIndex = 1;
            this.AddBind.Text = "ADD BIND";
            this.AddBind.UseVisualStyleBackColor = false;
            this.AddBind.Click += new System.EventHandler(this.AddBind_Click);
            // 
            // BindListBox
            // 
            this.BindListBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.BindListBox.FormattingEnabled = true;
            this.BindListBox.Location = new System.Drawing.Point(255, 92);
            this.BindListBox.Name = "BindListBox";
            this.BindListBox.Size = new System.Drawing.Size(456, 184);
            this.BindListBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Font = new System.Drawing.Font("Microsoft PhagsPa", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(255, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(456, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // RemoveBind
            // 
            this.RemoveBind.AutoSize = true;
            this.RemoveBind.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RemoveBind.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBind.Location = new System.Drawing.Point(75, 163);
            this.RemoveBind.Name = "RemoveBind";
            this.RemoveBind.Size = new System.Drawing.Size(132, 51);
            this.RemoveBind.TabIndex = 4;
            this.RemoveBind.Text = "REMOVE BIND";
            this.RemoveBind.UseVisualStyleBackColor = false;
            this.RemoveBind.Click += new System.EventHandler(this.RemoveBind_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(759, 300);
            this.Controls.Add(this.RemoveBind);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BindListBox);
            this.Controls.Add(this.AddBind);
            this.Controls.Add(this.InputLabel);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "MainForm";
            this.Text = "Windows KEY Binder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.Button AddBind;
        public System.Windows.Forms.CheckedListBox BindListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button RemoveBind;
    }
    #endregion
}

