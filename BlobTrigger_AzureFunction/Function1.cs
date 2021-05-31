using System.IO;
using BlobTrigger_AzureFunction.Models;
using Microsoft.Azure.WebJobs;
using Microsoft.Extensions.Logging;


namespace BlobTrigger_AzureFunction
{
    public class Function1
    {
        #region Property
        private readonly AppDbContext appDbContext;
        #endregion

        #region Constructor
        public Function1(AppDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        #endregion

        [FunctionName("Triggerwhenfileuploads")]
        public void Run([BlobTrigger("filecontainer/{name}", Connection = "AzureWebJobsStorage")] Stream myBlob, string name, ILogger log)
        {
            log.LogInformation($"C# Blob trigger function Processed blob\n Name:{name} \n Size: {myBlob.Length} Bytes");
            appDbContext.FileRecords.Add(new FileRecords
            {
                FileName = name,
                IsCompleted = true
            });
             appDbContext.SaveChanges();
        }
    }
}
