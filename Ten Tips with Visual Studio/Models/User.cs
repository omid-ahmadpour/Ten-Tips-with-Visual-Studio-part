using Ten_Tips_with_Visual_Studio.Interfaces;

namespace Ten_Tips_with_Visual_Studio.Models
{
    public class User
    {
        private readonly IUser user;
        private readonly IPerson person;
        private readonly IPermission access;

        public User(IUser user,
                   IPerson person,
                    IPermission access)
        {
            this.user = user;
            this.person = person;
            this.access = access;
        }

        public int Id { get; set; }

        public string Name { get; set; }

        void Add(User user)

        {
            // Do Something...
        }
    }
}
