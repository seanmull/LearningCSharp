using System.Collections.Generic;

namespace LearningC_.LambdaExpressions
{
    public class BookRepository
    {
        public List<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Title 1", Price = 5},
                new Book() {Title = "Title 2", Price = 15},
                new Book() {Title = "Title 3", Price = 25}
            };
        }
    }
}