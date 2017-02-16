using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HorasSemestre
{
    public partial class MainForm : Form
    {
        HoraSemana horasSemanais = new HoraSemana();
        Feriados feriado = new Feriados();
        DateTime startModule = new DateTime();
        DateTime endModule = new DateTime();


        public MainForm()
        {
            InitializeComponent();
            listFeriados.DataSource = feriado.ferias;
        }

        public void CheckHoras() {
            if (nmSeg.Value > 0) {
                horasSemanais.AddDia(DayOfWeek.Monday, nmSeg.Value);
            }
            if (nmTer.Value > 0)
            {
                horasSemanais.AddDia(DayOfWeek.Tuesday, nmTer.Value);
            }
            if (nmQua.Value > 0)
            {
                horasSemanais.AddDia(DayOfWeek.Wednesday, nmQua.Value);
            }
            if (nmQui.Value > 0)
            {
                horasSemanais.AddDia(DayOfWeek.Thursday, nmQui.Value);
            }
            if (nmSex.Value > 0)
            {
                horasSemanais.AddDia(DayOfWeek.Friday, nmSex.Value);
            }
        }

        private void DoTheMath() {
            startModule = dateTimeStart.Value;
            endModule = dateTimeEnd.Value;
            while (startModule.Date != endModule.Date) {
                bool containsDia = horasSemanais.dias.Any(horaDia => horaDia.Dia == startModule.DayOfWeek);
                bool containsHolly = feriado.ferias.Contains(startModule);
                if (containsDia && !containsHolly)
                {
                    horasSemanais.diaTrabalho.Add(startModule.Date);
                }
                startModule = startModule.AddDays(1);
            }
        }



        private void btnCalcular_Click(object sender, EventArgs e)
        {
            ClearAll();
            CheckHoras();
            DoTheMath();
            horasSemanais.CheckHorasTrabalho();
            txtOutput.Text += horasSemanais.StringfyDiaTrabalho();
            txtAulasMes.Text += horasSemanais.StringfyHorasTrabalho();
        }

        private void btnAddicionarFerias_Click(object sender, EventArgs e)
        {
            DateTime data = calendarioFerias.SelectionRange.Start;
            feriado.AddFeriado(data);
            listFeriados.DataSource = feriado.ferias;
            listFeriados.Refresh();
        }

        private void btnRemoverFerias_Click(object sender, EventArgs e)
        {
            if (feriado.ferias.Count > 0) { 
                DateTime data = (DateTime)listFeriados.SelectedItem;
                feriado.RemoveFeriado(data);
                listFeriados.DataSource = feriado.ferias;
                listFeriados.Refresh();
            }
        }

        private void ClearAll() {
            horasSemanais = new HoraSemana();
            feriado = new Feriados();
            startModule = new DateTime();
            endModule = new DateTime();
            listFeriados.DataSource = feriado.ferias;
            txtOutput.Text = "";
            txtAulasMes.Text = "";
        }

    }
}
