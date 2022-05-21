﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace SEDC.Oop.Class12
{
    public class Person
    {
        [XmlIgnore]
        [JsonIgnore]
        public Guid Id { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("firstName")]
        public string LastName { get; set; }

        [JsonProperty("firstName")]
        [XmlAttribute]
        public int Age { get; set; }

        public override string ToString()
        {
            return $"{FirstName} {LastName} is {Age}";
        }
    }
}
