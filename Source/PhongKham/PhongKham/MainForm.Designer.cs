using System.Windows.Forms;
using System.Windows.Forms.Calendar;
using Clinic;
namespace PhongKham
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange1 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange2 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange3 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange4 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.Windows.Forms.Calendar.CalendarHighlightRange calendarHighlightRange5 = new System.Windows.Forms.Calendar.CalendarHighlightRange();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainTab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panelcontent = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBoxPrintPageOptions = new System.Windows.Forms.ComboBox();
            this.cbb_Reason = new System.Windows.Forms.ComboBox();
            this.comboBoxLoaiKham = new System.Windows.Forms.ComboBox();
            this.buttonPutIn = new System.Windows.Forms.Button();
            this.txtBoxClinicRoomDiagnose = new System.Windows.Forms.TextBox();
            this.dataGridViewMedicine = new System.Windows.Forms.DataGridView();
            this.ColumnNameAllMedicine = new DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn();
            this.Column19 = new DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn();
            this.store = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCost = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.ColumnMoneyMedicine = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.dataGridViewMedicinesId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMedicinesHDSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.checkBoxHen = new System.Windows.Forms.CheckBox();
            this.textBoxClinicPhone = new System.Windows.Forms.TextBox();
            this.dateTimePickerHen = new System.Windows.Forms.DateTimePicker();
            this.txtBoxClinicRoomSymptom = new System.Windows.Forms.TextBox();
            this.labelTongTien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.expandableSplitter2 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panelListContent = new System.Windows.Forms.Panel();
            this.circularProgress1 = new DevComponents.DotNetBar.Controls.CircularProgress();
            this.buttonList = new System.Windows.Forms.Button();
            this.dataGridViewSearchValue = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNamePatient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNgayKham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSymtom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnNhietDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnHuyetAp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDiagno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSearchValueMedicines = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CollIDHistory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkBoxShow1Record = new System.Windows.Forms.CheckBox();
            this.checkBoxShowMedicines = new System.Windows.Forms.CheckBox();
            this.checkBoxShowBigForm = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.CoTableLayoutPanel1 = new Clinic.CoTableLayoutPanel();
            this.label28 = new System.Windows.Forms.Label();
            this.lblClinicRoomId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxClinicNhietDo = new System.Windows.Forms.TextBox();
            this.dateTimePickerBirthDay = new System.Windows.Forms.DateTimePicker();
            this.txtBoxClinicRoomAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.comboBoxClinicRoomName = new System.Windows.Forms.TextBox();
            this.buttonClinicCreateNew = new System.Windows.Forms.Button();
            this.buttonClinicClear = new System.Windows.Forms.Button();
            this.txtBoxClinicRoomWeight = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxClinicRoomHeight = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.dateTimePickerNgayKham = new System.Windows.Forms.DateTimePicker();
            this.label30 = new System.Windows.Forms.Label();
            this.textBoxHuyetAp = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.labelTuoi = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_khamlai = new System.Windows.Forms.Button();
            this.Calendar = new System.Windows.Forms.TabPage();
            this.panelCalendarDate = new System.Windows.Forms.Panel();
            this.dataGridViewCalendar = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewButtonColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnReason = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnState = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.expandableSplitter1 = new DevComponents.DotNetBar.ExpandableSplitter();
            this.panelCalendar = new System.Windows.Forms.Panel();
            this.tabPageLich = new System.Windows.Forms.Calendar.MonthView();
            this.calendar1 = new System.Windows.Forms.Calendar.Calendar();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.redTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yellowTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otherColorTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageTools = new System.Windows.Forms.TabPage();
            this.dataGridViewAccount = new System.Windows.Forms.DataGridView();
            this.ColumnUsername = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnnamedoctor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Columnupdate = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Columndelete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.textBoxNameDoctor = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBoxKethuoc = new System.Windows.Forms.CheckBox();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.Column22 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Column23 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Column24 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Column25 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.Column26 = new DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn();
            this.buttonCreateUser = new System.Windows.Forms.Button();
            this.checkBoxNhapThuoc = new System.Windows.Forms.CheckBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.CoTableLayoutPanel6 = new Clinic.CoTableLayoutPanel();
            this.label39 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.textBoxBackupSource = new System.Windows.Forms.TextBox();
            this.textBoxBackupTarget = new System.Windows.Forms.TextBox();
            this.textBoxBackupTimeAuto = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.checkBoxAutoCopy = new System.Windows.Forms.CheckBox();
            this.label38 = new System.Windows.Forms.Label();
            this.CoTableLayoutPanel5 = new Clinic.CoTableLayoutPanel();
            this.textBoxNameClinic = new System.Windows.Forms.TextBox();
            this.textBoxAddressClinic = new System.Windows.Forms.TextBox();
            this.textBoxAdviceClinic = new System.Windows.Forms.TextBox();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.labelSdt = new System.Windows.Forms.Label();
            this.textBoxSDT = new System.Windows.Forms.TextBox();
            this.tabPagePrint = new System.Windows.Forms.TabPage();
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.patternToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diagonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timescaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hourToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.minutesToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageAlignmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.Column7 = new System.Windows.Forms.DataGridViewColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CoTableLayoutPanel2 = new Clinic.CoTableLayoutPanel();
            this.label11 = new System.Windows.Forms.Label();
            this.comboBoxWaitRoomId = new System.Windows.Forms.ComboBox();
            this.txtBoxWaitRoomHeight = new System.Windows.Forms.TextBox();
            this.txtBoxWaitRoomDiagnose = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.lblWaitRoomName = new System.Windows.Forms.Label();
            this.txtBoxWaitRoomName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtBoxWaitingRoomSymptom = new System.Windows.Forms.TextBox();
            this.lblWaitRoomBirthday = new System.Windows.Forms.Label();
            this.txtBoxWaitingRoomWeight = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.lblWaitRoomAddress = new System.Windows.Forms.Label();
            this.txtBoxWaitRoomAddress = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.btnWaitRoomContinue = new System.Windows.Forms.Button();
            this.btnWaitRoomCancel = new System.Windows.Forms.Button();
            this.btnWaitRoomOK = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.programToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doanhThuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mởRộngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolpatientAllCount = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.doanhThuToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tủThuốcToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácDịchVụToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cácChẩnĐoánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appoinment = new System.Windows.Forms.ToolStripMenuItem();
            this.loaiKhamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLoạiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmThôngTinHẹnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.MainTab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panelcontent.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).BeginInit();
            this.panelListContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchValue)).BeginInit();
            this.CoTableLayoutPanel1.SuspendLayout();
            this.Calendar.SuspendLayout();
            this.panelCalendarDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).BeginInit();
            this.panelCalendar.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.tabPageTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.CoTableLayoutPanel6.SuspendLayout();
            this.CoTableLayoutPanel5.SuspendLayout();
            this.tabPagePrint.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.CoTableLayoutPanel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainTab
            // 
            this.MainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainTab.Controls.Add(this.tabPage1);
            this.MainTab.Controls.Add(this.Calendar);
            this.MainTab.Controls.Add(this.tabPageTools);
            this.MainTab.Controls.Add(this.tabPagePrint);
            this.MainTab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainTab.Location = new System.Drawing.Point(0, 27);
            this.MainTab.Name = "MainTab";
            this.MainTab.SelectedIndex = 0;
            this.MainTab.Size = new System.Drawing.Size(1354, 688);
            this.MainTab.TabIndex = 0;
            this.MainTab.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panelcontent);
            this.tabPage1.Controls.Add(this.checkBoxShow1Record);
            this.tabPage1.Controls.Add(this.checkBoxShowMedicines);
            this.tabPage1.Controls.Add(this.checkBoxShowBigForm);
            this.tabPage1.Controls.Add(this.buttonSearch);
            this.tabPage1.Controls.Add(this.CoTableLayoutPanel1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1346, 657);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "";
            this.tabPage1.Text = "Phòng Khám";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panelcontent
            // 
            this.panelcontent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelcontent.Controls.Add(this.panel1);
            this.panelcontent.Controls.Add(this.expandableSplitter2);
            this.panelcontent.Controls.Add(this.panelListContent);
            this.panelcontent.Location = new System.Drawing.Point(3, 204);
            this.panelcontent.Name = "panelcontent";
            this.panelcontent.Size = new System.Drawing.Size(1340, 450);
            this.panelcontent.TabIndex = 55;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 254);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1340, 196);
            this.panel1.TabIndex = 56;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.comboBoxPrintPageOptions);
            this.panel2.Controls.Add(this.cbb_Reason);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBoxLoaiKham);
            this.panel2.Controls.Add(this.buttonPutIn);
            this.panel2.Controls.Add(this.txtBoxClinicRoomDiagnose);
            this.panel2.Controls.Add(this.dataGridViewMedicine);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label44);
            this.panel2.Controls.Add(this.checkBoxHen);
            this.panel2.Controls.Add(this.textBoxClinicPhone);
            this.panel2.Controls.Add(this.dateTimePickerHen);
            this.panel2.Controls.Add(this.txtBoxClinicRoomSymptom);
            this.panel2.Controls.Add(this.labelTongTien);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1340, 196);
            this.panel2.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 18);
            this.label6.TabIndex = 53;
            this.label6.Text = "Triệu chứng:";
            // 
            // comboBoxPrintPageOptions
            // 
            this.comboBoxPrintPageOptions.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxPrintPageOptions.FormattingEnabled = true;
            this.comboBoxPrintPageOptions.Items.AddRange(new object[] {
            "Trang Đầu",
            "Trang Cuối",
            "Tất Cả",
            "Tùy Chỉnh"});
            this.comboBoxPrintPageOptions.Location = new System.Drawing.Point(1085, 148);
            this.comboBoxPrintPageOptions.Name = "comboBoxPrintPageOptions";
            this.comboBoxPrintPageOptions.Size = new System.Drawing.Size(100, 26);
            this.comboBoxPrintPageOptions.TabIndex = 68;
            this.comboBoxPrintPageOptions.Visible = false;
            // 
            // cbb_Reason
            // 
            this.cbb_Reason.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_Reason.FormattingEnabled = true;
            this.cbb_Reason.Location = new System.Drawing.Point(1101, 37);
            this.cbb_Reason.Name = "cbb_Reason";
            this.cbb_Reason.Size = new System.Drawing.Size(228, 26);
            this.cbb_Reason.TabIndex = 71;
            // 
            // comboBoxLoaiKham
            // 
            this.comboBoxLoaiKham.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxLoaiKham.FormattingEnabled = true;
            this.comboBoxLoaiKham.Location = new System.Drawing.Point(691, 6);
            this.comboBoxLoaiKham.Name = "comboBoxLoaiKham";
            this.comboBoxLoaiKham.Size = new System.Drawing.Size(173, 26);
            this.comboBoxLoaiKham.TabIndex = 65;
            // 
            // buttonPutIn
            // 
            this.buttonPutIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPutIn.AutoSize = true;
            this.buttonPutIn.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonPutIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPutIn.Location = new System.Drawing.Point(1199, 98);
            this.buttonPutIn.Name = "buttonPutIn";
            this.buttonPutIn.Size = new System.Drawing.Size(115, 49);
            this.buttonPutIn.TabIndex = 60;
            this.buttonPutIn.Text = " Nhập";
            this.buttonPutIn.UseVisualStyleBackColor = false;
            this.buttonPutIn.Click += new System.EventHandler(this.buttonPutIn_Click);
            // 
            // txtBoxClinicRoomDiagnose
            // 
            this.txtBoxClinicRoomDiagnose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClinicRoomDiagnose.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBoxClinicRoomDiagnose.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBoxClinicRoomDiagnose.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxClinicRoomDiagnose.Location = new System.Drawing.Point(99, 39);
            this.txtBoxClinicRoomDiagnose.Name = "txtBoxClinicRoomDiagnose";
            this.txtBoxClinicRoomDiagnose.Size = new System.Drawing.Size(519, 24);
            this.txtBoxClinicRoomDiagnose.TabIndex = 57;
            // 
            // dataGridViewMedicine
            // 
            this.dataGridViewMedicine.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewMedicine.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridViewMedicine.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dataGridViewMedicine.ColumnHeadersHeight = 40;
            this.dataGridViewMedicine.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnNameAllMedicine,
            this.Column19,
            this.store,
            this.ColumnCost,
            this.ColumnMoneyMedicine,
            this.dataGridViewMedicinesId,
            this.ColumnMedicinesHDSD});
            this.dataGridViewMedicine.GridColor = System.Drawing.SystemColors.MenuHighlight;
            this.dataGridViewMedicine.Location = new System.Drawing.Point(7, 69);
            this.dataGridViewMedicine.Name = "dataGridViewMedicine";
            this.dataGridViewMedicine.Size = new System.Drawing.Size(1068, 105);
            this.dataGridViewMedicine.TabIndex = 59;
            this.dataGridViewMedicine.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicine_CellContentClick);
            this.dataGridViewMedicine.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicine_CellContentClick);
            this.dataGridViewMedicine.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicine_CellLeave);
            this.dataGridViewMedicine.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMedicine_CellValueChanged_1);
            this.dataGridViewMedicine.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridViewMedicine_EditingControlShowing);
            this.dataGridViewMedicine.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridViewMedicine_RowsRemoved);
            this.dataGridViewMedicine.Leave += new System.EventHandler(this.dataGridViewMedicine_Leave);
            this.dataGridViewMedicine.MouseLeave += new System.EventHandler(this.dataGridViewMedicine_MouseLeave);
            // 
            // ColumnNameAllMedicine
            // 
            this.ColumnNameAllMedicine.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.ColumnNameAllMedicine.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.ColumnNameAllMedicine.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColumnNameAllMedicine.DisplayMember = "Text";
            this.ColumnNameAllMedicine.DropDownHeight = 106;
            this.ColumnNameAllMedicine.DropDownWidth = 121;
            this.ColumnNameAllMedicine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ColumnNameAllMedicine.HeaderText = "Tên Thuốc";
            this.ColumnNameAllMedicine.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.ColumnNameAllMedicine.IntegralHeight = false;
            this.ColumnNameAllMedicine.ItemHeight = 15;
            this.ColumnNameAllMedicine.Name = "ColumnNameAllMedicine";
            this.ColumnNameAllMedicine.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnNameAllMedicine.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // Column19
            // 
            this.Column19.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.Column19.BackgroundStyle.Class = "DataGridViewIpAddressBorder";
            this.Column19.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.Column19.FillWeight = 75F;
            this.Column19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Column19.HeaderText = "Số lượng";
            this.Column19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Column19.Name = "Column19";
            this.Column19.PasswordChar = '\0';
            this.Column19.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Column19.Text = "";
            this.Column19.Width = 50;
            // 
            // store
            // 
            this.store.FillWeight = 80F;
            this.store.HeaderText = "Tồn Kho";
            this.store.Name = "store";
            this.store.ReadOnly = true;
            // 
            // ColumnCost
            // 
            this.ColumnCost.FillWeight = 75F;
            this.ColumnCost.HeaderText = "Giá";
            this.ColumnCost.Name = "ColumnCost";
            this.ColumnCost.ReadOnly = true;
            this.ColumnCost.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnCost.Width = 150;
            // 
            // ColumnMoneyMedicine
            // 
            this.ColumnMoneyMedicine.HeaderText = "Tiền";
            this.ColumnMoneyMedicine.Name = "ColumnMoneyMedicine";
            this.ColumnMoneyMedicine.ReadOnly = true;
            this.ColumnMoneyMedicine.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnMoneyMedicine.Width = 150;
            // 
            // dataGridViewMedicinesId
            // 
            this.dataGridViewMedicinesId.HeaderText = "Id";
            this.dataGridViewMedicinesId.Name = "dataGridViewMedicinesId";
            this.dataGridViewMedicinesId.Visible = false;
            // 
            // ColumnMedicinesHDSD
            // 
            this.ColumnMedicinesHDSD.HeaderText = "Cách dùng";
            this.ColumnMedicinesHDSD.Name = "ColumnMedicinesHDSD";
            this.ColumnMedicinesHDSD.Width = 250;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 18);
            this.label7.TabIndex = 54;
            this.label7.Text = "Chẩn đoán:";
            // 
            // label44
            // 
            this.label44.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(644, 43);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(42, 18);
            this.label44.TabIndex = 56;
            this.label44.Text = "SĐT:";
            // 
            // checkBoxHen
            // 
            this.checkBoxHen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxHen.AutoSize = true;
            this.checkBoxHen.Location = new System.Drawing.Point(1194, 7);
            this.checkBoxHen.Name = "checkBoxHen";
            this.checkBoxHen.Size = new System.Drawing.Size(121, 22);
            this.checkBoxHen.TabIndex = 66;
            this.checkBoxHen.Text = "Hẹn Tái Khám";
            this.checkBoxHen.UseVisualStyleBackColor = true;
            this.checkBoxHen.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // textBoxClinicPhone
            // 
            this.textBoxClinicPhone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxClinicPhone.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.textBoxClinicPhone.Location = new System.Drawing.Point(691, 39);
            this.textBoxClinicPhone.Name = "textBoxClinicPhone";
            this.textBoxClinicPhone.Size = new System.Drawing.Size(173, 24);
            this.textBoxClinicPhone.TabIndex = 69;
            // 
            // dateTimePickerHen
            // 
            this.dateTimePickerHen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerHen.Location = new System.Drawing.Point(971, 7);
            this.dateTimePickerHen.Name = "dateTimePickerHen";
            this.dateTimePickerHen.Size = new System.Drawing.Size(200, 24);
            this.dateTimePickerHen.TabIndex = 63;
            // 
            // txtBoxClinicRoomSymptom
            // 
            this.txtBoxClinicRoomSymptom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClinicRoomSymptom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.txtBoxClinicRoomSymptom.Location = new System.Drawing.Point(99, 8);
            this.txtBoxClinicRoomSymptom.Name = "txtBoxClinicRoomSymptom";
            this.txtBoxClinicRoomSymptom.Size = new System.Drawing.Size(519, 24);
            this.txtBoxClinicRoomSymptom.TabIndex = 55;
            // 
            // labelTongTien
            // 
            this.labelTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTongTien.AutoSize = true;
            this.labelTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongTien.Location = new System.Drawing.Point(924, 41);
            this.labelTongTien.Name = "labelTongTien";
            this.labelTongTien.Size = new System.Drawing.Size(20, 24);
            this.labelTongTien.TabIndex = 58;
            this.labelTongTien.Text = "0";
            this.labelTongTien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelTongTien.Click += new System.EventHandler(this.label30_Click);
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(868, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 24);
            this.label9.TabIndex = 61;
            this.label9.Text = "Total:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // expandableSplitter2
            // 
            this.expandableSplitter2.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter2.Dock = System.Windows.Forms.DockStyle.Top;
            this.expandableSplitter2.ExpandableControl = this.panelListContent;
            this.expandableSplitter2.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.ExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(151)))), ((int)(((byte)(61)))));
            this.expandableSplitter2.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(94)))));
            this.expandableSplitter2.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter2.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter2.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotExpandLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.expandableSplitter2.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter2.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(147)))), ((int)(((byte)(207)))));
            this.expandableSplitter2.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter2.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(239)))), ((int)(((byte)(255)))));
            this.expandableSplitter2.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter2.Location = new System.Drawing.Point(0, 246);
            this.expandableSplitter2.Name = "expandableSplitter2";
            this.expandableSplitter2.Size = new System.Drawing.Size(1340, 8);
            this.expandableSplitter2.Style = DevComponents.DotNetBar.eSplitterStyle.Office2007;
            this.expandableSplitter2.TabIndex = 55;
            this.expandableSplitter2.TabStop = false;
            // 
            // panelListContent
            // 
            this.panelListContent.Controls.Add(this.circularProgress1);
            this.panelListContent.Controls.Add(this.buttonList);
            this.panelListContent.Controls.Add(this.dataGridViewSearchValue);
            this.panelListContent.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelListContent.Location = new System.Drawing.Point(0, 0);
            this.panelListContent.Name = "panelListContent";
            this.panelListContent.Size = new System.Drawing.Size(1340, 246);
            this.panelListContent.TabIndex = 54;
            // 
            // circularProgress1
            // 
            this.circularProgress1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.circularProgress1.BackColor = System.Drawing.SystemColors.Window;
            // 
            // 
            // 
            this.circularProgress1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.circularProgress1.FocusCuesEnabled = false;
            this.circularProgress1.Location = new System.Drawing.Point(448, 86);
            this.circularProgress1.Name = "circularProgress1";
            this.circularProgress1.ProgressBarType = DevComponents.DotNetBar.eCircularProgressType.Donut;
            this.circularProgress1.ProgressColor = System.Drawing.SystemColors.ControlDarkDark;
            this.circularProgress1.ProgressTextVisible = true;
            this.circularProgress1.Size = new System.Drawing.Size(301, 70);
            this.circularProgress1.Style = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
            this.circularProgress1.TabIndex = 0;
            // 
            // buttonList
            // 
            this.buttonList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonList.Location = new System.Drawing.Point(3, 4);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(29, 239);
            this.buttonList.TabIndex = 47;
            this.buttonList.Text = "Danh   Sách ";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            this.buttonList.MouseHover += new System.EventHandler(this.buttonList_MouseHover);
            // 
            // dataGridViewSearchValue
            // 
            this.dataGridViewSearchValue.AllowUserToAddRows = false;
            this.dataGridViewSearchValue.AllowUserToDeleteRows = false;
            this.dataGridViewSearchValue.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchValue.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchValue.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewSearchValue.ColumnHeadersHeight = 40;
            this.dataGridViewSearchValue.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnNamePatient,
            this.ColumnNgaySinh,
            this.ColumnNgayKham,
            this.ColumnAddress,
            this.ColumnSymtom,
            this.ColumnNhietDo,
            this.ColumnHuyetAp,
            this.ColumnWeight,
            this.ColumnDiagno,
            this.ColumnSearchValueMedicines,
            this.CollIDHistory});
            this.dataGridViewSearchValue.Location = new System.Drawing.Point(38, 4);
            this.dataGridViewSearchValue.Name = "dataGridViewSearchValue";
            this.dataGridViewSearchValue.ReadOnly = true;
            this.dataGridViewSearchValue.Size = new System.Drawing.Size(1297, 239);
            this.dataGridViewSearchValue.TabIndex = 46;
            this.dataGridViewSearchValue.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSearchValue_CellDoubleClick);
            // 
            // ColumnID
            // 
            this.ColumnID.FillWeight = 5.581299F;
            this.ColumnID.HeaderText = "ID";
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            // 
            // ColumnNamePatient
            // 
            this.ColumnNamePatient.FillWeight = 12.63171F;
            this.ColumnNamePatient.HeaderText = "Tên";
            this.ColumnNamePatient.Name = "ColumnNamePatient";
            this.ColumnNamePatient.ReadOnly = true;
            // 
            // ColumnNgaySinh
            // 
            this.ColumnNgaySinh.FillWeight = 8.930079F;
            this.ColumnNgaySinh.HeaderText = "Ngày Sinh";
            this.ColumnNgaySinh.Name = "ColumnNgaySinh";
            this.ColumnNgaySinh.ReadOnly = true;
            // 
            // ColumnNgayKham
            // 
            this.ColumnNgayKham.FillWeight = 8.930079F;
            this.ColumnNgayKham.HeaderText = "Ngày Khám";
            this.ColumnNgayKham.Name = "ColumnNgayKham";
            this.ColumnNgayKham.ReadOnly = true;
            // 
            // ColumnAddress
            // 
            this.ColumnAddress.FillWeight = 15.62764F;
            this.ColumnAddress.HeaderText = "Địa chỉ";
            this.ColumnAddress.Name = "ColumnAddress";
            this.ColumnAddress.ReadOnly = true;
            // 
            // ColumnSymtom
            // 
            this.ColumnSymtom.FillWeight = 12.63171F;
            this.ColumnSymtom.HeaderText = "Triệu chứng";
            this.ColumnSymtom.Name = "ColumnSymtom";
            this.ColumnSymtom.ReadOnly = true;
            // 
            // ColumnNhietDo
            // 
            this.ColumnNhietDo.FillWeight = 12.63171F;
            this.ColumnNhietDo.HeaderText = "Nhiệt độ";
            this.ColumnNhietDo.Name = "ColumnNhietDo";
            this.ColumnNhietDo.ReadOnly = true;
            // 
            // ColumnHuyetAp
            // 
            this.ColumnHuyetAp.FillWeight = 38.06841F;
            this.ColumnHuyetAp.HeaderText = "Huyết Áp";
            this.ColumnHuyetAp.Name = "ColumnHuyetAp";
            this.ColumnHuyetAp.ReadOnly = true;
            // 
            // ColumnWeight
            // 
            this.ColumnWeight.HeaderText = "Cân nặng";
            this.ColumnWeight.Name = "ColumnWeight";
            this.ColumnWeight.ReadOnly = true;
            // 
            // ColumnDiagno
            // 
            this.ColumnDiagno.FillWeight = 463.9643F;
            this.ColumnDiagno.HeaderText = "Chẩn đoán";
            this.ColumnDiagno.Name = "ColumnDiagno";
            this.ColumnDiagno.ReadOnly = true;
            // 
            // ColumnSearchValueMedicines
            // 
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnSearchValueMedicines.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColumnSearchValueMedicines.FillWeight = 22.3252F;
            this.ColumnSearchValueMedicines.HeaderText = "Thuốc đã dùng";
            this.ColumnSearchValueMedicines.Name = "ColumnSearchValueMedicines";
            this.ColumnSearchValueMedicines.ReadOnly = true;
            // 
            // CollIDHistory
            // 
            this.CollIDHistory.HeaderText = "IDHistory";
            this.CollIDHistory.Name = "CollIDHistory";
            this.CollIDHistory.ReadOnly = true;
            this.CollIDHistory.Visible = false;
            // 
            // checkBoxShow1Record
            // 
            this.checkBoxShow1Record.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShow1Record.AutoSize = true;
            this.checkBoxShow1Record.Checked = true;
            this.checkBoxShow1Record.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShow1Record.Location = new System.Drawing.Point(1190, 67);
            this.checkBoxShow1Record.Name = "checkBoxShow1Record";
            this.checkBoxShow1Record.Size = new System.Drawing.Size(138, 22);
            this.checkBoxShow1Record.TabIndex = 49;
            this.checkBoxShow1Record.Text = "Chỉ 1 Record /bn";
            this.checkBoxShow1Record.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowMedicines
            // 
            this.checkBoxShowMedicines.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowMedicines.AutoSize = true;
            this.checkBoxShowMedicines.Checked = true;
            this.checkBoxShowMedicines.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowMedicines.Location = new System.Drawing.Point(1190, 39);
            this.checkBoxShowMedicines.Name = "checkBoxShowMedicines";
            this.checkBoxShowMedicines.Size = new System.Drawing.Size(103, 22);
            this.checkBoxShowMedicines.TabIndex = 48;
            this.checkBoxShowMedicines.Text = "Hiện Thuốc";
            this.checkBoxShowMedicines.UseVisualStyleBackColor = true;
            // 
            // checkBoxShowBigForm
            // 
            this.checkBoxShowBigForm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxShowBigForm.AutoSize = true;
            this.checkBoxShowBigForm.Checked = true;
            this.checkBoxShowBigForm.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowBigForm.Location = new System.Drawing.Point(1190, 11);
            this.checkBoxShowBigForm.Name = "checkBoxShowBigForm";
            this.checkBoxShowBigForm.Size = new System.Drawing.Size(126, 22);
            this.checkBoxShowBigForm.TabIndex = 47;
            this.checkBoxShowBigForm.Text = "Hiện Form Lớn";
            this.checkBoxShowBigForm.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSearch.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttonSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.Location = new System.Drawing.Point(1201, 108);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(127, 93);
            this.buttonSearch.TabIndex = 34;
            this.buttonSearch.Text = "Tìm";
            this.buttonSearch.UseVisualStyleBackColor = false;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // CoTableLayoutPanel1
            // 
            this.CoTableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CoTableLayoutPanel1.AutoSize = true;
            this.CoTableLayoutPanel1.BackColor = System.Drawing.Color.Gainsboro;
            this.CoTableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.InsetDouble;
            this.CoTableLayoutPanel1.ColumnCount = 6;
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 38.2263F));
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.10731F));
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.48211F));
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 199F));
            this.CoTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.CoTableLayoutPanel1.Controls.Add(this.label28, 0, 0);
            this.CoTableLayoutPanel1.Controls.Add(this.lblClinicRoomId, 1, 0);
            this.CoTableLayoutPanel1.Controls.Add(this.label1, 0, 1);
            this.CoTableLayoutPanel1.Controls.Add(this.label2, 0, 2);
            this.CoTableLayoutPanel1.Controls.Add(this.textBoxClinicNhietDo, 3, 3);
            this.CoTableLayoutPanel1.Controls.Add(this.dateTimePickerBirthDay, 1, 2);
            this.CoTableLayoutPanel1.Controls.Add(this.txtBoxClinicRoomAddress, 1, 3);
            this.CoTableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.CoTableLayoutPanel1.Controls.Add(this.label45, 2, 3);
            this.CoTableLayoutPanel1.Controls.Add(this.comboBoxClinicRoomName, 1, 1);
            this.CoTableLayoutPanel1.Controls.Add(this.buttonClinicCreateNew, 4, 0);
            this.CoTableLayoutPanel1.Controls.Add(this.buttonClinicClear, 4, 1);
            this.CoTableLayoutPanel1.Controls.Add(this.txtBoxClinicRoomWeight, 3, 2);
            this.CoTableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.CoTableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.CoTableLayoutPanel1.Controls.Add(this.txtBoxClinicRoomHeight, 3, 1);
            this.CoTableLayoutPanel1.Controls.Add(this.label31, 2, 0);
            this.CoTableLayoutPanel1.Controls.Add(this.dateTimePickerNgayKham, 3, 0);
            this.CoTableLayoutPanel1.Controls.Add(this.label30, 2, 4);
            this.CoTableLayoutPanel1.Controls.Add(this.textBoxHuyetAp, 3, 4);
            this.CoTableLayoutPanel1.Controls.Add(this.label47, 0, 4);
            this.CoTableLayoutPanel1.Controls.Add(this.labelTuoi, 1, 4);
            this.CoTableLayoutPanel1.Controls.Add(this.button3, 4, 4);
            this.CoTableLayoutPanel1.Controls.Add(this.btn_khamlai, 4, 3);
            this.CoTableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CoTableLayoutPanel1.Location = new System.Drawing.Point(9, 6);
            this.CoTableLayoutPanel1.Name = "CoTableLayoutPanel1";
            this.CoTableLayoutPanel1.RowCount = 5;
            this.CoTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.CoTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CoTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.CoTableLayoutPanel1.Size = new System.Drawing.Size(1168, 198);
            this.CoTableLayoutPanel1.TabIndex = 27;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(6, 3);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(22, 18);
            this.label28.TabIndex = 0;
            this.label28.Text = "ID";
            // 
            // lblClinicRoomId
            // 
            this.lblClinicRoomId.AutoSize = true;
            this.lblClinicRoomId.Location = new System.Drawing.Point(79, 3);
            this.lblClinicRoomId.Name = "lblClinicRoomId";
            this.lblClinicRoomId.Size = new System.Drawing.Size(19, 18);
            this.lblClinicRoomId.TabIndex = 1;
            this.lblClinicRoomId.Text = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ngày Sinh";
            // 
            // textBoxClinicNhietDo
            // 
            this.textBoxClinicNhietDo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxClinicNhietDo.Location = new System.Drawing.Point(358, 122);
            this.textBoxClinicNhietDo.Name = "textBoxClinicNhietDo";
            this.textBoxClinicNhietDo.Size = new System.Drawing.Size(135, 24);
            this.textBoxClinicNhietDo.TabIndex = 22;
            this.textBoxClinicNhietDo.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxClinicRoom_Validating);
            // 
            // dateTimePickerBirthDay
            // 
            this.dateTimePickerBirthDay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerBirthDay.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerBirthDay.Location = new System.Drawing.Point(79, 88);
            this.dateTimePickerBirthDay.Name = "dateTimePickerBirthDay";
            this.dateTimePickerBirthDay.Size = new System.Drawing.Size(183, 24);
            this.dateTimePickerBirthDay.TabIndex = 18;
            this.dateTimePickerBirthDay.ValueChanged += new System.EventHandler(this.dateTimePickerBirthDay_ValueChanged);
            // 
            // txtBoxClinicRoomAddress
            // 
            this.txtBoxClinicRoomAddress.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxClinicRoomAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBoxClinicRoomAddress.Location = new System.Drawing.Point(79, 122);
            this.txtBoxClinicRoomAddress.Name = "txtBoxClinicRoomAddress";
            this.txtBoxClinicRoomAddress.Size = new System.Drawing.Size(183, 24);
            this.txtBoxClinicRoomAddress.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "Địa chỉ";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(271, 119);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(67, 18);
            this.label45.TabIndex = 40;
            this.label45.Text = "Nhiệt độ:";
            // 
            // comboBoxClinicRoomName
            // 
            this.comboBoxClinicRoomName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClinicRoomName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.comboBoxClinicRoomName.Location = new System.Drawing.Point(79, 49);
            this.comboBoxClinicRoomName.Name = "comboBoxClinicRoomName";
            this.comboBoxClinicRoomName.Size = new System.Drawing.Size(183, 24);
            this.comboBoxClinicRoomName.TabIndex = 17;
            this.comboBoxClinicRoomName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBoxClinicRoomName_KeyPress);
            this.comboBoxClinicRoomName.Validating += new System.ComponentModel.CancelEventHandler(this.comboBoxClinicRoomName_Validating);
            // 
            // buttonClinicCreateNew
            // 
            this.buttonClinicCreateNew.Location = new System.Drawing.Point(512, 6);
            this.buttonClinicCreateNew.Name = "buttonClinicCreateNew";
            this.buttonClinicCreateNew.Size = new System.Drawing.Size(175, 26);
            this.buttonClinicCreateNew.TabIndex = 24;
            this.buttonClinicCreateNew.Text = "Thêm mới/Cập nhật";
            this.buttonClinicCreateNew.UseVisualStyleBackColor = true;
            this.buttonClinicCreateNew.Click += new System.EventHandler(this.buttonClinicCreateNew_Click);
            // 
            // buttonClinicClear
            // 
            this.buttonClinicClear.Location = new System.Drawing.Point(512, 49);
            this.buttonClinicClear.Name = "buttonClinicClear";
            this.buttonClinicClear.Size = new System.Drawing.Size(75, 26);
            this.buttonClinicClear.TabIndex = 30;
            this.buttonClinicClear.Text = "Clear";
            this.buttonClinicClear.UseVisualStyleBackColor = true;
            this.buttonClinicClear.Click += new System.EventHandler(this.buttonClinicClear_Click);
            // 
            // txtBoxClinicRoomWeight
            // 
            this.txtBoxClinicRoomWeight.Location = new System.Drawing.Point(358, 88);
            this.txtBoxClinicRoomWeight.Name = "txtBoxClinicRoomWeight";
            this.txtBoxClinicRoomWeight.Size = new System.Drawing.Size(135, 24);
            this.txtBoxClinicRoomWeight.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 18);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nặng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 18);
            this.label4.TabIndex = 3;
            this.label4.Text = "Chiều Cao";
            // 
            // txtBoxClinicRoomHeight
            // 
            this.txtBoxClinicRoomHeight.Location = new System.Drawing.Point(358, 49);
            this.txtBoxClinicRoomHeight.Name = "txtBoxClinicRoomHeight";
            this.txtBoxClinicRoomHeight.Size = new System.Drawing.Size(135, 24);
            this.txtBoxClinicRoomHeight.TabIndex = 20;
            this.txtBoxClinicRoomHeight.Text = "0";
            this.txtBoxClinicRoomHeight.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxClinicRoom_Validating);
            // 
            // label31
            // 
            this.label31.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(271, 3);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(78, 40);
            this.label31.TabIndex = 25;
            this.label31.Text = "Ngày Khám";
            // 
            // dateTimePickerNgayKham
            // 
            this.dateTimePickerNgayKham.CustomFormat = "dd-MM-yyyy";
            this.dateTimePickerNgayKham.Location = new System.Drawing.Point(358, 6);
            this.dateTimePickerNgayKham.Name = "dateTimePickerNgayKham";
            this.dateTimePickerNgayKham.Size = new System.Drawing.Size(145, 24);
            this.dateTimePickerNgayKham.TabIndex = 26;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Location = new System.Drawing.Point(271, 158);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(71, 18);
            this.label30.TabIndex = 41;
            this.label30.Text = "Huyết Áp:";
            // 
            // textBoxHuyetAp
            // 
            this.textBoxHuyetAp.Location = new System.Drawing.Point(358, 161);
            this.textBoxHuyetAp.Name = "textBoxHuyetAp";
            this.textBoxHuyetAp.Size = new System.Drawing.Size(135, 24);
            this.textBoxHuyetAp.TabIndex = 23;
            this.textBoxHuyetAp.Validating += new System.ComponentModel.CancelEventHandler(this.txtBoxClinicRoom_Validating);
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 158);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(41, 18);
            this.label47.TabIndex = 43;
            this.label47.Text = "Tuổi:";
            // 
            // labelTuoi
            // 
            this.labelTuoi.AutoSize = true;
            this.labelTuoi.Location = new System.Drawing.Point(79, 158);
            this.labelTuoi.Name = "labelTuoi";
            this.labelTuoi.Size = new System.Drawing.Size(16, 18);
            this.labelTuoi.TabIndex = 44;
            this.labelTuoi.Text = "0";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(512, 161);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 31);
            this.button3.TabIndex = 45;
            this.button3.Text = "Chỉ Làm mới ID";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btn_khamlai
            // 
            this.btn_khamlai.Location = new System.Drawing.Point(512, 122);
            this.btn_khamlai.Name = "btn_khamlai";
            this.btn_khamlai.Size = new System.Drawing.Size(186, 30);
            this.btn_khamlai.TabIndex = 46;
            this.btn_khamlai.Text = "Khám lại bệnh nhân này";
            this.btn_khamlai.UseVisualStyleBackColor = true;
            this.btn_khamlai.Visible = false;
            this.btn_khamlai.Click += new System.EventHandler(this.btn_khamlai_Click);
            // 
            // Calendar
            // 
            this.Calendar.Controls.Add(this.panelCalendarDate);
            this.Calendar.Controls.Add(this.panelCalendar);
            this.Calendar.Location = new System.Drawing.Point(4, 27);
            this.Calendar.Name = "Calendar";
            this.Calendar.Padding = new System.Windows.Forms.Padding(3);
            this.Calendar.Size = new System.Drawing.Size(1346, 657);
            this.Calendar.TabIndex = 5;
            this.Calendar.Text = "Lịch";
            this.Calendar.UseVisualStyleBackColor = true;
            // 
            // panelCalendarDate
            // 
            this.panelCalendarDate.BackColor = System.Drawing.Color.LightBlue;
            this.panelCalendarDate.Controls.Add(this.dataGridViewCalendar);
            this.panelCalendarDate.Controls.Add(this.expandableSplitter1);
            this.panelCalendarDate.Controls.Add(this.calendar1);
            this.panelCalendarDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelCalendarDate.Location = new System.Drawing.Point(213, 3);
            this.panelCalendarDate.Name = "panelCalendarDate";
            this.panelCalendarDate.Size = new System.Drawing.Size(1130, 651);
            this.panelCalendarDate.TabIndex = 1;
            // 
            // dataGridViewCalendar
            // 
            this.dataGridViewCalendar.AllowUserToAddRows = false;
            this.dataGridViewCalendar.AllowUserToDeleteRows = false;
            this.dataGridViewCalendar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCalendar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Patient,
            this.phone,
            this.sick,
            this.dataGridViewButtonColumn1,
            this.ColumnReason,
            this.ColumnState});
            this.dataGridViewCalendar.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridViewCalendar.Location = new System.Drawing.Point(177, 0);
            this.dataGridViewCalendar.Name = "dataGridViewCalendar";
            this.dataGridViewCalendar.Size = new System.Drawing.Size(953, 651);
            this.dataGridViewCalendar.TabIndex = 3;
            this.dataGridViewCalendar.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCalendar_CellClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // Patient
            // 
            this.Patient.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Patient.HeaderText = "Họ và Tên";
            this.Patient.Name = "Patient";
            this.Patient.ReadOnly = true;
            // 
            // phone
            // 
            this.phone.HeaderText = "SĐT";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.Width = 80;
            // 
            // sick
            // 
            this.sick.HeaderText = "Bệnh";
            this.sick.Name = "sick";
            this.sick.ReadOnly = true;
            // 
            // dataGridViewButtonColumn1
            // 
            this.dataGridViewButtonColumn1.HeaderText = "Bác sĩ khám";
            this.dataGridViewButtonColumn1.Name = "dataGridViewButtonColumn1";
            this.dataGridViewButtonColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewButtonColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewButtonColumn1.Width = 150;
            // 
            // ColumnReason
            // 
            this.ColumnReason.HeaderText = "Lý do tái khám";
            this.ColumnReason.Name = "ColumnReason";
            this.ColumnReason.Width = 200;
            // 
            // ColumnState
            // 
            this.ColumnState.HeaderText = "Trạng Thái";
            this.ColumnState.Name = "ColumnState";
            this.ColumnState.ReadOnly = true;
            this.ColumnState.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnState.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // expandableSplitter1
            // 
            this.expandableSplitter1.BackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.expandableSplitter1.ExpandableControl = this.panelCalendar;
            this.expandableSplitter1.ExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.ExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.ExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.ExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripDarkColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.GripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.GripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.expandableSplitter1.GripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.HotBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(142)))), ((int)(((byte)(75)))));
            this.expandableSplitter1.HotBackColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(139)))));
            this.expandableSplitter1.HotBackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground2;
            this.expandableSplitter1.HotBackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemPressedBackground;
            this.expandableSplitter1.HotExpandFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.HotExpandFillColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotExpandLineColor = System.Drawing.SystemColors.ControlText;
            this.expandableSplitter1.HotExpandLineColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
            this.expandableSplitter1.HotGripDarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(45)))), ((int)(((byte)(150)))));
            this.expandableSplitter1.HotGripDarkColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.expandableSplitter1.HotGripLightColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
            this.expandableSplitter1.HotGripLightColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.expandableSplitter1.Location = new System.Drawing.Point(0, 0);
            this.expandableSplitter1.Name = "expandableSplitter1";
            this.expandableSplitter1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.expandableSplitter1.Size = new System.Drawing.Size(3, 651);
            this.expandableSplitter1.TabIndex = 0;
            this.expandableSplitter1.TabStop = false;
            // 
            // panelCalendar
            // 
            this.panelCalendar.BackColor = System.Drawing.Color.Gainsboro;
            this.panelCalendar.Controls.Add(this.tabPageLich);
            this.panelCalendar.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelCalendar.Location = new System.Drawing.Point(3, 3);
            this.panelCalendar.Name = "panelCalendar";
            this.panelCalendar.Size = new System.Drawing.Size(210, 651);
            this.panelCalendar.TabIndex = 0;
            // 
            // tabPageLich
            // 
            this.tabPageLich.ArrowsColor = System.Drawing.SystemColors.Window;
            this.tabPageLich.ArrowsSelectedColor = System.Drawing.Color.Gold;
            this.tabPageLich.DayBackgroundColor = System.Drawing.Color.Empty;
            this.tabPageLich.DayGrayedText = System.Drawing.SystemColors.GrayText;
            this.tabPageLich.DaySelectedBackgroundColor = System.Drawing.SystemColors.Highlight;
            this.tabPageLich.DaySelectedColor = System.Drawing.SystemColors.WindowText;
            this.tabPageLich.DaySelectedTextColor = System.Drawing.SystemColors.HighlightText;
            this.tabPageLich.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabPageLich.ItemPadding = new System.Windows.Forms.Padding(2);
            this.tabPageLich.Location = new System.Drawing.Point(0, 0);
            this.tabPageLich.MaxSelectionCount = 35;
            this.tabPageLich.MonthTitleColor = System.Drawing.SystemColors.ActiveCaption;
            this.tabPageLich.MonthTitleColorInactive = System.Drawing.SystemColors.InactiveCaption;
            this.tabPageLich.MonthTitleTextColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tabPageLich.MonthTitleTextColorInactive = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabPageLich.Name = "tabPageLich";
            this.tabPageLich.Size = new System.Drawing.Size(208, 651);
            this.tabPageLich.TabIndex = 3;
            this.tabPageLich.Text = "monthView1";
            this.tabPageLich.TodayBorderColor = System.Drawing.Color.Maroon;
            this.tabPageLich.SelectionChanged += new System.EventHandler(this.monthView1_SelectionChanged);
            // 
            // calendar1
            // 
            this.calendar1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendar1.ContextMenuStrip = this.contextMenuStrip1;
            this.calendar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            calendarHighlightRange1.DayOfWeek = System.DayOfWeek.Monday;
            calendarHighlightRange1.EndTime = System.TimeSpan.Parse("19:00:00");
            calendarHighlightRange1.StartTime = System.TimeSpan.Parse("07:00:00");
            calendarHighlightRange2.DayOfWeek = System.DayOfWeek.Tuesday;
            calendarHighlightRange2.EndTime = System.TimeSpan.Parse("19:00:00");
            calendarHighlightRange2.StartTime = System.TimeSpan.Parse("07:00:00");
            calendarHighlightRange3.DayOfWeek = System.DayOfWeek.Wednesday;
            calendarHighlightRange3.EndTime = System.TimeSpan.Parse("19:00:00");
            calendarHighlightRange3.StartTime = System.TimeSpan.Parse("07:00:00");
            calendarHighlightRange4.DayOfWeek = System.DayOfWeek.Thursday;
            calendarHighlightRange4.EndTime = System.TimeSpan.Parse("19:00:00");
            calendarHighlightRange4.StartTime = System.TimeSpan.Parse("07:00:00");
            calendarHighlightRange5.DayOfWeek = System.DayOfWeek.Friday;
            calendarHighlightRange5.EndTime = System.TimeSpan.Parse("19:00:00");
            calendarHighlightRange5.StartTime = System.TimeSpan.Parse("07:00:00");
            this.calendar1.HighlightRanges = new System.Windows.Forms.Calendar.CalendarHighlightRange[] {
        calendarHighlightRange1,
        calendarHighlightRange2,
        calendarHighlightRange3,
        calendarHighlightRange4,
        calendarHighlightRange5};
            this.calendar1.Location = new System.Drawing.Point(0, 0);
            this.calendar1.Name = "calendar1";
            this.calendar1.Size = new System.Drawing.Size(184, 632);
            this.calendar1.TabIndex = 2;
            this.calendar1.Text = "calendar1";
            this.calendar1.LoadItems += new System.Windows.Forms.Calendar.Calendar.CalendarLoadEventHandler(this.calendar1_LoadItems);
            this.calendar1.DayHeaderClick += new System.Windows.Forms.Calendar.Calendar.CalendarDayEventHandler(this.calendar1_DayHeaderClick);
            this.calendar1.ItemCreated += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemCreated);
            this.calendar1.ItemDeleted += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDeleted);
            this.calendar1.ItemTextEdited += new System.Windows.Forms.Calendar.Calendar.CalendarItemCancelEventHandler(this.calendar1_ItemTextEdited);
            this.calendar1.ItemDatesChanged += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDatesChanged);
            this.calendar1.ItemClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemClick);
            this.calendar1.ItemDoubleClick += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemDoubleClick);
            this.calendar1.ItemMouseHover += new System.Windows.Forms.Calendar.Calendar.CalendarItemEventHandler(this.calendar1_ItemMouseHover);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redTagToolStripMenuItem,
            this.yellowTagToolStripMenuItem,
            this.greenTagToolStripMenuItem,
            this.blueTagToolStripMenuItem,
            this.otherColorTagToolStripMenuItem,
            this.editItemToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(164, 136);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // redTagToolStripMenuItem
            // 
            this.redTagToolStripMenuItem.Name = "redTagToolStripMenuItem";
            this.redTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.redTagToolStripMenuItem.Text = "Red tag";
            this.redTagToolStripMenuItem.Click += new System.EventHandler(this.redTagToolStripMenuItem_Click);
            // 
            // yellowTagToolStripMenuItem
            // 
            this.yellowTagToolStripMenuItem.Name = "yellowTagToolStripMenuItem";
            this.yellowTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.yellowTagToolStripMenuItem.Text = "Yellow tag";
            this.yellowTagToolStripMenuItem.Click += new System.EventHandler(this.yellowTagToolStripMenuItem_Click);
            // 
            // greenTagToolStripMenuItem
            // 
            this.greenTagToolStripMenuItem.Name = "greenTagToolStripMenuItem";
            this.greenTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.greenTagToolStripMenuItem.Text = "Green tag";
            this.greenTagToolStripMenuItem.Click += new System.EventHandler(this.greenTagToolStripMenuItem_Click);
            // 
            // blueTagToolStripMenuItem
            // 
            this.blueTagToolStripMenuItem.Name = "blueTagToolStripMenuItem";
            this.blueTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.blueTagToolStripMenuItem.Text = "Blue tag";
            this.blueTagToolStripMenuItem.Click += new System.EventHandler(this.blueTagToolStripMenuItem_Click);
            // 
            // otherColorTagToolStripMenuItem
            // 
            this.otherColorTagToolStripMenuItem.Name = "otherColorTagToolStripMenuItem";
            this.otherColorTagToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.otherColorTagToolStripMenuItem.Text = "Other color tag...";
            this.otherColorTagToolStripMenuItem.Click += new System.EventHandler(this.otherColorTagToolStripMenuItem_Click);
            // 
            // editItemToolStripMenuItem
            // 
            this.editItemToolStripMenuItem.Name = "editItemToolStripMenuItem";
            this.editItemToolStripMenuItem.Size = new System.Drawing.Size(163, 22);
            this.editItemToolStripMenuItem.Text = "Edit item\'s text";
            this.editItemToolStripMenuItem.Click += new System.EventHandler(this.editItemToolStripMenuItem_Click);
            // 
            // tabPageTools
            // 
            this.tabPageTools.Controls.Add(this.dataGridViewAccount);
            this.tabPageTools.Controls.Add(this.textBoxNameDoctor);
            this.tabPageTools.Controls.Add(this.label46);
            this.tabPageTools.Controls.Add(this.button1);
            this.tabPageTools.Controls.Add(this.checkBoxKethuoc);
            this.tabPageTools.Controls.Add(this.dataGridView4);
            this.tabPageTools.Controls.Add(this.buttonCreateUser);
            this.tabPageTools.Controls.Add(this.checkBoxNhapThuoc);
            this.tabPageTools.Controls.Add(this.label29);
            this.tabPageTools.Controls.Add(this.label10);
            this.tabPageTools.Controls.Add(this.textBox2);
            this.tabPageTools.Controls.Add(this.textBox1);
            this.tabPageTools.Controls.Add(this.CoTableLayoutPanel6);
            this.tabPageTools.Controls.Add(this.CoTableLayoutPanel5);
            this.tabPageTools.Location = new System.Drawing.Point(4, 27);
            this.tabPageTools.Name = "tabPageTools";
            this.tabPageTools.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTools.Size = new System.Drawing.Size(1346, 657);
            this.tabPageTools.TabIndex = 3;
            this.tabPageTools.Text = "Tools";
            this.tabPageTools.UseVisualStyleBackColor = true;
            // 
            // dataGridViewAccount
            // 
            this.dataGridViewAccount.AllowUserToAddRows = false;
            this.dataGridViewAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnUsername,
            this.Columnnamedoctor,
            this.Columnupdate,
            this.Columndelete});
            this.dataGridViewAccount.Location = new System.Drawing.Point(5, 180);
            this.dataGridViewAccount.Name = "dataGridViewAccount";
            this.dataGridViewAccount.Size = new System.Drawing.Size(571, 150);
            this.dataGridViewAccount.TabIndex = 35;
            this.dataGridViewAccount.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAccount_CellClick);
            // 
            // ColumnUsername
            // 
            this.ColumnUsername.HeaderText = "User name";
            this.ColumnUsername.Name = "ColumnUsername";
            this.ColumnUsername.ReadOnly = true;
            this.ColumnUsername.Width = 150;
            // 
            // Columnnamedoctor
            // 
            this.Columnnamedoctor.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Columnnamedoctor.HeaderText = "Tên bác sĩ";
            this.Columnnamedoctor.Name = "Columnnamedoctor";
            // 
            // Columnupdate
            // 
            this.Columnupdate.HeaderText = "Cập nhật";
            this.Columnupdate.Name = "Columnupdate";
            // 
            // Columndelete
            // 
            this.Columndelete.HeaderText = "Xóa";
            this.Columndelete.Name = "Columndelete";
            // 
            // textBoxNameDoctor
            // 
            this.textBoxNameDoctor.Location = new System.Drawing.Point(115, 117);
            this.textBoxNameDoctor.Name = "textBoxNameDoctor";
            this.textBoxNameDoctor.Size = new System.Drawing.Size(158, 24);
            this.textBoxNameDoctor.TabIndex = 34;
            this.textBoxNameDoctor.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(24, 117);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(75, 18);
            this.label46.TabIndex = 33;
            this.label46.Text = "Họ và tên:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(789, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 31;
            this.button1.Text = "Thay đổi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxKethuoc
            // 
            this.checkBoxKethuoc.AutoSize = true;
            this.checkBoxKethuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBoxKethuoc.Location = new System.Drawing.Point(292, 58);
            this.checkBoxKethuoc.Name = "checkBoxKethuoc";
            this.checkBoxKethuoc.Size = new System.Drawing.Size(138, 22);
            this.checkBoxKethuoc.TabIndex = 28;
            this.checkBoxKethuoc.Text = "Quyền Kê Thuốc";
            this.checkBoxKethuoc.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column22,
            this.Column23,
            this.Column24,
            this.Column25,
            this.Column26});
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView4.Location = new System.Drawing.Point(3, 489);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(1340, 165);
            this.dataGridView4.TabIndex = 27;
            // 
            // Column22
            // 
            this.Column22.HeaderText = "ID";
            this.Column22.Name = "Column22";
            // 
            // Column23
            // 
            this.Column23.HeaderText = "Tên Thuốc";
            this.Column23.Name = "Column23";
            // 
            // Column24
            // 
            this.Column24.HeaderText = "Giá In";
            this.Column24.Name = "Column24";
            // 
            // Column25
            // 
            this.Column25.HeaderText = "Giá Out";
            this.Column25.Name = "Column25";
            // 
            // Column26
            // 
            this.Column26.HeaderText = "Số Lượng";
            this.Column26.Name = "Column26";
            this.Column26.SingleLineColor = System.Drawing.Color.Red;
            // 
            // buttonCreateUser
            // 
            this.buttonCreateUser.Location = new System.Drawing.Point(24, 147);
            this.buttonCreateUser.Name = "buttonCreateUser";
            this.buttonCreateUser.Size = new System.Drawing.Size(75, 27);
            this.buttonCreateUser.TabIndex = 6;
            this.buttonCreateUser.Text = "OK";
            this.buttonCreateUser.UseVisualStyleBackColor = true;
            this.buttonCreateUser.Click += new System.EventHandler(this.button3_Click);
            // 
            // checkBoxNhapThuoc
            // 
            this.checkBoxNhapThuoc.AutoSize = true;
            this.checkBoxNhapThuoc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.checkBoxNhapThuoc.Location = new System.Drawing.Point(292, 89);
            this.checkBoxNhapThuoc.Name = "checkBoxNhapThuoc";
            this.checkBoxNhapThuoc.Size = new System.Drawing.Size(155, 22);
            this.checkBoxNhapThuoc.TabIndex = 4;
            this.checkBoxNhapThuoc.Text = "Quyền Nhập Thuốc";
            this.checkBoxNhapThuoc.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(21, 78);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(83, 18);
            this.label29.TabIndex = 3;
            this.label29.Text = "Password :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(21, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 18);
            this.label10.TabIndex = 2;
            this.label10.Text = "UserName :";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(130, 24);
            this.textBox2.TabIndex = 1;
            this.textBox2.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(115, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(130, 24);
            this.textBox1.TabIndex = 0;
            this.textBox1.Validated += new System.EventHandler(this.textBox1_Validated);
            // 
            // CoTableLayoutPanel6
            // 
            this.CoTableLayoutPanel6.BackColor = System.Drawing.Color.DarkGray;
            this.CoTableLayoutPanel6.ColumnCount = 3;
            this.CoTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.20567F));
            this.CoTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.79433F));
            this.CoTableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 406F));
            this.CoTableLayoutPanel6.Controls.Add(this.label39, 0, 1);
            this.CoTableLayoutPanel6.Controls.Add(this.label40, 0, 2);
            this.CoTableLayoutPanel6.Controls.Add(this.textBoxBackupSource, 1, 0);
            this.CoTableLayoutPanel6.Controls.Add(this.textBoxBackupTarget, 1, 1);
            this.CoTableLayoutPanel6.Controls.Add(this.textBoxBackupTimeAuto, 1, 2);
            this.CoTableLayoutPanel6.Controls.Add(this.button2, 2, 0);
            this.CoTableLayoutPanel6.Controls.Add(this.button4, 2, 1);
            this.CoTableLayoutPanel6.Controls.Add(this.checkBoxAutoCopy, 2, 2);
            this.CoTableLayoutPanel6.Controls.Add(this.label38, 0, 0);
            this.CoTableLayoutPanel6.Location = new System.Drawing.Point(24, 351);
            this.CoTableLayoutPanel6.Name = "CoTableLayoutPanel6";
            this.CoTableLayoutPanel6.RowCount = 3;
            this.CoTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.CoTableLayoutPanel6.Size = new System.Drawing.Size(552, 124);
            this.CoTableLayoutPanel6.TabIndex = 32;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(3, 44);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(37, 44);
            this.label39.TabIndex = 1;
            this.label39.Text = "Thư mục backup:";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(3, 88);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(37, 36);
            this.label40.TabIndex = 2;
            this.label40.Text = "Thời gian(phút):";
            // 
            // textBoxBackupSource
            // 
            this.textBoxBackupSource.Location = new System.Drawing.Point(48, 3);
            this.textBoxBackupSource.Name = "textBoxBackupSource";
            this.textBoxBackupSource.Size = new System.Drawing.Size(94, 24);
            this.textBoxBackupSource.TabIndex = 3;
            // 
            // textBoxBackupTarget
            // 
            this.textBoxBackupTarget.Location = new System.Drawing.Point(48, 47);
            this.textBoxBackupTarget.Name = "textBoxBackupTarget";
            this.textBoxBackupTarget.Size = new System.Drawing.Size(94, 24);
            this.textBoxBackupTarget.TabIndex = 4;
            // 
            // textBoxBackupTimeAuto
            // 
            this.textBoxBackupTimeAuto.Location = new System.Drawing.Point(48, 91);
            this.textBoxBackupTimeAuto.Name = "textBoxBackupTimeAuto";
            this.textBoxBackupTimeAuto.Size = new System.Drawing.Size(94, 24);
            this.textBoxBackupTimeAuto.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(148, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "Duyệt";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(148, 47);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 38);
            this.button4.TabIndex = 7;
            this.button4.Text = "Duyệt";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // checkBoxAutoCopy
            // 
            this.checkBoxAutoCopy.AutoSize = true;
            this.checkBoxAutoCopy.Location = new System.Drawing.Point(148, 91);
            this.checkBoxAutoCopy.Name = "checkBoxAutoCopy";
            this.checkBoxAutoCopy.Size = new System.Drawing.Size(93, 22);
            this.checkBoxAutoCopy.TabIndex = 8;
            this.checkBoxAutoCopy.Text = "Auto copy";
            this.checkBoxAutoCopy.UseVisualStyleBackColor = true;
            this.checkBoxAutoCopy.CheckedChanged += new System.EventHandler(this.checkBoxAutoCopy_CheckedChanged);
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(3, 0);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(37, 44);
            this.label38.TabIndex = 0;
            this.label38.Text = "Thư mục data:";
            // 
            // CoTableLayoutPanel5
            // 
            this.CoTableLayoutPanel5.BackColor = System.Drawing.Color.DarkGray;
            this.CoTableLayoutPanel5.ColumnCount = 2;
            this.CoTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.95951F));
            this.CoTableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.04049F));
            this.CoTableLayoutPanel5.Controls.Add(this.textBoxNameClinic, 1, 0);
            this.CoTableLayoutPanel5.Controls.Add(this.textBoxAddressClinic, 1, 1);
            this.CoTableLayoutPanel5.Controls.Add(this.textBoxAdviceClinic, 1, 2);
            this.CoTableLayoutPanel5.Controls.Add(this.label37, 0, 2);
            this.CoTableLayoutPanel5.Controls.Add(this.label36, 0, 1);
            this.CoTableLayoutPanel5.Controls.Add(this.label35, 0, 0);
            this.CoTableLayoutPanel5.Controls.Add(this.labelSdt, 0, 3);
            this.CoTableLayoutPanel5.Controls.Add(this.textBoxSDT, 1, 3);
            this.CoTableLayoutPanel5.Location = new System.Drawing.Point(783, 13);
            this.CoTableLayoutPanel5.Name = "CoTableLayoutPanel5";
            this.CoTableLayoutPanel5.RowCount = 4;
            this.CoTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.CoTableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.CoTableLayoutPanel5.Size = new System.Drawing.Size(494, 144);
            this.CoTableLayoutPanel5.TabIndex = 30;
            // 
            // textBoxNameClinic
            // 
            this.textBoxNameClinic.Location = new System.Drawing.Point(150, 3);
            this.textBoxNameClinic.Name = "textBoxNameClinic";
            this.textBoxNameClinic.Size = new System.Drawing.Size(287, 24);
            this.textBoxNameClinic.TabIndex = 2;
            // 
            // textBoxAddressClinic
            // 
            this.textBoxAddressClinic.Location = new System.Drawing.Point(150, 46);
            this.textBoxAddressClinic.Name = "textBoxAddressClinic";
            this.textBoxAddressClinic.Size = new System.Drawing.Size(290, 24);
            this.textBoxAddressClinic.TabIndex = 3;
            // 
            // textBoxAdviceClinic
            // 
            this.textBoxAdviceClinic.Location = new System.Drawing.Point(150, 89);
            this.textBoxAdviceClinic.Name = "textBoxAdviceClinic";
            this.textBoxAdviceClinic.Size = new System.Drawing.Size(290, 24);
            this.textBoxAdviceClinic.TabIndex = 5;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(3, 86);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(56, 18);
            this.label37.TabIndex = 4;
            this.label37.Text = "Lời dặn";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(3, 43);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(53, 18);
            this.label36.TabIndex = 1;
            this.label36.Text = "Địa chỉ";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(3, 0);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(119, 18);
            this.label35.TabIndex = 0;
            this.label35.Text = "Tên phòng khám";
            // 
            // labelSdt
            // 
            this.labelSdt.AutoSize = true;
            this.labelSdt.Location = new System.Drawing.Point(3, 117);
            this.labelSdt.Name = "labelSdt";
            this.labelSdt.Size = new System.Drawing.Size(42, 18);
            this.labelSdt.TabIndex = 6;
            this.labelSdt.Text = "SĐT:";
            // 
            // textBoxSDT
            // 
            this.textBoxSDT.Location = new System.Drawing.Point(150, 120);
            this.textBoxSDT.Name = "textBoxSDT";
            this.textBoxSDT.Size = new System.Drawing.Size(287, 24);
            this.textBoxSDT.TabIndex = 7;
            // 
            // tabPagePrint
            // 
            this.tabPagePrint.Controls.Add(this.axAcroPDF1);
            this.tabPagePrint.Location = new System.Drawing.Point(4, 27);
            this.tabPagePrint.Name = "tabPagePrint";
            this.tabPagePrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrint.Size = new System.Drawing.Size(1346, 657);
            this.tabPagePrint.TabIndex = 4;
            this.tabPagePrint.Text = "Print";
            this.tabPagePrint.UseVisualStyleBackColor = true;
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(3, 3);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(1340, 651);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(64, 6);
            // 
            // patternToolStripMenuItem
            // 
            this.patternToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diagonalToolStripMenuItem,
            this.verticalToolStripMenuItem,
            this.horizontalToolStripMenuItem,
            this.hatchToolStripMenuItem,
            this.toolStripMenuItem3,
            this.noneToolStripMenuItem});
            this.patternToolStripMenuItem.Name = "patternToolStripMenuItem";
            this.patternToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.patternToolStripMenuItem.Text = "Pattern";
            // 
            // diagonalToolStripMenuItem
            // 
            this.diagonalToolStripMenuItem.Name = "diagonalToolStripMenuItem";
            this.diagonalToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // horizontalToolStripMenuItem
            // 
            this.horizontalToolStripMenuItem.Name = "horizontalToolStripMenuItem";
            this.horizontalToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // hatchToolStripMenuItem
            // 
            this.hatchToolStripMenuItem.Name = "hatchToolStripMenuItem";
            this.hatchToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(64, 6);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // timescaleToolStripMenuItem
            // 
            this.timescaleToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hourToolStripMenuItem,
            this.minutesToolStripMenuItem,
            this.toolStripMenuItem4,
            this.minutesToolStripMenuItem1,
            this.minutesToolStripMenuItem2,
            this.minutesToolStripMenuItem3});
            this.timescaleToolStripMenuItem.Name = "timescaleToolStripMenuItem";
            this.timescaleToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.timescaleToolStripMenuItem.Text = "Timescale";
            // 
            // hourToolStripMenuItem
            // 
            this.hourToolStripMenuItem.Name = "hourToolStripMenuItem";
            this.hourToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // minutesToolStripMenuItem
            // 
            this.minutesToolStripMenuItem.Name = "minutesToolStripMenuItem";
            this.minutesToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(67, 22);
            // 
            // minutesToolStripMenuItem1
            // 
            this.minutesToolStripMenuItem1.Name = "minutesToolStripMenuItem1";
            this.minutesToolStripMenuItem1.Size = new System.Drawing.Size(67, 22);
            // 
            // minutesToolStripMenuItem2
            // 
            this.minutesToolStripMenuItem2.Name = "minutesToolStripMenuItem2";
            this.minutesToolStripMenuItem2.Size = new System.Drawing.Size(67, 22);
            // 
            // minutesToolStripMenuItem3
            // 
            this.minutesToolStripMenuItem3.Name = "minutesToolStripMenuItem3";
            this.minutesToolStripMenuItem3.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(64, 6);
            // 
            // selectImageToolStripMenuItem
            // 
            this.selectImageToolStripMenuItem.Name = "selectImageToolStripMenuItem";
            this.selectImageToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // imageAlignmentToolStripMenuItem
            // 
            this.imageAlignmentToolStripMenuItem.Name = "imageAlignmentToolStripMenuItem";
            this.imageAlignmentToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(64, 6);
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Tên Thuốc";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Số lượng";
            this.Column8.Name = "Column8";
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Giá";
            this.Column9.Name = "Column9";
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Tiền";
            this.Column10.Name = "Column10";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.CoTableLayoutPanel2);
            this.tabPage2.Controls.Add(this.btnWaitRoomContinue);
            this.tabPage2.Controls.Add(this.btnWaitRoomCancel);
            this.tabPage2.Controls.Add(this.btnWaitRoomOK);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(833, 484);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Phòng đợi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(3, 250);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ShowCellErrors = false;
            this.dataGridView1.ShowCellToolTips = false;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.ShowRowErrors = false;
            this.dataGridView1.Size = new System.Drawing.Size(778, 164);
            this.dataGridView1.TabIndex = 21;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Ngày Sinh";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Địa chỉ";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Triệu chứng";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Chẩn đoán";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Số thứ tự";
            this.Column6.Name = "Column6";
            // 
            // CoTableLayoutPanel2
            // 
            this.CoTableLayoutPanel2.BackColor = System.Drawing.Color.Gainsboro;
            this.CoTableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.OutsetDouble;
            this.CoTableLayoutPanel2.ColumnCount = 4;
            this.CoTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.01303F));
            this.CoTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.98697F));
            this.CoTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 105F));
            this.CoTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 378F));
            this.CoTableLayoutPanel2.Controls.Add(this.label11, 0, 0);
            this.CoTableLayoutPanel2.Controls.Add(this.comboBoxWaitRoomId, 1, 0);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitRoomHeight, 3, 0);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitRoomDiagnose, 3, 3);
            this.CoTableLayoutPanel2.Controls.Add(this.label17, 2, 3);
            this.CoTableLayoutPanel2.Controls.Add(this.lblWaitRoomName, 0, 1);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitRoomName, 1, 1);
            this.CoTableLayoutPanel2.Controls.Add(this.label16, 2, 2);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitingRoomSymptom, 3, 2);
            this.CoTableLayoutPanel2.Controls.Add(this.lblWaitRoomBirthday, 0, 2);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitingRoomWeight, 3, 1);
            this.CoTableLayoutPanel2.Controls.Add(this.dateTimePicker2, 1, 2);
            this.CoTableLayoutPanel2.Controls.Add(this.label15, 2, 1);
            this.CoTableLayoutPanel2.Controls.Add(this.lblWaitRoomAddress, 0, 3);
            this.CoTableLayoutPanel2.Controls.Add(this.txtBoxWaitRoomAddress, 1, 3);
            this.CoTableLayoutPanel2.Controls.Add(this.label14, 2, 0);
            this.CoTableLayoutPanel2.Location = new System.Drawing.Point(9, 12);
            this.CoTableLayoutPanel2.Name = "CoTableLayoutPanel2";
            this.CoTableLayoutPanel2.RowCount = 4;
            this.CoTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.CoTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.CoTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.CoTableLayoutPanel2.Size = new System.Drawing.Size(778, 144);
            this.CoTableLayoutPanel2.TabIndex = 20;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(16, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Id";
            // 
            // comboBoxWaitRoomId
            // 
            this.comboBoxWaitRoomId.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.comboBoxWaitRoomId.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxWaitRoomId.FormattingEnabled = true;
            this.comboBoxWaitRoomId.Location = new System.Drawing.Point(87, 6);
            this.comboBoxWaitRoomId.Name = "comboBoxWaitRoomId";
            this.comboBoxWaitRoomId.Size = new System.Drawing.Size(98, 21);
            this.comboBoxWaitRoomId.TabIndex = 0;
            // 
            // txtBoxWaitRoomHeight
            // 
            this.txtBoxWaitRoomHeight.Location = new System.Drawing.Point(399, 6);
            this.txtBoxWaitRoomHeight.Name = "txtBoxWaitRoomHeight";
            this.txtBoxWaitRoomHeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWaitRoomHeight.TabIndex = 4;
            // 
            // txtBoxWaitRoomDiagnose
            // 
            this.txtBoxWaitRoomDiagnose.Location = new System.Drawing.Point(399, 110);
            this.txtBoxWaitRoomDiagnose.Name = "txtBoxWaitRoomDiagnose";
            this.txtBoxWaitRoomDiagnose.Size = new System.Drawing.Size(297, 20);
            this.txtBoxWaitRoomDiagnose.TabIndex = 7;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(291, 107);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(60, 13);
            this.label17.TabIndex = 14;
            this.label17.Text = "Chẩn đoán";
            // 
            // lblWaitRoomName
            // 
            this.lblWaitRoomName.AutoSize = true;
            this.lblWaitRoomName.Location = new System.Drawing.Point(6, 36);
            this.lblWaitRoomName.Name = "lblWaitRoomName";
            this.lblWaitRoomName.Size = new System.Drawing.Size(26, 13);
            this.lblWaitRoomName.TabIndex = 0;
            this.lblWaitRoomName.Text = "Tên";
            // 
            // txtBoxWaitRoomName
            // 
            this.txtBoxWaitRoomName.Location = new System.Drawing.Point(87, 39);
            this.txtBoxWaitRoomName.Name = "txtBoxWaitRoomName";
            this.txtBoxWaitRoomName.Size = new System.Drawing.Size(174, 20);
            this.txtBoxWaitRoomName.TabIndex = 1;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(291, 69);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(64, 13);
            this.label16.TabIndex = 12;
            this.label16.Text = "Triệu chứng";
            // 
            // txtBoxWaitingRoomSymptom
            // 
            this.txtBoxWaitingRoomSymptom.Location = new System.Drawing.Point(399, 72);
            this.txtBoxWaitingRoomSymptom.Name = "txtBoxWaitingRoomSymptom";
            this.txtBoxWaitingRoomSymptom.Size = new System.Drawing.Size(297, 20);
            this.txtBoxWaitingRoomSymptom.TabIndex = 6;
            // 
            // lblWaitRoomBirthday
            // 
            this.lblWaitRoomBirthday.AutoSize = true;
            this.lblWaitRoomBirthday.Location = new System.Drawing.Point(6, 69);
            this.lblWaitRoomBirthday.Name = "lblWaitRoomBirthday";
            this.lblWaitRoomBirthday.Size = new System.Drawing.Size(54, 13);
            this.lblWaitRoomBirthday.TabIndex = 16;
            this.lblWaitRoomBirthday.Text = "Ngày sinh";
            // 
            // txtBoxWaitingRoomWeight
            // 
            this.txtBoxWaitingRoomWeight.Location = new System.Drawing.Point(399, 39);
            this.txtBoxWaitingRoomWeight.Name = "txtBoxWaitingRoomWeight";
            this.txtBoxWaitingRoomWeight.Size = new System.Drawing.Size(100, 20);
            this.txtBoxWaitingRoomWeight.TabIndex = 5;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(87, 72);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(125, 20);
            this.dateTimePicker2.TabIndex = 2;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(291, 36);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(33, 13);
            this.label15.TabIndex = 10;
            this.label15.Text = "Nặng";
            // 
            // lblWaitRoomAddress
            // 
            this.lblWaitRoomAddress.AutoSize = true;
            this.lblWaitRoomAddress.Location = new System.Drawing.Point(6, 107);
            this.lblWaitRoomAddress.Name = "lblWaitRoomAddress";
            this.lblWaitRoomAddress.Size = new System.Drawing.Size(40, 13);
            this.lblWaitRoomAddress.TabIndex = 7;
            this.lblWaitRoomAddress.Text = "Địa chỉ";
            // 
            // txtBoxWaitRoomAddress
            // 
            this.txtBoxWaitRoomAddress.Location = new System.Drawing.Point(87, 110);
            this.txtBoxWaitRoomAddress.Name = "txtBoxWaitRoomAddress";
            this.txtBoxWaitRoomAddress.Size = new System.Drawing.Size(166, 20);
            this.txtBoxWaitRoomAddress.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(291, 3);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(56, 13);
            this.label14.TabIndex = 8;
            this.label14.Text = "Chiều Cao";
            // 
            // btnWaitRoomContinue
            // 
            this.btnWaitRoomContinue.Location = new System.Drawing.Point(578, 201);
            this.btnWaitRoomContinue.Name = "btnWaitRoomContinue";
            this.btnWaitRoomContinue.Size = new System.Drawing.Size(75, 23);
            this.btnWaitRoomContinue.TabIndex = 9;
            this.btnWaitRoomContinue.Text = "Tiếp tục";
            this.btnWaitRoomContinue.UseVisualStyleBackColor = true;
            this.btnWaitRoomContinue.Visible = false;
            // 
            // btnWaitRoomCancel
            // 
            this.btnWaitRoomCancel.Location = new System.Drawing.Point(670, 162);
            this.btnWaitRoomCancel.Name = "btnWaitRoomCancel";
            this.btnWaitRoomCancel.Size = new System.Drawing.Size(75, 23);
            this.btnWaitRoomCancel.TabIndex = 10;
            this.btnWaitRoomCancel.Text = "Cancel";
            this.btnWaitRoomCancel.UseVisualStyleBackColor = true;
            // 
            // btnWaitRoomOK
            // 
            this.btnWaitRoomOK.Location = new System.Drawing.Point(508, 162);
            this.btnWaitRoomOK.Name = "btnWaitRoomOK";
            this.btnWaitRoomOK.Size = new System.Drawing.Size(75, 23);
            this.btnWaitRoomOK.TabIndex = 8;
            this.btnWaitRoomOK.Text = "OK";
            this.btnWaitRoomOK.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.programToolStripMenuItem,
            this.doanhThuToolStripMenuItem,
            this.mởRộngToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // programToolStripMenuItem
            // 
            this.programToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logOutToolStripMenuItem,
            this.quitToolStripMenuItem});
            this.programToolStripMenuItem.Name = "programToolStripMenuItem";
            this.programToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.programToolStripMenuItem.Text = "Program";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.logOutToolStripMenuItem.Text = "Log out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // doanhThuToolStripMenuItem
            // 
            this.doanhThuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doanhThuToolStripMenuItem1,
            this.tủThuốcToolStripMenuItem,
            this.cácDịchVụToolStripMenuItem,
            this.cácChẩnĐoánToolStripMenuItem,
            this.appoinment});
            this.doanhThuToolStripMenuItem.Name = "doanhThuToolStripMenuItem";
            this.doanhThuToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.doanhThuToolStripMenuItem.Text = "Thống Kê";
            // 
            // mởRộngToolStripMenuItem
            // 
            this.mởRộngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loaiKhamToolStripMenuItem,
            this.thêmThôngTinHẹnToolStripMenuItem});
            this.mởRộngToolStripMenuItem.Name = "mởRộngToolStripMenuItem";
            this.mởRộngToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.mởRộngToolStripMenuItem.Text = "Mở rộng";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.aboutToolStripMenuItem.Text = "Supports";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel4,
            this.toolpatientAllCount});
            this.statusStrip1.Location = new System.Drawing.Point(0, 689);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1354, 26);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(279, 21);
            this.toolStripStatusLabel1.Text = "Số bệnh nhân khám hôm nay của bạn là :";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(10, 21);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(273, 21);
            this.toolStripStatusLabel4.Text = "Tổng số bệnh nhân khám trong ngày :";
            // 
            // toolpatientAllCount
            // 
            this.toolpatientAllCount.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.toolpatientAllCount.Image = global::Clinic.Properties.Resources.patient;
            this.toolpatientAllCount.Name = "toolpatientAllCount";
            this.toolpatientAllCount.Size = new System.Drawing.Size(35, 21);
            this.toolpatientAllCount.Text = "0";
            this.toolpatientAllCount.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.Image = global::Clinic.Properties.Resources.patient;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(33, 21);
            this.toolStripStatusLabel2.Text = "0";
            this.toolStripStatusLabel2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // doanhThuToolStripMenuItem1
            // 
            this.doanhThuToolStripMenuItem1.Image = global::Clinic.Properties.Resources.incomes;
            this.doanhThuToolStripMenuItem1.Name = "doanhThuToolStripMenuItem1";
            this.doanhThuToolStripMenuItem1.Size = new System.Drawing.Size(188, 22);
            this.doanhThuToolStripMenuItem1.Text = "Doanh Thu";
            this.doanhThuToolStripMenuItem1.Click += new System.EventHandler(this.doanhThuToolStripMenuItem1_Click);
            // 
            // tủThuốcToolStripMenuItem
            // 
            this.tủThuốcToolStripMenuItem.Image = global::Clinic.Properties.Resources.medicine;
            this.tủThuốcToolStripMenuItem.Name = "tủThuốcToolStripMenuItem";
            this.tủThuốcToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.tủThuốcToolStripMenuItem.Text = "Tủ Thuốc";
            this.tủThuốcToolStripMenuItem.Click += new System.EventHandler(this.tủThuốcToolStripMenuItem_Click);
            // 
            // cácDịchVụToolStripMenuItem
            // 
            this.cácDịchVụToolStripMenuItem.Image = global::Clinic.Properties.Resources.hospital;
            this.cácDịchVụToolStripMenuItem.Name = "cácDịchVụToolStripMenuItem";
            this.cácDịchVụToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cácDịchVụToolStripMenuItem.Text = "Các dịch vụ";
            this.cácDịchVụToolStripMenuItem.Click += new System.EventHandler(this.cácDịchVụToolStripMenuItem_Click);
            // 
            // cácChẩnĐoánToolStripMenuItem
            // 
            this.cácChẩnĐoánToolStripMenuItem.Image = global::Clinic.Properties.Resources.chandoan;
            this.cácChẩnĐoánToolStripMenuItem.Name = "cácChẩnĐoánToolStripMenuItem";
            this.cácChẩnĐoánToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.cácChẩnĐoánToolStripMenuItem.Text = "Các chẩn đoán";
            this.cácChẩnĐoánToolStripMenuItem.Click += new System.EventHandler(this.cácChẩnĐoánToolStripMenuItem_Click);
            // 
            // appoinment
            // 
            this.appoinment.Image = global::Clinic.Properties.Resources.appointent;
            this.appoinment.Name = "appoinment";
            this.appoinment.Size = new System.Drawing.Size(188, 22);
            this.appoinment.Text = "Các lịch hẹn tái khám";
            this.appoinment.Click += new System.EventHandler(this.appoinment_Click);
            // 
            // loaiKhamToolStripMenuItem
            // 
            this.loaiKhamToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLoạiToolStripMenuItem});
            this.loaiKhamToolStripMenuItem.Image = global::Clinic.Properties.Resources.folder;
            this.loaiKhamToolStripMenuItem.Name = "loaiKhamToolStripMenuItem";
            this.loaiKhamToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.loaiKhamToolStripMenuItem.Text = "Loại Khám";
            this.loaiKhamToolStripMenuItem.Click += new System.EventHandler(this.loaiKhamToolStripMenuItem_Click);
            // 
            // thêmLoạiToolStripMenuItem
            // 
            this.thêmLoạiToolStripMenuItem.Name = "thêmLoạiToolStripMenuItem";
            this.thêmLoạiToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.thêmLoạiToolStripMenuItem.Text = "Thêm Loại";
            this.thêmLoạiToolStripMenuItem.Click += new System.EventHandler(this.themLoaiToolStripMenuItem_Click);
            // 
            // thêmThôngTinHẹnToolStripMenuItem
            // 
            this.thêmThôngTinHẹnToolStripMenuItem.Image = global::Clinic.Properties.Resources.edit_interface_symbol_of_a_pencil_on_a_square_outline_paper;
            this.thêmThôngTinHẹnToolStripMenuItem.Name = "thêmThôngTinHẹnToolStripMenuItem";
            this.thêmThôngTinHẹnToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.thêmThôngTinHẹnToolStripMenuItem.Text = "Thêm Thông Tin Hẹn";
            this.thêmThôngTinHẹnToolStripMenuItem.Click += new System.EventHandler(this.thêmThôngTinHẹnToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::Clinic.Properties.Resources.print_printer;
            this.pictureBox1.Location = new System.Drawing.Point(1199, 153);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(115, 21);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 62;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 715);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.MainTab);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Phòng Khám";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MainTab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panelcontent.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMedicine)).EndInit();
            this.panelListContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchValue)).EndInit();
            this.CoTableLayoutPanel1.ResumeLayout(false);
            this.CoTableLayoutPanel1.PerformLayout();
            this.Calendar.ResumeLayout(false);
            this.panelCalendarDate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCalendar)).EndInit();
            this.panelCalendar.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tabPageTools.ResumeLayout(false);
            this.tabPageTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAccount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.CoTableLayoutPanel6.ResumeLayout(false);
            this.CoTableLayoutPanel6.PerformLayout();
            this.CoTableLayoutPanel5.ResumeLayout(false);
            this.CoTableLayoutPanel5.PerformLayout();
            this.tabPagePrint.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.CoTableLayoutPanel2.ResumeLayout(false);
            this.CoTableLayoutPanel2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainTab;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnWaitRoomCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtBoxWaitRoomDiagnose;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtBoxWaitingRoomWeight;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtBoxWaitRoomAddress;
        private System.Windows.Forms.Label lblWaitRoomAddress;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnWaitRoomOK;
        private System.Windows.Forms.TextBox txtBoxWaitingRoomSymptom;
        private System.Windows.Forms.Label lblWaitRoomBirthday;
        private System.Windows.Forms.TextBox txtBoxWaitRoomName;
        private System.Windows.Forms.Label lblWaitRoomName; //NT Tên
        private System.Windows.Forms.ComboBox comboBoxWaitRoomId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxWaitRoomHeight;
        private System.Windows.Forms.Button btnWaitRoomContinue;
        private CoTableLayoutPanel CoTableLayoutPanel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private TabPage tabPageTools;
        private Button buttonCreateUser;
        private CheckBox checkBoxNhapThuoc;
        private Label label29;
        private Label label10;
        private TextBox textBox2;
        private TextBox textBox1;
        private DataGridView dataGridView4;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column22;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column23;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column24;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column25;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn Column26;
        private CheckBox checkBoxKethuoc;
        private TabPage tabPagePrint;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
       
        private TabPage Calendar;
        private Panel panelCalendar;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter1;
        private Panel panelCalendarDate;

        private MonthView tabPageLich;
        private System.Windows.Forms.Calendar.Calendar calendar1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem redTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yellowTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem timescaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hourToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem editItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem minutesToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem otherColorTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem patternToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diagonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hatchToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem selectImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageAlignmentToolStripMenuItem;
        private Button button1;
        private CoTableLayoutPanel CoTableLayoutPanel5;
        private Label label35;
        private TextBox textBoxNameClinic;
        private TextBox textBoxAddressClinic;
        private TextBox textBoxAdviceClinic;
        private Label label37;
        private Label label36;
        private CoTableLayoutPanel CoTableLayoutPanel6;
        private Label label38;
        private Label label39;
        private Label label40;
        private TextBox textBoxBackupSource;
        private TextBox textBoxBackupTarget;
        private TextBox textBoxBackupTimeAuto;
        private Button button2;
        private Button button4;
        private CheckBox checkBoxAutoCopy;
        private TextBox textBoxNameDoctor;
        private Label label46;
        private DataGridView dataGridViewCalendar;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem programToolStripMenuItem;
        private ToolStripMenuItem logOutToolStripMenuItem;
        private ToolStripMenuItem quitToolStripMenuItem;
        private ToolStripMenuItem doanhThuToolStripMenuItem;
        private ToolStripMenuItem aboutToolStripMenuItem;
        private Label labelSdt;
        private TextBox textBoxSDT;
        private ToolStripMenuItem doanhThuToolStripMenuItem1;
        private ToolStripMenuItem tủThuốcToolStripMenuItem;
        private ToolStripMenuItem cácDịchVụToolStripMenuItem;
        private ToolStripMenuItem mởRộngToolStripMenuItem;
        private ToolStripMenuItem loaiKhamToolStripMenuItem;
        private ToolStripMenuItem thêmLoạiToolStripMenuItem;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn ColumnNameMedicine;
        private ToolStripMenuItem cácChẩnĐoánToolStripMenuItem;
        private TabPage tabPage1;
        private DevComponents.DotNetBar.Controls.CircularProgress circularProgress1;
        private Button buttonList;
        private DataGridView dataGridViewSearchValue;
        private TextBox txtBoxClinicRoomDiagnose;
        private ComboBox comboBoxPrintPageOptions;
        private CheckBox checkBoxHen;
        private DateTimePicker dateTimePickerHen;
        private PictureBox pictureBox1;
        private Label label9;
        private Button buttonPutIn;
        private DataGridView dataGridViewMedicine;
        private Label labelTongTien;
        private TextBox txtBoxClinicRoomSymptom;
        private TextBox textBoxClinicPhone;
        private Label label6;
        private Label label44;
        private Label label7;
        private ComboBox comboBoxLoaiKham;
        private CheckBox checkBoxShow1Record;
        private CheckBox checkBoxShowMedicines;
        private CheckBox checkBoxShowBigForm;
        private Button buttonSearch;
        private CoTableLayoutPanel CoTableLayoutPanel1;
        private Label label28;
        private Label lblClinicRoomId;
        private Label label1;
        private Label label2;
        private TextBox textBoxClinicNhietDo;
        private DateTimePicker dateTimePickerBirthDay;
        private TextBox txtBoxClinicRoomAddress;
        private Label label3;
        private Label label45;
        private TextBox comboBoxClinicRoomName;
        private Button buttonClinicCreateNew;
        private Button buttonClinicClear;
        private TextBox txtBoxClinicRoomWeight;
        private Label label5;
        private Label label4;
        private TextBox txtBoxClinicRoomHeight;
        private Label label31;
        private DateTimePicker dateTimePickerNgayKham;
        private Label label30;
        private TextBox textBoxHuyetAp;
        private Label label47;
        private Label labelTuoi;
        private Button button3;
        private ToolStripMenuItem thêmThôngTinHẹnToolStripMenuItem;
        private ComboBox cbb_Reason;
        private Panel panelcontent;
        private DevComponents.DotNetBar.ExpandableSplitter expandableSplitter2;
        private Panel panelListContent;
        private Panel panel2;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private Panel panel1;
        private Button btn_khamlai;
        private DataGridView dataGridViewAccount;
        private DataGridViewTextBoxColumn ColumnUsername;
        private DataGridViewTextBoxColumn Columnnamedoctor;
        private DataGridViewButtonColumn Columnupdate;
        private DataGridViewButtonColumn Columndelete;
        private DataGridViewTextBoxColumn ColumnID;
        private DataGridViewTextBoxColumn ColumnNamePatient;
        private DataGridViewTextBoxColumn ColumnNgaySinh;
        private DataGridViewTextBoxColumn ColumnNgayKham;
        private DataGridViewTextBoxColumn ColumnAddress;
        private DataGridViewTextBoxColumn ColumnSymtom;
        private DataGridViewTextBoxColumn ColumnNhietDo;
        private DataGridViewTextBoxColumn ColumnHuyetAp;
        private DataGridViewTextBoxColumn ColumnWeight;
        private DataGridViewTextBoxColumn ColumnDiagno;
        private DataGridViewTextBoxColumn ColumnSearchValueMedicines;
        private DataGridViewTextBoxColumn CollIDHistory;
        private ToolStripStatusLabel toolStripStatusLabel3;
        private ToolStripStatusLabel toolStripStatusLabel4;
        private ToolStripStatusLabel toolpatientAllCount;
        private DevComponents.DotNetBar.Controls.DataGridViewComboBoxExColumn ColumnNameAllMedicine;
        private DevComponents.DotNetBar.Controls.DataGridViewTextBoxDropDownColumn Column19;
        private DataGridViewTextBoxColumn store;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ColumnCost;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ColumnMoneyMedicine;
        private DataGridViewTextBoxColumn dataGridViewMedicinesId;
        private DataGridViewTextBoxColumn ColumnMedicinesHDSD;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Patient;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn sick;
        private DataGridViewTextBoxColumn dataGridViewButtonColumn1;
        private DataGridViewTextBoxColumn ColumnReason;
        private DevComponents.DotNetBar.Controls.DataGridViewLabelXColumn ColumnState;
        private ToolStripMenuItem appoinment;
    }
}

