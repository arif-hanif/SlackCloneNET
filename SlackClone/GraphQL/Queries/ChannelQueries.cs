﻿using System;
using System.Linq;
using HotChocolate;
using HotChocolate.Types;
using SlackClone.Models;
using HotChocolate.AspNetCore.Authorization;

namespace SlackClone.GraphQL.Queries
{
    [ExtendObjectType(Name = "Query")]
    public class ChannelQueries
    {
        /// <summary>
        /// Gets all channels.
        /// </summary>
        [Authorize]
        [UseSelection]
        public IQueryable<Channel> Channels([Service] SlackCloneDbContext dbContext)
        {
            return dbContext.Channels;
        }
    }
}
