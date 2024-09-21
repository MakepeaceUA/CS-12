using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp2
{
    public class ObjectBackpack
    {
        public string name;
        public int capacity;

        public ObjectBackpack(string na, int ca)
        {
            name = na;
            capacity = ca;
        }
        public override string ToString()
        {
            return $"{name}";
        }

    }

    public class Backpack
    {
        public string color;
        public string firm;
        public int weight;
        public int capacity;
        private ObjectBackpack[] contents;
        private int count;

        public event Action<ObjectBackpack> Add;
        public event Action<ObjectBackpack> Remove;

        public Backpack(string co, string fi, int we, int ca, int size)
        {
            color = co;
            firm = fi;
            weight = we;
            capacity = ca;
            contents = new ObjectBackpack[size];
            count = 0;
        }
        public int TotalCapacity()
        {
            int t_capacity = 0;
            for (int i = 0; i < count; i++)
            {
                t_capacity += contents[i].capacity;
            }
            return t_capacity;
        }
        public bool AddObject(ObjectBackpack obj)
        {
            if (count < contents.Length && TotalCapacity() + obj.capacity <= capacity)
            {
                contents[count] = obj;
                count++;
                Add?.Invoke(obj);
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool RemoveObject(string objectName)
        {
            for (int i = 0; i < count; i++)
            {
                if (contents[i].name == objectName)
                {
                    ObjectBackpack remove = contents[i];
                    for (int j = i; j < count - 1; j++)
                    {
                        contents[j] = contents[j + 1]; 
                    }
                    contents[count - 1] = null; 
                    count--;
                    Remove?.Invoke(remove);
                    return true;
                }
            }
            return false;
        }
        public void ShowContents()
        {
            for (int i = 0; i < count; i++)
            {
                Console.Write($"{contents[i].ToString()} ");
            }
            Console.WriteLine();
        }


    }
}
