using System;
using System.Collections.Generic;
using System.Linq;
using Couchbase;
using Couchbase.Core;
using Couchbase.N1QL;

namespace Starter.Models
{
    public class PersonRepository
    {
        private readonly IBucket _bucket;

        public PersonRepository()
        {
            _bucket = ClusterHelper.GetBucket("hello-couchbase");
        }

        public Dictionary<string, Person> GetAll()
        {
            var request = QueryRequest.Create("SELECT META().id AS `key`, TOOBJECT(hc) as `value` FROM `hello-couchbase` as hc WHERE type='Person';");
            request.ScanConsistency(ScanConsistency.RequestPlus);
            var response = _bucket.Query<KeyValuePair<string, Person>>(request);
            return response.Rows.ToDictionary(x => x.Key, x => x.Value);
        }

        public KeyValuePair<string, Person> GetPersonByKey(string key)
        {
            var person = _bucket.Get<Person>(key).Value;
            return new KeyValuePair<string, Person>(key, person);
        }

        public void Save(KeyValuePair<string, Person> model)
        {
            var doc = new Document<Person>
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