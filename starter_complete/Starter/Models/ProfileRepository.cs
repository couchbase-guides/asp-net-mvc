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
            var request = QueryRequest.Create("SELECT META().id AS `key`, TOOBJECT(hc) as `value` FROM `hello-couchbase` as hc WHERE type='Profile';");
            request.ScanConsistency(ScanConsistency.RequestPlus);
            var response = _bucket.Query<KeyValuePair<string, Profile>>(request);
            return response.Rows.ToDictionary(x => x.Key, x => x.Value);
        }

        public KeyValuePair<string, Profile> GetProfileByKey(string key)
        {
            var profile = _bucket.Get<Profile>(key).Value;
            return new KeyValuePair<string, Profile>(key, profile);
        }

        public void Save(KeyValuePair<string, Profile> model)
        {
            var doc = new Document<Profile>
            {
                Id = model.Key,
                Content = model.Value
            };
            _bucket.Upsert(doc);
        }

        public void Delete(string key)
        {
            _bucket.Remove(key);
        }
    }
}