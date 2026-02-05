namespace ConsoleApp1
{
    internal class Program
    {


        static int CountPieces(int length, int stick1, int stick2)
        {
            return (stick1 / length) + (stick2 / length);
        }

        static bool CanFormSquare(int length, int stick1, int stick2)
        {
            return CountPieces(length, stick1, stick2) >= 4;
        }

        public int solution(int A, int B)
        {
            for (int length = Math.Min(A, B); length > 0; length--)
            {
                if (CanFormSquare(length, A, B))
                {

                    return length;
                }
            }
            return 0;
        }







    }
}
