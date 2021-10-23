using LabNumber9.Abstract;
using LabNumber9.Task3.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LabNumber9.Task2.Collection
{
    class Picture : IDraw
    {
        private List<Shape> shapes;
        private int size;


        public Picture()
        {
            size = 3; // default value
            shapes = new List<Shape>(size);
        }

        public Picture(int size)
        {
            this.size = size;
            shapes = new List<Shape>(size);
        } 

        public bool add(Shape entity)
        {
            if(shapes.Count > size)
            {
                Console.WriteLine("Error!Container completely filled!");
                return false;
            }
            shapes.Add(entity);
            return true;
        }

        public bool delete(Shape entity)
        {
            if(!shapes.Contains(entity))
            {
                Console.WriteLine("Element do not exist!");
                return false;
            }
            shapes.Remove(entity);
            return true;
        }

        public bool delete(string name)
        {
           foreach (Shape entity in shapes) 
           {
                if (entity.getName().Equals(name))
                {
                    shapes.Remove(entity);
                    return true;
                }
           }

            return false;
        }

        public Shape get(int index)
        {
            return shapes.ElementAt(index);
        }

        public void printAll()
        {
            foreach (Shape entity in shapes)
            {
                Console.WriteLine(entity);
            }
        }

        public void Draw()
        {
            foreach (Shape entity in shapes)
            {
                entity.Draw();
            }
        }

    }
}
