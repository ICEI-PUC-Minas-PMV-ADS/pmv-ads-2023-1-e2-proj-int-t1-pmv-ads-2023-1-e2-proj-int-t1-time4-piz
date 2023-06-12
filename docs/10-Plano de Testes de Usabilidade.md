# Plano de Testes de Usabilidade

Para o teste de usabilidade, será realizado um questionário de UX através da plataforma Google Forms, onde os usuários testados responderão às seguintes perguntas com cinco opções de respostas (Discordo totalmente / Discordo / Neutro / Concordo / Concordo totalmente): 

    1. Acho que gostaria de usar este sistema com frequência
    2. Achei o sistema desnecessariamente complexo.
    3. Achei o sistema fácil de usar.
    4. Achei que seria necessário o apoio de um técnico para poder usar este sistema.
    5. As funções deste sistema estavam bem integradas.
    6. Achei este sistema muito inconsistente.
    7. Imagino que a maioria das pessoas aprenderiam a usar este sistema rapidamente.
    8. Achei o sistema muito complicado de usar.
    9. Eu me senti muito confiante com o sistema.
    10. Eu preciso aprender um monte de coisas antes de continuar usando este sistema.
    11. Eu me senti confortável com este sistema.
    12. Foi fácil encontrar a informação que eu precisava.
    13. Eu gostei de usar a interface do sistema.
    14. A interface do sistema é agradável.
    15. A organização de informações na tela do sistema é clara.


Com base nas informações coletadas, a equipe de desenvolvimento da aplicação realizará possíveis ajustes e melhorias.


| **Caso de Teste** 	| **CT-12 - Responsividade**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-002	A aplicação deverá ser responsiva permitindo a visualização em diferentes telas de forma adequada   |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a aplicação em outros aparelhos, para verificar se é responsiva.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Testar a aplicação em outros aparelhos, como celular, ipad e computador                      |
| Critério de Êxito  | A aplicação é responsiva com todos os meios de acesso, como celular, ipad e computador.                                  | 

| **Caso de Teste** 	| **CT-13 - Navegadores**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-04- A aplicação deve ser compatível com os principais navegadores do mercado (Google Chrome, Firefox, Microsoft Edge).   |
| Objetivo do Teste 	| Verificar se o usuário consegue visualizar a aplicação interativa em outros navegadores.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Testar a aplicação em outros navegadores                      |
| Critério de Êxito  | A aplicação é compatível com os principais navegadores do mercado.                                  | 

| **Caso de Teste** 	| **CT-14 - Usuários**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-005	A aplicação não permite o recebimento de cadastros de usuários com dados necessários em branco.   |
| Objetivo do Teste 	| Verificar se o usuário consegue cadastrar sem preencher dados, deixando em branco.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. ir em registrar <br> 4. Tentar cadastrar um usuário sem dados. <br> 5. salvar dados|
| Critério de Êxito  | Não irá permitir o cadastro do usuário pois precisa preencher os dados.                                  | 


| **Caso de Teste** 	| **CT-15 - Erro de cadastro e login**                                                                           	|
|--------------------|-----------------------------------------------------------------------------------------------------|
|	Requisito Associado| RNF-006	A aplicação deverá informar o erro de cadastro e login para o usuário caso os dados inseridos não estejam no banco de dados.   |
| Objetivo do Teste 	| Verificar se quando for fazer o cadastro ou login irá retornar um erro e/ou falha.                                     |
| Passos 	           | 1. Acessar o Navegador<br>2. Informar o endereço do Site<br>3. Realizar o cadastro equivocados. <br> 4. Verificar se mostra a falha|
| Critério de Êxito  | Irá retornar uma falha no registro do usuário.                                  | 




