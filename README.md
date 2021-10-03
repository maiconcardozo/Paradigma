# Paradigma



## Exercício 2

--Criei uma tabela temporária onde guardo o valor máximo do salário sem o nome da pessoa que é a única coisa que impede de ser pesquisado com apenas um select

WITH TabelaTemporaria AS (select  max(salario) Salario,Departamento.Nome from pessoa as p
join Departamento on Departamento.Id = p.DepartamentoId
group by 
Departamento.Nome)


--Assim posso fazer a pesquisa com as colunas que eu quero usando in baseado na minha tabela temporária 

SELECT * from Pessoa 
join Departamento on Departamento.Id = pessoa.DepartamentoId
WHERE pessoa.Salario IN (SELECT Salario FROM TabelaTemporaria)
AND Departamento.Nome IN (SELECT Departamento.Nome FROM TabelaTemporaria)

--Fiz desse modo para evitar colocar coisas fixas na query, então cada vez que criar um departamento novo não preciso me preocupar em mexer na query.


