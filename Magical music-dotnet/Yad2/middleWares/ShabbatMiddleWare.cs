namespace MagicalMusic.API.middleWares
{
    public class ShabbatMiddleWare
    {
        private readonly RequestDelegate _next;
        public ShabbatMiddleWare(RequestDelegate next)
        {
            _next = next;
        }
        public async Task InvokeAsync(HttpContext context)
        {
            Console.WriteLine("start");
            if (DateTime.Now.DayOfWeek == DayOfWeek.Saturday)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
            }
            else
            {
                await _next(context);
            }
            Console.WriteLine("end");

        }
    }
}
