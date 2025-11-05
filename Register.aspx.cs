using System;
using System.Web.UI;

namespace POISLab2
{
    public partial class Register : Page
    {
        protected void Page_PreInit(object sender, EventArgs e)
        {
            string master = Session["MasterPage"] as string ?? "~/Site1.Master";
            this.MasterPageFile = master;
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                lblCurrentMaster.Text = "Текущая мастер-страница: " + System.IO.Path.GetFileNameWithoutExtension(MasterPageFile);
            }
        }

        protected void btnSwitchTheme_Click(object sender, EventArgs e)
        {
            string current = Session["MasterPage"] as string ?? "~/Site1.Master";
            string newMaster = current == "~/Site1.Master" ? "~/Site2.Master" : "~/Site1.Master";
            Session["MasterPage"] = newMaster;

            Response.Redirect(Request.RawUrl);
        }

        protected void ddlThemes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Session["MasterPage"] = ddlThemes.SelectedValue;

            Response.Redirect(Request.RawUrl);
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