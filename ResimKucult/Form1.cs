using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace ResimKucult
{
    public partial class Form1 : Form
    {
        private Bitmap selectedImage;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnSelectImage_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                selectedImage = new Bitmap(openFileDialog.FileName);
                pictureBox.Image = selectedImage;
                lblImageSize.Text = $"Orijinal Boyut: {selectedImage.Width} x {selectedImage.Height}";

                // Genişlik ve yükseklik için girilen değerleri kontrol et
                if (int.TryParse(txtWidth.Text, out int newWidth) && int.TryParse(txtHeight.Text, out int newHeight))
                {
                    // Girilen boyutlardan en küçüğünü bul
                    int minTargetSize = Math.Min(newWidth, newHeight);

                    // Aspect ratio hesaplaması
                    float aspectRatio = (float)selectedImage.Width / selectedImage.Height;

                    // Resmin yeni boyutlarını hesapla
                    int resizedWidth;
                    int resizedHeight;

                    // En küçük kenarı yeni değer olarak belirle ve diğer kenarı orantılı küçült
                    if (aspectRatio > 1) // Genişlik daha büyük
                    {
                        resizedHeight = minTargetSize;
                        resizedWidth = (int)(resizedHeight * aspectRatio);
                    }
                    else // Yükseklik daha büyük
                    {
                        resizedWidth = minTargetSize;
                        resizedHeight = (int)(resizedWidth / aspectRatio);
                    }

                    // Fark bilgisi
                    int widthDifference = resizedWidth - newWidth;
                    int heightDifference = resizedHeight - newHeight;

                    // Fark bilgisi label'a yazdırılıyor
                    lblResizeInfo.Text = $"Küçültme Boyutu: {resizedWidth}x{resizedHeight} \n" +
                                         $"Yükseklik farkı: {heightDifference} px, Genişlik farkı: {widthDifference} px. Nereden kırpılsın?";

                    // Kesim yönü kontrolü için butonları aktif hale getirme
                    rbLeft.Enabled = widthDifference > 0;
                    rbRight.Enabled = widthDifference > 0;
                    rbCenter.Enabled = widthDifference > 0 || heightDifference > 0;
                    rbTop.Enabled = heightDifference > 0;
                    rbBottom.Enabled = heightDifference > 0;
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli genişlik ve yükseklik değerleri girin.");
                }
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (selectedImage == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int newWidth) || !int.TryParse(txtHeight.Text, out int newHeight))
            {
                MessageBox.Show("Lütfen geçerli genişlik ve yükseklik değerleri girin.");
                return;
            }

            // Aspect ratio hesaplaması
            float aspectRatio = (float)selectedImage.Width / selectedImage.Height;
            float targetAspectRatio = (float)newWidth / newHeight;

            int croppedWidth = selectedImage.Width;
            int croppedHeight = selectedImage.Height;

            if (aspectRatio > targetAspectRatio)
            {
                // Genişlik fazla, sağdan ve soldan kesim yapılacak
                croppedWidth = (int)(selectedImage.Height * targetAspectRatio);
            }
            else
            {
                // Yükseklik fazla, üstten ve alttan kesim yapılacak
                croppedHeight = (int)(selectedImage.Width / targetAspectRatio);
            }

            // Kesim yönü
            int offsetX = (selectedImage.Width - croppedWidth) / 2;
            int offsetY = (selectedImage.Height - croppedHeight) / 2;

            if (rbTop.Checked) // Üstten kesim
            {
                offsetY = 0;
            }
            else if (rbBottom.Checked) // Alttan kesim
            {
                offsetY = selectedImage.Height - croppedHeight;
            }
            else if (rbCenter.Checked) // Ortala
            {
                offsetY = (selectedImage.Height - croppedHeight) / 2;
            }

            if (croppedWidth > newWidth) // Genişlik fazlaysa
            {
                if (rbLeft.Checked) // Soldan kesim
                {
                    offsetX = 0;
                }
                else if (rbRight.Checked) // Sağdan kesim
                {
                    offsetX = selectedImage.Width - croppedWidth;
                }
                else if (rbCenter.Checked) // Ortala
                {
                    offsetX = (selectedImage.Width - croppedWidth) / 2;
                }
            }

            // Kesim işlemi
            Bitmap croppedImage = new Bitmap(newWidth, newHeight);
            using (Graphics g = Graphics.FromImage(croppedImage))
            {
                g.DrawImage(selectedImage, new Rectangle(0, 0, newWidth, newHeight), new Rectangle(offsetX, offsetY, croppedWidth, croppedHeight), GraphicsUnit.Pixel);
            }

            // Dosyayı kaydetme
            string originalFilePath = openFileDialog.FileName; // Seçilen resmin tam yolu
            string fileName = Path.GetFileName(originalFilePath); // Dosya adını al
            string directory = Path.Combine("C:\\Resimler", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

            Directory.CreateDirectory(directory);
            string saveFilePath = Path.Combine(directory, fileName); // Kaydedilecek tam dosya yolu

            croppedImage.Save(saveFilePath);

            MessageBox.Show("Resim başarıyla kaydedildi: " + saveFilePath);
        }

    }
}
