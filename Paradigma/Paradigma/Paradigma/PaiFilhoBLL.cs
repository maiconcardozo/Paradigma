using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paradigma
{
  public static class PaiFilhoBLL
  {

    public static string Arvoremontada = string.Empty;


    public static string MontandoArvore(List<PaiFilho> _ListaPaiFilho, List<PaiFilho> _ListaPaiFilhoReferencia)
    {
      foreach (var PaiFilho in _ListaPaiFilho)
      {
        if (!Arvoremontada.Contains(PaiFilho.Pai))
        {
          if (!string.IsNullOrEmpty(Arvoremontada))
          {
            Arvoremontada += PaiFilho.Pai;
          }
          else
          {
            Arvoremontada += PaiFilho.Pai + "[";
          }
          var filhos = _ListaPaiFilhoReferencia.Where(x => x.Pai == PaiFilho.Pai).ToList();

          if (filhos.Count != 0)
          {
            foreach (var pf in filhos)
            {
              if (!Arvoremontada.Contains(pf.Filho))
              {
                var Filhodopai = _ListaPaiFilhoReferencia.Where(x => x.Pai == pf.Filho).ToList();

                if (Filhodopai.Count == 0)
                {
                  Arvoremontada += "[" + pf.Filho + "]";
                }
                else
                {
                  Arvoremontada += "[";
                  MontandoArvore(Filhodopai, _ListaPaiFilhoReferencia);
                  continue;
                }
              }
            }
          }
          if (_ListaPaiFilho.Count == 1)
          {
            Arvoremontada += "]";
          }
          Arvoremontada += "]";
        }
      }
      return Arvoremontada;
    }
  }
}
