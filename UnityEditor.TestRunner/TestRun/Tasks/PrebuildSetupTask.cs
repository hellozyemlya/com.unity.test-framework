using System;
using System.Collections;
using NUnit.Framework.Interfaces;
using UnityEngine;
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class PrebuildSetupTask : BuildActionTaskBase<IPrebuildSetup>
    {
        public PrebuildSetupTask(Func<TestJobData, ITestFilter> filterSelector) : base(filterSelector, new PrebuildSetupAttributeFinder())
        {
        }

        protected override void Action(IPrebuildSetup target)
        {
            target.Setup();
        }
    }
}
