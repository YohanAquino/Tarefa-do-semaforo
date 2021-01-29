using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarefa_do_semaforo
{
	class Semaforo
	{
		private byte posicao;
        #region construtor
        public Semaforo()
		{
			this.posicao = 129;
		}
		#endregion

		#region set e get

		public void setVermelho(int rua)
		{
			int apagar, set;
			apagar = 489 - 241 * rua;
			set = rua * 124 - 120;
			this.posicao = (byte)((int)this.posicao & apagar);
			this.posicao = (byte)((int)this.posicao | set);
		}
		public void setAmarelo(int rua)
		{
			int apagar, set;
			apagar = 489 - 241 * rua;
			set = rua * 62 - 60;
			this.posicao = (byte)((int)this.posicao & apagar);
			this.posicao = (byte)((int)this.posicao | set);
		}
		public void setVerde(int rua)
		{
			int apagar, set;
			apagar = 489 - 241 * rua;
			set = rua * 31 - 30;
			this.posicao = (byte)((int)this.posicao & apagar);
			this.posicao = (byte)((int)this.posicao | set);
		}


		public byte getEstado()
		{
			return this.posicao;
		}

		public int getEstado(int rua)
		{
			int posicao=0,valor = rua * 31 - 30;

	        for (int i = 0; i <= 2; i++)
			{
				double x = Math.Pow(2, i);
			   if (((int)this.posicao&(byte)(x * valor)) == (x * valor))
				{
					posicao = i + 1;
					break;
				}
			}
			return posicao;
		}
        #endregion
    }
}
