using Microsoft.Extensions.Options;
using ProjeVek.Data.Infrastructure.Entites;
using ProjeVek.Data.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjeVek.Data
{
    public class CommentData : EntityBaseData<Model.Comment>
    {
        public CommentData(IOptions<DatabaseSettings> dbOptions)
            : base(new DataContext(dbOptions.Value.ConnectionString))
        {

        }
    }
}
