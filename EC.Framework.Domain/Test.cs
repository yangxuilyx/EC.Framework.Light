using Volo.Abp.Domain.Entities.Auditing;

namespace EC.Framework.Domain
{
    public class Test : FullAuditedEntity<long>
    {
        public string Name { get; set; }
    }
}