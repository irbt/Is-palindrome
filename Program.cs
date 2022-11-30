//Given a string, write a method that checks if it is a palindrome. String length may be >= 0.



namespace Program{
    class IsPalindromeRecursionTask{
            static bool IsPalindromeRecursion(string str){
                
                //str[str.Length-1] + IsPalindromeRecursion (str.Substring(0,(str.Length-1)))
                
                if(str.Length == 1 || str.Length == 0 ){
                    return true;
                }else if (str.Length>=2) {
                    return IsPalindromeRecursion (str.Substring(0,(str.Length-1)));
                }else{
                    return false;
                }
                  
                    
            }
        static void Main(string [] args){
            
            Console.WriteLine(IsPalindromeRecursion("laval"));// → true
            Console.WriteLine(IsPalindromeRecursion("pendrive"));// → false

        }
    }
}