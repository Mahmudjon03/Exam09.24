
namespace Domain.Wapper
{
    public class Response<T>
    {
        public int StatusCode { get; set; }
        public string Messenge { get; set; }
        public T Data { get; set; }
        public Response(T data)
        {
            Data= data;
            StatusCode = 200;
        }
        public Response(string messenge) => Messenge = messenge;
        
            
        
    }
}
