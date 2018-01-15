using IngenioTest.Core.Repos;
using IngenioTest.Core.Responses;
using System;
using System.Configuration;

namespace IngenioTest.Core.Controllers
{
    public interface IIngenioController
    {
        ExerciseAResponse GetExerciseA(int id);
        ExerciseBResponse GetExerciseb(int level);
    }
    public class IngenioController : IIngenioController
    {
        private readonly IIngenioRepo _ingenioRepo;

        public IngenioController() : this(new IngenioRepo()) { }

        public IngenioController(IIngenioRepo ingenioRepo)
        {
            _ingenioRepo = ingenioRepo;
        }

        public ExerciseAResponse GetExerciseA(int id)
        {
            var response = new ExerciseAResponse();
            try
            {
                response.Ingenio = _ingenioRepo.GetIngenioById(id);
                response.Acknowledgement = true;
                response.Message = "Success";
            }
            catch (Exception e)
            {
                response.Acknowledgement = false;
                response.Message = "Error: " + e.Message;
                throw new ConfigurationException("Handle Any Business logic error");
            }
            return response;
        }

        public ExerciseBResponse GetExerciseb(int level)
        {
            var response = new ExerciseBResponse();
            try
            {
                response.IngenioDtos = _ingenioRepo.GetIngenioByHierarchyLevel(level);
                response.Acknowledgement = true;
                response.Message = "Success";
            }
            catch (Exception e)
            {
                response.Acknowledgement = false;
                response.Message = "Error: " + e.Message;
                throw new ConfigurationException("Handle Any Business logic error");
            }
            return response;
        }
    }
}

