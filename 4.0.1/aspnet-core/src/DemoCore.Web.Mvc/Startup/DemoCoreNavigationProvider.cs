using System.IO;
using System.Reflection;
using System.Xml;
using Abp.Application.Navigation;
using Abp.Localization;
using DemoCore.Authorization;

namespace DemoCore.Web.Startup
{
    /// <summary>
    /// This class defines menus for the application.
    /// </summary>
    public class DemoCoreNavigationProvider : NavigationProvider
    {
        public override void SetNavigation(INavigationProviderContext context)
        {
            XmlDocument NavigationXml = new XmlDocument();
            //string currentDirectory = Path.GetFullPath("../../src/DemoCore.Core/Localization/XmlData/Navigation.xml");

            string[] name = Assembly.Load("DemoCore.Core").GetManifestResourceNames();
            Stream sm = Assembly.Load("DemoCore.Core").GetManifestResourceStream("DemoCore.Localization.XmlData.Navigation.xml");

            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreComments = true; //忽略注释
            XmlReader reader = XmlReader.Create(sm);// XmlReader.Create(currentDirectory, settings);

            NavigationXml.Load(reader);
            XmlNodeList List = NavigationXml.SelectNodes("//Navigation//First");
            if (List != null)
            {
                foreach (XmlNode item in List)
                {
                    MenuItemDefinition first = new MenuItemDefinition(
                        item.Attributes["Name"].Value,
                        L(item.Attributes["Name"].Value),
                        url: "",
                        icon: item.Attributes["Icon"].Value,
                        requiredPermissionName: item.Attributes["PermissionName"].Value
                        );
                    if (item.ChildNodes != null && item.ChildNodes.Count > 0)
                    {
                        foreach (XmlNode subItem in item.ChildNodes)
                        {
                            MenuItemDefinition second = new MenuItemDefinition(
                                 subItem.Attributes["Name"].Value,
                                 L(subItem.Attributes["Name"].Value),
                                 url: subItem.Attributes["Url"].Value,
                                 requiredPermissionName: subItem.Attributes["PermissionName"].Value,
                                 icon: ""
                                 );
                            first.AddItem(second);
                        }
                    }
                    context.Manager.MainMenu.AddItem(first);
                }
            }
        }
        private static ILocalizableString L(string name)
        {
            return new LocalizableString(name, DemoCoreConsts.LocalizationSourceName);
        }
    }
}
