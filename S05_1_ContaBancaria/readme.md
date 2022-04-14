# Exercício 1

Em um banco, para se cadastrar uma conta bancária, é necessário informar o número da conta, o nome do titular da conta, e o valor de depósito inicial que o titular depositou ao abrir a conta. 

Este valor de depósito inicial, entretanto, é opcional, ou seja, se o titular não tiver dinheiro a depositar no momento de abrir sua conta, o depósito inicial não será feito e o saldo inicial da conta será, naturalmente, zero.

Importante: uma vez que uma conta bancária foi aberta, o número da conta nunca poderá ser alterado. Já o nome do titular pode ser alterado (pois uma pessoa pode mudar de nome por ocasião de casamento, por exemplo).

Por fim, o saldo da conta não pode ser alterado livremente. É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos, e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de $ 5.00.

Nota: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.

Você deve fazer um programa que realize o cadastro de uma conta, dando opção para que seja ou não informado o valor de depósito inicial. Em seguida, realizar um depósito e depois um saque, sempre mostrando os dados da conta após cada operação.

Use a classe projetada abaixo.

![imagem](https://uploaddeimagens.com.br/images/003/825/820/original/Screenshot_3.png?1649787705)

**Exemplo 1:**
* * *
Entre o número da conta: 8532<br/>
Entre o titular da conta: Alex Green<br/>
Haverá depósito inicial (s/n)? s<br/>
Entre o valor de depósito inicial: 500.00<br/>

Dados da conta:<br/>
Conta 8532, Titular: Alex Green, Saldo: $ 500.00<br/>

Entre um valor para depósito: 200.00<br/>
Dados da conta atualizados:<br/>
Conta 8532, Titular: Alex Green, Saldo: $ 700.00<br/>

Entre um valor para saque: 300.00<br/>
Dados da conta atualizados:<br/>
Conta 8532, Titular: Alex Green, Saldo: $ 395.00<br/>

* * * 
**Exemplo 2:**
* * *
Entre o número da conta: 7801<br/>
Entre o titular da conta: Maria Brown<br/>
Haverá depósito inicial (s/n)? n<br/>

Dados da conta:<br/>
Conta 7801, Titular: Maria Brown, Saldo: $ 0.00<br/>

Entre um valor para depósito: 200.00<br/>
Dados da conta atualizados:<br/>
Conta 7801, Titular: Maria Brown, Saldo: $ 200.00<br/>

Entre um valor para saque: 198.00<br/>
Dados da conta atualizados:<br/>
Conta 7801, Titular: Maria Brown, Saldo: $ -3.00<br/>
* * *
