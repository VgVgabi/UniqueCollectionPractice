using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Collections;


namespace UniqueCollectionPractice
{
    public class StudetsList : ICollection<User>
    {
        private List<User> _students;
        public IEnumerator<User> GetEnumerator()
        {
            return new StudentsEnumerator(this);
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return new StudentsEnumerator(this);
        }
        //
        public StudetsList()
        {
            _students = new List<User>();
        }
        //
        public User this[int index]
        {
            get { return (User)_students[index]; }
            set { _students[index] = value; }
        }
        //
        public bool Contains(User name)
        {
            bool nameExist = false;
            foreach (User user in _students)
                if (user.Name == name.Name)
                {
                    nameExist = true;
                }
            return nameExist;
        }
        public void Add(User newUser)
        {
            foreach (var user in _students)
            {
                if (newUser.Name == user.Name)
                {
                    Console.WriteLine("The Name Exist in the List");
                    return;
                }
            }
            _students.Add(newUser);
        }
        //
        public void Clear()
        {
            _students.Clear();
        }
        //
        public void CopyTo(User[] array, int arrayIndex)
        {
            if (array == null)
                throw new ArgumentNullException("The array cannot be null.");
            if (arrayIndex < 0)
                throw new ArgumentOutOfRangeException("The starting array index cannot be negative.");
            if (Count > array.Length - arrayIndex + 1)
                throw new ArgumentException("The destination array has fewer elements than the collection.");
            for (int i = 0; i < _students.Count; i++)
            {

            }
        }
        //
        public bool Remove(User user)
        {
            return _students.Remove(user);
        }
        public bool Remove(string name)
        {
            foreach (var user in _students)
            {
                if (user.Name == name)
                {
                    this.Remove(user);
                    return true;
                }
                else
                    Console.WriteLine("The Name Not Exist");
            }
            return false;
        }
        //
        public int Count
        {
            get
            {
                return _students.Count;
            }
        }
        //
        public bool IsReadOnly
        {
            get { return false; }
        }
    }
}
