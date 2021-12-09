using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace THI
{
    public partial class Form1 : Form
    {
        // danh sách các câu hỏi thông qua class Question
        List<Questions> listQ = new List<Questions>();
        private int counter = 60;
        public Form1()
        {
            InitializeComponent();
        }

        // Bắt đầu làm bài 
        private void btnStart_Click(object sender, EventArgs e)
        {
            // thông tin nhân viên chưa được nhập thì không được bắt đầu thi
            if(txtHoten.Text == "" && txtMSSV.Text == "")
            {
                MessageBox.Show("VUI LONG DIEN THONG TIN  NHAN VIEN !!!");
            }
            else
            {
                LoadFilequestion();
                //đếm ngược thời gian thi
                timer.Start();
                LBLTime.Text = counter.ToString();
                
            }
        }

        // ĐỌC FILE XML XUẤT RA MÀN HÌNH Ở DẠNG TEXT BAO GỒM CÂU HỎI VÀ CÁC CÂU TRẢ LỜI
        private void LoadFilequestion()
        {
            XmlReader rd = XmlReader.Create("TEXT_1.xml");
            while (rd.ReadToFollowing("Question"))
            {
                Questions QS = new Questions();
                QS.id = rd.GetAttribute("id");
                rd.ReadToFollowing("Content");
                QS.Content = rd.ReadElementContentAsString();
                rd.ReadToFollowing("A");
                QS.A = rd.ReadElementContentAsString();
                rd.ReadToFollowing("B");
                QS.B = rd.ReadElementContentAsString();
                rd.ReadToFollowing("C");
                QS.C = rd.ReadElementContentAsString();
                rd.ReadToFollowing("D");
                QS.D = rd.ReadElementContentAsString();
                listQ.Add(QS);
            }
            rd.Close();
            txtReadfile.Text = listQ[0].id;
            // xuất câu hỏi đầu tiên và các câu trả lời ra màn hình
            txtReadfile.Text = listQ[0].Content;
            txtA.Text = listQ[0].A;
            txtB.Text = listQ[0].B;
            txtC.Text = listQ[0].C;
            txtD.Text = listQ[0].D;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            counter--;
            LBLTime.Text = counter.ToString();

            if (counter == 0)
            {
                timer.Stop();
                // thong bao het thoi gian lam bai khi time = 0
                MessageBox.Show("DA HET THOI GIAN LAM BAI, VUI LONG SUBMIT !!!");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            BackgroundImage = new Bitmap(@"img/backGround.jpg");
        }

        int index = 0;

        // CHUYỂN SANG CÂU KẾ TIẾP
        private void btnNext_Click(object sender, EventArgs e)
        {
            index++;
            if (index < listQ.Count)
            {
                txtReadfile.Text = listQ[index].Content;
                txtA.Text = listQ[index].A;
                txtB.Text = listQ[index].B;
                txtC.Text = listQ[index].C;
                txtD.Text = listQ[index].D;
            }
            else
                btnNext.Enabled = false;
            btnPrevious.Enabled = true;

            // thong bao het thoi gian lam bai khi time = 0
            if (counter == 0)
            {
                timer.Stop();
                MessageBox.Show("DA HET THOI GIAN LAM BAI, VUI LONG SUBMIT !!!");
            }
        }

        //CHUYỂN SANG CÂU TRƯỚC ĐÓ
        private void btnPrevious_Click(object sender, EventArgs e)
        {
            index--;
            if (index == -1)
            {
                btnPrevious.Enabled = false;
            }
            else
            {
                txtReadfile.Text = listQ[index].Content;
                txtA.Text = listQ[index].A;
                txtB.Text = listQ[index].B;
                txtC.Text = listQ[index].C;
                txtD.Text = listQ[index].D;
            }
            btnNext.Enabled = true;

            // thong bao het thoi gian lam bai khi time = 0
            if (counter == 0)
            {
                timer.Stop();
                MessageBox.Show("DA HET THOI GIAN LAM BAI, VUI LONG SUBMIT !!!");
            }
        }

        private void txtHoten_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
