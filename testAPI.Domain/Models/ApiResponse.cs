using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testAPI.Domain.Models
{
    public class ApiResponse<T> where T : class
    {
        public ApiResponse()
        {
            Message = "Ok";
            Success = true;
            RequestDate = DateTime.Now;
        }

        public string Message { get; set; }
        public T Data { get; set; }
        //public Exception Exception { get; set; }
        public bool Success { get; set; }
        public DateTime RequestDate { get; set; }
        public DateTime ResponseDate { get; set; }
    }
}
