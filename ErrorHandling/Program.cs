//https://exercism.org/tracks/csharp/exercises/error-handling/edit
public static class ErrorHandling
{
    public static void HandleErrorByThrowingException()
    {
        throw new Exception("throws an exception.");
    }

    public static int? HandleErrorByReturningNullableType(string input)
    {
        try
        {
            return Int32.Parse(input);
        }
        catch
        {
            return null;
        }
    }

    public static bool HandleErrorWithOutParam(string input, out int result)
    {
        try
        {
            result = Int32.Parse(input);
            return true;
        }
        catch (Exception ex)
        {
            result = 69;
            return false;
        }
    }

    public static void DisposableResourcesAreDisposedWhenExceptionIsThrown(IDisposable disposableObject)
    {
        try
        {
            disposableObject.Dispose();
            throw new System.Exception();
        }

        catch (Exception e)
        {
            disposableObject.Dispose();
            throw new System.Exception();
        }
    }
}



// https://msdn.microsoft.com/en-us/library/t3c3bfhx.aspx?f=255&MSPPError=-2147217396