# Exercício 1

Fazer um programa para ler os dados de uma reserva de hotel (número do quarto, datade entrada e data de saída) e mostrar os dados da reserva, inclusive sua duração em
dias. 

Em seguida, ler novas datas de entrada e saída, atualizar a reserva, e mostrar novamente a reserva com os dados atualizados. O programa não deve aceitar dados inválidos para a reserva, conforme as seguintes regras:

- Alterações de reserva só podem ocorrer para datas futuras
- A data de saída deve ser maior que a data de entrada

Siga o diagrama UML abaixo:

![](https://uploaddeimagens.com.br/images/003/833/942/original/imagem_2022-04-18_152812830.png?1650306570)

**Exemplo 1:**
* * *
Room number: 8021<br/>
Check-in date (dd/MM/yyyy): 23/09/2019<br/>
Check-out date (dd/MM/yyyy): 26/09/2019<br/>

Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights<br/>

Enter data to update the reservation:<br/>
Check-in date (dd/MM/yyyy): 24/09/2019<br/>
Check-out date (dd/MM/yyyy): 29/09/2019<br/>

Reservation: Room 8021, check-in: 24/09/2019, check-out: 29/09/2019, 5 nights<br/>
* * *
**Exemplo 2:**
* * *
Room number: 8021<br/>
Check-in date (dd/MM/yyyy): 23/09/2019<br/>
Check-out date (dd/MM/yyyy): 21/09/2019<br/>

Error in reservation: Check-out date must be after check-in date<br/>
* * *
**Exemplo 3:**
* * *
Room number: 8021<br/>
Check-in date (dd/MM/yyyy): 23/09/2019<br/>
Check-out date (dd/MM/yyyy): 26/09/2019<br/>

Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights<br/>

Enter data to update the reservation:<br/>
Check-in date (dd/MM/yyyy): 24/09/2015<br/>
Check-out date (dd/MM/yyyy): 29/09/2015<br/>

Error in reservation: Reservation dates for update must be future dates<br/>
* * *
**Exemplo 4:**
* * *
Room number: 8021<br/>
Check-in date (dd/MM/yyyy): 23/09/2019<br/>
Check-out date (dd/MM/yyyy): 26/09/2019<br/>

Reservation: Room 8021, check-in: 23/09/2019, check-out: 26/09/2019, 3 nights<br/>

Enter data to update the reservation:<br/>
Check-in date (dd/MM/yyyy): 24/09/2020<br/>
Check-out date (dd/MM/yyyy): 22/09/2020<br/>

Error in reservation: Check-out date must be after check-in date<br/>
* * *
