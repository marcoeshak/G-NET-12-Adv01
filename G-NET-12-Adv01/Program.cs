using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Security.Principal;
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

            #region Q09

            /*
            public class Factory<T> where T : new()
            {
            public T Create()
            {
                return new T(); // ✅ Allowed because of new() constraint
            }

            public List<T> CreateMany(int count)
            {
                var list = new List<T>();
                for (int i = 0; i < count; i++)
                {
                    list.Add(new T());
                }
                return list;
            }
            }
            */
            #endregion

            #region Q08
            /*
            public class Example<T> where T : class
            {
            public T Value;
            }
            */
            #endregion

            #region Q10

            /*
            public class Sorter<T> where T : IComparable<T>
                {
            public void BubbleSort(T[] array)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        // CompareTo available because of constraint
                        if (array[j].CompareTo(array[j + 1]) > 0)
                        {
                            (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        }
                    }
                }
            }
            */

            #endregion

            #region Q11

            /*
            public class Animal { }

            public class Example<T> where T : Animal
            {
            }
            */
            #endregion

            #region Q12

            /* 
             WITHE Single Type Parameter ///

            ublic class EntityManager<T>
            where T : class, IEntity, new()
               {
            public T CreateAndSave()
            {
                var entity = new T();      // ✅ new() constraint
                entity.Id = Guid.NewGuid(); // ✅ IEntity constraint
                return entity;
            }
            }

            WITH Multiple Type Parameters

            public class Mapper<TSource, TDest>
            where TSource : class
            Where TDest : class, new()
            {
             public TDest Map(TSource source)
             {
           var dest = new TDest();
           // Copy properties via reflection...
             return dest;
             }
              }

            */
            #endregion

            #region Q13
            
            // default(T) or default returns the default value for type T: null for reference types, 0 / false for value types
            
            #endregion

        }
    }
}
