using DotNet_Dojo.Domain.Dtos;
using System.Threading.Tasks;

namespace DotNet_Dojo.Application.Services.Abstract
{
    public interface IReferenceService
    {
        Task<bool> SetReference(ReferenceDto reference);

        Task<ReferenceDto> GetReference();
    }
}
