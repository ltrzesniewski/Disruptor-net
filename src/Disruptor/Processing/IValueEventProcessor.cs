﻿using System;

namespace Disruptor.Processing;

/// <summary>
/// An event processor (<see cref="IEventProcessor"/>) for a value-type ring buffer.
/// </summary>
/// <typeparam name="T">the type of event used.</typeparam>
public interface IValueEventProcessor<T> : IEventProcessor
    where T : struct
{
    /// <summary>
    /// Synchronously runs the processor.
    /// </summary>
    void Run();

    /// <summary>
    /// Waits before the event processor enters the <see cref="IEventProcessor.IsRunning"/> state.
    /// </summary>
    /// <param name="timeout">maximum wait duration</param>
    void WaitUntilStarted(TimeSpan timeout);

    /// <summary>
    /// Set a new <see cref="IValueExceptionHandler{T}"/> for handling exceptions propagated out of the <see cref="IValueEventHandler{T}"/>
    /// </summary>
    /// <param name="exceptionHandler">exceptionHandler to replace the existing exceptionHandler.</param>
    void SetExceptionHandler(IValueExceptionHandler<T> exceptionHandler);
}