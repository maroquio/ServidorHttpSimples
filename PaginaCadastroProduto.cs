using System;
using System.Collections.Generic;
using System.Text;

class PaginaCadastroProduto : PaginaDinamica
{
    public override byte[] Post(SortedList<string, string> parametros)
    {
        Produto p = new Produto();
        p.Codigo = parametros.ContainsKey("codigo") ?
            Convert.ToInt32(parametros["codigo"]) : p.Codigo = 0;
        p.Nome = parametros.ContainsKey("nome") ?
            parametros["nome"] : "";
        if (p.Codigo > 0)
            Produto.Listagem.Add(p);
        string html = "<script>window.location.replace(\"produtos.dhtml\")</script>";
        return Encoding.UTF8.GetBytes(html);
    }    
}