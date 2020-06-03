namespace robo.Utils
{
    public class BaseResponse<T>
    {
        public T records { get; set; }

        public bool success { get; set; } = true;

        public string message { get; set; } = "Ok";
    }
}
