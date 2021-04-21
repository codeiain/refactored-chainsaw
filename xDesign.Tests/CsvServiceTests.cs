using System;
using System.Collections.Generic;
using Xunit;
using Moq;
using xDesign.Models;
using xDesign.Services;
using FluentAssertions;

namespace xDesign.Tests
{
    public class CsvServiceTests
    {
        private readonly ICsvService _csvService;
        private List<CsvModel> _refData;
        public CsvServiceTests()
        {
            _csvService = new CsvService();
            _refData = new List<CsvModel>();
        }
        
        [Fact]
        public async void Test1()
        {
            var result = await _csvService.LoadCsv();
            result.Should().BeEquivalentTo(new List<CsvModel>());
        }
    }
}
