using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using SpeechLib;
using System.Text.RegularExpressions;
using Dictionary.DataAccess;
using Dictionary.Business;

namespace Dictionary.GUI
{
    public partial class frmMain : Form
    {
        //Properties
        MyData myDictionaryData;
        MyData myFavoriteData;
        private bool isExist = false;
        private bool isChange = false;
        //Constructor
        public frmMain()
        {
            InitializeComponent();
            myDictionaryData = new MyData();
            myDictionaryData.myDictionary.myHashTable.InitHashTable();
            myDictionaryData.LoadData("DataEV.txt");
            myFavoriteData = new MyData();
            myFavoriteData.myDictionary.myHashTable.InitHashTable();
            myFavoriteData.LoadData("Favorite.txt");

        }
        //Method
        //Hàm tìm kiếm một từ
        private Node Search()
        {
            Node sub = myDictionaryData.myDictionary.SearchDictionary(txbEng.Text.ToLower().Trim());
            if (sub == null)
            {
                lbNotify.Text = "Không tìm thấy kết quả";
                picSearch.Visible = true;
            }
            else
            {
                txbViet.Text = sub.value;
                lbNotify.Text = "";
                picSearch.Visible = false;
            }
            return sub;
        }
        //Hàm xử lý sự kiện khi nhấn button thoát, sẽ lưu lại dữ liệu người dùng
        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChange)
            {
                myFavoriteData.myDictionary.BackUp("Favorite.txt");
                isChange = false;
            }
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        //Hàm xử lý sự kiện thay đổi text box english, sẽ tìm kiếm nghĩa tiếng việt tương ứng
        private void txbEng_TextChanged(object sender, EventArgs e)
        {
            Regex regex = new Regex(@"^[a-zA-Z0-9_ ]+$");
            if (txbEng.Text == "")
            {
                txbViet.Text = "";
                lbNotify.Text = "Xin mời nhập dữ liệu";
                picSearch.Visible = false;
            }
            else if (!regex.IsMatch(txbEng.Text))
            {
                txbViet.Text = "";
                lbNotify.Text = "Không tìm thấy kết quả";
                picSearch.Visible = true;
            }
            else
            {
                Search();
            }
        }
        //Hàm xử lý sự kiện nhấn thêm từ sẽ hiện ra button lưu
        private void btnAdd_Click(object sender, EventArgs e)
        {
            btnSave.Visible = true;
            this.ActiveControl = txbViet;
        }
        //Hàm thêm một từ,  nếu từ đã tồn tại, người dùng có thể thay đổi nội dung
        private void Add()
        {
            picSearch.Visible = true;
            if (isExist)
            {
                myFavoriteData.myDictionary.ChangeDictionary(txbEng.Text.ToLower().Trim(), txbViet.Text);
                lbNotify.Text = "Lưu thay đổi thành công";
                isExist = false;
            }
            else
            {
                bool flag = myFavoriteData.myDictionary.AddDictionary(txbEng.Text.ToLower().Trim(), txbViet.Text);               
                if (flag == false)
                    lbNotify.Text = "Thêm vào không thành công";
                else
                    lbNotify.Text = "Thêm vào thành công";
            }
        }
        //Hàm xử lý sự kiện nhất button lưu
        private void btnSave_Click(object sender, EventArgs e)
        {
            bool flag = false;
            if (txbEng.Text.Trim() == "")
                MessageBox.Show("Không được để trống từ cần dịch", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                Node sub = myFavoriteData.myDictionary.SearchDictionary(txbEng.Text.ToLower().Trim());
                if (sub != null)
                {
                    if (MessageBox.Show("Từ này đã tồn tại bạn có muốn thay đổi nội dung không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        isExist = true;
                        flag = true;
                    }
                    else
                    {
                        txbViet.Text = sub.value;
                        flag = false;
                    }
                }
                else
                    flag = true;
            }
            if (flag)
            {
                isChange = true;
                Add();
            }
            btnSave.Visible = false;
        }
        //Hàm xử lý sự kiện txbViet thay đổi
        private void txbViet_TextChanged(object sender, EventArgs e)
        {
            btnSave.Visible = true;
        }
        //Hàm xử lý sự kiện khi nhấn button danh mục yêu thích
        private void btnFavorite_Click(object sender, EventArgs e)
        {
            if (isChange)
            {
                myFavoriteData.myDictionary.BackUp("Favorite.txt");
                isChange = false;
            }
            frmFavorite frmFavorite = new frmFavorite();
            frmFavorite.ShowDialog();
            myFavoriteData.myDictionary = new MyDictionary();
            myFavoriteData.myDictionary.myHashTable.InitHashTable();
            myFavoriteData.LoadData("Favorite.txt");
            this.Show();
        }
        //Hàm phát âm một từ tiếng Anh
        private void btnSpeakE_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(txbEng.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        //Hàm xử lý sự kiện khi nhấn vào các button thì button sẽ đổi màu
        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Lime;
        }
        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.PaleGreen;
        }
    }
}
