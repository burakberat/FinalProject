using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    //temel voidler için başlangıç
    public interface IResult
    {
        bool Success { get; } //başarılı mı başarısız mı ,, true or false.
        string Message { get; }

    }
}
