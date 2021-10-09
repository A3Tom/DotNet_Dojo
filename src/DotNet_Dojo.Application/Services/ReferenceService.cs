using DotNet_Dojo.Application.Services.Abstract;
using DotNet_Dojo.Domain.Dtos;
using System.Threading.Tasks;

namespace DotNet_Dojo.Application.Services
{
    public class ReferenceService : IReferenceService
    {
        private readonly object _referenceLock = new();
        private ReferenceDto _reference;

        public async Task<bool> SetReference(ReferenceDto reference)
        {
            return await Task.Run(() =>
            {
                lock (_referenceLock)
                {
                    _reference = reference;
                    
                    return _reference == reference;
                }
            });
        }

        public async Task<ReferenceDto> GetReference()
        {
            return await Task.Run(() =>
            {
                lock (_referenceLock)
                {
                    return _reference;
                }
            });
        }
    }
}
