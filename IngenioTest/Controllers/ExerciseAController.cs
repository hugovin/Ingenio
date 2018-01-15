using IngenioTest.Core.Controllers;
using IngenioTest.Core.Responses;
using System.Web.Http;

namespace IngenioTest.Controllers
{
    public class ExerciseAController : ApiController
    {
        private readonly IIngenioController _ingenioController;

        public ExerciseAController() : this(new IngenioController())
        {
        }

        public ExerciseAController(IIngenioController ingenioController)
        {
            _ingenioController = ingenioController;
        }

        // GET api/ExerciseA/5
        public ExerciseAResponse Get(int id)
        {
            return _ingenioController.GetExerciseA(id);
        }
    }
}
