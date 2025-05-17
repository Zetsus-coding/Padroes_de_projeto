Padrão de projeto Facade é um padrão que fornece uma interface simplificada/unificada (mas que em contrapartida é limitada) para um conjunto de sistemas e assim expõe somente
as interfaces que o cliente precisa enxergar;

1) No caso desse projeto, existem diferentes classes (Produto, Estoque, Pagamento, Transporte) que fazem parte do "sistema" e são necessárias para realizar a ação de fazer um pedido;
2) Mesmo que seja possível realizar/finalizar um pedido de um produto, o cliente necessita instanciar várias classes e chamar vários métodos para que isso aconteça e para isso ele necessita saber
como o sistema funciona como um "todo";
3) É ai que entra o padrão facade. Cria-se uma classe que vai servir de intermediário entre todas essas classes e métodos e o "cliente".
4) É nela que serão instanciadas as outras classes necessárias para fazer o pedido e os métodos serão chamados. A partir daí o cliente só precisa chamar um único método da classe Facade
para realizar o pedido;

-- Subsistemas --

Produto -> Uma classe para "armazenar" certas informações de produto (nome, quantidade, valorProduto)
Estoque -> Tem o método para checar se a quantidade desejada é maior que o que está no estoque. Se tiver quantidade suficiente retorna true senão false e faz um CW informando que não tem estoque o suficiente
Pagamento -> Tem o método de "checar pagamento". Se o valor informado for menor que o valor do produto retorna false e um CW "informando o erro" senão retorna true
Transporte -> Tem o método de envio que escreve uma mensagem de que o processo de envio está sendo preparado/iniciado.

-- Facade --

Facade -> É onde serão instanciadas todos os subsistemas e onde as informações do produto são definidas. Aqui existe o método RealizarPedido() que chama os métodos das outras classes na ordem definida
		  A partir daí, no Program.cs só é necessário instanciar a classe Facade e chamar o método RealizarPedido.


		  ** Desconsiderando os parâmetros

		  Produto
		   - Informações do produto  ---------\
											   \
		  Estoque								\
		   - VerificarEstoque()  ----------------\
												  ------>        Facade		   ----------->  Program.cs
		  Pagamento								 /         - RealizarPedido()				  - Facade fachada = new();
		   - ChecarPagamento()  ----------------/											  - fachada.RealizarPedido();
											   /
		  Transporte						  /
		   - Envio() ------------------------/