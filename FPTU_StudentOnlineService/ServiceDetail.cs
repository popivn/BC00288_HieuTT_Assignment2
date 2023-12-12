using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FTU_StudentOnlineService
{
    public partial class ServiceDetail : Form
    {
        private Color ClickBackColor = Color.Blue;
        private Color ClickForeColor = Color.White;
        private Color StandBackColor = Color.White;
        private Color StandForeColor = Color.Black;

        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private OpenFileDialog infcopenFileDialog = new OpenFileDialog();
        private OpenFileDialog scopenFileDialog = new OpenFileDialog();
        internal TuitionReductionServiceDAO tuitionReductionServiceDAO = new TuitionReductionServiceDAO();
        internal InformationChangeServiceDAO InformationChangeServiceDAO = new InformationChangeServiceDAO();
        internal StudentConfirmationDAO studentConfirmationDAO = new StudentConfirmationDAO();
        public string status = "None";
        public string infcStatus = "None";
        public string scStatus = "None";
        public ServiceDetail()
        {
            InitializeComponent();
        }

        private void ServiceDetail_Load(object sender, EventArgs e)
        {
            cbb_searcch.SelectedItem = cbb_searcch.Items[0];
            cbb_infcSearch.SelectedItem = cbb_infcSearch.Items[0];
        }

        //tuition reduction Service Area
        private void LoadColumnTuitionReductionServiceList()
        {
            // Assuming StudentAccountForm_tableTuitionReductionService is your DataGridView for TuitionReductionService
            table_tuitionreductionserviceList.ColumnCount = 10;
            table_tuitionreductionserviceList.Columns[0].Name = "Reduction ID";
            table_tuitionreductionserviceList.Columns[1].Name = "Service ID";
            table_tuitionreductionserviceList.Columns[2].Name = "Course";
            table_tuitionreductionserviceList.Columns[3].Name = "Fee";
            table_tuitionreductionserviceList.Columns[4].Name = "Certificate";
            table_tuitionreductionserviceList.Columns[5].Name = "Major";
            table_tuitionreductionserviceList.Columns[6].Name = "Registration Date";
            table_tuitionreductionserviceList.Columns[7].Name = "Phone Number";
            table_tuitionreductionserviceList.Columns[8].Name = "Delivery Method";
            table_tuitionreductionserviceList.Columns[9].Name = "Result Delivery Method";
        }

        private void LoadDataTuitionReductionService()
        {
            // Assuming StudentAccountForm_tableTuitionReductionService is your DataGridView for TuitionReductionService
            table_tuitionreductionserviceList.Rows.Clear();
            TuitionReductionServiceDAO tuitionReductionServiceDAO = new TuitionReductionServiceDAO();
            List<TuitionReductionService> tuitionReductionServices = tuitionReductionServiceDAO.GetTuitionReductionServices();

            foreach (TuitionReductionService tuitionReductionService in tuitionReductionServices)
            {
                string[] row = {
            tuitionReductionService.ReductionIDProp.ToString(),
            tuitionReductionService.ServiceIDProp.ToString(),
            tuitionReductionService.CourseProp.ToString(),
            tuitionReductionService.FeeProp.ToString(),
            tuitionReductionService.CertificateProp.ToString(),
            tuitionReductionService.MajorProp.ToString(),
            tuitionReductionService.RegistrationDateProp.ToString(),
            tuitionReductionService.PhoneNumberProp.ToString(),
            tuitionReductionService.DeliveryMethodProp.ToString(),
            tuitionReductionService.ResultDeliveryMethodProp.ToString()
        };

                table_tuitionreductionserviceList.Rows.Add(row);
            }
        }

        private void btn_view_Enter(object sender, EventArgs e)
        {
            status = "View";
            txt_status.Text = "Status: "+status;
            LoadColumnTuitionReductionServiceList();
            LoadDataTuitionReductionService();
            tb_reductionID.Enabled = false;
            tb_serviceID.Enabled = false;
            tb_course.Enabled = false;
            tb_fee.Enabled = false;
            tb_fileAttached.Enabled = false;
            tb_major.Enabled = false;
            datetime_RegistrationDate.Enabled = false;
            tb_phoneNumber.Enabled = false;
            tb_deliveryMethod.Enabled = false;
            tb_resuiltdeliveryMethod.Enabled = false;
            tb_studentname.Enabled = false;
            button1.Enabled = false;
            tb_search.Enabled = true;
            btn_refresh.Enabled = true;

            btn_view.BackColor = ClickBackColor;
            btn_view.ForeColor = ClickForeColor;

            btb_update.ForeColor = StandForeColor;
            btb_update.BackColor = StandBackColor;

            table_tuitionreductionserviceList.ReadOnly = true;
            if (table_tuitionreductionserviceList.RowCount > 1)
                if (table_tuitionreductionserviceList.CurrentRow != null)
                {
                    int rowindex = table_tuitionreductionserviceList.CurrentCell.RowIndex;
                    if (table_tuitionreductionserviceList.Rows.Count - 2 >= rowindex)
                    {
                        string reductionID = table_tuitionreductionserviceList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_tuitionreductionserviceList.Rows[rowindex].Cells[1].Value.ToString();
                        string course = table_tuitionreductionserviceList.Rows[rowindex].Cells[2].Value.ToString();
                        string fee = table_tuitionreductionserviceList.Rows[rowindex].Cells[3].Value.ToString();
                        string certificate = table_tuitionreductionserviceList.Rows[rowindex].Cells[4].Value.ToString();
                        string major = table_tuitionreductionserviceList.Rows[rowindex].Cells[5].Value.ToString();
                        string registrationDate = table_tuitionreductionserviceList.Rows[rowindex].Cells[6].Value.ToString();
                        string phoneNumber = table_tuitionreductionserviceList.Rows[rowindex].Cells[7].Value.ToString();
                        string deliveryMethod = table_tuitionreductionserviceList.Rows[rowindex].Cells[8].Value.ToString();
                        string resultDeliveryMethod = table_tuitionreductionserviceList.Rows[rowindex].Cells[9].Value.ToString();

                        tb_reductionID.Text = reductionID;
                        tb_serviceID.Text = serviceID;
                        tb_course.Text = course;
                        tb_fee.Text = fee;
                        tb_fileAttached.Text = certificate;
                        tb_major.Text = major;
                        datetime_RegistrationDate.Text = registrationDate;
                        tb_phoneNumber.Text = phoneNumber;
                        tb_deliveryMethod.Text = deliveryMethod;
                        tb_resuiltdeliveryMethod.Text = resultDeliveryMethod;
                        tb_studentname.Text = tuitionReductionServiceDAO.GetUserNameByServiceID(tb_serviceID.Text);
                    }
                }
        }

        private void table_tuitionreductionserviceList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_tuitionreductionserviceList.ReadOnly = true;
            if (table_tuitionreductionserviceList.RowCount > 1)
                if (table_tuitionreductionserviceList.CurrentRow != null)
                {
                    int rowindex = table_tuitionreductionserviceList.CurrentCell.RowIndex;
                    if (table_tuitionreductionserviceList.Rows.Count - 2 >= rowindex)
                    {
                        string reductionID = table_tuitionreductionserviceList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_tuitionreductionserviceList.Rows[rowindex].Cells[1].Value.ToString();
                        string course = table_tuitionreductionserviceList.Rows[rowindex].Cells[2].Value.ToString();
                        string fee = table_tuitionreductionserviceList.Rows[rowindex].Cells[3].Value.ToString();
                        string certificate = table_tuitionreductionserviceList.Rows[rowindex].Cells[4].Value.ToString();
                        string major = table_tuitionreductionserviceList.Rows[rowindex].Cells[5].Value.ToString();
                        string registrationDate = table_tuitionreductionserviceList.Rows[rowindex].Cells[6].Value.ToString();
                        string phoneNumber = table_tuitionreductionserviceList.Rows[rowindex].Cells[7].Value.ToString();
                        string deliveryMethod = table_tuitionreductionserviceList.Rows[rowindex].Cells[8].Value.ToString();
                        string resultDeliveryMethod = table_tuitionreductionserviceList.Rows[rowindex].Cells[9].Value.ToString();

                        tb_reductionID.Text = reductionID;
                        tb_serviceID.Text = serviceID;
                        tb_course.Text = course;
                        tb_fee.Text = fee;
                        tb_fileAttached.Text = certificate;
                        tb_major.Text = major;
                        datetime_RegistrationDate.Text = registrationDate;
                        tb_phoneNumber.Text = phoneNumber;
                        tb_deliveryMethod.Text = deliveryMethod;
                        tb_resuiltdeliveryMethod.Text = resultDeliveryMethod;
                        tb_studentname.Text = tuitionReductionServiceDAO.GetUserNameByServiceID(tb_serviceID.Text);
                    }
                }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            btn_save.BackColor = ClickBackColor;
            btn_save.ForeColor = ClickForeColor;
            if (status == "Update")
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to UPDATE this Service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    TuitionReductionServiceDAO tuitionReductionServiceDAO = new TuitionReductionServiceDAO();
                    try
                    {
                        TuitionReductionService tuitionReductionService = new TuitionReductionService(
                            tb_reductionID.Text,
                            tb_serviceID.Text,
                            tb_course.Text,
                            Convert.ToDecimal(tb_fee.Text),
                            tb_fileAttached.Text,
                            tb_major.Text,
                            Convert.ToDateTime(datetime_RegistrationDate.Text),
                            tb_phoneNumber.Text,
                            tb_deliveryMethod.Text,
                            tb_resuiltdeliveryMethod.Text
                        );

                        tuitionReductionServiceDAO.UpdateTuitionReductionService(tuitionReductionService);
                        MessageBox.Show("Update Complete.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Any wrong here maybe lost information");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Status");
            }
            btn_save.BackColor = StandBackColor;
            btn_save.ForeColor = StandForeColor;
        }

        private void btb_update_Enter(object sender, EventArgs e)
        {
            if (status != "None")
            {
                status = "Update";
                txt_status.Text = "Status: " + status;
                tb_fee.Enabled = true;
                tb_fileAttached.Enabled = true;
                datetime_RegistrationDate.Enabled = true;
                tb_deliveryMethod.Enabled = true;
                tb_resuiltdeliveryMethod.Enabled = true;
                tb_search.Enabled = true;
                button1.Enabled = true;

                btb_update.BackColor = ClickBackColor;
                btb_update.ForeColor = ClickForeColor;

                btn_view.BackColor = StandBackColor;
                btn_view.ForeColor = StandForeColor;
            }
            else
            {
                MessageBox.Show("You Should Click View First!!!!!");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (cbb_searcch.Text == "Search by Name")
            {
                table_tuitionreductionserviceList.Rows.Clear();
                TuitionReductionServiceDAO tuition = new TuitionReductionServiceDAO();
                List<TuitionReductionService> tuitionReductionServices = tuition.SearchTuitionReductionServicesByUsername(tb_search.Text);
                foreach (TuitionReductionService tuitionReductionService in tuitionReductionServices)
                {
                     string[] row = {
                     tuitionReductionService.ReductionIDProp.ToString(),
                     tuitionReductionService.ServiceIDProp.ToString(),
                     tuitionReductionService.CourseProp.ToString(),
                     tuitionReductionService.FeeProp.ToString(),
                     tuitionReductionService.CertificateProp.ToString(),
                     tuitionReductionService.MajorProp.ToString(),
                     tuitionReductionService.RegistrationDateProp.ToString(),
                     tuitionReductionService.PhoneNumberProp.ToString(),
                     tuitionReductionService.DeliveryMethodProp.ToString(),
                     tuitionReductionService.ResultDeliveryMethodProp.ToString()
                     };

                    table_tuitionreductionserviceList.Rows.Add(row);
                }
            }
        }
        private void OpenFileSelectionDialog()
        {
            openFileDialog.Filter = "All Files (*.*)|*.*";
            openFileDialog.Title = "Select a File";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = openFileDialog.FileName;

                tb_fileAttached.Text = Path.GetFileName(selectedFilePath);

                string filePath = selectedFilePath;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileSelectionDialog();
        }
        // Inforamtion Change Area
        private void LoadColumnInformationChangeServiceList()
        {
            // Assuming your DataGridView is named table_informationChangeServiceList
            table_infcList.ColumnCount = 8;
            table_infcList.Columns[0].Name = "Change ID";
            table_infcList.Columns[1].Name = "Service ID";
            table_infcList.Columns[2].Name = "Change Type";
            table_infcList.Columns[3].Name = "Fee";
            table_infcList.Columns[4].Name = "Registration Date";
            table_infcList.Columns[5].Name = "Major";
            table_infcList.Columns[6].Name = "Description";
            table_infcList.Columns[7].Name = "File Attached";
        }

        private void LoadDataInformationChangeService()
        {
            // Assuming your DataGridView is named table_informationChangeServiceList
            table_infcList.Rows.Clear();
            InformationChangeServiceDAO infoChangeServiceDAO = new InformationChangeServiceDAO();
            List<InformationChangeService> infoChangeServices = infoChangeServiceDAO.GetInformationChangeServices();

            foreach (InformationChangeService infoChangeService in infoChangeServices)
            {
                string[] row = {
            infoChangeService.ChangeIDProp.ToString(),
            infoChangeService.ServiceIDProp.ToString(),
            infoChangeService.ChangeTypeProp.ToString(),
            infoChangeService.FeeProp.ToString(),
            infoChangeService.RegistrationDateProp.ToString(),
            infoChangeService.MajorProp.ToString(),
            infoChangeService.DescriptionProp.ToString(),
            infoChangeService.FileAttachedProp.ToString()
        };

                table_infcList.Rows.Add(row);
            }
        }

        private void btn_vỉew_Enter(object sender, EventArgs e)
        {
            infcStatus = "View";
            txt_infcStatus.Text = "Status: " + infcStatus;
            LoadColumnInformationChangeServiceList();
            LoadDataInformationChangeService();

            tb_infcchangeID.Enabled = false;
            tb_infcserviceID.Enabled = false;
            tb_infcchangeType.Enabled = false;
            tb_infcFee.Enabled = false;
            dtp_infcRegistrationDate.Enabled = false;
            tb_infcMajor.Enabled = false;
            tb_infcDescription.Enabled = false;
            tb_infcFile.Enabled = false;
            tb_infcstudentName.Enabled = false;
            btn_infcBrowser.Enabled = false;
            tb_infcSearch.Enabled = true;
            btn_refresh.Enabled = true;

            btn_infcView.BackColor = ClickBackColor;
            btn_infcView.ForeColor = ClickForeColor;

            btn_infcUpdate.BackColor = StandBackColor;
            btn_infcUpdate.ForeColor = StandForeColor;

            table_infcList.ReadOnly = true;
            if (table_infcList.RowCount > 1)
            {
                if (table_infcList.CurrentRow != null)
                {
                    int rowindex = table_infcList.CurrentCell.RowIndex;
                    if (table_infcList.Rows.Count - 2 >= rowindex)
                    {
                        string changeID = table_infcList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_infcList.Rows[rowindex].Cells[1].Value.ToString();
                        string changeType = table_infcList.Rows[rowindex].Cells[2].Value.ToString();
                        string fee = table_infcList.Rows[rowindex].Cells[3].Value.ToString();
                        string registrationDate = table_infcList.Rows[rowindex].Cells[4].Value.ToString();
                        string major = table_infcList.Rows[rowindex].Cells[5].Value.ToString();
                        string description = table_infcList.Rows[rowindex].Cells[6].Value.ToString();
                        string fileAttached = table_infcList.Rows[rowindex].Cells[7].Value.ToString();

                        tb_infcchangeID.Text = changeID;
                        tb_infcserviceID.Text = serviceID;
                        tb_infcchangeType.Text = changeType;
                        tb_infcFee.Text = fee;
                        dtp_infcRegistrationDate.Text = registrationDate;
                        tb_infcMajor.Text = major;
                        tb_infcDescription.Text = description;
                        tb_infcFile.Text = fileAttached;
                        tb_infcstudentName.Text = InformationChangeServiceDAO.GetUserNameByServiceID(tb_infcserviceID.Text);

                    }
                }
            }
        }

        private void btn_infcrefresh_Click(object sender, EventArgs e)
        {
            LoadDataInformationChangeService();
        }
        private void table_infcList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_infcList.ReadOnly = true;
            if (table_infcList.RowCount > 1)
            {
                if (table_infcList.CurrentRow != null)
                {
                    int rowindex = table_infcList.CurrentCell.RowIndex;
                    if (table_infcList.Rows.Count - 2 >= rowindex)
                    {
                        string changeID = table_infcList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_infcList.Rows[rowindex].Cells[1].Value.ToString();
                        string changeType = table_infcList.Rows[rowindex].Cells[2].Value.ToString();
                        string fee = table_infcList.Rows[rowindex].Cells[3].Value.ToString();
                        string registrationDate = table_infcList.Rows[rowindex].Cells[4].Value.ToString();
                        string major = table_infcList.Rows[rowindex].Cells[5].Value.ToString();
                        string description = table_infcList.Rows[rowindex].Cells[6].Value.ToString();
                        string fileAttached = table_infcList.Rows[rowindex].Cells[7].Value.ToString();

                        tb_infcchangeID.Text = changeID;
                        tb_infcserviceID.Text = serviceID;
                        tb_infcchangeType.Text = changeType;
                        tb_infcFee.Text = fee;
                        dtp_infcRegistrationDate.Text = registrationDate;
                        tb_infcMajor.Text = major;
                        tb_infcDescription.Text = description;
                        tb_infcFile.Text = fileAttached;
                        tb_infcstudentName.Text = InformationChangeServiceDAO.GetUserNameByServiceID(tb_infcserviceID.Text);

                    }
                }
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (cbb_infcSearch.Text == "Search by Name")
            {
                table_infcList.Rows.Clear();
                InformationChangeServiceDAO informationchangeDAO = new InformationChangeServiceDAO();
                List<InformationChangeService> informationChanges = informationchangeDAO.SearchInformationChangeServicesByUsername(tb_infcSearch.Text);

                foreach (InformationChangeService informationChange in informationChanges)
                {
                    string[] row = {
                informationChange.ChangeIDProp.ToString(),
                informationChange.ServiceIDProp.ToString(),
                informationChange.ChangeTypeProp.ToString(),
                informationChange.FeeProp.ToString(),
                informationChange.RegistrationDateProp.ToString(),
                informationChange.MajorProp.ToString(),
                informationChange.DescriptionProp.ToString(),
                informationChange.FileAttachedProp.ToString()
                };

                    table_infcList.Rows.Add(row);
                }
            }
        }

        private void tbn_save_Click(object sender, EventArgs e)
        {
            if (infcStatus == "Update")
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to UPDATE this Service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    InformationChangeServiceDAO informationChangeServiceDAO = new InformationChangeServiceDAO();
                    try
                    {
                        InformationChangeService information = new InformationChangeService(
                        tb_infcchangeID.Text,
                        tb_infcserviceID.Text, 
                        tb_infcchangeType.Text,
                        Convert.ToDecimal(tb_infcFee.Text),
                        Convert.ToDateTime(dtp_infcRegistrationDate.Text),
                        tb_infcMajor.Text,
                        tb_infcDescription.Text ,
                        tb_infcFile.Text
                        );

                        informationChangeServiceDAO.UpdateInformationChangeService(information);
                        MessageBox.Show("Update Complete.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Any wrong here maybe lost information");
                    }
                }
            }
            else
            {
                MessageBox.Show("Invalid Status");
            }
        }

        private void btn_update_Enter(object sender, EventArgs e)
        {
            if (infcStatus != "None")
            {
                infcStatus = "Update";
                txt_infcStatus.Text = "Status: " + infcStatus;

                tb_infcchangeType.Enabled = true;
                tb_infcFee.Enabled = true;
                dtp_infcRegistrationDate.Enabled = true;
                tb_infcDescription.Enabled = true;
                tb_infcFile.Enabled = true;
                btn_infcBrowser.Enabled = true;

                btn_infcView.BackColor = StandBackColor;
                btn_infcView.ForeColor = StandForeColor;

                btn_infcUpdate.BackColor = ClickBackColor;
                btn_infcUpdate.ForeColor = ClickForeColor;
            }
            else
            {
                MessageBox.Show("You Should Click View First !!!!!");
            }
        }

        //Student Confirmation Area
        private void LoadColumnStudentConfirmationServiceList()
        {
            // Assuming your DataGridView is named table_scList
            table_scList.ColumnCount = 11;
            table_scList.Columns[0].Name = "Confirmation ID";
            table_scList.Columns[1].Name = "Service ID";
            table_scList.Columns[2].Name = "Fee";
            table_scList.Columns[3].Name = "Major";
            table_scList.Columns[4].Name = "Confirmation Type";
            table_scList.Columns[5].Name = "Phone Number";
            table_scList.Columns[6].Name = "File Attached";
            table_scList.Columns[7].Name = "Registration Date";
            table_scList.Columns[8].Name = "Description";
            table_scList.Columns[9].Name = "Delivery Method";
            table_scList.Columns[10].Name = "Result Delivery Method";
        }

        private void LoadDataStudentConfirmationService()
        {
            // Assuming your DataGridView is named table_scList
            table_scList.Rows.Clear();
            StudentConfirmationDAO studentConfirmationServiceDAO = new StudentConfirmationDAO();
            List<StudentConfirmationService> studentConfirmationServices = studentConfirmationServiceDAO.GetStudentConfirmationServices();

            foreach (StudentConfirmationService studentConfirmationService in studentConfirmationServices)
            {
                string[] row = {
            studentConfirmationService.ConfirmationIDProp.ToString(),
            studentConfirmationService.ServiceIDProp.ToString(),
            studentConfirmationService.FeeProp.ToString(),
            studentConfirmationService.MajorProp.ToString(),
            studentConfirmationService.ConfirmationTypeProp.ToString(),
            studentConfirmationService.PhoneNumberProp.ToString(),
            studentConfirmationService.FileAttachedProp.ToString(),
            studentConfirmationService.RegistrationDateProp.ToString(),
            studentConfirmationService.DescriptionProp.ToString(),
            studentConfirmationService.DeliveryMethodProp.ToString(),
            studentConfirmationService.ResuiltDeliveryMethodProp.ToString()
        };

                table_scList.Rows.Add(row);
            }
        }

        private void btn_scView_Enter(object sender, EventArgs e)
        {
            scStatus = "View";
            txt_scStatus.Text = "Status: " + scStatus;
            LoadColumnStudentConfirmationServiceList();
            LoadDataStudentConfirmationService();
            tb_scconfirmationID.Enabled = false;
            tb_scserviceID.Enabled = false;
            tb_scFee.Enabled = false;
            tb_scMajor.Enabled = false;
            cbb_scconformationType.Enabled = false;
            tb_scphoneNumber.Enabled = false;
            tb_scFile.Enabled = false;
            dtp_regDate.Enabled = false;
            tb_scDescription.Enabled = false;
            tb_scdeliveryMethod.Enabled = false;
            tb_scresultdeliveryMethod.Enabled = false;
            btn_scBrowser.Enabled = false;
            btn_scRefresh.Enabled = true;
            tb_scsearch.Enabled = true;

            btn_scView.BackColor = ClickBackColor;
            btn_scView.ForeColor = ClickForeColor;

            btn_scUpdate.BackColor = StandBackColor;
            btn_scUpdate.ForeColor = StandForeColor;

            table_scList.ReadOnly = true;
            if (table_scList.RowCount > 1)
            {
                if (table_scList.CurrentRow != null)
                {
                    int rowindex = table_scList.CurrentCell.RowIndex;
                    if (table_scList.Rows.Count - 2 >= rowindex)
                    {
                        string confirmationID = table_scList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_scList.Rows[rowindex].Cells[1].Value.ToString();
                        string fee = table_scList.Rows[rowindex].Cells[2].Value.ToString();
                        string major = table_scList.Rows[rowindex].Cells[3].Value.ToString();
                        string confirmationType = table_scList.Rows[rowindex].Cells[4].Value.ToString();
                        string phoneNumber = table_scList.Rows[rowindex].Cells[5].Value.ToString();
                        string fileAttached = table_scList.Rows[rowindex].Cells[6].Value.ToString();
                        string registrationDate = table_scList.Rows[rowindex].Cells[7].Value.ToString();
                        string description = table_scList.Rows[rowindex].Cells[8].Value.ToString();
                        string deliveryMethod = table_scList.Rows[rowindex].Cells[9].Value.ToString();
                        string resultDeliveryMethod = table_scList.Rows[rowindex].Cells[10].Value.ToString();

                        // Assign these values to your TextBoxes or other controls
                        tb_scconfirmationID.Text = confirmationID;
                        tb_scserviceID.Text = serviceID;
                        tb_scFee.Text = fee;
                        tb_scMajor.Text = major;
                        cbb_scconformationType.Text = confirmationType;
                        tb_scphoneNumber.Text = phoneNumber;
                        tb_scFile.Text = fileAttached;
                        dtp_regDate.Text = registrationDate;
                        tb_scDescription.Text = description;
                        tb_scdeliveryMethod.Text = deliveryMethod;
                        tb_scresultdeliveryMethod.Text = resultDeliveryMethod;

                        // You may also update the student name using the appropriate method
                        tb_scstudentName.Text = studentConfirmationDAO.GetUserNameByServiceID(tb_scserviceID.Text);
                    }
                }
            }
        }

        private void table_scList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            table_scList.ReadOnly = true;
            if (table_scList.RowCount > 1)
            {
                if (table_scList.CurrentRow != null)
                {
                    int rowindex = table_scList.CurrentCell.RowIndex;
                    if (table_scList.Rows.Count - 2 >= rowindex)
                    {
                        string confirmationID = table_scList.Rows[rowindex].Cells[0].Value.ToString();
                        string serviceID = table_scList.Rows[rowindex].Cells[1].Value.ToString();
                        string fee = table_scList.Rows[rowindex].Cells[2].Value.ToString();
                        string major = table_scList.Rows[rowindex].Cells[3].Value.ToString();
                        string confirmationType = table_scList.Rows[rowindex].Cells[4].Value.ToString();
                        string phoneNumber = table_scList.Rows[rowindex].Cells[5].Value.ToString();
                        string fileAttached = table_scList.Rows[rowindex].Cells[6].Value.ToString();
                        string registrationDate = table_scList.Rows[rowindex].Cells[7].Value.ToString();
                        string description = table_scList.Rows[rowindex].Cells[8].Value.ToString();
                        string deliveryMethod = table_scList.Rows[rowindex].Cells[9].Value.ToString();
                        string resultDeliveryMethod = table_scList.Rows[rowindex].Cells[10].Value.ToString();

                        // Assign these values to your TextBoxes or other controls
                        tb_scconfirmationID.Text = confirmationID;
                        tb_scserviceID.Text = serviceID;
                        tb_scFee.Text = fee;
                        tb_scMajor.Text = major;
                        cbb_scconformationType.Text = confirmationType;
                        tb_scphoneNumber.Text = phoneNumber;
                        tb_scFile.Text = fileAttached;
                        dtp_regDate.Text = registrationDate;
                        tb_scDescription.Text = description;
                        tb_scdeliveryMethod.Text = deliveryMethod;
                        tb_scresultdeliveryMethod.Text = resultDeliveryMethod;

                        // You may also update the student name using the appropriate method
                        tb_scstudentName.Text = studentConfirmationDAO.GetUserNameByServiceID(tb_scserviceID.Text);
                    }
                }
            }
        }

        private void btn_scSave_Click(object sender, EventArgs e)
        {
            btn_scSave.BackColor = ClickBackColor;
            btn_scSave.ForeColor = ClickForeColor;
            if (scStatus == "Update")
            {
                // Display confirmation dialog
                DialogResult result = MessageBox.Show("Are you sure to UPDATE this Service?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                // Check if the user clicked Yes
                if (result == DialogResult.Yes)
                {
                    // Call the function to save data
                    StudentConfirmationDAO scDAO = new StudentConfirmationDAO();
                    try
                    {
                        StudentConfirmationService sc = new StudentConfirmationService(
                        tb_scconfirmationID.Text,
                        tb_scserviceID.Text,
                        Convert.ToDecimal(tb_scFee.Text),
                        tb_scMajor.Text,
                        cbb_scconformationType.Text,
                        tb_scphoneNumber.Text,
                        tb_scFile.Text,
                        Convert.ToDateTime(dtp_regDate.Text),
                        tb_scDescription.Text,
                        tb_scdeliveryMethod.Text,
                        tb_scresultdeliveryMethod.Text
                        );

                        scDAO.UpdateStudentConfirmationService(sc);
                        MessageBox.Show("Update Complete.");
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Any wrong here maybe lost information");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Status");
                }
            }

            btn_scSave.BackColor = StandBackColor;
            btn_scSave.ForeColor = StandForeColor;
        }
        private void btn_scUpdate_Enter(object sender, EventArgs e)
        {
            btn_scView.BackColor = StandBackColor;
            btn_scView.ForeColor = StandForeColor;
            if (scStatus == "View")
            {
                scStatus = "Update";
                txt_scStatus.Text = "Status: " + scStatus;
                tb_scFee.Enabled = true;
                cbb_scconformationType.Enabled = true;
                tb_scFile.Enabled = true;
                dtp_regDate.Enabled = true;
                tb_scDescription.Enabled = true;
                tb_scdeliveryMethod.Enabled = true;
                tb_scresultdeliveryMethod.Enabled = true;
            }
            else
            {
                MessageBox.Show("You Should Click View First !!!!!");
            }
            btn_scUpdate.BackColor = ClickBackColor;
            btn_scUpdate.ForeColor = ClickForeColor;

        }

        private void btn_scRefresh_Click(object sender, EventArgs e)
        {
            LoadDataStudentConfirmationService();
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            btn_refresh.BackColor = ClickBackColor;
            btn_refresh.ForeColor = ClickForeColor;
            if (status != "None")
            {
                LoadDataTuitionReductionService();
            }
            else
            {
                MessageBox.Show("You Should Click View FIrst !!!!!");
            }
            btn_refresh.BackColor = StandBackColor;
            btn_refresh.ForeColor = StandForeColor;
        }

        private void btn_infcBrowser_Click(object sender, EventArgs e)
        {
            infcOpenFileSelectionDialog();
        }
        private void infcOpenFileSelectionDialog()
        {
            infcopenFileDialog.Filter = "All Files (*.*)|*.*";
            infcopenFileDialog.Title = "Select a File";

            if (infcopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = infcopenFileDialog.FileName;

                tb_infcFile.Text = Path.GetFileName(selectedFilePath);

                string filePath = selectedFilePath;
            }
        }

        private void btn_scBrowser_Click(object sender, EventArgs e)
        {
            scOpenFileSelectionDialog();
        }
        private void scOpenFileSelectionDialog()
        {
            scopenFileDialog.Filter = "All Files (*.*)|*.*";
            scopenFileDialog.Title = "Select a File";

            if (scopenFileDialog.ShowDialog() == DialogResult.OK)
            {
                string selectedFilePath = scopenFileDialog.FileName;

                tb_scFile.Text = Path.GetFileName(selectedFilePath);

                string filePath = selectedFilePath;
            }
        }

        private void ptb_scLookup_Click(object sender, EventArgs e)
        {

            if (cbb_scsearch.Text == "Search by Name")
            {
                table_scList.Rows.Clear();
                StudentConfirmationDAO scDAO = new StudentConfirmationDAO();
                List<StudentConfirmationService> sc = scDAO.SearchStudentConfirmationServicesByUsername(tb_scsearch.Text);

                foreach (StudentConfirmationService scs in sc)
                {
                    string[] row = {
                 scs.ConfirmationIDProp.ToString(),
            scs.ServiceIDProp.ToString(),
            scs.FeeProp.ToString(),
            scs.MajorProp.ToString(),
            scs.ConfirmationTypeProp.ToString(),
            scs.PhoneNumberProp.ToString(),
            scs.FileAttachedProp.ToString(),
            scs.RegistrationDateProp.ToString(),
            scs.DescriptionProp.ToString(),
            scs.DeliveryMethodProp.ToString(),
            scs.ResuiltDeliveryMethodProp.ToString()
                };

                    table_scList.Rows.Add(row);
                }
            }
        }
    }
}

