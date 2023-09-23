

using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FirstMVCApplication.Models
{
    public class AuthorRepository
    {
        public static Dictionary<int, Author> GetAuthorDictinory()
        {
            String fiName = @"c:\temp\author.txt";
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            bool isFileExists = System.IO.File.Exists(fiName);
            if (isFileExists)
            {
                using (StreamReader sr = new StreamReader(fiName))
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
        private static Author StringToAuthor(String[] data, Author author)
        {
            author.AuthorID = int.Parse(data[0]);
            author.AuthorName = data[1];
            author.AuthorDOB = (data[2]);
            author.NoOfBooksPublished = int.Parse(data[3]);
            author.RoyaltyCompany = data[4];
            return author;
        }
        //public static List<Author> GetAuthorList() { }
        public static Author FindAuthorById(int id)
        {
            Dictionary<int, Author> list = new Dictionary<int, Author>();
            Author author = null;
            if (list != null)
            {
                author = list.FirstOrDefault(x => (x.Key == id)).Value;
            }
            return author;
        }
        public static void SaveToFile(Author pAuthor)
        {
            String fName = @"c:\temp\author.csv";
            string strAuthor = $"{pAuthor.AuthorID}, {pAuthor.AuthorName},{pAuthor.RoyaltyCompany}, {pAuthor.NoOfBooksPublished},{pAuthor.AuthorDOB}";
            using (StreamWriter sw = new StreamWriter(fName, true))
            {
                sw.WriteLine(strAuthor);
            }
        }
        public static void RemoveAuthor(int id)
        {
            String fName = @"c\temp\Author.csv";
            Dictionary<int, Author> list = AuthorRepository.GetAuthorDictinory();
            string strAuthor = String.Empty;
            using (StreamWriter sw = new StreamWriter(fName))
            {
                foreach (Author author in list.Values)
                {
                    if (author.AuthorID != id)
                        strAuthor = $"{author.AuthorID},{author.AuthorName}{author.AuthorDOB},{author.NoOfBooksPublished},{author.RoyaltyCompany} {Environment.NewLine}";
                    sw.WriteLine(strAuthor);
                }
            }
        }

        public static void SaveAllAuthorsToFile(Dictionary<int, Author> pAuthorList) { }
        public static void UpdateAuthorToFile(Author pAuthor)
       { 
                String fname = @"c:\temp\author.csv";
                Dictionary<int, Author> list = AuthorRepository.GetAuthorDictinory();
                string strAuthor = String.Empty;
                using (StreamWriter sw = new StreamWriter(fname))
                {
                    foreach (Author author in list.Values)
                    {
                        if (author.AuthorID != pAuthor.AuthorID)
                            strAuthor = $"{author.AuthorID},{author.AuthorName},{author.AuthorDOB},{author.NoOfBooksPublished},{author.RoyaltyCompany}";
                        else
                            strAuthor = $"{pAuthor.AuthorID},{pAuthor.AuthorName},{pAuthor.AuthorDOB},{pAuthor.NoOfBooksPublished},{pAuthor.RoyaltyCompany}";
                        sw.WriteLine(strAuthor);
                    }
                }
       }

        
    }
}