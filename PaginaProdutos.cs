using System.Collections.Generic;
using System.Text;

class PaginaProdutos : PaginaDinamica
{
    public override byte[] Get(SortedList<string, string> parametros)
    {
        string codigo = parametros.ContainsKey("id") ?
            parametros["id"] : "";

        StringBuilder htmlGerado = new StringBuilder();
        foreach (var p in Produto.Listagem)
        {          
            bool negrito = (!string.IsNullOrEmpty(codigo) && codigo == p.Codigo.ToString());
            htmlGerado.Append("<tr>");
            if (negrito)
            {
                htmlGerado.Append($"<td><b>{p.Codigo:D4}</b></td>");
                htmlGerado.Append($"<td><b>{p.Nome}</b></td>");
            }
            else
            {
                htmlGerado.Append($"<td>{p.Codigo:D4}</td>");
                htmlGerado.Append($"<td>{p.Nome}</td>");
            }
            htmlGerado.Append("</tr>");
        }

        string textoHtmlGerado = this.HtmlModelo.Replace(
            "{{HtmlGerado}}", htmlGerado.ToString());
        return Encoding.UTF8.GetBytes(textoHtmlGerado);
    }
}