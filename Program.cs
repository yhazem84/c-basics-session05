#region Q1
using Assignment_04;

Book b1 = new Book();

//Console.WriteLine(Book.password); // it can't access to the password because it is private so it's accessable only inside the class

#endregion
Console.WriteLine("-------------------------------");
#region Q2
Console.WriteLine(b1.copiesInStock); // it compiles because copiesInStock is internal and can be accessed in the same project
#endregion
Console.WriteLine("-------------------------------");
#region Q3
b1.title = "Book01";
Console.WriteLine(b1.title);
#endregion
Console.WriteLine("-------------------------------");
#region Q4
Console.WriteLine(b1.genre);
#endregion
Console.WriteLine("-------------------------------");
#region Q5
Console.WriteLine((int)Genre.Fiction);
Console.WriteLine((int)Genre.NonFiction);
Console.WriteLine((int)Genre.Science);
#endregion
Console.WriteLine("-------------------------------");
#region Q6
int genreNumber = 1;
Console.WriteLine((Genre)genreNumber);
#endregion
Console.WriteLine("-------------------------------");
#region Q7
Genre genre = Genre.Fiction;
string genreString = genre.ToString();
Console.WriteLine(genreString);
#endregion
Console.WriteLine("-------------------------------");
#region Q8
string genreText = "Science";
Genre genreParsed = Enum.Parse<Genre>(genreText);
Console.WriteLine(genreParsed);
#endregion
Console.WriteLine("-------------------------------");
#region Q9
string genreTextt = "Mystery";
Genre genreTryParse;
if (Enum.TryParse<Genre>(genreTextt, out genreTryParse))
{
    Console.WriteLine(genreTextt);
}
else
{
    Console.WriteLine("Unknown genre");
}

#endregion