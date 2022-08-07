using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace 일기장_예제
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            string folderPath = "./DATE/";
            DirectoryInfo di = new DirectoryInfo(folderPath);

            // 만약 폴더가 존재하지 않으면
            if (di.Exists == false)
            {
                di.Create();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"./DATE/" + TitleBox.Text + ".txt", "작성 시간 : " + DateTime.Now + Environment.NewLine + Environment.NewLine + contentBox.Text);
            MessageBox.Show("내용이 저장 되었습니다.");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void contentBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

