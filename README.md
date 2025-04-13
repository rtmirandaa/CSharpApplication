# API de Calculo de Areas

Essa API foi desenvolvida para uma tarefa da faculdade UNISENAC, com o objetivo de aprender a criar uma API utilizando C# e seguindo os padrões de projeto DDD e design patterns.

A API tem apenas um endpoint, que é um POST para o seguinte endereço: `http://localhost:5178/api/area/calcular-area`

O endpoint recebe um objeto do tipo `CalculoAreaRequest` que contém as seguintes propriedades:

* `Forma`: string que indica a forma geométrica que será calculada (pode ser "Quadrado", "Retangulo" ou "TrianguloRetangulo")
* `Lado`: double que indica o lado do quadrado ou da base do retangulo
* `Base`: double que indica a base do retangulo ou do triangulo retangulo
* `Altura`: double que indica a altura do retangulo ou do triangulo retangulo

O endpoint retorna um objeto do tipo `AreaResponse` que contém a propriedade `Area` que é o resultado do cálculo da área da forma geométrica.

A API foi desenvolvida com o padrão de projeto Clean Architecture e utiliza a camada de Domain para separar a lógica de negócios da lógica de infraestrutura.

A API foi desenvolvida com o padrão de projeto Dependency Injection para separar a lógica de negócios da lógica de infraestrutura.


