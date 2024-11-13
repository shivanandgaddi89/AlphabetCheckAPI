using AlphabetCheckAPI.Design;

namespace AlphabetCheckAPI.Compute
{
    public class AlphabetCheckCompute : IAlphabetsChecker
    {
        public bool ContainsAllAlphabets(string input)
        {
            try
            {
                input = input.ToLower();
                return Enumerable.Range('a', 26).All(c => input.Contains((char)c));
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
