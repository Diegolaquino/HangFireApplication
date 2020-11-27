using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HangFireApplication.Services
{
    public interface IServiceBase<T>
    {
        Task Start();

        Task Stop();
    }
}
