using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HorasSemestre
{
    public class HoraSemana
    {
        public List<HoraDia> dias = new List<HoraDia>();
        public List<DateTime> diaTrabalho = new List<DateTime>();
        public int[] horarioMensal = new int[12];
        public string[] diaMensal = new string[12];

        public HoraSemana()
        {
            return;
        }

        public void AddDia(DayOfWeek day, decimal hour)
        {
            HoraDia days = new HoraDia()
            {
                Dia = day,
                Horas = hour
            };
            dias.Add(days);
        }

        public void CheckHorasTrabalho() {
            foreach (DateTime dt in diaTrabalho) {
                HoraDia hd = dias.Find(horaDia => horaDia.Dia == dt.DayOfWeek);
                if (dt.DayOfWeek == hd.Dia) {
                    int month = dt.Month - 1;
                    diaMensal[month] += dt.Day + ", ";
                    horarioMensal[month] += (int)hd.Horas;
                }
            }
        }

    }
}
