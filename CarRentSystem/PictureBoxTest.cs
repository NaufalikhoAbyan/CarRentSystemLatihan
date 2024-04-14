using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using Image = System.Drawing.Image;

namespace CarRentSystem
{
    public partial class PictureBoxTest : Form
    {
        public PictureBoxTest()
        {
            InitializeComponent();
        }

        private void uploadButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = new Bitmap(ofd.FileName);

                carsTableAdapter.InsertQuery("Toyota", "AB", "Red", "2008-11-11", 1, "20000", 1, Save_Image(pictureBox1));
;           }
        }

        public byte[] Save_Image(PictureBox pb)
        {
            MemoryStream ms = new MemoryStream();
            pb.Image.Save(ms, pb.Image.RawFormat);
            return ms.ToArray();
        }

        public Image Display_Image(byte[] photo)
        {
            MemoryStream ms = new MemoryStream(photo);
            return Image.FromStream(ms);
        }   

        private void showButton_Click(object sender, EventArgs e)
        {
            DataRow car = carsTableAdapter.GetData().Rows[0];
            pictureBox2.Image = Display_Image((byte[])car["image"]);
        }
    }
}
