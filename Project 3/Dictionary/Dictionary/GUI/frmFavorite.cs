using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpeechLib;
using Dictionary.DataAccess;
using Dictionary.Business;

namespace Dictionary.GUI
{
    public partial class frmFavorite : Form
    {
        //Properties
        MyData myFavoriteData;
        private bool isChange = false;
        int numberFavorite;
        //Constructor
        public frmFavorite()
        {
            InitializeComponent();
            myFavoriteData = new MyData();
            myFavoriteData.myDictionary.myHashTable.InitHashTable();
            myFavoriteData.LoadData("Favorite.txt");
            numberFavorite = myFavoriteData.myDictionary.LoadDataToCombobox(cbWord);
        }
        //Hàm tìm kiếm một từ
        private Node Search()
        {
            Node sub = myFavoriteData.myDictionary.SearchDictionary(cbWord.Text);
            if (sub != null)
            {
                txbExplaination.Text = sub.value;
            }
            return sub;
        }
        //Hàm xử lý sự kiện khi nhấn button thoát, sẽ lưu lại dữ liệu người dùng
        private void frmFavorite_FormClosing(object sender, FormClosingEventArgs e)
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
        //Hàm phát âm một từ tiếng Anh
        private void btnSpeakEnglish_Click(object sender, EventArgs e)
        {
            SpVoice phatam = new SpVoice();
            phatam.Speak(cbWord.Text, SpeechVoiceSpeakFlags.SVSFDefault);
        }

        //Hàm xóa một từ điển
        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa từ này", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                isChange = true;
                myFavoriteData.myDictionary.RemoveDictionary(cbWord.Text);
                numberFavorite = myFavoriteData.myDictionary.LoadDataToCombobox(cbWord);
            }
        }
        //Hàm xử lý sự kiện thay đổi cbWord english, sẽ tìm kiếm nghĩa tiếng việt tương ứng
        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWord.DataSource == null)
            {
                return;
            }
            Search();
        }
        //Hàm xử lý sự kiện khi nhấn button luyện tập
        private void btnLearn_Click(object sender, EventArgs e)
        {
            if (numberFavorite < 5)
            {
                MessageBox.Show("Mục yêu thích cần có 5 từ trở lên", "Thông báo");
            }
            else
            {
                if (isChange)
                {
                    myFavoriteData.myDictionary.BackUp("Favorite.txt");
                    isChange = false;
                }
                frmLearn frmLearn = new frmLearn();
                frmLearn.ShowDialog();
                this.Show();
            }
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
