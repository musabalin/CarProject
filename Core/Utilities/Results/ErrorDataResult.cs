using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class ErrorsDataResult<T> : DataResult<T>
    {
        //Data ve mesaj verildiği zaman çalıştırır
        public ErrorsDataResult(T data, string message) : base(data, false, message)
        {
        }
        //Sadece Data verdiğin zaman çalıştırır
        public ErrorsDataResult(T data) : base(data, false)
        {
        }
        //Sadece mesaj verdiğin zaman çalıştırır.
        public ErrorsDataResult(string message) : base(default, false, message)
        {
        }
        //Hiçbirşey vermesede çalışır.
        public ErrorsDataResult() : base(default, false)
        {
        }
    }
}
