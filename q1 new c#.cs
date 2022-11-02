// a. this is darshit's code 

class Program
    {
        static void Main(string[] args)
        {
            List<Author> AuthorList = new List<Author>();
            AuthorList.Add(new Author("Mahesh Chand", 35, "A Prorammer's Guide to ADO.NET", true, new DateTime(2003, 7, 10), "Backend program"));
            AuthorList.Add(new Author("Neel Beniwal", 18, "Graphics Development with C#", false, new DateTime(2010, 2, 22), "Backend program"));
            AuthorList.Add(new Author("Praveen Kumar", 28, "Mastering WCF", true, new DateTime(2012, 01, 01), "Backend program"));
            AuthorList.Add(new Author("Mahesh Chand", 35, "Graphics Programming with GDI+", true, new DateTime(2008, 01, 20), "Frontend program"));
            AuthorList.Add(new Author("Raj Kumar", 30, "Building Creative Systems", false, new DateTime(2011, 6, 3), "Frontend program"));
        }
    }

    class Author
    {


        public string Name { get; set; }

        public short Age { get; set; }

        public string BookTitle { get; set; }

        public bool IsMVP { get; set; }

        public DateTime PublishedDate { get; set; }

        public string areaofexpertise { get; set; }

        public Author(string name, short age, string title, bool mvp, DateTime pubdate, string areaofexpertise)
        {
            this.Name = name;
            this.Age = age;
            this.BookofTitle = title;
            this.IsMVP = mvp;
            this.PublishedDate = pubdate;
            this.areaexpertise = areaexpertise;
        }


    }
// b. Display areas of expertise................


var areaExpertiseQuery = (from a in AuthorList
select a,areaexpertise) Distinct();
foreach (var areaofexpertise in areaExpertiseQuery) {
Console WriteLine(areaexpertise)
Console.WriteLine("areas are displayed");

// c. Display the number of books..........

var booksofQuery = (from a in AuthorList
select a BookofTitle) Count();
Console.WriteLine(booksofQuery);
Console.WriteLine(*total number of book*);

// d. Display the min , average authors.

IEnumerable<short> ageQuery = 
from e in Authortlist 
select e.Age;


Console. WriteLine (ageQuery.Min());
Console. WriteLine (ageQuery. Max());

List<Float> ageSum = new List<float>();
foreach (short e in agequery) (
ageSum.Add(e);
}
Console.WriteLine(ageSus.Average());

// e. Group the authors by their area of expertise and display the results. 


var groupedAuthors = from author in AuthorList
group author by author.areaexpertise;

foreach (var group in groupedAuthors) {
Console. WriteLine(group.Key + " : " + group.Count0());


foreach (var author in group) {
Console.WriteLine(" the Author names : " + author.Name +
", this is Area of Expertise: " + author.areaexpertise);
}
}

// end of the code