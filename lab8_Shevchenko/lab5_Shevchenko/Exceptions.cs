using System;

public class ArrayException : Exception
{
    public ArrayException(string message) : base(message) { }
}

public class InvalidDataException : ArrayException
{
    public InvalidDataException(string message) : base(message) { }
}

public class FileReadException : ArrayException
{
    public FileReadException(string message) : base(message) { }
}

public class ObjectCreationException : ArrayException
{
    public ObjectCreationException(string message) : base(message) { }
}