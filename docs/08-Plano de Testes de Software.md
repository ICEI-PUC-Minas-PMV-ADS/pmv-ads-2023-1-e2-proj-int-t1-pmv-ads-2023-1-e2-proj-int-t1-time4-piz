# Plano de Testes de Software
<p align="justify">
 
| **Caso de Teste** 	| **CT-01 - Visualizar a página principal**                                                          	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-01 - A aplicação deve apresentar na página principal informações sobre a história da pizzaria.   |
| Objetivo do Teste 	| Verificar se a carga da página inicial está acontecendo corretamente.                               |
| Passos 	           | 1. Acessar o Navegador <br> 2. Informar o endereço do Site <br> 3. Visualizar a página principal    |
| Critério de Êxito  | Todos os textos, imagens e ícones devem ser carregados totalmente.                                  |

 
| **Caso de Teste** 	| **CT-02 - Visualizar o cardápio**                                                                  	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-02 -  A aplicação deve apresentar, para cada pizza, uma imagem correspondente. (thumbnail) <br> RF-03 - A aplicação deve permitir ao usuário visualizar o cardápio completo da pizzaria com todos os detalhes dos ingredientes.                                         |
| Objetivo do Teste 	| Verificar se a aplicação apresenta corretamente o cardápio.                                         |
| Passos 	           | 1. Acessar o Navegador <br> 2. Informar o endereço do Site <br> 3. Acessar o menu do cardápio <br> 4. Verificar se as imagens e as informações das pizzas estão carregando corretamente                                                                                   |
| Critério de Êxito  | As informações das pizzas devem ser exibidas corretamente no site, sendo necessários pelo menos 5 sabores sendo apresentados. <br> As imagens das pizzas devem estar relacionadas ao sabor.                                                                              |


| **Caso de Teste** 	| **CT-03 - Cadastrar sabores e ingredientes**                                                         |
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-04 - A aplicação deve permitir ao gestor cadastrar, alterar e remover sabores de pizzas, ingredientes e promoções.<br> RF-05 - A aplicação deve permitir que o usuário adicione e remova ingredientes.<br> RF-12 - A aplicação deve permitir o cadastro e atualização dos produtos de estoque pelos funcionários. |
| Objetivo do Teste 	| Verificar se os produtos são cadastrados, editados e excluídos.               |
| Passos 	           | 1. Acessar o Navegador <br> 2. Informar o endereço do Site <br> 3. Acessar o perfil de administrador <br> 4. Clicar em criar novo, clicar em editar e clicar em remover <br> 5. Adicionar, editar e remover as informações <br> 6. Salvar|
| Critério de Êxito  | Verificar se o usuário consegue adicionar, editar e remover novos sabores, ingredientes e promoções.<br> Verificar se o usuário consegue adicionar, editar e remover um novo sabor.|
  
| **Caso de Teste** 	| **CT-04 - Realizar pedidos**                                                                       	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-06 - A aplicação permite que o usuário realize os seus pedidos diretamente por ele.              |
| Objetivo do Teste 	| Verificar se os produtos que o cliente seleciona estão sendo adicionados ao carrinho.               |
| Passos 	           | 1. Acessar o Navegador <br> 2. Informar o endereço do Site <br> 3. Acessar o cardápio <br> 4. Adicionar uma pizza no carrinho <br> 5. Clicar em Realizar Pedido                                                                                                            |
| Critério de Êxito  | Verificar se o usuário consegue adicionar a pizza no carrinho.<br> Verificar se o usuário consegue adicionar a bebida no carrinho.|
 
| **Caso de Teste** 	| **CT-05 - Relatório de estoque**                                                                              	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-07- A aplicação deve oferecer ao gestor uma funcionalidade de relatório de estoque dos produtos da pizzaria.|
| Objetivo do Teste 	| Geração de relatório para verificar o estoque.                                                      |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Preencher campo de usuário<br>5. Preencher o campo da senha<br>6. Clicar em Entrar<br>7. No menu, clicar em gerar relatório<br>8. Clicar no botão gerar                       |
| Critério de Êxito  | O relatório de estoque será gerado com sucesso                                     .                                  |

 | **Caso de Teste** 	| **CT-06 - Contatos**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-08 - A aplicação deve permitir visualizar as informações de contatos do desenvolvedor do site.                  |
| Objetivo do Teste 	| Verificar se o usuário consegue se ver os contados do site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar o rodapé do site <br>4. Verificar se os contatos aparecem|
| Critério de Êxito  | Irá aparecer uma página com os contatos do site  
 
 | **Caso de Teste** 	| **CT-07 - Relatório de Vendas**                                                                    |
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-09 - A aplicação deve oferecer ao gestor uma funcionalidade de relatório de vendas..             |
| Objetivo do Teste 	| Verificar se o administrador consegue gerar o relatório de vendas.                                  |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login de administrador<br>4. Clicar gerenciamento <br>5. Clicar em relatório de vendas<br>6. Gerar relatório|
| Critério de Êxito  | Irá gerar um relatório de vendas.   
 
| **Caso de Teste** 	| **CT-08 - Cadastrar usuário**                                                                      	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-10 - A aplicação deve permitir que qualquer usuário possa se cadastrar no site.                  |
| Objetivo do Teste 	| Verificar se o usuário consegue se cadastrar no site.                                               |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Clicar em cadastrar<br>5. Informar os dados necessários<br>6. Salvar dados|
| Critério de Êxito  | Irá aparecer uma mensagem como: O cadastro foi realizado com sucesso.                                                               |
 
| **Caso de Teste** 	| **CT-09  - Login de usuário**                                                           	             |
|--------------------|--------------------------------------------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-11 - A aplicação deve permitir que os usuários realizem seus pedidos após a realização do login                |
| Objetivo do Teste 	| Verificar se o usuário consegue ver os dados do próprio cadastro.                                                                    |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login<br>4. Preencher o campo de usuário<br>5. Preencher o campo da senha<br>6. Clicar em Entrar |
| Critério de Êxito  | As informações fornecidas pelo usuário devem ser compatíveis com as do cadastro.<br> A aplicação deverá realizar o login com sucesso.|
 
| **Caso de Teste** 	| **CT-10  - Atualização de estoque**                                                           	             |
|--------------------|--------------------------------------------------------------------------------------------------------------------------------------|
|	Requisito Associado| RF-12 - A aplicação deve permitir o cadastro e atualização dos produtos de estoque pelos funcionários. |
| Objetivo do Teste 	| Verificar se o usuário consegue adicionar, editar e excluir os produtos no estoque.                                                                                         |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Acessar a aba de login como administrador <br>4. Ir na aba gerenciamento <br>5. ir na aba de cadastrar produtos <br>6. Clicar em salvar |
| Critério de Êxito  | As informações do estoque devem ser adicionadas, editadas e excluídas com sucesso.|
 



