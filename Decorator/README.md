Decorator:

1) O padrão de projeto decorator "permite que você acople novos comportamentos para objetos ao colocá-los dentro de invólucros 
de objetos que contém os comportamentos".

2) Ou seja, permite que sejam adicionadas novos comportamentos sem afetar os comportamentos 
de um objeto da mesma classe (adicionar novas funcionalidades sem alterar o código original).

3) É uma alternativa flexível a herança, caso queira se estender "uma" funcionalidade;

![image](https://github.com/user-attachments/assets/adc6abbc-d6f1-4dd9-8d67-36d8f3fce5d6)

Fonte: https://refactoring.guru/pt-br/design-patterns/decorator


-----------------------------------------------------------------------------------------------------------------------------

a) Interface comum:
Tanto o objeto original quanto os decorators são implementados usando da mesma interface (ou herdam da mesma classe abstrata).

a.1) Interface (component): IPizza; Classe "original" (concrete component): Pizza; Decorator: PizzaDecorator; Concrete Decorator: AdicionaisPizzaDecorator, MassaEspecialDecorator
a.2) A instância do objeto base é a "pizzaBase" = pizzaExtras

c) Decorators:
Cada decorator recebe o objeto base (ou outro decorator) como parâmetro no construtor e adiciona um novo comportamento ou informação.

d) Encadeamento:
Podem ser "encadeados"(adicionados) quantos decorators forem necessários, cada um adicionando sua funcionalidade.

c+d) (AdicionaisDecorator(MassaEspecial(PizzaDecorator(pizzaBase))))
       <---------------------------------------------------------

e) Chamada em cadeia:
Ao chamar um método, o decorator pode executar um código novo e, em seguida, delegar a chamada para o objeto decorado (objeto anterior).

e.1)    public override string AdicionaisPizza()
        {
            var sabor = base.AdicionaisPizza();
            sabor += $"; Massa especial ({tipoMassa})";
            return sabor;
        }
