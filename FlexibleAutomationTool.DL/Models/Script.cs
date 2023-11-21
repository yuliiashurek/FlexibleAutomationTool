namespace FlexibleAutomationTool.DL.Models
{
    public class Script : Entity
    {
        public string Name { get; set; }
        public Queue<Key> Keys { get; set; }
        public Queue<Mouse> Mouses { get; set; }
    }
}
