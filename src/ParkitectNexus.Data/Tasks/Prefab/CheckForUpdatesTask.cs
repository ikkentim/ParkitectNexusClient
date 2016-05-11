﻿// ParkitectNexusClient
// Copyright (C) 2016 ParkitectNexus, Tim Potze
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
// GNU General Public License for more details.
// You should have received a copy of the GNU General Public License
// along with this program.  If not, see <http://www.gnu.org/licenses/>.

using System.Threading;
using System.Threading.Tasks;
using ParkitectNexus.Data.Assets;

namespace ParkitectNexus.Data.Tasks.Prefab
{
    public class CheckForUpdatesTask : QueueableTask
    {
        private readonly IAssetUpdatesManager _assetUpdatesManager;

        public CheckForUpdatesTask(IAssetUpdatesManager assetUpdatesManager) : base("Updates check")
        {
            _assetUpdatesManager = assetUpdatesManager;

            StatusDescription = "Check for updates.";
        }

        #region Overrides of QueueableTask

        public override async Task Run(CancellationToken token)
        {
            UpdateStatus("Checking for updates...", 25, TaskStatus.Running);
            var count = await _assetUpdatesManager.CheckForUpdates();

            UpdateStatus($"Found {count} available updates.", 100, TaskStatus.Finished);
        }

        #endregion
    }
}
