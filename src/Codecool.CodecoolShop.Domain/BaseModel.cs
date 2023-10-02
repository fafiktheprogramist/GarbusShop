using System;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Codecool.CodecoolShop.Domain
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
