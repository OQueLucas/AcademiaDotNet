# PROJETO ANTIGO ([ACESSE O NOVO AQUI](https://github.com/OQueLucas/Academia_DotNet_5-WPAmigoSecreto))
Por questão de organização, separei o projeto e fiz modificações nesse novo link, caso queira ver a versão mais atualizada do mesmo, acesso o link acima.
 
 # Amigo Secreto ![C#](https://img.shields.io/badge/c%23-%23239120.svg?logo=c-sharp&logoColor=white) ![Static Badge](https://img.shields.io/badge/6.0-blueviolet?logo=.net&logoColor=white) 

Aplicação desenvolvida em `C# Windows Form` com o intuito de gerar pares pros amigos secreto.

[Video da versão Alpha no youtube](https://youtu.be/Ri8pkEohAXI)

## 📏 Regras de negócio

- Utilizei como base a ideia do MVVM para criação e organização de pastas;
- As classes Model `Pessoa` e `AmigoSecreto` tem configuradas suas regras de negocios e foi feito o override do ToString com separação usando ";" para facilitar o salvamento no CSV e capturar com a tratativa do Split.
- As Classes `View Models` foram criadas para facilitar a tratativa que os dados irão receber e separar do Forms, para terem maior autonomia dos dados e separar as funções do negócio das funções do sistema.
- O `Form1` está a parte principal do projeto, onde o usuário pode adicionar o nome e o email, porém, o email é opcional, caso queira, o mesmo pode adicionar apenas nome e sobrenome e o email será gerado automáticamente.
- o `FormAmigoSecreto` foi feito mais pela questão de visualização dos dados e ter uma ideia do que está gerando de forma organizada, já que o mesmo deve ser sigiloso até o fim do evento.
- A classe `Persistencia` é essencial para a conexão, leitura e escrita com os CSVs.
- A classe `Utils` tem métodos auxiliares, para validação de email e geração do mesmo, para poder ser acessado em momentos necessários do codigo.

## 📲 Recursos implementados
- Foi adicionado os tabIndex para facilitar o uso do sistema pro usuário com a tecla tab.
- Adicionado leitura de tecla enter para enviar dados.
- Configurado geração de email automática (com domínio UFN.com.br) caso usuário não tenha especificado o email do mesmo.
- Implementado botões para:
	- carregar dados na lista de arquivo num local especificado;
	- limpar a lista;
	- gravar lista em arquivo;
	- gerar lista de amigos secretos;
	- espiar a lista detalhadamente, mas com avisos de que poderia estragar a brincadeira.
- Ao carregar o projeto, é perguntado se o usuário já deseja popular a lista com arquivo existente, caso clique não, ele poderá adicionar do zero ou apertar em carregar lista para popular com arquivo existente.
- A gravação do arquivo de amigos secretos é mantido dentro do projeto, para que fique guardada e não seja revelada facilmente.
- Os botões de adicionar, excluir e limpar pessoas agem diretamente nos campos de email e senha.
- Caso queira remover alguém da lista, basta digitar o Nome ou Email da pessoa, caso o email não seja valido ou encontrado, o sistema tentará demitir pelo nome.
- As modificações na lista só são salvas em arquivo no momento em que Salvar a mesma no botão Salvar Lista.
- A geração de pares é feito a partir da lista no sistema, então caso não haja lista carregada ou não tenha inserido dados, não será possível gerar os mesmos.

## 🔧 Recursos Utilizados

- ``.NET 6``
- ``C#``

## 🔻 Clonar Repositório

```bash
git clone git@github.com:OQueLucas/SalesWebMvc.git
```

## 👨🏻‍🦱 Author
[Lucas Queiroz](https://github.com/OQueLucas/)
