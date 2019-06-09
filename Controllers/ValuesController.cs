using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Livraria.Controllers
{
    [Route("api/livros")]
    [ApiController]
    public class LivrosController : ControllerBase
    {
        // GET api/livros
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            Console.Write("teste");
            return new string[] 
            { 
                @"{'isbn': '8532530788', 'name': 'Harry Potter e a pedra filosofal', 'price' : '24,87', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }",
                @"{'isbn': '8532530796', 'name': 'Harry Potter e a Câmara Secreta', 'price' : '22,36', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }",
                @"{'isbn': '0439784549', 'name': 'Harry Potter and the Half-Blood Prince ', 'price' : '17.35', 'language' : 'English', 'publisher' : 'Arthur A. Levine Books', 'author' : 'J.K. Rowling' }"
            };
        }

        // GET api/livros/8532530788
        [HttpGet("{isbn}")]
        public ActionResult<string> Get(long isbn)
        {
            if(isbn == 8532530788)
                return "{'isbn': '8532530788', 'name': 'Harry Potter e a pedra filosofal', 'price' : '24,87', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }";
            else if(isbn == 8532530796)
                return "{'isbn': '8532530796', 'name': 'Harry Potter e a Câmara Secreta', 'price' : '22,36', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }";
            else if(isbn == 0439784549)
                return "{'isbn': '0439784549', 'name': 'Harry Potter and the Half-Blood Prince ', 'price' : '17.35', 'language' : 'English', 'publisher' : 'Arthur A. Levine Books', 'author' : 'J.K. Rowling' }";
            else
                return StatusCode(400, "Livro não encontrado!");
        }

        
        // GET api/livros/idioma/1
        [HttpGet("idiomas/{idIdioma}")]
        public ActionResult<IEnumerable<string>> Get(int idIdioma)
        {
            if(idIdioma == 1){
                return new string[] 
                { 
                    @"{'isbn': '8532530788', 'name': 'Harry Potter e a pedra filosofal', 'price' : '24,87', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }",
                    @"{'isbn': '8532530796', 'name': 'Harry Potter e a Câmara Secreta', 'price' : '22,36', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling' }"
                };
            }
            else if(idIdioma == 2){
                return new string[] 
                { 
                    @"{'isbn': '0439784549', 'name': 'Harry Potter and the Half-Blood Prince ', 'price' : '17.35', 'language' : 'English', 'publisher' : 'Arthur A. Levine Books', 'author' : 'J.K. Rowling' }"
                };
            }

            return StatusCode(400, "Id do idioma informado não existe");
        }


        // POST api/livros
        // JSON body (raw) example: "'isbn': '853253080', 'name': 'Harry Potter e o prisioneiro de Azkaban', 'price' : '26,58', 'language' : 'Português', 'publisher' : 'Rocco', 'author' : 'J.K. Rowling'"
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            if(string.IsNullOrEmpty(value))
                return StatusCode(400, "Não foi possível adicionar um novo livro!");
            
            return StatusCode(200, "Livro foi adicionado com sucesso!");
        }

        // PUT api/livros/5
        [HttpPut("{isbn}")]
        public ActionResult<string> Put(long isbn, [FromBody] string value)
        {
            if(isbn == 0)
                return StatusCode(400, "Livro não existe");
            
            return StatusCode(200, "Livro atualizado com sucesso no sistema!");
        }

        // DELETE api/livros/5
        [HttpDelete("{isbn}")]
        public ActionResult<string> Delete(long isbn)
        {
            if(isbn == 0)
                return StatusCode(400, "Livro não existe");
            
            return StatusCode(200, "Livro deletado com sucesso do sistema!");
        }
    }

    [Route("api/livros/promocoes")]
    [ApiController]
    public class LivrosPromocoesController : ControllerBase
    {
        // GET api/livros
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] 
            { 
                @"{'isbn': '0439784549', 'name': 'Harry Potter and the Half-Blood Prince ', 'price' : '17.35', 'language' : 'English', 'publisher' : 'Arthur A. Levine Books', 'author' : 'J.K. Rowling' }"
            };
        }
    }

    [Route("api/livros/{isbn}/comentarios")]
    [ApiController]
    public class LivrosComentariosController : ControllerBase
    {
        // GET api/livros/8532530788/comentarios
        [HttpGet]
        public ActionResult<string> Get(long isbn)
        {
            if(isbn == 8532530788)
                return "{'author':'John', 'comment':'Livro maravilhoso', 'date':'2019/06/01' }";
            else if(isbn == 8532530796)
                return "{'author':'Bill', 'comment':'Otimo livro, recomendo a todos', 'date':'2019/04/04' }";
            else if(isbn == 0439784549)
                return "{}";
            else
                return StatusCode(400, "Livro não encontrado, nenhum comentário retornado!");
        }

        // POST api/livros/8532530788/comentarios
        // JSON body (raw) example: "'author':'Alice', 'comment':'O livro é melhor do que o filme!', 'date':'2019/09/06'"
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            if(string.IsNullOrEmpty(value))
                return StatusCode(400, "Não foi possível adicionar um novo comentário!");
            
            return StatusCode(200, "Comentário foi adicionado com sucesso ao livro!");
        }
    }

    [Route("api/compras")]
    [ApiController]
    public class ComprasController : ControllerBase
    {
        // GET api/compras
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] 
            { 
                @"{'isbn': '0439784549', 'price' : '17.35', 'quantity' : '1' }",
                @"{'isbn': '8532530796', 'price' : '22,36', 'quantity' : '1' }"
            };
        }

        // POST api/compras
        // JSON body (raw) example: "'isbn': '8532530788', 'price' : '24.87', 'quantity' : '1'"
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            if(string.IsNullOrEmpty(value))
                return StatusCode(400, "Não foi possível adicionar um novo produto ao carrinho de compras!");
            
            return StatusCode(200, "Produto adicionado com sucesso ao carrinho de compras!");
        }

        // DELETE api/compras/8532530796
        [HttpDelete("{isbn}")]
        public ActionResult<string> Delete(long isbn)
        {
            if(isbn == 0)
                return StatusCode(400, "Produto inválido!");
            
            return StatusCode(200, "Produto deletado com sucesso do carrinho de compras!");
        }
    }

    [Route("api/entregas")]
    [ApiController]
    public class EntregasController : ControllerBase
    {
        // GET api/entregas
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] 
            { 
                @"{'id': '1', 'totalPrice' : '33.99', 'status' : 'entregue', 'products' : [ {'id' = '2'}, {'id' = '3'}] }",
                @"{'id': '2', 'totalPrice' : '22.99', 'status' : 'enviado', 'products' : [ {'id' = '3'}, {'id' = '4'}] }"
            };
        }

        // GET api/entregas/1
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            if(id == 1)
                return "{'id': '1', 'totalPrice' : '33.99', 'status' : 'entregue', 'products' : [ {'id' = '2'}, {'id' = '3'}] }";
            else if(id == 2)
                return "{'id': '2', 'totalPrice' : '22.99', 'status' : 'enviado', 'products' : [ {'id' = '3'}, {'id' = '4'}] }";
            else
                return StatusCode(400, "Entrega não localizada!");
        }

        // POST api/entregas
        // JSON body (raw) example: "'id': '3', 'totalPrice' : '110.99', 'status' : 'aguardando pagamento', 'products' : [ {'id' = '8'}, {'id' = '9'}] }"
        [HttpPost]
        public ActionResult<string> Post([FromBody] string value)
        {
            if(string.IsNullOrEmpty(value))
                return StatusCode(400, "Não foi possível adicionar uma nova entrega ao sistema!");
            
            return StatusCode(200, "Nova entrega cadastrada!");
        }
    }
}
