﻿using Abp.Localization;
using Abp.MultiTenancy;
using System.Collections.Generic;

namespace LanguageLearning.EntityFrameworkCore.Seed.Host
{
    public class DefaultLanguagesCreator
    {
        public static List<ApplicationLanguage> InitialLanguages => GetInitialLanguages();

        private readonly LanguageLearningDbContext _context;

        private static List<ApplicationLanguage> GetInitialLanguages()
        {
            var tenantId = LanguageLearningConsts.MultiTenancyEnabled ? null : (int?)MultiTenancyConsts.DefaultTenantId;
            return new List<ApplicationLanguage>
            {
                new ApplicationLanguage(tenantId, "en", "English", "famfamfam-flags us"),
                new ApplicationLanguage(tenantId, "ar", "العربية", "famfamfam-flags sa"),
                new ApplicationLanguage(tenantId, "de", "German", "famfamfam-flags de"),
                new ApplicationLanguage(tenantId, "it", "Italiano", "famfamfam-flags it"),
                new ApplicationLanguage(tenantId, "fa", "فارسی", "famfamfam-flags ir"),
                new ApplicationLanguage(tenantId, "fr", "Français", "famfamfam-flags fr"),
                new ApplicationLanguage(tenantId, "pt-BR", "Português", "famfamfam-flags br"),
                new ApplicationLanguage(tenantId, "tr", "Türkçe", "famfamfam-flags tr"),
                new ApplicationLanguage(tenantId, "ru", "Русский", "famfamfam-flags ru"),
                new ApplicationLanguage(tenantId, "zh-Hans", "简体中文", "famfamfam-flags cn"),
                new ApplicationLanguage(tenantId, "es-MX", "Español México", "famfamfam-flags mx"),
                new ApplicationLanguage(tenantId, "nl", "Nederlands", "famfamfam-flags nl"),
                new ApplicationLanguage(tenantId, "ja", "日本語", "famfamfam-flags jp")
            };
        }

        public DefaultLanguagesCreator(LanguageLearningDbContext context)
        {
            _context = context;
        }



    }
}
