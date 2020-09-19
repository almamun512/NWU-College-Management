using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NWU_College_Management
{
    public partial class Admission_Form : Form
    {
        public Admission_Form()
        {
            InitializeComponent();
        }

        private void Admission_Form_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtFullName.Text;
            String fname = txtFatherName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            Int64 mobile = Int64.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String program = txtProgram.Text;
            String duration = TxtDuration.Text;
            String add = txtAddress.Text;

            SqlConnection con = new SqlConnection();
            con.ConnectionString = "data source =DESKTOP-KH5J0BA\\MSSQLLocalDB; database = college;integrated security=True";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into NewAdmission (fname,faname,gender,dob,mobile,email,semester,prog,duration,addres) values ('" + name + "','" + fname + "','" + gender + "','" + dob + "'," + mobile + ",'" + email + "','" + semester + "','" + program + "','" + duration + "','" + add + "')";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Saved. Remember the Registration ID", "Data", MessageBoxButtons.OK, MessageBoxIcon.Hand);
        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtFatherName.Clear();
            radioButtonMale.Checked = false;
            radioButtonFemale.Checked = false;
            txtAddress.Clear();
            txtEmail.Clear();
            txtMobile.Clear();
            txtProgram.ResetText();
            txtSemester.ResetText();
            TxtDuration.ResetText();
        }
    }
}
