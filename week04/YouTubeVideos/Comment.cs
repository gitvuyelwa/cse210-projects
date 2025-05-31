using System;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;


    public class Comment
    {
    public string Author { get; set; }
    public string Content { get; set; }

    public Comment(string author, string content)
    {
        Author = author;
        Content = content;
        
    }
    }
