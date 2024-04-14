namespace PlmLibs
{
    public static class AsyncLib
    {
        public static void Delay(int miliseconds)
        {
            Task task = Task.Delay(miliseconds);
            while (task.Status != TaskStatus.RanToCompletion) { }
        }
    }
}
