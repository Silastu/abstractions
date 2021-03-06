﻿using Unity.Lifetime;

namespace Unity
{
    public static class TypeLifetime
    {
        public static ITypeLifetimeManager Singleton => new SingletonLifetimeManager();

        public static ITypeLifetimeManager ContainerControlled => new ContainerControlledLifetimeManager();

        public static ITypeLifetimeManager PerContainer => new ContainerControlledLifetimeManager();

        public static ITypeLifetimeManager Hierarchical => new HierarchicalLifetimeManager();

        public static ITypeLifetimeManager Scoped => new HierarchicalLifetimeManager();

        public static ITypeLifetimeManager PerResolve => new PerResolveLifetimeManager();

        public static ITypeLifetimeManager PerThread => new PerThreadLifetimeManager();
        
        public static ITypeLifetimeManager Transient => TransientLifetimeManager.Instance;

        public static ITypeLifetimeManager PerContainerTransient => new ContainerControlledTransientManager();
    }
}
