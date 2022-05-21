using Lab12.Stack;
using Microsoft.CSharp.RuntimeBinder;
using NUnit.Framework;
using System;

namespace Lab12.Test
{
    [TestFixture]
    public class StackTest
    {
        [Test]
        public void InitDifferentTypesNoException()
        {
            MyStack<string> stack1 = new MyStack<string>();
            MyStack<int> stack2 = new MyStack<int>();
            MyStack<bool> stack3 = new MyStack<bool>();
            MyStack<object> stack4 = new MyStack<object>();

            Assert.Pass();
        }

        #region Push tests
        [Test]
        public void PushMuslitpleItmesNoException()
        {
            var stack = new MyStack<int>();

            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }

            Assert.Pass();
        }

        [Test]
        public void PushMultipleItemsRightOrder()
        {
            var stack = new MyStack<int>();
            for (int i = 0; i < 100; i++)
            {
                stack.Push(i);
            }

            var current = stack.Count - 1;

            foreach (int num in stack)
            {
                Assert.AreEqual(num, current--);
            }
        }

        [Test]
        public void PushEventSuccessfully()
        {
            var stack = new MyStack<int>();
            bool called = false;
            stack.OnPush += (int t) => { called = true; };
            stack.Push(1);
            Assert.IsTrue(called);
        }
        #endregion

        #region Pop tests
        [Test]
        public void PopMultipleItemsRightOrder()
        {
            MyStack<int>? stack = new MyStack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            for (int i = 9; i >= 0; i--)
            {
                Assert.AreEqual(i, stack.Pop());
            }
        }

        [Test]
        public void PopEventSuccessfulCall()
        {
            MyStack<int>? stack = new MyStack<int>();
            bool called = false;
            stack.OnPop += (int t) => { called = true; };

            stack.Push(1);
            stack.Pop();

            Assert.IsTrue(called);
        }
        #endregion

        #region Contains test
        [Test]
        public void ContainsEmptyStackFalse()
        {
            MyStack<int> stack = new MyStack<int>();
            Assert.IsFalse(stack.Contains(1));
        }

        [Test]
        public void ContainsMultipleItemsTrue()
        {
            MyStack<int> stack = new MyStack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            Assert.IsTrue(stack.Contains(9));
            Assert.IsTrue(stack.Contains(3));
        }
        #endregion

        #region Count tests
        [Test]
        public void CountEmptyStackZero()
        {
            MyStack<int> stack = new MyStack<int>();

            Assert.AreEqual(0, stack.Count);
        }

        [Test]
        public void CountTwoItemOne()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Push(1);
            stack.Push(2);

            Assert.AreEqual(2, stack.Count);
        }
        #endregion

        #region Peek test
        [Test]
        public void PeekMultipleTimesNoChange()
        {
            var stack = new MyStack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            for (int i = 9; i >= 0; i--)
            {
                Assert.AreEqual(9, stack.Peek());
            }
        }

        [Test]
        public void PeekPopOnceChange()
        {
            var stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(2);
            Assert.AreEqual(2, stack.Peek());

            stack.Pop();
            Assert.AreEqual(1, stack.Peek());
        }
        #endregion

        #region Clear tests
        [Test]
        public void ClearEmptyStackNoException()
        {
            MyStack<int> stack = new MyStack<int>();
            stack.Clear();
            Assert.Pass();
        }

        [Test]
        public void ClearMultipleItemsNoException()
        {
            MyStack<int> stack = new MyStack<int>();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }

            stack.Clear();
            Assert.Pass();
        }
        #endregion
    }
}