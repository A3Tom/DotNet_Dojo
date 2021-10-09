using DotNet_Dojo.Application.Services.Abstract;
using DotNet_Dojo.Domain.Dtos;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DotNet_Dojo.Command.UseCases.Reference.Handlers
{
    public class SetExampleReference : IRequestHandler<SetExampleReferenceRequest, bool>
    {
        private readonly IReferenceService _referenceService;

        public SetExampleReference(IReferenceService referenceService)
        {
            _referenceService = referenceService ?? throw new ArgumentNullException(nameof(referenceService));
        }

        public async Task<bool> Handle(SetExampleReferenceRequest request, CancellationToken cancellationToken)
        {
            return await _referenceService.SetReference(request.Reference);
        }
    }

    public class SetExampleReferenceRequest : IRequest<bool>
    {
        public ReferenceDto Reference { get; init; }
    }
}
