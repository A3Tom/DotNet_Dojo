using DotNet_Dojo.Application.Services.Abstract;
using DotNet_Dojo.Domain.Dtos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet_Dojo.Command.UseCases.Reference.Handlers
{
    public class GetExampleReference : IRequestHandler<GetExampleReferenceRequest, ReferenceDto>
    {
        private readonly IReferenceService _referenceService;

        public GetExampleReference(IReferenceService referenceService)
        {
            _referenceService = referenceService ?? throw new ArgumentNullException(nameof(referenceService));
        }

        public async Task<ReferenceDto> Handle(GetExampleReferenceRequest request, CancellationToken cancellationToken)
        {
            return await _referenceService.GetReference();
        }
    }

    public class GetExampleReferenceRequest : IRequest<ReferenceDto>
    {
    }
}
