using System;

namespace ProjetoTDD.Program
{
    public class VerificacaoAluno
    {
        //Verificar se algum dos valores é ngativo
        public void VerificarValorNegativo(int frequencia, double notaFinal, double notaEspecial)
        {
            (double valor, string nome)[] parametros =
            {
                (frequencia, "frequencia"),
                (notaFinal, "notaFinal"),
                (notaEspecial, "notaEspecial")
            };

            foreach (var parametro in parametros)
            {
                if (parametro.valor < 0)
                {
                    throw new ValorNegativoException(parametro.nome, parametro.valor);
                }
            }
        }

        // Método de aprovação
        public bool DeterminarAprovacao(int frequencia, double notaFinal, double mediaFinal)
        {
            //Verificação da frequência
            if (frequencia < 75)
            {
                Console.WriteLine($"REPROVADO - Frequência final: {frequencia}. A frequência não atingiu o valor mínimo de 75%.");
                return false;
            }
            // Verificação da nota final
            if (notaFinal <= 60)
            {
                Console.WriteLine($"REPROVADO - Nota final: {notaFinal}. A nota final não atingiu o valor mínimo de 60 pontos.");
                return false;
            }
            //Verificação da média entre nota final e nota especial
            if (mediaFinal <= 60)
            {
                Console.WriteLine($"REPROVADO - Média final: {mediaFinal}. A média final não atingiu o valor mínimo de 60 pontos.");
                return false;
            }
            else
            {
                Console.WriteLine($"APROVADO - Frequência final: {frequencia} - Nota final: {notaFinal} - Média final: {mediaFinal}.");
                return true;
            }
        }

        //Método para receber os dados do aluno, calcular a aprovação e exibir mensagem personalizada
        public static void RecebereCalcularValores()
        {
            VerificacaoAluno aluno = new();

            try
            {
                //Recebendo a frequência, nota final e nota especial do aluno
                Console.WriteLine("Informe a frequência do aluno (em %): ");
                int frequencia = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe a nota final do aluno: ");
                double notaFinal = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Informe a nota especial do aluno (se aplicável, caso contrário, digite 0): ");
                double notaEspecial = Convert.ToDouble(Console.ReadLine());

                //Verifica se algum dos valores informados é negativo
                aluno.VerificarValorNegativo(frequencia, notaFinal, notaEspecial);

                // Calculando o resultado
                double mediaFinal = (notaFinal + notaEspecial) / 2;
                if (notaEspecial == 0)
                {
                    mediaFinal = notaFinal;
                }
                bool resultado = aluno.DeterminarAprovacao(frequencia, notaFinal, mediaFinal);

                //Exibindo os resultados personalizadas com base nos calculos
                if (resultado)
                {
                    Console.WriteLine($"Parabéns! Aluno APROVADO - Frequência final: {frequencia} - Nota final: {notaFinal} - Média final: {mediaFinal}.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERRO: {ex.Message}");
            }
        }

        public class ValorNegativoException : Exception
        {
            public ValorNegativoException(string nome, double valor)
                : base($"ERRO: O valor de {nome} é negativo. Valor informado: {valor}.")
            {
            }
        }
    }
}
