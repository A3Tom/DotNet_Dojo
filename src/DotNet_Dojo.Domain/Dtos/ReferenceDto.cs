using System.Collections.Generic;

namespace DotNet_Dojo.Domain.Dtos
{
    public class ReferenceDto
    {
        public string ReferenceName { get; init; }

        public IDictionary<string, string> References { get; init; }
    }
}
