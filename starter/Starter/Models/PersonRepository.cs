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
            throw new NotImplementedException("Write code to get all Person documents");
        }

        public Person GetPersonByKey(Guid key)
        {
            throw new NotImplementedException("Write code to get a Person document by key");
        }

        public void Save(Person person)
        {
            throw new NotImplementedException("Write code to create a new Person or update an existing Person");
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException("Write code to delete a Person given a key");
        }
    }
}