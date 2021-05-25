using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Battaglia_navale
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            p = new Partita(new Giocatore("Donno"), new Giocatore("Pippi"));
            creaBtnCampo(p.campo, Campo.PlayerType.Io);
            creaBtnCampo(p.campoAvversario, Campo.PlayerType.Nemico);
            p.giocatori[1].InserisciNavi(p.campoAvversario);
            AggiornaBtnCampo(p.campoAvversario, Campo.PlayerType.Nemico);
        }

        private readonly Partita p;

        private void Form1_Load(object sender, EventArgs e)
        {
            StampaCampo(btnCampo, Campo.PlayerType.Io);
            StampaCampo(btnCampoAvversario, Campo.PlayerType.Nemico);
            StampaNaviPosizionabili();
        }

        public Button[,] btnCampo;
        public Button[,] btnCampoAvversario;
        private void AggiornaBtnCampo(Campo c, Campo.PlayerType pt)
        {
            for (int i = 0; i < c.dimensione; i++)
            {
                for (int j = 0; j < c.dimensione; j++)
                {
                    if (pt == Campo.PlayerType.Io)
                        btnCampo[i, j].Tag = c.campoIDs[i, j];
                    else
                    {
                        btnCampoAvversario[i, j].Tag = c.campoIDs[i, j];
                    }
                }
            }
        }

        public void creaBtnCampo(Campo c, Campo.PlayerType p)
        {
            if (p == Campo.PlayerType.Io)
                btnCampo = new Button[c.dimensione, c.dimensione];
            else
            {
                btnCampoAvversario = new Button[c.dimensione, c.dimensione];
            }

            var y = 30;

            for (var i = 0; i < c.dimensione; i++)
            {
                y += 25;
                var x = 30;
                for (var j = 0; j < c.dimensione; j++)
                {
                    x += 25;
                    var b = new Button
                    {
                        Bounds = new Rectangle(x, y, 25, 25),
                        FlatStyle = FlatStyle.Flat,
                        Tag = c.campoIDs[i, j],
                        TabStop = false,
                        FlatAppearance = { BorderSize = 1 },
                        Name = i + ";" + j
                    };

                    if (p == Campo.PlayerType.Io)
                        btnCampo[i, j] = b;
                    else
                    {
                        btnCampoAvversario[i, j] = b;
                    }
                }
            }
        }

        private void StampaCampo(Button[,] bmat, Campo.PlayerType pt)
        {
            foreach (var b in bmat)
            {
                switch ((Campo.CellType)(b.Tag))
                {
                    case Campo.CellType.Mare:
                        b.BackColor = Color.Blue;
                        break;
                    case Campo.CellType.Barca:
                        b.BackColor = Color.BurlyWood;
                        break;
                    case Campo.CellType.Buco:
                        b.BackColor = Color.DarkSeaGreen;
                        break;
                    case Campo.CellType.Colpito:
                        b.BackColor = Color.Firebrick;
                        break;
                    case Campo.CellType.Affondato:
                        b.BackColor = Color.DarkSlateGray;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                if (pt == Campo.PlayerType.Io)
                    gbCampo.Controls.Add(b);
                else
                {
                    gbAvversario.Controls.Add(b);
                }
            }
        }

        private void AggiornaCampo(Campo.PlayerType pt)
        {
            GroupBox gb;
            gb = pt == Campo.PlayerType.Io ? gbCampo : gbAvversario;

            foreach (var b in gb.Controls.OfType<Button>())
            {
                switch ((Campo.CellType)(b.Tag))
                {
                    case Campo.CellType.Mare:
                        b.BackColor = Color.Blue;
                        break;
                    case Campo.CellType.Barca:
                        b.BackColor = Color.BurlyWood;
                        break;
                    case Campo.CellType.Buco:
                        b.BackColor = Color.DarkBlue;
                        break;
                    case Campo.CellType.Colpito:
                        b.BackColor = Color.Firebrick;
                        break;
                    case Campo.CellType.Affondato:
                        b.BackColor = Color.DarkSlateGray;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }


            }


        }

        private void StampaNaviPosizionabili()
        {
            const int cellsize = 25;
            int x = 25;
            int y = 25;
            foreach (Nave n in p.giocatori[0].navi)
            {
                y += 30;
                var b = new Button
                {
                    Bounds = new Rectangle(x, y, cellsize * n.dimensione, 25),
                    FlatStyle = FlatStyle.Flat,
                    Tag = n
                };
                b.Click += BOnClick;
                gbNavi.Controls.Add(b);
            }
        }

        private Nave naveSelezionata;
        private bool naveHasBeenSelected;
        private void BOnClick(object sender, EventArgs eventArgs)
        {
            naveSelezionata = (Nave)(sender as Button)?.Tag;

            if (!naveHasBeenSelected)
                foreach (Button bCampo in gbCampo.Controls)
                {
                    bCampo.MouseEnter += BOnMouseEnter;
                    bCampo.Click += BCampo_Click;
                }

            naveHasBeenSelected = true;

            if (KeyPreview == false)
                this.KeyPress += Form1_KeyPress;
            this.KeyPreview = true;
        }

        private void BCampo_Click(object sender, EventArgs e)
        {



            naveHasBeenSelected = false;
            if (!p.campo.InserisciNave(naveSelezionata, x, y)) return;

            foreach (Button bCampo in gbCampo.Controls)
            {
                bCampo.MouseEnter -= BOnMouseEnter;
                bCampo.Click -= BCampo_Click;
            }
            gbNavi.Controls.Clear();
            p.giocatori[0].navi.Remove(naveSelezionata);
            naveSelezionata = null;
            StampaNaviPosizionabili();
            AggiornaBtnCampo(p.campo, Campo.PlayerType.Io);
            AggiornaCampo(Campo.PlayerType.Io);
            if (p.giocatori[0].navi.Count == 0)
            {
                InizioMatch();
                return;
            }
        }

        private void InizioMatch()
        {
            foreach (var btnAvversario in btnCampoAvversario)
            {
                btnAvversario.Click += BtnAvversario_Click;
            }


        }

        private void BtnAvversario_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            int i = Convert.ToInt32(b.Name.Split(';')[0]);
            int j = Convert.ToInt32(b.Name.Split(';')[1]);
            p.campoAvversario.AssegnaColpo(i, j);
            AggiornaBtnCampo(p.campoAvversario, Campo.PlayerType.Nemico);
            AggiornaCampo(Campo.PlayerType.Nemico);
            TurnoAvversario();
        }

        private void TurnoAvversario()
        {
            Random rnd = new Random();

            int i = 0;
            int j = 0;

            do
            {
                i = rnd.Next(p.campo.dimensione);
                j = rnd.Next(p.campo.dimensione);
            } while ((p.campo.campoIDs[i, j] == Campo.CellType.Buco || p.campo.campoIDs[i, j] == Campo.CellType.Colpito) && !(CheckVittoria(Campo.PlayerType.Io) && !CheckVittoria(Campo.PlayerType.Nemico)));

            p.campo.AssegnaColpo(i, j);
            AggiornaBtnCampo(p.campo, Campo.PlayerType.Io);
            AggiornaCampo(Campo.PlayerType.Io);
            if (CheckVittoria(Campo.PlayerType.Io) || CheckVittoria(Campo.PlayerType.Nemico))
            {
                label1.Visible = true;
                label1.Text = "Vinto";
                pictureBox1.Visible = true;

                var player = new System.Media.SoundPlayer { SoundLocation = "mom.wav" };

                player.Play();
            }

        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.ToLower(e.KeyChar) == 'r')
            {
                naveSelezionata.toggleOrientamento();
                AggiornaCampo(Campo.PlayerType.Io);
                StampaAntemprima();
            }
        }

        private int x;
        private int y;

        private void BOnMouseEnter(object sender, EventArgs eventArgs)
        {
            AggiornaCampo(Campo.PlayerType.Io);
            if (!(sender is Button b)) return;
            x = Convert.ToInt16(b.Name.Split(';')[0]);
            y = Convert.ToInt16(b.Name.Split(';')[1]);

            StampaAntemprima();


        }

        private void StampaAntemprima()
        {
            if (p.campo.ciSta(naveSelezionata, x, y))
            {
                if (naveSelezionata.orientamento == Nave.Orientamento.Verticale)
                {
                    for (int i = x; i < x + naveSelezionata.dimensione; i++)
                    {
                        btnCampo[i, y].BackColor = Color.AntiqueWhite;
                    }
                }
                else
                {
                    for (int i = y; i < y + naveSelezionata.dimensione; i++)
                    {
                        btnCampo[x, i].BackColor = Color.AntiqueWhite;
                    }
                }
            }
            else
            {
                if (naveSelezionata.orientamento == Nave.Orientamento.Verticale)
                {
                    try
                    {
                        for (int i = x; i < x + naveSelezionata.dimensione; i++)
                        {
                            btnCampo[i, y].BackColor = Color.DarkRed;
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
                else
                {
                    try
                    {
                        for (int i = y; i < y + naveSelezionata.dimensione; i++)
                        {
                            btnCampo[x, i].BackColor = Color.DarkRed;
                        }
                    }
                    catch (Exception)
                    {
                        // ignored
                    }
                }
            }
        }

        private bool CheckVittoria(Campo.PlayerType pt)
        {
            return pt == Campo.PlayerType.Io ? btnCampo.Cast<Button>().All(b => (Campo.CellType)b.Tag != Campo.CellType.Barca) : btnCampoAvversario.Cast<Button>().All(b => (Campo.CellType)b.Tag != Campo.CellType.Barca);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
