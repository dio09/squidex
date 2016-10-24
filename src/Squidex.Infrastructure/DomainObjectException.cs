﻿// ==========================================================================
//  DomainObjectException.cs
//  Squidex Headless CMS
// ==========================================================================
//  Copyright (c) Squidex Group
//  All rights reserved.
// ==========================================================================

using System;

namespace Squidex.Infrastructure
{
    public class DomainObjectException : Exception
    {
        private readonly string id;
        private readonly string typeName;

        public string TypeName
        {
            get
            {
                return typeName;
            }
        }

        public string Id
        {
            get
            {
                return id;
            }
        }

        protected DomainObjectException(string message, string id, Type type)
            : this(message, id, type, null)
        {
        }

        protected DomainObjectException(string message, string id, Type type, Exception inner)
            : base(message, inner)
        {
            this.id = id;

            if (type != null)
            {
                typeName = type.Name;
            }
        }
    }
}