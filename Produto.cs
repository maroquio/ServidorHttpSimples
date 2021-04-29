using System.Collections.Generic;

class Produto
{
    public static List<Produto> Listagem {get; set;}
    public int Codigo { get; set; } 
    public string Nome { get; set; }
    static Produto()
    {
        Produto.Listagem = new List<Produto>();
        Produto.Listagem.AddRange(new List<Produto>{
            new Produto{Codigo=1, Nome="Banana"},
            new Produto{Codigo=2, Nome="Maçã"},
            new Produto{Codigo=3, Nome="Mamão"},
            new Produto{Codigo=4, Nome="Morango"},
            new Produto{Codigo=5, Nome="Uva"}
        });
    }

}