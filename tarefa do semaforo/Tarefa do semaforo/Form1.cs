using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarefa_do_semaforo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private Semaforo sem = new Semaforo();
        void atualizar()
        {
            int rua1 = sem.getEstado(1), rua2 = sem.getEstado(2);

            if (rua1 == rua2)
            {
                switch (rua2)
                {
                    case 1:
                        sem.setVermelho(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
                        rdb21.Checked = true;
                        break;
                    case 2:
                        sem.setVerde(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
                        rdb23.Checked = true;
                        break;
                    case 3:
                        sem.setAmarelo(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_amarelo;
                        rdb22.Checked = true;
                        break;
                }
            }
            else 
            {
                switch (rua1)
                {
                    case 1:
                        sem.setVermelho(1);
                        PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
                        rdb11.Checked = true;
                        break;
                    case 2:
                        sem.setVerde(1);
                        PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
                        rdb13.Checked = true;
                        break;
                    case 3:
                        sem.setAmarelo(1);
                        PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_amarelo;
                        rdb12.Checked = true;
                        break;
                }

                switch (rua2)
                {
                    case 1:
                        sem.setVermelho(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
                        rdb21.Checked = true;
                        break;
                    case 2:
                        sem.setVerde(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
                        rdb23.Checked = true;
                        break;
                    case 3:
                        sem.setAmarelo(2);
                        PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_amarelo;
                        rdb22.Checked = true;
                        break;
                }
            }
        }
        private void MudançaEstado(object sender, EventArgs e)
        {
            int sinal;
            RadioButton remetente = (RadioButton)sender;
            sinal = int.Parse(remetente.Tag.ToString());
            switch (sinal)
            {
                case 1:
                    sem.setVermelho(1);
                    PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
                    break;
                case 2:
                    sem.setAmarelo(1);
                    PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_amarelo;
              
                    break;
                case 3:
                    sem.setVerde(1);
                    PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
                    break;
                case 4:
                    sem.setVermelho(2);
                    PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
                    break;
                case 5:
                    sem.setAmarelo(2);
                    PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_amarelo;

                    break;
                case 6:
                    sem.setVerde(2);
                    PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PRua1.Image = Tarefa_do_semaforo.Properties.Resources.sinal_verde;
            PRua2.Image = Tarefa_do_semaforo.Properties.Resources.sinal_vermelho;
            rdb13.Checked = true;
            rdb21.Checked = true;
        }

        private void rdbon_CheckedChanged(object sender, EventArgs e)
        {
            auto.Enabled = true;
        }

        private void rdbof_CheckedChanged(object sender, EventArgs e)
        {
            auto.Enabled = false;
        }

        private void auto_Tick(object sender, EventArgs e)
        {
            atualizar();
        }
    }
}
