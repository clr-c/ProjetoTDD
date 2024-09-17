using Xunit;
using System;
using static ProjetoTDD.Program.VerificacaoAluno;

namespace ProjetoTDD.Program.Tests
{
    public class VerificacaoAlunoTests
    {
        private VerificacaoAluno _verificacaoAluno;

        public VerificacaoAlunoTests()
        {
            _verificacaoAluno = new VerificacaoAluno();
        }

        [Fact]
        public void VerificarValorNegativo_FrequenciaNegativa_RetornaException()
        {
            //Arrange
            int frequencia = -1;
            double notaFinal = 50;
            double notaEspecial = 60;

            //Act & Assert
            var ex = Assert.Throws<ValorNegativoException>(() => _verificacaoAluno.VerificarValorNegativo(frequencia, notaFinal, notaEspecial));
            Assert.Equal($"ERRO: O valor de frequencia é negativo. Valor informado: {frequencia}.", ex.Message);
        }

        [Fact]
        public void VerificarValorNegativo_NotaFinalNegativa_RetornaException()
        {
            //Arrange
            int frequencia = 100;
            double notaFinal = -20;
            double notaEspecial = 75;

            //Act & Assert
            var ex = Assert.Throws<ValorNegativoException>(() => _verificacaoAluno.VerificarValorNegativo(frequencia, notaFinal, notaEspecial));
            Assert.Equal($"ERRO: O valor de notaFinal é negativo. Valor informado: {notaFinal}.", ex.Message);
        }

        [Fact]
        public void VerificarValorNegativo_NotaEspecialNegativa_RetornaException()
        {
            //Arrange
            int frequencia = 95;
            double notaFinal = 75;
            double notaEspecial = -60;

            //Act & Assert
            var ex = Assert.Throws<ValorNegativoException>(() => _verificacaoAluno.VerificarValorNegativo(frequencia, notaFinal, notaEspecial));
            Assert.Equal($"ERRO: O valor de notaEspecial é negativo. Valor informado: {notaEspecial}.", ex.Message);
        }

        [Fact]
        public void DeterminarAprovacao_FrequenciaBaixa_RetornaFalse()
        {
            //Arrange
            int frequencia = 70;
            double notaFinal = 80;
            double notaEspecial = 70;

            //Act
            bool resultado = _verificacaoAluno.DeterminarAprovacao(frequencia, notaFinal, notaEspecial);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeterminarAprovacao_NotaFinalBaixa_RetornaFalse()
        {
            //Arrange
            int frequencia = 80;
            double notaFinal = 50;
            double notaEspecial = 65;

            //Act
            bool resultado = _verificacaoAluno.DeterminarAprovacao(frequencia, notaFinal, notaEspecial);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeterminarAprovacao_NotaEspecialBaixa_RetornaFalse()
        {
            //Arrange
            int frequencia = 80;
            double notaFinal = 70;
            double notaEspecial = 50;

            //Act
            bool resultado = _verificacaoAluno.DeterminarAprovacao(frequencia, notaFinal, notaEspecial);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeterminarAprovacao_NotaEspecialZero_RetornaFalse()
        {
            //Arrange
            int frequencia = 80;
            double notaFinal = 90;
            double notaEspecial = 0;

            //Act
            bool resultado = _verificacaoAluno.DeterminarAprovacao(frequencia, notaFinal, notaEspecial);

            //Assert
            Assert.False(resultado);
        }

        [Fact]
        public void DeterminarAprovacao_TodasAsCondicoesAprovadas_RetornaTrue()
        {
            //Arrange
            int frequencia = 80;
            double notaFinal = 98;
            double notaEspecial = 100;

            //Act
            bool resultado = _verificacaoAluno.DeterminarAprovacao(frequencia, notaFinal, notaEspecial);

            //Assert
            Assert.True(resultado);
        }
    }
}