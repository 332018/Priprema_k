using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class FormIspis : Form
    {
        private readonly StudentBussiness studentBussiness;
        public FormIspis()
        {
            this.studentBussiness = new StudentBussiness();
            InitializeComponent();
        }

        private void FormIspis_Load(object sender, EventArgs e)
        {
            FillList();
        }

       public void FillList()
        {
            listBoxIspis.Items.Clear();
            List<Student> students = this.studentBussiness.GetStudents();

            foreach (Student s in students)
            {
                listBoxIspis.Items.Add(s.Id + "." + s.Name + "," + s.IndexNumber + "," + s.AverageMark + " ");
            }
        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            Student s = new Student();
            s.Name = textBoxIme.Text;
            s.IndexNumber = textBoxIndex.Text;
            s.AverageMark = Convert.ToDecimal(textBoxOcena.Text);

            bool result = this.studentBussiness.InsertStudent(s);

            if(result)
            {
                FillList();
                MessageBox.Show("Uspesan unos!");
                textBoxIme.Text = " ";
                textBoxIndex.Text = " ";
                textBoxOcena.Text = " ";
            }
            else
            {
                MessageBox.Show("Neuspesan unos!");
            }
        }

        private void buttonVrati_Click(object sender, EventArgs e)
        {
            listBoxIspis.Items.Clear();
            decimal pr;
            pr = Convert.ToDecimal(textBoxProsek.Text);
            List<Student> students = this.studentBussiness.GetStudentsWithMark(pr);
            foreach (Student s in students)
            {
                listBoxIspis.Items.Add(s.Id + "." + s.Name + "," + s.IndexNumber + "," + s.AverageMark + " ");
            }
        }
    }
}
