namespace Aldsoft.Acord.LA
{
    public interface IBuilder<T> : IBuild<T>
    {
        /// <summary>
        /// Will deep clone and use the provided object as the starter for our built entity.
        /// </summary>
        /// <param name="baseObject">The seed instance the builder will clone and populate.</param>
        /// <returns>The xml entity the builder created.</returns>
        T Build(T baseObject);
    }

    public interface IBuild<T>
    {
        /// <summary>
        /// Will build the default(T) entity, or Clone the entity if provided in the CreateBuilder arguments
        /// </summary>
        /// <returns>The xml entity the builder created.</returns>
        T Build();
    }
}
