﻿using System.Runtime.Serialization;

namespace CiT.Common.Exceptions;

[Serializable]
public class InvalidConfigurationException : Exception
{
    public InvalidConfigurationException() { }
    public InvalidConfigurationException(string message) : base(message) { }
    public InvalidConfigurationException(string message, Exception innerException) : base(message, innerException) { }
    protected InvalidConfigurationException(SerializationInfo info, StreamingContext context) : base(info, context) { }
}
