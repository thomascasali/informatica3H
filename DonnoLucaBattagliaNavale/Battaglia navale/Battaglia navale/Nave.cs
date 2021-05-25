using System;

namespace Battaglia_navale
{
    public class Nave
    {
        public int dimensione;

        private CellType[] nave;

        private enum CellType
        {
            Colpito, Affondato, Integra
        }

        public enum Orientamento
        {
            Verticale, Orizzontale
        }

        public enum Type
        {
            da2, da3, da4, da5
        }

        public Type type;

        public Orientamento orientamento;

        public Nave(Type type, Orientamento orientamento)
        {
            this.type = type;
            this.orientamento = orientamento;
            switch (this.type)
            {
                case Type.da2:
                    dimensione = 2;
                    break;
                case Type.da3:
                    dimensione = 3;
                    break;
                case Type.da4:
                    dimensione = 4;
                    break;
                case Type.da5:
                    dimensione = 5;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            nave = new CellType[dimensione];
            for (var i = 0; i < nave.Length; i++)
            {
                nave[i] = CellType.Integra;
            }
        }

        public void setOrientamento(Orientamento o)
        {
            orientamento = o;
        }

        public void toggleOrientamento()
        {
            orientamento = orientamento == Orientamento.Orizzontale ? Orientamento.Verticale : Orientamento.Orizzontale;
        }
    }
}
