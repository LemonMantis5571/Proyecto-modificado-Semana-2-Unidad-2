using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Conversor_de_Unidades_de_Longitud
{
    class cLongitudes
    {
        public double mts_cms(double valor)
        {
            return valor * 100;
        }

        public double mts_mili(double valor)
        {
            return valor * 1000;
        }

        public double cms_mts(double valor)
        {
            return valor / 100;
        }

        public double cms_mili(double valor)
        {
            return valor * 10;
        }

        public double mili_cms(double valor)
        {
            return valor / 10;
        }

        public double mili_mts(double valor)
        {
            return valor / 1000;
        }

        public double km_mts(double valor)
        {
            return valor * 1000;
        }

        public double km_cms(double valor)
        {
            return valor * 100000;
        }

        public double km_mili(double valor)
        {
            return valor * 1000000;
        }

        public double mts_km(double valor)
        {
            return valor / 1000;
        }

        public double cms_km(double valor)
        {
            return valor / 100000;
        }

        public double mili_km(double valor)
        {
            return valor / 1000000;
        }
    }
}

