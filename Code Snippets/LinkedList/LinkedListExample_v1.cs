using System;
using System.Collections;

/// <summary>
/// LinkList Class
/// </summary>
public class LinkList<type> where type : IComparable<type>, IEquatable<type>, IEnumerator<type>
{

    /// <summary>
    /// Node Class
    /// </summary>
    public sealed class Node<type> where type : IComparable<type>,
    IEquatable<type>
    {
        public type Data { get; set; }
        public Node<type> Next { get; set; }

        public Node() { }

        public Node(type data)
        {
            this.Data = data;
            this.Next = null;
        }

        public Node(type data, Node<type> next)
        {
            this.Data = data;
            this.Next = next;
        }

        /// <summary>
        /// Add Node to end method
        /// </summary>
        /// <param name="data"></param>
        public void AddToEnd(type data)
        {
            if (Next == null)
            {
                Next = new Node<type>(data);
            }
            else
            {
                Next.AddToEnd(data);
            }
        }

        /// <summary>
        /// Print Method
        /// </summary>
        /// <returns></returns>
        public string Print()
        {
            if (Next != null)
            {
                return Data.ToString() + Environment.NewLine + Next.Print();
            }
            else if (Data != null)
            {
                return Data.ToString();
            }

            return "";
        }

        private Node<type> HeadNode { get; set; }
        public int Count { get; private set; }

        /// <summary>
        /// Bool to check if LinkList is empty or not
        /// </summary>
        public bool Empty
        {
            get { return this.Count == 0; }
        }

        public LinkList()
        {
            this.HeadNode = null;
            this.Count = 0;
        }

        public Node<type> GetHeadNode()
        {
            return this.HeadNode;
        }

        /// <summary>
        /// Get Enumerator used for foreach
        /// </summary>
        /// <returns></returns>
        public IEnumerator GetEnumerator()
        {
            for (Node<type> dd = HeadNode; dd != null; dd = dd.Next)
            {
                yield return dd.Data;
            }
        }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this [int index]
        {
            get { return this.Get(index); }
        }

        /// <summary>
        /// Add Object to End
        /// </summary>
        /// <param name="data"></param>
        public void AddToEnd(type data)
        {
            if (HeadNode == null)
            {
                HeadNode = new Node<type>(data);
            }
            else
            {
                HeadNode.AddToEnd(data);
            }

            Count++;
        }

        /// <summary>
        /// Remove Specific Object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public object Remove(type obj)
        {
            return Remove(IndexOf(obj));
        }

        /// <summary>
        /// Remove Object by Index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object Remove(int index)
        {
            if (this.Empty)return null;

            if (index < 0 || index > Count)return null;

            Node<type> current = this.HeadNode;

            object result = null;

            if (index == 0)
            {
                result = current.Data;

                this.HeadNode = current.Next;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                {
                    current = current.Next;
                }

                result = current.Next.Data;

                current.Next = current.Next.Next;
            }

            Count--;

            return result;
        }

        /// <summary>
        /// Checks Node index
        /// </summary>
        /// <param name="obj"></param>
        /// <returns>int</returns>
        public int IndexOf(type obj)
        {
            Node<type> current = this.HeadNode;

            for (int i = 0; i < this.Count; i++)
            {
                if (current.Data.Equals(obj))
                {
                    return i;
                }

                current = current.Next;
            }

            return -1;
        }

        /// <summary>
        /// Bool to check if LinkList contains specific object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public bool Contains(type obj)
        {
            return this.IndexOf(obj) != -1;
        }

        /// <summary>
        /// Gets and return Node by index
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object Get(int index)
        {
            if (index >= 0 && index < this.Count)
            {
                if (this.Empty)
                {
                    return null;
                }

                Node<type> current = this.HeadNode;

                for (int i = 0; i < index; i++)
                {
                    current = current.Next;
                }

                return current.Data;
            }

            return null;
        }

        public void Print()
        {
            if (HeadNode != null)
            {
                HeadNode.Print();
            }
        }

        /// <summary>
        /// Clear LinkList
        /// </summary>
        public void Clear()
        {
            this.HeadNode = null;

            this.Count = 0;
        }

        /// <summary>
        /// Sort LinkList
        /// </summary>
        public void Sort()
        {
            if (HeadNode == null)
            {
                return;
            }

            bool done = true;
            while (done)
            {
                done = false;

                var headn = HeadNode;

                while (headn.Next != null)
                {
                    var HeadDatMod = headn.Data as Module;
                    var HeadNextDataMod = headn.Next.Data as Module;

                    var HeadDataSt = headn.Data as Student;
                    var HeadNextDataSt = headn.Next.Data as Student;

                    if (HeadDatMod is Module && HeadDatMod > HeadNextDataMod)
                    {
                        type temp = headn.Data;
                        headn.Data = headn.Next.Data;
                        headn.Next.Data = temp;

                        done = true;
                    }

                    if (HeadDataSt is Student && HeadDataSt > HeadNextDataSt)
                    {
                        type St = headn.Data;
                        headn.Data = headn.Next.Data;
                        headn.Next.Data = St;

                        done = true;
                    }

                    headn = headn.Next;
                }
            }

        }
    }
}