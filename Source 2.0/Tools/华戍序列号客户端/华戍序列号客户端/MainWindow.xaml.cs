using System.Windows;
using jiami;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;

namespace 华戍序列号客户端
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            this.textInfo.Text = LicenseFile.GetDiskVolumeSerialNumber().ToString();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (textPWD.Text.Length < 8)
                    throw new System.Exception();

                if (LicenseFile.p())
                    LicenseFile.VerifyPass(textPWD.Text);

                if (LicenseFile.pt==(textPWD.Text.ToLower()))
                {
                    LicenseFile.Parse();
                    Interaction.MsgBox("您的License已生成，请关闭窗口。", MsgBoxStyle.OkOnly, null);
                    Environment.Exit(0);
                }
                else
                {
                    Interaction.MsgBox("您的验证码有误，请重新输入或联系华戍防务。", MsgBoxStyle.OkOnly, null);
                }
            }
            catch
            {
                Interaction.MsgBox("您的验证码有误，请重新输入或联系华戍防务。", MsgBoxStyle.OkOnly, null);
            }

        }

        private void textPWD_TextChanged(object sender, System.Windows.Controls.TextChangedEventArgs e)
        {
            if (textPWD.Text.Length == textInfo.Text.Length)
            { }

            if (!string.IsNullOrEmpty(textPWD.Text))
            {
                btnOK.IsEnabled = true;
            }
            else
                btnOK.IsEnabled = false;
        }
    }
}
