using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

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
            }
        }

        private void btnResize_Click(object sender, EventArgs e)
        {
            if (selectedImage == null)
            {
                MessageBox.Show("Lütfen önce bir resim seçin.");
                return;
            }

            if (!int.TryParse(txtWidth.Text, out int cropWidth) || !int.TryParse(txtHeight.Text, out int cropHeight))
            {
                MessageBox.Show("Lütfen geçerli genişlik ve yükseklik değerleri girin.");
                return;
            }

            // Kırpma boyutları, resimden büyükse 
            if (cropWidth > selectedImage.Width || cropHeight > selectedImage.Height)
            {
                MessageBox.Show("Kırpma boyutları orijinal resimden büyük olamaz.");
                return;
            }

            Rectangle cropArea = new Rectangle(0, 0, cropWidth, cropHeight);

            if (rbRight.Checked)
            {
                // Sağdan kırpma
                cropArea = new Rectangle(selectedImage.Width - cropWidth, (selectedImage.Height - cropHeight) / 2, cropWidth, cropHeight);
            }
            else if (rbLeft.Checked)
            {
                // Soldan kırpma
                cropArea = new Rectangle(0, (selectedImage.Height - cropHeight) / 2, cropWidth, cropHeight);
            }
            else if (rbTop.Checked)
            {
                // Üstten kırpma
                cropArea = new Rectangle((selectedImage.Width - cropWidth) / 2, 0, cropWidth, cropHeight);
            }
            else if (rbBottom.Checked)
            {
                // Alttan kırpma
                cropArea = new Rectangle((selectedImage.Width - cropWidth) / 2, selectedImage.Height - cropHeight, cropWidth, cropHeight);
            }
            else if (rbCenter.Checked)
            {
                // Ortadan kırpma
                cropArea = new Rectangle((selectedImage.Width - cropWidth) / 2, (selectedImage.Height - cropHeight) / 2, cropWidth, cropHeight);
            }

            // Eğer orta seçildiyse, resmi olduğu gibi kalsın
            Bitmap resizedImage;
            if (rbCenter.Checked)
            {
                resizedImage = new Bitmap(selectedImage, new Size(cropWidth, cropHeight));
            }
            else
            {
                // Seçilen bölgeyi kırpma işlemi
                resizedImage = new Bitmap(cropArea.Width, cropArea.Height);
                using (Graphics g = Graphics.FromImage(resizedImage))
                {
                    g.DrawImage(selectedImage, new Rectangle(0, 0, cropArea.Width, cropArea.Height), cropArea, GraphicsUnit.Pixel);
                }
            }

            // kaliteyi al (%)
            long quality = 75L;
            if (int.TryParse(kalite.Text, out int parsedQuality))
            {
                quality = Math.Max(0, Math.Min(100, parsedQuality)); // 0 ile 100 arasında sınırla
            }

            // JPEG codec bilgilerini al
            ImageCodecInfo jpgEncoder = GetEncoder(ImageFormat.Jpeg);

            // Encoder parametrelerini ayarla (kalite için)
            EncoderParameters encoderParameters = new EncoderParameters(1);
            EncoderParameter qualityParameter = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            encoderParameters.Param[0] = qualityParameter;

            // dosya kaydetme işlemi
            string originalFilePath = openFileDialog.FileName;
            string fileName = Path.GetFileName(originalFilePath);
            string directory = Path.Combine("C:\\Resimler", DateTime.Now.ToString("yyyy"), DateTime.Now.ToString("MM"), DateTime.Now.ToString("dd"));

            Directory.CreateDirectory(directory);
            string saveFilePath = Path.Combine(directory, fileName);

            // belirlenen kalite ile kaydetme
            resizedImage.Save(saveFilePath, jpgEncoder, encoderParameters);

            MessageBox.Show("Resim başarıyla kaydedildi: " + saveFilePath);
        }

        // JPEG codec'i bul
        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();
            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }
        private void rbBottom_CheckedChanged(object sender, EventArgs e)
        {
            // rbBottom
        }
    }
}
