# Lista de Tarefas

> Status: Concluido ✅

### Essa é uma ApplicationWeb feita para gerenciar tarefas onde pode-se criar, atualizar e remover uma ou mais tarefas, você também pode colocar descrição, prioridade e status.

## Os campos para preenchimento são:

+ Nome
+ Descrição da Tarefa
+ Prioridade
+ Status da Tarefa

## Tecnologias Usadas:

+ C#
+ ASP.NET
+ HTML
+ CSS
+ EntityFramework
+ SQL Server

## Prints das telas da aplicação:

+ Home
  ![home](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/b82af489-3524-4550-b3b5-0a34450c8023) 

+ Lista de Tarefas
  ![tarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/d98167e2-401f-4f06-a957-c3b94c825028)

+ Adcionar Tarefas
  ![AddTarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/229113ed-83bb-4f65-b676-87ab37fbfb8a)

+ Tarefa Criada
  ![ListaTarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/b5187254-b016-44b5-9dc8-79bf1baab1de)

+ Atualizar Tarefas
  ![EditarTarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/2c00a0e1-3e12-40fc-b5fb-bf3d36c5d3ec)

+ Tarefas Atualizada
  ![TarefaEditada](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/54a70849-5530-47b1-8f4f-9ff4226d3aa6)

+ Remover Tarefas
  ![DeletarTarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/4b709e28-9b36-4183-af34-e587fdf8fbd7)

+ Tarefas Removidas
  ![tarefas](https://github.com/Brunollm/ApplicationWeb_SKA/assets/110358647/ccae9c2c-4d42-4e56-8706-a8b35ffabf82)

## Requerimentos
+ Ferramentas:
  
  + SQL Server
  + Visual Studio (recomendado)
  
+ Pacotes Nuget:
    
  + Microsoft.EntityFrameworkCore
  + Microsoft.EntityFrameworkCore.Tools
  + Microsoft.EntityFrameworkCore.SqlServer


## Inicialização da aplicação:
  +    Instale o SQL Server e os pacotes Nugets referidos no requerimento acima.
  +    Abra o arquivo appsettings.json, altere a linha 10, “DefaultConnection”, e substitua os valores direcionando ao seu Servidor. Em seguida defina um nome para o Database a ser usado
Exemplo: 
~~~json
"DefaultConnection": "Server=<NOME DO SERVIDOR>;Database=<NOME DO DATASE>;Trusted_Connection=True;TrustServerCertificate=True;Encrypt=False"
~~~
  +    Salve o documento appsetttings.json
  +   Abra o Console do Gerenciador de Pacotes
  +    Digite os seguintes comandos para criar o Banco de Dados e Tabelas:
~~~
add-migration AddCategoryDb
update-database
~~~
  +    Após a criação do Banco de Dados, depure a aplicação para executá-la.



