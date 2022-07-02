﻿using OWML.ModHelper;

namespace AchievementTracker.Util
{
    public interface IAchievements
    {
        void RegisterAchievement(string uniqueID, bool secret, ModBehaviour mod);
        void RegisterTranslation(string uniqueID, TextTranslation.Language language, string name, string description);
        void RegisterTranslationsFromFiles(ModBehaviour mod, string folderPath);
        void EarnAchievement(string uniqueID);
        void ShowProgressPopup(string uniqueID, int current, int final);
    }
}
