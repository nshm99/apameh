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
using System.Windows.Shapes;

namespace DBProject
{
    /// <summary>
    /// Interaction logic for BFactorDetail.xaml
    /// </summary>
    public partial class BFactorDetail : Window
    {
        public bFactor_info factor;
        public BFactorDetail(bFactor_info val)
        {
            factor = val;
            InitializeComponent();
            product.Text = factor.product;
            count.Text = factor.count.ToString();
            price.Text = factor.price.ToString();
            stage.Text = factor.stage;
            provider.Text = factor.provider;
            admin.Text = factor.admin;
            date.Text = factor.date;
            
        }
    }
}
