using System.Drawing.Imaging;
using System.Windows.Forms;

namespace ConvertToBase64
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private string ImageToBase64(Image image, System.Drawing.Imaging.ImageFormat format)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, format);
                byte[] imageBytes = ms.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }
        private void btnChange64_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "PNG Files|*.png";
            openFileDialog.Title = "Select a PNG file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                Image image = Image.FromFile(filePath);
                string base64String = ImageToBase64(image, System.Drawing.Imaging.ImageFormat.Png);
                txbBase64.Text = base64String;
            }
        }
        private Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                return Image.FromStream(ms);
            }
        }
        private void ChangePNG_Click(object sender, EventArgs e)
        {
            string base64String = txtInBase64.Text;
            if (string.IsNullOrWhiteSpace(base64String))
            {
                MessageBox.Show("Please enter or paste a Base64 string.");
                return;
            }

            try
            {
                // Chuyển đổi Base64 thành ảnh
                Image image = Base64ToImage(base64String);

                // Mở hộp thoại để chọn nơi lưu tệp ảnh
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "PNG Files|*.png";
                saveFileDialog.Title = "Save Image File";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Lưu ảnh vào tệp
                    string filePath = saveFileDialog.FileName;
                    image.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                    MessageBox.Show("Image saved successfully!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
