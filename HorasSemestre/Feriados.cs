using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HorasSemestre
{
    class Feriados
    {
        public BindingList<DateTime> ferias = new BindingList<DateTime>();
        public Feriados() {
            CultureInfo culture = new CultureInfo("pt-BR");
            Thread.CurrentThread.CurrentCulture = culture;
            ferias.Add(new DateTime(2017, 01, 01));
            ferias.Add(new DateTime(2017, 02, 27));
            ferias.Add(new DateTime(2017, 02, 28));
            ferias.Add(new DateTime(2017, 03, 01));
            ferias.Add(new DateTime(2017, 04, 13));
            ferias.Add(new DateTime(2017, 04, 14));
            ferias.Add(new DateTime(2017, 04, 21));
            ferias.Add(new DateTime(2017, 04, 24));
            ferias.Add(new DateTime(2017, 05, 01));
            ferias.Add(new DateTime(2017, 05, 23));
            ferias.Add(new DateTime(2017, 06, 15));
            ferias.Add(new DateTime(2017, 06, 16));
            ferias.Add(new DateTime(2017, 09, 07));
            ferias.Add(new DateTime(2017, 10, 12));
            ferias.Add(new DateTime(2017, 10, 13));
            ferias.Add(new DateTime(2017, 10, 15));
            ferias.Add(new DateTime(2017, 11, 02));
            ferias.Add(new DateTime(2017, 11, 15));
            ferias.Add(new DateTime(2017, 12, 25));
        }

        public void AddFeriado(DateTime data) {
            ferias.Add(data);
        }

        public void RemoveFeriado(DateTime data)
        {
            ferias.Remove(data);
        }

    }
}
