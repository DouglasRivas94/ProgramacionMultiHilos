using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploWinThread
{
    public partial class FrmThread : Form
    {
        private Thread hilo1, hilo2, hilo3;
        delegate void delegado(ProgressBar progressBar, int value);
        public FrmThread()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            hilo1 = new Thread(new ParameterizedThreadStart(Proceso));
            hilo2 = new Thread(new ParameterizedThreadStart(Proceso));
            hilo3 = new Thread(new ParameterizedThreadStart(Proceso));

            hilo1.Start(new { ProgressBar = pb1, Delay = 70 });
            hilo2.Start(new {ProgressBar = pb2, Delay = 40});
            hilo3.Start(new {ProgressBar = pb3, Delay = 100});
        }

        private void Proceso(object? obj)
        {
            if (obj is not { } param) return;
            var pb = param.GetType().GetProperty("ProgressBar")?.GetValue(param) as ProgressBar;
            var delay = (int?)param.GetType().GetProperty("Delay")?.GetValue(param) ?? 0;

            if(pb == null || delay <= 0) return;

            for (int i = 0; i <= 100; i++)
            {
                //delegado MD = new delegado(ActualizarProgreso);
                //Invoke(MD, new object[] {pb, i});
                Invoke(new Action(() => pb.Value = i));
                Thread.Sleep(delay);
            }
        }

        private void ActualizarProgreso(ProgressBar pb, int value)
        {
            pb.Value = value;
        }
    }
}
