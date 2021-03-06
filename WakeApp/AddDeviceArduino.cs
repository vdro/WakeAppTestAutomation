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
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace WakeApp
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the AddDeviceArduino element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("11a8705c-12a8-481b-bc4c-a188a5d15012")]
    public partial class AddDeviceArduino : RepoGenBaseFolder
    {
        static AddDeviceArduino instance = new AddDeviceArduino();
        AddDeviceArduinoFolders.WelcomeWakeAppAppFolder _welcomewakeapp;

        /// <summary>
        /// Gets the singleton class instance representing the AddDeviceArduino element repository.
        /// </summary>
        [RepositoryFolder("11a8705c-12a8-481b-bc4c-a188a5d15012")]
        public static AddDeviceArduino Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public AddDeviceArduino() 
            : base("AddDeviceArduino", "/", null, 0, false, "11a8705c-12a8-481b-bc4c-a188a5d15012", ".\\RepositoryImages\\AddDeviceArduino11a8705c.rximgres")
        {
            _welcomewakeapp = new AddDeviceArduinoFolders.WelcomeWakeAppAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("11a8705c-12a8-481b-bc4c-a188a5d15012")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The WelcomeWakeApp folder.
        /// </summary>
        [RepositoryFolder("f24cac12-396d-4515-ad04-cb5e98458945")]
        public virtual AddDeviceArduinoFolders.WelcomeWakeAppAppFolder WelcomeWakeApp
        {
            get { return _welcomewakeapp; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class AddDeviceArduinoFolders
    {
        /// <summary>
        /// The WelcomeWakeAppAppFolder folder.
        /// </summary>
        [RepositoryFolder("f24cac12-396d-4515-ad04-cb5e98458945")]
        public partial class WelcomeWakeAppAppFolder : RepoGenBaseFolder
        {
            AddDeviceArduinoFolders.DivTagRowFolder _divtagrow;
            RepoItemInfo _buttontag1Info;
            RepoItemInfo _nameInfo;
            RepoItemInfo _inputtagmacInfo;

            /// <summary>
            /// Creates a new WelcomeWakeApp  folder.
            /// </summary>
            public WelcomeWakeAppAppFolder(RepoGenBaseFolder parentFolder) :
                    base("WelcomeWakeApp", "/dom[@domain='www.projektbudzik.pl']", parentFolder, 30000, null, false, "f24cac12-396d-4515-ad04-cb5e98458945", "")
            {
                _divtagrow = new AddDeviceArduinoFolders.DivTagRowFolder(this);
                _buttontag1Info = new RepoItemInfo(this, "ButtonTag1", "body/header/nav//ul/?/?/form[@action='http://www.projektbudzik.pl/']/?/?/i[@innertext='devices_other']", 30000, null, "14513247-75c5-4cc7-ba6c-76f1b51eed6e");
                _nameInfo = new RepoItemInfo(this, "Name", ".//input[#'Name']", 30000, null, "6c89c71d-fbb3-4f52-a9b4-d5e731d40831");
                _inputtagmacInfo = new RepoItemInfo(this, "InputTagMac", ".//input[#'Mac']", 30000, null, "d12f51fd-e538-4e98-9cf9-95ba955f64d2");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("f24cac12-396d-4515-ad04-cb5e98458945")]
            public virtual Ranorex.WebDocument Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.WebDocument>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("f24cac12-396d-4515-ad04-cb5e98458945")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonTag1 item.
            /// </summary>
            [RepositoryItem("14513247-75c5-4cc7-ba6c-76f1b51eed6e")]
            public virtual Ranorex.ITag ButtonTag1
            {
                get
                {
                    return _buttontag1Info.CreateAdapter<Ranorex.ITag>(true);
                }
            }

            /// <summary>
            /// The ButtonTag1 item info.
            /// </summary>
            [RepositoryItemInfo("14513247-75c5-4cc7-ba6c-76f1b51eed6e")]
            public virtual RepoItemInfo ButtonTag1Info
            {
                get
                {
                    return _buttontag1Info;
                }
            }

            /// <summary>
            /// The Name item.
            /// </summary>
            [RepositoryItem("6c89c71d-fbb3-4f52-a9b4-d5e731d40831")]
            public virtual Ranorex.InputTag Name
            {
                get
                {
                    return _nameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Name item info.
            /// </summary>
            [RepositoryItemInfo("6c89c71d-fbb3-4f52-a9b4-d5e731d40831")]
            public virtual RepoItemInfo NameInfo
            {
                get
                {
                    return _nameInfo;
                }
            }

            /// <summary>
            /// The InputTagMac item.
            /// </summary>
            [RepositoryItem("d12f51fd-e538-4e98-9cf9-95ba955f64d2")]
            public virtual Ranorex.InputTag InputTagMac
            {
                get
                {
                    return _inputtagmacInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The InputTagMac item info.
            /// </summary>
            [RepositoryItemInfo("d12f51fd-e538-4e98-9cf9-95ba955f64d2")]
            public virtual RepoItemInfo InputTagMacInfo
            {
                get
                {
                    return _inputtagmacInfo;
                }
            }

            /// <summary>
            /// The DivTagRow folder.
            /// </summary>
            [RepositoryFolder("31cbfa6b-9476-42e1-8436-d7712f52da1e")]
            public virtual AddDeviceArduinoFolders.DivTagRowFolder DivTagRow
            {
                get { return _divtagrow; }
            }
        }

        /// <summary>
        /// The DivTagRowFolder folder.
        /// </summary>
        [RepositoryFolder("31cbfa6b-9476-42e1-8436-d7712f52da1e")]
        public partial class DivTagRowFolder : RepoGenBaseFolder
        {
            RepoItemInfo _submit1Info;
            RepoItemInfo _tdtagInfo;
            RepoItemInfo _tdtag1Info;

            /// <summary>
            /// Creates a new DivTagRow  folder.
            /// </summary>
            public DivTagRowFolder(RepoGenBaseFolder parentFolder) :
                    base("DivTagRow", "body/div/?/?/section/div[1]", parentFolder, 30000, null, false, "31cbfa6b-9476-42e1-8436-d7712f52da1e", "")
            {
                _submit1Info = new RepoItemInfo(this, "Submit1", ".//form[@action='http://www.projektbudzik.pl/Device/Create']/div[5]/input[@type='submit']", 30000, null, "9d441f16-27f1-420e-b904-f38a68a3cc31");
                _tdtagInfo = new RepoItemInfo(this, "TdTag", "table/tbody/?/?/td[@innertext>'                        12']", 30000, null, "b0bc8ff1-4824-463f-9d09-89a1ee4f7d40");
                _tdtag1Info = new RepoItemInfo(this, "TdTag1", "table/tbody/tr/td[1]", 30000, null, "3590abfd-bb63-4e7f-8aa6-dd3eb05ffb5f");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("31cbfa6b-9476-42e1-8436-d7712f52da1e")]
            public virtual Ranorex.DivTag Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("31cbfa6b-9476-42e1-8436-d7712f52da1e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Submit1 item.
            /// </summary>
            [RepositoryItem("9d441f16-27f1-420e-b904-f38a68a3cc31")]
            public virtual Ranorex.InputTag Submit1
            {
                get
                {
                    return _submit1Info.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The Submit1 item info.
            /// </summary>
            [RepositoryItemInfo("9d441f16-27f1-420e-b904-f38a68a3cc31")]
            public virtual RepoItemInfo Submit1Info
            {
                get
                {
                    return _submit1Info;
                }
            }

            /// <summary>
            /// The TdTag item.
            /// </summary>
            [RepositoryItem("b0bc8ff1-4824-463f-9d09-89a1ee4f7d40")]
            public virtual Ranorex.TdTag TdTag
            {
                get
                {
                    return _tdtagInfo.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The TdTag item info.
            /// </summary>
            [RepositoryItemInfo("b0bc8ff1-4824-463f-9d09-89a1ee4f7d40")]
            public virtual RepoItemInfo TdTagInfo
            {
                get
                {
                    return _tdtagInfo;
                }
            }

            /// <summary>
            /// The TdTag1 item.
            /// </summary>
            [RepositoryItem("3590abfd-bb63-4e7f-8aa6-dd3eb05ffb5f")]
            public virtual Ranorex.TdTag TdTag1
            {
                get
                {
                    return _tdtag1Info.CreateAdapter<Ranorex.TdTag>(true);
                }
            }

            /// <summary>
            /// The TdTag1 item info.
            /// </summary>
            [RepositoryItemInfo("3590abfd-bb63-4e7f-8aa6-dd3eb05ffb5f")]
            public virtual RepoItemInfo TdTag1Info
            {
                get
                {
                    return _tdtag1Info;
                }
            }
        }

    }
#pragma warning restore 0436
}
