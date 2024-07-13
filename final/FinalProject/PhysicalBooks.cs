using System;

class PhysicalBooks:Library
{
    //Method to get list of authors of the books
    public List<string> deGetAuthor(string deInfo)
    {
        List<string> deAuthor = new List<string>();
        deAuthor.Add(deInfo);
        return deAuthor;
    }

    //Method to get physical book titles
    public List<string> deGetBookTitle(string list)
    {
        List<string> books = new List<string>();
        books.Add(list);

        return books;
    }
}