using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_ATENDIMENTO.bytebank.Exceptions
{
    [Serializable]
    public class BytebankException : Exception
    {
        public BytebankException() { }
        public BytebankException(string message) : base("Aconteceu uma Exceção -> " + message) { }
        public BytebankException(string message, Exception inner) : base(message, inner) { }
        protected BytebankException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
