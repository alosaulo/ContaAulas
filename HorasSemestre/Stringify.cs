using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasSemestre
{
    class Stringify
    {
        HoraSemana horaSemana;

        public Stringify(HoraSemana horaSemana) {
            this.horaSemana = horaSemana;
        }

        public string StringifyDiaTrabalho()
        {
            string aux = "";
            foreach (DateTime s in horaSemana.diaTrabalho)
            {
                HoraDia hd = horaSemana.dias.Find(horaDia => horaDia.Dia == s.DayOfWeek);
                if (s.DayOfWeek == hd.Dia)
                {
                    for (int i = 0; i < hd.Horas; i++)
                    {
                        aux += s.ToShortDateString();
                        aux += "\n";
                    }
                }
            }
            return aux;
        }

        public string StringifyHorasTrabalho()
        {
            string output = "";
            int total = 0;
            for (int i = 0; i < horaSemana.horarioMensal.Length; i++)
            {
                if (horaSemana.horarioMensal[i] != 0)
                {
                    string strMonthName = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(i + 1);
                    output += strMonthName + " " + horaSemana.diaMensal[i] + " / " + horaSemana.horarioMensal[i] + " horas \n";
                    total += horaSemana.horarioMensal[i];
                }
            }
            output += "total: " + total;
            return output;
        }

        public string StringifyDias()
        {
            string aux = "";
            foreach (HoraDia s in horaSemana.dias)
            {
                aux += s.Dia + " ";
                aux += s.Horas + " ";
                aux += " -- ";
            }
            return aux;
        }

    }
}
