using System;
using System.Collections.Generic;
using Extensions;
using UnityEngine;

namespace Services
{
    public class ServiceLocator : MonoBehaviour
    {
        private static readonly Dictionary<Type, object> Services = new Dictionary<Type, object>();

        [RuntimeInitializeOnLoadMethod]
        public static void Initialize()
        {
            foreach (var serviceType in ReflectionService.GetAllAutoRegisteredServices())
            {
                if (IsRegistered(serviceType)) continue;
                
                if (serviceType.IsMonoBehaviour())
                {
                    FindOrCreateMonoService(serviceType);
                }
                else
                {
                    RegisterNewInstance(serviceType);
                }
            }
        }

        public static void Register<TService>(TService service, bool safe = true) where TService : IServiceBase
        {
            var serviceType = typeof(TService);
            if (IsRegistered<TService>() && safe)
            {
                throw new Exception($"{serviceType.Name} has been already registered.");
            }

            Services[typeof(TService)] = service;
        }

        public static TService Get<TService>() where TService : IServiceBase
        {
            var serviceType = typeof(TService);
            if (IsRegistered<TService>())
            {
                return (TService) Services[serviceType];
            }

            throw new Exception($"{serviceType.Name} hasn't been registered.");
        }

        public static bool IsRegistered(Type t)
        {
            return Services.ContainsKey(t);
        }

        public static bool IsRegistered<TService>()
        {
            return IsRegistered(typeof(TService));
        }

        private static void RegisterNewInstance(Type serviceType)
        {
            Services[serviceType] = Activator.CreateInstance(serviceType);
        }
        
        private static void FindOrCreateMonoService(Type serviceType)
        {
            var inGameService = FindObjectOfType(serviceType);
            if (inGameService == null)
            {
                var newObject = new GameObject();
                newObject.AddComponent(serviceType);
                newObject.name = serviceType.Name;
                inGameService = FindObjectOfType(serviceType); 
            }
            Services[serviceType] = inGameService;
        }
    }
}
