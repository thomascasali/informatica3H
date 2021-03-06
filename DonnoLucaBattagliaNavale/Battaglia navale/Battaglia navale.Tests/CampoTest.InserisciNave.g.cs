using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Battaglia_navale;
// <copyright file="CampoTest.InserisciNave.g.cs">Copyright ©  2018</copyright>
// <auto-generated>
// Questo file contiene test generati automaticamente.
// Non modificarlo manualmente.
// 
// Se il contenuto di questo file diventa obsoleto, è possibile eliminarlo,
// ad esempio se non viene più compilato.
// </auto-generated>
using System;

namespace Battaglia_navale.Tests
{
    public partial class CampoTest
    {

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void InserisciNaveThrowsNullReferenceException987()
{
    Campo campo;
    bool b;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = (Campo.CellType[,])null;
    b = this.InserisciNave(campo, (Nave)null, 0, 0);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave61()
{
    Campo campo;
    Nave nave;
    bool b;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = (Campo.CellType[,])null;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 0;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 0, 0);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave310()
{
    Campo campo;
    Nave nave;
    bool b;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = (Campo.CellType[,])null;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 0;
    nave.type = Nave.Type.da2;
    nave.orientamento = (Nave.Orientamento)4;
    b = this.InserisciNave(campo, nave, 0, 0);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave42()
{
    Campo campo;
    Nave nave;
    bool b;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = (Campo.CellType[,])null;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 514;
    nave.type = Nave.Type.da2;
    nave.orientamento = (Nave.Orientamento)4;
    b = this.InserisciNave(campo, nave, 0, 749);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave104()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = new Campo.CellType[0, 0];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 1021;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Orizzontale;
    b = this.InserisciNave(campo, nave, 0, 2);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(0, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLength(1));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave892()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 1}, new int[]{536945694, 1342177162}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 805306485;
    nave.type = Nave.Type.da2;
    nave.orientamento = (Nave.Orientamento)64;
    b = this.InserisciNave(campo, nave, 536945694, 1342177162);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(536945694, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(1342177162, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[536945694, 1342177162]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave950()
{
    Campo campo;
    Nave nave;
    bool b;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = (Campo.CellType[,])null;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 514;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 749, 0);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave842()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = new Campo.CellType[0, 0];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 1023;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 0, 0);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(0, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(0, campo.campoIDs.GetLength(1));
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave54()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 1}, new int[]{-1845493761, -867310098}) as Campo.CellType[,];
    @is[-1845493761, -867310098] = Campo.CellType.Buco;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = -1933173247;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Orizzontale;
    b = this.InserisciNave(campo, nave, -1845493761, -867310098);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(-1845493761, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(-867310098, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Buco, campo.campoIDs[-1845493761, -867310098]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave649()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance
                                (typeof(Campo.CellType), new int[]{1, 1}, new int[]{134823679, 5151093}) as
                              Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 2012368452;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 134823679, 5151093);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(134823679, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(5151093, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[134823679, 5151093]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave749()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 1}, new int[]{-174323201, 67443102}) as Campo.CellType[,];
    @is[-174323201, 67443102] = (Campo.CellType)2048;
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 174320128;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, -174323201, 67443102);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(-174323201, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(67443102, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        ((Campo.CellType)2048, campo.campoIDs[-174323201, 67443102]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave724()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{3, 1}, new int[]{-2139003906, 425947422}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = -1325490176;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, -2139003905, 425947422);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(-2139003906, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(3, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(425947422, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-2139003906, 425947422]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-2139003905, 425947422]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-2139003904, 425947422]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave389()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 3}, new int[]{-67130793, -1467330561}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = -687830169;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Orizzontale;
    b = this.InserisciNave(campo, nave, -67130793, -1467330560);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(-67130793, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(-1467330561, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(3, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-67130793, -1467330561]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-67130793, -1467330560]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[-67130793, -1467330559]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave747()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 1}, new int[]{192405742, 163860706}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da5, Nave.Orientamento.Verticale);
    nave.dimensione = 1;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 192405742, 163860706);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(192405742, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(163860706, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[192405742, 163860706]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave130()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{1, 1}, new int[]{-193986561, 2146435078}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 1;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Orizzontale;
    b = this.InserisciNave(campo, nave, -193986561, 2146435078);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(-193986561, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(2146435078, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[-193986561, 2146435078]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave335()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{3, 3}, new int[]{1305989246, -1878780227}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 3;
    nave.type = Nave.Type.da2;
    nave.orientamento = (Nave.Orientamento)4;
    b = this.InserisciNave(campo, nave, 1305989247, -1878780227);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(1305989246, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(3, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(-1878780227, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(3, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989246, -1878780227]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989246, -1878780226]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989246, -1878780225]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[1305989247, -1878780227]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[1305989247, -1878780226]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[1305989247, -1878780225]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989248, -1878780227]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989248, -1878780226]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[1305989248, -1878780225]);
    Assert.AreEqual<int>(0, campo.dimensione);
}

[TestMethod]
[PexGeneratedBy(typeof(CampoTest))]
public void InserisciNave934()
{
    Campo campo;
    Nave nave;
    bool b;
    Campo.CellType[,] @is = Array.CreateInstance(typeof(Campo.CellType), 
                                                 new int[]{3, 1}, new int[]{805310463, 1090519039}) as Campo.CellType[,];
    campo = new Campo(0, Campo.PlayerType.Io);
    campo.PT = Campo.PlayerType.Io;
    campo.campoIDs = @is;
    nave = new Nave(Nave.Type.da2, Nave.Orientamento.Verticale);
    nave.dimensione = 2;
    nave.type = Nave.Type.da2;
    nave.orientamento = Nave.Orientamento.Verticale;
    b = this.InserisciNave(campo, nave, 805310464, 1090519039);
    Assert.IsNotNull((object)campo);
    Assert.AreEqual<Campo.PlayerType>(Campo.PlayerType.Io, campo.PT);
    Assert.IsNotNull((object)(campo.campoIDs));
    Assert.AreEqual<int>(2, campo.campoIDs.Rank);
    Assert.AreEqual<int>(805310463, campo.campoIDs.GetLowerBound(0));
    Assert.AreEqual<int>(3, campo.campoIDs.GetLength(0));
    Assert.AreEqual<int>(1090519039, campo.campoIDs.GetLowerBound(1));
    Assert.AreEqual<int>(1, campo.campoIDs.GetLength(1));
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Mare, campo.campoIDs[805310463, 1090519039]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[805310464, 1090519039]);
    Assert.AreEqual<Campo.CellType>
        (Campo.CellType.Barca, campo.campoIDs[805310465, 1090519039]);
    Assert.AreEqual<int>(0, campo.dimensione);
}
    }
}
