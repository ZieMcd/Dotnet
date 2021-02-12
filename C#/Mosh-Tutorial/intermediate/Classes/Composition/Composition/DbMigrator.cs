﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Composition
{
    class DbMigrator
    {
        private readonly Logger _logger;

        public DbMigrator(Logger logger)
        {
            _logger = logger;
        }

        public void Migrate()
        {
            _logger.Log("we are migrating");
        }
    }
}
