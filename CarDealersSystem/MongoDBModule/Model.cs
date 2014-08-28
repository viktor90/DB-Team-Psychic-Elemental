﻿using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDBModule
{
    public class Model
    {
         [BsonId]
        public ObjectId Id { get; set; }

        public string Name { get; set; }

        public DateTime ManufacturingDate { get; set; }

        public string TypeName { get; set; }

        [BsonConstructor]
        public Model(string name, DateTime manufacturingDate, string typeName)
        {
            this.Name = name;
            this.ManufacturingDate = manufacturingDate;
            this.TypeName = typeName;
        }

        public override string ToString()
        {
            return this.Name + " " + this.ManufacturingDate + " " + this.TypeName;
        }
    }
}
