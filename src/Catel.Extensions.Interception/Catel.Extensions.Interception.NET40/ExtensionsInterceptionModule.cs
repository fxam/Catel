﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ExtensionsInterceptionModule.cs" company="Catel development team">
//   Copyright (c) 2008 - 2014 Catel development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Catel
{
    using System;
    using Catel.Interception;
    using Catel.IoC;

    /// <summary>
    /// Extensions.Interception module which allows the registration of default services in the service locator.
    /// </summary>
    public static class ExtensionsInterceptionModule
    {
        #region Methods
        /// <summary>
        /// Registers the services in the specified <see cref="IServiceLocator" />.
        /// </summary>
        /// <param name="serviceLocator">The service locator.</param>
        /// <exception cref="ArgumentNullException">The <paramref name="serviceLocator"/> is <c>null</c>.</exception>
        public static void RegisterServices(IServiceLocator serviceLocator)
        {
            Argument.IsNotNull(() => serviceLocator);

            serviceLocator.RegisterType<IProxyFactory, ProxyFactory>();
        }
        #endregion
    }
}