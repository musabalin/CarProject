using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class SuccessDataResult<T> : DataResult<T>
    {
        //Data ve mesaj verildiği zaman çalıştırır
        public SuccessDataResult(T data, string message) : base(data, true, message)
        {
        }
        //Sadece Data verdiğin zaman çalıştırır
        public SuccessDataResult(T data) : base(data, true)
        {
        }
        //Sadece mesaj verdiğin zaman çalıştırır.
        public SuccessDataResult(string message) : base(default, true, message)
        {
        }
        //Hiçbirşey vermesede çalışır.
        public SuccessDataResult() : base(default, true)
        {
        }
    }
}
