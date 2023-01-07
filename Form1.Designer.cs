namespace DemoSort
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btHistory2 = new System.Windows.Forms.Button();
            this.btHistory = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Chon2ThuatToan = new System.Windows.Forms.RadioButton();
            this.Chon1ThuatToan = new System.Windows.Forms.RadioButton();
            this.checkBoxStep = new System.Windows.Forms.CheckBox();
            this.btTao = new System.Windows.Forms.Button();
            this.txNhap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btNext = new System.Windows.Forms.Button();
            this.ListSapXep2 = new System.Windows.Forms.ComboBox();
            this.btChay = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ListSapXep = new System.Windows.Forms.ComboBox();
            this.pnChay = new System.Windows.Forms.Panel();
            this.backgroundWorkerInterCharge = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerInsertionSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerQuickSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSelectionSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerBubbleSort = new System.ComponentModel.BackgroundWorker();
            this.panel4 = new System.Windows.Forms.Panel();
            this.comboSpeed = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.backgroundWorkerHeapSort = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerInterChargeStep = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerInsertionStep = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerQuickStep = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSelectionStep = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerHeapStep = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerBubbleStep = new System.ComponentModel.BackgroundWorker();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel5 = new System.Windows.Forms.Panel();
            this.backgroundWorkerInterCharge2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerInsertionSort2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerQuickSort2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerSelectionSort2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerBubbleSort2 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorkerHeapSort2 = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(749, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "MÔ PHỎNG THUẬT TOÁN SẮP XẾP";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btHistory2);
            this.panel1.Controls.Add(this.btHistory);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1225, 66);
            this.panel1.TabIndex = 1;
            // 
            // btHistory2
            // 
            this.btHistory2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btHistory2.Dock = System.Windows.Forms.DockStyle.Left;
            this.btHistory2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory2.ForeColor = System.Drawing.SystemColors.Control;
            this.btHistory2.Location = new System.Drawing.Point(0, 0);
            this.btHistory2.Name = "btHistory2";
            this.btHistory2.Size = new System.Drawing.Size(115, 64);
            this.btHistory2.TabIndex = 13;
            this.btHistory2.Text = "History2";
            this.btHistory2.UseVisualStyleBackColor = false;
            this.btHistory2.Click += new System.EventHandler(this.btHistory2_Click);
            // 
            // btHistory
            // 
            this.btHistory.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.btHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btHistory.ForeColor = System.Drawing.SystemColors.Info;
            this.btHistory.Location = new System.Drawing.Point(1120, 0);
            this.btHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btHistory.Name = "btHistory";
            this.btHistory.Size = new System.Drawing.Size(103, 64);
            this.btHistory.TabIndex = 12;
            this.btHistory.Text = "History";
            this.btHistory.UseVisualStyleBackColor = false;
            this.btHistory.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.Chon2ThuatToan);
            this.panel2.Controls.Add(this.Chon1ThuatToan);
            this.panel2.Controls.Add(this.checkBoxStep);
            this.panel2.Controls.Add(this.btTao);
            this.panel2.Controls.Add(this.txNhap);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 110);
            this.panel2.TabIndex = 2;
            // 
            // Chon2ThuatToan
            // 
            this.Chon2ThuatToan.AutoSize = true;
            this.Chon2ThuatToan.Location = new System.Drawing.Point(186, 77);
            this.Chon2ThuatToan.Name = "Chon2ThuatToan";
            this.Chon2ThuatToan.Size = new System.Drawing.Size(105, 21);
            this.Chon2ThuatToan.TabIndex = 11;
            this.Chon2ThuatToan.TabStop = true;
            this.Chon2ThuatToan.Text = "2 thuật toán";
            this.Chon2ThuatToan.UseVisualStyleBackColor = true;
            // 
            // Chon1ThuatToan
            // 
            this.Chon1ThuatToan.AutoSize = true;
            this.Chon1ThuatToan.Location = new System.Drawing.Point(9, 77);
            this.Chon1ThuatToan.Name = "Chon1ThuatToan";
            this.Chon1ThuatToan.Size = new System.Drawing.Size(105, 21);
            this.Chon1ThuatToan.TabIndex = 10;
            this.Chon1ThuatToan.TabStop = true;
            this.Chon1ThuatToan.Text = "1 thuật toán";
            this.Chon1ThuatToan.UseVisualStyleBackColor = true;
            // 
            // checkBoxStep
            // 
            this.checkBoxStep.AutoSize = true;
            this.checkBoxStep.Location = new System.Drawing.Point(111, 51);
            this.checkBoxStep.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxStep.Name = "checkBoxStep";
            this.checkBoxStep.Size = new System.Drawing.Size(109, 21);
            this.checkBoxStep.TabIndex = 9;
            this.checkBoxStep.Text = "Step by step";
            this.checkBoxStep.UseVisualStyleBackColor = true;
            // 
            // btTao
            // 
            this.btTao.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btTao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btTao.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btTao.Location = new System.Drawing.Point(255, 5);
            this.btTao.Margin = new System.Windows.Forms.Padding(4);
            this.btTao.Name = "btTao";
            this.btTao.Size = new System.Drawing.Size(80, 41);
            this.btTao.TabIndex = 7;
            this.btTao.Text = "TẠO";
            this.btTao.UseVisualStyleBackColor = false;
            this.btTao.Click += new System.EventHandler(this.bttaonut_Click);
            // 
            // txNhap
            // 
            this.txNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNhap.Location = new System.Drawing.Point(174, 5);
            this.txNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txNhap.Multiline = true;
            this.txNhap.Name = "txNhap";
            this.txNhap.Size = new System.Drawing.Size(57, 38);
            this.txNhap.TabIndex = 4;
            this.txNhap.TextChanged += new System.EventHandler(this.txnhapnut_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "Số phần tử: ";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.btNext);
            this.panel3.Controls.Add(this.ListSapXep2);
            this.panel3.Controls.Add(this.btChay);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.ListSapXep);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(684, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(540, 110);
            this.panel3.TabIndex = 3;
            // 
            // btNext
            // 
            this.btNext.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNext.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btNext.Location = new System.Drawing.Point(422, 3);
            this.btNext.Margin = new System.Windows.Forms.Padding(4);
            this.btNext.Name = "btNext";
            this.btNext.Size = new System.Drawing.Size(112, 41);
            this.btNext.TabIndex = 9;
            this.btNext.Text = "NEXT";
            this.btNext.UseVisualStyleBackColor = false;
            this.btNext.Visible = false;
            this.btNext.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // ListSapXep2
            // 
            this.ListSapXep2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSapXep2.FormattingEnabled = true;
            this.ListSapXep2.Items.AddRange(new object[] {
            "Interchange Sort",
            "Insertion Sort",
            "Quick Sort",
            "Selection Sort",
            "Bubble Sort",
            "Heap Sort"});
            this.ListSapXep2.Location = new System.Drawing.Point(231, 61);
            this.ListSapXep2.Name = "ListSapXep2";
            this.ListSapXep2.Size = new System.Drawing.Size(167, 33);
            this.ListSapXep2.TabIndex = 10;
            // 
            // btChay
            // 
            this.btChay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChay.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btChay.Location = new System.Drawing.Point(422, 2);
            this.btChay.Margin = new System.Windows.Forms.Padding(4);
            this.btChay.Name = "btChay";
            this.btChay.Size = new System.Drawing.Size(108, 42);
            this.btChay.TabIndex = 6;
            this.btChay.Text = "CHẠY";
            this.btChay.UseVisualStyleBackColor = false;
            this.btChay.Click += new System.EventHandler(this.btsapxep_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(225, 39);
            this.label3.TabIndex = 4;
            this.label3.Text = "Thuật toán: ";
            // 
            // ListSapXep
            // 
            this.ListSapXep.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListSapXep.FormattingEnabled = true;
            this.ListSapXep.Items.AddRange(new object[] {
            "Interchange Sort",
            "Insertion Sort",
            "Quick Sort",
            "Selection Sort",
            "Bubble Sort",
            "Heap Sort"});
            this.ListSapXep.Location = new System.Drawing.Point(231, 5);
            this.ListSapXep.Margin = new System.Windows.Forms.Padding(4);
            this.ListSapXep.Name = "ListSapXep";
            this.ListSapXep.Size = new System.Drawing.Size(167, 34);
            this.ListSapXep.TabIndex = 8;
            // 
            // pnChay
            // 
            this.pnChay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnChay.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnChay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnChay.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnChay.Location = new System.Drawing.Point(24, 74);
            this.pnChay.Margin = new System.Windows.Forms.Padding(4);
            this.pnChay.Name = "pnChay";
            this.pnChay.Size = new System.Drawing.Size(1185, 263);
            this.pnChay.TabIndex = 9;
            this.pnChay.Resize += new System.EventHandler(this.pnchay_Resize);
            // 
            // backgroundWorkerInterCharge
            // 
            this.backgroundWorkerInterCharge.WorkerReportsProgress = true;
            this.backgroundWorkerInterCharge.WorkerSupportsCancellation = true;
            this.backgroundWorkerInterCharge.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            this.backgroundWorkerInterCharge.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker1_RunWorkerCompleted_1);
            // 
            // backgroundWorkerInsertionSort
            // 
            this.backgroundWorkerInsertionSort.WorkerReportsProgress = true;
            this.backgroundWorkerInsertionSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerInsertionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker2_DoWork);
            this.backgroundWorkerInsertionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker2_RunWorkerCompleted_1);
            // 
            // backgroundWorkerQuickSort
            // 
            this.backgroundWorkerQuickSort.WorkerReportsProgress = true;
            this.backgroundWorkerQuickSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerQuickSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker3_DoWork_1);
            this.backgroundWorkerQuickSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker3_RunWorkerCompleted_1);
            // 
            // backgroundWorkerSelectionSort
            // 
            this.backgroundWorkerSelectionSort.WorkerReportsProgress = true;
            this.backgroundWorkerSelectionSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerSelectionSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker4_DoWork);
            this.backgroundWorkerSelectionSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker4_RunWorkerCompleted);
            // 
            // backgroundWorkerBubbleSort
            // 
            this.backgroundWorkerBubbleSort.WorkerReportsProgress = true;
            this.backgroundWorkerBubbleSort.WorkerSupportsCancellation = true;
            this.backgroundWorkerBubbleSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker5_DoWork);
            this.backgroundWorkerBubbleSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker5_RunWorkerCompleted);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.comboSpeed);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(342, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(335, 110);
            this.panel4.TabIndex = 10;
            // 
            // comboSpeed
            // 
            this.comboSpeed.FormattingEnabled = true;
            this.comboSpeed.Items.AddRange(new object[] {
            "Rất chậm",
            "Chậm",
            "Thường",
            "Nhanh",
            "Rất Nhanh"});
            this.comboSpeed.Location = new System.Drawing.Point(173, 37);
            this.comboSpeed.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboSpeed.Name = "comboSpeed";
            this.comboSpeed.Size = new System.Drawing.Size(140, 24);
            this.comboSpeed.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 106);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tốc độ :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backgroundWorkerHeapSort
            // 
            this.backgroundWorkerHeapSort.WorkerReportsProgress = true;
            this.backgroundWorkerHeapSort.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker6_DoWork);
            this.backgroundWorkerHeapSort.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker6_RunWorkerCompleted);
            // 
            // backgroundWorkerInterChargeStep
            // 
            this.backgroundWorkerInterChargeStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker7_DoWork);
            // 
            // backgroundWorkerInsertionStep
            // 
            this.backgroundWorkerInsertionStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker8_DoWork);
            // 
            // backgroundWorkerQuickStep
            // 
            this.backgroundWorkerQuickStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker9_DoWork);
            // 
            // backgroundWorkerSelectionStep
            // 
            this.backgroundWorkerSelectionStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker10_DoWork);
            // 
            // backgroundWorkerHeapStep
            // 
            this.backgroundWorkerHeapStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker11_DoWork);
            // 
            // backgroundWorkerBubbleStep
            // 
            this.backgroundWorkerBubbleStep.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker12_DoWork);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.hScrollBar1.Location = new System.Drawing.Point(0, 454);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(1224, 21);
            this.hScrollBar1.TabIndex = 0;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panel4);
            this.panel5.Controls.Add(this.panel2);
            this.panel5.Controls.Add(this.panel3);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 344);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1224, 110);
            this.panel5.TabIndex = 10;
            // 
            // backgroundWorkerInterCharge2
            // 
            this.backgroundWorkerInterCharge2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker13_DoWork);
            this.backgroundWorkerInterCharge2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker13_RunWorkerCompleted);
            // 
            // backgroundWorkerInsertionSort2
            // 
            this.backgroundWorkerInsertionSort2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker14_DoWork);
            this.backgroundWorkerInsertionSort2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker14_RunWorkerCompleted);
            // 
            // backgroundWorkerQuickSort2
            // 
            this.backgroundWorkerQuickSort2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker15_DoWork);
            this.backgroundWorkerQuickSort2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker15_RunWorkerCompleted);
            // 
            // backgroundWorkerSelectionSort2
            // 
            this.backgroundWorkerSelectionSort2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker16_DoWork);
            this.backgroundWorkerSelectionSort2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker16_RunWorkerCompleted);
            // 
            // backgroundWorkerBubbleSort2
            // 
            this.backgroundWorkerBubbleSort2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker17_DoWork);
            this.backgroundWorkerBubbleSort2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker17_RunWorkerCompleted);
            // 
            // backgroundWorkerHeapSort2
            // 
            this.backgroundWorkerHeapSort2.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker18_DoWork);
            this.backgroundWorkerHeapSort2.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker18_RunWorkerCompleted);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1224, 475);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.pnChay);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sort Algorithms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txNhap;
        private System.Windows.Forms.Button btChay;
        private System.Windows.Forms.Button btTao;
        private System.Windows.Forms.ComboBox ListSapXep;
        private System.Windows.Forms.Panel pnChay;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInterCharge;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInsertionSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelectionSort;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBubbleSort;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHeapSort;
        private System.Windows.Forms.Button btHistory;
        private System.Windows.Forms.CheckBox checkBoxStep;
        private System.Windows.Forms.ComboBox comboSpeed;
        private System.Windows.Forms.Button btNext;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInterChargeStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInsertionStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelectionStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHeapStep;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBubbleStep;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.RadioButton Chon2ThuatToan;
        private System.Windows.Forms.RadioButton Chon1ThuatToan;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox ListSapXep2;
        private System.Windows.Forms.Button btHistory2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInterCharge2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerInsertionSort2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerQuickSort2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerSelectionSort2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerBubbleSort2;
        private System.ComponentModel.BackgroundWorker backgroundWorkerHeapSort2;
    }
}

