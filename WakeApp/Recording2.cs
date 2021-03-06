﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace WakeApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The Recording2 recording.
    /// </summary>
    [TestModule("2778919f-20b3-4435-8b8d-c77587d00a0b", ModuleType.Recording, 1)]
    public partial class Recording2 : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static Recording2 instance = new Recording2();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public Recording2()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static Recording2 Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'ranorex.RxBrowser' on device 'WakeApp'.", new RecordItemIndex(0));
            Host.Local.RunMobileApp("WakeApp", "ranorex.RxBrowser", true);
            Delay.Milliseconds(3500);
            
            Report.Log(ReportLevel.Info, "Application", "Run mobile app 'ranorex.RxBrowser' on device " + Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName() + ".", new RecordItemIndex(1));
            Host.Local.RunMobileApp(Ranorex.Core.Remoting.RemoteServiceLocator.GetCurrentDeviceName(), "ranorex.RxBrowser", true);
            Delay.Milliseconds(3500);
            
            // Browse to site.
            Report.Log(ReportLevel.Info, "Set value", "Browse to site.\r\nSetting attribute PageUrl to 'http://www.projektbudzik.pl' on item 'Browser.Dom'.", repo.Browser.Dom.SelfInfo, new RecordItemIndex(2));
            repo.Browser.Dom.Self.Element.SetAttributeValue("PageUrl", "http://www.projektbudzik.pl");
            Delay.Milliseconds(10000);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
