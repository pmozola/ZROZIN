namespace ZROZIN.App.Handlers.Helpers;

public class Result<T> : Result
{
    public static Result<T> Success(T value) => new() { IsSuccess = true, Value = value };
    
    public T? Value { get; init; }
}

public class Result
{
    public static Result Success() => new() { IsSuccess = true};
    public static Result Error(string errorMessage) => new() { IsSuccess = false, ErrorMessage = errorMessage };
    
    public bool IsSuccess { get; init; }
    public string? ErrorMessage { get; init; }
}