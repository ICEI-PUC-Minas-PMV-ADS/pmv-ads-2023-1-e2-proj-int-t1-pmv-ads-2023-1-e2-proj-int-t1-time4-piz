# Programação de Funcionalidades

A medida que os requisitos funcionais foram implementados na aplicação, foram gerados artefatos. A correlação está descrita na tabela abaixo:

|ID    | Descrição do Requisito  | Artefato(s) produzido(s) |
|------|---------------------------------------------------------------------------------------------------------------------------------|----------|
|RF-001|A aplicação deve apresentar na página principal informações sobre a história da pizzaria.       | PizzApp/views/home/index.cshtml | 
|RF-002|A aplicação deve apresentar, para cada pizza, uma imagem correspondente. (thumbnail).           | PizzApp/views/pizza/list.cshtml     |
|RF-003|A aplicação deve permitir ao usuário visualizar o cardápio completo da pizzaria com todos os detalhes dos ingredientes. | PizzApp/views/pizza/list.cshtml | 
|RF-004|A aplicação deve permitir ao gestor cadastrar, alterar e remover sabores de pizzas, ingredientes e promoções.| PizzApp/Areas/Admin/Views/AdminPizzas/index.cshtml; create.cshtml; edit.cshtml; delete.cshtml| 
|RF-005|A aplicação deve permitir que o usuário adicione e remova ingredientes.                         | PizzApp/Views/Pizza/details.cshtml    | 
|RF-006|A aplicação permite que o usuário realize os seus pedidos diretamente por ele.                  | PizzApp/PizzApp/Views/CarrinhoCompra/index.cshtml | 
|RF-007|A aplicação deve oferecer ao gestor uma funcionalidade de relatório de estoque dos produtos da pizzaria.   | PizzApp/PizzApp/Areas/Admin/Views/AdminRelatorioEstoque/index.cshtml; criar.cshtml; editar.cshtml; GerarRelatorio.cshtml; RemoverConfirmacao.cshtml     | 
|RF-008|A aplicação deve permitir visualizar as informações de contatos do mantenedor do site.           | PizzApp/Views/Contato/Index.cshtml    | 
|RF-009|A aplicação deve oferecer ao gestor uma funcionalidade de relatório de vendas.           | PizzApp/Areas/Admin/Servicos/RelatorioVendasService.cs   | 
|RF-010|A aplicação deve permitir que qualquer usuário possa se cadastrar no site.                           | PizzApp/Views/Account/Register.cshtml| 
|RF-011|A aplicação deve permitir que os usuários realizem seus pedidos após a realização do login            | PizzApp/Views/Pedido/Checkout.cshtml | 
|RF-012|A aplicação deve permitir o cadastro e atualização dos produtos de estoque pelos funcionários|PizzApp/Areas/Funcionarios/Views/FuncionarioRelatorioEstoque/index.cshtml; criar.cshtml; editar.cshtml; RemoverConfirmacao.cshtml| 

# Instruções de acesso

A aplicação está disponível através do link:
[PizzApp](https://pizzapp20230613222420.azurewebsites.net/).
<br><br>
Para testes de usuário do tipo "cliente", o registro é livre.<br>
Para testes de usuário do tipo "funcionário", utilizar a credencial: usuário - funcionarios@localhost / senha - Numsey#2022<br>
Para testes de usuário do tipo "administrador", utilizar a credencial: usuário - admin@localhost / senha - Numsey#2022
