# Projeto TDD - Sistema de Aprovação Acadêmica

## Descrição

Este projeto é um programa de aprovação acadêmica, inclui uma verificação de valores (negativo OU positivo) e o restultado de aprovação OU reprovação do aluno com base na frequência, nota final e média final. O projeto utiliza o conceito de Test-Driven Development (TDD) para garantia da qualidade do código através de testes unitários automatizados.

## Estrutura do Projeto

O projeto está dividido em duas pastas principais:

1. **Program (`Program.cs` && `MetodosParaAprovacaoAcademica.cs`)**
   - **Métodos:**
     - `Main()`
     - `VerificarValorNegativo(int frequencia, double notaFinal, double notaEspecial)`
     - `DeterminarAprovacao(int frequencia, double notaFinal, double mediaFinal)`
     - `RecebereCalcularValores()`

2. **Program.Tests (`VerificacaoAlunoTests.cs`)**
   - **Testes:**
     - `VerificarValorNegativo_FrequenciaNegativa_RetornaException()`
     - `DeterminarAprovacao_FrequenciaBaixa_RetornaFalse()`
     - `DeterminarAprovacao_NotaFinalBaixa_RetornaFalse()`
     - `DeterminarAprovacao_MediaFinalBaixa_RetornaFalse()`
     - `DeterminarAprovacao_TodasAsCondicoesAprovadas_RetornaTrue()`

## Executando o Projeto

Para executar o projeto, siga estas etapas:
   ```sh
   git clone <URL do repositório>
   cd ProjetoTDD
   dotnet run --project Program/Program.csproj
   ```

## Executando os Testes

Para executar os testes, siga estas etapas:
   ```sh
   cd Program.Tests
   dotnet test
   ```
