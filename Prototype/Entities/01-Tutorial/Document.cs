using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.Entities._01_Tutorial
{
    public class Document
    {
        public string Title { get; set; } = string.Empty;
        private string Content { get; set; } = string.Empty;
        public string Author { get; set; } = string.Empty;

        public Document(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public string DisplayInfo() 
        {
            return $"Title: {Title} \n" +
                $"Content: {Content} \n" +
                $"Author: {Author}";
        }

        public Document Clone() 
        { 
            return new Document(this.Title, this.Content, this.Author);
        }


    }
}
