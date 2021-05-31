using System;
using Xunit;

namespace GradeBook.Tests
{
    public class BookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            var book= new Book("");
            book.AddGrade(64.56);
            book.AddGrade(82.44);
            book.AddGrade(54.56);
            book.AddGrade(92.44);


            var result=book.GetStatistics();

            Assert.Equal(73.5,result.Average,1);
            Assert.Equal(92.44,result.High);
            Assert.Equal(54.56,result.Low);
            Assert.Equal('C',result.Letter);

        }
    }
}
