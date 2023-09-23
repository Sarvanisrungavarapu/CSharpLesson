using FirstOneMvcWebApp.Models;

namespace FirstOneMvcWebApp.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictionary()
        {
            String fName = @"C:\temp\author.csv";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fName))
                {
                    string strAuthor = $"{sr.ReadLine()}";
                    String[] data = strAuthor.Split(',');
                    Author author = null;
                    if (data.Length == 5)
                    {
                        author = StringToAuthor(data, new Author());
                        list.Add(author.AuthorID, author);
                        while (!sr.EndOfStream)
                        {
                            strAuthor = $"{sr.ReadLine()}";
                            data = strAuthor.Split(',');
                            if (data.Length == 5)
                            {
                                author = StringToAuthor(data, new Author());
                                list.Add(author.AuthorID, author);
                            }
                        }
                    }
                }
            }
            return list;
        }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            Author author = null;
            if(list!=null)
            {
                author = list.FirstOrDefault(x=>(x.Key==id)).Value;
            }
            return author;
        }
        //public static Author RemoveAuthor(int id)
        //{
        //}
        public static void SaveToFile(Author pauthor)
        {
            String fname = @"c:\temp\author.csv";
            string strAuthor = $"{pauthor.AuthorID},{pauthor.AuthorName},{pauthor.AuthorDOB},{pauthor.NoOfBooksPublished},{pauthor.RoyaltyCompany}";
            using (StreamWriter sw = new StreamWriter(fname, true))
            {
                sw.WriteLine(strAuthor);
            }
        }

        //public static void SaveAllAuthorToFile(Dictionary<int, Author>) { }
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDOB = DateTime.Parse(data[2]);
            author.NoOfBooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = data[4];
            return author;
        }
    }
}



