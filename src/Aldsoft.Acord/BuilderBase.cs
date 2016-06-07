namespace Aldsoft.Acord.LA
{
    using System;
    using System.Collections.Generic;

    public abstract class BuilderBase<T> : IBuilder<T> where T : EntityBase<T>, new()
    {
        private readonly T _baseEntity;
        protected readonly LinkedList<Action<T>> _buildPropertiesActions = new LinkedList<Action<T>>();

        protected BuilderBase() { }

        protected BuilderBase(T baseEntity)
            : this()
        {
            if (baseEntity == null)
                throw new ArgumentNullException("baseEntity");

            _baseEntity = baseEntity.Clone();
            ValidateBaseObject(_baseEntity);
        }

        public virtual T Build()
        {
            ValidateBuilder();

            var clonedBaseEntity = _baseEntity != null ? _baseEntity.Clone() : new T();
            BuildEntity(clonedBaseEntity);
            return clonedBaseEntity;
        }

        public virtual T Build(T baseEntity)
        {
            if (baseEntity == null)
                throw new ArgumentNullException("baseEntity");

            ValidateBuilder();

            var clonedBaseEntity = baseEntity.Clone();
            ValidateBaseObject(clonedBaseEntity);
            BuildEntity(clonedBaseEntity);
            return clonedBaseEntity;
        }

        /// <summary>
        /// Validates that the baseEntity doesn't have certain properties set which the builder is responsible to set.
        /// </summary>
        /// <param name="baseEntity"></param>
        protected virtual void ValidateBaseObject(T baseEntity) { }

        /// <summary>
        /// Validates that the builder was used with the minimum requirements according to ACORD
        /// </summary>
        protected virtual void ValidateBuilder() { }

        private void BuildEntity(T baseEntity)
        {
            var node = _buildPropertiesActions.First;
            while (node != null)
            {
                node.Value(baseEntity);
                node = node.Next;
            }
        }
    }
}
