namespace ServerSendMessageToAllClientsTCP
{
    internal class Student
    {
        public string AridNo { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{AridNo} --- {Name} --- {Age}";
        }
    }
}