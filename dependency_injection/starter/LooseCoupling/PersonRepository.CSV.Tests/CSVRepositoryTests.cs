using NUnit.Framework;
using System;
using System.IO;
using System.Linq;

namespace PersonRepository.CSV.Tests
{
    public class CSVRepositoryTests
    {
        [Test]
        public void GetPeople_WithEmptyFile_ReturnsEmptyList()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void GetTask_WithNoFile_ThrowsFileNotFoundException()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void GetPeople_WithGoodRecords_ReturnsGoodRecords()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void GetPeople_WithBadRecords_ReturnsGoodRecords()
        {
            Assert.Inconclusive();
        }

        [Test]
        public void GetPeople_WithOnlyBadRecord_ReturnsEmptyList()
        {
            Assert.Inconclusive();
        }

    }
}
