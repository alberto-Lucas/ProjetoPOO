using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjetoPOO.Services
{
    //O tipo "enum" representa um enumerador,
    //ou seja ele possui uma lista de valores, e
    //cada valor possui uma sequencia
    //Aplicando as opção Iserir, Alterar e Visualizar
    //equivale a sequinte sequencia
    //Inserir = 0
    //Alterar = 1
    //Visualizar = 2
    //Ou seja se tivesse um quarto item seria o valor 3
    public enum AcaoNaTela
    {
        Inserir,
        Alterar,
        Visualizar
    }
}
