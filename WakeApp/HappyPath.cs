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
    ///The HappyPath recording.
    /// </summary>
    [TestModule("240274e3-a7e5-413d-8bcf-357237c95cad", ModuleType.Recording, 1)]
    public partial class HappyPath : ITestModule
    {
        /// <summary>
        /// Holds an instance of the WakeAppRepository repository.
        /// </summary>
        public static WakeAppRepository repo = WakeAppRepository.Instance;

        static HappyPath instance = new HappyPath();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public HappyPath()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static HappyPath Instance
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

            Report.Log(ReportLevel.Info, "Website", "Opening web site 'http://www.projektbudzik.pl/Account/Register?' with browser 'Chrome' in normal mode.", new RecordItemIndex(0));
            Host.Current.OpenBrowser("http://www.projektbudzik.pl/Account/Register?", "Chrome", "", false, false, false, true, false, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(1));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Name' at 151;7.", repo.WelcomeWakeApp.NameInfo, new RecordItemIndex(2));
            repo.WelcomeWakeApp.Name.Click("151;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'WelcomeWakeApp.Name'.", repo.WelcomeWakeApp.NameInfo, new RecordItemIndex(3));
            repo.WelcomeWakeApp.Name.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Email' at 97;15.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(4));
            repo.WelcomeWakeApp.Email.Click("97;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Email' at 49;22.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(5));
            repo.WelcomeWakeApp.Email.Click("49;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test13112{RShiftKey down}@{RShiftKey up}gmail.com' with focus on 'WelcomeWakeApp.Email'.", repo.WelcomeWakeApp.EmailInfo, new RecordItemIndex(6));
            repo.WelcomeWakeApp.Email.PressKeys("test13112{RShiftKey down}@{RShiftKey up}gmail.com");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Password' at 39;15.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(7));
            repo.WelcomeWakeApp.Password.Click("39;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WakeApp132{RShiftKey down}!{RShiftKey up}' with focus on 'WelcomeWakeApp.Password'.", repo.WelcomeWakeApp.PasswordInfo, new RecordItemIndex(8));
            repo.WelcomeWakeApp.Password.PressKeys("WakeApp132{RShiftKey down}!{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.ConfirmPassword' at 51;26.", repo.WelcomeWakeApp.ConfirmPasswordInfo, new RecordItemIndex(9));
            repo.WelcomeWakeApp.ConfirmPassword.Click("51;26");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'WakeApp132{RShiftKey down}!{RShiftKey up}' with focus on 'WelcomeWakeApp.ConfirmPassword'.", repo.WelcomeWakeApp.ConfirmPasswordInfo, new RecordItemIndex(10));
            repo.WelcomeWakeApp.ConfirmPassword.PressKeys("WakeApp132{RShiftKey down}!{RShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.CreateNewGroup' at 10;3.", repo.WelcomeWakeApp.CreateNewGroupInfo, new RecordItemIndex(11));
            repo.WelcomeWakeApp.CreateNewGroup.Click("10;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.GroupName' at 46;18.", repo.WelcomeWakeApp.GroupNameInfo, new RecordItemIndex(12));
            repo.WelcomeWakeApp.GroupName.Click("46;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test11211' with focus on 'WelcomeWakeApp.GroupName'.", repo.WelcomeWakeApp.GroupNameInfo, new RecordItemIndex(13));
            repo.WelcomeWakeApp.GroupName.PressKeys("test11211");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.GroupPassword' at 51;23.", repo.WelcomeWakeApp.GroupPasswordInfo, new RecordItemIndex(14));
            repo.WelcomeWakeApp.GroupPassword.Click("51;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'WelcomeWakeApp.GroupPassword'.", repo.WelcomeWakeApp.GroupPasswordInfo, new RecordItemIndex(15));
            repo.WelcomeWakeApp.GroupPassword.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.GroupConfirmPassword' at 60;9.", repo.WelcomeWakeApp.GroupConfirmPasswordInfo, new RecordItemIndex(16));
            repo.WelcomeWakeApp.GroupConfirmPassword.Click("60;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence 'test' with focus on 'WelcomeWakeApp.GroupConfirmPassword'.", repo.WelcomeWakeApp.GroupConfirmPasswordInfo, new RecordItemIndex(17));
            repo.WelcomeWakeApp.GroupConfirmPassword.PressKeys("test");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'WelcomeWakeApp.Submit1' at 82;27.", repo.WelcomeWakeApp.Submit1Info, new RecordItemIndex(18));
            repo.WelcomeWakeApp.Submit1.Click("82;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WelcomeWakeApp.DivTagCol'.", repo.WelcomeWakeApp.DivTagColInfo, new RecordItemIndex(19));
            Validate.Exists(repo.WelcomeWakeApp.DivTagColInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'WelcomeWakeApp.DivTagCol1'.", repo.WelcomeWakeApp.DivTagCol1Info, new RecordItemIndex(20));
            Validate.Exists(repo.WelcomeWakeApp.DivTagCol1Info);
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
