using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using xDesign.Models;

namespace xDesign.Services
{
    public interface ICsvService
    {
        public Task<List<CsvModel>> LoadCsv();
    }
}
