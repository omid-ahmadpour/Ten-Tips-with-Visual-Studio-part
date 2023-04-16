namespace Ten_Tips_with_Visual_Studio
{
    public class User
    {
        private readonly IUser user;
        private readonly IPerson person;
        private readonly IAccess access;

        public User(IUser user,
                    IPerson person,
                    IAccess access)
        {
            this.user = user;
            this.person = person;
            this.access = access;
        }

        public int Id { get; set; }

        public string Name { get; set; }
    }
}
