using System;
using System.Collections.Generic;

namespace Battaglia_navale
{
    class Giocatore
    {
        public string nome;
        private Nave nave;
        public List<Nave> navi = new List<Nave>();

        public Giocatore(string nome)
        {
            this.nome = nome;
        }
        public void InserisciNavi(Campo c)
        {
            int i = 0;
            int j = 0;
            foreach (Nave n in navi)
            {
                do
                {
                    var rnd = new Random();
                    i = rnd.Next(c.dimensione);
                    j = rnd.Next(c.dimensione);
                    if (rnd.Next(2) == 1)
                    {
                        n.orientamento = Nave.Orientamento.Verticale;
                    }
                } while (!c.InserisciNave(n, i, j));


            }
        }

        public void creaNaviPosizionabili(int dimensione)
        {
            nave = new Nave(Nave.Type.da5, Nave.Orientamento.Orizzontale);
            for (var i = 0; i < dimensione / 5; i++)
            {
                navi.Add(nave);
            }

            nave = new Nave(Nave.Type.da4, Nave.Orientamento.Orizzontale);
            for (var i = 0; i < dimensione / 5; i++)
            {
                navi.Add(nave);
            }

            nave = new Nave(Nave.Type.da3, Nave.Orientamento.Orizzontale);
            for (var i = 0; i < dimensione / 5; i++)
            {
                navi.Add(nave);
            }

            nave = new Nave(Nave.Type.da2, Nave.Orientamento.Orizzontale);
            for (var i = 0; i < (dimensione * 2) / 5; i++)
            {
                navi.Add(nave);
            }

        }
    }
}
