using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiplomaProject.DataTypes
{
    class CharType
    {
        public char Value;
        public CharType( char value )
        {
            Value = value;
        }
        public bool Equals( CharType symbol )
        {
            return (symbol.Value == Value);
        }
    }
}
