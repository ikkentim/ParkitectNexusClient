﻿// ParkitectNexusClient
// Copyright 2016 Parkitect, Tim Potze

using System.Diagnostics;
using System.IO;
using System.Linq;
using ParkitectNexus.Data.Game;
using ParkitectNexus.Data.Game.Base;
using ParkitectNexus.Data.Settings;
using ParkitectNexus.Data.Utilities;

namespace ParkitectNexus.Data
{
    public class LinuxParkitect : BaseParkitect
    {
        public LinuxParkitect(IRepositoryFactory repositoryFactory, ILogger logger) : base(repositoryFactory, logger)
        {
            Paths = new LinuxParkitectPath(this);
        }


        /// <summary>
        ///     get a collection of paths
        /// </summary>
        public override IParkitectPaths Paths { get; }

        /// <summary>
        ///     Detects the installation path.
        /// </summary>
        /// <returns>true if the installation path has been detected; false otherwise.</returns>
        public override bool DetectInstallationPath()
        {
            if (IsInstalled)
                return true;

            // TODO Detect registry key of installation path.
            // can only do this once it's installed trough steam or a setup.
            return false;
        }

        /// <summary>
        ///     Launches the game with the specified arguments.
        /// </summary>
        /// <param name="arguments">The arguments.</param>
        /// <returns>The launched process.</returns>
        public override Process Launch(string arguments = "-single-instance")
        {
            Logger.WriteLine($"Attempting to launch game with arguments '{arguments}'.");

            Logger.WriteLine("Attempting to compile installed mods.");
            CompileActiveMods();

            // If the process is already running, push it to the foreground and return it.
            var running = Process.GetProcessesByName("Parkitect").FirstOrDefault();

            if (running != null)
            {
                Logger.WriteLine(
                    $"'Parkitect' is already running. Giving window handle '{running.MainWindowHandle}' focus.");

                return running;
            }

            var t = Logger.LoggingPath;
            Logger.WriteLine($"Launching game at path '{Paths.GetPathInGameFolder("Parkitect.x86_64")}'.");
            // Start the game process.
            return !IsInstalled
                ? null
                : Process.Start(new ProcessStartInfo(Paths.GetPathInGameFolder("Parkitect.x86_64"))
                {
                    WorkingDirectory = InstallationPath,
                    Arguments = arguments
                });
        }

        protected override bool IsValidInstallationPath(string path)
        {
            // Path must exist and contain Parkitect.exe.
            return !string.IsNullOrWhiteSpace(path) && File.Exists(Path.Combine(path, "Parkitect.x86_64"));
        }
    }
}
