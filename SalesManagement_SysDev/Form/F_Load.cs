using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement_SysDev
{
    public partial class F_Load : Form
    {
        public F_Load()
        {
            InitializeComponent();
        }

        //Splashフォーム
        private static F_Load _form = null;
        //メインフォーム
        private static Form _mainForm = null;
        //Splashを表示するスレッド
        private static System.Threading.Thread _thread = null;
        //lock用のオブジェクト
        private static readonly object syncObject = new object();
        //Splashが表示されるまで待機するための待機ハンドル
        private static System.Threading.ManualResetEvent splashShownEvent = null;

        /// <summary>
        /// Splashフォーム
        /// </summary>
        public static F_Load Form
        {
            get { return _form; }
        }

        /// <summary>
        /// Splashフォームを表示する
        /// </summary>
        /// <param name="mainForm">メインフォーム</param>
        public static void ShowSplash(Form mainForm)
        {
            lock (syncObject)
            {
                if (_form != null || _thread != null)
                {
                    return;
                }

                _mainForm = mainForm;
                //メインフォームのActivatedイベントでSplashフォームを消す
                if (_mainForm != null)
                {
                    _mainForm.Activated += new EventHandler(_mainForm_Activated);
                }

                //待機ハンドルの作成
                splashShownEvent = new System.Threading.ManualResetEvent(false);

                //スレッドの作成
                _thread = new System.Threading.Thread(
                    new System.Threading.ThreadStart(StartThread));
                _thread.Name = "SplashForm";
                _thread.IsBackground = true;
                _thread.SetApartmentState(System.Threading.ApartmentState.STA);
                //.NET Framework 1.1以前では、以下のようにする
                //_thread.ApartmentState = System.Threading.ApartmentState.STA;
                //スレッドの開始
                _thread.Start();
            }
        }

        /// <summary>
        /// Splashフォームを表示する
        /// </summary>
        public static void ShowSplash()
        {
            ShowSplash(null);
        }

        /// <summary>
        /// Splashフォームを消す
        /// </summary>
        public static void CloseSplash()
        {
            lock (syncObject)
            {
                if (_thread == null)
                {
                    return;
                }

                if (_mainForm != null)
                {
                    _mainForm.Activated -= new EventHandler(_mainForm_Activated);
                }

                //Splashが表示されるまで待機する
                if (splashShownEvent != null)
                {
                    splashShownEvent.WaitOne();
                    splashShownEvent.Close();
                    splashShownEvent = null;
                }

                //Splashフォームを閉じる
                //Invokeが必要か調べる
                if (_form != null)
                {
                    if (_form.InvokeRequired)
                    {
                        _form.Invoke(new MethodInvoker(CloseSplashForm));
                    }
                    else
                    {
                        CloseSplashForm();
                    }
                }

                //メインフォームをアクティブにする
                if (_mainForm != null)
                {
                    if (_mainForm.InvokeRequired)
                    {
                        _mainForm.Invoke(new MethodInvoker(ActivateMainForm));
                    }
                    else
                    {
                        ActivateMainForm();
                    }
                }

                _form = null;
                _thread = null;
                _mainForm = null;
            }
        }

        //スレッドで開始するメソッド
        private static void StartThread()
        {
            //Splashフォームを作成
            _form = new F_Load();
            //Splashフォームをクリックして閉じられるようにする
            _form.Click += new EventHandler(_form_Click);
            //Splashが表示されるまでCloseSplashメソッドをブロックする
            _form.Activated += new EventHandler(_form_Activated);
            //Splashフォームを表示する
            Application.Run(_form);
        }

        //SplashのCloseメソッドを呼び出す
        private static void CloseSplashForm()
        {
            if (!_form.IsDisposed)
            {
                _form.Close();
            }
        }

        //メインフォームのActivateメソッドを呼び出す
        private static void ActivateMainForm()
        {
            if (!_mainForm.IsDisposed)
            {
                _mainForm.Activate();
            }
        }

        //Splashフォームがクリックされた時
        private static void _form_Click(object sender, EventArgs e)
        {
            //Splashフォームを閉じる
            CloseSplash();
        }

        //メインフォームがアクティブになった時
        private static void _mainForm_Activated(object sender, EventArgs e)
        {
            //Splashフォームを閉じる
            CloseSplash();
        }

        //Splashフォームが表示された時
        private static void _form_Activated(object sender, EventArgs e)
        {
            _form.Activated -= new EventHandler(_form_Activated);
            //CloseSplashメソッドの待機を解除
            if (splashShownEvent != null)
            {
                splashShownEvent.Set();
            }
        }

        private void F_Load_Load(object sender, EventArgs e)
        {
            // フォームの境界線、タイトルバーを無しに設定
            this.FormBorderStyle = FormBorderStyle.None;

            // フォームの背景を黒に設定
            this.BackColor = Color.Black;

            // フォームの不透明度を設定（半透明化）
            this.Opacity = 0.8;

            // 丸み値
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();

            float r = 50;
            float x = 0.0f;
            float y = 0.0f;
            float w = ClientSize.Width;
            float h = ClientSize.Height;

            gp.StartFigure();
            gp.AddArc(x, y, r, r, 180.0f, 90.0f);
            gp.AddArc(w - r, y, r, r, 270.0f, 90.0f);
            gp.AddArc(w - r, h - r, r, r, 0.0f, 90.0f);
            gp.AddArc(x, h - r, r, r, 90.0f, 90.0f);
            gp.CloseFigure();

            this.Region = new Region(gp);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Opacity = 0;
        }
    }
}
