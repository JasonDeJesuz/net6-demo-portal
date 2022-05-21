using sheeple.Data.Context;

namespace sheeple.Data.Services
{
    public interface IsheepleContextService
    {
        /// <summary>
        /// Directly get the will app context - Just playing around
        /// </summary>
        /// <returns></returns>
        public sheepleContext GetDatabaseContext();
    }
}