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

namespace Halı_Saha_Yönetim.PageScreens
{
    
    public partial class ReservationAttempt : Page
    {
        db_halisahayonetimEntities db = new db_halisahayonetimEntities();
        public ReservationAttempt()
        {
            InitializeComponent();           

            var sahalar = db.tbl_saha.ToList();
           
            foreach (var s in sahalar)
            {
                cmbSaha.Items.Add(s.ID);
            }
           
        }
        private void CmbSaha_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var deger = Convert.ToInt32(cmbSaha.SelectedItem.ToString());
            var saha = db.tbl_saha.Where(y => y.ID == deger).FirstOrDefault();
            sahaadi.Content = "Sahanın adı: " + saha.SAHA_ADI;
            sahafiyat.Content = saha.FIYAT;
            sahakapasite.Content = "Sahanın kapasitesi: " + saha.KAPASITE;
        }
        string tarih = "";
        private void Tarih_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            var picker = sender as DatePicker;
            DateTime? date = picker.SelectedDate;
            tarih = date.Value.ToShortDateString();
        }

        private void BtnSaveResAttempt_Click(object sender, RoutedEventArgs e)
        {
            if (cmbSaat.SelectedItem == null || cmbSaha.SelectedItem == null)
            {
                MessageBox.Show("Bilgileri Eksiksiz Girdinize Emin olun.");
            }
            else
            {
                tbl_rezervasyon rez = new tbl_rezervasyon();
                var deger=cmbSaha.SelectedItem.ToString();
                rez.SAHA_ID = int.Parse(deger);
                rez.REZERVASYON_TARIH = tarih;
                rez.REZERVASYON_SAAT = cmbSaat.Text;
                rez.NOT = note.Text;
                rez.DURUM = true;
                db.tbl_rezervasyon.Add(rez);
                db.SaveChanges();
                MessageBox.Show("Rezervasyon Başarıyle Oluşturuldu");
            }
        }
    }
}
