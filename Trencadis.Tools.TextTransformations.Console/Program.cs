// ---------------------------------------------------------------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Trencadis">
// Copyright (c) 2016, Trencadis, All rights reserved
// </copyright>
// ---------------------------------------------------------------------------------------------------------------------------------------

namespace Trencadis.Tools.TextTransformations.Console
{
    using System;
    using System.IO;

    class Program
    {
        const string paramToConfigTransformationDefinitions = "-config";
        const string paramToSourceTemplate = "-source";
        const string paramToTarget = "-target";

        static void Main(string[] args)
        {
            if ((args == null) || (args.Length == 0))
            {
                System.Console.WriteLine(
                    "No arguments specified, you must provide values for the following arguments: {0}, {1} and {2}",
                    paramToConfigTransformationDefinitions,
                    paramToSourceTemplate,
                    paramToTarget);

                Environment.Exit(1);
            }

            string pathToConfigTransformationDefinitions = null, pathToSourceTemplate = null, pathToTarget = null;

            #region Decode parameters

            for (int i = 0; i < args.Length; i++)
            {
                if (string.Equals(args[i], paramToConfigTransformationDefinitions, StringComparison.OrdinalIgnoreCase))
                {
                    if (i + 1 < args.Length)
                    {
                        pathToConfigTransformationDefinitions = args[i + 1];
                        i++;
                    }
                }

                if (string.Equals(args[i], paramToSourceTemplate, StringComparison.OrdinalIgnoreCase))
                {
                    if (i + 1 < args.Length)
                    {
                        pathToSourceTemplate = args[i + 1];
                        i++;
                    }
                }

                if (string.Equals(args[i], paramToTarget, StringComparison.OrdinalIgnoreCase))
                {
                    if (i + 1 < args.Length)
                    {
                        pathToTarget = args[i + 1];
                        i++;
                    }
                }
            }

            #endregion

            #region Verify decoded parameters

            if (string.IsNullOrWhiteSpace(pathToConfigTransformationDefinitions))
            {
                System.Console.WriteLine(
                    "No value specified for argumet {0}, the value is mandatory",
                    paramToConfigTransformationDefinitions);

                Environment.Exit(1);
            }

            if (string.IsNullOrWhiteSpace(pathToSourceTemplate))
            {
                System.Console.WriteLine(
                    "No value specified for argumet {0}, the value is mandatory",
                    paramToSourceTemplate);

                Environment.Exit(1);
            }

            if (string.IsNullOrWhiteSpace(pathToTarget))
            {
                System.Console.WriteLine(
                    "No value specified for argumet {0}, the value is mandatory",
                    paramToTarget);

                Environment.Exit(1);
            }

            if (!File.Exists(pathToConfigTransformationDefinitions))
            {
                System.Console.WriteLine(
                    "File '{0}' doesn't exist",
                    pathToConfigTransformationDefinitions);

                Environment.Exit(1);
            }

            if (!File.Exists(pathToSourceTemplate))
            {
                System.Console.WriteLine(
                    "File '{0}' doesn't exist",
                    pathToSourceTemplate);

                Environment.Exit(1);
            }

            var targetDirInfo = new DirectoryInfo(Path.GetDirectoryName(pathToTarget));

            if (!targetDirInfo.Exists)
            {
                System.Console.WriteLine(
                    "Directory '{0}' doesn't exist",
                    targetDirInfo.Name);

                Environment.Exit(1);
            }

            #endregion

            var transformDefs = File.ReadAllText(pathToConfigTransformationDefinitions);

            var inputContent = File.ReadAllText(pathToSourceTemplate);

            var transformations = TextTransformationsFacade.CreateFromXmlContent(transformDefs);

            var result = TextTransformationsRunner.RunTransformations(inputContent, transformations);

            File.WriteAllText(pathToTarget, result);

            Environment.Exit(0);
        }
    }
}
