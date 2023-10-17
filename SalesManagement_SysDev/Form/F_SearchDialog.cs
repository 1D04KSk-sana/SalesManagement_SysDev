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
    public partial class F_SearchDialog : Form
    {
        // 子フォームのボタンクリックイベントを定義
        public event EventHandler btnOrSearchClick;
        public event EventHandler btnAndSearchClick;

        public F_SearchDialog()
        {
            InitializeComponent();

            //btnAndSearchのクリックイベントを設定
            btnAndSearch.Click += (sender, e) => btnAndSearchClick?.Invoke(this, e);

            //btnOrSearchのクリックイベントを設定
            btnOrSearch.Click += (sender, e) => btnOrSearchClick?.Invoke(this, e);
        }
    }
}
