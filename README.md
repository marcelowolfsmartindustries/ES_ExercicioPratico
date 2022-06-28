# Euro-millions is a lucky or unlucky game?
Cada chave do Euro Milhões contém 5 números distintos [1-50] e 2 estrelas distintas [1-11]. 

Deverá criar uma aplicação ASP.NET MVC Core Web (sem autenticação) com os seguintes requisitos:

1. Registar uma ou mais chaves por utilizador introduzindo números, estrelas e data do registo da aposta. Esta informação deve ser armazenada numa base de dados (SQLite, PostgreSQL, etc).
2. Permitir gerar e inserir uma chave aleatória. É necessário indicar apenas o nome do utilizador. A data da aposta é colocada automaticamente no dia atual.
3. Deverá ser possível listar todas as chaves inseridas.
4. Deverá ser possível apagar uma chave inserida anteriormente.

Dica: Exemplo de geração de números aleatórios.
![image](https://user-images.githubusercontent.com/98460923/176059731-f293128f-2ee3-44d7-963e-e76ed79ad933.png)

5. Pretende-se agora verificar quais são os prémios obtidos em determinado dia. O utilizador deve indicar uma data e a aplicação deve listar o prémio consoante a tabela abaixo para cada aposta registada nesse dia.

![image](https://user-images.githubusercontent.com/98460923/176059639-91d481ef-f69f-4809-b20b-469c78ca4a45.png)

6. Deverá realizar testes unitários para a verificação do prémio da pergunta anterior.
