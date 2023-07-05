using Microsoft.Extensions.Options;
using ProjeVek.Data.Infrastructure.Entites;
using ProjeVek.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeVek.Data
{
    public class CategoryData : EntityBaseData<Model.Category>
    {
        public CategoryData(IOptions<DatabaseSettings> dbOptions)
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
