using Developer.NotificationCore.Patterns;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Developer.NotificationCore.Validations
{
    public partial class Contract<T>
    {
        /// <summary>
        /// Requer que uma string seja um número de passaporte (Requires a string is a passport number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsPassport(string val, string message) => Matches(val, NotificationCoreRegexPatterns.PassportRegexPattern, message);

        /// <summary>
        /// Requer que uma string seja um número de passaporte (Requires a string is a passport number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsPassport(string val, string key, string message) => Matches(val, NotificationCoreRegexPatterns.PassportRegexPattern, key, message);

        /// <summary>
        /// Requer que uma string seja um número de RG (Requires a string is an RG number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsRG(string val, string message)
        {
            // 1. Remove caracteres não numéricos
            var rg = Regex.Replace(val ?? "", @"\D", "");

            // 2. Verifica se tem 9 dígitos
            if (rg.Length != 9)
                return this;

            // 3. Cálculo do dígito verificador (Módulo 11)
            int[] pesos = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int soma = 0;

            for (int i = 0; i < 8; i++)
            {
                soma += int.Parse(rg[i].ToString()) * pesos[i];
            }

            int resto = soma % 11;
            int digitoCalculado = 11 - resto;

            // Ajustes para valores especiais
            if (digitoCalculado == 11) digitoCalculado = 0;
            else if (digitoCalculado == 10) digitoCalculado = 'X'; // Dependendo do estado, pode ser 'X'

            // 4. Pega o dígito digitado (convertendo 'X' para 10 se necessário)
            char digitoDigitado = rg[8];
            char digitoComparacao = digitoCalculado == 'X' ? 'X' : digitoCalculado.ToString()[0];

            if (digitoDigitado != digitoComparacao)
                AddNotification(message);

            return this;
        }

        /// <summary>
        /// Requer que uma string seja um número de RG (Requires a string is an RG number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsRG(string val, string key, string message)
        {
            // 1. Remove caracteres não numéricos
            var rg = Regex.Replace(val ?? "", @"\D", "");

            // 2. Verifica se tem 9 dígitos
            if (rg.Length != 9)
                return this;

            // 3. Cálculo do dígito verificador (Módulo 11)
            int[] pesos = { 2, 3, 4, 5, 6, 7, 8, 9 };
            int soma = 0;

            for (int i = 0; i < 8; i++)
            {
                soma += int.Parse(rg[i].ToString()) * pesos[i];
            }

            int resto = soma % 11;
            int digitoCalculado = 11 - resto;

            // Ajustes para valores especiais
            if (digitoCalculado == 11) digitoCalculado = 0;
            else if (digitoCalculado == 10) digitoCalculado = 'X'; // Dependendo do estado, pode ser 'X'

            // 4. Pega o dígito digitado (convertendo 'X' para 10 se necessário)
            char digitoDigitado = rg[8];
            char digitoComparacao = digitoCalculado == 'X' ? 'X' : digitoCalculado.ToString()[0];

            if (digitoDigitado != digitoComparacao)
                AddNotification(key, message);

            return this;
        }

        /// <summary>
        /// Requer que uma string seja um número de CPF (Requires a string is a CPF number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCPF(string val, string message)
        {
            // Limpeza e verificação básica
            var cpf = new string((val ?? string.Empty).Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || new HashSet<char>(cpf).Count == 1)
            {
                AddNotification(message);
                return this;
            }

            // Cálculo dos dígitos verificadores
            for (int j = 0; j < 2; j++)
            {
                int soma = 0;
                for (int i = 0; i < 9 + j; i++)
                    soma += (cpf[i] - '0') * (10 + j - i);

                int resto = soma % 11;
                int digito = resto < 2 ? 0 : 11 - resto;

                if (cpf[9 + j] - '0' != digito)
                {
                    AddNotification(message);
                    return this;
                }
            }

            return this;
        }

        /// <summary>
        /// Requer que uma string seja um número de CPF (Requires a string is a CPF number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCPF(string val, string key, string message)
        {
            // Limpeza e verificação básica
            var cpf = new string((val ?? string.Empty).Where(char.IsDigit).ToArray());

            if (cpf.Length != 11 || new HashSet<char>(cpf).Count == 1)
            {
                AddNotification(key, message);
                return this;
            }

            // Cálculo dos dígitos verificadores
            for (int j = 0; j < 2; j++)
            {
                int soma = 0;
                for (int i = 0; i < 9 + j; i++)
                    soma += (cpf[i] - '0') * (10 + j - i);

                int resto = soma % 11;
                int digito = resto < 2 ? 0 : 11 - resto;

                if (cpf[9 + j] - '0' != digito)
                {
                    AddNotification(key, message);
                    return this;
                }
            }

            return this;
        }

        /// <summary>
        /// Requer que uma string seja um número de CNPJ (Requires a string is a CNPJ number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCNPJ(string val, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                AddNotification(message);
                return this;
            }

            // Limpa e valida tamanho (14 dígitos)
            var cnpj = val.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                AddNotification(message);
                return this;
            }

            // Validação dos dígitos verificadores (cálculo matemático padrão)
            int[] m1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] m2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string temp = cnpj.Substring(0, 12);
            int soma = 0;
            for (int i = 0; i < 12; i++) soma += int.Parse(temp[i].ToString()) * m1[i];
            int resto = (soma % 11);
            int d1 = (resto < 2) ? 0 : 11 - resto;

            temp += d1.ToString();
            soma = 0;
            for (int i = 0; i < 13; i++) soma += int.Parse(temp[i].ToString()) * m2[i];
            resto = (soma % 11);
            int d2 = (resto < 2) ? 0 : 11 - resto;

            if (!cnpj.EndsWith(d1.ToString() + d2.ToString()))
            {
                AddNotification(message);
            }

            return this;
        }

        /// <summary>
        /// Requer que uma string seja um número de CNPJ (Requires a string is a CNPJ number)
        /// </summary>
        /// <param name="val">O valor a ser verificado (The value to be checked).</param>
        /// <param name="key">A chave da notificação (The key of the notification).</param>
        /// <param name="message">A mensagem de notificação (Custom notification message).</param>
        /// <returns></returns>
        public Contract<T> IsCNPJ(string val, string key, string message)
        {
            if (string.IsNullOrWhiteSpace(val))
            {
                AddNotification(key, message);
                return this;
            }

            // Limpa e valida tamanho (14 dígitos)
            var cnpj = val.Trim().Replace(".", "").Replace("-", "").Replace("/", "");

            if (cnpj.Length != 14)
            {
                AddNotification(key, message);
                return this;
            }

            // Validação dos dígitos verificadores (cálculo matemático padrão)
            int[] m1 = { 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };
            int[] m2 = { 6, 5, 4, 3, 2, 9, 8, 7, 6, 5, 4, 3, 2 };

            string temp = cnpj.Substring(0, 12);
            int soma = 0;
            for (int i = 0; i < 12; i++) soma += int.Parse(temp[i].ToString()) * m1[i];
            int resto = (soma % 11);
            int d1 = (resto < 2) ? 0 : 11 - resto;

            temp += d1.ToString();
            soma = 0;
            for (int i = 0; i < 13; i++) soma += int.Parse(temp[i].ToString()) * m2[i];
            resto = (soma % 11);
            int d2 = (resto < 2) ? 0 : 11 - resto;

            if (!cnpj.EndsWith(d1.ToString() + d2.ToString()))
            {
                AddNotification(key, message);
            }

            return this;
        }

    }
}
