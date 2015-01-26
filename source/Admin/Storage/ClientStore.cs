﻿using Thinktecture.IdentityServer3.Admin.WebApi.Models.Persistence;
using Thinktecture.IdentityServer3.Admin.WebApi.Models.Storage;

namespace Thinktecture.IdentityServer3.Admin.WebApi.Storage
{
	public class ClientStore : IPersistence<Client>
	{
	    private readonly IPersistence<Client> _persistence;

	    public ClientStore(IPersistence<Client> persistence)
	    {
	        _persistence = persistence;
	    }

	    public PageResult<Client> List(PagingInformation pagingInformation)
	    {
	        return _persistence.List(pagingInformation);
	    }

	    public Client Get(int key)
	    {
	        return _persistence.Get(key);
	    }

	    public void Delete(int key)
	    {
	        _persistence.Delete(key);
	    }

	    public object Add(Client entity)
	    {
	        return _persistence.Add(entity);
	    }

	    public void Update(Client entity)
	    {
	        _persistence.Update(entity);
	    }
	}
}