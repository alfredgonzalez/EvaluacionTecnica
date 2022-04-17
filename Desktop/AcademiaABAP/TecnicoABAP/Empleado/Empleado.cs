using System;

namespace Entidades
{
    public class Empleado
    {
        private int id;
        private string name;

        public Empleado(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public int GetId() 
        {
            return this.id;
        }
        public void SetId(int value) 
        {
            if(value > 0) 
            {
                this.id = value;
            }
        }
        public string GetName() 
        {
            return this.name;
        }
        public void SetName(string value) 
        {
            if (!string.IsNullOrEmpty(value)) 
            {
                this.name = value;
            }
        }
    }
}
