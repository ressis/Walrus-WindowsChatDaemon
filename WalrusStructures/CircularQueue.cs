using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WalrusStructures
{
	public class CircularQueue<T>
	{
		private Int64 lowerBound;
		private Int64 higherBound;
		private int maxSize;
		private T[] array;

		public CircularQueue(int size)
		{
			maxSize = size;
			lowerBound = 0;
			higherBound = 0;
			array = new T[size];
		}

		public Int64 push(T obj)
		{
			array[higherBound % maxSize] = obj;
			higherBound++;
			if (higherBound - lowerBound >= maxSize)
				lowerBound++;
			return higherBound;
		}

		public T pop()
		{
			if (higherBound - lowerBound <= 0)
				throw new IndexOutOfRangeException();
			T item = array[lowerBound % maxSize];
			lowerBound++;
			return item;
		}

		public T[] peekFrom(Int64 index)
		{
			if (index > higherBound)
				return null;
			if (index + maxSize < lowerBound)
				return array;
			List<T> list = new List<T>();
			for (; index < higherBound; index++)
				list.Add(array[index % maxSize]);
			return list.ToArray();
		}
	}
}
