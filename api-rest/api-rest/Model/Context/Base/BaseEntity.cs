using System.ComponentModel.DataAnnotations.Schema;

namespace api_rest.Model.Context.Base
{
    public class BaseEntity
    {
        [Column("id")]
        public long Id { get; set; }
    }
}
