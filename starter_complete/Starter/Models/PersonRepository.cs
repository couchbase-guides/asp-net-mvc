using System;
using System.Collections.Generic;
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

        public List<Person> GetAll()
        {
            var request = QueryRequest.Create("SELECT hc.* FROM `hello-couchbase` as hc WHERE type='Person';");
            request.ScanConsistency(ScanConsistency.RequestPlus);
            var response = _bucket.Query<Person>(request);
            return response.Rows;
        }

        public Person GetPersonByKey(Guid key)
        {
            var person = _bucket.Get<Person>("Person::" + key).Value;
            return person;
        }

        public void Save(Person person)
        {
            // if there is no ID, then assume this is a "new" person
            // and assign an ID
            if (string.IsNullOrEmpty(person.Id))
                person.Id = Guid.NewGuid().ToString();

            var doc = new Document<Person>
            {
                Id = "Person::" + person.Id,
                Content = person
            };
            _bucket.Upsert(doc);
        }

        public void Delete(Guid id)
        {
            _bucket.Remove("Person::" + id);
        }
    }
}