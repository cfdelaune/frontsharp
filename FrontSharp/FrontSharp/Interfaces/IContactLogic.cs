using FrontSharp.Models;
using FrontSharp.Requests;
using System.Collections.Generic;

namespace FrontSharp.Interfaces
{
    public interface IContactLogic
    {
        ListResultResponseBody<Contact> List(string q = null, string page_token = null, int? limit = null, string sort_by = null, string sort_order = null);

        Contact Get(string contactId);

        void Update(string contactId, UpdateContactRequest updateContact);

        Contact Create(CreateContactRequest contact);

        ListResultResponseBody<Conversation> ListConversations(string contactId, List<ConversationStatusFilter> statusFilter = null, int? limit = null);

        void AddHandle(string contactId, AddHandleRequest addHandle);

        void DeleteHandle(string contactId, DeleteHandleRequest deleteHandle);
    }
}