
namespace ImageConverter_SametColak_Lunes
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.PicBox = new System.Windows.Forms.PictureBox();
            this.BrowseButton = new System.Windows.Forms.Button();
            this.ConvertButton = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.OFDialog = new System.Windows.Forms.OpenFileDialog();
            this.TypeBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PicBox
            // 
            this.PicBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.PicBox.Location = new System.Drawing.Point(30, 12);
            this.PicBox.Name = "PicBox";
            this.PicBox.Size = new System.Drawing.Size(500, 400);
            this.PicBox.TabIndex = 0;
            this.PicBox.TabStop = false;
            this.PicBox.Click += new System.EventHandler(this.PicBox_Click);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.BrowseButton.Location = new System.Drawing.Point(574, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(200, 40);
            this.BrowseButton.TabIndex = 1;
            this.BrowseButton.Text = "Browse Image";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // ConvertButton
            // 
            this.ConvertButton.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConvertButton.Location = new System.Drawing.Point(574, 190);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(200, 40);
            this.ConvertButton.TabIndex = 2;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            this.ConvertButton.Click += new System.EventHandler(this.ConvertButton_Click_1);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // OFDialog
            // 
            this.OFDialog.FileName = "Choose Image";
            this.OFDialog.Title = "Choose Image";
            this.OFDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.OFDialog_FileOk);
            // 
            // TypeBox
            // 
            this.TypeBox.DropDownWidth = 100;
            this.TypeBox.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TypeBox.FormattingEnabled = true;
            this.TypeBox.Items.AddRange(new object[] {
            "PNG",
            "BMP",
            "JPG",
            "GIF",
            "JPEG"});
            this.TypeBox.Location = new System.Drawing.Point(574, 60);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(200, 25);
            this.TypeBox.TabIndex = 3;
            this.TypeBox.Text = "Choose Type";
            this.TypeBox.SelectedIndexChanged += new System.EventHandler(this.TypeBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PicBox);
            this.Controls.Add(this.BrowseButton);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.ConvertButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PicBox;
        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog OFDialog;
        private System.Windows.Forms.ComboBox TypeBox;
    }
}

