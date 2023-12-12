using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FTU_StudentOnlineService
{
    public partial class RegistrationDepartment : Form
    {
        internal DataValidation dv = new DataValidation();
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.PeachPuff;
        private Color StandForeColor = Color.Black;

        public string status = "None";
        public RegistrationDepartment()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationDepartment_Load(object sender, EventArgs e)
        {
            btn_View.PerformClick();
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            
        }

        private void table_department_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_department.ReadOnly = true;
            if (table_department.RowCount > 1)
                if (table_department.CurrentRow != null)
                {
                    int rowindex = table_department.CurrentCell.RowIndex;
                    if (table_department.Rows.Count - 2 >= rowindex)
                    {
                        string a = table_department.Rows[rowindex].Cells[0].Value.ToString();
                        string b = table_department.Rows[rowindex].Cells[1].Value.ToString();
                        string c = table_department.Rows[rowindex].Cells[2].Value.ToString();
                        string d = table_department.Rows[rowindex].Cells[3].Value.ToString();
                        string ee = table_department.Rows[rowindex].Cells[4].Value.ToString();
                        string f = table_department.Rows[rowindex].Cells[5].Value.ToString();

                        tb_departmentID.Text = a;
                        tb_departmemtName.Text = b;
                        tb_contactEmail.Text = c;
                        tb_contactPhone.Text = d;
                        tb_location.Text = ee;
                        tb_responsibilities.Text = f;
                    }
                }
        }

        private void btn_edit_Enter(object sender, EventArgs e)
        {
            if (status != "None")
            {
                status = "Update";
                txt_status.Text = "Status " + status;
                tb_departmemtName.Enabled = true;
                tb_contactEmail.Enabled = true;
                tb_contactPhone.Enabled = true;
                tb_location.Enabled = true;
                tb_responsibilities.Enabled = true;

                btn_update.BackColor = ClickBackColor;
                btn_update.ForeColor = ClickForeColor;

                btn_View.BackColor = StandBackColor;
                btn_View.ForeColor = StandForeColor;

                btn_add.ForeColor = StandForeColor;
                btn_add.BackColor = StandBackColor;

            }
            else
            {
                MessageBox.Show("You Should Click View First !!!!!");
            }
        }
        private bool AreFieldsValid()
        {
            return
                   !string.IsNullOrEmpty(tb_departmemtName.Text) &&
                   !string.IsNullOrEmpty(tb_contactEmail.Text) &&
                   !string.IsNullOrEmpty(tb_contactPhone.Text) &&
                    dv.IsPhoneNumberValid(tb_contactPhone.Text)&&
                   !string.IsNullOrEmpty(tb_location.Text) &&
                   !string.IsNullOrEmpty(tb_responsibilities.Text);
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (status == "Update")
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to save this Users?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    DepartmentDAO dDAO = new DepartmentDAO();
                    try
                    {
                        if (AreFieldsValid())
                        {
                            Department d = new Department(tb_departmentID.Text, tb_departmemtName.Text, tb_contactEmail.Text, tb_contactPhone.Text, tb_location.Text, tb_responsibilities.Text);
                            dDAO.updateDepartment(d);
                            MessageBox.Show("Update Complete.");
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Any wrong here maybe lost infomation or phone invalid");
                    }
                }
            }
            if (status == "Add")
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to save this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    try
                    {
                        if (AreFieldsValid())
                        {
                            DepartmentDAO departmentDAO = new DepartmentDAO();
                            List<Department> departments = departmentDAO.getDepartments();
                            string newId = GenerateUniqueKey(departments);
                            tb_departmentID.Text = newId;
                            Department department = new Department(newId, tb_departmemtName.Text, tb_contactEmail.Text, tb_contactPhone.Text, tb_location.Text, tb_responsibilities.Text);
                            departmentDAO.addDepartment(department);
                            MessageBox.Show("Add Complete Refresh To See In Table!!! Department ID " + newId);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    tb_departmentID.Text = "Auto";
                    tb_departmemtName.Text = null;
                    tb_contactEmail.Text = null;
                    tb_contactPhone.Text = null;
                    tb_location.Text = null;
                    tb_responsibilities.Text = null;
                }
            }
        }

        private string GenerateUniqueKey(List<Department> dd)
        {
            int maxId = 0;

            foreach (Department d in dd)
            {
                string deparment = d.departmentID;
                int idNumber = 0;
                idNumber = int.Parse(deparment);
                if (idNumber > maxId)
                {
                    maxId = idNumber;
                }
            }

            string newId = "" + (maxId + 1);

            return newId;
        }
        private void btn_View_Enter(object sender, EventArgs e)
        {
            btn_View.BackColor = ClickBackColor;
            btn_View.ForeColor = ClickForeColor;

            btn_update.ForeColor = StandForeColor;
            btn_update.BackColor = StandBackColor;

            btn_add.ForeColor = StandForeColor;
            btn_add.BackColor = StandBackColor;
            
            status = "View";
            txt_status.Text = "Status " + status;
            tb_departmentID.Enabled = false;
            tb_departmemtName.Enabled = false;
            tb_contactEmail.Enabled = false;
            tb_contactPhone.Enabled = false;
            tb_location.Enabled = false;
            tb_responsibilities.Enabled = false;
            btn_refresh.Enabled = true;

            table_department.ColumnCount = 6;
            table_department.Columns[0].Name = "Department ID";
            table_department.Columns[1].Name = "Department Name";
            table_department.Columns[2].Name = "Contat Email";
            table_department.Columns[3].Name = "Contact Phone";
            table_department.Columns[4].Name = "Location";
            table_department.Columns[5].Name = "Responsibilities";

            table_department.Rows.Clear();
            DepartmentDAO departmentDAO = new DepartmentDAO();
            List<Department> departments = departmentDAO.getDepartments();

            foreach (Department U in departments)
            {
                string[] row = { U.departmentID.ToString(), U.departmentName.ToString(), U.contactEmail.ToString(), U.contactPhone.ToString(), U.location.ToString(), U.responsibilities.ToString() };
                table_department.Rows.Add(row);
            }

        }

        private void ClearFields()
        {
            tb_departmentID.Text = string.Empty;
            tb_departmemtName.Text = string.Empty;
            tb_contactEmail.Text = string.Empty;
            tb_contactPhone.Text = string.Empty;
            tb_location.Text = string.Empty;
            tb_responsibilities.Text = string.Empty;
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            ClearFields();
            try
            {
                table_department.Rows.Clear();
                DepartmentDAO departmentDAO = new DepartmentDAO();
                List<Department> departments = departmentDAO.getDepartments();

                foreach (Department U in departments)
                {
                    string[] row = { U.departmentID.ToString(), U.departmentName.ToString(), U.contactEmail.ToString(), U.contactPhone.ToString(), U.location.ToString(), U.responsibilities.ToString() };
                    table_department.Rows.Add(row);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("You Should Click View First !!!!!");
            }
        }

        private void btn_add_Enter(object sender, EventArgs e)
        {
            if (status != "None")
            {
                btn_View.BackColor = StandBackColor;
                btn_View.ForeColor = StandForeColor;

                btn_update.ForeColor = StandForeColor;
                btn_update.BackColor = StandBackColor;

                btn_add.ForeColor = ClickForeColor;
                btn_add.BackColor = ClickBackColor;

                status = "Add";
                txt_status.Text = "Status " + status;
                tb_departmemtName.Enabled = true;
                tb_contactEmail.Enabled = true;
                tb_contactPhone.Enabled = true;
                tb_location.Enabled = true;
                tb_responsibilities.Enabled = true;

                tb_departmentID.Text = "Auto";
            }
            else
            {
                MessageBox.Show("You Should Click View First !!!!!");
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            try
            {
                if (!String.IsNullOrEmpty(tb_departmentID.Text))
                {
                    // Display confirmation dialog
                    DialogResult result = MessageBox.Show("Are you sure to save this User?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    // Check if the user clicked Yes
                    if (result == DialogResult.Yes)
                    {
                        if (tb_departmentID != null)
                        {
                            DepartmentDAO d = new DepartmentDAO();
                            d.deleteDepartment(tb_departmentID.Text);
                            MessageBox.Show("Remove Complete Refresh To See In Table");
                        }
                        else
                        {
                            MessageBox.Show("Don't Have Any Infomation");
                        }
                        tb_departmentID.Text = null;
                        tb_departmemtName.Text = null;
                        tb_contactEmail.Text = null;
                        tb_contactPhone.Text = null;
                        tb_location.Text = null;
                        tb_responsibilities.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Need ID");
                    }
                }
            }
            catch
            {
                MessageBox.Show(" This department is in use ");
            }
        }
    }
}
