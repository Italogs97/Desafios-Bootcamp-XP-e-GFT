
# Sistema de Gerenciamento de Estacionamento 🅿️ 🚘


## Visão Geral do Projeto

Este projeto apresenta um sistema de gerenciamento de estacionamento robusto e intuitivo, desenvolvido em C#. Ele foi concebido para simular as operações essenciais de um estacionamento, desde o registro de veículos até a emissão de recibos de pagamento. O foco principal é a usabilidade e a precisão no cálculo de custos, garantindo uma experiência eficiente tanto para o operador quanto para o cliente. A arquitetura do sistema é modular, permitindo futuras expansões e integrações com outras plataformas, caso necessário. A escolha do C# e do .NET 6.0 reflete o compromisso com a performance, segurança e a vasta gama de recursos que essas tecnologias oferecem para o desenvolvimento de aplicações de console.

### Interagindo com o Menu

Ao iniciar a aplicação, você será recebido com um menu de opções:


``` plaintext
Seja bem vindo ao sistema de estacionamento!
Digite o preço inicial:
[Digite o preço inicial, ex: 10]
Agora digite o preço por hora:
[Digite o preço por hora, ex: 5]

Digite a sua opção:
1 - Cadastrar veículo
2 - Remover veículo
3 - Listar veículos
4 - Encerrar

```
• **Preço Inicial e Preço por Hora:** Antes de acessar o menu principal, o sistema solicitará que você defina o preço inicial (taxa fixa) e o preço por hora do estacionamento. Esses valores serão utilizados para calcular o custo total da permanência de um veículo.

• **Opções do Menu:** Digite o número correspondente à opção desejada e pressione Enter:


•  ` 1 - Cadastrar veículo:` Para adicionar um novo veículo. O sistema pedirá a placa do veículo.

• `2 - Remover veículo:` Para retirar um veículo. O sistema pedirá a placa e a quantidade de horas que o veículo permaneceu estacionado. Certifique-se de digitar um número inteiro para as horas. Após a remoção, um recibo será exibido.

• `3 - Listar veículos:` Para ver todos os veículos atualmente estacionados.

• `4 - Encerrar: ` Para sair da aplicação.

Após cada operação, o sistema aguardará que você pressione qualquer tecla para continuar, permitindo que você revise a saída antes de retornar ao menu principal.






## 🤝 Contribuição

Contribuições são bem-vindas! Para contribuir:

1. Faça um **fork** do repositório.
2. Crie uma **branch** para sua feature:
   ```bash
   git checkout -b minha-feature
   ```
3. Faça **commit** das alterações:
   ```bash
   git commit -m "Minha nova feature"
   ```
4. Envie para o repositório remoto:
   ```bash
   git push origin minha-feature
   ```
5. Abra um **Pull Request**.






--------------------------------------------------------------------- English --------------------------------------------------------------


# Parking Management System 🅿️ 🚘


## Project Overview

This project presents a robust and intuitive parking management system developed in C#. It was designed to simulate the essential operations of a parking lot, from vehicle registration to the issuance of payment receipts. The main focus is on usability and accuracy in cost calculation, ensuring an efficient experience for both the operator and the customer. The system's architecture is modular, allowing for future expansions and integrations with other platforms, if necessary. The choice of C# and .NET 6.0 reflects the commitment to performance, security, and the wide range of features these technologies offer for console application development.

### Interacting with the Menu


Upon starting the application, you will be greeted with a menu of options:

``` plaintext
Welcome to the parking system!
Enter the initial price:
[Enter the initial price, e.g., 10]
Now enter the price per hour:
[Enter the price per hour, e.g., 5]

Enter your option:
1 - Register vehicle
2 - Remove vehicle
3 - List vehicles
4 - Exit


```
• **Initial Price and Price per Hour: ** ABefore accessing the main menu, the system will ask you to define the initial price (fixed fee) and the hourly price of the parking lot. These values will be used to calculate the total cost of a vehicle's stay.

• **Menu Options:** Enter the number corresponding to the desired option and press Enter:


•  ` 1 - Register vehicle:` To add a new vehicle. The system will ask for the vehicle's license plate.

• `2 - Remove vehicle:` To remove a vehicle. The system will ask for the license plate and the number of hours the vehicle remained parked. Make sure to enter an integer for the hours. After removal, a receipt will be displayed.

• `3 - List vehicles:` To see all currently parked vehicles.

• `4 - Exit: ` To quit the application.

After each operation, the system will wait for you to press any key to continue, allowing you to review the output before returning to the main menu.






## 🤝 Contribuição

Contribuições são bem-vindas! Para contribuir:

1. **Fork**  the repository.
2. Create a **branch** for your feature:
   ```bash
   git checkout -b minha-feature
   ```
3. **Commit** your changes :
   ```bash
   git commit -m "Minha nova feature"
   ```
4. Push to the remote repository:
   ```bash
   git push origin minha-feature
   ```
5. Open a **Pull Request**.
