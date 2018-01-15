using IngenioTest.Core.Controllers;
using IngenioTest.Core.Responses;
using System.Web.Http;

namespace IngenioTest.Controllers
{
    public class ExerciseBController : ApiController
    {
        private readonly IIngenioController _ingenioController;

        public ExerciseBController() : this(new IngenioController())
        {
        }

        public ExerciseBController(IIngenioController ingenioController)
        {
            _ingenioController = ingenioController;
        }

        // GET api/ExerciseB/5
        public ExerciseBResponse Get(int level)
        {
            return _ingenioController.GetExerciseb(level);
        }
    }
}
