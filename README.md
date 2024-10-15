# Arquitetura de Software - Projeto

## Visão Geral

Este projeto foi desenvolvido utilizando uma arquitetura de software baseada nos princípios do **Domain-Driven Design (DDD)**, implementada em **C#**. A arquitetura foi projetada com foco em manter o código desacoplado e facilmente testável, utilizando práticas modernas de desenvolvimento, como **Injeção de Dependência**, **Commands**, **Handlers** e a separação de responsabilidades através de diferentes camadas e projetos.

## Estrutura em Camadas

O projeto está estruturado em quatro camadas principais:

### 1. Camada de API
Esta camada é responsável por expor os serviços do sistema para clientes externos. Ela atua como a interface pública do sistema, recebendo requisições HTTP e encaminhando-as para as camadas internas.

### 2. Camada de Application
A camada **Application** organiza e expõe as lógicas de domínio em pacotes organizados, fornecendo uma interface para que as operações sejam realizadas. É também nessa camada que são gerenciados os **Commands** e **Handlers**, garantindo o fluxo de dados entre a camada de API e a camada de Domínio. Além disso, aqui estão presentes os **projetos de Contracts**, que contêm as definições de interfaces e objetos de negócio, promovendo o desacoplamento.

### 3. Camada de Domínio
Esta camada contém as **lógicas de negócio** do sistema, implementando as regras e processos que definem o comportamento do domínio. As entidades, agregados e serviços de domínio são gerenciados aqui. A camada também faz uso dos **projetos de Contracts** para se manter desacoplada e facilitar a reutilização de código.

### 4. Camada de Infraestrutura
A camada **Infraestrutura** é responsável pela implementação dos componentes que interagem com tecnologias externas, como:
- **Acesso a banco de dados**: gerenciamento de persistência e recuperação de dados.
- **Logging**: captura e gerenciamento de logs de eventos do sistema.
- **Autenticação**: serviços de autenticação e autorização.
- **Componentes Core**: elementos estruturais da arquitetura, fundamentais para o funcionamento do sistema, mas que não fazem parte do domínio de negócios diretamente.

## Padrões e Tecnologias Utilizadas

### 1. Domain-Driven Design (DDD)
A aplicação segue o conceito de DDD, onde os principais domínios de negócio são modelados de forma que a lógica do sistema reflita diretamente o vocabulário e as regras de negócio da organização.

### 2. Injeção de Dependência
Para facilitar o desacoplamento entre os componentes e melhorar a testabilidade do código, foi utilizada a **Injeção de Dependência (Dependency Injection - DI)**. Isso permite que as dependências sejam fornecidas de forma externa e configuradas em tempo de execução, proporcionando maior flexibilidade e facilitando o desenvolvimento de **testes unitários**.

### 3. Commands e Handlers
O padrão **Command-Handler** foi aplicado para gerenciar as operações do sistema. Cada ação no sistema é representada por um **Command**, que encapsula todos os dados necessários para a execução de uma operação. Os **Handlers** são responsáveis por processar esses comandos, promovendo um nível extra de separação entre o código que emite o comando e o código que o executa.

### 4. Padrão de Projeto - Contracts
Um padrão de projeto desenvolvido por mim foi incorporado nesta arquitetura, através da criação de um projeto específico denominado **Contracts**. Este projeto concentra todas as **interfaces** e **objetos de negócios** que são utilizados em diferentes partes do sistema. Ao centralizar essas definições, o projeto **Contracts** reduz o acoplamento entre as camadas de **domínio** e **infraestrutura**, permitindo que os projetos que contêm regras de negócios fiquem separados dos que contêm apenas objetos de negócios.

#### Vantagens:
- **Desacoplamento**: Separação clara entre as lógicas de negócio e os contratos, facilitando a evolução do sistema sem impacto cruzado.
- **Reutilização**: O projeto de **Contracts** pode ser facilmente transformado em um **NuGet** para reutilização em outros sistemas ou soluções maiores.
- **Manutenção**: Com essa estrutura modular, é mais simples manter e escalar a aplicação, além de facilitar a criação de **testes unitários**.

### 5. Testabilidade
Como resultado da aplicação dessas práticas, a arquitetura está desenhada para facilitar a **criação de testes unitários**. O desacoplamento entre as camadas e o uso de Injeção de Dependência permite que as diferentes partes da aplicação sejam testadas isoladamente, assegurando que os comportamentos desejados sejam garantidos de forma modular.

## Futuras Melhorias

- **NuGet Packages**: Planejo evoluir este projeto de **Contracts** em pacotes NuGet distribuíveis, promovendo ainda mais a reutilização dos componentes em projetos de maior escala.
- **Monitoramento e Observabilidade**: Uma próxima etapa seria a implementação de soluções de **monitoramento** para garantir a observabilidade e saúde dos serviços.
- **Migração para uma Arquitetura de Microsserviços**: Dada a flexibilidade proporcionada pela separação de contratos e domínio, esta arquitetura está preparada para uma futura migração para um ambiente de microsserviços.

## Conclusão

Essa abordagem arquitetural garante um alto nível de desacoplamento, flexibilidade e testabilidade, sendo altamente escalável e reutilizável. A separação entre contratos e domínios é uma prática desenvolvida especificamente para facilitar a manutenção e evolução de sistemas complexos, permitindo a criação de soluções mais robustas e modulares.





