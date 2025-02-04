using System;
using System.Collections.Generic;

using AuthorizeNet.Api.Contracts.V1;
using AuthorizeNet.Api.Controllers;
using AuthorizeNet.Api.Controllers.Test;
using AuthorizeNet.Util;

using NUnit.Framework;

namespace AuthorizeNet.Api.Controllers.MockTest
{
	[TestFixture]
	public class CreateCustomerProfileFromTransactionTest : ApiCoreTestBase
	{

		[SetUp]
		public new static void SetUpBeforeClass()
		{
			ApiCoreTestBase.SetUpBeforeClass();
		}

		[TearDown]
		public new static void TearDownAfterClass()
		{
			ApiCoreTestBase.TearDownAfterClass();
		}

		[SetUp]
		public new void SetUp()
		{
			base.SetUp();
		}

		[TearDown]
		public new void TearDown()
		{
			base.TearDown();
		}

		[Test]
		public void MockcreateCustomerProfileFromTransactionTest()
		{
			//define all mocked objects as final
			var mockController = GetMockController<createCustomerProfileFromTransactionRequest, createCustomerProfileResponse>();
			var mockRequest = new createCustomerProfileFromTransactionRequest
			{
				merchantAuthentication = new merchantAuthenticationType() { name = "mocktest", Item = "mockKey", ItemElementName = ItemChoiceType.transactionKey },
				transId = CounterStr,
			};
			var mockResponse = new createCustomerProfileResponse
			{
				refId = "1234",
				sessionToken = "sessiontoken",
				customerProfileId = CounterStr,
				customerPaymentProfileIdList = new[] { CounterStr },
				customerShippingAddressIdList = new[] { CounterStr },
			};

			var errorResponse = new ANetApiResponse();
			var results = new List<String>();
			const messageTypeEnum messageTypeOk = messageTypeEnum.Ok;

			SetMockControllerExpectations<createCustomerProfileFromTransactionRequest, createCustomerProfileResponse, CreateCustomerProfileFromTransactionController>(
				mockController.MockObject, mockRequest, mockResponse, errorResponse, results, messageTypeOk);
			mockController.MockObject.Execute(Environment.CUSTOM);
			//mockController.MockObject.Execute();
			// or var controllerResponse = mockController.MockObject.ExecuteWithApiResponse(AuthorizeNet.Environment.CUSTOM);
			var controllerResponse = mockController.MockObject.GetApiResponse();
			Assert.IsNotNull(controllerResponse);

			Assert.IsNotNull(controllerResponse.customerProfileId);
			LogHelper.Info(Logger, "createCustomerProfileFromTransaction: Details:{0}", controllerResponse.customerProfileId);
		}
	}
}
