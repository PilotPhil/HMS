using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using pilot.HMS.DataAccess;

namespace pilot.HMS.Views
{
    /// <summary>
    /// UserManagementView.xaml 的交互逻辑
    /// </summary>
    public partial class UserManagementView : Page
    {
        public DataTable UserData { get; set; }


        public UserManagementView()
        {
            InitializeComponent();

            
        }

        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Refresh(object sender, RoutedEventArgs e)
        {

            UserData=SqlServerDataAccess.GetInstance().GetUserInfo();

            this.userDataGrid.ItemsSource = UserData.DefaultView;
        }

        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Save(object sender, RoutedEventArgs e)
        {
            SqlServerDataAccess.GetInstance().Update2UserTable(this.UserData);
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Delete(object sender, RoutedEventArgs e)
        {
            if(this.userDataGrid.SelectedIndex<0)
            {

                return;
            }

            string userId2Delete = (string)UserData.Rows[this.userDataGrid.SelectedIndex][0];

            string deleteSql = "delete from users where user_id='" + userId2Delete + "';";

            SqlServerDataAccess.GetInstance().RunSql(deleteSql);
        }
    }
}
