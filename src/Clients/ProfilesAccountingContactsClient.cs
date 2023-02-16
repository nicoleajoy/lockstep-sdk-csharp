/***
 * Lockstep Platform SDK for C#
 *
 * (c) 2021-2023 Lockstep, Inc.
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * @author     Lockstep Network <support@lockstep.io>
 * @copyright  2021-2023 Lockstep, Inc.
 * @link       https://github.com/Lockstep-Network/lockstep-sdk-csharp
 */



using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using LockstepSDK.Models;


namespace LockstepSDK.Clients
{
    /// <summary>
    /// API methods related to ProfilesAccountingContacts
    /// </summary>
    public class ProfilesAccountingContactsClient
    {
        private readonly LockstepApi _client;

        /// <summary>
        /// Constructor
        /// </summary>
        public ProfilesAccountingContactsClient(LockstepApi client)
        {
            _client = client;
        }

        /// <summary>
        /// Retrieves the Accounting Profile Contact specified by this unique identifier, optionally including nested data sets.
        ///
        /// A Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of this Accounting Profile Contact</param>
        public async Task<LockstepResponse<AccountingProfileContactModel>> RetrieveAccountingProfileContact(Guid id)
        {
            var url = $"/api/v1/profiles/accounting/contacts/{id}";
            return await _client.Request<AccountingProfileContactModel>(HttpMethod.Get, url, null, null, null);
        }

        /// <summary>
        /// Delete the Accounting Profile Contact referred to by this unique identifier.
        ///
        /// An Accounting Profile Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Accounting Profile Contact to delete</param>
        public async Task<LockstepResponse<DeleteResult>> DeleteAccountingProfileContact(Guid id)
        {
            var url = $"/api/v1/profiles/accounting/contacts/{id}";
            return await _client.Request<DeleteResult>(HttpMethod.Delete, url, null, null, null);
        }

        /// <summary>
        /// Creates one or more Accounting Profile Contacts from a given model.
        ///
        /// An Accounting Profile Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// </summary>
        /// <param name="body">The Accounting Profile Contacts to create</param>
        public async Task<LockstepResponse<AccountingProfileContactModel[]>> CreateAccountingProfileContacts(AccountingProfileContactModel[] body)
        {
            var url = $"/api/v1/profiles/accounting/contacts";
            return await _client.Request<AccountingProfileContactModel[]>(HttpMethod.Post, url, null, body, null);
        }

        /// <summary>
        /// Queries Accounting Profile Contacts for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// An Accounting Profile Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: None</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<AccountingProfileContactModel>>> QueryAccountingProfileContacts(string filter = null, string include = null, string order = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/profiles/accounting/contacts/query";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (include != null) { options["include"] = include; }
            if (order != null) { options["order"] = order; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<AccountingProfileContactModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Queries Accounting Profile Contacts and Contacts for this account using the specified filtering, sorting, nested fetch, and pagination rules requested.
        ///
        /// More information on querying can be found on the [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight) page on the Lockstep Developer website.
        ///
        /// An Accounting Profile Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// A Contact contains information about a person or role within a Company. You can use Contacts to track information about who is responsible for a specific project, who handles invoices, or information about which role at a particular customer or vendor you should speak with about invoices.
        ///
        /// </summary>
        /// <param name="filter">The filter for this query. See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="order">The sort order for this query. See See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="include">To fetch additional data on this object, specify the list of elements to retrieve. Available collections: None</param>
        /// <param name="pageSize">The page size for results (default 250, maximum of 500). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        /// <param name="pageNumber">The page number for results (default 0). See [Searchlight Query Language](https://developer.lockstep.io/docs/querying-with-searchlight)</param>
        public async Task<LockstepResponse<FetchResult<AccountingProfileContactResultModel>>> QueryLinkedAccountingProfileContacts(string filter = null, string order = null, string include = null, int? pageSize = null, int? pageNumber = null)
        {
            var url = $"/api/v1/profiles/accounting/contacts/query/models";
            var options = new Dictionary<string, object>();
            if (filter != null) { options["filter"] = filter; }
            if (order != null) { options["order"] = order; }
            if (include != null) { options["include"] = include; }
            if (pageSize != null) { options["pageSize"] = pageSize; }
            if (pageNumber != null) { options["pageNumber"] = pageNumber; }
            return await _client.Request<FetchResult<AccountingProfileContactResultModel>>(HttpMethod.Get, url, options, null, null);
        }

        /// <summary>
        /// Reverses the isPrimary fields on the primary and secondary contact to reflect a swap and returns the new primary accounting profile contact model.
        ///
        /// An Accounting Profile Contact has a link to a Contact that is associated with your company&#39;s Accounting Profile. A profile has one primary contact and any number of secondary contacts.
        ///
        /// </summary>
        /// <param name="id">The unique Lockstep Platform ID number of the Accounting Profile Contact to set as primary</param>
        public async Task<LockstepResponse<AccountingProfileContactModel>> SetSecondaryContactasPrimary(Guid id)
        {
            var url = $"/api/v1/profiles/accounting/contacts/{id}/primary";
            return await _client.Request<AccountingProfileContactModel>(new HttpMethod("PATCH"), url, null, null, null);
        }
    }
}
