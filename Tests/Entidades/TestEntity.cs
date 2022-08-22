using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests.Entidades
{
    [TestMethod]
    internal class TestEntity
    {
        private string Name { get; set; }
        private decimal Value { get; set; }
        private decimal Id { get; set; }

        public string GetName()
        {
            return Name;
        }
        public decimal GetValue()
        {
            return Value;
        }
        public decimal GetId()
        {
            return Id;
        }
        public void SetName(string name)
        {
            Name = name;
        }
        public void SetValue(decimal value)
        {
            Value = value;
        }
        public void SetId(decimal id)
        {
            Id = id;
        }

    }
}
