using System.Windows;
using jiami;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace 华戍序列号管理端
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (txtCode.Text.Length < 8)
                    throw new System.Exception();

                if (LicenseFile.p())
                    LicenseFile.VerifyPass(txtCode.Text);

                if (txtCode.Text.Length==8)
                {
                    txtPassCode.Text = LicenseFile.EncryptComX(txtCode.Text).Substring(0, 8).ToLower();

                    LicenseFile.Parse();
                    Interaction.MsgBox("客户授权码及License已生成！请将该授权码告知用户。", MsgBoxStyle.OkOnly, null);
                }
                else
                {
                    Interaction.MsgBox("特征码有误，请重新输入或联系客户。", MsgBoxStyle.OkOnly, null);
                }
            }
            catch
            {
                Interaction.MsgBox("程序执行异常。", MsgBoxStyle.OkOnly, null);
            }

        }

        private void txtCode_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {

            if (!string.IsNullOrEmpty(txtCode.Text))
            {
                btnOK.IsEnabled = true;
            }
            else
                btnOK.IsEnabled = false;
        }
    }
}
