namespace Battaglia_navale
{
    internal class Partita
    {
        private const int dimensione = 6;
        public int nNavi = 0;

        public Campo campo = new Campo(dimensione, Campo.PlayerType.Io);
        public Campo campoAvversario = new Campo(dimensione, Campo.PlayerType.Nemico);

        private Giocatore g1;
        private Giocatore g2;

        public Giocatore[] giocatori = new Giocatore[2];

        public Partita(Giocatore g1, Giocatore g2)
        {
            this.g1 = g1;
            this.g2 = g2;

            giocatori[0] = g1;
            giocatori[1] = g2;

            g1.creaNaviPosizionabili(dimensione);
            g2.creaNaviPosizionabili(dimensione);
            nNavi = g1.navi.Count;
        }
    }
}