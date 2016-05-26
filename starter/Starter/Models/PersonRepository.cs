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
            throw new NotImplementedException("Implement GetAll with a N1QL query");
        }

        public KeyValuePair<string, Person> GetPersonByKey(string key)
        {
            throw new NotImplementedException("Implement GetPersonByKey with bucket Get");
        }

        public void Save(KeyValuePair<string, Person> model)
        {
            throw new NotImplementedException("Implement Save with bucket Upsert");
        }

        public void Delete(string key)
        {
            throw new NotImplementedException("Implement Delete with bucket Remove");
        }
    }
}