using Microsoft.Extensions.Options;
using ProjeVek.Data.Infrastructure.Entites;
using ProjeVek.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using ProjeVek.Model;

namespace ProjeVek.Data
{
    public class ContentData : EntityBaseData<Model.Content>
    {
        public ContentData(IOptions<DatabaseSettings> dbOptions)
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }

        public List<Model.Content> GetBlogNewContents(int count = 25)
        {
            var dtNow = DateTime.Now;

            return _context.Set<Model.Content>()
                .OrderByDescending("PublishDate")
                .Include(x => x.Media)
                .Include(x => x.Author)
                .Where(x => x.PublishDate <= dtNow && x.IsActive && !x.IsDeleted)
                .Include(x => x.ContentCategories)
                .Take(count).ToList();
        }

        public Model.Content GetContentBySlug(string slug)
        {
            var dtNow = DateTime.Now;

            return _context.Set<Model.Content>()
                .OrderByDescending("PublishDate")
                .Include(x => x.Media)
                .Include(x => x.Author)
                .Where(x => x.Slug == slug.ToLowerInvariant() && x.PublishDate <= dtNow && x.IsActive && !x.IsDeleted)
                .Include(x => x.ContentCategories)
                .FirstOrDefault();
        }

        public List<Model.Content> GetContentsByIds(List<int> ids, int count)
        {
            var dtNow = DateTime.Now;

            return _context.Set<Model.Content>()
                .OrderByDescending("PublishDate")
                .Include(x => x.Media)
                .Include(x => x.Author)
                .Where(x => ids.Contains(x.Id) && x.PublishDate <= dtNow && x.IsActive && !x.IsDeleted)
                .Include(x => x.ContentCategories)
                .Take(count).ToList();
        }

        public List<Content> GetContentsByIds(List<int?> category_content_ids, int v)
        {
            throw new NotImplementedException();
        }
    }
}

