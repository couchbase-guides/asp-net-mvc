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

        public PersonRepository(IBucket bucket)
        {
            _bucket = bucket;
        }

        public List<Person> GetAll()
        {
            throw new NotImplementedException("GetAll implementation goes here");
        }

        public Person GetPersonByKey(Guid key)
        {
            throw new NotImplementedException("GetPersonByKey implementation goes here");
        }

        public void Save(Person person)
        {
            throw new NotImplementedException("Save implementation goes here");
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException("Delete implementation goes here");
        }
    }
}