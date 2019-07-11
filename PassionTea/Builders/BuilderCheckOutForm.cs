using Bogus;
using PassionTea.Enum;
using PassionTea.Objects;
using PassionTea.Utilities;

namespace PassionTea.Builders
{
    class BuilderCheckOutForm 
    {
        public static ModelFormCheckOut BuildCheckOutDetails(CardType cardType)
        {
            var fullName = Faker.Name.FullName();
            var model = new ModelFormCheckOut();
            {
                EmailID = Faker.Internet.Email(fullName),
                Name = fullName,
                Address=Faker.Address.City(),
                CardType =EnumHelper.GetnumDescription(CardType),
                CardNumber= Faker.RandomNumber.Next(10000000,99999999).ToString()+Faker.RandomNumber.Next(10000000,99999999),
                CardHoldName = Faker.Name.FullName();
                VerificationCode=Faker.RandomNumber.Next(100,999)

            };
            return model;
        } 
     
    }
}
