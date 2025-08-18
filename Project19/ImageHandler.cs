using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project19
{
    internal class ImageHandler
    {

        private readonly string _ImageStorageFolder = "D:\\DVLD PICS";


        public string SaveImageToFile(Image image)
        {
            try
            {
                //insure Folder existe /creat New
                if (!Directory.Exists(_ImageStorageFolder))
                {
                    Directory.CreateDirectory(_ImageStorageFolder);
                }

                // generate unique file Name

                string fileName = $"{Guid.NewGuid()}.jpg";

                string fullPath = Path.Combine(_ImageStorageFolder, fileName);

                //saving 
                image.Save(fullPath, System.Drawing.Imaging.ImageFormat.Jpeg);
                return fullPath;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Saving Picture Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
            
        }

        public string SelectAndSaveImage()
        {
            using (OpenFileDialog openFileDialog1 = new OpenFileDialog())
            {
                openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image SelectedImage = Image.FromFile(openFileDialog1.FileName))
                        {
                            string SavedImagePAth =  SaveImageToFile(SelectedImage);
                            if (SavedImagePAth != null)
                            {
                                MessageBox.Show("Image Saved Successfully!","Saved", MessageBoxButtons.OK);
                                return SavedImagePAth;
                            }
                            else
                            {
                                MessageBox.Show("Image Not Saved ", "Saved", MessageBoxButtons.OK,MessageBoxIcon.Error);
                            }

                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error Loading image: ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return null;
                    }
                }
            }
            return null;
        }



    }
}
