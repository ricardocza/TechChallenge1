﻿using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using TechChallenge1.Core.DomainExceptions;
using TechChallenge1.Core.DTO;
using TechChallenge1.Domain.Interfaces;
using TechChallenge1.Domain.Models;
using TechChallenge1.Domain.Validators;

namespace TechChallenge1.Domain.Services
{

    public class ContactService : IContactService
    {
        private readonly IContactRepository _contactRepository;

        public ContactService(IContactRepository contactRepository)
        {
            _contactRepository = contactRepository;
        }

        public async Task Create(Contact contact)
        {
            var contactValidator = new ContactValidator();
            var result = contactValidator.Validate(contact);

            if(!result.IsValid)
            {
                throw new DomainException(result.Errors.FirstOrDefault().ErrorMessage);
            }

            contact.State = null;
            await _contactRepository.Create(contact);
        }

        public async Task Delete(Guid id)
        {
            await _contactRepository.Delete(id);
        }

        public async Task<IEnumerable<Contact>> GetAll()
        {
            return  await _contactRepository.GetAll();
        }
        public ReturnTableDto<Contact> GetRadzenList(string filter, string order, int? skip, int? take, Expression<Func<Contact, Contact>> select)
        {
            return  _contactRepository.GetRadzenList(filter, order, skip, take, select);
        }

        public async Task<Contact> GetById(Guid id)
        {
            return await _contactRepository.GetById(id);
        }

        public async Task Update(Contact contact)
        {
            await _contactRepository.Update(contact);
        }
    }
}
