# Exercício 2

Fazer um programa para ler um número inteiro N e depois os dados (id, nome e salario) de N funcionários. Não deve haver repetição de id.

Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário. Para isso, o programa deve ler um id e o valor X. 

Se o id informado não existir, mostrar uma mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários, conforme exemplos.

Lembre-se de aplicar a técnica de encapsulamento para não permitir que o salário possa ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento por porcentagem dada.

Use a classe projetada abaixo.

![](https://uploaddeimagens.com.br/images/003/826/113/original/imagem_2022-04-12_171019477.png?1649794290)

**Exemplo 1:**
* * *
How many employees will be registered? 3<br/>

Employee #1:<br/>
Id: 333<br/>
Name: Maria Brown<br/>
Salary: 4000.00<br/>

Employee #2:<br/>
Id: 536<br/>
Name: Alex Grey<br/>
Salary: 3000.00<br/>

Employee #3:<br/>
Id: 772<br/>
Name: Bob Green<br/>
Salary: 5000.00<br/>

Enter the employee id that will have salary increase : 536<br/>
Enter the percentage: 10.0<br/>

Updated list of employees:<br/>
333, Maria Brown, 4000.00<br/>
536, Alex Grey, 3300.00<br/>
772, Bob Green, 5000.00<br/>
* * * 
**Exemplo 2:**
* * *
How many employees will be registered? 2<br/>

Employee #1:<br/>
Id: 333<br/>
Name: Maria Brown<br/>
Salary: 4000.00<br/>

Employee #2:<br/>
Id: 536<br/>
Name: Alex Grey<br/>
Salary: 3000.00<br/>

Enter the employee id that will have salary increase : 776<br/>
This id does not exist!<br/>

Updated list of employees:<br/>
333, Maria Brown, 4000.00<br/>
536, Alex Grey, 3000.00<br/>
* * *

