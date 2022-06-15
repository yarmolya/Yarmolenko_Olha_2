using System;
namespace laba2.Properties
{
    public class Leaves
    {
        protected string color;
        public Leaves()
        {
            color = "зелений";
        }
        public string Color
        {
            get => color;
            set => color = value;
        }
    }
}