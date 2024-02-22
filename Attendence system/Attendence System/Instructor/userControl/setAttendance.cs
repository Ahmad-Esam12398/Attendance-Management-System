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
using System.Xml.Linq;

namespace attendence_system.Instructor.userControl
{
    public partial class setAttendance : UserControl
    {
        public setAttendance()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void setAttendance_Load(object sender, EventArgs e)
        {
            //DataSet AttendanceData = new DataSet();
            //AttendanceData.ReadXml("D:\\ITI\\Projects\\XML&C#\\new repo\\mine\\Attendance-Management-System\\XmldummyData.xml");
            string dummyDataPath = Path.Combine(Application.StartupPath, @"../../../../../Xml/dummyData.xml");
            //DataSet dataSet = new DataSet();
            //dataSet.ReadXml(path);
            //dataGridViewAttendance.DataSource = dataSet.Tables[1];


        }
        private void populateDataGirdView()
        {
            string dummyDataPath = Path.Combine(Application.StartupPath, @"../../../../../Xml/dummyData.xml");
            XmlDocument doc = new XmlDocument();
            doc.Load(dummyDataPath);
            XmlNodeList nodeList = doc.SelectNodes("studentsRecords/class");
            foreach (XmlNode node in nodeList)
            {
                string id = node.SelectSingleNode("id").InnerText;
                string name = node.SelectSingleNode("name").InnerText;
                string status = node.SelectSingleNode("status").InnerText;
                dataGridViewAttendance.Rows.Add(id, name, status);
            }
        }
    }
}
