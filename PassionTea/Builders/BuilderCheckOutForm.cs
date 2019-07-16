using Bogus;
using PassionCore.Utilities;
using PassionTea.Enum;
using PassionTea.Objects;


namespace PassionTea.Builders
{
    class BuilderCheckOutForm 
    {
        public static ModelFormCheckOutPage BuildCheckOutDetails(CardType cardType)
        {
            var fullName = Faker.Name.FullName();
           //var cardType = CardType;
            var model = new ModelFormCheckOutPage()
            {
                EmailID = Faker.Internet.Email(fullName),
                Name = fullName,
                Address=Faker.Address.City(),
                CardType = EnumHelper.GetnumDescription(cardType),
                CardNumber = Faker.RandomNumber.Next(10000000, 99999999).ToString() + Faker.RandomNumber.Next(10000000, 99999999),
                CardHoldName = Faker.Name.FullName(),
                VerificationCode = Faker.RandomNumber.Next(100, 999)

            };
            return model;
        } 
     
    }
}
