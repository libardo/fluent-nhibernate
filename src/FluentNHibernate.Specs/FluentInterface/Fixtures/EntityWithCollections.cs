﻿using System;
using System.Collections.Generic;
using Iesi.Collections.Generic;

namespace FluentNHibernate.Specs.FluentInterface.Fixtures
{
    class EntityWithCollections
    {
        public EntityCollectionChild[] ArrayOfChildren { get; set; }
        public IList<EntityCollectionChild> BagOfChildren { get; set; }
        public ISet<EntityCollectionChild> SetOfChildren { get; set; }

        public IList<string> BagOfStrings { get; set; }
        public int Id { get; set; }
    }

    class EntityWithFieldCollections
    {
        public IList<EntityCollectionChild> BagOfChildren;
        public int Id { get; set; }
    }

    class EntityCollectionChild
    {
        public int Position { get; set; }
    }
}