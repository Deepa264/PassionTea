using Faker;
using PassionTea.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PassionTea.Builders
{
    class BuilderFeedBackForm
    {
        public static ModelFormFeedBackPage BuildFeedbackDetails()
        {
            var fullName = Faker.Name.FullName();
            var model = new ModelFormFeedBackPage();
            {
             EmailID = Faker.Internet.Email.(fullName),
            Name = FullName,
            Subject = Faker.Lorem.Sentence(),
            Message = Faker.Lorem.Paregraph(),

            };
            return model;
        }
    }
}
