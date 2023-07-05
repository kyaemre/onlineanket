using onlineanket.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace onlineanket.BL
{
    public static class BLogic
    {
        public static bool Ogretmenekle(teachers t)
        {
            try
            {
                int res = DataLayer.ogretmenekle(t);
                return (res > 0);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }
        internal static DataSet Ogretmengetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Ogretmengetir(filtre);
                return ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
              
        }

        internal static bool OgretmenGuncelle(teachers t)
        {
            try
            {
                int res = DataLayer.OgretmenGuncelle(t);
                return (res > 0);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static bool OgretmenSil(string id)
        {
            try
            {
                int res = DataLayer.OgretmenSil(id);
                return (res > 0);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

     



        //ÖĞRENCi

        internal static bool Ogrecinekle(students o)
        {
            try
            {
                int res = DataLayer.ogrenciekle(o);
                return (res > 0);
            }


            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu:" + ex.Message);
                return false;
            }
        }

        internal static DataSet Ogrencigetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.Ogrencigetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool Ogrecinekle(teachers student)
        {
            throw new NotImplementedException();
        }
    }
    
}



