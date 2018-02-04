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
            ferias.Add(new DateTime(2018, 02, 12));
            ferias.Add(new DateTime(2018, 02, 13));
            ferias.Add(new DateTime(2018, 02, 14));
            ferias.Add(new DateTime(2018, 03, 29));
            ferias.Add(new DateTime(2018, 03, 30));
            ferias.Add(new DateTime(2018, 04, 09));
            ferias.Add(new DateTime(2018, 04, 30));
            ferias.Add(new DateTime(2018, 05, 01));
            ferias.Add(new DateTime(2018, 05, 23));
            ferias.Add(new DateTime(2018, 05, 31));
            ferias.Add(new DateTime(2018, 06, 01));
            ferias.Add(new DateTime(2018, 09, 07));
            ferias.Add(new DateTime(2018, 10, 12));
            ferias.Add(new DateTime(2018, 10, 15));
            ferias.Add(new DateTime(2018, 11, 02));
            ferias.Add(new DateTime(2018, 10, 15));

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
