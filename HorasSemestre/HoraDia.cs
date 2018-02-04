using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HorasSemestre
{
    public class HoraDia
    {
        decimal horas;
        DayOfWeek dia;
        public DayOfWeek Dia { get { return dia; } set { dia = value; } }
        public decimal Horas { get { return horas; } set { horas = value; } }
    }
}
