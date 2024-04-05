namespace PlmLibs.Async
{
    public static class Async
    {
        public static async Task Delay(int miliseconds) => await Task.Delay(miliseconds);
    }
}
