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

namespace UserEventDemo
{
    /// <summary>
    /// Interaction logic for ShowView.xaml
    /// </summary>
    public partial class ShowView : UserControl
    {
        public ShowView()
        {
            InitializeComponent();
        }

        public void SetDetail(object sender, Person p)
        {
            DataContext = p;
        }

        internal void SetDetail(Person p)
        {
            DataContext = p;
        }
    }
}
