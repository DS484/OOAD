using Hotel_Management.Constants;
using Hotel_Management.DAO;
using Hotel_Management.DTO;
using Hotel_Management.HandleData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_Management
{
    public partial class FSignUp : Form
    {
        private string? firstName;
        private string? lastName;
        private int gender;
        private string? image;
        private int managerId;
        private int hotelId;

        private ManagerDAO managerDAO = new ManagerDAO();
        private HotelDAO hotelDAO = new HotelDAO();

        private DataInputCheck dic = new DataInputCheck();

        public FSignUp()
        {
            InitializeComponent();
        }

        public FSignUp(string managerName, string managerIdCard, string managerPhone,
            int mangerGender, string userName, string passWord, string passWord2, string hotelVoucher,
            string hotelName, string hotelAddress, string hotelCity, string hotelImg, string review, int managerId, int hotelId)
        {
            InitializeComponent();
            this.managerId = managerId;
            this.hotelId = hotelId;


            lblTopic.Text = "Chỉnh sửa thông tin";
            lblTopic.Font = new Font("Segoe UI", 18, FontStyle.Bold | FontStyle.Italic);
            lblTopic.ForeColor = Color.Green;

            HidePassWord();

            txtFullName.Texts = managerName;
            txtIdentifyCard.Texts = managerIdCard;
            txtPhoneNumber.Texts = managerPhone;
            if (mangerGender == 0)
            {
                cbbGender.SelectedIndex = 0;
            }
            else cbbGender.SelectedIndex = 1;
            txtUserName.Texts = userName;
            txtPassword.Texts = passWord;
            txtConfirmPassword.Texts = passWord2;
            txtVoucher.Texts = hotelVoucher;
            txtHotel.Texts = hotelName;
            txtAddress.Texts = hotelAddress;
            cbbCity.SelectedItem = hotelCity;
            txtReview.Texts = review;

            string workingDirectory = Environment.CurrentDirectory;
            string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
            image = projectDirectory + @"\" + hotelImg.ToString();
            picboxHotel.ImageLocation = image;
        }

        private void HidePassWord()
        {
            pbPassWord.Visible = false;
            pbConfirmPassWord.Visible = false;
            lblPassWord.Visible = false;
            lblConfirmPassWord.Visible = false;
            txtPassword.Visible = false;
            txtConfirmPassword.Visible = false;
            btnComplete.Visible = false;
        }

        private bool CheckNullOrEmpty()
        {
            string[] input = { txtFullName.Texts, txtUserName.Texts, txtPhoneNumber.Texts, txtIdentifyCard.Texts, txtPassword.Texts, txtConfirmPassword.Texts, 
                txtVoucher.Texts, txtHotel.Texts, txtAddress.Texts, txtReview.Texts, txtLatitude.Texts, txtLongitude.Texts};
            foreach (string s in input)
            {
                if (string.IsNullOrEmpty(s))
                {
                    MessageBox.Show("Hãy nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            if (!dic.CheckPhoneNumber(txtPhoneNumber.Texts))
            {
                MessageBox.Show("Số điện thoại không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!dic.CheckIdentifyCard(txtIdentifyCard.Texts))
            {
                MessageBox.Show("Số căn cước công dân không hợp lệ!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            string[] fullName = txtFullName.Texts.Split(' ');
            firstName = fullName[fullName.Length - 1];
            lastName = "";
            for (int i = 0; i < fullName.Length - 1; i++)
            {
                if (i == fullName.Length - 2)
                {
                    lastName += fullName[i];
                }
                else
                {
                    lastName += fullName[i] + " ";
                }
            }
            if (cbbGender.SelectedItem == null)
            {
                gender = (int)Gender.MALE;
            }
            else
            {
                if (cbbGender.SelectedItem.ToString() == "Nam")
                {
                    gender = (int)Gender.MALE;
                }
                else
                {
                    gender = (int)Gender.FEMALE;
                }
            }
            return true;
        }

        private bool CheckExist()
        {
            bool checkExist = false;
            if (dic.checkUserDataExist("identify_card", txtIdentifyCard.Texts))
            {
                checkExist = true;
                MessageBox.Show("ID này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentifyCard.Focus();

            }
            if (dic.checkUserDataExist("phone_number", txtPhoneNumber.Texts))
            {
                checkExist = true;
                MessageBox.Show("Số điện thoại này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
            }
            if (dic.checkUserDataExist("username", txtUserName.Texts))
            {
                checkExist = true;
                MessageBox.Show("Tên đăng nhập này đã tồn tại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
            }
            if (dic.checkHotelDataExist(new string[] { txtHotel.Texts, txtAddress.Texts, cbbCity.Texts }))
            {
                checkExist = true;
                MessageBox.Show("Khách sạn này đã được đăng ký!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtHotel.Focus();
            }
            return checkExist;
        }

        private void btnCpmplete_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckNullOrEmpty())
                    return;
                Manager c = new Manager(firstName!, lastName!,
                gender, txtUserName.Texts, txtIdentifyCard.Texts,
                txtPhoneNumber.Texts, (int)Role.MANAGER, txtPassword.Texts);

                bool checkExist = CheckExist();

                bool inserted = false;
                if (!checkExist)
                    inserted = managerDAO.Insert(c);
                if (inserted)
                {
                    string workingDirectory = Environment.CurrentDirectory;
                    string projectDirectory = Directory.GetParent(workingDirectory)!.Parent!.Parent!.FullName;
                    string[] lstDir = picboxHotel.ImageLocation.ToString().Split(@"\");
                    string fileName = @"Image\" + lstDir[lstDir.Length - 1];
                    //

                    Hotel hotel = new Hotel(txtHotel.Texts, txtAddress.Texts, cbbCity.Texts, fileName, txtVoucher.Texts, txtReview.Texts, Convert.ToInt32(cbbStar.Texts), float.Parse(txtLatitude.Texts), float.Parse(txtLongitude.Texts));
                    bool addHotel = hotelDAO.Insert(hotel);
                    if (addHotel)
                    {
                        hotelDAO.InsertHotelManager();
                        MessageBox.Show("Đăng kí thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        FSignIn fSignIn = new FSignIn();
                        fSignIn.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Đã có lỗi xảy ra!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Lỗi!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            txtFullName.Texts = "";
            txtIdentifyCard.Texts = "";
            txtPhoneNumber.Texts = "";
            txtUserName.Texts = "";
            txtPassword.Texts = "";
            txtConfirmPassword.Texts = "";
        }

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            string imageLocation = "";
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.jpg; *.png)|*.jpg; *.png";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imageLocation = openFileDialog.FileName;
                    picboxHotel.ImageLocation = imageLocation;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void btnEditInfo_Click(object sender, EventArgs e)
        {
            if (!CheckNullOrEmpty())
                return;
            Manager oldManger = managerDAO.GetInfor(managerId);
            List<string> fieldsUpdate = new List<string>();
            if (!dic.CheckDuplicateField("users", "identify_card", oldManger.IdentifyCard, txtIdentifyCard.Texts))
                fieldsUpdate.Add("identify_card");
            else
            {
                MessageBox.Show("Đã tồn tại CCCD này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIdentifyCard.Focus();
                return;
            }
            if (!dic.CheckDuplicateField("users", "phone_number", oldManger.PhoneNumber, txtPhoneNumber.Texts))
                fieldsUpdate.Add("phone_number");
            else
            {
                MessageBox.Show("Đã tồn tại số điện thoại này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPhoneNumber.Focus();
                return;
            }

            Hotel oldHotel = hotelDAO.GetHotel(hotelId);
            if (dic.CheckDuplicateField("hotels", "hotel_name", oldHotel.HotelName, txtHotel.Texts)
                && dic.CheckDuplicateField("hotels", "address", oldHotel.Address, txtAddress.Texts)
                && dic.CheckDuplicateField("hotels", "city", oldHotel.City, cbbCity.Texts))
            {
                MessageBox.Show("Đã tồn tại thông tin khách sạn này", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                fieldsUpdate.Add("hotel_name");
                fieldsUpdate.Add("address");
                fieldsUpdate.Add("city");
            }

            Manager manager = new Manager(managerId, firstName!, lastName!,
            gender, txtUserName.Texts, txtIdentifyCard.Texts,
            txtPhoneNumber.Texts, (int)Role.MANAGER, txtPassword.Texts);

            string[] lst = picboxHotel.ImageLocation.ToString().Split(@"\");
            string hotelImg = "Image" + @"\" + lst[lst.Length - 1];
            Hotel hotel = new Hotel(hotelId, txtHotel.Texts, txtAddress.Texts, cbbCity.Texts, hotelImg, txtVoucher.Texts, txtReview.Texts, Convert.ToInt32(cbbStar.SelectedItem));
            bool editedManager = managerDAO.Update(manager);
            bool editedHotel = hotelDAO.Update(hotel);
            if (editedHotel && editedManager)
            {
                this.Close();
                MessageBox.Show("Sửa thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Có lỗi xảy ra!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }
    }
}
