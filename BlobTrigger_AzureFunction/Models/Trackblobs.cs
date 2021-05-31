using System;

namespace BlobTrigger_AzureFunction.Models
{
   public class FileRecords
    {
        public Guid Id { get; set; } = System.Guid.NewGuid();
        public string FileName { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
    }
}
