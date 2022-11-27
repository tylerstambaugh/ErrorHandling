//https://exercism.org/tracks/csharp/exercises/error-handling/edit
public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("throws an exception.");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        return null;
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        throw new NotImplementedException("You need to implement this function.");
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        throw new NotImplementedException("You need to implement this function.");
    }
}
