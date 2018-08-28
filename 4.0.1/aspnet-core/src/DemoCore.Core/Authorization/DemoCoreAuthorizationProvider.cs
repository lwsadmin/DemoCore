﻿using System.IO;
using System.Xml;
using Abp.Authorization;
using Abp.Localization;
using Abp.MultiTenancy;

namespace DemoCore.Authorization
{
    public class DemoCoreAuthorizationProvider : AuthorizationProvider
    {
        public override void SetPermissions(IPermissionDefinitionContext context)
        {
            XmlDocument NavigationXml = new XmlDocument();
            string currentDirectory = Path.GetFullPath("../../src/DemoCore.Core/Localization/XmlData/Navigation.xml");

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true; //忽略注释
            XmlReader reader = XmlReader.Create(currentDirectory, settings);
            while (reader.Read())
            {
             
                     context.CreatePermission(reader.GetAttribute("PermissionName"), 
                         L(reader.GetAttribute("Name")));
            }

        }

        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, DemoCoreConsts.LocalizationSourceName);
        }
    }
}
