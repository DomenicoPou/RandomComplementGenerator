using CommonLibrary.Handlers;
using RandomComplementGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomComplementGenerator.Handlers
{
    public static class ComplimentHandler
    {
        private static Random random = new Random();

        /// <summary>
        /// Using complex mathamatics we are able to generate the compliment that will cure all the worlds problems.
        /// </summary>
        /// <returns>A well structured compliment</returns>
        public static string GenerateCompliment()
        {
            // Get the current configuration components
            ComplimentConfiguration config = ConfigHandler.config;
            ComplimentComponents components = ConfigHandler.components;


            string greeting = ObtainGreeting(components);

            string praise = ObtainPraise(components);

            return $"{greeting}, {praise}";
        }

        private static string ObtainPraise(ComplimentComponents components)
        {
            string result = RandomHandler.GetRandomKey(components.praiseCombinations);
            string bridge = components.Bridge[random.Next(components.Bridge.Count - 1)] + " ";
            switch (result)
            {
                case "Single":
                    return bridge + components.NormalComponents.Single[
                        random.Next(components.NormalComponents.Single.Count - 1)
                        ];

                case "Normal":
                    return components.NormalCompliments[
                        random.Next(components.NormalCompliments.Count - 1)
                        ];

                case "Combination":
                default:
                    return
                        bridge
                        + components.NormalComponents.Suffix[
                            random.Next(components.NormalComponents.Suffix.Count - 1)
                            ]
                        + components.NormalComponents.Prefix[
                            random.Next(components.NormalComponents.Prefix.Count - 1)
                            ];
            }
        }

        private static string ObtainGreeting(ComplimentComponents components)
        {
            List<string> results = new List<string>();
            if (random.Next(1) == 0) {
                int hour = DateTime.Now.Hour;
                if (hour >= 12)
                {
                    results = components.GreetingComponents.Afternoon;
                } else
                {
                    results = components.GreetingComponents.Morning;
                }
            } else
            {
                results = components.GreetingComponents.Normal; 
            }
            return results[random.Next(results.Count - 1)];
        }
    }
}
