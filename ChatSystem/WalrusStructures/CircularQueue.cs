using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChatSystem
{
	class CircularQueue<T>
	{
		Int64 lowerBound;
		Int64 higherBound;
		int maxSize;
		T[] array;

		public CircularQueue(int size)
		{
			maxSize = size;
			lowerBound = 0;
			higherBound = 0;
			array = new T[size];
		}

		public void push(T obj)
		{
			array[higherBound % maxSize] = obj;
			higherBound++;
			if (higherBound - lowerBound >= maxSize)
				lowerBound++;
		}

		public T pop()
		{
			if (higherBound - lowerBound <= 0)
				throw new IndexOutOfRangeException();
			T item = array[lowerBound % maxSize];
			lowerBound++;
			return item;
		}
	}
}
