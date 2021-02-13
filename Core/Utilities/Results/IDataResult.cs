using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    public interface IDataResult<T>:IResult //<T>: Generic
    {
        T Data { get; }
    }
}
