using NUnit.Framework;
using System.Collections.Generic;

namespace Paradigma.Teste
{
  public class Tests
  {

    [Test]
    public void Teste()
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

      ArvoreMontada = Paradigma.PaiFilhoBLL.MontandoArvore(ListaPaiFilho, ListaPaiFilho);

      Assert.AreEqual("A[[B[D][G]][C[E[F]][H]]]]", ArvoreMontada);


//  A[
//   [B[D][G]]
//   [C[E[F]][H]]
//   ]
//]


    }
  }
}