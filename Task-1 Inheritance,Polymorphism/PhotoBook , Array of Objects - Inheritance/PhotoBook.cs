using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class PhotoBook
    {
        protected int numPages = 16;

        public PhotoBook() { }
        public PhotoBook(int noOfPages)
        {
            this.numPages = noOfPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }
    }
    public class BigPhotoBook : PhotoBook
    {

        public BigPhotoBook()
        {
            this.numPages = 64;
        }

    }
    public class PhotoBookTest
    {
        private static void Main(string[] args)
        {
            PhotoBook book1 = new PhotoBook();
            PhotoBook book2 = new PhotoBook(24);
            Console.WriteLine(book1.GetNumberPages());
            Console.WriteLine(book2.GetNumberPages());
            BigPhotoBook bigPhotoBook = new BigPhotoBook();
            Console.WriteLine(bigPhotoBook.GetNumberPages());
        }
    }
}

