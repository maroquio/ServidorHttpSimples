using System.Collections.Generic;
using System.Text;

abstract class PaginaDinamica
{
    public string HtmlModelo {get; set;}
    public virtual byte[] Get(SortedList<string, string> parametros)
    {
        return Encoding.UTF8.GetBytes(this.HtmlModelo);
    }
    public virtual byte[] Post(SortedList<string, string> parametros)
    {
        return Encoding.UTF8.GetBytes(this.HtmlModelo);
    }
}