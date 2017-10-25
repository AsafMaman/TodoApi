
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class TodoController:Controller{
        public TodoController(){

        }
        [HttpGet]
        public IEnumerable<TodoItem> GetAll(){
            var items=new List<TodoItem>{
                new TodoItem{Id=1,Name="Item 1",IsComplete=false},
                new TodoItem{Id=2,Name="Item 2",IsComplete=false},
                new TodoItem{Id=3,Name="Item 3",IsComplete=true},
            };
            
            return items;
        } 
        [HttpGet("{id}",Name="GetTodo")]
        public IActionResult GetItemById(long id){
            var item=new TodoItem{Id=id,Name="item "+id,IsComplete=true};
            return new OkObjectResult(item);
        }
    }
}