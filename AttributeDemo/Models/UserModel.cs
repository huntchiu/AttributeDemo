using AttributeDemo.Attributes;

namespace AttributeDemo.Models
{
    public class UserModel
    {
        public string ID { get; set; }
        [Field("姓名")]
        public string NAME { get; set; }
        [Field("年龄")]
        public string AGE { get; set; }
    }
}