using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _02_CacaAoBugMVC.Model
{
    class ValidaServece
    {
        // padrão:
        // - mínimo de 3 caracteres
        // - não ter 3 letras repetidas
        // - não ter duplo espaço
        private readonly string padraoNome = @"^(?!.*([A-Za-zÀ-ÖØ-öø-ÿ])\1\1)(?!.* {2,})(?=.{3,}).+$";

        // padrão:
        // - valida nota de 0..10
        // - aceita decimais, aceitando ponto(.) ou vírgula(,) como separador decimal
        private readonly string padraoNota = @"^(?:10(?:[.,]0+)?|[0-9](?:[.,][0-9]+)?)$";

        public bool ValidaNome(string nome, out string mensagemErro)
        {
            mensagemErro = string.Empty;
            if (string.IsNullOrEmpty(nome))
            {
                mensagemErro = "Nome vazio";
                return false;
            }
            if (!Regex.IsMatch(nome.Trim(), padraoNome))
            {
                mensagemErro = "-Mínimo 3 caracteres\n-Não pode ter 3 letras iguais seguidas\n-Não pode ter espaços duplos";
                return false;
            }
            return true;
        }

        public bool ConverteNota(string notaEntrada)
        {
            double nota = -1; // corrigido: declaração da variável
            if (string.IsNullOrEmpty(notaEntrada)) return false;

            var notaDecimalVirgula = notaEntrada.Trim().Replace(",", ".");
            if (!Regex.IsMatch(notaDecimalVirgula, padraoNota)) return false;

            if (double.TryParse(notaDecimalVirgula, System.Globalization.NumberStyles.Number,
                System.Globalization.CultureInfo.InvariantCulture, out nota))
            {
                if (nota < 0 || nota > 10)
                    return false;
                else
                    return true;
            }

            return false; // corrigido: se não conseguiu converter, retorna false
        }
    }
}
