using Microsoft.AspNetCore.Mvc;

namespace API___controllers_and_routes.Controllers;

    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        public List<string> studentList = new();

        public StudentController()
        {
            studentList.Add("Isaiah");
            studentList.Add("Jesse");
        }
        [HttpGet] // use Get to get/pull Data
        [Route("GetStudents")] 
        public List<string>GetStudents()
        {
            return studentList;
        }

        [HttpPost] // used Post to add Data
        [Route("AddStudent/{studentName}")]

        // created another method
        public List<string> AddStudent(string studentName)
        {
            studentList.Add(studentName);
            return studentList;
        }

        [HttpDelete] // use delete to delete data - not really dont do this
        [Route("DeleteStudent/{studentName}")]

        public List<string> DeleteStudent(string studentName)
        {
            studentList.Remove(studentName);
            return studentList;
        }

        [HttpPut] // use put to update data
        [Route("UpdateStudent/{oldName}/{newName}")]

        public List<string> UpdateStudent(string oldName, string newName)
        {   
          studentList[studentList.IndexOf(oldName)] = newName;
          return studentList;
        }

    }
