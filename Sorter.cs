using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Radix_Sort
{
    class Sorter
    {
        public int[] Radix(int[] input){
            var numbers = new Queue<int>(input);
            var buckets = InitializeArray<Queue<int>>(10);
            int m = 10;
            int n = 1;
            for(int i = numbers.Max().ToString().Length; i > 0; i--){
                while(numbers.Count > 0){
                    buckets[numbers.Peek()%m/n].Enqueue(numbers.Dequeue());
                }
                foreach(Queue<int> bucket in buckets){
                    while(bucket.Count > 0){
                        numbers.Enqueue(bucket.Dequeue());
                    }
                }
                m *= 10;
                n *= 10;
            }
            return numbers.ToArray();
        }
        private static T[] InitializeArray<T>(int length) where T : new(){
            T[] array = new T[length];
            for (int i = 0; i < length; ++i){
                array[i] = new T();
            }

            return array;
        }
    }
}
