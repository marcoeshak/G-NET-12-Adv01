using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Timers;

namespace G_NET_12_Adv01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Q01

            /*
            A generic class uses type parameters that are replaced with actual types when you create an instance.The type parameter <T> acts as a placeholder.
            
            Why use :

            Type Safety — Compile-time type checking
            Performance — No boxing/unboxing
            Code Reuse — One implementation for all types

            */

            #endregion

            #region Q02

            /*
            public class Container<T>
            {
            private T _value;

            public void Add(T value)
            {
                _value = value;
            }

            public T Get()
            {
                return _value;
            }
            }

            */

            #endregion

            #region Q03

            /*
             
            public class Pair<TKey, TValue>
            {
            public TKey Key { get; set; }
            public TValue Value { get; set; }
            }

            */
            #endregion

            #region Q04

            /*
             
            Generic methods define type parameters at method level.

                public static void Swap<T>(ref T a, ref T b)
                {
                 T temp = a;
                 a = b;
                 b = temp;
                }

            */

            #endregion

            #region Q05

            /*
            public static T FindMax<T>(T a, T b) where T : IComparable<T>
             {
                 if (a.CompareTo(b) > 0)
                return a;
                return b;
             }
            */
            #endregion

            #region Q06

            // Generic interfaces define contracts with type parameters

            /*
             
            public interface IRepository<T>
               {
            void Add(T item);
            T Get(int id);
                }
            */

            #endregion

            #region Q07

            /*
            public struct Nullable<T> where T : struct
                {
            private readonly bool _hasValue;
            private readonly T _value;

            public bool HasValue => _hasValue;
            public T Value => _hasValue ? _value
                : throw new InvalidOperationException();

            public Nullable(T value)
            {
                _hasValue = true;
                _value = value;
            }
                 }
            */

            #endregion


    }
    }
}
