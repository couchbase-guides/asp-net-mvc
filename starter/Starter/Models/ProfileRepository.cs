using System;
using System.Collections.Generic;
using System.Linq;
using Couchbase;
using Couchbase.Core;
using Couchbase.N1QL;

namespace Starter.Models
{
    public class ProfileRepository
    {
        private readonly IBucket _bucket;

        public ProfileRepository()
        {
            _bucket = ClusterHelper.GetBucket("hello-couchbase");
        }

        public Dictionary<string, Profile> GetAll()
        {
            throw new NotImplementedException("Implement GetAll with a N1QL query");
        }

        public KeyValuePair<string, Profile> GetProfileByKey(string key)
        {
            throw new NotImplementedException("Implement GetProfileByKey with bucket Get");
        }

        public void Save(KeyValuePair<string, Profile> model)
        {
            throw new NotImplementedException("Implement Save with bucket Upsert");
        }

        public void Delete(string key)
        {
            throw new NotImplementedException("Implement Delete with bucket Remove");
        }
    }
}