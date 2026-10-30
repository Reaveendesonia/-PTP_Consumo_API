# PTP_Consumo_API

Trabalho prático de **Consumo de Web API em C#**.

O projeto chama-se **Consumo_API_CSharp** e consome a API pública **DummyJSON Quotes**
(`https://dummyjson.com/quotes`), que devolve citações e respetivos autores em formato JSON.
A API não exige autenticação nem chave de acesso.

## Funcionalidades

- Listagem paginada de citações (10 por página, com navegação entre páginas).
- Consulta de uma citação pelo seu ID.
- Obtenção de uma citação aleatória.
- Pesquisa por autor ou por texto da citação (feita localmente sobre o catálogo obtido da API).
- Interface de consola com cores, texto formatado e mensagens em português.
- Tratamento de erros de rede, tempo de espera, respostas HTTP de erro e JSON inválido.

## API utilizada

| Funcionalidade | Endpoint |
| --- | --- |
| Listar citações | `GET https://dummyjson.com/quotes?limit=10&skip=0` |
| Citação por ID | `GET https://dummyjson.com/quotes/{id}` |
| Citação aleatória | `GET https://dummyjson.com/quotes/random` |
| Todas as citações (pesquisa local) | `GET https://dummyjson.com/quotes?limit=0` |

Exemplo de resposta de `GET /quotes/1`:

```json
{
  "id": 1,
  "quote": "Life isn't about getting and having, it's about giving and being.",
  "author": "Kevin Kruse"
}
```

Exemplo de resposta de `GET /quotes?limit=2&skip=0`:

```json
{
  "quotes": [
    {
      "id": 1,
      "quote": "Life isn't about getting and having, it's about giving and being.",
      "author": "Kevin Kruse"
    },
    {
      "id": 2,
      "quote": "The Bay of Bengal is hit frequently by cyclones. The months of November and May, in particular, are dangerous in this regard.",
      "author": "Abdul Kalam"
    }
  ],
  "total": 1454,
  "skip": 0,
  "limit": 2
}
```

## Tecnologias e conceitos aplicados

- **C# / .NET 8** (o projeto também executa em versões mais recentes do .NET, graças a `RollForward`).
- **HttpClient** para efetuar pedidos HTTP do tipo `GET`.
- **System.Text.Json** para converter o JSON recebido em objetos C# (`Quote` e `QuotesResponse`).
- **async/await** para pedidos assíncronos.
- **try-catch** para tratamento de exceções de rede (`HttpRequestException`), de tempo de espera
  (`TaskCanceledException`), de erros devolvidos pela API (`ApiException`) e de erros inesperados.
- **IDisposable** para libertar corretamente o `HttpClient`.
- Programação orientada a objetos com separação entre modelos, serviço de API e interface de consola.

## Requisitos

- [.NET SDK 8.0](https://dotnet.microsoft.com/download) ou superior.
- Ligação à Internet.
- Visual Studio 2022, Visual Studio Code ou apenas a linha de comandos.

## Como executar

### Linha de comandos

```bash
dotnet run --project Consumo_API_CSharp
```

### Visual Studio

1. Abrir `Consumo_API_CSharp.sln`.
2. Definir o projeto `Consumo_API_CSharp` como projeto de arranque.
3. Premir **F5** (ou Ctrl+F5).

## Estrutura do projeto

```text
PTP_Consumo_API/
├── .gitignore
├── README.md
├── Consumo_API_CSharp.sln
└── Consumo_API_CSharp/
    ├── Consumo_API_CSharp.csproj
    ├── Program.cs
    ├── Models/
    │   ├── Quote.cs
    │   └── QuotesResponse.cs
    └── Services/
        ├── ApiException.cs
        └── QuoteApiService.cs
```

## Tratamento de erros

O programa apresenta mensagens claras quando:

- não existe ligação à Internet ou a API está indisponível;
- o pedido excede o tempo limite de 20 segundos;
- a API devolve um estado HTTP de erro (por exemplo, `404` para uma citação inexistente);
- a resposta recebida não é um JSON válido;
- o utilizador introduz uma opção ou um ID inválido.

## Repositório

Este projeto deve ser publicado num repositório **público** do GitHub com o nome exato
**PTP_Consumo_API**:

```text
https://github.com/SEU_UTILIZADOR/PTP_Consumo_API
```

## Autor

- Nome: _(preencher)_
- Curso: _(preencher)_
- Ano/Turma: _(preencher)_
