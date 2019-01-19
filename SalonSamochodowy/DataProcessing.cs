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
            return wynik;
        }

        public Samochod PobierzSamochodNajdrozszy(List<Samochod> samochody)
        {
            Samochod wynik = samochody.OrderByDescending(s => s.CenaBazowa).First();
            return wynik;
        }

        public List<Samochod> PosortujPoCenie(List<Samochod> samochody)
        {
            List<Samochod> wynik = samochody.OrderBy(o=>o.CenaBazowa).ToList(); //OrderByDescending(s => s.CenaBazowa);
            return wynik;
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
