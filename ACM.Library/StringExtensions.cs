using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ACM.Library
{
    public static class StringExtensions
    {
        //a palavra-chave this torna o metodo num "Extention Method"
        // A classe e o método precisam ser estáticos e no caso da classe - não-genérica
        public static string ConvertToTitleCase(this string source)
        {
            CultureInfo cultureInfo = Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;

            return textInfo.ToTitleCase(source);
        }

    }
}
