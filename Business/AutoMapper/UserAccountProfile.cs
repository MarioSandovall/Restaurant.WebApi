using AutoMapper;
using Business.Extensions;
using Domain.Entities;
using Model.Models.Login;

namespace Business.AutoMapper
{
    public class UserAccountProfile : Profile
    {
        public UserAccountProfile()
        {
            CreateMap<UserEf, UserAccount>().ConvertUsing(ConvertFrom_Entity_To_Model);
        }

        private UserAccount ConvertFrom_Entity_To_Model(UserEf entity, UserAccount model)
        {
            var instance = model ?? new UserAccount();

            instance.Email = entity.Email;
            instance.FullName = $"{entity.Name} {entity.LastName}";
            instance.Image = entity.ImagePath.ToImage();

            return instance;
        }
    }
}
