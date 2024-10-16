namespace CSharpConcepts
{
    internal class Boxing
    {
        /// <summary>
        /// Definition: <br/>
        /// Boxing is the process of converting a value type (like int, float, char, etc.) 
        /// into a reference type (specifically, an object).<br/><br/>
        /// Mechanism:<br/>
        /// When a value type is boxed, a new object is created on the heap, and the value is copied into that object.
        /// This allows the value type to be treated as an object.<br/><br/>
        /// Performance:<br/>
        /// Boxing incurs performance overhead due to heap allocation and copying.
        /// Memory management involves garbage collection for boxed objects.
        /// </summary>
        internal void ValidExample()
        {
            int number = 936;
            object obj = number;// Boxing
            Console.WriteLine($"Boxed value: {obj}");
        }
    }
}
