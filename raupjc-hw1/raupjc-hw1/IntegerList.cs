using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment1Tests;

namespace raupjc_hw1
{
    public class IntegerList : IIntegerList
    {
        private int[] _internalStorage;
        private int size;
        public int count = 0;
        

        public int Count => count;

        public IntegerList()
        {
            _internalStorage = new int[4];
            size = 4;
        }
        public IntegerList(int initialSize)
        {
            if (initialSize < 0)
            {
                System.Console.WriteLine("Size can not be negative");
                return;
            }
            _internalStorage = new int[initialSize];
            size = initialSize;
        }
      
        public void Add(int item)
        {

            if (count >= size )
            {
                size = size * 2;
                Array.Resize(ref _internalStorage, size);
                int[] biggerInternalStorage = new int[size];
                biggerInternalStorage = _internalStorage;
                _internalStorage = biggerInternalStorage;
                _internalStorage[count] = item;
                count++;
                //Console.WriteLine("IS {0}",count);
            }
            else
            {
                _internalStorage[count] = item;
                //Console.WriteLine("BUU {0}",count);
                
                count++;
            }
        }

        public void Clear()
        {
            count = 0;
            Array.Clear(_internalStorage, 0, _internalStorage.Length);
        }

        public bool Contains(int item)
        {
            bool contains = false;
            for (int i = 0; i < _internalStorage.Length; i++)
            {
                if (_internalStorage[i] == item)
                {
                    contains = true;
                }
            }
           
                return contains;
            
         
        }

        public int GetElement(int index)
        {
            if (index >= size)
            {
                throw new IndexOutOfRangeException();

            }
            else
            {
                return _internalStorage[index];
            }
        }

        public int IndexOf(int item)
        {
            if (Contains(item))
            {
                for (int i = 0; i < size; i++)
                {
                    if (_internalStorage[i] == item)
                    {
                        return i;
                    }

                    continue;
                }
                return -1;


            }
            else
            {

                return -1;
            }
        }
        public bool Remove(int item)
        {
            if (Contains(item))
            {
                
                for (int i = 0; i < _internalStorage.Length; i++)
                {
                    if (_internalStorage[i] != item)
                    {
                        continue;
                    }
                    else
                    {
                        
                        RemoveAt(i);
                        return true;


                    }

                }
                return true;
            }
            else
            {
                return false ;
            }
        }

        public bool RemoveAt(int index)
        {
            if (index < 0 || index >= _internalStorage.Length)
            {
                throw new IndexOutOfRangeException();
            }
            else
            {
                count = count - 1;
                var newArray = new int[_internalStorage.Length - 1];
                int j = 0;
                for (int i = 0; i < _internalStorage.Length; i++)
                {
                    if (i == index) continue;
                    newArray[j] = _internalStorage[i];
                    j++;
                }
                for (int k = 0; k < newArray.Length; k++)
                {
                    Console.WriteLine("K {0}",newArray[k]);
                    _internalStorage[k] = newArray[k];
                }
                return true;
            }
        }

    }
}
