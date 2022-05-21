using sheeple.Data.Context;

namespace sheeple.Data.Services
{
    public class sheepleContextService : IsheepleContextService
    {
        #region Members
        private readonly sheepleContext _context;
        #endregion

        #region Constructors
        public sheepleContextService(sheepleContext context)
        {
            _context = context;
        }
        #endregion
         
        public sheepleContext GetDatabaseContext()
        {
            return _context;
        }
    }
}