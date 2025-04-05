using UnityEngine;

namespace Assignment29
{
    public class RecursionScript : MonoBehaviour
    {
        void Start()
        {
            print(FibonacciRecursive(10));
            print(FibonacciIterative(10));
        }
    
        
        int FibonacciRecursive(int n){
            if(n <= 1){
                return n;
            }
            return FibonacciRecursive(n-1) + FibonacciRecursive(n-2);
        }
    
        int FibonacciIterative(int n){
            int a = 0;
            int b = 1;
            int nthLimit = 0;
            for(int i = 2; i <= n; i++){
                nthLimit = a + b;
                a = b;
                b = nthLimit;
            }
            return nthLimit;
        }
    }
}

