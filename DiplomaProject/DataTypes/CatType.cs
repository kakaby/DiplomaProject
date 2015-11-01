using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.DataTypes
{
    class CatType
    {           
        public string Name;
        public CatType( string name )
        {
            Name = name;
        }
        public bool Equals( CatType symbol )
        {
            return (symbol.Name == Name);
        }
    }
}
