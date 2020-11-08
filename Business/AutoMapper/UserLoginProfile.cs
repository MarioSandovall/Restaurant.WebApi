using AutoMapper;
using Business.Extensions;
using Domain.Entities;
using Model.Models.Login;
using System.Linq;

namespace Business.AutoMapper
{
    public class UserLoginProfile : Profile
    {
        public UserLoginProfile()
        {
            CreateMap<UserEf, UserLogin>().ConvertUsing(ConvertFrom_Entity_To_Model);
        }

        private UserLogin ConvertFrom_Entity_To_Model(UserEf entity, UserLogin model)
        {
            var instance = model ?? new UserLogin();

            instance.Id = entity.Id;
            instance.Email = entity.Email;
            instance.Image = entity.ImagePath.ToImage();
            instance.FullName = $"{ entity.Name} {entity.LastName}";
            instance.RoleIds = entity?.UserRoles.Select(x => x.RoleId).ToList();

            return instance;
        }
    }
}
