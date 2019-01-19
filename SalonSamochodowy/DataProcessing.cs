using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalonSamochodowy
{
    public class DataProcessing
    {
        public Samochod PobierzSamochodZNajwiekszymWyposazeniem(List<Samochod> samochody)
        {
            Samochod wynik = samochody.OrderByDescending(s => s.ListaWyposazenia.Count).First();
           // Samochod wynik =
               //return (from Samochod s in samochody
               //          where s.ListaWyposazenia.Max()
               //          select s);
            return wynik;
        }

        public Samochod PobierzSamochodNajdrozszy(List<Samochod> samochody)
        {
            return null;
        }

        public List<Samochod> PosortujPoCenie(List<Samochod> samochody)
        {
            return null;
        }

        public bool CzyMaWyposazenie(Samochod s, Wyposazenie w)
        {
            return false;
        }

        public List<Samochod> PobierzSamochodyZWyposazeniem(List<Samochod> samochody, Wyposazenie w)
        {
            return null;
        }
    }
}
