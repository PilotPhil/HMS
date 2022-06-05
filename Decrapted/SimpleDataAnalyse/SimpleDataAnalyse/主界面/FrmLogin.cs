using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace SimpleDataAnalyse
{
    public partial class FrmLogin : MetroForm
    {
        Dictionary<string, string> LOGIN = new Dictionary<string, string>();

        public FrmLogin()
        {
            InitializeComponent();

            LOGIN.Add("209010076","226613");
            LOGIN.Add("test", "test");
        }

        private bool CheckLogin(string user,string password)
        {
            string pass;
            if (LOGIN.TryGetValue(user, out pass) == false)
                return false;
            else
                if (pass == password)
                    return true;
                else
                    return false;
        }

        private void button_calcelLogin_Click(object sender, EventArgs e)//取消登录
        {
            this.DialogResult = DialogResult.Cancel;
        }

        //检验
        private void button_checkLogin_Click(object sender, EventArgs e)
        {
            string user = txb_userName.Text.Trim();
            string pass = txb_password.Text.Trim();

            if(CheckLogin(user, pass)==true)
                this.DialogResult = DialogResult.OK;
            
        }
    }
}
