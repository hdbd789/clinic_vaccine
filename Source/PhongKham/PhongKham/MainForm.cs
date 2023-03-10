using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Clinic;
using Clinic.Helpers;
using Clinic.Models;
using Clinic.Database;
using System.Data.Common;
using System.Drawing;
using System.ComponentModel;
using System.Windows.Forms.Calendar;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.InteropServices;
using Clinic.Models.ItemMedicine;
using Clinic.Extensions.LoaiKham;
using Clinic.Thong_Ke;
using Clinic.Extensions;
using Clinic.Gui;
using log4net;
using System.Reflection;

namespace PhongKham
{
    public partial class Form1 : DevComponents.DotNetBar.Office2007Form
    {
        private static readonly ILog Log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        [DllImport("user32")]
        public static extern int SetParent(int hWndChild, int hWndNewParent);


        public static Dictionary<string, string> listPatientToday = new Dictionary<string, string>();

        private static int maxIdOfCalendarItem;
        private int TongTien;
        private InfoClinic infoClinic;
        private static string UserName;
        public static string nameOfDoctor;
        private IDatabase db = DatabaseFactory.Instance;
        List<CalendarItem> _items = new List<CalendarItem>();


        public List<IMedicine> currentMedicines = new List<IMedicine>();
        public List<IMedicine> currentServices = new List<IMedicine>();

        private static List<string> listDiagnosesFromHistory = new List<string>();
        private static Dictionary<int, string> listDiagnosesFromDiagnoses = new Dictionary<int, string>();
        public static int Authority;
        private static string IdHistoryCurrent = string.Empty;


        System.Threading.Timer TimerItem;
        private ListPatientsTodayForm listPatientForm;

        private bool IsViewHistory = false;
        private System.Windows.Forms.Timer timer;
        private void backgroundWorkerLoadingDatabase_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            this.Enabled = true;
            InitUser(Authority);
        }
        private void backgroundWorkerLoadingDatabase_DoWork(object sender, DoWorkEventArgs e)
        {
            //InitUser(Authority);
        }

        public Form1(int Authority, string name)
        {
            
            //init MainForm
            this.TopLevel = true;
            InitializeComponent();

            //init delegate
            TuThuocForm.refreshMedicines4MainForm = new Clinic.TuThuocForm.RefreshMedicines4MainForm(InitComboboxMedicinesMySql);
            Services.refreshMedicines4MainForm = new Clinic.Services.RefreshMedicines4MainForm(InitComboboxMedicinesMySql);


            
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Text = "Phòng Khám -" + "User: " + name;
            Form1.Authority = Authority;

            UserName = name;
            nameOfDoctor = db.GetNameOfDoctor(name);

            //LoadDatabase
            CircularProgressAction("Loading Database");
            //Load Settings
            this.checkBoxShowBigForm.Checked = Clinic.Properties.Settings.Default.checkBoxBigSearchForm;
            this.checkBoxShow1Record.Checked = Clinic.Properties.Settings.Default.checkBox1RecordInSearchForm;
            this.checkBoxShowMedicines.Checked = Clinic.Properties.Settings.Default.checkBoxShowMedicineInSearchForm;

            this.Enabled = false;
            BackgroundWorker backgroundWorkerLoadingDatabase = new BackgroundWorker();
            backgroundWorkerLoadingDatabase.WorkerSupportsCancellation = true;
            backgroundWorkerLoadingDatabase.DoWork += new DoWorkEventHandler(backgroundWorkerLoadingDatabase_DoWork);
            backgroundWorkerLoadingDatabase.RunWorkerCompleted += new RunWorkerCompletedEventHandler(backgroundWorkerLoadingDatabase_RunWorkerCompleted);

            backgroundWorkerLoadingDatabase.RunWorkerAsync();

            this.cbb_Reason.Visible = false;


            List<string> listLoaiKham = Helper.GetAllLoaiKham(this.db);
            this.comboBoxLoaiKham.Items.AddRange(listLoaiKham.ToArray());
            comboBoxLoaiKham.Text = "Loại Khám: ";

            

            // add autocomplete into textbox
            AddItemAutoCompleteTextBoxDiagnoses();

            this.StartPosition = FormStartPosition.CenterScreen;

            this.WindowState = Clinic.Properties.Settings.Default.State;
            if (this.WindowState == FormWindowState.Normal) this.Size = Clinic.Properties.Settings.Default.Size;
            this.Resize += new System.EventHandler(this.Form1_Resize);

            try
            {

                XmlSerializer xmlSerializer = new XmlSerializer(typeof(InfoClinic));
                StreamReader sr = new StreamReader("Information.xml");
                infoClinic = xmlSerializer.Deserialize(sr) as InfoClinic;



                textBoxNameClinic.Text = infoClinic.Name;
                textBoxAddressClinic.Text = infoClinic.Address;
                textBoxAdviceClinic.Text = infoClinic.Advice;
                textBoxSDT.Text = infoClinic.Sdt;

                textBoxBackupSource.Text = infoClinic.PathData;
                textBoxBackupTarget.Text = infoClinic.PathTargetBackup;

                textBoxBackupTimeAuto.Text = infoClinic.TimeBackup;
                bool temp = bool.Parse(infoClinic.CheckedBackup1.ToLower());
                if (temp)
                {
                    checkBoxAutoCopy.CheckState = CheckState.Checked;
                }


                sr.Close();
            }
            catch (Exception exx)
            {
                Log.Error(exx.Message, exx);
            }
            try
            {
                // do any background work

                //do not change 
                InitComboboxMedicinesMySql();
                InitClinicRoom();
                dataGridView4.Visible = false;
                maxIdOfCalendarItem = Helper.SearchMaxValueOfTable("calendar", "IdCalendar", "DESC");
                //
                //Load calendar
                //
                List<ADate> listDate = db.GetAllDateOfUser(UserName);
                foreach (ADate item in listDate)
                {
                    CalendarItem cal = new CalendarItem(calendar1, item.StartTime, item.EndTime, item.Text);
                    cal.Tag = item.Id;
                    if (item.color != 0)
                    {
                        cal.ApplyColor(Helper.ConvertCodeToColor(item.color));
                    }
                    _items.Add(cal);
                }

                PlaceItems();


                //load lichhen
                LoadLichHen(DateTime.Now);

                //xoa listtoday
                XoaListToday();
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }

            listPatientForm = new Clinic.ListPatientsTodayForm();
            listPatientForm.sendCommandKham = new Clinic.ListPatientsTodayForm.SendCommandKham(KhamVaXoa);

            SearchForm.sendCommand = new Clinic.SearchForm.SendCommandProcessFromSearchForm(this.ProcessWhenUserDoubleClickOnSearch);
            ///favouriteForm.sendCommand = new Form2.SendCommand(PlayFromFavouriteForm);
            ///

            this.ColumnID.Width = 50;
            this.ColumnNamePatient.Width = 150;
            this.ColumnNgaySinh.Width = 100;
            this.ColumnNgayKham.Width = 100;
            this.ColumnAddress.Width = 100;
            this.ColumnSymtom.Width = 100;
            this.ColumnNhietDo.Width = 50;
            this.ColumnHuyetAp.Width = 50;
            this.ColumnDiagno.Width = 150;
            this.ColumnSearchValueMedicines.Width = 250;

            this.circularProgress1.Hide();

        }

        private void AddItemAutoCompleteTextBoxDiagnoses(bool getAgainHistory = true)
        {
            if(getAgainHistory)
                listDiagnosesFromHistory = this.db.GetAllDiagnosesFromHistory(DiagnosesHistory.dateHistoryUse);
            List<string> result = new List<string>();
            result.AddRange(listDiagnosesFromHistory);
            listDiagnosesFromDiagnoses = Helper.GetAllDiagnosesFromTableDiagnoses(db,result);
            result.AddRange(listDiagnosesFromDiagnoses.Values);
            this.txtBoxClinicRoomDiagnose.AutoCompleteCustomSource.Clear();
            this.txtBoxClinicRoomDiagnose.AutoCompleteCustomSource.AddRange(result.ToArray());
        }

        private void CircularProgressAction(string text)
        {
            this.circularProgress1.Show();
            this.circularProgress1.IsRunning = true;
            this.circularProgress1.ProgressText = text;
        }

        private void CircularProgressStop(string text)
        {
            this.circularProgress1.IsRunning = false;
            this.circularProgress1.ProgressText = text;
            this.circularProgress1.Hide();
        }

        private void CircularProgressSetvalue(string text)
        {
            this.circularProgress1.IsRunning = false;
            this.circularProgress1.ProgressText = text;
            this.circularProgress1.Hide();
        }

        private void KhamVaXoa(string id, string name, string state)
        {
            string strCommand = string.Format("Select * From {0} Where Name = {1} AND {2} = {3}",
                DatabaseContants.tables.patient, Helper.ConvertToSqlString(name),
                DatabaseContants.patient.Id, Helper.ConvertToSqlString(id));

            using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            {
                reader.Read();
                FillInfoToClinicForm(reader, true);
            }
            string[] stateString = state.Split(';');
            // fill
            this.textBoxClinicNhietDo.Text = stateString[0];
            this.textBoxHuyetAp.Text = stateString[1];
            this.txtBoxClinicRoomWeight.Text = stateString[2];
            this.txtBoxClinicRoomHeight.Text = stateString[3];

            buttonSearch.PerformClick();
            this.IsViewHistory = false;
            this.btn_khamlai.Visible = false;

            db.DeleteRowFromTablelistpatienttoday(id, name);
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Clinic.Properties.Settings.Default.State = this.WindowState;
            if (this.WindowState == FormWindowState.Normal) Clinic.Properties.Settings.Default.Size = this.Size;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Clinic.Properties.Settings.Default.checkBoxBigSearchForm = this.checkBoxShowBigForm.Checked;
            Clinic.Properties.Settings.Default.checkBox1RecordInSearchForm = this.checkBoxShow1Record.Checked;
            Clinic.Properties.Settings.Default.checkBoxShowMedicineInSearchForm = this.checkBoxShowMedicines.Checked;
            Clinic.Properties.Settings.Default.Save();
        }


        #region Init



        private void XoaListToday()
        {
            string cmd = string.Format("Delete from {0} Where time != {1}", DatabaseContants.tables.listpatienttoday, Helper.ConvertToSqlString(DateTime.Now.ToString("yyyy-MM-dd")));
            db.ExecuteNonQuery(cmd, null);
        }

        private void LoadLichHen(DateTime time)
        {
            string cmd = string.Format("Select * from {0} Where time = {1}", DatabaseContants.tables.lichHen, Helper.ConvertToSqlString(time.ToString("yyyy-MM-dd")));
            using (DbDataReader reader = db.ExecuteReader(cmd, null) as DbDataReader)
            {
                while (reader.Read())
                {

                    int index = dataGridViewCalendar.Rows.Add();
                    DataGridViewRow row = dataGridViewCalendar.Rows[index];
                    row.Cells[0].Value = reader["Idpatient"].ToString();
                    row.Cells[1].Value = reader["Namepatient"].ToString();
                    row.Cells[2].Value = reader["phone"].ToString();
                    row.Cells[3].Value = reader["benh"].ToString();
                    row.Cells[4].Value = reader["Namedoctor"].ToString();
                    try
                    {
                        int idHistory = (int)reader[DatabaseContants.history.IdHistory];
                        row.Cells[this.ColumnReason.Name].Value =Helper.GetReasonComeBackFromHistoryByIdHistory(idHistory, DatabaseFactory.Instance2);
                        int status = GetStatusAppointment(row.Cells[0].Value.ToString(), time, reader[DatabaseContants.LichHen.status]);
                        if (status == 0)
                        {
                            row.Cells[this.ColumnState.Name].Value = "Chưa khám";
                        }
                        else
                        {
                            row.Cells[this.ColumnState.Name].Value = "Đã tái khám";
                        }
                    }
                    catch { }

                       
                }
            }
        }

        private int GetStatusAppointment(string idPatient,DateTime timeHen, object statusFromDb)
        {
            int timeCompare = timeHen.CompareTo(DateTime.Now);
            if (statusFromDb == null || !Helper.CheckNumberValid(statusFromDb))
            {
                if (timeCompare <= 0)
                {
                    return Helper.GetStateComeBackFromHistoryByIdPatient(idPatient, DatabaseFactory.Instance2, timeHen);
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                int status = Helper.ConvertString2Int(statusFromDb);
                return status;
            }

        }
        private void InitClinicRoom()
        {
            //init id
            int intId = Helper.SearchMaxValueOfTable(DatabaseContants.tables.patient, DatabaseContants.patient.Id, "DESC");
            string ID = intId.ToString();
            lblClinicRoomId.Text = ID;

            //init comboBoxName

            //comboBoxClinicRoomName.Items.Clear();
            comboBoxClinicRoomName.Text = "";
            // Helper.GetAllRowsOfSpecialColumn("Patient","Name");

        }

        private void InitComboboxMedicinesMySql()
        {
            this.ColumnNameAllMedicine.Items.Clear();

            currentMedicines = Helper.GetAllMedicinesAndServicesFromDB();
            currentServices = currentMedicines.Where(x => x.Name[0] == '@').ToList();
            this.ColumnNameAllMedicine.Items.AddRange(currentMedicines.Select(x => x.Name).ToArray());
        }

        public void Init()
        {


            if (!Helper.checkAdminExists(DatabaseContants.tables.clinicuser))
            {
                CreateUserForm createUserForm = new CreateUserForm();
                createUserForm.ShowDialog();
            }

            LoginForm login = new LoginForm();
            if (login.ShowDialog(this) == DialogResult.OK)
            {

            }
        }

        private void InitUser(int authority)
        {

            //  Authority = 2; // bac si

            //Authority = 3; // nhan vien nhap thuoc

            //Authority = 4; // ca 2

            if (authority == 1)
            { //admin

                return;
            }
            this.Invoke(new MethodInvoker(delegate
            {
            
                MainTab.TabPages.Remove(tabPageTools);
                MainTab.TabPages.Remove(tabPagePrint);
                this.pictureBox1.Visible = false;
            
                switch (authority)
                {
                    case 1:
                        //all control
                        break;
                    case 2:
                        MainTab.TabPages.Add(tabPagePrint);
                        this.checkBoxShow1Record.Checked = false;
                        this.pictureBox1.Visible = true;
                        break;
                    case 3://khong co quyen ke thuoc
                        this.checkBoxShow1Record.Checked = false;
                        this.dataGridViewMedicine.Visible = false;
                        this.label9.Visible = false;
                        this.labelTongTien.Visible = false;
                        this.label44.Visible = true; // SDT:
                        this.textBoxClinicPhone.Visible = true;
                        this.txtBoxClinicRoomSymptom.Visible = false;
                        this.txtBoxClinicRoomDiagnose.Visible = false;
                        this.buttonPutIn.Visible = false;
                        break;
                    case 4:
                        this.pictureBox1.Visible = true;
                        MainTab.TabPages.Add(tabPagePrint);
                        break;
                    case 0:
                        this.checkBoxShowMedicines.Checked = false;
                        this.dataGridViewMedicine.Visible = false;
                        this.label9.Visible = false;
                        this.labelTongTien.Visible = false;
                        this.label44.Visible = false; // SDT:
                        this.textBoxClinicPhone.Visible = false;
                        this.txtBoxClinicRoomSymptom.Visible = false;
                        this.txtBoxClinicRoomDiagnose.Visible = false;
                        this.buttonPutIn.Visible = false;
                        break;
                }
            }));
        }
        #endregion

        #region EventCheck
        private void txtBoxInputMedicineNewCount_KeyPress(object sender, KeyPressEventArgs e)
        {

            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);

        }
        private void txtBoxInputMedicineNewCostIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoxInputMedicineNewCostOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        private void txtBoxInputMedicineAdd_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        //private void txtBoxClinicRoomHeight_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}
        //private void txtBoxClinicRoomWeight_KeyPress(object sender, KeyPressEventArgs e)
        //{
        //    e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        //}
        #endregion

        #region ClearForm


        private void ClearClinicRoomForm()
        {
            txtBoxClinicRoomAddress.Clear();
            comboBoxClinicRoomName.Text = "";
            txtBoxClinicRoomDiagnose.Clear();
            txtBoxClinicRoomHeight.Text = "";
            dateTimePickerBirthDay.ResetText();
            txtBoxClinicRoomSymptom.Clear();
            txtBoxClinicRoomWeight.Text = "";
            lblClinicRoomId.Text = "";
            // comboBoxClinicRoomMedicines.Text = "";
            dataGridViewMedicine.Rows.Clear();
            labelTongTien.Text = "0";
            TongTien = 0;
            textBoxClinicPhone.Text = "";
            textBoxClinicNhietDo.Text = "";
            textBoxHuyetAp.Text = "";
            labelTuoi.Text = "0";
        }
        #endregion

        #region Helper

        
        private void FillInfoToClinicForm(DbDataReader reader, bool onlyInfo)
        {
            try
            {
                lblClinicRoomId.Text = reader[DatabaseContants.patient.Id].ToString();
                txtBoxClinicRoomAddress.Text = reader["Address"].ToString();
                
                dateTimePickerBirthDay.Text = reader["Birthday"].ToString();
                comboBoxClinicRoomName.Text = reader["name"].ToString();
                if (!onlyInfo)
                {
                    txtBoxClinicRoomSymptom.Text = reader["Symptom"].ToString();
                    txtBoxClinicRoomDiagnose.Text = reader["Diagnose"].ToString();
                }
                if (!onlyInfo && IsViewHistory)
                {
                    textBoxClinicNhietDo.Text = reader[DatabaseContants.history.temperature].ToString();
                    textBoxHuyetAp.Text = reader[DatabaseContants.history.huyetap].ToString();
                }
                if (IsViewHistory)
                {                   
                    txtBoxClinicRoomWeight.Text = reader["Weight"].ToString();
                    txtBoxClinicRoomHeight.Text = reader["Height"].ToString();
                }
                textBoxClinicPhone.Text = reader["phone"].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bệnh Nhân Không Tồn Tại");
            }


        }
        private void AddVisitData(List<Medicine> medicineListInDataGrid)
        {
            //Save to history
            string medicines = GetAndConvertMedicinesToString(medicineListInDataGrid);

            List<string> valuesHistory = new List<string>() { lblClinicRoomId.Text, txtBoxClinicRoomSymptom.Text, txtBoxClinicRoomDiagnose.Text, DateTime.Now.ToString("yyyy-MM-dd"), medicines, textBoxClinicNhietDo.Text, textBoxHuyetAp.Text, this.cbb_Reason.Text };
            db.InsertRowToTable("history", Helper.ColumnsHistory, valuesHistory);
     
            // add table Diagnoses
            DiagnosesHistory.AddNewDiagnoses(db, txtBoxClinicRoomDiagnose.Text.Trim());
        }
        private void ChangeVisitData(List<Medicine> medicineListInDataGrid)
        {
            List<string> columns = new List<string>() { DatabaseContants.patient.Name, DatabaseContants.patient.Address, DatabaseContants.patient.birthday, DatabaseContants.patient.height, DatabaseContants.patient.weight };
            List<string> values = new List<string>() { comboBoxClinicRoomName.Text, txtBoxClinicRoomAddress.Text, dateTimePickerBirthDay.Value.ToString("yyyy-MM-dd"), txtBoxClinicRoomHeight.Text, txtBoxClinicRoomWeight.Text };
            db.UpdateRowToTable(DatabaseContants.tables.patient, columns, values,DatabaseContants.patient.Id, lblClinicRoomId.Text);

            //Save to history

            string medicines = GetAndConvertMedicinesToString(medicineListInDataGrid,true);

            List<string> valuesHistory = new List<string>() { lblClinicRoomId.Text, txtBoxClinicRoomSymptom.Text, txtBoxClinicRoomDiagnose.Text, dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd"), medicines, textBoxClinicNhietDo.Text, textBoxHuyetAp.Text, this.cbb_Reason.Text };
            db.UpdateRowToTable(DatabaseContants.tables.history, Helper.ColumnsHistory, valuesHistory,DatabaseContants.history.IdPatient, lblClinicRoomId.Text, dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd"));

            // add table Diagnoses
            DiagnosesHistory.AddNewDiagnoses(db, txtBoxClinicRoomDiagnose.Text.Trim());
        }

        private string GetAndConvertMedicinesToString(List<Medicine>listMedicine,bool updateCount = false)
        {
            string medicines = "";
            for (int i = 0; i < listMedicine.Count; i++)
            {
                Medicine medicine = listMedicine[i];
                if(updateCount){
                    medicine.Count = db.GetCountFromMecidicByName(medicine.Name);
                }
                int countStore = medicine.Count - medicine.Number;
                if (i == listMedicine.Count - 1)
                {
                    medicines += medicine.Name + "," + medicine.Number + "," + medicine.CostOut + "," + countStore;
                }
                else
                {
                    medicines += medicine.Name + "," + medicine.Number + "," + medicine.CostOut + "," + countStore + "|";
                }
            }
                //// nam,count, cose out, store count
                //for (int i = 0; i < dataGridViewMedicine.Rows.Count - 1; i++)
                //{
                //    int countStore = Helper.ConvertString2Int(dataGridViewMedicine[2, i].Value) - Helper.ConvertString2Int(dataGridViewMedicine[1, i].Value);

                //    if (i == dataGridViewMedicine.Rows.Count - 2)
                //    {
                //        medicines += dataGridViewMedicine[0, i].Value + "," + dataGridViewMedicine[1, i].Value + "," + dataGridViewMedicine[3, i].Value + "," + countStore;
                //    }
                //    else
                //    {
                //        medicines += dataGridViewMedicine[0, i].Value + "," + dataGridViewMedicine[1, i].Value + "," + dataGridViewMedicine[3, i].Value + "," + countStore + "|";
                //    }
                //}
            return medicines;
        }

        private void RefreshMedicineLess100()
        {
            dataGridView4.Rows.Clear();
            string strCommand = string.Format("Select * From {0} Where Count < 100", DatabaseContants.tables.medicine);
            // MySqlCommand comm = new MySqlCommand(strCommand, Program.conn);


            using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            {
                while (reader.Read())
                {
                    int index = dataGridView4.Rows.Add();
                    DataGridViewRow row = dataGridView4.Rows[index];
                    row.Cells[0].Value = reader.GetString(5);
                    row.Cells[1].Value = reader.GetString(0);
                    row.Cells[2].Value = reader.GetValue(2).ToString(); // gia in
                    row.Cells[3].Value = reader.GetValue(3).ToString(); // gia out
                    row.Cells[4].Value = reader.GetValue(1).ToString(); // So luong

                }
            }
        }
        #endregion

        #region Event Main Medicine

        
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MainTab.SelectedTab.Name == "tabnhapthuoc")
            {
                RefreshMedicineLess100();
            }
            if (MainTab.SelectedTab.Name == "tabPageTools")
            {
                LoadAccount();
            }

        }

        private void LoadAccount()
        {
            dataGridViewAccount.Rows.Clear();
            string query = string.Format("select * from {0}", DatabaseContants.tables.clinicuser);
            using (DbDataReader reader = db.ExecuteReader(query, null) as DbDataReader)
            {
                while (reader.Read())
                {
                    int index = dataGridViewAccount.Rows.Add();
                    DataGridViewRow row = dataGridViewAccount.Rows[index];
                    row.Cells[this.ColumnUsername.Name].Value = reader[DatabaseContants.clinicuser.Username];
                    row.Cells[this.Columnnamedoctor.Name].Value = reader[DatabaseContants.clinicuser.Namedoctor];
                    row.Cells[this.Columnupdate.Name].Value = "Cập nhật";
                    row.Cells[this.Columndelete.Name].Value = "xóa";
                }
            }
        }


        #endregion

        #region Event Main Clinic

        private void dataGridViewMedicine_CellValueChanged_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex > -1) // change name of medicine
            {
                ChangeNameMedicineDataGrid(e.ColumnIndex, e.RowIndex);
            }
            if (e.ColumnIndex == 1 && e.RowIndex > -1) // change count of medicine
            {
                if (dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value != null && dataGridViewMedicine[2, e.RowIndex].Value != null)
                {
                    try
                    {
                        int count = Helper.ConvertString2Int(dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value);
                        if (!this.IsViewHistory)
                        {
                            SetReadOnlyForControl(false);

                            string nameOfMedicine = dataGridViewMedicine[0, e.RowIndex].Value.ToString();
                            if (nameOfMedicine[0] != '@')
                            {
                                int coutInventory = Helper.ConvertString2Int(dataGridViewMedicine[DatabaseContants.StoreColumnInDataGridViewMedicines, e.RowIndex].Value);
                                if (count > coutInventory)
                                {
                                    MessageBox.Show("Lượng thuốc tồn kho không đủ. Xin vui lòng nhập lại", "Thông báo");
                                    dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value = 0;
                                    count = 0;
                                }
                            }
                            
                        }
                        if (dataGridViewMedicine[DatabaseContants.CostColumnInDataGridViewMedicines, e.RowIndex].Value != null)
                        {
                            int cost = int.Parse(dataGridViewMedicine[DatabaseContants.CostColumnInDataGridViewMedicines, e.RowIndex].Value.ToString()) * count;
                            dataGridViewMedicine[DatabaseContants.MoneyColumnInDataGridViewMedicines, e.RowIndex].Value = cost.ToString();
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Format sai!");
                        dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value = "";
                    }


                }
            }
            if (e.ColumnIndex == 4 && e.RowIndex > -1) // change money
            {
                labelTongTien.Text = "0";
                int total = 0;
                if (dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value != null)
                {
                    for (int i = 0; i < dataGridViewMedicine.Rows.Count; i++)
                    {
                        try
                        {
                            if (dataGridViewMedicine[4, i].Value != null)
                                total += int.Parse(dataGridViewMedicine[4, i].Value.ToString());
                        }
                        catch (Exception ex)
                        {

                        }
                    }
                }

                int temp = total;
                TongTien = total;
                labelTongTien.Text = temp.ToString("C0");
            }
            if(e.ColumnIndex == 3 && e.RowIndex > -1) // Chang Cost Out
            {
                if (dataGridViewMedicine[DatabaseContants.CountColumnInDataGridViewMedicines, e.RowIndex].Value != null)
                {
                    int count;
                    bool success = int.TryParse(dataGridViewMedicine[DatabaseContants.CountColumnInDataGridViewMedicines, e.RowIndex].Value.ToString(),out count);
                    if (success)
                    {
                        int cost = int.Parse(dataGridViewMedicine[DatabaseContants.CostColumnInDataGridViewMedicines, e.RowIndex].Value.ToString()) * count;
                        dataGridViewMedicine[DatabaseContants.MoneyColumnInDataGridViewMedicines, e.RowIndex].Value = cost.ToString();
                    }
                }
            }
        }

        private void ChangeNameMedicineDataGrid(int columnIndex, int rowIndex)
        {
            if (dataGridViewMedicine[columnIndex, rowIndex].Value != null)
            {
                string nameOfMedicine = dataGridViewMedicine[columnIndex, rowIndex].Value.ToString();
                string strCommand = string.Format("SELECT * FROM {0} WHERE Name = {1}", DatabaseContants.tables.medicine, Helper.ConvertToSqlString(nameOfMedicine));
                //MySqlCommand comm = new MySqlCommand(strCommand, Program.conn);
                using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
                {
                    reader.Read();
                    if (reader.HasRows)
                    {
                        string costOut = reader[DatabaseContants.medicine.CostOut].ToString();
                        string HDSD = reader[DatabaseContants.medicine.Hdsd].ToString();
                        string id = reader["Id"].ToString();

                        dataGridViewMedicine[DatabaseContants.CostColumnInDataGridViewMedicines, rowIndex].Value = costOut;
                        dataGridViewMedicine[DatabaseContants.HDSDColumnInDataGridViewMedicines, rowIndex].Value = HDSD;
                        dataGridViewMedicine[DatabaseContants.IdColumnInDataGridViewMedicines, rowIndex].Value = id;
                        string valuInventory = reader[DatabaseContants.medicine.Count] != null ? reader[DatabaseContants.medicine.Count].ToString() : "";
                        if (string.IsNullOrEmpty(valuInventory))
                        {
                            valuInventory = "Dịch Vụ";
                        }
                        dataGridViewMedicine[DatabaseContants.StoreColumnInDataGridViewMedicines, rowIndex].Value = valuInventory;
                    }
                    reader.Close();
                }
                if (!string.IsNullOrEmpty(nameOfMedicine) && nameOfMedicine[0] == '@')
                {
                    dataGridViewMedicine[DatabaseContants.CountColumnInDataGridViewMedicines, rowIndex].Value = "1";
                }
            }
        }
        private void ProcessWhenUserDoubleClickOnSearch(string id, string time)
        {
            string strCommand = string.Format("SELECT * FROM {0} p RIGHT JOIN {1} h ON p.{2} = h.Id WHERE h.Id = {3} AND h.Day = {4}",
                DatabaseContants.tables.patient, DatabaseContants.tables.history,
                DatabaseContants.patient.Id, id,
                time
                );

            // MySqlCommand comm = new MySqlCommand(strCommand, Program.conn);

            using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            {
                reader.Read();
                if (!reader.HasRows) return;

                string medicines = reader["Medicines"].ToString();
                string name = reader["Name"].ToString();
                comboBoxClinicRoomName.Text = name;
                FillInfoToClinicForm(reader, false);
                IdHistoryCurrent = reader["IdHistory"].ToString();
                reader.Close();

                this.dataGridViewMedicine.Rows.Clear();
                if (Helper.CheckDataMedicineOld(medicines))
                {
                    string[] medicineAndCount = new string[] { };
                    medicineAndCount = medicines.Split(',');

                    // empty
                    if (medicineAndCount.Length < 2)
                        return;
                    for (int i = 0; i < medicineAndCount.Length; i = i + 2)
                    {
                        if (this.dataGridViewMedicine.RowCount <= i / 2 + 1)
                        {
                            this.dataGridViewMedicine.Rows.Add();
                        }
                        this.dataGridViewMedicine.Rows[i / 2].Cells[0].Value = medicineAndCount[i];
                        try
                        {
                            this.dataGridViewMedicine.Rows[i / 2].Cells[1].Value = medicineAndCount[i + 1];
                        }
                        catch (Exception ex)
                        { }

                    }
                }
                else
                {
                    string[] newProcess = new string[] { };
                    if (!string.IsNullOrEmpty(medicines))
                    {
                        newProcess = medicines.Split('|');
                    }
                    for (int i = 0; i < newProcess.Length; i++)
                    {
                        string[] parts = newProcess[i].Split(',');
                        if (parts.Length < 4)
                            return;
                        if (this.dataGridViewMedicine.RowCount <= i + 1)
                        {
                            this.dataGridViewMedicine.Rows.Add();
                        }
                        this.dataGridViewMedicine.Rows[i].Cells[0].Value = parts[0];
                        try
                        {
                            this.dataGridViewMedicine.Rows[i].Cells[1].Value = parts[1];
                            if(this.IsViewHistory)
                                this.dataGridViewMedicine.Rows[i].Cells[3].Value = parts[2];
                            else
                            {
                                Medicine medicine = db.GetMedicineFromName(parts[0]);
                                if (medicine != null)
                                    this.dataGridViewMedicine.Rows[i].Cells[3].Value = medicine.CostOut;
                                else
                                    this.dataGridViewMedicine.Rows[i].Cells[3].Value = 0;
                            }
                        }
                        catch (Exception ex)
                        {
                            Log.Error(ex.Message, ex);
                        }
                        
                    }
                }

            }
        }
        private void dataGridViewSearchValue_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string Id = dataGridViewSearchValue[0, e.RowIndex].Value.ToString();
                string time = Helper.ConvertToSqlString(Helper.ChangePositionOfDayAndYear(this.dataGridViewSearchValue.Rows[e.RowIndex].Cells[3].Value.ToString()));
                ProcessWhenUserDoubleClickOnSearch(Id, time);

                string date = dataGridViewSearchValue[3, e.RowIndex].Value.ToString();

                if (this.IsViewHistory)
                {
                    SetReadOnlyForControl(true);
                    dateTimePickerNgayKham.Value = ConvertStringToDateTime(date);
                }
                else
                {
                    SetReadOnlyForControl(false);
                    dateTimePickerNgayKham.Value = DateTime.Now;
                }
                if(this.IsViewHistory)
                    this.btn_khamlai.Visible = true;
            }
        }

        private DateTime ConvertStringToDateTime(string date)
        {
            DateTime datetime = new DateTime();
            string[] splitDate = date.Split('-');
            if (splitDate.Length == 3)
            {
                datetime = new DateTime(Helper.ConvertString2Int(splitDate[2]), Helper.ConvertString2Int(splitDate[1]), Helper.ConvertString2Int(splitDate[0]));
            }
            return datetime;
        }
        private void comboBoxClinicRoomName_SelectedValueChanged(object sender, EventArgs e)
        {
            //string strCommand = "Select * From Patient Where Name = " + Helper.ConvertToSqlString(comboBoxClinicRoomName.Text);
            string strCommand = string.Format("Select * From {0} p RIGHT JOIN {1} h ON p.{2} = h.Id Where p.Name = {3}",
                DatabaseContants.tables.patient, DatabaseContants.tables.history, 
                DatabaseContants.patient.Id, Helper.ConvertToSqlString(comboBoxClinicRoomName.Text));
            //MySqlCommand comm = new MySqlCommand(strCommand, Program.conn);

            using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            {
                reader.Read();
                FillInfoToClinicForm(reader, false);
                reader.Close();

            }
        }


        private void SearchOnTextBox_PressEnter()
        {
            dataGridViewSearchValue.Rows.Clear();
            dataGridViewMedicine.Rows.Clear();

            string findingName = comboBoxClinicRoomName.Text;
            string Id = lblClinicRoomId.Text;
            string strCommandMain = "";
            //
            // Check find level2 if (both Name and ID match)
            string strCommand = "Select Name ," +  DatabaseContants.patient.Id + " From patient  Where Name = " + Helper.ConvertToSqlString(findingName) + " and " +  DatabaseContants.patient.Id + " =" + Helper.ConvertToSqlString(Id);
            // MySqlCommand comm = new MySqlCommand(strCommand, Program.conn);
            using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            {
                reader.Read();
                if (reader.HasRows == true && !string.IsNullOrEmpty(findingName)) //level 2
                {
                    strCommandMain = string.Format("SELECT * FROM patient p RIGHT JOIN history h ON p.{0} = h.Id WHERE h.Id = ",DatabaseContants.patient.Id) + Id;
                }
                else // level 1 
                {
                    if (dateTimePickerNgayKham.Value.Date <= DateTime.Now.Date)
                    {
                        if (string.IsNullOrEmpty(findingName)) //name = null --> find due to date
                        {
                            strCommandMain = string.Format("SELECT * FROM patient p RIGHT JOIN history h ON p.{0} = h.Id WHERE h.Day = ",DatabaseContants.patient.Id) +
                                Helper.ConvertToSqlString(dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd"));
                        }
                        else
                        {
                            strCommandMain = string.Format("SELECT *  FROM patient p RIGHT JOIN history h ON p.{0} = h.Id WHERE p.Name LIKE '%",DatabaseContants.patient.Id) +
                                findingName + "%'";
                        }
                    }
                    else // ngay kham o tuong lai
                    {
                        return;
                        //strCommandMain = "SELECT * FROM patient p RIGHT JOIN history h ON p.Id = h.Id WHERE p.Name LIKE '%" + findingName + "%' ";
                    }
                }
            }

            if (checkBoxShow1Record.Checked) // Get 1 Record
            {
                strCommandMain += " GROUP BY h.Id";
            }



            //string strCommand = "Select ";
            var style = new DataGridViewCellStyle();
            style.Font = new System.Drawing.Font("Lucida Sans Unicode", 10F,
                                                 System.Drawing.FontStyle.Regular,
                                                 System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewSearchValue.DefaultCellStyle = style;

            CircularProgressAction("Loaddata");
            string medicines = "";
            int countData = 0;
            // MySqlCommand comm2 = new MySqlCommand(strCommandMain, Program.conn);
            using (DbDataReader reader2 = db.ExecuteReader(strCommandMain, null) as DbDataReader)
            {
                while (reader2.Read())
                {
                    string ID = reader2[DatabaseContants.patient.Id].ToString(); // id;
                    if (string.IsNullOrEmpty(ID))
                    {
                        continue;
                    }
                    int index = dataGridViewSearchValue.Rows.Add();
                    DataGridViewRow row = dataGridViewSearchValue.Rows[index];
                    row.Cells["ColumnID"].Value = ID; // id
                    row.Cells["ColumnNamePatient"].Value = reader2[DatabaseContants.patient.Name].ToString();
                    row.Cells["ColumnNgaySinh"].Value = reader2.GetDateTime(reader2.GetOrdinal(DatabaseContants.patient.birthday)).ToString("dd-MM-yyyy");//birthday
                    row.Cells["ColumnNgayKham"].Value = reader2.GetDateTime(reader2.GetOrdinal(DatabaseContants.history.Day)).ToString("dd-MM-yyyy");  // ngay kham
                    row.Cells["ColumnAddress"].Value = reader2[DatabaseContants.patient.Address].ToString();//address
                    row.Cells["ColumnSymtom"].Value = reader2[DatabaseContants.history.Symptom].ToString();//symptom
                    row.Cells["ColumnDiagno"].Value = reader2[DatabaseContants.history.Diagnose].ToString(); // chan doan
                    row.Cells["ColumnNhietDo"].Value = reader2[DatabaseContants.history.temperature].ToString();
                    row.Cells["ColumnWeight"].Value = reader2[DatabaseContants.patient.weight].ToString();
                    row.Cells["CollIDHistory"].Value = reader2[DatabaseContants.history.IdHistory].ToString();
                    if (checkBoxShowMedicines.Checked)
                    {
                        medicines = reader2[DatabaseContants.history.Medicines].ToString();
                        try
                        {
                            row.Cells["ColumnSearchValueMedicines"].Value = Helper.ChangeListMedicines(medicines);
                        }
                        catch (Exception exp)
                        {

                        }
                    }
                    row.Cells["ColumnHuyetAp"].Value = reader2[DatabaseContants.history.huyetap].ToString();
                }
            }
            CircularProgressStop("100");
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            this.IsViewHistory = true;
            this.btn_khamlai.Visible = false;
            SearchOnTextBox_PressEnter();

            if (checkBoxShowBigForm.Checked)
            {
                SearchForm searchForm = new Clinic.SearchForm();
                SearchForm.dataGridView1.Rows.Clear();
                CopyDataGridView(dataGridViewSearchValue, SearchForm.dataGridView1);
                searchForm.Show();
            }

        }

        private void CopyDataGridView(DataGridView dgv_org, DataGridView dgv_target)
        {
            //DataGridView dgv_copy = new DataGridView();
            try
            {
                if (dgv_target.Columns.Count == 0)
                {
                    foreach (DataGridViewColumn dgvc in dgv_org.Columns)
                    {
                        dgv_target.Columns.Add(dgvc.Clone() as DataGridViewColumn);
                    }
                }

                DataGridViewRow row = new DataGridViewRow();

                for (int i = 0; i < dgv_org.Rows.Count; i++)
                {
                    row = (DataGridViewRow)dgv_org.Rows[i].Clone();
                    int intColIndex = 0;
                    foreach (DataGridViewCell cell in dgv_org.Rows[i].Cells)
                    {
                        row.Cells[intColIndex].Value = cell.Value;
                        intColIndex++;
                    }
                    dgv_target.Rows.Add(row);
                }
                dgv_target.AllowUserToAddRows = false;
                dgv_target.Refresh();

            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }

        }

        private void comboBoxClinicRoomName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                buttonSearch_Click(sender, e);
            }
        }
        private void bw_DoWork(string idbenhnhan)
        {
            //string idbenhnhan = e.Argument.ToString();
            string strHenTaiKham = "";
            if (checkBoxHen.Checked == true)
            {
                strHenTaiKham = BuildStringHenTaiKham(idbenhnhan, strHenTaiKham);
            }

            Patient patient = new Patient(this.lblClinicRoomId.Text, comboBoxClinicRoomName.Text, txtBoxClinicRoomWeight.Text, txtBoxClinicRoomHeight.Text, txtBoxClinicRoomAddress.Text, dateTimePickerBirthDay.Value);


            if (string.IsNullOrEmpty(this.comboBoxClinicRoomName.Text))
            {
                MessageBox.Show("Tên bệnh nhân");
                this.Enabled = true;
                return;
            }

            if (infoClinic == null)
            {
                System.Windows.Forms.MessageBox.Show("Bạn chưa nhập thông tin ở Tool. Xin vào Tool để nhập thông tin", "Thông báo");
                return;
            }

            string originalName = Helper.hasOtherNameForThisId(db, idbenhnhan,
                this.comboBoxClinicRoomName.Text);
            if (originalName != null)
            {
                MessageBox.Show("Bạn không thể sửa tên bệnh nhân đã nhập!");
                this.comboBoxClinicRoomName.Text = originalName;
                this.Enabled = true;
                return;
            }

            bool isPatientExist = Helper.checkPatientExists(db, idbenhnhan);

            if (!isPatientExist)
            {
                List<string> columns = new List<string>() { DatabaseContants.patient.Name, DatabaseContants.patient.Address, DatabaseContants.patient.birthday, DatabaseContants.patient.height, DatabaseContants.patient.weight, DatabaseContants.patient.Id, DatabaseContants.patient.Phone };
                List<string> values = new List<string>()
                {
                    comboBoxClinicRoomName.Text,
                    txtBoxClinicRoomAddress.Text,
                    dateTimePickerBirthDay.Value.ToString("yyyy-MM-dd"),
                    txtBoxClinicRoomHeight.Text,
                    txtBoxClinicRoomWeight.Text,
                    lblClinicRoomId.Text,
                    textBoxClinicPhone.Text
                };
                db.InsertRowToTable(DatabaseContants.tables.patient, columns, values);
            }


            List<Medicine> listMedicines = new List<Medicine>();
            if (this.dataGridViewMedicine.Rows.Count > 1)
            {
                listMedicines = Helper.GetAllMedicinesFromDataGrid(this.dataGridViewMedicine);
                int sumFollowDatagird = listMedicines.Sum(x => x.Number * x.CostOut);
                if (TongTien != sumFollowDatagird)
                {
                    MessageBox.Show("Có sự sai soát trong tổng tiền.");
                    return;
                }
            }
            // id history in danh thu exists.
            string idHistoryOld = string.Empty;
            if (!Helper.checkVisitExists(db, idbenhnhan, this.dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd"), ref idHistoryOld))
            {
                AddVisitData(listMedicines);

                // not exist
                idHistoryOld = db.SearchIDHistoryByIDPatientAndDay(idbenhnhan, this.dateTimePickerNgayKham.Value.ToString("yyyy-MM-dd"));
                //save to doanhthu
                List<string> valuesDoanhThu = new List<string>() { Form1.nameOfDoctor, TongTien.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), lblClinicRoomId.Text, comboBoxClinicRoomName.Text, Helper.BuildStringServices4SavingToDoanhThu(listMedicines), comboBoxLoaiKham.Text, idHistoryOld };
                db.InsertRowToTable(DatabaseContants.tables.danhthu, Helper.ColumnsDoanhThu, valuesDoanhThu);

                //tru tu thuoc
                Helper.TruTuThuoc(db, listMedicines);

            }
            else
            {
                //sua tu thuoc 
                List<Medicine> listMedicineFromHistory = new List<Medicine>();
                bool isNew = false;
                try
                {
                    listMedicineFromHistory = Helper.GetMedicinesFromHistoryByID(db, idHistoryOld, ref isNew);
                }
                catch (Exception ex)
                {
                    Log.Error(ex.Message, ex);
                }

                // list old and new
                List<Medicine> UpdateMedicines = Helper.CompareTwoListMedicineToUpdate(listMedicineFromHistory, listMedicines);

                Helper.TruTuThuoc(db, UpdateMedicines);

                ChangeVisitData(listMedicines);

                //maxValueIdHistoryFromHistory = Helper.SearchMaxValueOfTableWithoutPlusPlus(ClinicConstant.HistoryTable, ClinicConstant.HistoryTable_IdHistory, "DESC").ToString();

                if (isNew)
                {

                    //save to doanhthu
                    List<string> valuesDoanhThu = new List<string>() { Form1.nameOfDoctor, TongTien.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), idbenhnhan, comboBoxClinicRoomName.Text, Helper.BuildStringServices4SavingToDoanhThu(listMedicines), this.comboBoxLoaiKham.Text, idHistoryOld };
                    db.InsertRowToTable(DatabaseContants.tables.danhthu, Helper.ColumnsDoanhThu, valuesDoanhThu);
                }
                else
                {

                    //update to doanhthu
                    List<string> columnsDoanhThu = new List<string>() { "Namedoctor", "Money", "time", DatabaseContants.danhthu.Services, DatabaseContants.danhthu.LoaiKham, DatabaseContants.history.IdHistory };
                    List<string> valuesDoanhThu = new List<string>() { Form1.nameOfDoctor, TongTien.ToString(), DateTime.Now.ToString("yyyy-MM-dd"), Helper.BuildStringServices4SavingToDoanhThu(listMedicines), comboBoxLoaiKham.Text, idHistoryOld };
                    Helper.UpdateRowToTableDoanhThu(db, DatabaseContants.tables.danhthu, columnsDoanhThu, valuesDoanhThu, idbenhnhan);
                }
            }
            UpdateStatusAppointment(idbenhnhan, idHistoryOld);
            AddToLichHenTable(idbenhnhan, idHistoryOld);

            int STT = Helper.LaySTTTheoNgay(db, DateTime.UtcNow, this.lblClinicRoomId.Text);
            Helper.CreateAPdf(infoClinic, idbenhnhan, patient, listMedicines, strHenTaiKham, this.txtBoxClinicRoomDiagnose.Text, this.labelTuoi.Text, STT, this.cbb_Reason.Text);
            this.cbb_Reason.Text = string.Empty;

        }
        // remember update duy nhat add lichj hen
        private void UpdateStatusAppointment(string idbenhnhan, string idHistoryOld)
        {
            // select id,state,idpatient,time,idHistory
            string strcmd = string.Format("select Idlichhen,{1},{3},{5},{6} from {2} where {3} = {4} and {1} = 0 order by {5} limit 1", DatabaseContants.LichHen.ID, DatabaseContants.LichHen.status, DatabaseContants.tables.lichHen, DatabaseContants.LichHen.Idpatient, idbenhnhan, DatabaseContants.LichHen.Time,DatabaseContants.LichHen.IdHistory);
            using (DbDataReader reader = db.ExecuteReader(strcmd, null) as DbDataReader)
            {
                while (reader.Read())
                {
                    if (Helper.ConvertObject2String(reader[DatabaseContants.LichHen.IdHistory]) == idHistoryOld)
                        return;
                    int status = GetStatusAppointment(reader[DatabaseContants.LichHen.Idpatient].ToString(),Convert.ToDateTime(reader[DatabaseContants.LichHen.Time]), reader[DatabaseContants.LichHen.status]);
                    if (status == 0)
                    {
                        string strUpdate = string.Format("update {0} set {1} = {2} where {3} = {4}", DatabaseContants.tables.lichHen, DatabaseContants.LichHen.status, 1, DatabaseContants.LichHen.ID, reader[DatabaseContants.LichHen.ID]);
                        DatabaseFactory.Instance2.ExecuteNonQuery(strUpdate,null);
                        return;
                    }
                }
            }
        }

        private void AddToLichHenTable(string idbenhnhan,string idHistory)
        {
            if (checkBoxHen.Checked == true)
            {
                string IDLichHen = "";
                if (Helper.IsExistsAppointment(db,idbenhnhan, idHistory,ref IDLichHen)) // update
                {
                    List<string> columnslichhen = new List<string>() { "Idpatient", "Namedoctor", "Namepatient", "time", "phone", "benh", DatabaseContants.history.IdHistory, DatabaseContants.LichHen.status };
                    List<string> valueslichhen = new List<string>() { idbenhnhan, Form1.nameOfDoctor, comboBoxClinicRoomName.Text, dateTimePickerHen.Value.ToString("yyyy-MM-dd"), textBoxClinicPhone.Text, txtBoxClinicRoomDiagnose.Text, idHistory, "0" };
                    db.UpdateRowToTable(DatabaseContants.tables.lichHen, columnslichhen, valueslichhen, DatabaseContants.LichHen.ID, IDLichHen);
                }
                else // add new
                {
                    List<string> columnslichhen = new List<string>() { "Idpatient", "Namedoctor", "Namepatient", "time", "phone", "benh", DatabaseContants.history.IdHistory, DatabaseContants.LichHen.status };
                    List<string> valueslichhen = new List<string>() { idbenhnhan, Form1.nameOfDoctor, comboBoxClinicRoomName.Text, dateTimePickerHen.Value.ToString("yyyy-MM-dd"), textBoxClinicPhone.Text, txtBoxClinicRoomDiagnose.Text, idHistory, "0" };
                    db.InsertRowToTable(DatabaseContants.tables.lichHen, columnslichhen, valueslichhen);
                }
                checkBoxHen.Checked = false;
            }
        }

        private string BuildStringHenTaiKham(string idbenhnhan, string strHenTaiKham)
        {
            strHenTaiKham = "Mời tái khám vào ngày: " + dateTimePickerHen.Value.ToString("dd-MM-yyyy");
            return strHenTaiKham;
        }

        private void buttonPutIn_Click(object sender, EventArgs e)
        {
            // validate
            if (!ValidateFormHome())
            {
                MessageBox.Show("Bạn nhập bị lỗi ", "Thông báo");
                return;
            }

            string idbenhnhan = this.lblClinicRoomId.Text;

            if (dateTimePickerNgayKham.Value.ToShortDateString() != DateTime.Now.ToShortDateString())
            {
                MessageBox.Show("Không thể khám ở quá khứ");
                return;
            }

            if (this.IsViewHistory)
            {
                MessageBox.Show("Không thể khám ở quá khứ. Xin chọn khám lại bệnh nhân.");
                return;
            }

            if (!Helper.CheckAllDataCellMedicine(this.dataGridViewMedicine))
            {
                return;
            }
            if (Helper.ExistMoreThanOneRowOfMedicine(this.dataGridViewMedicine))
            {
                MessageBox.Show("Trùng Thuốc!");
                return;
            }

            string thongbao = "Kết thúc phiên khám! và không hẹn";
            if (checkBoxHen.Checked == true)
            {
                if (dateTimePickerHen.Value <= DateTime.Now)
                {
                    MessageBox.Show("Ngày hẹn không được ở quá khứ và hiện tại");
                    return;
                }
                thongbao = "Kết thúc phiên khám! và hẹn tái khám vào ngày: " + dateTimePickerHen.Value.ToString("dd-MM-yyyy");
            }

            DialogResult result = MessageBox.Show(thongbao, "Xin xác nhận!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (result == DialogResult.Cancel)
            {
                return;
            }
            else if (result == DialogResult.OK)
            {
                this.Enabled = false;
                //BackgroundWorker backgroundWorker = new BackgroundWorker();
                //backgroundWorker.WorkerSupportsCancellation = true;
                //backgroundWorker.DoWork += new DoWorkEventHandler(bw_DoWork);
                //backgroundWorker.RunWorkerCompleted += new RunWorkerCompletedEventHandler(bw_RunWorkerCompleted);
                //backgroundWorker.RunWorkerAsync(idbenhnhan);
                bw_DoWork(idbenhnhan);
                try
                {
                    axAcroPDF1.LoadFile("firstpage.pdf");
                    db.UpdateRowToTable(DatabaseContants.tables.patient, new List<string>() { "phone" }, new List<string>() { this.textBoxClinicPhone.Text },DatabaseContants.patient.Id ,idbenhnhan);
                }
                catch
                {


                }
                this.Enabled = true;
                
                UpdateForm();
            }

        }

        private void UpdateForm()
        {
            string strCommandMain = string.Format("SELECT *  FROM patient p RIGHT JOIN history h ON p.{0} = h.Id WHERE p.{0} = ",DatabaseContants.patient.Id) + Helper.ConvertToSqlString(this.lblClinicRoomId.Text);
            FillDataGridViewSearchValue(strCommandMain);
            UpdateToolstrip();
        }

        private void UpdateToolstrip()
        {
            toolStripStatusLabel2.Text = Helper.SoLuotKhamTrongNgay(DatabaseFactory.Instance3, Form1.nameOfDoctor).ToString();
            toolpatientAllCount.Text = Helper.TongSoLuotKhamTrongNgay(DatabaseFactory.Instance3) + "/" + Helper.SoluotKham0DongInDay(DatabaseFactory.Instance3,DateTime.Now);
        }
        private void bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }


        #endregion

        #region Event Main Tool

        private void button3_Click(object sender, EventArgs e)
        {
            if (!ValidateFormTool())
            {
                MessageBox.Show("Bạn có giá trị chưa nhập!");
                return;
            }
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (Helper.checkUserExistsWithoutPassword(username))
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại, vui lòng nhập tên đăng nhập khác!");
                return;
            }

            int Authority = 0;
            if (checkBoxKethuoc.Checked == true)
            {
                Authority = 2; // bac si
            }
            if (checkBoxNhapThuoc.Checked == true)
            {
                Authority = 3; // nhan vien nhap thuoc
            }
            if (checkBoxNhapThuoc.Checked == true && checkBoxKethuoc.Checked == true)
            {
                Authority = 4; // ca 2
            }


            List<string> columns = new List<string>() { DatabaseContants.clinicuser.Username, DatabaseContants.clinicuser.Password1, DatabaseContants.clinicuser.Authority, DatabaseContants.clinicuser.Namedoctor };
            List<string> values = new List<string>() { username, Helper.Encrypt(password), Authority.ToString(), textBoxNameDoctor.Text };

            db.InsertRowToTable(DatabaseContants.tables.clinicuser, columns, values);
            MessageBox.Show("Thêm mới nhân viên thành công");
        }

        #endregion

        CalendarItem contextItem = null;
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            contextItem = calendar1.ItemAt(contextMenuStrip1.Bounds.Location);
        }

        private void calendar1_ItemDoubleClick(object sender, CalendarItemEventArgs e)
        {
            calendar1.ActivateEditMode();
        }

        private void calendar1_ItemDeleted(object sender, CalendarItemEventArgs e)
        {
            _items.Remove(e.Item);
            db.DeleteRowToTableCalendar(DatabaseContants.tables.calendar, e.Item.Tag.ToString(), Form1.UserName);

        }

        private void calendar1_ItemTextEdited(object sender, CalendarItemCancelEventArgs e)
        {

            // e.Item.Tag = // set id
            db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "Text" }, new List<string> { e.Item.Text }, e.Item.Tag.ToString(), UserName);

        }

        private void calendar1_ItemDatesChanged(object sender, CalendarItemEventArgs e)
        {

            // e.Item.Tag = // set id
            try
            {
                db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "StartTime", "EndTime" }, new List<string> { Helper.ConvertToDatetimeSql(e.Item.StartDate), Helper.ConvertToDatetimeSql(e.Item.EndDate) }, e.Item.Tag.ToString(), UserName);
            }
            catch (Exception ex)
            {
                Log.Error(ex.Message, ex);
            }

        }

        private void calendar1_DayHeaderClick(object sender, CalendarDayEventArgs e)
        {
            calendar1.SetViewRange(e.CalendarDay.Date, e.CalendarDay.Date);
        }
        private void calendar1_ItemCreated(object sender, CalendarItemCancelEventArgs e)
        {
            _items.Add(e.Item);
            //if (e.Item.Text.Length > 0)
            //{
            e.Item.Tag = maxIdOfCalendarItem;
            List<string> values = new List<string> { maxIdOfCalendarItem.ToString(), UserName, Helper.ConvertToDatetimeSql(e.Item.StartDate), Helper.ConvertToDatetimeSql(e.Item.EndDate), e.Item.Text, "0" };
            db.InsertRowToTable(DatabaseContants.tables.calendar, DatabaseContants.columnsCalendar, values);
            //MessageBox.Show("s");
            //}
            maxIdOfCalendarItem = Helper.SearchMaxValueOfTable(DatabaseContants.tables.calendar, "IdCalendar", "DESC");
        }

        public FileInfo ItemsFile
        {
            get
            {
                return new FileInfo(Path.Combine(Application.StartupPath, "items.xml"));
            }
        }
        private void monthView1_SelectionChanged(object sender, EventArgs e)
        {
            calendar1.SetViewRange(tabPageLich.SelectionStart, tabPageLich.SelectionEnd);

            //refresh datagridViewCalendar

            this.dataGridViewCalendar.Rows.Clear();
            LoadLichHen(tabPageLich.SelectionStart);

        }
        private void PlaceItems()
        {
            foreach (CalendarItem item in _items)
            {
                if (calendar1.ViewIntersects(item))
                {
                    calendar1.Items.Add(item);
                }
            }
        }

        private void calendar1_ItemClick(object sender, CalendarItemEventArgs e)
        {
            //MessageBox.Show(e.Item.Text);
        }
        private void calendar1_LoadItems(object sender, CalendarLoadEventArgs e)
        {
            PlaceItems();
        }
        private void calendar1_ItemMouseHover(object sender, CalendarItemEventArgs e)
        {
            Text = e.Item.Text;
        }
        private void otherColorTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ColorDialog dlg = new ColorDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    foreach (CalendarItem item in calendar1.GetSelectedItems())
                    {
                        item.ApplyColor(dlg.Color);
                        calendar1.Invalidate(item);
                    }
                }
            }
        }
        private void redTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Red);
                calendar1.Invalidate(item);
                db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "Color" }, new List<string> { "1" }, item.Tag.ToString(), UserName);


            }
        }

        private void yellowTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Gold);
                calendar1.Invalidate(item);
                db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "Color" }, new List<string> { "2" }, item.Tag.ToString(), UserName);
            }
        }

        private void greenTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.Green);
                calendar1.Invalidate(item);
                db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "Color" }, new List<string> { "3" }, item.Tag.ToString(), UserName);
            }
        }

        private void blueTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CalendarItem item in calendar1.GetSelectedItems())
            {
                item.ApplyColor(Color.DarkBlue);
                calendar1.Invalidate(item);
                db.UpdateRowToTableCalendar(DatabaseContants.tables.calendar, new List<string> { "Color" }, new List<string> { "4" }, item.Tag.ToString(), UserName);
            }
        }
        private void editItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            calendar1.ActivateEditMode();
        }

        private void label30_Click(object sender, EventArgs e)
        {

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //Trang Đầu
            //Trang Cuối
            //Tất Cả
            //Tùy Chỉnh
            //if (this.comboBoxPrintPageOptions.SelectedItem == "Trang Đầu")
            //{

            //    axAcroPDF1.printPages(1, 1);
            //}
            //else if (this.comboBoxPrintPageOptions.SelectedItem == "Trang Cuối")
            //{

            //    axAcroPDF1.printPages(2, 2);
            //}
            //else if (this.comboBoxPrintPageOptions.SelectedItem == "Tất Cả")
            //{

            //    axAcroPDF1.printPages(1, 2);
            //}
            //else if (this.comboBoxPrintPageOptions.SelectedItem == "Tùy Chỉnh")
            //{
                axAcroPDF1.printWithDialog();
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            InfoClinic infoClinic = new InfoClinic();
            infoClinic.Name = textBoxNameClinic.Text;
            infoClinic.Address = textBoxAddressClinic.Text;
            infoClinic.Advice = textBoxAdviceClinic.Text;
            infoClinic.Sdt = textBoxSDT.Text;
            infoClinic.PathData = textBoxBackupSource.Text;
            infoClinic.PathTargetBackup = textBoxBackupTarget.Text;
            infoClinic.CheckedBackup1 = checkBoxAutoCopy.Checked.ToString();
            infoClinic.TimeBackup = textBoxBackupTimeAuto.Text;

            XmlSerializer serializer = new XmlSerializer(infoClinic.GetType());
            StreamWriter sw = new StreamWriter("Information.xml");
            serializer.Serialize(sw, infoClinic);
            sw.Close();

            MessageBox.Show("Thay đổi thành công, yêu cầu chạy lại chương trình để áp dụng thông tin mới", "Thông báo!");
        }

        private void checkBoxAutoCopy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoCopy.Checked == true)
            {


                System.Threading.TimerCallback TimerDelegate =
        new System.Threading.TimerCallback(TimerTask);

                // Create a timer that calls a procedure every int.Parse(textBoxBackupTimeAuto.Text) seconds. 
                // Note: There is no Start method; the timer starts running as soon as  
                // the instance is created.
                if (string.IsNullOrEmpty(textBoxBackupTimeAuto.Text))
                    return;

                int minute = int.Parse(textBoxBackupTimeAuto.Text) * 1000 * 60;
                TimerItem =
                    new System.Threading.Timer(TimerDelegate, null, minute, minute);

            }

            else
            {
                if (TimerItem != null)
                    TimerItem.Dispose();
            }

        }

        private void TimerTask(object StateObj)
        {
            Helper.CopyFilesRecursively(new DirectoryInfo(textBoxBackupSource.Text), new DirectoryInfo(textBoxBackupTarget.Text));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBackupSource.Text = folderBrowserDialog.SelectedPath;

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowNewFolderButton = true;
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                textBoxBackupTarget.Text = folderBrowserDialog.SelectedPath;

            }
        }
        private void dataGridViewMedicine_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void buttonClinicClear_Click(object sender, EventArgs e)
        {
            ClearClinicRoomForm();
            InitClinicRoom();
        }

        private void buttonClinicCreateNew_Click(object sender, EventArgs e)
        {
            if (this.comboBoxClinicRoomName.Text == null || this.comboBoxClinicRoomName.Text == string.Empty)
            {
                MessageBox.Show("Tên Bệnh Nhân Bạn Chưa Nhập","Thông báo");
                return;
            }

            if (!ValidateFormHome())
            {
                MessageBox.Show("Bạn nhập bị lỗi ", "Thông báo");
                return;
            }

            string originalName = Helper.hasOtherNameForThisId(db, this.lblClinicRoomId.Text,
                this.comboBoxClinicRoomName.Text);
            if (originalName != null)
            {
                MessageBox.Show("Bệnh Nhân Có Tên Này Đã Nhập Rồi, Xin hãy làm mới lại ID khác","Thông báo lỗi");
                this.comboBoxClinicRoomName.Text = originalName;
                return;
            }

            bool isPatientExist = Helper.checkPatientExists(db, this.lblClinicRoomId.Text);

            if (!isPatientExist) // them moi
            {
                if (Helper.SameAddressAndName(db, this.comboBoxClinicRoomName.Text, this.txtBoxClinicRoomAddress.Text))
                {
                    DialogResult r = MessageBox.Show("Tên và địa chỉ trùng với 1 người , bạn có thực sự muốn tạo mới ??", "Chú ý", MessageBoxButtons.YesNo);
                    if (r == System.Windows.Forms.DialogResult.No)
                    {
                        buttonSearch.PerformClick();
                        return;
                    }
                }


                List<string> columns = new List<string>() { DatabaseContants.patient.Name, DatabaseContants.patient.Address, DatabaseContants.patient.birthday, DatabaseContants.patient.height, DatabaseContants.patient.weight, DatabaseContants.patient.Phone };
                //List<string> columns = new List<string>() { "Name", "Address", "Birthday", "phone" };
                List<string> values = new List<string>()
                {
                    comboBoxClinicRoomName.Text,
                    txtBoxClinicRoomAddress.Text,
                    dateTimePickerBirthDay.Value.ToString("yyyy-MM-dd"),
                    txtBoxClinicRoomHeight.Text,
                    txtBoxClinicRoomWeight.Text,
                    textBoxClinicPhone.Text
                };
                db.InsertRowToTable(DatabaseContants.tables.patient, columns, values);
                GetIDMaxCurrentPatient();
                string medicines = "Dd nhập bệnh nhân mới,!";

                List<string> columnsHistory = new List<string>() { "Id", "Symptom","temperature", "Diagnose", "Day", "Medicines" };
                List<string> valuesHistory = new List<string>() { lblClinicRoomId.Text, txtBoxClinicRoomSymptom.Text,textBoxClinicNhietDo.Text, txtBoxClinicRoomDiagnose.Text, DateTime.Now.ToString("yyyy-MM-dd"), medicines };
                db.InsertRowToTable(DatabaseContants.tables.history, columnsHistory, valuesHistory);
                MessageBox.Show("Thêm bệnh nhân mới thành công","Thông Báo");      
                
            }
            else // cap nhat
            {
                List<string> columns = new List<string>() { DatabaseContants.patient.Address, DatabaseContants.patient.birthday, DatabaseContants.patient.height, DatabaseContants.patient.weight, DatabaseContants.patient.Phone };
                List<string> values = new List<string>() { txtBoxClinicRoomAddress.Text, dateTimePickerBirthDay.Value.ToString("yyyy-MM-dd"), txtBoxClinicRoomHeight.Text, txtBoxClinicRoomWeight.Text, textBoxClinicPhone.Text };
                db.UpdateRowToTable(DatabaseContants.tables.patient, columns, values,DatabaseContants.patient.Id, lblClinicRoomId.Text);

                // edit history
                //List<string> columnsHistory = new List<string>() {"temperature","huyetap" };
                //List<string> valuesHistory = new List<string>() {textBoxClinicNhietDo.Text,textBoxHuyetAp.Text };
                //if(!string.IsNullOrEmpty(IdHistoryCurrent))
                   // Helper.UpdateRowToTable(db, "history", columnsHistory, valuesHistory, DatabaseContants.history.IdHistory, IdHistoryCurrent);
                MessageBox.Show("Sửa thông tin thành công");
            }

            //put into listpatientToday
            AddListPatientToday();

        }

        private void AddListPatientToday()
        {
            try
            {
                // nhiet do : huyet ap : can nang: chieu cao
                string state = textBoxClinicNhietDo.Text + ';' + textBoxHuyetAp.Text + ';' + txtBoxClinicRoomWeight.Text + ';' + txtBoxClinicRoomHeight.Text;
                List<string> columnslistpatientToday = new List<string>() { "Id", "Name", "State", "time" };
                List<string> valueslistpatientToday = new List<string>() { lblClinicRoomId.Text, comboBoxClinicRoomName.Text, state, DateTime.Now.ToString("yyyy-MM-dd") };
                db.InsertRowToTable(DatabaseContants.tables.listpatienttoday, columnslistpatientToday, valueslistpatientToday);
            }
            catch
            {
                MessageBox.Show("Bệnh nhân đã có trong danh sách");
            }
        }

        private void buttonList_MouseHover(object sender, EventArgs e)
        {


            listPatientForm.Show();
            SetParent((int)listPatientForm.Handle, (int)this.Handle);
            listPatientForm.Location = new Point(10, 100);

            //update database

            listPatientToday = db.GetListPatientToday();
            listPatientForm.PutIntoGrid(listPatientToday);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonHen_Click(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (this.checkBoxHen.Checked == true)
            {
                cbb_Reason.Visible = true;
                LoadReason();
            }
            else
            {
                cbb_Reason.Visible = false;
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dateTimePickerBirthDay_ValueChanged(object sender, EventArgs e)
        {
            //int day = DateTime.Now.Day - dateTimePickerBirthDay.Value.Day;
            Age age = new Age(dateTimePickerBirthDay.Value, DateTime.Now);
            if (age.Years >= 6)
            {
                labelTuoi.Text = age.Years.ToString() + " tuổi ";
            }
            else
            {
                int thang = age.Years * 12 + age.Months + 1;
                labelTuoi.Text = thang.ToString() + " tháng";
            }

        }

        private void doanhThuToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Authority == 1)
            {
                DoanhThuForm dtForm = new Clinic.DoanhThuForm();
                dtForm.Show();

            }
            else
            {
                MessageBox.Show("Chỉ khả dụng cho admin! ");
            }
        }

        private void tủThuốcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authority == 1 || Authority == 3)
            {
                TuThuocForm dtForm = new Clinic.TuThuocForm();
                dtForm.Show();
            }
            else
            {
                MessageBox.Show("Chỉ khả dụng cho admin va Quyen nhap thuoc! ");
            }
        }

        private void cácDịchVụToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authority == 1)
            {
                Services formservices = new Clinic.Services();
                formservices.Show();
            }
            else
            {
                MessageBox.Show("Chỉ khả dụng cho admin! ");
            }
        }

        private void dataGridViewMedicine_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            labelTongTien.Text = "0";
            int total = 0;

            for (int i = 0; i < dataGridViewMedicine.Rows.Count; i++)
            {
                try
                {
                    if (dataGridViewMedicine[4, i].Value != null)
                        total += Helper.ConvertString2Int(dataGridViewMedicine[4, i].Value);
                }
                catch (Exception)
                {
                }
            }

            int temp = total;
            TongTien = total;
            labelTongTien.Text = temp.ToString("C0");
        }

        private void dataGridViewCalendar_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex < 0 || e.ColumnIndex != dataGridViewCalendar.Columns["ColumnState"].Index) return;
            //string id = dataGridViewCalendar.Rows[e.RowIndex].Cells["Id"].Value.ToString();
            //string name = dataGridViewCalendar.Rows[e.RowIndex].Cells["Patient"].Value.ToString();

            //string strCommand = "Select * From patient  Where Name = " + Helper.ConvertToSqlString(name) + " and Idpatient =" + Helper.ConvertToSqlString(id);

            //using (DbDataReader reader = db.ExecuteReader(strCommand, null) as DbDataReader)
            //{
            //    reader.Read();
            //    FillInfoToClinicForm(reader, true);
            //}
            //buttonSearch.PerformClick();
            //Helper.DeleteRowFromTableCalendar(db, id, name);
            //dataGridViewCalendar.Rows.RemoveAt(e.RowIndex);
        }

        private void dataGridViewMedicine_Leave(object sender, EventArgs e)
        {

        }

        private void dataGridViewMedicine_MouseLeave(object sender, EventArgs e)
        {
            int total = 0;

            for (int i = 0; i < dataGridViewMedicine.Rows.Count; i++)
            {
                try
                {
                    if (dataGridViewMedicine[4, i].Value != null)
                        total += int.Parse(dataGridViewMedicine[4, i].Value.ToString());
                }
                catch (Exception)
                {
                }
            }

            int temp = total;
            TongTien = total;
            labelTongTien.Text = temp.ToString("C0");
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            LamMoiIDRoom();
        }

        private void LamMoiIDRoom()
        {
            int intId = Helper.SearchMaxValueOfTable(DatabaseContants.tables.patient, DatabaseContants.patient.Id, "DESC");
            string ID = intId.ToString();
            lblClinicRoomId.Text = ID;
        }

        private void GetIDMaxCurrentPatient()
        {
            int intId = Helper.SearchMaxValueOfTable(DatabaseContants.tables.patient, DatabaseContants.patient.Id, "DESC");
            string ID = (intId - 1).ToString();
            lblClinicRoomId.Text = ID;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateToolstrip();
            textBoxClinicPhone.TabStop = false;
            // create timer interval 
            timer = new System.Windows.Forms.Timer();
            timer.Interval = 12000;
            timer.Tick += timer_Tick;
            timer.Start();
        }

        void timer_Tick(object sender, EventArgs e)
        {
           if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)(() =>
                {
                    UpdateToolstrip();
                }));
            }
            else
            {
                UpdateToolstrip();
            }
            
        }

        private void loaiKhamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.loaiKhamToolStripMenuItem.Checked = !this.loaiKhamToolStripMenuItem.Checked;

        }

        private void themLoaiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //db.InsertRowToTable(ClinicConstant.LoaiKhamTable,new List<string>(){ClinicConstant.LoaiKhamTable_Nameloaikham},new List<string>(){te}
            themLoaiForm form = new themLoaiForm();
            form.Show();
        }



        private void textBoxReason_VisibleChanged(object sender, EventArgs e)
        {
            if (this.checkBoxHen.Checked == true)
            {
                TextBox TB = (TextBox)sender;
                int VisibleTime = 1000;  //in milliseconds

                ToolTip tt = new ToolTip();
                tt.Show("Lý do tái khám", TB, 0, 0, VisibleTime);
            }
        }

        private void cácChẩnĐoánToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Authority == 1)
            {
                AddItemAutoCompleteTextBoxDiagnoses(false);
                DiagnosesHistory form = new DiagnosesHistory(listDiagnosesFromHistory, listDiagnosesFromDiagnoses);
                form.ShowDialog();
                AddItemAutoCompleteTextBoxDiagnoses();
            }
            else
            {
                MessageBox.Show("Chỉ khả dụng cho admin! ");
            }
        }

        private void txtBoxClinicRoom_Validating(object sender, CancelEventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //try
            //{
            //    if (string.IsNullOrEmpty(textBox.Text))
            //    {
            //        ErrorProviderHelper.GetInstance.SetError(textBox, "");
            //        return;
            //    }
            //    double temp = double.Parse(textBox.Text);
            //    ErrorProviderHelper.GetInstance.SetError(textBox,"");
            //}
            //catch (Exception ex)
            //{
            //    ErrorProviderHelper.GetInstance.SetError(textBox, "Bạn Phải Nhập Kiểu Number");
            //}
        }

        private void comboBoxClinicRoomName_Validating(object sender, CancelEventArgs e)
        {
            //TextBox textBox = (TextBox)sender;
            //if (string.IsNullOrEmpty(textBox.Text))
            //{
            //    ErrorProviderHelper.GetInstance.SetError(textBox, "Bạn không ");
            //}
        }
        public void FillDataGridViewSearchValue(string strCommandMain)
        {
            dataGridViewSearchValue.Rows.Clear();

            using (DbDataReader reader2 = db.ExecuteReader(strCommandMain, null) as DbDataReader)
            {
                while (reader2.Read())
                {
                    string ID = reader2[DatabaseContants.patient.Id].ToString(); // id
                    if (string.IsNullOrEmpty(ID))
                    {
                        continue;
                    }
                    
                    int index = dataGridViewSearchValue.Rows.Add();
                    DataGridViewRow row = dataGridViewSearchValue.Rows[index];
                    row.Cells["ColumnID"].Value = ID; // id                    
                    row.Cells["ColumnNamePatient"].Value = reader2[DatabaseContants.patient.Name].ToString();
                    row.Cells["ColumnNgaySinh"].Value = reader2.GetDateTime(reader2.GetOrdinal(DatabaseContants.patient.birthday)).ToString("dd-MM-yyyy");//birthday
                    row.Cells["ColumnNgayKham"].Value = reader2.GetDateTime(reader2.GetOrdinal(DatabaseContants.history.Day)).ToString("dd-MM-yyyy");  // ngay kham
                    row.Cells["ColumnAddress"].Value = reader2[DatabaseContants.patient.Address].ToString();//address
                    row.Cells["ColumnSymtom"].Value = reader2[DatabaseContants.history.Symptom].ToString();//symptom
                    row.Cells["ColumnDiagno"].Value = reader2[DatabaseContants.history.Diagnose].ToString(); // chan doan
                    row.Cells["ColumnNhietDo"].Value = reader2[DatabaseContants.history.temperature].ToString();
                    if (checkBoxShowMedicines.Checked)
                    {
                        string medicines = reader2[DatabaseContants.history.Medicines].ToString();
                        try
                        {
                            row.Cells["ColumnSearchValueMedicines"].Value = Helper.ChangeListMedicines(medicines);
                        }
                        catch (Exception exp)
                        {

                        }
                    }
                    row.Cells["ColumnHuyetAp"].Value = reader2[DatabaseContants.history.huyetap].ToString();
                }
            }
        }

        private bool ValidateFormHome()
        {
            //if(!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(this.textBoxClinicNhietDo))){
            //    return false;
            //}
            //if(!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(this.textBoxHuyetAp))){
            //    return false;
            //}
            //if(!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(this.txtBoxClinicRoomHeight))){
            //    return false;
            //}
            //if(!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(this.txtBoxClinicRoomWeight))){
            //    return false;
            //}
            return true;
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            TextBox txtText = (TextBox)sender;
            if (string.IsNullOrEmpty(txtText.Text))
            {
                ErrorProviderHelper.GetInstance.SetError(txtText, "Bạn không nên để trống");
            }
            else
                ErrorProviderHelper.GetInstance.SetError(txtText, "");
        }

        private bool ValidateFormTool()
        {
            if (!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(textBox1)))
            {
                return false;
            }
            if (!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(textBox2)))
            {
                return false;
            }
            if (!string.IsNullOrEmpty(ErrorProviderHelper.GetInstance.GetError(textBoxNameDoctor)))
            {
                return false;
            }

            if (string.IsNullOrEmpty(textBox1.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBox2.Text))
            {
                return false;
            }
            if (string.IsNullOrEmpty(textBoxNameDoctor.Text))
            {
                return false;
            }
            return true;
        }

        private void dataGridViewMedicine_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.ColumnIndex == DatabaseContants.CountColumnInDataGridViewMedicines)
            //{
            //    int count = int.Parse(dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value.ToString());

            //    string nameOfMedicine = dataGridViewMedicine[0, e.RowIndex].Value.ToString();
            //    if (nameOfMedicine[0] != '@')
            //    {
            //        int coutInventory = int.Parse(dataGridViewMedicine[DatabaseContants.StoreColumnInDataGridViewMedicines, e.RowIndex].Value.ToString());
            //        if (count > coutInventory)
            //        {
            //            MessageBox.Show("Lượng thuốc tồn kho không đủ. Xin vui lòng nhập lại", "Thông báo");
            //            dataGridViewMedicine[e.ColumnIndex, e.RowIndex].Value = 0;
            //            count = 0;
            //        }
            //    }
            //    int cost = int.Parse(dataGridViewMedicine[DatabaseContants.CostColumnInDataGridViewMedicines, e.RowIndex].Value.ToString()) * count;
            //    dataGridViewMedicine[DatabaseContants.MoneyColumnInDataGridViewMedicines, e.RowIndex].Value = cost.ToString();
            //}
        }

        private void SetReadOnlyForControl(bool p)
        {
            this.Column19.ReadOnly = p;
            this.txtBoxClinicRoomSymptom.ReadOnly = p;
            this.txtBoxClinicRoomDiagnose.ReadOnly = p;
            //this.textBoxClinicPhone.ReadOnly = p;
            this.ColumnNameAllMedicine.ReadOnly = p;
            this.dataGridViewMedicine.AllowUserToAddRows = !p;
        }

        private void thêmThôngTinHẹnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReasonAppointment form = new ReasonAppointment();
            form.ShowDialog();
        }

        private void LoadReason()
        {
            cbb_Reason.Items.Clear();
            List<ReasonApointmentModel> listReason = db.GetListReason();
            foreach (ReasonApointmentModel item in listReason)
            {
                cbb_Reason.Items.Add(item.Reason);
            }
        }

        private void cácLýDoTáiKhámToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btn_khamlai_Click(object sender, EventArgs e)
        {
            AddListPatientToday();
            MessageBox.Show("Đã thêm vào danh sách khám hôm nay.. Xin vui lòng xem danh sách", "Thông báo");
        }

        private void dataGridViewMedicine_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            ComboBox combo = e.Control as ComboBox;
            if (combo != null)
            {
                combo.SelectedIndexChanged -= new EventHandler(combo_SelectedIndexChanged);
                combo.SelectedIndexChanged += combo_SelectedIndexChanged;
            }
        }

        void combo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.dataGridViewMedicine.SelectedCells.Count > 0)
            {
                string name = string.Empty;
                ComboBox combo = (ComboBox)sender;
                if(combo != null){
                    name = combo.SelectedItem.ToString();
                }
                DataGridViewCell cell = this.dataGridViewMedicine.SelectedCells[0];
                if (cell.ColumnIndex == 0)
                {
                    cell.Value = name;
                }
            }
        }

        private void dataGridViewAccount_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == this.dataGridViewAccount.Columns[this.Columnupdate.Name].Index)
            {
                string query = string.Format("update {0} set {1} = {2} where {3} = {4}", DatabaseContants.tables.clinicuser, DatabaseContants.clinicuser.Namedoctor, Helper.ConvertToSqlString(this.dataGridViewAccount[1, e.RowIndex].Value.ToString()), DatabaseContants.clinicuser.Username, Helper.ConvertToSqlString(this.dataGridViewAccount[0, e.RowIndex].Value.ToString()));
                if(db.ExecuteNonQuery(query, null) > -1)
                    MessageBox.Show(ClinicConstant.SuccessUpdate_Text);
                else
                {
                    MessageBox.Show(ClinicConstant.FailUpdate_Text);
                    LoadAccount();
                }
            }
            else if (e.ColumnIndex == this.dataGridViewAccount.Columns[this.Columndelete.Name].Index)
            {
                string usenameDelete = dataGridViewAccount[0, e.RowIndex].Value.ToString();
                if (UserName == usenameDelete)
                {
                    MessageBox.Show("Bạn không thể xóa tài khoản hiện tại của bạn");
                }
                string query = string.Format("delete from {0} where {1} = {2}", DatabaseContants.tables.clinicuser, DatabaseContants.clinicuser.Username, Helper.ConvertToSqlString(usenameDelete));
                if (db.ExecuteNonQuery(query, null) > -1)
                {
                    MessageBox.Show("Bạn xóa thành công");
                }
                else
                {
                    MessageBox.Show("Bạn xóa thất bại");
                }
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm login = new LoginForm();
            login.ShowDialog();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {

        }

        private void appoinment_Click(object sender, EventArgs e)
        {
            Appointment appoint = new Appointment();
            appoint.Show();
        }
    }
}
