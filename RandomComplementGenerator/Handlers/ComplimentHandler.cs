using RandomComplementGenerator.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RandomComplementGenerator.Handlers
{
    public static class ComplimentHandler
    {
        
        public static string GenerateCompliment()
        {
            ComplimentConfiguration config = ConfigHandler.config;
            return $"Hello {config.name}";
        }
    }
}
