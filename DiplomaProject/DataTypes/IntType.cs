using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.DataTypes
{
    class IntType
    {
        public int Value;
        public IntType( int value )
        {
            Value = value;
        }
        public bool Equals( IntType symbol )
        {
            return (symbol.Value == Value);
        }
    }
}
