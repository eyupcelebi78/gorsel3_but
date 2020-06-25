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

namespace Halı_Saha_Yönetim
{
  
    public partial class ReservationShow : Page
    {
        db_halisahayonetimEntities db = new db_halisahayonetimEntities();
        public ReservationShow()
        {
            InitializeComponent();
            rezgrid.ItemsSource = db.tbl_rezervasyon.ToList();
        }
    }
}
