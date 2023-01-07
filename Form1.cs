using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*Danh sách vị trí các hàm sort
 * Interchange Sort : 
 * Insertion Sort: 
 * Quick Sort:
 * Radix Sort: 
 * Bubble Sort:
 * Selection Sort:
 */

namespace DemoSort
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            hScrollBar1.Maximum = 1000;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Value = 0;
            SIZE = ClientSize.Height / 10;

        }
        private void txnhapnut_TextChanged(object sender, EventArgs e)
        {

        }
        Form3 frm2 = new Form3();
        Form2 frm = new Form2();
        // tạo biến random chứa giá trị số ngẫu nhiên cho nút
        Random rd = new Random();
        String sMang = "";
        String sMang2 = "";
        int iSoBuoc = 0;
        int iSoBuoc2 = 0;
        int[] M; // mảng M chứa giá trị số nguyên
        int[] M2;
        Button[] Mn; // mảng nút
        Button[] Mn2; //mảng nút 2
        int SIZE = 50; // kích thước của nút
        int KHOANGCACHNUT = 100;
        int iSpeed = 100;
        int iResize = 10;
        
        int isave, jsave;
        private bool IsNumber(string s)
        {
            foreach(char k in s)
            {
                if ((k<'0') || (k>'9'))
                {
                    return false;
                }
            }
            return true;

        }
        private void bttaonut_Click(object sender, EventArgs e)
        {
            pnChay.Controls.Clear();
            btChay.Text = "CHẠY";
            iSoBuoc = 0;
            if(comboSpeed.Text == "")
            {
                MessageBox.Show("Chọn tốc độ");
            }    
            else
            
            if(IsNumber(txNhap.Text) == false)
            {
                MessageBox.Show("text phải nhập là số");
            }
            else
            {
                if ((Chon1ThuatToan.Checked == false) && (Chon2ThuatToan.Checked == false))
                {
                    MessageBox.Show(" Vui lòng chọn số thuật toán");
                }
                
                else if (Chon1ThuatToan.Checked == true)
                {
                    btHistory2.Visible = false;
                    //lấy giá trị n nhập từ bàn phím
                    int n = int.Parse(txNhap.Text.Trim());
                    M = new int[n]; // khởi tạo mảng M có n phần tử
                    Mn = new Button[n]; // khởi tạo mảng Mn có n nút

                    //Xóa giao diện cũ trong pnchay


                    for (int i = 0; i < n; i++)
                    {
                        Button bt = new Button(); // khởi tạo một Button "bt"

                        int value = rd.Next(100); // lấy một giá trị ngẫu nhiên từ 0 - 99
                        bt.Text = value + ""; // thên giá trị ngẫu nhiên vào nút "bt"
                        bt.Height = bt.Width = iResize * 5;
                        bt.Location = new Point
                            (
                            KHOANGCACHNUT + (bt.Width + 30) * i - 60,
                            20
                        ); // cho nút xuất hiện giữa trong pnnchay

                        pnChay.Controls.Add(bt); // add nút vào pnchay
                        M[i] = value; // gán giá trị ngẫu nhiên cho từng phần từ trong mảng
                        Mn[i] = bt; // gán từng nút cho mảng button
                    }

                    foreach (Button bt in pnChay.Controls) // đổi màu nút
                    {
                        bt.BackColor = Color.Red;
                        bt.ForeColor = Color.White;
                    }
                    ListSapXep2.Visible = false;
                    checkBoxStep.Visible = true;
                }
                else if (Chon2ThuatToan.Checked == true)
                {                    
                    //lấy giá trị n nhập từ bàn phím
                    int n = int.Parse(txNhap.Text.Trim());
                    M = new int[n]; // khởi tạo mảng M có n phần tử
                    M2 = new int[n];
                    Mn = new Button[n]; // khởi tạo mảng Mn có n nút
                    Mn2 = new Button[n];

                    //Xóa giao diện cũ trong pnchay


                    for (int i = 0; i < n; i++)
                    {
                        Button bt = new Button(); // khởi tạo một Button "bt"
                        Button bt2 = new Button();
                        int value = rd.Next(100); // lấy một giá trị ngẫu nhiên từ 0 - 99
                        bt.Text = value + ""; // thên giá trị ngẫu nhiên vào nút "bt"
                        bt2.Text = value + "";
                        bt.Height = bt.Width = iResize * 5;
                        bt2.Height = bt2.Width = iResize * 5;
                        bt.Location = new Point(KHOANGCACHNUT + (bt.Width + 30) * i - 60, 20);
                        bt2.Location = new Point(KHOANGCACHNUT + (bt2.Width + 30) * i - 60, 90);
                        pnChay.Controls.Add(bt); // add nút vào pnchay
                        pnChay.Controls.Add(bt2);
                        M[i] = value; // gán giá trị ngẫu nhiên cho từng phần từ trong mảng
                        M2[i] = value;
                        Mn[i] = bt; // gán từng nút cho mảng button
                        Mn2[i] = bt2;
                    }

                    foreach (Button bt in pnChay.Controls) // đổi màu nút
                    {
                        bt.BackColor = Color.Red;
                        bt.ForeColor = Color.White;
                    }
                    checkBoxStep.Visible = false;
                    btNext.Visible = false;
                    ListSapXep2.Visible = true;
                    btHistory2.Visible = true;

                }
            }
            this.Refresh();

        }
        private void pnchay_Resize(object sender, EventArgs e)
            {
                iResize = pnChay.Height / 20;
                if (txNhap.Text == "") { }
                else
                {
                    if (Chon1ThuatToan.Checked == true)
                    {
                        int n = int.Parse(txNhap.Text);
                        for (int i = 0; i < n; i++)
                        {
                            Mn[i].Height = Mn[i].Width = iResize * 5;

                            Mn[i].Location = new Point
                            (
                                KHOANGCACHNUT + (Mn[i].Width + 30) * i,
                                pnChay.Height / 2 - Mn[i].Height / 2
                            );
                        }
                    }
                    else if (Chon2ThuatToan.Checked == true)
                    {
                        int n = int.Parse(txNhap.Text);
                        for (int i = 0; i < n; i++)
                        {
                            Mn[i].Height = Mn[i].Width = iResize * 5;
                            Mn2[i].Height = Mn2[i].Width = iResize * 5;
                            Mn[i].Location = new Point
                            (
                                KHOANGCACHNUT + (Mn[i].Width + 30) * i,
                                pnChay.Height / 2 - Mn[i].Height / 2 - 40
                            );
                            Mn2[i].Location = new Point
                            (
                                KHOANGCACHNUT + (Mn2[i].Width + 30) * i,
                                pnChay.Height / 2 - Mn2[i].Height / 2 + 10 + Mn[i].Height
                            );
                        }
                    }
                }
            


        }
        //
        //
        //
        //
        private void button3_Click(object sender, EventArgs e)
        {
            frm.Show();
        }
        private bool ktra()
        {
            for (int i = 1; i < M.Length; i++)
            {
                if (M[i - 1] > M[i])
                    return false;
            }
            return true;
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
             
            if (ListSapXep.SelectedIndex == 0) // Interchange Sort
            {
                backgroundWorkerInterChargeStep.RunWorkerAsync();
            }
            else if (ListSapXep.SelectedIndex == 1) // Insertion Sort
            {

                backgroundWorkerInsertionStep.RunWorkerAsync();
            }
            else if (ListSapXep.SelectedIndex == 2) // Quick Sort
            {

                backgroundWorkerQuickStep.RunWorkerAsync();

            }

            else if (ListSapXep.SelectedIndex == 3) // Selection sort
            {

                backgroundWorkerSelectionStep.RunWorkerAsync();

            }
            else if (ListSapXep.SelectedIndex == 4) // Bubble sort
            {

                backgroundWorkerBubbleStep.RunWorkerAsync();

            }
            else if (ListSapXep.SelectedIndex == 5) // heapsort
            {


                backgroundWorkerHeapStep.RunWorkerAsync();


            }
            if (ktra() == true)
            {
                btChay.Visible = true;
                btNext.Visible = false;
                btNext.Enabled = false;
                btTao.Enabled = true;
                btChay.Enabled = true;
                foreach (Button bt in pnChay.Controls) // đổi màu nút để thông báo hoàn thành sort
                {
                    bt.BackColor = Color.Black;
                    bt.ForeColor = Color.White;
                }
            }
        }
        private void btsapxep_Click(object sender, EventArgs e)
        {
            
            if(txNhap.Text == "")
            {
                MessageBox.Show("Nhập số nút");
            }
            else
            {
                if (comboSpeed.Text == "")
                {
                    MessageBox.Show("Chọn tốc độ");
                }
                else
                {
                    if (String.Compare(comboSpeed.Text, "Rất chậm", true) == 0) iSpeed = 0;
                    else if (String.Compare(comboSpeed.Text, "Chậm", true) == 0) iSpeed = 100;
                    else if (String.Compare(comboSpeed.Text, "Thường", true) == 0) iSpeed = 200;
                    else if (String.Compare(comboSpeed.Text, "Nhanh", true) == 0) iSpeed = 300;
                    else if (String.Compare(comboSpeed.Text, "Rất Nhanh", true) == 0) iSpeed = 399;
                    if (Mn.Length == 0)
                    {
                        MessageBox.Show("Không có button");
                    }
                    else
                    {
                        if (checkBoxStep.Checked == false)
                        {
                            
                            if (Chon1ThuatToan.Checked == true)
                            {
                                btNext.Visible = false;


                                if (ListSapXep.SelectedIndex == -1)
                                {
                                    MessageBox.Show("Bạn chưa chọn thuật toán sắp xếp.");

                                }
                                else if (ListSapXep.SelectedIndex == 0) // Interchange Sort
                                {
                                    frm.Text = frm.Text + " " + ListSapXep.Text;
                                    btChay.Enabled = false; // ẩn nút chọn thuật toán trong quá trình chạy
                                    backgroundWorkerInterCharge.RunWorkerAsync(); // gọi hàm Dowork
                                }
                                else if (ListSapXep.SelectedIndex == 1) // Insertion Sort
                                {
                                    frm.Text = frm.Text + " " + ListSapXep.Text;

                                    btChay.Enabled = false;
                                    backgroundWorkerInsertionSort.RunWorkerAsync();
                                }
                                else if (ListSapXep.SelectedIndex == 2) // Quick Sort
                                {
                                    btChay.Enabled = false;
                                    backgroundWorkerHeapSort.RunWorkerAsync();

                                }
                                else if (ListSapXep.SelectedIndex == 3) // Selection sort
                                {

                                    btChay.Enabled = false;
                                    backgroundWorkerSelectionSort.RunWorkerAsync();

                                }
                                else if (ListSapXep.SelectedIndex == 4) // Bubble sort
                                {

                                    btChay.Enabled = false;
                                    backgroundWorkerQuickSort.RunWorkerAsync();

                                }
                                else if (ListSapXep.SelectedIndex == 5) //heap sort
                                {
                                    btChay.Enabled = false;
                                    backgroundWorkerBubbleSort.RunWorkerAsync();
                                }

                            }
                            else if (Chon2ThuatToan.Checked == true)
                            {
                                if (ListSapXep2.SelectedIndex == ListSapXep.SelectedIndex)
                                {
                                    MessageBox.Show("Phải chọn 2 thuật toán khác nhau");
                                }
                                else
                                {
                                    if (ListSapXep.SelectedIndex == -1)
                                    {
                                        MessageBox.Show(" Chưa chọn thuật toán đầu");
                                    }
                                    else if ((ListSapXep2.SelectedIndex) == -1)
                                    { MessageBox.Show("Chưa chọn thuật toán hai"); }
                                    else
                                    {
                                        if ((ListSapXep.SelectedIndex == 0) && (ListSapXep2.SelectedIndex == 1))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 1) && (ListSapXep2.SelectedIndex == 0))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 0) && (ListSapXep2.SelectedIndex == 2))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 2) && (ListSapXep2.SelectedIndex == 0))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 0) && (ListSapXep2.SelectedIndex == 3))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 3) && (ListSapXep2.SelectedIndex == 0))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 0) && (ListSapXep2.SelectedIndex == 4))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 4) && (ListSapXep2.SelectedIndex == 0))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 0) && (ListSapXep2.SelectedIndex == 5))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 5) && (ListSapXep2.SelectedIndex == 0))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInterCharge2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 1) && (ListSapXep2.SelectedIndex == 2))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 2) && (ListSapXep2.SelectedIndex == 1))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 1) && (ListSapXep2.SelectedIndex == 3))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 3) && (ListSapXep2.SelectedIndex == 1))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 1) && (ListSapXep2.SelectedIndex == 4))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 4) && (ListSapXep2.SelectedIndex == 1))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 1) && (ListSapXep2.SelectedIndex == 5))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 5) && (ListSapXep2.SelectedIndex == 1))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerInsertionSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 2) && (ListSapXep2.SelectedIndex == 3))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 3) && (ListSapXep2.SelectedIndex == 2))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 2) && (ListSapXep2.SelectedIndex == 4))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 4) && (ListSapXep2.SelectedIndex == 2))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 2) && (ListSapXep2.SelectedIndex == 5))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 5) && (ListSapXep2.SelectedIndex == 2))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerQuickSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 3) && (ListSapXep2.SelectedIndex == 4))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 4) && (ListSapXep2.SelectedIndex == 3))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 3) && (ListSapXep2.SelectedIndex == 5))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 5) && (ListSapXep2.SelectedIndex == 3))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerSelectionSort2.RunWorkerAsync(); }, atp);
                                            });

                                        }
                                        else if ((ListSapXep.SelectedIndex == 4) && (ListSapXep2.SelectedIndex == 5))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                        else if ((ListSapXep.SelectedIndex == 5) && (ListSapXep2.SelectedIndex == 4))
                                        {
                                            TaskCreationOptions atp = TaskCreationOptions.AttachedToParent;
                                            Task.Factory.StartNew(() =>
                                            {
                                                Task.Factory.StartNew(() => { backgroundWorkerHeapSort.RunWorkerAsync(); }, atp);
                                                Task.Factory.StartNew(() => { backgroundWorkerBubbleSort2.RunWorkerAsync(); }, atp);
                                            });
                                        }
                                    }
                                }
                            }
                        }
                        else if (checkBoxStep.Checked == true)
                        {
                            if (ListSapXep.SelectedIndex == -1)
                            {
                                MessageBox.Show("Bạn chưa chọn thuật toán sắp xếp.");
                            }


                            btNext.Visible = true;
                            btNext.Enabled = true;
                            isave = 0;
                            jsave = 0;
                            frm.Text = frm.Text + " " + ListSapXep.Text;
                            btTao.Enabled = false;// ẩn nút Tạo trong quá trình chạy

                        }
                    }
                }
            }
            
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //

        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void Dichuyen(int vt1, int vt2)
        {
            // btsapxep.Enabled = false;
            Mn[vt1].BackColor = Color.Blue;
            Mn[vt2].BackColor = Color.Blue;
            System.Threading.Thread.Sleep(400 - iSpeed);
            string x;
            x = string.Copy(Mn[vt1].Text);
            Mn[vt1].Text = string.Copy(Mn[vt2].Text);
            Mn[vt2].Text = x;
            Mn[vt1].BackColor = Color.Red;
            Mn[vt2].BackColor = Color.Red;

            //btsapxep.Enabled = true;
        }
        private void Dichuyen2(int vt1, int vt2)
        {
            // btsapxep.Enabled = false;
            Mn2[vt1].BackColor = Color.Blue;
            Mn2[vt2].BackColor = Color.Blue;
            System.Threading.Thread.Sleep(400 - iSpeed);
            string x;
            x = string.Copy(Mn2[vt1].Text);
            Mn2[vt1].Text = string.Copy(Mn2[vt2].Text);
            Mn2[vt2].Text = x;
            Mn2[vt1].BackColor = Color.Red;
            Mn2[vt2].BackColor = Color.Red;

            //btsapxep.Enabled = true;
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeSort(M); 
        }
        
        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            InsertionSort(M);
        }
        private void backgroundWorker3_DoWork_1(object sender, DoWorkEventArgs e)
        {
            BubbleSort(M);
        }
        private void backgroundWorker4_DoWork(object sender, DoWorkEventArgs e)
        {
            SelectionSort(M);
        }       
        
        private void backgroundWorker5_DoWork(object sender, DoWorkEventArgs e)
        {
            HeapSort(M);
        }
        private void backgroundWorker6_DoWork(object sender, DoWorkEventArgs e)
        {
            QuickSort(M, 0, M.Length - 1);
        }
        private void backgroundWorker7_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeSort2(M,ref isave, jsave);
        }      
        private void backgroundWorker8_DoWork(object sender, DoWorkEventArgs e)
        {
            InsertionSort2(M,  isave, jsave); 
            
        }
        private void backgroundWorker9_DoWork(object sender, DoWorkEventArgs e)
        {
            QuickSort2(M, isave, jsave);
        }
        private void backgroundWorker10_DoWork(object sender, DoWorkEventArgs e)
        {
            SelectionSort2(M, isave, jsave);
        }
        private void backgroundWorker11_DoWork(object sender, DoWorkEventArgs e)
        {
            HeapSort2(M, isave, jsave);
        }
        private void backgroundWorker12_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort2(M, isave, jsave);
        }
        private void backgroundWorker13_DoWork(object sender, DoWorkEventArgs e)
        {
            InterchangeSort3(M2);
        }

        private void backgroundWorker14_DoWork(object sender, DoWorkEventArgs e)
        {
            InsertionSort3(M2);
        }

        private void backgroundWorker15_DoWork(object sender, DoWorkEventArgs e)
        {
            QuickSort3(M2, 0, M2.Length - 1);
        }

        private void backgroundWorker16_DoWork(object sender, DoWorkEventArgs e)
        {
            SelectionSort3(M2);
        }

        private void backgroundWorker17_DoWork(object sender, DoWorkEventArgs e)
        {
            BubbleSort3(M2);
        }

        private void backgroundWorker18_DoWork(object sender, DoWorkEventArgs e)
        {
            HeapSort3(M2);
        }


        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //


        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //

        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void InterchangeSort(int[] M)
        {
            int i, j;
            trangthai tt = new trangthai();
            for (i = 0; i < M.Length - 1; i++)
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {

                        int tam = M[i];
                        M[i] = M[j];
                        M[j] = tam;
                        iSoBuoc = iSoBuoc + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang = sMang + M[k].ToString() + " ";
                        }
                        frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, "InterchangeSort");
                        sMang = "";
                        System.Threading.Thread.Sleep(400 - iSpeed); // delay để xem button di chuyển                                               
                        Dichuyen(j, i);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                    }

                }
        }
        
        private void InterchangeSort3(int[] M)
        {
            int i, j;
            trangthai tt = new trangthai();
            for (i = 0; i < M.Length - 1; i++)
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {

                        int tam = M[i];
                        M[i] = M[j];
                        M[j] = tam;
                        iSoBuoc2 = iSoBuoc2 + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang2 = sMang2 + M[k].ToString() + " ";
                        }
                        frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang2, "InterchangeSort");
                        sMang2 = "";
                        System.Threading.Thread.Sleep(400 - iSpeed); // delay để xem button di chuyển                                               
                        Dichuyen2(j, i);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                    }

                }
        }
        private void InterchangeSort2(int[] M, ref int isave, int jsave)
        {
            int i, j;
            trangthai tt = new trangthai();
            for (i = isave; i < M.Length - 1; i++)
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[i] > M[j])
                    {

                        int tam = M[i];
                        M[i] = M[j];
                        M[j] = tam;
                        iSoBuoc = iSoBuoc + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang = sMang + M[k].ToString() + " ";
                        }
                        frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, "InterchangeSort");
                        sMang = "";
                        System.Threading.Thread.Sleep(400 - iSpeed); // delay để xem button di chuyển                                               
                        Dichuyen(j, i);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                        isave = i;
                        i = M.Length + 5;
                    }

                }
        }
        //
        //
        //
        //
        //
        //
        private void InsertionSort(int[] M)
        {
            trangthai tt = new trangthai();
            int i, key, j;
            for (i = 1; i < M.Length; i++)
            {
                key = M[i];
                j = i - 1;


                while (j >= 0 && M[j] > key)
                {
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }
                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + (i + 1).ToString() + "," + (j + 1).ToString() + ")", sMang, "InserttionSort");
                    sMang = "";
                    Dichuyen(j + 1, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    M[j + 1] = M[j];
                    j = j - 1;
                }
                M[j + 1] = key;


            }
        }
        private void InsertionSort2(int[] M, int isave, int jsave)
        {
            trangthai tt = new trangthai();
            int i = isave + 1, key, j;
            while (i < M.Length)
            {

                key = M[i];
                j = i - 1;

                while (j >= jsave && M[j] > key && jsave >= 0)
                {
                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }
                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + (i + 1).ToString() + "," + (j + 1).ToString() + ")", sMang, "InserttionSort");
                    sMang = "";
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    if(M[j]>M[j+1])
                    {
                        Dichuyen(j + 1, j);
                    }
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    M[j + 1] = M[j];
                    j = j - 1;
                    jsave = jsave - 1;
                }
                M[j + 1] = key;
                i = i + 1;
                isave = i;

            }
        }
        private void InsertionSort3(int[] M)
        {
            trangthai tt = new trangthai();
            int i, key, j;
            for (i = 1; i < M.Length; i++)
            {
                key = M[i];
                j = i - 1;


                while (j >= 0 && M[j] > key)
                {
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    iSoBuoc2 = iSoBuoc2 + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang2 = sMang2 + M[k].ToString() + " ";
                    }
                    frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + (i + 1).ToString() + "," + (j + 1).ToString() + ")", sMang2, "InserttionSort");
                    sMang2 = "";
                    Dichuyen2(j + 1, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    M[j + 1] = M[j];
                    j = j - 1;
                }
                M[j + 1] = key;


            }
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void BubbleSort(int[] M)
        {
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M.Length - 1; j++)
                {
                    if (M[j] > M[j + 1])
                    {
                        int temp = M[j];
                        M[j] = M[j + 1];
                        M[j + 1] = temp;
                        iSoBuoc = iSoBuoc + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang = sMang + M[k].ToString() + " ";
                        }
                        frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, "BubbleSort");
                        sMang = "";
                        System.Threading.Thread.Sleep(400 - iSpeed);
                        Dichuyen(j, j + 1);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                    }
                }
            }
        }
        private void BubbleSort2(int[] M,int isave, int jsave)
        {
           
                for (int j = jsave; j < M.Length - 1; j++)
                {
                    if (M[j] > M[j + 1])
                    {
                        int temp = M[j];
                        M[j] = M[j + 1];
                        M[j + 1] = temp;
                        iSoBuoc = iSoBuoc + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang = sMang + M[k].ToString() + " ";
                        }
                        frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + isave.ToString() + "," + j.ToString() + ")", sMang, "BubbleSort");
                        sMang = "";
                        System.Threading.Thread.Sleep(400 - iSpeed);
                        Dichuyen(j, j + 1);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                        j = j + 1;
                        jsave = j;
                        j = M.Length + 5;
                        if(M.Length == jsave)
                        {
                            jsave = 0;
                        }
                        
                    }
                
            }
        }
        private void BubbleSort3(int[] M)
        {
            for (int i = 0; i < M.Length; i++)
            {
                for (int j = 0; j < M.Length - 1; j++)
                {
                    if (M[j] > M[j + 1])
                    {
                        int temp = M[j];
                        M[j] = M[j + 1];
                        M[j + 1] = temp;
                        iSoBuoc2 = iSoBuoc2 + 1;
                        for (int k = 0; k < M.Length; k++)
                        {
                            sMang2 = sMang2 + M[k].ToString() + " ";
                        }
                        frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang2, "BubbleSort");
                        sMang2 = "";
                        System.Threading.Thread.Sleep(400 - iSpeed);
                        Dichuyen2(j, j + 1);
                        System.Threading.Thread.Sleep(400 - iSpeed);
                    }
                }
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void SelectionSort(int[] M)
        {
            trangthai tt = new trangthai();
            int i, j, min;

            for (i = 0; i < M.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[j] < M[min])
                        min = j;
                }
                if (M[min] == M[i]) { }
                else
                {
                    int temp = M[min];
                    M[min] = M[i];
                    M[i] = temp;
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }

                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, " SelectionSort");
                    sMang = "";
                    Dichuyen(min, i);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                }
            }
        }
        private void SelectionSort2(int[] M, int isave, int jsave)
        {
            trangthai tt = new trangthai();
            int i, j, min;

            for (i = isave; i < M.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[j] < M[min])
                        min = j;
                }
                if (M[min] == M[i]) { }
                else
                {
                    int temp = M[min];
                    M[min] = M[i];
                    M[i] = temp;
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }

                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, " SelectionSort");
                    sMang = "";
                    Dichuyen(min, i);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    isave = i;
                    i = M.Length + 5;
                }
            }
        }
        private void SelectionSort3(int[] M)
        {
            trangthai tt = new trangthai();
            int i, j, min;

            for (i = 0; i < M.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < M.Length; j++)
                {
                    if (M[j] < M[min])
                        min = j;
                }
                if (M[min] == M[i]) { }
                else
                {
                    int temp = M[min];
                    M[min] = M[i];
                    M[i] = temp;
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    iSoBuoc2 = iSoBuoc2 + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang2 = sMang2 + M[k].ToString() + " ";
                    }

                    frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang2, " SelectionSort");
                    sMang2 = "";
                    Dichuyen2(min, i);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                }
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void HeapSort(int[] M)
        {
            for (int i = M.Length / 2 - 1; i >= 0; i--)
                heapify(M, M.Length, i);
            for (int i = M.Length - 1; i >= 0; i--)
            {
                int temp = M[0];
                M[0] = M[i];
                M[i] = temp;
                System.Threading.Thread.Sleep(400 - iSpeed);
                Dichuyen(0, i);
                System.Threading.Thread.Sleep(400 - iSpeed);
                heapify(M, i, 0);
            }
        }
        private void heapify(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                iSoBuoc = iSoBuoc + 1;
                for (int k = 0; k < M.Length; k++)
                {
                    sMang = sMang + M[k].ToString() + " ";
                }
                frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + largest.ToString() + ")", sMang, "HeapSort");
                sMang = "";
                System.Threading.Thread.Sleep(400 - iSpeed);
                Dichuyen(i, largest);
                System.Threading.Thread.Sleep(400 - iSpeed);
                heapify(arr, n, largest);
            }
        }
        private void HeapSort2(int[] M, int isave, int jsave)
        {
            int i = M.Length / 2 - 1 - isave;
            if (i >= 0)
            {
                heapify2(M, M.Length, i);
                isave = isave + 1;
            }
            else
            {
                int j = M.Length - 1 - jsave;
                if (j >= 0)
                {
                    int temp = M[0];
                    M[0] = M[j];
                    M[j] = temp;
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    Dichuyen(0, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    heapify2(M, j, 0);
                    jsave = jsave + 1;
                }
                else
                {
                    isave = 0;
                    jsave = 0;
                }
            }
        }
        private void heapify2(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                iSoBuoc = iSoBuoc + 1;
                for (int k = 0; k < M.Length; k++)
                {
                    sMang = sMang + M[k].ToString() + " ";
                }
                frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + largest.ToString() + ")", sMang, "HeapSort");
                sMang = "";
                System.Threading.Thread.Sleep(400 - iSpeed);
                Dichuyen(i, largest);
                System.Threading.Thread.Sleep(400 - iSpeed);
                heapify2(arr, n, largest);
            }
        }
        private void HeapSort3(int[] M2)
        {
            for (int i = M2.Length / 2 - 1; i >= 0; i--)
                heapify3(M2, M2.Length, i);
            for (int i = M2.Length - 1; i >= 0; i--)
            {
                int temp = M2[0];
                M2[0] = M2[i];
                M2[i] = temp;
                System.Threading.Thread.Sleep(400 - iSpeed);
                Dichuyen2(0, i);
                System.Threading.Thread.Sleep(400 - iSpeed);
                heapify3(M2, i, 0);
            }
        }
        private void heapify3(int[] arr, int n, int i)
        {
            int largest = i;
            int left = 2 * i + 1;
            int right = 2 * i + 2;
            if (left < n && arr[left] > arr[largest])
                largest = left;
            if (right < n && arr[right] > arr[largest])
                largest = right;
            if (largest != i)
            {
                int swap = arr[i];
                arr[i] = arr[largest];
                arr[largest] = swap;
                iSoBuoc2 = iSoBuoc2 + 1;
                for (int k = 0; k < M2.Length; k++)
                {
                    sMang2 = sMang2 + M2[k].ToString() + " ";
                }
                frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + i.ToString() + "," + largest.ToString() + ")", sMang2, "HeapSort");
                sMang2 = "";
                System.Threading.Thread.Sleep(400 - iSpeed);
                Dichuyen2(i, largest);
                System.Threading.Thread.Sleep(400 - iSpeed);
                heapify3(arr, n, largest);
            }
        }
        //
        //
        //
        //
        //
        //
        //
        //
        private void QuickSort(int[] M, int dau, int cuoi)
        {
            int i, j, tam, mid;
            mid = M[(dau + cuoi) / 2];
            i = dau;
            j = cuoi;
            do
            {
                while (M[i] < mid)
                {
                    i++;
                }
                while (M[j] > mid)
                {
                    j--;
                }
                if (i <= j)
                {
                    tam = M[i];
                    M[i] = M[j];
                    M[j] = tam;
                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }
                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, "QuickSort");
                    sMang = "";
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    Dichuyen(i, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    i++;
                    j--;
                }
            } while (i < j);
            if (dau < j)
                QuickSort(M, dau, j);
            if (i < cuoi)
                QuickSort(M, i, cuoi);
        }
        private void QuickSort2(int[] M, int isave, int jsave)
        {
            int i, j, tam, mid;
            mid = M[(isave + jsave) / 2];
            i = isave;
            j = jsave;
            do
            {
                while (M[i] < mid)
                {
                    i++;
                }
                while (M[j] > mid)
                {
                    j--;
                }
                if (i <= j)
                {
                    tam = M[i];
                    M[i] = M[j];
                    M[j] = tam;
                    iSoBuoc = iSoBuoc + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang = sMang + M[k].ToString() + " ";
                    }
                    frm.dataGridView1.Rows.Add(iSoBuoc.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang, "QuickSort");
                    sMang = "";
                    System.Threading.Thread.Sleep(400 - iSpeed);
                    Dichuyen(i, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    i++;
                    isave = i;
                    j--;
                    jsave = j;
                }
            } while (i < j);
            if (isave < j)
                QuickSort(M, isave, j);
            if (i < jsave)
                QuickSort(M, i, jsave);
        }
     
        private void QuickSort3(int[] M2, int dau, int cuoi)
        {
            int i, j, tam, mid;
            mid = M2[(dau + cuoi) / 2];
            i = dau;
            j = cuoi;
            do
            {
                while (M2[i] < mid)
                {
                    i++;
                }
                while (M2[j] > mid)
                {
                    j--;
                }
                if (i <= j)
                {
                    tam = M2[i];
                    M2[i] = M2[j];
                    M2[j] = tam;
                    iSoBuoc2 = iSoBuoc2 + 1;
                    for (int k = 0; k < M.Length; k++)
                    {
                        sMang2 = sMang2 + M2[k].ToString() + " ";
                    }
                    frm2.dataGridView1.Rows.Add(iSoBuoc2.ToString(), "(" + i.ToString() + "," + j.ToString() + ")", sMang2, "QuickSort");
                    sMang2 = "";
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    Dichuyen2(i, j);
                    System.Threading.Thread.Sleep(400 - iSpeed);

                    i++;
                    j--;
                }
            } while (i < j);
            if (dau < j)
                QuickSort3(M2, dau, j);
            if (i < cuoi)
                QuickSort3(M2, i, cuoi);
        }

        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void btHistory2_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        
        private void backgroundWorker1_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach(Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }    
        }

        private void backgroundWorker2_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker3_RunWorkerCompleted_1(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker4_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker5_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker6_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker13_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }


        private void backgroundWorker14_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker15_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker16_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

      
        private void backgroundWorker18_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }

        private void backgroundWorker17_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            foreach (Button bt in Mn2)
            {
                bt.BackColor = Color.Black;
                bt.ForeColor = Color.White;
            }
        }




        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        //
        private void hScrollBar1_ValueChanged(object sender, EventArgs e)
        {
            if (Chon1ThuatToan.Checked == true)
            {
                Mn[0].Location = new Point(-hScrollBar1.Value*2 + 40, 20);
                for (int i = 1; i < int.Parse(txNhap.Text); i++)
                {
                    Mn[i].Location = new Point(Mn[i - 1].Location.X + 80, 20);
                }
            }
            else if(Chon2ThuatToan.Checked == true)
            {
                Mn[0].Location = new Point(-hScrollBar1.Value*2 + 80, 20);
                Mn2[0].Location = new Point(-hScrollBar1.Value*2 + 80, Mn[0].Height + 60);
                for (int i = 1; i < int.Parse(txNhap.Text); i++)
                {
                    Mn[i].Location = new Point(Mn[i - 1].Location.X + Mn[i-1].Width + 40, 20);
                    Mn2[i].Location = new Point(Mn2[i - 1].Location.X + Mn2[i-1].Width + 40, Mn[i].Height + 60);

                }
            }    
        }    
    }
}


