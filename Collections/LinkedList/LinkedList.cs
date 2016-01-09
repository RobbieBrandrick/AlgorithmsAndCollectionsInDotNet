﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections.LinkedList
{
    public sealed class LinkedList<T>
    {

        private LinkedListNode<T> _head = null;
        private LinkedListNode<T> _tail = null;
        private int _count = 0;

        /// <summary>
        /// Return the first Item in the linked list
        /// </summary>
        /// <returns>last item in the linked list</returns>        
        public T Front()
        {

            if (_count == 0)
            {
                throw new InvalidOperationException("There are no items in the Linked List");
            }

            return _head.Value;
        }

        /// <summary>
        /// Return the last item in the linked list
        /// </summary>
        /// <returns>last item in the linked list</returns>
        public T Back()
        {

            if (_count == 0)
            {
                throw new InvalidOperationException("There are no items in the Linked List");
            }

            return _tail.Value;
        }

        /// <summary>
        /// Adds an item to the front of the linked list
        /// </summary>
        /// <param name="value">item to add</param>
        public void PushFront(T value)
        {

            var item = new LinkedListNode<T>(value);
            var tempNode = _head;

            _head = item;
            _head.Next = tempNode;

            if(_count == 0)
            {
                _tail = _head;
            }

            _count++;

        }

        /// <summary>
        /// Adds an item to the back of the linked list
        /// </summary>
        /// <param name="value">item to add</param>
        public void PushBack(T value)
        {

            var item = new LinkedListNode<T>(value);
            
            if(_count == 0)
            {
                _head = item;
            } 
            else
            {
                _tail.Next = item;
            }

            _tail = item;

            _count++;

        }

    }
}
