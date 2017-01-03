using System;
using ICities;
using UnityEngine;
using System.Collections;
using System.IO;
using System.Reflection;
using CSLMusicMod.UI;

namespace CSLMusicMod
{
    public class CSLMusicMod : IUserMod
    {
        public static System.Random RANDOM = new System.Random();

        public const String VersionName = "Rewrite 1.1.4.0";

        private SettingsUI m_SettingsUI;

        public string Name
        {
            get
            {
                return "CSL Music Mod";
            }
        }

        public string Description
        {
            get
            {
                return "Adds custom radio stations the game";
            }
        }

        public CSLMusicMod()
        {

        }

        public void OnSettingsUI(UIHelperBase helper)
        {
            m_SettingsUI = new SettingsUI();
            m_SettingsUI.InitializeSettingsUI(helper);
        }
    }
}

