﻿using System;
using System.IO;
using UnityEngine;

namespace Liminal.Platform.Experimental.Utils
{
    public static class ExperienceAppUtils
    {
        public static Byte[] ExperienceBytes(string fileName)
        {
            var buildFolder = "_Builds";
            var experienceBytes = File.ReadAllBytes($"{Application.dataPath}/{buildFolder}/{fileName}.limapp");

            return experienceBytes;
        }

        public static int AppIdFromName(string fileName)
        {
            var fileNameStrings = fileName.Split('_');
            var appId = int.Parse(fileNameStrings[1]);
            return appId;
        }
    }
}