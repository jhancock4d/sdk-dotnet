﻿using System;

using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers.Bases;

namespace AuthorizeNet.Api.Controllers
{
#pragma warning disable 1591
	public class CreateCustomerProfileTransactionController : ApiOperationBase<createCustomerProfileTransactionRequest, createCustomerProfileTransactionResponse>
	{

		public CreateCustomerProfileTransactionController(createCustomerProfileTransactionRequest apiRequest) : base(apiRequest)
		{
		}

		override protected void ValidateRequest()
		{
			var request = GetApiRequest();

			//validate required fields
			if (null == request.transaction) throw new ArgumentException("transaction cannot be null");

			//validate not-required fields
		}
	}
#pragma warning restore 1591
}