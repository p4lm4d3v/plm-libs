namespace PlmLibs.Async
{
    public static class Async
    {
        public static void Delay(int miliseconds)
        {
            Task task = Task.Delay(miliseconds);
            while (task.Status != TaskStatus.RanToCompletion) { }
        }
    }
}
