﻿using Grpc.Core;

namespace BasicGrpcV4.Services;

public class ContactService(ILogger<ContactService> logger) : Contact.ContactBase
{
    public override Task<CreateContactResponse> CreateContact(CreateContactRequest request, ServerCallContext context)
    {
        // TODO: Save contact to database
        return Task.FromResult(new CreateContactResponse
        {
            ContactId = Guid.NewGuid().ToString()
        });
    }
}