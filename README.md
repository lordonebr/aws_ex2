# lordonebr-aws_ex2
Código .NET da atividade 2 da disciplina API e Web Services (AWS) - Desenvolvimento de Web Full Stack

### Running the server
To run the server, run:

```
dotnet run
```

To access web services:  
   
* Recupera detalhes de todos os livros:
```
GET https://localhost:5001/api/livros
```
   
* Recupera detalhes de um livro em específico:
```
GET https://localhost:5001/api/livros/{isbn}
```

* Recupera detalhes de todos os livros do idioma especificado:
```
GET https://localhost:5001/api/livros/idiomas/{idIdioma}
```

* Recupera detalhes de todos os livros em promoção:
```
GET https://localhost:5001/api/livros/promocoes
```

* Recupera comentários de um livro em especifico:
```
GET https://localhost:5001/api/livros/{isbn}/comentarios
```

* Operação para criar um livro:
```
POST https://localhost:5001/api/livros
```

* Operação para editar um livro:
```
PUT https://localhost:5001/api/livros
```

* Operação para deletar um livro:
```
DELETE https://localhost:5001/api/livros
```

* Operação para criar um comentário em um livro:
```
POST https://localhost:5001/api/livros/{isbn}/comentarios 	
```

* Recupera todos os itens que estão no carrinho de compras:
```
GET https://localhost:5001/api/compras
```

* Operação para adicionar um produto no carrinho de compras:
```
POST https://localhost:5001/api/compras
```

* Operação para deletar um produto do carrinho de compras:
```
DELETE https://localhost:5001/api/compras
```

* Operação para adicionar um novo pedido de entrega:
```
POST https://localhost:5001/api/entregas
```

* Recupera o status de todas as entregas:
```
GET https://localhost:5001/api/entregas
```

* Recupera informações da entrega especificada:
```
GET https://localhost:5001/api/entregas/{idEntrega}
```

