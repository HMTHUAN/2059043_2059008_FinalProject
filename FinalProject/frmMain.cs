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
using System.Xml;

namespace FinalProject
{
    public partial class frmMain : Form
    {
        BindingList<Questions> lbsQuestion = new BindingList<Questions>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadQuestionLIST();
        }

        private void LoadQuestionLIST()
        {
            XmlReader rd = XmlReader.Create("Detail_1.xml");
            while (rd.ReadToFollowing("Question"))
            {
                Questions QS = new Questions();
                QS.ID = int.Parse(rd.GetAttribute("id"));
                rd.ReadToFollowing("Content");
                QS.Content = rd.ReadElementContentAsString();
                rd.ReadToFollowing("Answers");
                QS.ABC = rd.ReadElementContentAsString();
                lbsQuestion.Add(QS);
            }
            rd.Close();
            lbsQuestions.DataSource = lbsQuestion;
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            Questions QS = new Questions();
            QS.ID = lbsQuestion.Count + 1;
            QS.Content = txtContent.Text;
            QS.ABC = txtABC.Text;

            lbsQuestion.Add(QS);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            XmlWriter writer = XmlWriter.Create("Detail_1.xml", new XmlWriterSettings() { Indent = true });
            
            writer.WriteStartElement("Questions");

            foreach(Questions Question in lbsQuestion)
            {
                writer.WriteStartElement("Question");
                writer.WriteAttributeString("id", Question.ID.ToString());

                writer.WriteStartElement("Content");
                writer.WriteValue(Question.Content);
                writer.WriteEndElement();

                writer.WriteStartElement("Answers");
                writer.WriteValue(Question.ABC);
                writer.WriteEndElement();

                writer.WriteEndElement();

            }
            writer.WriteEndElement();
            writer.Close();
        }
    }
}
