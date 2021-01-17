namespace _02_BitmapPlayground
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.ApplyFilterButton = new System.Windows.Forms.Button();
            this.FilterPickerBox = new System.Windows.Forms.ComboBox();
            this.PictureBoxFiltered = new System.Windows.Forms.PictureBox();
            this.PictureBoxOriginal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFiltered)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // ApplyFilterButton
            // 
            this.ApplyFilterButton.Location = new System.Drawing.Point(460, 146);
            this.ApplyFilterButton.Name = "ApplyFilterButton";
            this.ApplyFilterButton.Size = new System.Drawing.Size(75, 74);
            this.ApplyFilterButton.TabIndex = 2;
            this.ApplyFilterButton.Text = ">";
            this.ApplyFilterButton.UseVisualStyleBackColor = true;
            this.ApplyFilterButton.Click += new System.EventHandler(this.ApplyFilterButton_Click);
            // 
            // FilterPickerBox
            // 
            this.FilterPickerBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FilterPickerBox.FormattingEnabled = true;
            this.FilterPickerBox.Location = new System.Drawing.Point(438, 226);
            this.FilterPickerBox.Name = "FilterPickerBox";
            this.FilterPickerBox.Size = new System.Drawing.Size(121, 21);
            this.FilterPickerBox.TabIndex = 3;
            this.FilterPickerBox.SelectedIndexChanged += new System.EventHandler(this.FilterPickerBox_SelectedIndexChanged);
            // 
            // PictureBoxFiltered
            // 
            this.PictureBoxFiltered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PictureBoxFiltered.Location = new System.Drawing.Point(571, 12);
            this.PictureBoxFiltered.Name = "PictureBoxFiltered";
            this.PictureBoxFiltered.Size = new System.Drawing.Size(386, 385);
            this.PictureBoxFiltered.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxFiltered.TabIndex = 1;
            this.PictureBoxFiltered.TabStop = false;
            // 
            // PictureBoxOriginal
            // 
            this.PictureBoxOriginal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.PictureBoxOriginal.Image = global::_02_BitmapPlayground.Properties.Resources.Istanbul;
            this.PictureBoxOriginal.Location = new System.Drawing.Point(12, 12);
            this.PictureBoxOriginal.Name = "PictureBoxOriginal";
            this.PictureBoxOriginal.Size = new System.Drawing.Size(411, 385);
            this.PictureBoxOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBoxOriginal.TabIndex = 0;
            this.PictureBoxOriginal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 409);
            this.Controls.Add(this.FilterPickerBox);
            this.Controls.Add(this.ApplyFilterButton);
            this.Controls.Add(this.PictureBoxFiltered);
            this.Controls.Add(this.PictureBoxOriginal);
            this.Name = "Form1";
            this.Text = "Bitmap playground";
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxFiltered)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBoxOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PictureBoxOriginal;
        private System.Windows.Forms.PictureBox PictureBoxFiltered;
        private System.Windows.Forms.Button ApplyFilterButton;
        private System.Windows.Forms.ComboBox FilterPickerBox;
    }
}

