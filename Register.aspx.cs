using System;
using System.Web.UI;

namespace POISLab2
{
    public partial class Register : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblMessage.Text = "";
            lblResult.Text = "";

            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text;
            string confirm = txtConfirm.Text;
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                lblMessage.Text = "Все поля должны быть заполнены!";
                return;
            }

            if (password != confirm)
            {
                lblMessage.Text = "Пароли не совпадают!";
                return;
            }


            lblResult.ForeColor = System.Drawing.Color.Green;
            lblResult.Text = $"Пользователь {username} успешно зарегистрирован!";
        }
    }
}