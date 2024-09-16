# Projeto TDD - Sistema de Aprovação Acadêmica

## Descrição

Este projeto é um programa de aprovação acadêmica, inclui uma verificação de valores (negativo OU positivo) e o restultado de aprovação OU reprovação do aluno com base na frequência, nota final e média final. O projeto utiliza o conceito de Test-Driven Development (TDD) para garantia da qualidade do código através de testes unitários automatizados.

## Estrutura do Projeto

O projeto está dividido em duas pastas principais:

1. **Programa (`Program.cs`)**
   - **Métodos Principais:**
     - `VerificarValorNegativo(int frequencia, double notaFinal, double notaEspecial)`
     - `DeterminarAprovacao(int frequencia, double notaFinal, double mediaFinal)`
     - `ReceberValores()`

2. **Testes (`Program.Tests`)**
   - **Testes Principais:**
     - `VerificarValorNegativo_FrequenciaNegativa_RetornaException()`
     - `DeterminarAprovacao_FrequenciaBaixa_RetornaFalse()`
     - `DeterminarAprovacao_NotaFinalBaixa_RetornaFalse()`
     - `DeterminarAprovacao_MediaFinalBaixa_RetornaFalse()`
     - `DeterminarAprovacao_TodasAsCondicoesAprovadas_RetornaTrue()`

## Executando o Projeto

Para executar o projeto, siga estas etapas:

1. **Clone o repositório:**

   ```sh
   git clone <URL do repositório>
   cd ProjetoTDD
   dotnet run --project Program/Program.csproj
