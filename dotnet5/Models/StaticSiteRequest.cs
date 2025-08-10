namespace dotnet5.Models
{
    public class StaticSiteRequest
    {
        public string Slug { get; set; } = string.Empty;
        public string StorageAccount { get; set; } = string.Empty;
        public string DomainName { get; set; } = string.Empty;
        public string TenantId { get; set; } = string.Empty;
        public string UserId { get; set; } = string.Empty;
        public string WorkspaceId { get; set; } = string.Empty;
    }
}
