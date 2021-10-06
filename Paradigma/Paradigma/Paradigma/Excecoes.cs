using System;
using static Paradigma.Enum;

namespace Paradigma
{
  [Serializable]
  public class ErroArvoreException : Exception
  {

    public ErroArvoreException()
    {

    }

    public ErroArvoreException(ErroArvoreExceptionEnum _CodErro)
    {
      switch (_CodErro)
      {
        case ErroArvoreExceptionEnum.E1:
          throw new Exception("Mais de 2 filhos");
        case ErroArvoreExceptionEnum.E2:
          throw new StackOverflowException("Ciclo presente");
        case ErroArvoreExceptionEnum.E3:
          throw new Exception("Raízes múltiplas");
        case ErroArvoreExceptionEnum.E4:
          throw new Exception("Qualquer outro erro");
        default:
          break;
      }

    }
  }
}
