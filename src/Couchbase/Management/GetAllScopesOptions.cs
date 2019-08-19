using System.Threading;

namespace Couchbase.Management
{
    public class GetAllScopesOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public GetAllScopesOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static GetAllScopesOptions Default => new GetAllScopesOptions();
    }
}