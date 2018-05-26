namespace HM.Cloud.EntityFrameworkCore.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly CloudDbContext _context;

        public InitialHostDbBuilder(CloudDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultCreator(_context).Create();
            _context.SaveChanges();
        }
    }
}
