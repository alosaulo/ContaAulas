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
        public string StringfyDias() {
            string aux = "";
            foreach (HoraDia s in dias) {
                aux += s.Dia + " ";
                aux += s.Horas + " ";
                aux += " -- ";
            }
            return aux;
        }
        public string StringfyDiaTrabalho()
        {
            string aux = "";
            foreach (DateTime s in diaTrabalho)
            {
                HoraDia hd = dias.Find(horaDia => horaDia.Dia == s.DayOfWeek);
                if (s.DayOfWeek == hd.Dia) {
                    for(int i = 0; i < hd.Horas; i++) { 
                        aux += s.ToShortDateString();
                        aux += "\n";
                    }
                }
            }
            return aux;
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

        public string StringfyHorasTrabalho() {
            string output = "";
            int total = 0;
            for (int i = 0; i < horarioMensal.Length; i++)
            {
                if (horarioMensal[i] != 0)
                {
                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i+1);
                    output += strMonthName + " "+diaMensal[i]+" / " + horarioMensal[i] + " horas \n";
                    total += horarioMensal[i];
                }
            }
            output += "total: " + total;
            return output;
        }

    }
    public class HoraDia {
        decimal horas;
        DayOfWeek dia;
        public DayOfWeek Dia { get { return dia; } set { dia = value; } }
        public decimal Horas { get { return horas; } set { horas = value; } }
    }
}
