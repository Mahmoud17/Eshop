using MediatR;

namespace Shared.DDD;

public abstract class DomainEvent : INotification
{
	public Guid EventId => Guid.NewGuid();
	public DateTime OccurredOn => DateTime.Now;
	public string EventType => GetType().AssemblyQualifiedName!;
}

public interface IDomainEvent : INotification
{
}