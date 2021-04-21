using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xDesign.Models;

namespace xDesign.Services
{
    public class CsvService : ICsvService
    {
        public CsvService()
        {
        }
        
        public async Task<List<CsvModel>> LoadCsv()
        {
            return new List<CsvModel>();
        }
    }
}
