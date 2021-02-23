using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dictionary.DataAccess;
using Dictionary.Business;

namespace Dictionary.GUI
{
    public partial class frmLearn : Form
    {
        //Properties
        MyData myFavoriteData;
        string temp;
        public frmLearn()
        {
            InitializeComponent();
            myFavoriteData = new MyData();
            myFavoriteData.myDictionary.myHashTable.InitHashTable();
            myFavoriteData.LoadData("Favorite.txt");
            myFavoriteData.myDictionary.LoadDataToCombobox(cbWord);
        }
        //Hàm tìm kiếm một từ
        private Node Search()
        {
            Node sub = myFavoriteData.myDictionary.SearchDictionary(cbWord.Text);
            int i = 0;
            temp ="";
            int len = sub.value.Length;
            Random r = new Random();
            if (sub != null)
            {
                while (sub.value[i] != '-')
                {
                    i++;
                }

                if (sub.value[i] == '-')
                {
                    i++;
                    int check = 1;
                    while (check==1 && i<len)
                    {
                        if(sub.value[i] != '=' && sub.value[i] != '*' && (sub.value[i] != '-'||sub.value[i+1]!=' ')) 
                        {
                            temp = temp + sub.value[i];
                            i++;
                        }
                        else
                        {
                            check = 0;
                        }
                       
                    }
                }
                int h = r.Next(1, 4);
                if(h == 1)
                {
                    rbA.Text = temp;
                    myFavoriteData.myDictionary.LoadDataToRadioButton(rbB, rbC, rbD,sub.value);
                }
                else if (h == 2)
                {
                    rbB.Text = temp;
                    myFavoriteData.myDictionary.LoadDataToRadioButton(rbA, rbC, rbD, sub.value);
                }
                else if (h == 3)
                {
                    rbC.Text = temp;
                    myFavoriteData.myDictionary.LoadDataToRadioButton(rbB, rbA, rbD, sub.value);
                }
                else
                {
                    rbD.Text = temp;
                    myFavoriteData.myDictionary.LoadDataToRadioButton(rbB, rbC, rbA, sub.value);
                }

            }
            return sub;
        }
        //Hàm xử lý sự kiện khi nhấn button thoát
        private void frmLearn_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát", "Thông báo", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        //Hàm xử lý sự kiện thay đổi cbWord english, sẽ tìm kiếm nghĩa tiếng việt tương ứng
        private void cbWord_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbWord.DataSource == null)
            {
                return;
            }
            rbA.Checked = false;
            rbB.Checked = false;
            rbC.Checked = false;
            rbD.Checked = false;
            Search();
        }
        //Hàm kiểm tra sự chính xác của phương án được chọn
        private void check(string text)
        {
            if (text == temp)
            {
                MessageBox.Show("Phương án bạn chọn là chính xác.", "Thông báo");
            }
            else
            {
                MessageBox.Show("Phương án bạn chọn là không chính xác.", "Thông báo");
            }
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if (rbA.Checked == true)
            {
                check(rbA.Text);
            }
            else if (rbB.Checked == true)
            {
                check(rbB.Text);
            }
            else if (rbC.Checked == true)
            {
                check(rbC.Text);
            }
            else if (rbD.Checked == true)
            {
                check(rbD.Text);
            }
            else
            {
                MessageBox.Show("Bạn chưa chọn câu trả lời của mình.", "Thông báo");
            }
        }
        //Hàm xử lý sự kiện khi nhấn vào các button thì button sẽ đổi màu
        private void button1_MouseHover(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Lime;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.PaleGreen;
        }

    }
}
