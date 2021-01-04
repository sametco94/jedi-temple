using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageConverter_SametColak_Lunes
{
    public partial class Form1 : Form
    {
		bool val;
		public Form1()
		{
			InitializeComponent();
			
			TypeBox.SelectedItem = "PNG";
			TypeBox.SelectedItem = "BMP";
			TypeBox.SelectedItem = "JPG";
			TypeBox.SelectedItem = "GIF";
			TypeBox.SelectedItem = "JPEG";		
		}

		private void BrowseButton_Click(object sender, EventArgs e)
        {
			{

				try
				{					
					if (OFDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
					{
						PicBox.Image = Image.FromFile(OFDialog.FileName);
						PicBox.SizeMode = PictureBoxSizeMode.StretchImage;						
						val = true;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}
		}

        private void ConvertButton_Click(object sender, EventArgs e)
		{
			
		}

        private void TypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PicBox_Click(object sender, EventArgs e)
        {

        }

        private void saveFileDialog_FileOk(object sender, CancelEventArgs e)
        {
			
		}

        private void OFDialog_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void ConvertButton_Click_1(object sender, EventArgs e)
        {
			{
				try
				{
					if (val == true)
					{
						if ((string)TypeBox.SelectedItem == "PNG")
						{
							saveFileDialog.Filter = "PNG|*.png";
							if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
							{
								PicBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Png);
							}

						}
						else if ((string)TypeBox.SelectedItem == "JPEG")
						{
							saveFileDialog.Filter = "JPEG|*.jpeg";
							if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
							{
								PicBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
							}
						}
						else if ((string)TypeBox.SelectedItem == "BMP")
						{
							saveFileDialog.Filter = "BMP|*.bmp";
							if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
							{
								PicBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Bmp);
							}
						}
						else if ((string)TypeBox.SelectedItem == "JPG")
						{
							saveFileDialog.Filter = "JPG|*.jpg";
							if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
							{
								PicBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
							}
						}
						else if ((string)TypeBox.SelectedItem == "GIF")
						{
							saveFileDialog.Filter = "GIF|*.gif";
							if (saveFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
							{
								PicBox.Image.Save(saveFileDialog.FileName, System.Drawing.Imaging.ImageFormat.Gif);
							}
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message);
				}
			}			
		}
    }
}
