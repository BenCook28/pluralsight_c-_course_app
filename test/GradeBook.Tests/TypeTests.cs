// using System;
// using Xunit;

// namespace GradeBook.Tests
// {
//     public class TypeTests
//     {
//         [Fact]
//         public void GetBookReturnsDifferentObjects()
//         {
//            var book1 = GetBook("Book 1");
//            var book2 = GetBook("Book 2");

//            Assert.Equal("Book 1", book1.name);
//            Assert.Equal("Book 2", book2.name);
//            Assert.Same(book1, book2); 
//         }

//         [Fact]
//         public void TwoVarsCanReferenceSameObject()
//         {
//            var book1 = GetBook("Book 1");
//            var book2 = book1;

//            Assert.Same(book1, book2);
//         }

//         Book GetBook(string name)
//         {
//             return new Book(name);
//         }
//     }
// }
