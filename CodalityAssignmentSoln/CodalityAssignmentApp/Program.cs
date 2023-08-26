namespace CodalityAssignmentApp
{
    internal class Program
    {

        public int Solution(int N)
        {
            int bg = 0, i, j = 0, sCount = 0, bgCount = 0;
            int[] tBinaryNo = new int[20];
            int[] BinaryNo = new int[20];
            int[] binaryGap = new int[5];
            for (i = 0; N > 0; i++)
            {
                tBinaryNo[i] = N % 2;
                N = N / 2;
                sCount++;
            }
            for (i = i - 1; i >= 0; i--)
            {
                BinaryNo[j] = tBinaryNo[i];
                j++;
            }
            //for (i = 0; i < count; i++)
            //{
            //    Console.Write(BinaryNo[i]);
            //}
            for(i=0;i<sCount;i++)
            {
                if (BinaryNo[i] == 1)
                {
                    int flag = 0;
                    bgCount++;
                    bg = 0;
                    for(j=i+1;j < sCount;j++)
                    {
                        if (BinaryNo[j] == 1)
                        {
                            flag = 1;
                            break;
                            
                        }  
                        bg++;
                    }
                    if (flag == 1)
                        binaryGap[bgCount - 1] = bg;
                    else
                        binaryGap[bgCount - 1] = 0;
                }
            }
            int max = binaryGap[0];
            for(i=0;i<bgCount;i++)
            {
                if (binaryGap[i]>max)
                    max = binaryGap[i];

            }
            bg = max;
            return bg;
        }
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            int gap = new Program().Solution(1041);
            Console.WriteLine(gap);
            
        }
    }
}