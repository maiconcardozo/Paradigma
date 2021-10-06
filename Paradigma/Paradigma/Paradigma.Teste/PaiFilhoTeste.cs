using NUnit.Framework;
using System.Collections.Generic;

namespace Paradigma.Teste
{
  public class Tests
  {

    [Test]
    public void TesteExemplo1()
    {
      List<PaiFilho> ListaPaiFilho = new List<PaiFilho>();

      //[A, B] [A, C] [B, G] [C, H] [E, F] [B, D] [C, E]

      PaiFilho AB = new PaiFilho();
      AB.Pai = "A";
      AB.Filho = "B";

      ListaPaiFilho.Add(AB);

      PaiFilho AC = new PaiFilho();
      AC.Pai = "A";
      AC.Filho = "C";

      ListaPaiFilho.Add(AC);

      PaiFilho BG = new PaiFilho();
      BG.Pai = "B";
      BG.Filho = "G";

      ListaPaiFilho.Add(BG);

      PaiFilho CH = new PaiFilho();
      CH.Pai = "C";
      CH.Filho = "H";

      ListaPaiFilho.Add(CH);

      PaiFilho EF = new PaiFilho();
      EF.Pai = "E";
      EF.Filho = "F";

      ListaPaiFilho.Add(EF);

      PaiFilho BD = new PaiFilho();
      BD.Pai = "B";
      BD.Filho = "D";

      ListaPaiFilho.Add(BD);

      PaiFilho CE = new PaiFilho();
      CE.Pai = "C";
      CE.Filho = "E";

      ListaPaiFilho.Add(CE);

      string ArvoreMontada = string.Empty;
      Paradigma.PaiFilhoBLL.Arvoremontada = string.Empty;

      ListaPaiFilho = Paradigma.PaiFilhoBLL.OrdernarLista(ListaPaiFilho);

      ArvoreMontada = Paradigma.PaiFilhoBLL.MontandoArvore(ListaPaiFilho, ListaPaiFilho);

      Assert.AreEqual("A[[B[D][G]][C[E[F]][H]]]", ArvoreMontada);
    }

    [Test]
    public void TesteExemplo2()
    {
      //[B,D] [D,E] [A,B] [C,F] [E,G] [A,C]
      List<PaiFilho> ListaPaiFilho = new List<PaiFilho>();

      PaiFilho BD = new PaiFilho();
      BD.Pai = "B";
      BD.Filho = "D";

      ListaPaiFilho.Add(BD);

      PaiFilho DE = new PaiFilho();
      DE.Pai = "D";
      DE.Filho = "E";

      ListaPaiFilho.Add(DE);

      PaiFilho AB = new PaiFilho();
      AB.Pai = "A";
      AB.Filho = "B";

      ListaPaiFilho.Add(AB);


      PaiFilho CF = new PaiFilho();
      CF.Pai = "C";
      CF.Filho = "F";

      ListaPaiFilho.Add(CF);


      PaiFilho EG = new PaiFilho();
      EG.Pai = "E";
      EG.Filho = "G";

      ListaPaiFilho.Add(EG);

      PaiFilho AC = new PaiFilho();
      AC.Pai = "A";
      AC.Filho = "C";

      ListaPaiFilho.Add(AC);

      string ArvoreMontada = string.Empty;
      Paradigma.PaiFilhoBLL.Arvoremontada = string.Empty;

      ListaPaiFilho = Paradigma.PaiFilhoBLL.OrdernarLista(ListaPaiFilho);

      ArvoreMontada = Paradigma.PaiFilhoBLL.MontandoArvore(ListaPaiFilho, ListaPaiFilho);

      Assert.AreEqual("A[[B[D[E[G]]]][C[F]]]", ArvoreMontada);
    }


    [Test]
    public void TesteExemplo3()
    {
      List<PaiFilho> ListaPaiFilho = new List<PaiFilho>();

      PaiFilho AB = new PaiFilho();
      AB.Pai = "A";
      AB.Filho = "B";

      ListaPaiFilho.Add(AB);

      PaiFilho AC = new PaiFilho();
      AC.Pai = "A";
      AC.Filho = "C";

      ListaPaiFilho.Add(AC);

      PaiFilho BD = new PaiFilho();
      BD.Pai = "B";
      BD.Filho = "D";

      ListaPaiFilho.Add(BD);


      PaiFilho DC = new PaiFilho();
      DC.Pai = "D";
      DC.Filho = "C";

      ListaPaiFilho.Add(DC);

      string ArvoreMontada = string.Empty;
      Paradigma.PaiFilhoBLL.Arvoremontada = string.Empty;

      Paradigma.PaiFilhoBLL.OrdernarLista(ListaPaiFilho);

      ArvoreMontada = Paradigma.PaiFilhoBLL.MontandoArvore(ListaPaiFilho, ListaPaiFilho);

      Assert.AreEqual("Raízes múltiplas", ArvoreMontada);
    }
  }
}