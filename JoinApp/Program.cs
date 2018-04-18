using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //join - метод или ключевое слово которое служит для соедениня таблици(сущностей) по запросам
            // в качестве места соеденения служит общее свойство (столбец поле)
            using(ForbsContext context=new ForbsContext())
            {
                var result = from article in context.Articles//далее можно where а потом join
                             join author in context.Authors //where...
                             on article.AuthorInfo equals author.MainInfo
                             select new { Theme = article.Theme, Text = article.Text, AuthorInfo = author.MainInfo, AuthorName = author.Fullname, PublishedDate = article.PublishedDate };




                var result2 = context.Articles.Join(context.Authors,//2 выборка из которой надо брать
                    article => article.AuthorInfo,//1 pole
                    author => author.MainInfo,//2 pole
                    (article, author) => new { Theme = article.Theme, Text = article.Text, AuthorInfo = author.MainInfo, AuthorName = author.Fullname, PublishedDate = article.PublishedDate }
                    );



                var result3 = context.Articles.GroupJoin(context.Authors,//2 выборка из которой надо брать
                   article => article.AuthorInfo,//1 pole
                   author => author.MainInfo,//2 pole
                   (article, author) => new { Theme = article.Theme, Text = article.Text,GroupedAuthors=author, PublishedDate = article.PublishedDate }
                   );



            }
        }
    }
}
