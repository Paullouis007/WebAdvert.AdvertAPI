using AdvertAPI.Models;
using Amazon.DynamoDBv2.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdvertAPI.Services
{
    [DynamoDBTable("Advert")]
    public class AdvertDBModel
    {
        [DynamoDBHashKey]
        public string Id { get; set; }

        [DynamoDBProperty]
        public String Title { get; set; }

        [DynamoDBProperty]
        public String Description { get; set; }

        [DynamoDBProperty]
        public double Price { get; set; }

        [DynamoDBProperty]
        public DateTime CreationDateTime { get; set; }

        [DynamoDBProperty]
        public AdvertStatus Status { get; set; }
    }
}
