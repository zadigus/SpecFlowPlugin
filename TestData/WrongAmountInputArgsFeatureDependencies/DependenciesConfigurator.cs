﻿namespace WrongAmountInputArgsFeatureDependencies
{
    using System.Diagnostics.CodeAnalysis;
    using Ninject;
    using Ninject.SpecFlowPlugin.Attributes;

    internal class DependenciesConfigurator
    {
        [SuppressMessage(
            "Microsoft.Performance",
            "CA1811:AvoidUncalledPrivateCode",
            Justification = "the call is indirect")]
        [FeatureDependencies]
        public static void SetupFeatureContainer(IKernel kernel, string invalidArg)
        {
            // do nothing
        }
    }
}