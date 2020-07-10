using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ait.Models
{
    public class Response<T>
    {
        private bool _success = false;
        private Exception _exception = new Exception();
        private T _value;
        public bool Success { get { return _success; } }
        public Exception Exception { get { return _exception; } }
        public T Value { get { return _value; } }

        public void SuccessResponse(T entity)
        {
            SetResponse(entity, null);
        }

        private void SetResponse(T entity, Exception ex)
        {
            _value = entity;
            _success = ex == null ? true : false;
            _exception = ex;
        }

        public void FailResponse(T entity, Exception exception)
        {
            SetResponse(entity, exception);
        }
    }
}
