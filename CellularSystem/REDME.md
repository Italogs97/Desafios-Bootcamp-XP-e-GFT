# CellularSystem

## 📱 Sobre o Sistema

O **CellularSystem** é um projeto de simulação de celulares desenvolvido em C# e .NET, com foco em conceitos de orientação a objetos.  
O sistema foi criado para demonstrar como diferentes modelos de celulares podem compartilhar comportamentos comuns e, ao mesmo tempo, possuir funcionalidades específicas.

### Como funciona

- O sistema possui uma **classe abstrata** chamada `Cellular`, que define propriedades e métodos comuns a todos os celulares, como modelo, marca, número, memória e IMEI.
- Métodos abstratos como `TurnOn`, `TurnOff`, `MakeCall` e `SendMessage` obrigam cada modelo a implementar seu próprio comportamento.
- Métodos virtuais como `TakePhoto` e `InstallApp` podem ser sobrescritos para personalizar a experiência de cada celular.
- As classes `Iphone`, `Samsung` e `Nokia` herdam de `Cellular` e implementam comportamentos específicos, simulando ações reais de cada marca.

### Demonstração

Ao executar o projeto, o sistema cria instâncias de cada modelo de celular e realiza operações como ligar, fazer chamadas, enviar mensagens, tirar fotos e instalar aplicativos.  
Cada ação é exibida no console, mostrando como cada modelo pode ter respostas diferentes para os mesmos comandos.

### Objetivos do Projeto

- Praticar herança, abstração e polimorfismo em C#
- Simular um sistema realista de celulares
- Facilitar a expansão para novos modelos e funcionalidades

### Como executar

1. Instale o .NET SDK.
2. No terminal, navegue até a pasta do projeto.
3. Execute:
   ```
   dotnet run
   ```
4. Observe a simulação dos celulares no console.

---

## 📱 About the System (English)

**CellularSystem** is a cellphone simulation project developed in C# and .NET, focused on object-oriented concepts.  
The system demonstrates how different cellphone models can share common behaviors while having their own specific functionalities.

### How it works

- The system has an **abstract class** called `Cellular`, which defines common properties and methods for all cellphones, such as model, brand, number, memory, and IMEI.
- Abstract methods like `TurnOn`, `TurnOff`, `MakeCall`, and `SendMessage` require each model to implement its own behavior.
- Virtual methods like `TakePhoto` and `InstallApp` can be overridden to customize each cellphone's experience.
- The classes `Iphone`, `Samsung`, and `Nokia` inherit from `Cellular` and implement specific behaviors, simulating real actions for each brand.

### Demonstration

When running the project, the system creates instances of each cellphone model and performs operations such as turning on, making calls, sending messages, taking photos, and installing apps.  
Each action is displayed in the console, showing how each model can respond differently to the same commands.

### Project Goals

- Practice inheritance, abstraction, and polymorphism in C#
- Simulate a realistic cellphone system
- Facilitate expansion for new models and features

### How to run

1. Install the .NET SDK.
2. In the terminal, navigate to the project folder.
3. Run:
   ```
   dotnet run
   ```
4. Watch the cellphone simulation