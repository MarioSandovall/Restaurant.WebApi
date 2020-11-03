using System.Collections.Generic;

namespace Model.Models.Login
{
    public class UserLogin
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public IEnumerable<int> RoleIds { get; set; }

    }
}
