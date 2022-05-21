﻿namespace Lab12.Stack
{
    internal class Node<T>
    {
        public T Data;
        public Node<T>? Next;
        public Node(T data)
        {
            Data = data;
            Next = null;
        }
    }
}