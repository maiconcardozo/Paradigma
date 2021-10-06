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
      try
      {
        foreach (var PaiFilho in _ListaPaiFilho)
        {
          if (!_ListaPaiFilhoReferencia.Any(x => x.Filho == PaiFilho.Filho && x.Pai != PaiFilho.Pai))
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
                    else if (Filhodopai.Count > 2)
                    {
                      throw new ErroArvoreException(Enum.ErroArvoreExceptionEnum.E2);
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
              else if (filhos.Count > 2)
              {
                throw new ErroArvoreException(Enum.ErroArvoreExceptionEnum.E1);
              }
              Arvoremontada += "]";
            }
          }
          else
          {
            throw new ErroArvoreException(Enum.ErroArvoreExceptionEnum.E3);
          }
        }
        return Arvoremontada;
      }
      catch (Exception e)
      {
        return e.Message;
      }
    }

    public static List<PaiFilho> OrdernarLista(List<PaiFilho> listaPaiFilho)
    {
      return listaPaiFilho.OrderBy(x => x.Pai).ThenBy(x => x.Filho).ToList();
    }
  }
}