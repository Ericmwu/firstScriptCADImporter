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

namespace firstScriptCADImporter
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the firstScriptCADImporterRepository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("863124fd-6afe-4612-8bb8-501b3e405402")]
    public partial class firstScriptCADImporterRepository : RepoGenBaseFolder
    {
        static firstScriptCADImporterRepository instance = new firstScriptCADImporterRepository();
        firstScriptCADImporterRepositoryFolders.UpchainCADImporterAppFolder _upchaincadimporter;
        firstScriptCADImporterRepositoryFolders.LogInToUpchainAppFolder _logintoupchain;
        firstScriptCADImporterRepositoryFolders.LogInToUpchainGoogleChromeAppFolder _logintoupchaingooglechrome;
        firstScriptCADImporterRepositoryFolders.UpchainAppFolder _upchain;
        firstScriptCADImporterRepositoryFolders.LogInToUpchainSuccessAppFolder _logintoupchainsuccess;

        /// <summary>
        /// Gets the singleton class instance representing the firstScriptCADImporterRepository element repository.
        /// </summary>
        [RepositoryFolder("863124fd-6afe-4612-8bb8-501b3e405402")]
        public static firstScriptCADImporterRepository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public firstScriptCADImporterRepository() 
            : base("firstScriptCADImporterRepository", "/", null, 0, false, "863124fd-6afe-4612-8bb8-501b3e405402", ".\\RepositoryImages\\firstScriptCADImporterRepository863124fd.rximgres")
        {
            _upchaincadimporter = new firstScriptCADImporterRepositoryFolders.UpchainCADImporterAppFolder(this);
            _logintoupchain = new firstScriptCADImporterRepositoryFolders.LogInToUpchainAppFolder(this);
            _logintoupchaingooglechrome = new firstScriptCADImporterRepositoryFolders.LogInToUpchainGoogleChromeAppFolder(this);
            _upchain = new firstScriptCADImporterRepositoryFolders.UpchainAppFolder(this);
            _logintoupchainsuccess = new firstScriptCADImporterRepositoryFolders.LogInToUpchainSuccessAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("863124fd-6afe-4612-8bb8-501b3e405402")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The UpchainCADImporter folder.
        /// </summary>
        [RepositoryFolder("21cf03e5-07e8-42c5-ac78-6d6d5fbb631f")]
        public virtual firstScriptCADImporterRepositoryFolders.UpchainCADImporterAppFolder UpchainCADImporter
        {
            get { return _upchaincadimporter; }
        }

        /// <summary>
        /// The LogInToUpchain folder.
        /// </summary>
        [RepositoryFolder("152b13b8-5ef6-46b1-a658-4362075180f3")]
        public virtual firstScriptCADImporterRepositoryFolders.LogInToUpchainAppFolder LogInToUpchain
        {
            get { return _logintoupchain; }
        }

        /// <summary>
        /// The LogInToUpchainGoogleChrome folder.
        /// </summary>
        [RepositoryFolder("9a47568b-8bd1-45b3-a52f-227186d77b37")]
        public virtual firstScriptCADImporterRepositoryFolders.LogInToUpchainGoogleChromeAppFolder LogInToUpchainGoogleChrome
        {
            get { return _logintoupchaingooglechrome; }
        }

        /// <summary>
        /// The Upchain folder.
        /// </summary>
        [RepositoryFolder("d9d2dc0a-ea74-405b-8815-7426843a6845")]
        public virtual firstScriptCADImporterRepositoryFolders.UpchainAppFolder Upchain
        {
            get { return _upchain; }
        }

        /// <summary>
        /// The LogInToUpchainSuccess folder.
        /// </summary>
        [RepositoryFolder("119ffc5d-4641-4755-9fc7-0d75a6d5774e")]
        public virtual firstScriptCADImporterRepositoryFolders.LogInToUpchainSuccessAppFolder LogInToUpchainSuccess
        {
            get { return _logintoupchainsuccess; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class firstScriptCADImporterRepositoryFolders
    {
        /// <summary>
        /// The UpchainCADImporterAppFolder folder.
        /// </summary>
        [RepositoryFolder("21cf03e5-07e8-42c5-ac78-6d6d5fbb631f")]
        public partial class UpchainCADImporterAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonlogoutInfo;
            RepoItemInfo _btn_textloginInfo;

            /// <summary>
            /// Creates a new UpchainCADImporter  folder.
            /// </summary>
            public UpchainCADImporterAppFolder(RepoGenBaseFolder parentFolder) :
                    base("UpchainCADImporter", "/form[@title='Upchain CAD Importer']", parentFolder, 30000, null, true, "21cf03e5-07e8-42c5-ac78-6d6d5fbb631f", "")
            {
                _buttonlogoutInfo = new RepoItemInfo(this, "ButtonLogout", "container[@caption='']/container/container[@caption='']/container[2]/button[@automationid='ButtonLogout']", ".//button[@automationid='ButtonLogout']", 30000, null, "82740042-3fbb-46bf-9e4f-a4f5f5552fb5");
                _btn_textloginInfo = new RepoItemInfo(this, "Btn_textLogin", "?/?/button[@text='Log in']/text[@caption='Log in']", ".//text[@caption='Log in']", 30000, null, "33d619b0-163f-4438-8617-b39a600a9fc7");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("21cf03e5-07e8-42c5-ac78-6d6d5fbb631f")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("21cf03e5-07e8-42c5-ac78-6d6d5fbb631f")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonLogout item.
            /// </summary>
            [RepositoryItem("82740042-3fbb-46bf-9e4f-a4f5f5552fb5")]
            public virtual Ranorex.Button ButtonLogout
            {
                get
                {
                    return _buttonlogoutInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonLogout item info.
            /// </summary>
            [RepositoryItemInfo("82740042-3fbb-46bf-9e4f-a4f5f5552fb5")]
            public virtual RepoItemInfo ButtonLogoutInfo
            {
                get
                {
                    return _buttonlogoutInfo;
                }
            }

            /// <summary>
            /// The Btn_textLogin item.
            /// </summary>
            [RepositoryItem("33d619b0-163f-4438-8617-b39a600a9fc7")]
            public virtual Ranorex.Text Btn_textLogin
            {
                get
                {
                    return _btn_textloginInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The Btn_textLogin item info.
            /// </summary>
            [RepositoryItemInfo("33d619b0-163f-4438-8617-b39a600a9fc7")]
            public virtual RepoItemInfo Btn_textLoginInfo
            {
                get
                {
                    return _btn_textloginInfo;
                }
            }
        }

        /// <summary>
        /// The LogInToUpchainAppFolder folder.
        /// </summary>
        [RepositoryFolder("152b13b8-5ef6-46b1-a658-4362075180f3")]
        public partial class LogInToUpchainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _fieldusernameInfo;
            RepoItemInfo _fieldpasswordInfo;
            RepoItemInfo _buttoncontinueInfo;

            /// <summary>
            /// Creates a new LogInToUpchain  folder.
            /// </summary>
            public LogInToUpchainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LogInToUpchain", "/dom[@domain='release-sso.upchain.gold']", parentFolder, 30000, null, false, "152b13b8-5ef6-46b1-a658-4362075180f3", "")
            {
                _fieldusernameInfo = new RepoItemInfo(this, "fieldUsername", ".//input[#'username']", ".//input[#'username']", 30000, null, "999a84a5-e474-4c52-ad81-70874afd9e74");
                _fieldpasswordInfo = new RepoItemInfo(this, "fieldPassword", ".//input[#'password']", ".//input[#'password']", 30000, null, "07985518-d2b4-41f6-a657-2f29619e9b26");
                _buttoncontinueInfo = new RepoItemInfo(this, "ButtonContinue", ".//input[#'kc-login']", ".//input[#'kc-login']", 30000, null, "abf6446c-adcb-4bba-9407-8459d8694b32");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("152b13b8-5ef6-46b1-a658-4362075180f3")]
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
            [RepositoryItemInfo("152b13b8-5ef6-46b1-a658-4362075180f3")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The fieldUsername item.
            /// </summary>
            [RepositoryItem("999a84a5-e474-4c52-ad81-70874afd9e74")]
            public virtual Ranorex.InputTag fieldUsername
            {
                get
                {
                    return _fieldusernameInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The fieldUsername item info.
            /// </summary>
            [RepositoryItemInfo("999a84a5-e474-4c52-ad81-70874afd9e74")]
            public virtual RepoItemInfo fieldUsernameInfo
            {
                get
                {
                    return _fieldusernameInfo;
                }
            }

            /// <summary>
            /// The fieldPassword item.
            /// </summary>
            [RepositoryItem("07985518-d2b4-41f6-a657-2f29619e9b26")]
            public virtual Ranorex.InputTag fieldPassword
            {
                get
                {
                    return _fieldpasswordInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The fieldPassword item info.
            /// </summary>
            [RepositoryItemInfo("07985518-d2b4-41f6-a657-2f29619e9b26")]
            public virtual RepoItemInfo fieldPasswordInfo
            {
                get
                {
                    return _fieldpasswordInfo;
                }
            }

            /// <summary>
            /// The ButtonContinue item.
            /// </summary>
            [RepositoryItem("abf6446c-adcb-4bba-9407-8459d8694b32")]
            public virtual Ranorex.InputTag ButtonContinue
            {
                get
                {
                    return _buttoncontinueInfo.CreateAdapter<Ranorex.InputTag>(true);
                }
            }

            /// <summary>
            /// The ButtonContinue item info.
            /// </summary>
            [RepositoryItemInfo("abf6446c-adcb-4bba-9407-8459d8694b32")]
            public virtual RepoItemInfo ButtonContinueInfo
            {
                get
                {
                    return _buttoncontinueInfo;
                }
            }
        }

        /// <summary>
        /// The LogInToUpchainGoogleChromeAppFolder folder.
        /// </summary>
        [RepositoryFolder("9a47568b-8bd1-45b3-a52f-227186d77b37")]
        public partial class LogInToUpchainGoogleChromeAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _paneInfo;

            /// <summary>
            /// Creates a new LogInToUpchainGoogleChrome  folder.
            /// </summary>
            public LogInToUpchainGoogleChromeAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LogInToUpchainGoogleChrome", "/form[@title>'Log in to Upchain - Google']", parentFolder, 30000, null, true, "9a47568b-8bd1-45b3-a52f-227186d77b37", "")
            {
                _paneInfo = new RepoItemInfo(this, "Pane", "container[@accessiblename>'Log in to Upchain - Google']/container[@accessiblename='Google Chrome']/container/container[2]/container[1]", "?/?/container[@accessiblename='Google Chrome']/container[@accessiblerole='Pane']/container[2]/container[1]", 30000, null, "5815aa92-758b-4fda-b93b-e0154e1cc9b0");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9a47568b-8bd1-45b3-a52f-227186d77b37")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9a47568b-8bd1-45b3-a52f-227186d77b37")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The Pane item.
            /// </summary>
            [RepositoryItem("5815aa92-758b-4fda-b93b-e0154e1cc9b0")]
            public virtual Ranorex.Container Pane
            {
                get
                {
                    return _paneInfo.CreateAdapter<Ranorex.Container>(true);
                }
            }

            /// <summary>
            /// The Pane item info.
            /// </summary>
            [RepositoryItemInfo("5815aa92-758b-4fda-b93b-e0154e1cc9b0")]
            public virtual RepoItemInfo PaneInfo
            {
                get
                {
                    return _paneInfo;
                }
            }
        }

        /// <summary>
        /// The UpchainAppFolder folder.
        /// </summary>
        [RepositoryFolder("d9d2dc0a-ea74-405b-8815-7426843a6845")]
        public partial class UpchainAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _buttonlogoutconfirmInfo;

            /// <summary>
            /// Creates a new Upchain  folder.
            /// </summary>
            public UpchainAppFolder(RepoGenBaseFolder parentFolder) :
                    base("Upchain", "/form[@title='Upchain']", parentFolder, 30000, null, true, "d9d2dc0a-ea74-405b-8815-7426843a6845", "")
            {
                _buttonlogoutconfirmInfo = new RepoItemInfo(this, "ButtonLogoutConfirm", "button[@text='&Yes']", "button[@text='&Yes']", 30000, null, "4226a3b0-a014-4093-8d63-0da1d6808533");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("d9d2dc0a-ea74-405b-8815-7426843a6845")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("d9d2dc0a-ea74-405b-8815-7426843a6845")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The ButtonLogoutConfirm item.
            /// </summary>
            [RepositoryItem("4226a3b0-a014-4093-8d63-0da1d6808533")]
            public virtual Ranorex.Button ButtonLogoutConfirm
            {
                get
                {
                    return _buttonlogoutconfirmInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The ButtonLogoutConfirm item info.
            /// </summary>
            [RepositoryItemInfo("4226a3b0-a014-4093-8d63-0da1d6808533")]
            public virtual RepoItemInfo ButtonLogoutConfirmInfo
            {
                get
                {
                    return _buttonlogoutconfirmInfo;
                }
            }
        }

        /// <summary>
        /// The LogInToUpchainSuccessAppFolder folder.
        /// </summary>
        [RepositoryFolder("119ffc5d-4641-4755-9fc7-0d75a6d5774e")]
        public partial class LogInToUpchainSuccessAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _msgloginsuccessfulInfo;

            /// <summary>
            /// Creates a new LogInToUpchainSuccess  folder.
            /// </summary>
            public LogInToUpchainSuccessAppFolder(RepoGenBaseFolder parentFolder) :
                    base("LogInToUpchainSuccess", "/dom[@domain='127.0.0.1:57221']", parentFolder, 30000, null, false, "119ffc5d-4641-4755-9fc7-0d75a6d5774e", "")
            {
                _msgloginsuccessfulInfo = new RepoItemInfo(this, "MsgLoginSuccessful", "body/?/?/div[@innertext>'            Login successful']", ".//div[@innertext>'            Login successful']", 30000, null, "9ad9f362-26ba-4edb-820f-5d86ecd5b1fd");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("119ffc5d-4641-4755-9fc7-0d75a6d5774e")]
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
            [RepositoryItemInfo("119ffc5d-4641-4755-9fc7-0d75a6d5774e")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The MsgLoginSuccessful item.
            /// </summary>
            [RepositoryItem("9ad9f362-26ba-4edb-820f-5d86ecd5b1fd")]
            public virtual Ranorex.DivTag MsgLoginSuccessful
            {
                get
                {
                    return _msgloginsuccessfulInfo.CreateAdapter<Ranorex.DivTag>(true);
                }
            }

            /// <summary>
            /// The MsgLoginSuccessful item info.
            /// </summary>
            [RepositoryItemInfo("9ad9f362-26ba-4edb-820f-5d86ecd5b1fd")]
            public virtual RepoItemInfo MsgLoginSuccessfulInfo
            {
                get
                {
                    return _msgloginsuccessfulInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
