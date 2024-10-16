namespace CSharpConcepts
{
    internal class UnBoxing
    {
        internal void ValidExample()
        {
            object obj = 936;
            int unboxedNum = (int)obj; // Unboxing
            Console.WriteLine($"Unboxed value: {unboxedNum}");
        }

        internal void InvalidCastExample()
        {
            try
            {
                object wrongObj = "Hello";
                int wrongUnbox = (int)wrongObj; // This will throw an InvalidCastException
            }
            catch (InvalidCastException e)
            {
                Console.WriteLine($"Unboxing error: {e.Message}");
            }
        }
    }
}
