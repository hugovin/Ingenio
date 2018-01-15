using AutoMapper;
using IngenioTest.Core.DTO;
using IngenioTest.Data;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;

namespace IngenioTest.Core.Repos
{
    public interface IIngenioRepo
    {
        IngenioDto GetIngenioById(int id);
        List<IngenioDto> GetIngenioByHierarchyLevel(int level);
    }
    public class IngenioRepo : IIngenioRepo
    {
        public IngenioDto GetIngenioById(int id)
        {
            var response = new IngenioDto();
            try
            {
                var config = new MapperConfiguration(cfg =>
                {

                    cfg.CreateMap<Ingenio, IngenioDto>();

                });
                IMapper iMapper = config.CreateMapper();
                var context = new IngenioTestEntities();
                response = iMapper.Map<Ingenio, IngenioDto>(context.Ingenios.FirstOrDefault(x => x.CategoryId == id));
            }
            catch (Exception e)
            {
                throw new ConfigurationException("Handle Any SQL Error");
                //TODO Logging the error 
            }
            return response;
        }

        public List<IngenioDto> GetIngenioByHierarchyLevel(int level)
        {
            var response = new List<IngenioDto>();
            try
            {
                var config = new MapperConfiguration(cfg =>
                {

                    cfg.CreateMap<ExerciseB_Result, IngenioDto>();

                });
                IMapper iMapper = config.CreateMapper();
                var context = new IngenioTestEntities();
                var sprocResult = context.ExerciseB(level);
                foreach (var obj in sprocResult)
                {
                    response.Add(iMapper.Map<ExerciseB_Result, IngenioDto>(obj));
                }

            }
            catch (Exception e)
            {
                throw new ConfigurationException("Handle Any SQL Error");
                //TODO Logging the error 
            }
            return response;
        }
    }
}
