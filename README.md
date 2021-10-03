# Paradigma

## Exercicio 1
 
Fiz o projeto no visual studio, não fiz nenhuma pesquisa especifica, só li um pouco sobre arvore binária, mas tentei fazer só usando o que sei, usei praticamente Linq e método recursivo pra percorrer e organizar a arvore.

Em breve ele estará no repositório desse github

## Exercício 2

--Criei uma tabela temporária onde guardo o valor máximo do salário sem o nome da pessoa que é a única coisa que impede de ser pesquisado com apenas um select

WITH TabelaTemporaria AS (select  max(salario) Salario,Departamento.Nome from Pessoa
JOIN Departamento on Departamento.Id = Pessoa.DepartamentoId
GROUP BY Departamento.Nome)

--Assim posso fazer a pesquisa com as colunas que eu quero usando in baseado na minha tabela temporária 

SELECT Departamento.Nome, Pessoa.Nome, Salario from Pessoa 
JOIN Departamento on Departamento.Id = pessoa.DepartamentoId
WHERE pessoa.Salario IN (SELECT Salario FROM TabelaTemporaria)
AND Departamento.Nome IN (SELECT Departamento.Nome FROM TabelaTemporaria)****

--Fiz desse modo para evitar colocar coisas fixas na query, então cada vez que criar um departamento novo não preciso me preocupar em mexer na query.

### Fonte: 
https://docs.microsoft.com/pt-br/previous-versions/sql/sql-server-2008-r2/ms190766(v=sql.105)?redirectedfrom=MSDN
https://docs.microsoft.com/pt-br/sql/t-sql/functions/max-transact-sql?view=sql-server-ver15


