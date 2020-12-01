using BusinessLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PresentationLayerWeb
{
    public partial class _Default : Page
    {
        private  StudentBussiness studentBussiness;
        protected void Page_Load(object sender, EventArgs e)
        {
            this.studentBussiness = new StudentBussiness();

            List<Student> students = this.studentBussiness.GetStudents();

            foreach (Student s in students)
            {
                listBoxIspis.Items.Add(s.Id + "." + s.Name + "," + s.IndexNumber + "," + s.AverageMark + " ");
            }
        }
    }
}