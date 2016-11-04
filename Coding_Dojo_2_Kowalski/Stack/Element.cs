namespace Coding_Dojo_2_Kowalski.Stack
{
    public class Element<T>
    {
        public T ElementValue
        {
            get;
            set;
        }
        public Element<T> Vorgaenger
        {
            get; set;
        }
    }
}