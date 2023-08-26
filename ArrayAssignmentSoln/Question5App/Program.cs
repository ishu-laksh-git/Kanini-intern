//5) Validate a Card number
//4477 4683 4311 3002
//2003 1134 3864 7744 - Reverse the number
//2+0*2+0+3*2+1+1*2+3+4*2+3+8*2+6+4*2+7+7*2+4+4*2 - identify the even position numbers and multiply by 2
//2+0+0+6+1+2+3+8+3+16+6+8+7+14+4+8 - Multiplied
//2+0+0+6+1+2+3+8+3+(1+6)+6 + 8 + 7 + (1 + 4) + 4 + 8 - If results in 2 digit number sum them up
//2+0+0+6+1+2+3+8+3+7+6+8+7+5+4+8 - Sum up all teh values
//70%10-> Divide by 10 if 0 remainder then valid card number


namespace Question5App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            q5 question5 = new q5();
        }
    }
}