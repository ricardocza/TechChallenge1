using Moq;
using System.Data.Common;
using TechChallenge1.Core.DomainExceptions;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;
using TechChallenge1.Domain.Services;

namespace TechChallenge.Domain.UnitTest
{
    public class ContactTests
    {
        private readonly Mock<IContactRepository> _contactRepositoryMock;

        public ContactTests()
        {
            _contactRepositoryMock = new Mock<IContactRepository>();
        }
        [Fact]
        public async Task CreateContact_ShouldReturnDomainException_WhenEmailIsNotValid()
        {
            //Arrange
            var contactService = new ContactService(_contactRepositoryMock.Object);
            var contactWithNotValidEmail = new Contact()
            { Email = "test", };
            //Act

            var result =  contactService.Create(contactWithNotValidEmail);


            Assert.Equal(result.Exception.InnerException.Message, "Informe um endereço de e-mail válido. Ex.: nome@dominio.com.br");


        }
    }
}