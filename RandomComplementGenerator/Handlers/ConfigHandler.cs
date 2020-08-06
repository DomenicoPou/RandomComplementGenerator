using CommonLibrary.Handlers;
using RandomComplementGenerator.Models;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace RandomComplementGenerator.Handlers
{
    /// <summary>
    /// The handler used to interrface with the confighandler in the common library
    /// </summary>
    public static class ConfigHandler
    {
        public static ComplimentConfiguration config;

        public static ComplimentComponents components;

        // Used to only allow one pull of the configuration files
        private static bool firstPull = true;

        /// <summary>
        /// The config handler constructor. Used to configuree the main state of the application
        /// </summary>
        static ConfigHandler()
        {
            if (firstPull) // Only allow one pull
            {
                // Grab configuration
                config = ConfigurationHandler<ComplimentConfiguration>.ReadConfig();

                // Set the initial values
                if (config == null) config = new ComplimentConfiguration();
                if (config.howMany == null) config.howMany = 0;
                if (config.favoriteCompliments == null) config.favoriteCompliments = new List<string>();

                // Get Components
                components = new ComplimentComponents();
                Assembly assembly = typeof(ConfigHandler).Assembly;
                components.Bridge = EmbeddedJsonResourceHandler
                    .ReadEmbeddedResource<List<string>>(assembly, "BridgeData.json");
                components.GreetingComponents = EmbeddedJsonResourceHandler
                    .ReadEmbeddedResource<GreetingComponents>(assembly, "GreetingData.json");
                components.NormalCompliments = EmbeddedJsonResourceHandler
                    .ReadEmbeddedResource<List<string>>(assembly, "NormalComplimentData.json");
                components.NormalComponents = EmbeddedJsonResourceHandler
                    .ReadEmbeddedResource<NormalComponents>(assembly, "ComplimentData.json");

                firstPull = false;
            }
        }

        // Save the current configuration
        internal static void Save()
        {
            ConfigurationHandler<ComplimentConfiguration>.WriteConfig(config);
        }
    }
}
