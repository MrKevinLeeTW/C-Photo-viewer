using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.IO;

namespace Photo_viewer
{
    public partial class Form1 : Form
    {
        // 保存打開圖片的路徑
        string imgPath = null;
        Image newbitmap = null;
        // 打開圖片的目錄
        string directory = null;

        // 目錄下的圖片集合
        List<string> imgArray = null;

        public Form1()
        {
            InitializeComponent();

            left.Visible = false;
            right.Visible = false;
            automatic.Visible = false;

        }

        private void select_Click(object sender, System.EventArgs e)
        {
            using (OpenFileDialog fileDialog = new OpenFileDialog())
            {
                fileDialog.Filter = "圖片文件(*.jpg;*.bmp;*.png)|*.jpg;*.bmp;*.png|(All file(*.*)|*.*";
                fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                    imgPath = fileDialog.FileName;
                    // 初始化圖片集合
                    directory = Path.GetDirectoryName(imgPath);
                    imgArray = ImageManager.GetImgCollection(directory);

                    newbitmap = (Bitmap)Image.FromFile(imgPath);
                    pictureBox1.Image = newbitmap;
                }
                left.Visible = true;
                right.Visible = true;
                automatic.Visible = true;

                label1.Text = imgPath;  //顯示位置

            }
        }

        private void right_Click(object sender, System.EventArgs e)
        {
            int index = GetIndex(imgPath);
            // 釋放上一張圖片的资源，避免保存的时候出現ExternalException異常
            newbitmap.Dispose();
            if (index != imgArray.Count - 1)
            {
                SwitchImg(index + 1);
            }
            else
            {
                SwitchImg(0);
            }
            label1.Text = imgPath;  //顯示位置
        }

        private void left_Click(object sender, System.EventArgs e)
        {
            int index = GetIndex(imgPath);
            // 釋放上一張圖片的资源，避免保存的时候出現ExternalException異常
            newbitmap.Dispose();
            if (index == 0)
            {
                SwitchImg(imgArray.Count - 1);
            }
            else
            {
                SwitchImg(index - 1);
            }
            label1.Text = imgPath;  //顯示位置
        }
        // 獲得打開圖片在圖片集合中的索引
        private int GetIndex(string imagepath)
        {
            int index = 0;
            for (int i = 0; i < imgArray.Count; i++)
            {
                if (imgArray[i].Equals(imagepath))
                {
                    index = i;
                    break;
                }
            }

            return index;
        }

        // 切换圖片的方法
        private void SwitchImg(int index)
        {
            newbitmap = Image.FromFile(imgArray[index]);
            pictureBox1.Image = newbitmap;
            imgPath = imgArray[index];
        }

        public class ImageManager
        {
            // 獲得預覽圖片文件路徑下的圖片集合
            public static List<string> GetImgCollection(string path)
            {
                string[] imgarray = Directory.GetFiles(path);
                var result = from imgstring in imgarray
                             where imgstring.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                             imgstring.EndsWith("png", StringComparison.OrdinalIgnoreCase) ||
                             imgstring.EndsWith("bmp", StringComparison.OrdinalIgnoreCase)
                             select imgstring;
                return result.ToList();
            }
        }

        private void automatic_Click(object sender, System.EventArgs e)
        {
            if (timer1.Enabled == false)
            {
                timer1.Enabled = true;
            }
            else
            {
                timer1.Enabled = false;
            }      
        }

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            right_Click(sender, e);
        }


    }
}
