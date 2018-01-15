using IngenioTest.Core.DTO;
using System.Collections.Generic;

namespace IngenioTest.Core.Responses
{
    public class ExerciseBResponse : BasicResponse
    {
        public List<IngenioDto> IngenioDtos { get; set; }

        public ExerciseBResponse()
        {
            IngenioDtos = new List<IngenioDto>();
        }

    }
}
