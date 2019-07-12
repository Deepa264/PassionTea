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

                model.EmailID = Faker.Internet.Email(fullName);
                model.Name = fullName;
                model.Subject = Faker.Lorem.Sentence();
                model.Message = Faker.Lorem.Paragraph();

            };
            return model;
        }
    }
}
