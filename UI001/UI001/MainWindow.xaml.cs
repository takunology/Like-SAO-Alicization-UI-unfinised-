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
using System.Media;
using System.Diagnostics;

namespace UI001
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
   
    public partial class MainWindow : Window
    {
       
        public MainWindow()
        {
            string soundpath = "F:/プログラミング/ProjectAlicization/UI001/WindowSE.wav";
            SoundPlayer sp = new SoundPlayer(soundpath);
            sp.Play();

            InitializeComponent();

            //PerformanceCounter pc = new PerformanceCounter();
            //pc.CategoryName = "";
            //pc.CounterName = "PrivateBytes";
            //pc.InstanceName = "Exprorer";



            //MessageBox.Show(pc.NextValue().ToString());

        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            //透明化したウィンドウの移動 
            if (e.ButtonState != MouseButtonState.Pressed) return;
            this.DragMove();
        }


        /*private async void Cpu (object sender, EventArgs e)
        {
            string machineName = ".";
            //カテゴリ名
            string categoryName = "Processor";
            //カウンタ名
            string counterName = "% Processor Time";
            //インスタンス名
            string instanceName = "_Total";

            //カテゴリが存在するか確かめる
            if (!System.Diagnostics.PerformanceCounterCategory.Exists(
                categoryName, machineName))
            {
                Console.WriteLine("登録されていないカテゴリです。");
                return;
            }

            //カウンタが存在するか確かめる
            if (!System.Diagnostics.PerformanceCounterCategory.CounterExists(
                counterName, categoryName, machineName))
            {
                Console.WriteLine("登録されていないカウンタです。");
                return;
            }

            //PerformanceCounterオブジェクトの作成
            System.Diagnostics.PerformanceCounter pc =
                new System.Diagnostics.PerformanceCounter(
                categoryName, counterName, instanceName, machineName);
            
            //1秒おきに値を取得する
            for (int i = 0; i < 10; i++) 
            {
                //計算された値を取得し、表示する
                await textBlock.Text = pc.NextValue().ToString();
                System.Threading.Thread.Sleep(1000);
            }


        }*/

 
    }


}
