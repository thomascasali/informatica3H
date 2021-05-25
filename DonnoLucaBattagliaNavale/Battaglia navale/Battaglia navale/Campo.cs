using System;

namespace Battaglia_navale
{
    public class Campo
    {
        public enum CellType
        {
            Mare, Buco, Colpito, Affondato, Barca
        }

        public enum PlayerType
        {
            Io, Nemico
        }

        public PlayerType PT;

        public CellType[,] campoIDs;

        public readonly int dimensione;
        public Campo(int dimensione, PlayerType PT)
        {
            this.dimensione = dimensione;
            this.PT = PT;
            creaCampoIDs();
        }

        public void creaCampoIDs()
        {
            campoIDs = new CellType[dimensione, dimensione];

            for (var i = 0; i < dimensione; i++)
            {
                for (var j = 0; j < dimensione; j++)
                {
                    campoIDs[i, j] = CellType.Mare;
                }
            }
        }
        public bool ciSta(Nave n, int x, int y)
        {
            if (n.orientamento == Nave.Orientamento.Verticale)
            {
                for (int i = x; i < x + n.dimensione; i++)
                {
                    try
                    {
                        if (campoIDs[i, y] != CellType.Mare) return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return true;
            }
            else
            {
                for (int i = y; i < y + n.dimensione; i++)
                {
                    try
                    {
                        if (campoIDs[x, i] != CellType.Mare) return false;
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
                return true;
            }
        }
        public bool InserisciNave(Nave naveSelezionata, int x, int y)
        {
            if (!ciSta(naveSelezionata, x, y)) return false;
            if (naveSelezionata.orientamento == Nave.Orientamento.Verticale)
            {
                for (int i = x; i < x + naveSelezionata.dimensione; i++)
                {
                    campoIDs[i, y] = CellType.Barca;
                }
            }
            else
            {
                for (int i = y; i < y + naveSelezionata.dimensione; i++)
                {
                    campoIDs[x, i] = CellType.Barca;
                }
            }

            return true;

        }
        public void AssegnaColpo(int i, int j)
        {
            switch (campoIDs[i, j])
            {
                case CellType.Mare:
                    campoIDs[i, j] = CellType.Buco;
                    break;
                case CellType.Barca:
                    campoIDs[i, j] = CellType.Colpito;
                    break;
            }
        }
    }
}
