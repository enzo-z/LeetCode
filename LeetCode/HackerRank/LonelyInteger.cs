namespace LeetCode.HackerRank
{
    public class LonelyInteger
    {
        public static void Start()
        {
            var a = new List<int>(){ 1, 2, 3, 4, 3, 2, 1 };

            var lonelyInteger = a.GroupBy(n => n).Where(x => x.Count() == 1).Select(x => x.Key).FirstOrDefault();
            Console.WriteLine(lonelyInteger);
        }
    }
}
