using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;
using WebApplication3.TempDb;

namespace WebApplication3.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class PersonController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllPersons()
        {
            //IActionResult helps us automatically generate HttpResponses along with the object being returned
            //to the client

            //Assume a database query to get all persons
            var persons = MockDatabase.GetAll();

            //1. return 200 OK
            //2. return the persons object as JSON
            return Ok(persons);
        }

        [HttpGet("{Id}")]
        public IActionResult GetPersonById(int Id)
        {
            //Perform a database query to get the person by id
            //persons.Where(person => person.Id == Id).FirstOrDefault()

            var person = MockDatabase.GetById(Id);
            return Ok(person);

        }

        [HttpPut("{id}")]
        public IActionResult UpdatePerson(int id, Person updatedPerson)
        {
            MockDatabase.Update(id, updatedPerson);
            return Ok("Update Successful");
        }

        [HttpPost]
        public IActionResult CreatePerson(Person person)
        {
            MockDatabase.Create(person);

            return Ok("Create Successful");
        }

        [HttpDelete("{id}")]
        public IActionResult DeletePerson(int id)
        {
            MockDatabase.Delete(id);

            return Ok("Delete Successful");
        }



    }
}
