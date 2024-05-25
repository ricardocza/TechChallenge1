using Moq;
using System.Data.Common;
using TechChallenge1.Core.DomainExceptions;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;
using TechChallenge1.Domain.Services;
using TechChallenge1.Infrastructure.Repository;

namespace TechChallenge.Domain.UnitTest
{
    public class ContactTests
    {
        [Theory]
        [InlineData("", "11111111111", "email@server.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 2", "", "email@gmail.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 2", "44444444444", "", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 2", "44444444444", "email@gmail.com", "")]
        public async Task CreateContact_ShouldReturnDomainException_WhenMandatoryFieldsIsEmpty(string name, string phone, string email, string stateId)
        {
            //Arrange
            Guid guidStateId = stateId == string.Empty ? Guid.Empty : new Guid(stateId);
            var contactWithNotValidEmail = new Contact() { Name = name, Phone = phone, Email = email, StateId = guidStateId };
            var mockRepository = new Mock<TechChallenge1.Domain.Interfaces.IContactRepository>();

            var contactService = new ContactService(mockRepository.Object);

            //Act
            var result = contactService.Create(contactWithNotValidEmail);

            // Assert
            Assert.Equal("Campo de preenchimento obrigat�rio.", result.Exception.InnerException.Message.ToString());
        }


        [Theory]
        [InlineData("Tester 1", "11111111111", "email", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 2", "44444444444", "email.gmail.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        public async Task CreateContact_ShouldReturnDomainException_WhenEmailIsNotValid(string name, string phone, string email, string stateId)
        {
            //Arrange
            var contactWithNotValidEmail = new Contact() { Name = name, Phone = phone, Email = email, StateId = new Guid(stateId)};
            var mockRepository = new Mock<TechChallenge1.Domain.Interfaces.IContactRepository>();

            var contactService = new ContactService(mockRepository.Object);

            //Act
            var result = contactService.Create(contactWithNotValidEmail);

            // Assert
            Assert.Equal("Informe um endere�o de e-mail v�lido. Ex.: nome@dominio.com.br", result.Exception.InnerException.Message.ToString());
        }

        [Theory]
        [InlineData("Tester 3", "1111111111G", "email@server.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 4", "22222O22222", "email@gmail.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        public async Task CreateContact_ShouldReturnDomainException_WhenPhoneFormatIsNotValid(string name, string phone, string email, string stateId)
        {
            //Arrange
            var contactWithNotValidPhone = new Contact() { Name = name, Phone = phone, Email = email, StateId = new Guid(stateId) };
            var mockRepository = new Mock<TechChallenge1.Domain.Interfaces.IContactRepository>();

            var contactService = new ContactService(mockRepository.Object);

            //Act
            var result = contactService.Create(contactWithNotValidPhone);

            // Assert
            Assert.Equal("O telefone deve conter apenas n�meros.", result.Exception.InnerException.Message.ToString());
        }

        [Theory]
        [InlineData("Tester 5", "111111111111111111", "email@server.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        [InlineData("Tester 6", "44", "email@gmail.com", "3156F34C-6E51-4CA2-A403-D7C08AF19239")]
        public async Task CreateContact_ShouldReturnDomainException_WhenPhoneLengthIsNotValid(string name, string phone, string email, string stateId)
        {
            //Arrange
            var contactWithNotValidPhone = new Contact() { Name = name, Phone = phone, Email = email, StateId = new Guid(stateId) };
            var mockRepository = new Mock<TechChallenge1.Domain.Interfaces.IContactRepository>();

            var contactService = new ContactService(mockRepository.Object);

            //Act
            var result = contactService.Create(contactWithNotValidPhone);

            // Assert
            Assert.Equal("O telefone deve conter entre 10 e 11 digitos.", result.Exception.InnerException.Message.ToString());
        }

    }
}