using RDA.TaskSQLite._4.Model;
using System;
using System.Collections.Generic;
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

namespace RDA.TaskSQLite._4.View.UserControls
{
    /// <summary>
    /// Логика взаимодействия для LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : UserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var Login = TbLogin.Text;
                var UID = PbUid.Password;
                using (UserDataContext db = new UserDataContext())
                {
                    bool userFound = db.Users.Any(u => u.Login == Login && u.UID == Uid);
                    if (userFound)
                    {
                        MessageBox.Show("Успешная авторизация",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Information); 
                    }
                    else
                    {
                        MessageBox.Show("Ошибка данных",
                            "Системное сообщение",
                            MessageBoxButton.OK,
                            MessageBoxImage.Error
                            );
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),
                    "Системное сообщение",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
               
            }
        }
    }
}
