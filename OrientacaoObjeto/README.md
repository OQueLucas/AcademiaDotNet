# Exerc�cios da aula
� 1 - Crie uma classe "Jogo" com os seguintes atributos: T�tulo, G�nero,
Plataforma (por exemplo, PC, Xbox, PlayStation), Ano de lan�amento. Na
main, instancie um objeto e fa�a a leitura pelo teclado.
� 2 - Crie uma classe "Est�dio" com os seguintes atributos: Nome, Ano de
funda��o, Pa�s de origem e N�mero de jogos produzidos. Na main, instancie
um objeto e fa�a a leitura pelo teclado.
� 3 - Crie uma classe chamada Carro que possua 3 atributos: marca, modelo e
anoFabricacao. Al�m disso, na main crie 2 objetos do tipo Carro e exibir na
tela os valores dos atributos criados. Esses valores devem ser solicitados ao
usu�rio, no programa.
� 4 - Crie uma classe Livro com os atributos t�tulo, autor e ano de publica��o.
Fa�a a instancia��o de 3 objetos e imprima as informa��es do livro na tela.

# Exercicios
1 - Crie uma classe Produto com atributos como nome, pre�o e quantidade em estoque. Implemente um construtor e m�todos para adicionar e remover itens do estoque.
 
2 - Crie uma classe RegistroDeCompras com atributos para registrar informa��es de compras (data, produto, valor). Implemente um construtor e m�todos para adicionar e listar compras.

3 - Crie uma classe CorretoraDeIm�veis com atributos para armazenar informa��es sobre im�veis (endere�o, pre�o, tipo). Implemente um construtor e m�todos para listar im�veis dispon�veis e calcular o valor m�dio.
Crie um menu que contenha as op��es de inserir imoveis, alterar pre�o do imovel e apresentar todos os imoveis. Insira os imoveis numa lista para facilitar o trabalho.
 
4 - Crie uma classe AgendaTelef�nica com atributos para armazenar contatos (nome, telefone, e-mail). Implemente um construtor e m�todos para adicionar numa lista, remover e buscar contatos.
 
5 - Crie uma classe GerenciadorDeTarefas com atributos para armazenar uma lista de tarefas (descri��o, data de vencimento). Implemente um construtor e m�todos para adicionar, remover e listar tarefas. Adicione um m�todo para verificar se a tarefa dever� ser executada no dia de hoje. 
 
6 - Utilize o exerc�cio 1 para criar uma lista de produtos e fa�a m�todos para apresentar na tela e para consultar produtos pelo c�digo. 

7 - Crie uma classe chamada M�sica que contenha os atributos nome, autor e gravadora. Ap�s, crie uma classe Playlist que possua como atributo uma Lista de m�sicas e uma string para armazenar o dono da playlist. Implemente um m�todo para adicionar m�sicas na lista, para "tocar a m�sica" (s� mostrar uma mensagem na tela com o titulo da m�sica). Tente fazer uma reprodu��o aleat�ria, ou seja, em vez de percorrer do inicio ao fim da lista, fa�a um random para acessar valores aleat�rios v�lidos.

8 - Crie classes chamadas Fabricante e Produto. Fabricante que tenha as propriedades Nome, Endere�o e Cidade.  Produto que tenha as propriedades Nome, Fabricante (objeto da classe Fabricante) e Preco. Utilize o encapsulamento para garantir que o nome n�o seja vazio e que o pre�o seja positivo. 

9 - Crie uma classe chamada Livro que tenha as propriedades Titulo e Autor. Utilize o encapsulamento  para garantir que o t�tulo e o autor n�o sejam vazios.

10 - Crie uma classe chamada Animal que tenha as propriedades Nome, Especie e Idade. Crie tamb�m um m�todo chamado EmitirSom, que imprime na tela o som do animal.

11 - Crie uma classe "Carro" com os atributos "modelo", "ano" e "velocidade". Em seguida, crie um m�todo para acelerar o carro (aumentando a velocidade em 10) e outro para frear o carro (diminuindo a velocidade em 10, mas nunca deixando a  velocidade negativa).

12 - Crie uma classe Agenda que pode armazenar in�meras pessoas e que seja capaz de realizar as seguintes opera��es:
  void armazenaPessoa(String nome, int idade, float altura);
  void removePessoa(String nome);
  Pessoa buscaPessoa(String nome); // retorna a pessoa com o nome informado
  void imprimeAgenda(); // imprime os dados de todas as pessoas da agenda
Fa�a um menu para navegar entre as op��es infinitamente.