namespace robo.Utils
{
    public class ResponseWrapper<T>
    {
        public T records { get; set; }

        public bool success { get; set; } = true;

        public string message { get; set; } = "Ok";
    }
}
