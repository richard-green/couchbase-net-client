using System.Threading;

namespace Couchbase.Management
{
    public class ScopeExistsOptions
    {
        public CancellationToken CancellationToken { get; set; }

        public ScopeExistsOptions WithCancellationToken(CancellationToken cancellationToken)
        {
            CancellationToken = cancellationToken;
            return this;
        }

        public static ScopeExistsOptions Default => new ScopeExistsOptions();
    }
}