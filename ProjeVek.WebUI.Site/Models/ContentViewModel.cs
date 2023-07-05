using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ProjeVek.WebUI.Site.Models
{
    public class ContentViewModel
    {
        public ContentViewModel()
        {
            Content = new Model.Content();
            Relateds = new List<Model.Content>();
        }

        public Model.Content Content { get; set; }
        public List<Model.Content> Relateds { get; set; }
    }
}
