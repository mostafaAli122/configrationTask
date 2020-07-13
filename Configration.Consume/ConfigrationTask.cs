using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Configration.Consume
{
    public partial class ConfigrationTask : Form
    {
        ServiceReference1.ConfigrationServiceClient Service;

        public ConfigrationTask()
        {
            InitializeComponent();
            Service = new ServiceReference1.ConfigrationServiceClient("default");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //ITI Branch Tab
            cmbBranch.DataSource = Service.GetAllITIBranches();
            cmbBranch.DisplayMember = "Name";
            cmbBranch.ValueMember = "ID";

            
            cmbBranchConfigKey.DataSource = Service.GetAllBranchesConfigKeys();
            cmbBranchConfigKey.DisplayMember = "Name";
            cmbBranchConfigKey.ValueMember = "ID";


            //Student Tab
            cmbStudent.DataSource = Service.GetAllStudents();
            cmbStudent.DisplayMember = "Name";
            cmbStudent.ValueMember = "ID";

            cmbStudentConfigKey.DataSource = Service.GetAllStudentsConfigKeys();
            cmbStudentConfigKey.DisplayMember = "Name";
            cmbStudentConfigKey.ValueMember = "ID";

            //Instructor Tab
            cmbInstructor.DataSource = Service.GetAllInstructors();
            cmbInstructor.DisplayMember = "Name";
            cmbInstructor.ValueMember = "ID";

            cmbInstructorConfigKey.DataSource = Service.GetAllInstructorsConfigKeys();
            cmbInstructorConfigKey.DisplayMember = "Name";
            cmbInstructorConfigKey.ValueMember = "ID";
        }

        private void cmbBranchConfigKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            int branchId = Convert.ToInt32(cmbBranch.SelectedValue);
            bool ok = Int32.TryParse(cmbBranchConfigKey.SelectedValue.ToString(),out int branchConfigureKeyId);

            tbBranchConfigValue.Text = Service.GetITIBranchConfigValue(branchId, branchConfigureKeyId);
        }

        private void cmbStudentConfigKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            int StudentId = Convert.ToInt32(cmbStudent.SelectedValue);
            bool ok = Int32.TryParse(cmbStudentConfigKey.SelectedValue.ToString(),out int StudentConfigureKeyId);

            tbStudentConfigValue.Text = Service.GetITIBranchConfigValue(StudentId, StudentConfigureKeyId);
        }

        private void cmbInstructorConfigKey_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Int32.TryParse(cmb.SelectedValue.ToString(), out selectedValue);
            int InstructorId = Convert.ToInt32(cmbInstructor.SelectedValue);
            bool ok  = Int32.TryParse(cmbInstructorConfigKey.SelectedValue.ToString(),out int InstructorConfigureKeyId);

            tbInstructorConfigValue.Text = Service.GetITIBranchConfigValue(InstructorId, InstructorConfigureKeyId);
        }
    }
}
